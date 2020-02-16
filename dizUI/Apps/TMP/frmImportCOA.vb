Public Class frmImportCOA

    Private Sub frmImportCOA_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim arrTxt() As String = IO.File.ReadAllLines("D:\Developer\Project\PDAB\Dokumen\coa.txt")
        ListBox1.DataSource = arrTxt
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ListBox1.Items.Count = 0 Then
            Exit Sub
        End If
        Dim mys As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idcoa", "tipecoa", "coa", "remarks", "posisidk", "isdeleted", "createdby", "createddate"})
        For i As Integer = 0 To ListBox1.Items.Count - 1
            Dim idtmp As String = GenerateGUID()
            mys = New dtsetSQLS(dbstring)
            value = New List(Of Object)
            value.Clear()
            Dim strcoa As String = ListBox1.Items(i).ToString.Split("|")(0).Replace(".", "")
            Dim strremarks As String = ListBox1.Items(i).ToString.Split("|")(1)
            value.AddRange(New Object() {idtmp, 1, strcoa, strremarks, 0, 0, 1, nowTime})
            mys.datasetSave("coa", idtmp, field, value, False)
        Next

    End Sub
End Class