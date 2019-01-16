Imports System.Data
Imports System.Configuration
Public Class Form1
    Private sqlAdapt As System.Data.SqlClient.SqlDataAdapter
    Private sqltrans As System.Data.SqlClient.SqlTransaction
    Private sqlComm As New System.Data.SqlClient.SqlCommand
    Private sqlConn As New System.Data.SqlClient.SqlConnection
    Private dtset As New DataSet
    Private strConn As String

    Private Sub btnRefresh1_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Dim strConn As String = "Database=SOTH2016;Server=192.168.20.210;User Id=sa;Password=sqlsoth;Connection Timeout=15"
        Try
            sqlConn.ConnectionString = strConn
            sqlConn.Open()
        Catch ex As Exception
            sqlConn.Close()
            'MsgBox(ex.Message)
            Exit Sub
        End Try
        Try
            sqlAdapt = New System.Data.SqlClient.SqlDataAdapter("select convert(bigint,p.no_rekam_medis) as norm,replace(replace(p.rumah,' ',''),'-','') as telprumah,replace(replace(p.kantor,' ',''),'-','') as telpkantor,replace(replace(p.handphone,' ',''),'-','') as cellphone from pasien2016 p where replace(replace(p.rumah,' ',''),'-','')='' or replace(replace(p.kantor,' ',''),'-','')='' or replace(replace(p.handphone,' ',''),'-','')='' or (replace(replace(p.rumah,' ',''),'-','')='' and replace(replace(p.kantor,' ',''),'-','')='' and replace(replace(p.handphone,' ',''),'-','')='' )", strConn)
            sqlAdapt.Fill(dtset, "phone")
            sqlConn.Close()

            ListBox1.Items.Clear()
            For i As Integer = 0 To dtset.Tables("phone").Rows.Count - 1
                ListBox1.Items.Add(dtset.Tables("phone").Rows(i).Item("norm") & "|" & dtset.Tables("phone").Rows(i).Item("telprumah") & "|" & dtset.Tables("phone").Rows(i).Item("telpkantor") & "|" & dtset.Tables("phone").Rows(i).Item("cellphone"))
            Next
        Catch ex As Exception
            sqlConn.Close()
        End Try
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Dim dbstring As String = "Database=POS;Server=192.168.20.216;User Id=sa;Password=Soth2010;Connection Timeout=15"
        'Dim dbstring As String = "Database=POS;Server=127.0.0.1;User Id=sa;Password=sa;Connection Timeout=15"
        Dim norm, norumah, nokantor, nohp As String
        Dim str As String
        Dim idrm As Long = -1

        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        For i As Integer = 0 To ListBox1.Items.Count - 1
            Me.Text = i & " / " & ListBox1.Items.Count - 1

            norm = ""
            norumah = ""
            nokantor = ""
            nohp = ""

            str = ListBox1.Items(i).ToString
            norm = str.Split("|")(0)
            norumah = str.Split("|")(1)
            nokantor = str.Split("|")(2)
            nohp = str.Split("|")(3)

            'MsgBox(norm & vbCrLf & norumah & vbCrLf & nokantor & vbCrLf & nohp)
            dtsql = New dtsetSQLS(dbstring)
            dtsql.DMLQuery("select idrekammedis from rekammedis where rekammedisno=" & norm, "getid")
            idrm = dtsql.getDataSetValue("getid", 0, 0)

            If IsNumeric(nokantor) Then
                dtsql = New dtsetSQLS(dbstring)
                field = New List(Of String)
                value = New List(Of Object)
                field.Clear()
                value.Clear()

                field.AddRange(New String() {"idphone", "idcompany", "idreff", "tablereff", "phonetype", "phone", "extension", "isdeleted", "isprimary", "createdby", "createddate"})
                value.AddRange(New Object() {-1, 1, idrm, "PASIEN", 1, nokantor, 0, 0, 1, 1, Now})
                dtsql.DMLQuery("update phone set isdeleted=1,isprimary=0 where tablereff='PASIEN' and phonetype=1 and idreff=" & idrm, False)
                dtsql.datasetSave("phone", -1, field, value, False)
            End If

            If IsNumeric(norumah) Then
                dtsql = New dtsetSQLS(dbstring)
                field = New List(Of String)
                value = New List(Of Object)
                field.Clear()
                value.Clear()

                field.AddRange(New String() {"idphone", "idcompany", "idreff", "tablereff", "phonetype", "phone", "extension", "isdeleted", "isprimary", "createdby", "createddate"})
                value.AddRange(New Object() {-1, 1, idrm, "PASIEN", 2, norumah, 0, 0, 1, 1, Now})
                dtsql.DMLQuery("update phone set isdeleted=1,isprimary=0 where tablereff='PASIEN' and phonetype=2 and idreff=" & idrm, False)
                dtsql.datasetSave("phone", -1, field, value, False)
            End If

            If IsNumeric(nohp) Then
                dtsql = New dtsetSQLS(dbstring)
                field = New List(Of String)
                value = New List(Of Object)
                field.Clear()
                value.Clear()

                field.AddRange(New String() {"idphone", "idcompany", "idreff", "tablereff", "phonetype", "phone", "extension", "isdeleted", "isprimary", "createdby", "createddate"})
                value.AddRange(New Object() {-1, 1, idrm, "PASIEN", 3, nohp, 0, 0, 1, 1, Now})
                dtsql.DMLQuery("update phone set isdeleted=1,isprimary=0 where tablereff='PASIEN' and phonetype=3 and idreff=" & idrm, False)
                dtsql.datasetSave("phone", -1, field, value, False)
            End If
            Threading.Thread.Sleep(100)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dbstring As String = "Database=POS216TEST;Server=127.0.0.1;User Id=sa;Password=sa;Connection Timeout=15"
        Dim sqls As New dtsetSQLS(dbstring)
        sqls.DMLQuery("select iditem from item", "item")
        Dim kode As String = ""
        For i As Integer = 0 To sqls.getDataSetRowCount("item") - 1
            kode = sqls.getDataSetValue("item", i, "iditem")
            sqls.DMLQuery("update item set kode=replace(replace(replace(replace(convert(varchar,getdate(),121),'-',''),':',''),'.',''),' ','') where iditem='" & kode & "'", False)
            Threading.Thread.Sleep(989)
        Next
    End Sub

End Class
