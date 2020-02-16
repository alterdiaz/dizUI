Public Class frmRegistrasiUpdate
    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1

    Private iddept As String = ""
    Private fromParent As Boolean = False
    Public Sub New(Optional strParam As String = "")
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        iddept = strParam
        fromParent = True
        If Me.Parent Is Nothing Then
            Me.Size = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
            Me.MaximumSize = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
            Me.StartPosition = FormStartPosition.CenterScreen

            pMinimize.Visible = False
            pMaximize.Visible = False
        End If
    End Sub

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    'API functions   
    <System.Runtime.InteropServices.DllImport("user32.dll", CharSet:=System.Runtime.InteropServices.CharSet.Auto, SetLastError:=True, ExactSpelling:=True)>
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

    Private Sub pExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pExit.Click
        splashClosed = True
        Me.Dispose()
    End Sub

    Private Sub pMaximize_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pMaximize.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        ElseIf Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub pMinimize_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pMinimize.Click
        Me.WindowState = FormWindowState.Minimized
        Me.Visible = False
        Me.Hide()
    End Sub

    Private Sub pbMMX_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pMinimize.MouseDown, pMaximize.MouseDown, pExit.MouseDown
        If sender Is pExit Then
            sender.backcolor = justRead
            sender.Image = My.Resources.exit_n
        ElseIf sender Is pMaximize Then
            sender.backcolor = canWrite
            sender.Image = My.Resources.max_n
        ElseIf sender Is pMinimize Then
            sender.backcolor = canWrite
            sender.Image = My.Resources.min_n
        End If
    End Sub

    Private Sub pbMMX_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pMinimize.MouseEnter, pMaximize.MouseEnter, pExit.MouseEnter
        If sender Is pExit Then
            sender.backcolor = Color.FromArgb(206, 0, 0)
            sender.Image = My.Resources.exit_n
        ElseIf sender Is pMaximize Then
            sender.backcolor = Color.Lime
            sender.Image = My.Resources.max_n
        ElseIf sender Is pMinimize Then
            sender.backcolor = Color.Lime
            sender.Image = My.Resources.min_n
        End If
    End Sub

    Private Sub pbMMX_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pMinimize.MouseLeave, pMaximize.MouseLeave, pExit.MouseLeave
        sender.backcolor = Color.Transparent
        If sender Is pExit Then
            sender.Image = My.Resources.exit_w
        ElseIf sender Is pMaximize Then
            sender.Image = My.Resources.max_w
        ElseIf sender Is pMinimize Then
            sender.Image = My.Resources.min_w
        End If
    End Sub

    Private Sub pbMMX_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pMinimize.MouseUp, pMaximize.MouseUp, pExit.MouseUp
        If sender Is pExit Then
            sender.backcolor = Color.FromArgb(206, 0, 0)
            sender.Image = My.Resources.exit_n
        ElseIf sender Is pMaximize Then
            sender.backcolor = Color.Lime
            sender.Image = My.Resources.max_n
        ElseIf sender Is pMinimize Then
            sender.backcolor = Color.Lime
            sender.Image = My.Resources.min_n
        End If
    End Sub

    Private Sub loadLOV()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select iddepartment as id,kode as content from department where iddepartment in (select value from sys_appsetting where variable in ('IDHDDept','IDICUDept','IDVKDept','IDIRNADept','IDIRMDept','IDNICUDept','IDLabDept','IDCathDept','IDIRJDept','IDIBSDept','IDHCUDept','IDPICUDept','IDODSDept','IDRadDept','IDICCUDept','IDIGDDept','IDMCUDept') and value <>'0') order by department asc", "dept")
        cboDepartment.Properties.DataSource = sqls.dataTable("dept")
        cboDepartment.Properties.ValueMember = "id"
        cboDepartment.Properties.DisplayMember = "content"
        cboDepartment.SetEditValue(New Object() {Nothing})

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='REGSTATUS' and idgeneral<>0", "regstat")
        lueRegStatus.Properties.DataSource = sqls.dataTable("regstat")
        lueRegStatus.Properties.ValueMember = "id"
        lueRegStatus.Properties.DisplayMember = "content"
        lueRegStatus.EditValue = Nothing
    End Sub

    Dim idtranstype As New List(Of String)
    Private Sub frmRegistrasiUpdate_Load(sender As Object, e As EventArgs) Handles Me.Load
        getRegex(dbstring)

        btnNew_Click(btnNew, Nothing)
    End Sub

    Private isLoad As Boolean = False
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        RemoveHandler cboDepartment.EditValueChanged, AddressOf cboDepartment_EditValueChanged
        loadLOV()
        AddHandler cboDepartment.EditValueChanged, AddressOf cboDepartment_EditValueChanged

        If fromParent = True Then
            cboDepartment.SetEditValue(New Object() {iddept})
            cboDepartment.ReadOnly = True
        End If
    End Sub

    Private regno As String = ""
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If lueRegStatus.EditValue Is Nothing Then
            dizMsgbox("Registrasi Status belum dipilih", dizMsgboxStyle.Info, Me)
            lueRegStatus.Focus()
            Exit Sub
        End If
        Dim strreason As String = ""
        If lueRegStatus.EditValue = 2 Then
            Dim reason As New frmDeleteReason
            If reason.ShowDialog = Windows.Forms.DialogResult.OK Then
                If reason.reason.Length = 0 Then
                    dizMsgbox("Alasan hapus harus diisi", dizMsgboxStyle.Peringatan, "Peringatan", Me)
                    Exit Sub
                End If
            Else
                Exit Sub
            End If
            strreason = "DELETE NOTE : " & vbCrLf & reason.reason
        End If

        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        regno = ""
        Dim sqls As New SQLs(dbstring)
        Dim cekbool As Boolean = False
        For i As Integer = 0 To gvData.RowCount - 1
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            Dim dra As DataRow = gvData.GetDataRow(i)
            If dra.RowState = DataRowState.Modified Then
                If dra("cek") = "True" Then
                    Dim dtsqls As New dtsetSQLS(dbstring)
                    If lueRegStatus.EditValue = 2 Then 'Or lueRegStatus.EditValue = 5 Then
                        field.AddRange(New String() {"idregistrasi", "registrasistatus", "isdeleted", "deletereason", "updatedby", "updateddate", "registrasiendby", "registrasienddate"})
                        value.AddRange(New Object() {dra("idregistrasi"), lueRegStatus.EditValue, 1, strreason, userid, nowTime, userid, nowTime})

                        sqls = New SQLs(dbstring)
                        sqls.DMLQuery("update appointment set deletereason='" & strreason & "',isdeleted=1,updateddate=getdate(),updatedby='" & userid & "' where idregistrasi='" & dra("idregistrasi") & "'", False)
                        dtsqls.datasetSave("registrasi", dra("idregistrasi"), field, value, False)
                    Else
                        sqls = New SQLs(dbstring)
                        'sqls.DMLQuery("select idregistrasi from registrasi where iddepartment not in (select value from sys_appsetting where variable in ('IDRadDept','IDLabDept')) and isasesmenmedis=1 and idregistrasi='" & dra("idregistrasi") & "'", "cekasm")
                        regno = dra("registrasino")
                        'If sqls.getDataSet("cekasm") > 0 Then
                        '    field.AddRange(New String() {"idregistrasi", "registrasistatus", "updatedby", "updateddate"})
                        '    value.AddRange(New Object() {dra("idregistrasi"), lueRegStatus.EditValue, userid, nowTime})

                        '    sqls = New SQLs(dbstring)
                        '    sqls.DMLQuery("update appointment set bookingstatus=3,updateddate=getdate(),updatedby='" & userid & "' where idregistrasi='" & dra("idregistrasi") & "'", False)
                        '    dtsqls.datasetSave("registrasi", dra("idregistrasi"), field, value, False)
                        'Else
                        '    If CStr(dra("transactiontype")) <> idtranstype Then
                        '        'regno = dra("registrasino")
                        '    Else
                        field.AddRange(New String() {"idregistrasi", "registrasistatus", "updatedby", "updateddate", "registrasiendby", "registrasienddate"})
                        value.AddRange(New Object() {dra("idregistrasi"), lueRegStatus.EditValue, userid, nowTime, userid, nowTime})

                        sqls = New SQLs(dbstring)
                        sqls.DMLQuery("update appointment set bookingstatus=3,updateddate=getdate(),updatedby='" & userid & "' where idregistrasi='" & dra("idregistrasi") & "'", False)
                        dtsqls.datasetSave("registrasi", dra("idregistrasi"), field, value, False)
                        '    End If
                        'End If
                    End If
                    'Dim istype As Boolean = False
                    'For aa As Integer = 0 To idtranstype.Count - 1
                    '    If CStr(dra("transactiontype")) = idtranstype(aa) Then
                    '        istype = True
                    '    End If
                    'Next
                    'If dra("registrasino") = regno And istype = True Then
                    sqls = New SQLs(dbstring)
                    'Dim idregkamar As String = "0"
                    'sqls.DMLQuery("select idregistrasikamar from registrasikamar where idlokasi='" & dra("idlokasi") & "' and idregistrasi='" & dra("idregistrasi") & "'", "getidregkamar")
                    sqls.DMLQuery("update registrasikamar set checkout=getdate() where idlokasi=(select top 1 idlokasi from kamar where idregistrasi='" & dra("idregistrasi") & "') and idregistrasi='" & dra("idregistrasi") & "' and checkout is null", False)
                    sqls.DMLQuery("update kamar set checkin=null,statusbed=2,idregistrasi='0' where idregistrasi='" & dra("idregistrasi") & "'", False)

                    'If sqls.getDataSet("getidregkamar") > 0 Then
                    '        idregkamar = sqls.getDataSet("getidregkamar", 0, "idregistrasikamar")
                    '        MsgBox(idregkamar)
                    '        sqls.DMLQuery("select idkamar from kamar where idlokasi='" & dra("idlokasi") & "'", "getidkamar")
                    '        Dim idkamar As String = "0"
                    '        idkamar = sqls.getDataSet("getidkamar", 0, "idkamar")

                    '        dtsqls = New dtsetSQLS(dbstring)
                    '        field = New List(Of String)
                    '        value = New List(Of Object)
                    '        field.AddRange(New String() {"idkamar", "idregistrasi", "checkin", "checkout", "statusbed", "updatedby", "updateddate"})
                    '        value.AddRange(New Object() {idkamar, 0, DBNull.Value, nowTime, 2, userid, nowTime})
                    '        dtsqls.datasetSave("kamar", idkamar, field, value, False)

                    '        dtsqls = New dtsetSQLS(dbstring)
                    '        field = New List(Of String)
                    '        value = New List(Of Object)
                    '        field.AddRange(New String() {"idregistrasikamar", "idregistrasi", "checkout", "updatedby", "updateddate"})
                    '        value.AddRange(New Object() {idregkamar, dra("idregistrasi"), nowTime, userid, nowTime})
                    '        dtsqls.datasetSave("registrasikamar", idregkamar, field, value, False)
                    '    End If
                    'End If
                    cekbool = True
                End If
            End If
        Next

        Me.Cursor = Cursors.Default
        splashClosed = True

        If cekbool = True Then
            dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
            'If regno <> "" Then
            '    dizMsgbox("Satu atau lebih Registrasi belum dilakukan asesmen medis", dizMsgboxStyle.Info, Me)
            'End If

            'btnNew_Click(btnNew, Nothing)
            If fromParent = False Then
                cboDepartment_EditValueChanged(cboDepartment, Nothing)
            End If
        Else
            dizMsgbox("Tidak ada data yang disimpan", dizMsgboxStyle.Info, Me)
        End If
    End Sub

    Private Sub cboDepartment_EditValueChanged(sender As Object, e As EventArgs) Handles cboDepartment.EditValueChanged
        If cboDepartment.EditValue Is Nothing Then
            If fromParent = False Then
                iddept = ""
            End If
        Else
            If fromParent = False Then
                iddept = cboDepartment.EditValue.ToString.Replace(" ", "")
            End If
        End If
        Dim sqls As New SQLs(dbstring)
        If iddept = "" Then
            'sqls.CallSP("spRegistrasiPasienAll", "monregall")
            gcData.DataSource = Nothing
            gvData.BestFitColumns()
        Else
            sqls.DMLQuery("select idtransactiontype from transactiontype where kodetransaksi='REG' and iddepartment in ('" & iddept.Replace(",", "','") & "')", "idtranstype")
            If sqls.getDataSet("idtranstype") > 0 Then
                idtranstype.Clear()
                For i As Integer = 0 To sqls.getDataSet("idtranstype") - 1
                    idtranstype.Add(sqls.getDataSet("idtranstype", i, "idtransactiontype"))
                Next
            Else
                idtranstype.Clear()
            End If

            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"@iddept"})
            value.AddRange(New Object() {iddept})
            sqls.CallSP("spRegistrasiPasienDept", "monregall", field, value)
            gcData.DataSource = sqls.dataTable("monregall")
            gvData.BestFitColumns()
        End If
    End Sub

End Class