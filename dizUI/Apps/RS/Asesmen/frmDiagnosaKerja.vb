Imports DevExpress.XtraGrid.Views.Base

Public Class frmDiagnosaKerja
    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1

    Private idreg As String = "-1"
    Private idso As String = -1
    Private unit As String = ""
    Private qtydiagutama As Long = 1
    Public Sub New(idso As String, idreg As String, unitname As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.idso = idso
        'If Me.idso = "-1" Then
        '    dizMsgbox("Assessment belum disimpan", dizMsgboxStyle.Kesalahan, Me)
        '    Me.Close()
        'End If
        Me.idreg = idreg
        If Me.idreg = "-1" Then
            dizMsgbox("Registrasi belum dipilih", dizMsgboxStyle.Kesalahan, Me)
            Me.Close()
        End If
        Me.unit = unitname
        If Me.unit = "" Then
            dizMsgbox("Unit tidak benar", dizMsgboxStyle.Kesalahan, Me)
            Me.Close()
        End If

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select value from sys_appsetting where variable='DiagnosaUtama" & Me.unit & "'", "cekset")
        If sqls.getDataSet("cekset") > 0 Then
            qtydiagutama = sqls.getDataSet("cekset", 0, "value")
        End If

        If Me.Parent Is Nothing Then
            Me.Size = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
            Me.MaximumSize = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
            Me.StartPosition = FormStartPosition.CenterScreen
        End If
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

    Private Sub loadLOV()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='ICDTYPE' and idgeneral = 3 order by idgeneral asc", "icdtype")
        lueType.Properties.DataSource = sqls.dataTable("icdtype")
        lueType.Properties.DisplayMember = "content"
        lueType.Properties.ValueMember = "id"
        lueType.EditValue = Nothing
        If sqls.getDataSet("icdtype") = 0 Then
            dizMsgbox("Jenis ICD tidak ditemukan" & vbCrLf & "Jenis ICD harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        Else
            lueType.EditValue = CLng(sqls.getDataSet("icdtype", 0, "id"))
        End If

        If lueType.EditValue IsNot Nothing Then
            sqls.DMLQuery("select idicd as id,kode,diagnosa from icd where icdtype='" & lueType.EditValue & "' order by kode asc", "kode")
            slueKode.Properties.DataSource = sqls.dataTable("kode")
            slueKode.Properties.ValueMember = "id"
            slueKode.Properties.DisplayMember = "kode"
            slueKode.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
            slueKode.EditValue = Nothing
            meDiagnosa.Text = ""
            meRemarks.Text = ""
        Else
            slueKode.Properties.DataSource = Nothing
            slueKode.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
            slueKode.EditValue = Nothing
            meDiagnosa.Text = ""
            meRemarks.Text = ""
        End If

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='JENISDIAGNOSA' order by idgeneral asc", "jenisdiagnosa")
        lueDiagnosa.Properties.DataSource = sqls.dataTable("jenisdiagnosa")
        lueDiagnosa.Properties.DisplayMember = "content"
        lueDiagnosa.Properties.ValueMember = "id"
        lueDiagnosa.EditValue = Nothing
        If sqls.getDataSet("jenisdiagnosa") = 0 Then
            dizMsgbox("Jenis Diagnosa tidak ditemukan" & vbCrLf & "lueDiagnosa harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If
    End Sub

    Private Sub loadGrid()
        Dim sqls As New SQLs(dbstring)
        If idso = "-1" Then
            sqls.DMLQuery("select d.idanalisarmdt,d.idicd,d.jenisdiagnosa,jd.generalcode as jnsdiagnosa,i.icdtype,i.kode,i.diagnosa,d.remarks,d.isdeleted,del.generalcode as statdata,it.generalcode as jenisicd from analisarmdt d left join icd i on d.idicd=i.idicd left join sys_generalcode del on d.isdeleted=del.idgeneral and del.gctype='DELETE' left join sys_generalcode it on i.icdtype=it.idgeneral and it.gctype='ICDTYPE' left join sys_generalcode jd on d.jenisdiagnosa=jd.idgeneral and jd.gctype='JENISDIAGNOSA' where d.analisarmtype=1 and d.idregistrasi='" & idreg & "' order by d.jenisdiagnosa asc,d.createddate desc", "data")
        Else
            sqls.DMLQuery("select d.idanalisarmdt,d.idicd,d.jenisdiagnosa,jd.generalcode as jnsdiagnosa,i.icdtype,i.kode,i.diagnosa,d.remarks,d.isdeleted,del.generalcode as statdata,it.generalcode as jenisicd from analisarmdt d left join icd i on d.idicd=i.idicd left join sys_generalcode del on d.isdeleted=del.idgeneral and del.gctype='DELETE' left join sys_generalcode it on i.icdtype=it.idgeneral and it.gctype='ICDTYPE' left join sys_generalcode jd on d.jenisdiagnosa=jd.idgeneral and jd.gctype='JENISDIAGNOSA' where d.analisarmtype=1 and d.idregistrasi='" & idreg & "' and d.idsoapnote='" & idso & "' order by d.jenisdiagnosa asc,d.createddate desc", "data")
        End If
        gcICD.DataSource = sqls.dataTable("data")
        gvICD.BestFitColumns()
    End Sub

    Private Sub lueType_EditValueChanged(sender As Object, e As EventArgs) Handles lueType.EditValueChanged
        If lueType.EditValue Is Nothing Then
            slueKode.Properties.DataSource = Nothing
            slueKode.EditValue = Nothing
            meDiagnosa.EditValue = Nothing
            meRemarks.EditValue = Nothing
            Exit Sub
        End If

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idicd as id,kode,diagnosa from icd where icdtype='" & lueType.EditValue & "' order by kode asc", "kode")
        slueKode.Properties.DataSource = sqls.dataTable("kode")
        slueKode.Properties.ValueMember = "id"
        slueKode.Properties.DisplayMember = "kode"
        slueKode.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        slueKode.EditValue = Nothing
        meDiagnosa.EditValue = Nothing
        meRemarks.EditValue = Nothing
    End Sub

    Private idData As String = "-1"
    Private Sub btnBaruICD_Click(sender As Object, e As EventArgs) Handles btnBaruICD.Click
        lueDiagnosa.EditValue = Nothing
        lueType.EditValue = Nothing
        slueKode.EditValue = Nothing
        meDiagnosa.EditValue = Nothing
        meRemarks.EditValue = Nothing
        btnBaruICD.Enabled = True
        btnSimpanICD.Enabled = True
        btnDeleteICD.Enabled = False
        idData = "-1"
    End Sub

    Private Sub btnSimpanICD_Click(sender As Object, e As EventArgs) Handles btnSimpanICD.Click
        Dim cek As Boolean = True
        If lueType.EditValue Is Nothing Then
            cek = False
        End If
        If slueKode.EditValue Is Nothing Then
            cek = False
        End If
        If cek = False Then
            dizMsgbox("Isian belum benar", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        Dim sqls As New SQLs(dbstring)
        If idData = "-1" Then
            sqls.DMLQuery("select idicd from analisarmdt where idicd='" & slueKode.EditValue & "' and idregistrasi='" & idreg & "'", "cekdata")
            If sqls.getDataSet("cekdata") > 0 Then
                dizMsgbox("ICD tersebut sudah ada", dizMsgboxStyle.Peringatan, Me)
                Exit Sub
            End If
        End If

        sqls.DMLQuery("select idicd from analisarmdt where analisarmtype=1 and jenisdiagnosa=1 and idregistrasi='" & idreg & "'", "cek1")
        If sqls.getDataSet("cek1") > 0 Then
            If qtydiagutama = 1 Then
                dizMsgbox("Diagnosa Utama sudah ada", dizMsgboxStyle.Peringatan, Me)
                Exit Sub
            End If
        End If
        'If idso = "-1" Then
        '    dizMsgbox("Data Soap Note disimpan terlebih dahulu", dizMsgboxStyle.Info)
        '    Exit Sub
        'End If

        sqls.DMLQuery("delete from analisarmdt where idicd='" & slueKode.EditValue & "' and idregistrasi='" & idreg & "'", False)
        iddata = GenerateGUID()

        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        Dim dtsqls As New dtsetSQLS(dbstring)
        field.AddRange(New String() {"idanalisarmdt", "idregistrasi", "analisarmtype", "idsoapnote", "jenisdiagnosa", "idicd", "remarks", "createdby"})
        value.AddRange(New Object() {iddata, idreg, 1, idso, lueDiagnosa.EditValue, slueKode.EditValue, If(meRemarks.EditValue, "-"), userid})
        dtsqls.datasetSave("analisarmdt", iddata, field, value, False)

        idData = GenerateGUID()
        field = New List(Of String)
        value = New List(Of Object)
        dtsqls = New dtsetSQLS(dbstring)
        field.AddRange(New String() {"idanalisarmdt", "idregistrasi", "analisarmtype", "idsoapnote", "jenisdiagnosa", "idicd", "remarks", "createdby"})
        value.AddRange(New Object() {iddata, idreg, 2, idso, lueDiagnosa.EditValue, slueKode.EditValue, If(meRemarks.EditValue, "-"), userid})
        dtsqls.datasetSave("analisarmdt", iddata, field, value, False)

        loadGrid()
        btnBaruICD_Click(btnBaruICD, Nothing)
    End Sub

    Private Sub btnDeleteICD_Click(sender As Object, e As EventArgs) Handles btnDeleteICD.Click
        'If idso = "-1" Then
        '    dizMsgbox("Data Soap Note disimpan terlebih dahulu", dizMsgboxStyle.Info)
        '    Exit Sub
        'End If
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idicd from analisarmdt where idanalisarmdt<>'" & iddata & "' and analisarmtype=1 and idicd='" & slueKode.EditValue & "' and idregistrasi='" & idreg & "'", "cekdata")
        If sqls.getDataSet("cekdata") > 0 Then
            dizMsgbox("ICD tersebut sudah ada", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        sqls.DMLQuery("select idicd from analisarmdt where idanalisarmdt<>'" & iddata & "' and analisarmtype=1 and jenisdiagnosa=1 and idregistrasi='" & idreg & "'", "cek1")
        If sqls.getDataSet("cek1") > 0 Then
            If qtydiagutama = 1 Then
                dizMsgbox("Diagnosa Utama sudah ada", dizMsgboxStyle.Peringatan, Me)
                Exit Sub
            End If
        End If

        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        Dim dtsqls As New dtsetSQLS(dbstring)
        field.AddRange(New String() {"idanalisarmdt", "isdeleted", "updatedby", "updateddate"})
        value.AddRange(New Object() {iddata, 1, userid, nowTime})
        dtsqls.datasetSave("analisarmdt", iddata, field, value, False)

        loadGrid()
        btnBaruICD_Click(btnBaruICD, Nothing)
    End Sub

    Private Sub frmDiagnosaKerja_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select count(idanalisarmdt) as counter from analisarmdt where analisarmtype=1 and idregistrasi='" & idreg & "' and idsoapnote=-1", "countnull")
        If sqls.getDataSet("countnull", 0, "counter") <> 0 Then
            sqls.DMLQuery("update analisarmdt set idsoapnote='" & idso & "' where analisarmtype=1 and idregistrasi='" & idreg & "' and idsoapnote=-1", False)
            sqls.DMLQuery("update analisarmdt set idsoapnote='" & idso & "' where analisarmtype=2 and idregistrasi='" & idreg & "' and idsoapnote=-1", False)
        End If
        loadLOV()
        loadGrid()
        btnBaruICD_Click(Me, Nothing)
    End Sub

    Private Sub slueKode_EditValueChanged(sender As Object, e As EventArgs) Handles slueKode.EditValueChanged
        If slueKode.EditValue Is Nothing Then
            meDiagnosa.EditValue = Nothing
            'meRemarks.EditValue = Nothing
            Exit Sub
        End If

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select diagnosa,remarks from icd where idicd='" & slueKode.EditValue & "'", "icd")
        meDiagnosa.EditValue = sqls.getDataSet("icd", 0, "diagnosa")
    End Sub

    Private Sub gvICD_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles gvICD.FocusedRowChanged
        Try
            lueDiagnosa.EditValue = Nothing
            lueType.EditValue = Nothing
            slueKode.EditValue = Nothing

            Dim dcol As DataRow = gvICD.GetDataRow(e.FocusedRowHandle)
            lueDiagnosa.EditValue = dcol("jenisdiagnosa")
            lueType.EditValue = dcol("icdtype")
            slueKode.EditValue = dcol("idicd")
            meRemarks.EditValue = dcol("remarks")
            iddata = dcol("idanalisarmdt")

            Dim isdeleted As Integer = dcol("isdeleted")
            If isdeleted = 1 Then
                btnDeleteICD.Text = "AKTIF"
            Else
                btnDeleteICD.Text = "HAPUS"
            End If

            btnBaruICD.Enabled = True
            btnDeleteICD.Enabled = True
        Catch ex As Exception
            btnBaruICD_Click(Me, Nothing)
        End Try
    End Sub

    Private Sub gvICD_FocusedColumnChanged(sender As Object, e As FocusedColumnChangedEventArgs) Handles gvICD.FocusedColumnChanged
        If gvICD.RowCount = 1 Then
            Try
                lueDiagnosa.EditValue = Nothing
                lueType.EditValue = Nothing
                slueKode.EditValue = Nothing

                Dim dcol As DataRow = gvICD.GetDataRow(0)
                lueDiagnosa.EditValue = dcol("jenisdiagnosa")
                lueType.EditValue = dcol("icdtype")
                slueKode.EditValue = dcol("idicd")
                meRemarks.EditValue = dcol("remarks")
                iddata = dcol("idanalisarmdt")

                Dim isdeleted As Integer = dcol("isdeleted")
                If isdeleted = 1 Then
                    btnDeleteICD.Text = "AKTIF"
                Else
                    btnDeleteICD.Text = "HAPUS"
                End If

                btnBaruICD.Enabled = True
                btnDeleteICD.Enabled = True
            Catch ex As Exception
                btnBaruICD_Click(Me, Nothing)
            End Try
        End If
    End Sub

End Class