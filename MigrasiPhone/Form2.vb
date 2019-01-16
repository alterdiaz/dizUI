Public Class Form2

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Dim webclient_server7 As New System.Net.WebClient
        Dim json_result As String = webclient_server7.DownloadString("https://diznet.co.id/dizdata/30/soaptest.php/user")
        MsgBox(json_result)

        Try
            Dim table As DataTable = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)
            gcData.DataSource = table
        Catch ex As Exception
            MsgBox("An exception occured: " & ex.Message)
        End Try
    End Sub

End Class