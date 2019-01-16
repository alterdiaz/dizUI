Public Class frmImportKaryawan

    Private Sub frmImportCOA_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tboFilename.Text = ""
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ListBox1.Items.Count = 0 Then
            Exit Sub
        End If

        Dim mys As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idstaff", "idposition", "iddepartment", "idunit", "idnegara", "idpropinsi", "idkabupaten", "nik", "karyawan", "alamat", "handphone", "teleponrumah", "email", "isdeleted", "createdby", "createddate"})
        For i As Integer = 0 To ListBox1.Items.Count - 1
            Dim nik As String = ListBox1.Items(i).ToString.Split("|")(0)
            Dim nama As String = ListBox1.Items(i).ToString.Split("|")(1)

            mys = New dtsetSQLS(dbstring)
            value = New List(Of Object)
            value.Clear()
            value.AddRange(New Object() {-1, 7, 41, 2, 1, 12, 194, nik, nama, "Surabaya", "0", "0", "a@gmail.com", 0, 1, nowTime})
            mys.datasetSave("add_staff", -1, field, value, False)
        Next

    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Dim opdlg As New OpenFileDialog
        opdlg.AddExtension = False
        opdlg.AutoUpgradeEnabled = True
        opdlg.CheckFileExists = True
        opdlg.CheckPathExists = True
        opdlg.DefaultExt = "txt"
        opdlg.Filter = "Text Files (*.txt)|*.txt"
        opdlg.FilterIndex = 0
        opdlg.InitialDirectory = Application.ExecutablePath
        opdlg.Multiselect = False
        opdlg.ShowHelp = False
        opdlg.ShowReadOnly = False
        opdlg.ValidateNames = True
        opdlg.Title = "Pilih File"
        If opdlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            tboFilename.Text = opdlg.FileName
        End If
    End Sub

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        Dim arrTxt() As String = IO.File.ReadAllLines(tboFilename.Text)
        ListBox1.DataSource = arrTxt

        Dim iscek As Boolean = True
        Dim strcek As String = ""
        If ListBox1.Items.Count = 0 Then
            strcek = "Data Kosong"
            iscek = False
        End If
        If iscek = True Then
            For i As Integer = 0 To ListBox1.Items.Count - 1
                Dim arrstr() As String = ListBox1.Items(i).ToString.Split("|")
                If arrstr.Length <> 2 Then
                    strcek = "Format yang digunakan: NIK|Nama"
                    iscek = False
                    Exit For
                End If
                If System.Text.RegularExpressions.Regex.IsMatch(arrstr(0), "[A-Za-z]") = True Then
                    strcek = "NIK tidak boleh mengandung huruf"
                    iscek = False
                    Exit For
                End If
                If System.Text.RegularExpressions.Regex.IsMatch(arrstr(1), "[0-9]") = True Then
                    strcek = "Nama tidak boleh mengandung angka"
                    iscek = False
                    Exit For
                End If
                If IsNumeric(arrstr(1)) = True Then
                    strcek = "Nama tidak boleh mengandung angka"
                    iscek = False
                    Exit For
                End If
                If arrstr(0).Length > 20 Then
                    strcek = "NIK maksimal 20 karakter"
                    iscek = False
                    Exit For
                End If
                If arrstr(1).Length > 200 Then
                    strcek = "Nama maksimal 200 karakter"
                    iscek = False
                    Exit For
                End If
                Dim mys As New SQLs(dbstring)
                mys.DMLQuery("select * from add_staff where nik='" & arrstr(0) & "'", "ceknik")
                If mys.getDataSet("ceknik") > 0 Then
                    strcek = "NIK " & arrstr(0) & " sudah ada dalam data"
                    iscek = False
                    Exit For
                End If
                mys = New SQLs(dbstring)
                mys.DMLQuery("select * from add_staff where karyawan='" & arrstr(1) & "'", "ceknama")
                If mys.getDataSet("ceknama") > 0 Then
                    strcek = "Nama " & arrstr(1) & " sudah ada dalam data"
                    iscek = False
                    Exit For
                End If
            Next
        End If
        If iscek = False Then
            MsgBox("Warning:" & vbCrLf & strcek, MsgBoxStyle.Exclamation, "Peringatan")
            btnSave.Enabled = False
        Else
            btnSave.Enabled = True
        End If
    End Sub

End Class