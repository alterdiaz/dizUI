Public Class Form2


    Private Function HttpPOSTRequest(ByVal url As String, Optional ByVal mparam As List(Of String) = Nothing, Optional ByVal mvalue As List(Of String) = Nothing) As String
        Dim retval As String = ""
        If mparam IsNot Nothing Then
            If mparam.Count <> mvalue.Count Then
                MsgBox("List Parameter is not equal with List Value Parameter")
                Return False
                Exit Function
            End If
        End If
        Using client As New Net.WebClient
            client.Proxy = Nothing
            Dim reqparm As New Specialized.NameValueCollection
            If mparam IsNot Nothing Then
                For i As Integer = 0 To mparam.Count - 1
                    reqparm.Add(mparam(i), mvalue(i))
                Next
            End If
            Dim responsebytes = client.UploadValues(url, "POST", reqparm)
            Dim responsebody As String = (New Text.UTF8Encoding).GetString(responsebytes)
            retval = responsebody
        End Using
        Return retval
    End Function

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Dim param As New List(Of String)
        Dim value As New List(Of String)
        param.AddRange(New String() {"param", "value", "tkey1", "tkey2"})
        value.AddRange(New String() {"cekid", "380C81DE-1716-11E9-B068-28924AD3C84E", "ABF", "123"})
        'Dim webclient_server7 As New System.Net.WebClient
        Dim json_result As String = HttpPOSTRequest("http://127.0.0.1/hqdata/index.php/company", param, value)
        MsgBox(json_result)

        Try
            Dim table As DataTable = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)
            gcData.DataSource = table
        Catch ex As Exception
            MsgBox("An exception occured: " & ex.Message)
        End Try
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
    End Sub

End Class