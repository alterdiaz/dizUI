Public Class frmAppPDABSetting
    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1

    'API functions   
    <System.Runtime.InteropServices.DllImport("user32.dll", CharSet:=System.Runtime.InteropServices.CharSet.Auto, SetLastError:=True, ExactSpelling:=True)> _
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    Private Sub lblTitle_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitle.MouseDown
        'This code can be used in the MouseDown event of any control(s) you want to be able to move your form with   
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0&)
    End Sub

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

    Private Sub frmAppSetting_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim mys As New SQLs(dbstring)
        mys.DMLQuery("select idbank as id,bank as content from bank order by idbank asc", "bankkas")
        lueBankKas.Properties.DataSource = mys.dataTable("bankkas")
        lueBankKas.Properties.DisplayMember = "content"
        lueBankKas.Properties.ValueMember = "id"

        mys.DMLQuery("select idstaff as id,nama as content from staff order by nama asc", "idsys")
        lueSystem.Properties.DataSource = mys.dataTable("idsys")
        lueSystem.Properties.DisplayMember = "content"
        lueSystem.Properties.ValueMember = "id"

        mys.DMLQuery("select idstaff as id,nama as content from staff order by nama asc", "kabkeu")
        lueKabidKeu.Properties.DataSource = mys.dataTable("kabkeu")
        lueKabidKeu.Properties.DisplayMember = "content"
        lueKabidKeu.Properties.ValueMember = "id"

        mys.DMLQuery("select idstaff as id,nama as content from staff order by nama asc", "dirkeu")
        lueDirKeu.Properties.DataSource = mys.dataTable("dirkeu")
        lueDirKeu.Properties.DisplayMember = "content"
        lueDirKeu.Properties.ValueMember = "id"

        mys.DMLQuery("select idstaff as id,nama as content from staff order by nama asc", "dirut")
        lueDirut.Properties.DataSource = mys.dataTable("dirut")
        lueDirut.Properties.DisplayMember = "content"
        lueDirut.Properties.ValueMember = "id"

        mys.DMLQuery("select idstaff as id,nama as content from staff order by nama asc", "nonkas")
        lueNonKas.Properties.DataSource = mys.dataTable("nonkas")
        lueNonKas.Properties.DisplayMember = "content"
        lueNonKas.Properties.ValueMember = "id"

        mys.DMLQuery("select idstaff as id,nama as content from staff order by nama asc", "kas")
        lueKas.Properties.DataSource = mys.dataTable("kas")
        lueKas.Properties.DisplayMember = "content"
        lueKas.Properties.ValueMember = "id"

        mys.DMLQuery("select value from sys_appsetting where variable='idbankkas'", "idbankkas")
        lueBankKas.EditValue = CStr(mys.getDataSet("idbankkas", 0, "value"))
        mys.DMLQuery("select value from sys_appsetting where variable='idsystem'", "idsystem")
        lueSystem.EditValue = CStr(mys.getDataSet("idsystem", 0, "value"))
        mys.DMLQuery("select value from sys_appsetting where variable='idkabidkeuangan'", "idkabidkeuangan")
        lueKabidKeu.EditValue = CStr(mys.getDataSet("idkabidkeuangan", 0, "value"))
        mys.DMLQuery("select value from sys_appsetting where variable='iddirekturkeuangan'", "iddirekturkeuangan")
        lueDirKeu.EditValue = CStr(mys.getDataSet("iddirekturkeuangan", 0, "value"))
        mys.DMLQuery("select value from sys_appsetting where variable='iddirekturutama'", "iddirekturutama")
        lueDirut.EditValue = CStr(mys.getDataSet("iddirekturutama", 0, "value"))
        mys.DMLQuery("select value from sys_appsetting where variable='ppubnonkas'", "ppubnonkas")
        lueNonKas.EditValue = CStr(mys.getDataSet("ppubnonkas", 0, "value"))
        mys.DMLQuery("select value from sys_appsetting where variable='ppubkas'", "ppubkas")
        lueKas.EditValue = CStr(mys.getDataSet("ppubkas", 0, "value"))
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If dizmsgbox("Melanjutkan untuk menyimpan setting ?", dizMsgboxStyle.konfirmasi, Me) = dizMsgboxValue.OK Then
            Dim mys As New SQLs(dbstring)
            mys.DMLQuery("delete from sys_appsetting where variable in ('IDBankKas','IDSystem','IDKabidKeuangan','IDDirekturKeuangan','IDDirekturUtama','PPUBNonKas','PPUBKas')", False)

            Dim sqls As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)

            field.AddRange(New String() {"idappsetting", "variable", "value"})

            Dim idtmp As String = GenerateGUID()
            sqls = New dtsetSQLS(dbstring)
            value.Clear()
            value.AddRange(New Object() {idtmp, "IDBankKas", lueBankKas.EditValue})
            sqls.datasetSave("sys_AppSetting", idtmp, field, value, False)

            idtmp = GenerateGUID()
            sqls = New dtsetSQLS(dbstring)
            value.Clear()
            value.AddRange(New Object() {idtmp, "IDSystem", lueSystem.EditValue})
            sqls.datasetSave("sys_AppSetting", idtmp, field, value, False)

            idtmp = GenerateGUID()
            sqls = New dtsetSQLS(dbstring)
            value.Clear()
            value.AddRange(New Object() {idtmp, "IDKabidKeuangan", lueKabidKeu.EditValue})
            sqls.datasetSave("sys_AppSetting", idtmp, field, value, False)

            idtmp = GenerateGUID()
            sqls = New dtsetSQLS(dbstring)
            value.Clear()
            value.AddRange(New Object() {idtmp, "IDDirekturKeuangan", lueDirKeu.EditValue})
            sqls.datasetSave("sys_AppSetting", idtmp, field, value, False)

            idtmp = GenerateGUID()
            sqls = New dtsetSQLS(dbstring)
            value.Clear()
            value.AddRange(New Object() {idtmp, "IDDirekturUtama", lueDirut.EditValue})
            sqls.datasetSave("sys_AppSetting", idtmp, field, value, False)

            idtmp = GenerateGUID()
            sqls = New dtsetSQLS(dbstring)
            value.Clear()
            value.AddRange(New Object() {idtmp, "PPUBNonKas", lueNonKas.EditValue})
            sqls.datasetSave("sys_AppSetting", idtmp, field, value, False)

            idtmp = GenerateGUID()
            sqls = New dtsetSQLS(dbstring)
            value.Clear()
            value.AddRange(New Object() {idtmp, "PPUBKas", lueKas.EditValue})
            sqls.datasetSave("sys_AppSetting", idtmp, field, value, False)

            dizMsgbox("Setting telah tersimpan", dizMsgboxStyle.info, Me)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Dispose()
        End If
    End Sub

End Class
