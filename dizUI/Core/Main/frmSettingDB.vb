Public Class frmSettingDB
    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1

    'API functions   
    <System.Runtime.InteropServices.DllImport("user32.dll", CharSet:=System.Runtime.InteropServices.CharSet.Auto, SetLastError:=True, ExactSpelling:=True)> _
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    Private Sub lblTitle_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitle.MouseDown
        'This code can be used in the MouseDown event of any control(s) you want to be able to move your form with   
        'If Me.WindowState = FormWindowState.Normal Then
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0&)
        'End If
    End Sub

    Private Sub frmSettingDB_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ds As New DataSet
        Dim dttbl As New DataTable("dbtype")
        Dim dc As New DataColumn

        dc.Caption = "ID"
        dc.ColumnName = "id"
        dc.DataType = GetType(String)
        dttbl.Columns.Add(dc)
        dc = New DataColumn

        dc.Caption = "Jenis Database"
        dc.ColumnName = "content"
        dc.DataType = GetType(String)
        dttbl.Columns.Add(dc)

        Dim dr As DataRow
        dr = dttbl.NewRow
        dr("id") = "SQLS"
        dr("content") = "SQL Server"
        dttbl.Rows.Add(dr)

        dr = dttbl.NewRow
        dr("id") = "MYS"
        dr("content") = "MySQL Server"
        dttbl.Rows.Add(dr)
        ds.Tables.Add(dttbl)

        lueDBtype.Properties.DataSource = ds.Tables("dbtype")
        lueDBtype.Properties.ValueMember = "id"
        lueDBtype.Properties.DisplayMember = "content"
        lueDBtype.EditValue = Nothing

        tboDBname.Text = ""
        tboDBname.Properties.MaxLength = 500
        tboDBport.Text = 0
        tboDBport.Properties.MaxLength = 5
        tboDBpwd.Text = ""
        tboDBpwd.Properties.MaxLength = 100
        tboDBsvr.Text = ""
        tboDBsvr.Properties.MaxLength = 15
        tboDBuid.Text = ""
        tboDBuid.Properties.MaxLength = 100
        tboSkema.Text = ""
        tboSkema.Properties.MaxLength = 500
        tboInstance.Text = ""
        tboInstance.Properties.MaxLength = 100

        Dim lite As New SQLi(dblite)
        lite.DMLQuery("select iddbconn,databasename,ipserver,instance,port,schema,username,password,dbtype from dbconn where dblocation='SERVER'", "getdbstring")
        If lite.getDataSet("getdbstring") > 0 Then
            idData = lite.getDataSet("getdbstring", 0, "iddbconn")
            tboDBname.Text = lite.getDataSet("getdbstring", 0, "databasename")
            tboDBport.Text = lite.getDataSet("getdbstring", 0, "port")
            tboDBpwd.Text = lite.getDataSet("getdbstring", 0, "password")
            tboDBsvr.Text = lite.getDataSet("getdbstring", 0, "ipserver")
            tboDBuid.Text = lite.getDataSet("getdbstring", 0, "username")
            lueDBtype.EditValue = lite.getDataSet("getdbstring", 0, "dbtype")
            tboSkema.Text = lite.getDataSet("getdbstring", 0, "schema")
            tboInstance.Text = lite.getDataSet("getdbstring", 0, "instance")
        Else
            idData = "-1"
        End If
    End Sub

    Private Sub tboport_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboDBport.KeyPress
        If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, "[0-9]") = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub tboDBsvr_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tboDBsvr.Click
        'tboDBsvr.SelectionStart = tboDBsvr.Text.Length
    End Sub

    Private Sub tboDBsvr_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tboDBsvr.GotFocus
        'tboDBsvr.SelectionStart = tboDBsvr.Text.Length
    End Sub

    Private Sub tboDBsvr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tboDBsvr.KeyDown
        'If e.KeyData = Keys.Down Or e.KeyData = Keys.Up Or e.KeyData = Keys.Left Or e.KeyData = Keys.Right Then
        '    tboDBsvr.SelectionStart = tboDBsvr.Text.Length
        'End If
    End Sub

    Private Sub tboDBsvr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboDBsvr.KeyPress
        'If tboDBsvr.Text <> "" Then
        '    If tboDBsvr.Text.Split(".").Length = 4 Then
        '        If tboDBsvr.Text.Split(".")(tboDBsvr.Text.Split(".").Length - 1).Length < 3 Then
        '            If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, "[0-9]") = False And Asc(e.KeyChar) <> 8 Then
        '                e.Handled = True
        '            End If
        '        Else
        '            If Asc(e.KeyChar) <> 8 Then
        '                e.Handled = True
        '            End If
        '        End If
        '    Else
        '        If tboDBsvr.Text.Split(".")(tboDBsvr.Text.Split(".").Length - 1).Length > 0 And tboDBsvr.Text.Split(".")(tboDBsvr.Text.Split(".").Length - 1).Length < 3 Then
        '            If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, "[0-9.]") = False And Asc(e.KeyChar) <> 8 Then
        '                e.Handled = True
        '            End If
        '        ElseIf tboDBsvr.Text.Split(".")(tboDBsvr.Text.Split(".").Length - 1).Length = 0 And tboDBsvr.Text.Split(".")(tboDBsvr.Text.Split(".").Length - 1).Length < 3 Then
        '            If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, "[0-9]") = False And Asc(e.KeyChar) <> 8 Then
        '                e.Handled = True
        '            End If
        '        Else
        '            If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, "[.]") = False And Asc(e.KeyChar) <> 8 Then
        '                e.Handled = True
        '            End If
        '        End If
        '    End If
        'Else
        '    If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, "[0-9]") = False And Asc(e.KeyChar) <> 8 Then
        '        e.Handled = True
        '    End If
        'End If
    End Sub

    Private statData As statusData = statusData.Baru
    Private idData As Long = -1

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If checkEntry() = False Then
            dizmsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.peringatan, Me)
            Exit Sub
        End If
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        Dim iset As New dtsetSQLI(dblite)
        field.AddRange(New String() {"iddbconn", "databasename", "ipserver", "schema", "instance", "port", "username", "password", "dbtype", "dblocation"})
        value.AddRange(New String() {idData, tboDBname.Text, tboDBsvr.Text, tboSkema.Text, tboInstance.Text, tboDBport.Text, tboDBuid.Text, tboDBpwd.Text, lueDBtype.EditValue, "SERVER"})
        If iset.datasetSave("dbconn", idData, field, value, False) = True Then
            dizMsgbox("Silahkan restart aplikasi ini", dizMsgboxStyle.Info, Me)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Dispose()
        End If
    End Sub

    Private Function checkEntry() As Boolean
        Dim retval As Boolean = True
        If tboDBname.Text = "" Then retval = False
        If tboDBsvr.Text = "" Then retval = False
        If tboDBport.Text = "" Then retval = False
        If tboDBuid.Text = "" Then retval = False
        If tboDBpwd.Text = "" Then retval = False
        If lueDBtype.EditValue Is Nothing Then retval = False
        If lueDBtype.EditValue = "SQLS" Then
            If tboSkema.Text = "" Then retval = False
        End If

        'If tboDBsvr.Text.Contains(".") = True Then
        '    retval = True
        'End If
        If tboDBsvr.Text.Contains(".") = True Then
            If tboDBsvr.Text.Split(".").Length <> 4 Then retval = False
        End If
        If tboDBport.Text <> "" Then
            If CInt(tboDBport.Text) > 65536 Then retval = False
            If CInt(tboDBport.Text) < 0 Then retval = False
        End If
        Return retval
    End Function

    Private Sub pExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pExit.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Dispose()
    End Sub

    Private Sub pbMMX_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pExit.MouseDown
        If sender Is pExit Then
            sender.backcolor = justRead
            sender.Image = My.Resources.exit_n
        End If
    End Sub

    Private Sub pbMMX_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pExit.MouseEnter
        If sender Is pExit Then
            sender.backcolor = Color.FromArgb(206, 0, 0)
            sender.Image = My.Resources.exit_n
        End If
    End Sub

    Private Sub pbMMX_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pExit.MouseLeave
        sender.backcolor = Color.Transparent
        If sender Is pExit Then
            sender.Image = My.Resources.exit_w
        End If
    End Sub

    Private Sub pbMMX_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pExit.MouseUp
        If sender Is pExit Then
            sender.backcolor = Color.FromArgb(206, 0, 0)
            sender.Image = My.Resources.exit_n
        End If
    End Sub

End Class