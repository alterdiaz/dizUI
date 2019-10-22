Imports System.Runtime.InteropServices
Imports System.Runtime.CompilerServices
Imports System.Globalization
Imports Newtonsoft.Json

Public Class TypeInferringDataTableConverter
    Inherits Newtonsoft.Json.Converters.DataTableConverter

    Public Overrides Function ReadJson(ByVal reader As JsonReader, ByVal objectType As Type, ByVal existingValue As Object, ByVal serializer As JsonSerializer) As Object
        If reader.TokenType = JsonToken.Null Then
            Return Nothing
        End If

        Dim dt As DataTable = TryCast(existingValue, DataTable)

        If dt Is Nothing Then
            dt = If((objectType = GetType(DataTable)), New DataTable(), CType(Activator.CreateInstance(objectType), DataTable))
        End If

        If reader.TokenType = JsonToken.PropertyName Then
            dt.TableName = CStr(reader.Value)
            reader.ReadAndAssert()

            If reader.TokenType = JsonToken.Null Then
                Return dt
            End If
        End If

        If reader.TokenType <> JsonToken.StartArray Then
            Throw JsonSerializationExceptionHelper.Create(reader, "Unexpected JSON token when reading DataTable. Expected StartArray, got {0}.".FormatWith(CultureInfo.InvariantCulture, reader.TokenType))
        End If

        reader.ReadAndAssert()
        Dim ambiguousColumnTypes = New HashSet(Of String)()

        While reader.TokenType <> JsonToken.EndArray
            CreateRow(reader, dt, serializer, ambiguousColumnTypes)
            reader.ReadAndAssert()
        End While

        Return dt
    End Function

    Private Shared Sub CreateRow(ByVal reader As JsonReader, ByVal dt As DataTable, ByVal serializer As JsonSerializer, ByVal ambiguousColumnTypes As HashSet(Of String))
        Dim dr As DataRow = dt.NewRow()
        reader.ReadAndAssert()

        While reader.TokenType = JsonToken.PropertyName
            Dim columnName As String = CStr(reader.Value)
            reader.ReadAndAssert()
            Dim column As DataColumn = dt.Columns(columnName)

            If column Is Nothing Then
                Dim isAmbiguousType As Boolean
                Dim columnType As Type = GetColumnDataType(reader, isAmbiguousType)
                column = New DataColumn(columnName, columnType)
                dt.Columns.Add(column)
                If isAmbiguousType Then ambiguousColumnTypes.Add(columnName)
            ElseIf ambiguousColumnTypes.Contains(columnName) Then
                Dim isAmbiguousType As Boolean
                Dim newColumnType As Type = GetColumnDataType(reader, isAmbiguousType)
                If Not isAmbiguousType Then ambiguousColumnTypes.Remove(columnName)

                If newColumnType <> column.DataType Then
                    column = ReplaceColumn(dt, column, newColumnType, serializer)
                End If
            End If

            If column.DataType = GetType(DataTable) Then

                If reader.TokenType = JsonToken.StartArray Then
                    reader.ReadAndAssert()
                End If

                Dim nestedDt As DataTable = New DataTable()
                Dim nestedUnknownColumnTypes = New HashSet(Of String)()

                While reader.TokenType <> JsonToken.EndArray
                    CreateRow(reader, nestedDt, serializer, nestedUnknownColumnTypes)
                    reader.ReadAndAssert()
                End While

                dr(columnName) = nestedDt
            ElseIf column.DataType.IsArray AndAlso column.DataType <> GetType(Byte()) Then

                If reader.TokenType = JsonToken.StartArray Then
                    reader.ReadAndAssert()
                End If

                Dim o As List(Of Object) = New List(Of Object)()

                While reader.TokenType <> JsonToken.EndArray
                    o.Add(reader.Value)
                    reader.ReadAndAssert()
                End While

                Dim destinationArray As Array = Array.CreateInstance(column.DataType.GetElementType(), o.Count)
                Array.Copy(o.ToArray(), destinationArray, o.Count)
                dr(columnName) = destinationArray
            Else
                Dim columnValue As Object = If((reader.Value IsNot Nothing), If(serializer.Deserialize(reader, column.DataType), DBNull.Value), DBNull.Value)
                dr(columnName) = columnValue
            End If

            reader.ReadAndAssert()
        End While

        dr.EndEdit()
        dt.Rows.Add(dr)
    End Sub

    Private Shared Function RemapValue(ByVal oldValue As Object, ByVal newType As Type, ByVal serializer As JsonSerializer) As Object
        If oldValue Is Nothing Then Return Nothing
        If oldValue = DBNull.Value Then Return oldValue
        Dim jtoken As Newtonsoft.Json.Linq.JToken
#Disable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
        Return jtoken.FromObject(oldValue, serializer).ToObject(newType, serializer)
#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
    End Function

    Private Shared Function ReplaceColumn(ByVal dt As DataTable, ByVal column As DataColumn, ByVal newColumnType As Type, ByVal serializer As JsonSerializer) As DataColumn
        Dim newValues = Enumerable.Range(0, dt.Rows.Count).[Select](Function(i) dt.Rows(i)).[Select](Function(r) RemapValue(r(column), newColumnType, serializer)).ToList()
        Dim ordinal = column.Ordinal
        Dim name = column.ColumnName
        Dim [namespace] = column.[Namespace]
        Dim newColumn = New DataColumn(name, newColumnType)
        newColumn.[Namespace] = [namespace]
        dt.Columns.Remove(column)
        dt.Columns.Add(newColumn)
        newColumn.SetOrdinal(ordinal)

        For i As Integer = 0 To dt.Rows.Count - 1
            dt.Rows(i)(newColumn) = newValues(i)
        Next

        Return newColumn
    End Function

    Private Shared Function GetColumnDataType(ByVal reader As JsonReader, <Out> ByRef isAmbiguous As Boolean) As Type
        Dim tokenType As JsonToken = reader.TokenType

        Select Case tokenType
            Case JsonToken.Integer, JsonToken.Boolean, JsonToken.Float, JsonToken.String, JsonToken.Date, JsonToken.Bytes
                isAmbiguous = False
                Return reader.ValueType
            Case JsonToken.Null, JsonToken.Undefined
                isAmbiguous = True
                Return GetType(String)
            Case JsonToken.StartArray
                reader.ReadAndAssert()

                If reader.TokenType = JsonToken.StartObject Then
                    isAmbiguous = False
                    Return GetType(DataTable)
                Else
                    isAmbiguous = False
                    Dim innerAmbiguous As Boolean
                    Dim arrayType As Type = GetColumnDataType(reader, innerAmbiguous)
                    Return arrayType.MakeArrayType()
                End If

            Case Else
                Throw JsonSerializationExceptionHelper.Create(reader, "Unexpected JSON token when reading DataTable: {0}".FormatWith(CultureInfo.InvariantCulture, tokenType))
        End Select
    End Function
End Class

Friend Module JsonSerializationExceptionHelper
    <Extension()>
    Function Create(ByVal reader As JsonReader, ByVal format As String, ParamArray args As Object()) As JsonSerializationException
        Dim lineInfo = TryCast(reader, IJsonLineInfo)
        Dim path = (If(reader Is Nothing, Nothing, reader.Path))
        Dim message = String.Format(CultureInfo.InvariantCulture, format, args)

        If Not message.EndsWith(Environment.NewLine, StringComparison.Ordinal) Then
            message = message.Trim()
            If Not message.EndsWith(".", StringComparison.Ordinal) Then message += "."
            message += " "
        End If

        message += String.Format(CultureInfo.InvariantCulture, "Path '{0}'", path)
        If lineInfo IsNot Nothing AndAlso lineInfo.HasLineInfo() Then message += String.Format(CultureInfo.InvariantCulture, ", line {0}, position {1}", lineInfo.LineNumber, lineInfo.LinePosition)
        message += "."
        Return New JsonSerializationException(message)
    End Function
End Module

Friend Module StringUtils
    <Extension()>
    Function FormatWith(ByVal format As String, ByVal provider As IFormatProvider, ByVal arg0 As Object) As String
        Return format.FormatWith(provider, {arg0})
    End Function

    <Extension()>
    Private Function FormatWith(ByVal format As String, ByVal provider As IFormatProvider, ParamArray args As Object()) As String
        Return String.Format(provider, format, args)
    End Function
End Module

Friend Module JsonReaderExtensions
    <Extension()>
    Sub ReadAndAssert(ByVal reader As JsonReader)
        If reader Is Nothing Then Throw New ArgumentNullException("reader")

        If Not reader.Read() Then
            Throw JsonSerializationExceptionHelper.Create(reader, "Unexpected end when reading JSON.")
        End If
    End Sub
End Module
