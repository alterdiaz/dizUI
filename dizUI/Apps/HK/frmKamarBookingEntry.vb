Imports DevExpress.XtraEditors.Controls

Public Class frmKamarBookingEntry
    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1

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

    Public Sub New(iddata As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._iddata = iddata
    End Sub

    Public Property iddata() As String
        Get
            Return Me._iddata
        End Get
        Set(value As String)
            Me._iddata = value
        End Set
    End Property

    Private _iddata As String = ""
    Private Sub frmKamarBookingEntry_Load(sender As Object, e As EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        loadLOV()
        deTanggal.EditValue = New Date(nowTime.Year, nowTime.Month, nowTime.Day, nowTime.Hour, 0, 0)
        teNoRM.Text = "0"
        tePasien.EditValue = Nothing
        slueParamedis.EditValue = Nothing
        slueKelas.EditValue = Nothing
        slueKamar.EditValue = Nothing
        meDiagnosa.Text = ""
        meRencana.Text = ""

        btnNew_Click(Me, Nothing)
        If _iddata <> "" Then
            loadData(iddata)
        End If
    End Sub

    Private Sub loadData(iddata As String)
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idrekammedis,nama,dbo.fFormatNoRM(rekammedisno) as rekammedisno,diagnosa,rencana,idkelas,isnull(idlokasi,'0') as idlokasi,idparamedis,convert(varchar,bookingdate,105)+' '+convert(varchar,bookingdate,108) as bookingdate,pembayaran from bookingkelas where idbookingkelas='" & iddata & "'", "getdata")
        If sqls.getDataSet("getdata") > 0 Then
            Dim strdate As String = sqls.getDataSet("getdata", 0, "bookingdate")
            Dim bookdate As Date = Strdatetime2Datetime(strdate)
            deTanggal.EditValue = bookdate
            teNoRM.Text = sqls.getDataSet("getdata", 0, "rekammedisno")
            tePasien.EditValue = sqls.getDataSet("getdata", 0, "nama")

            slueKelas.EditValue = sqls.getDataSet("getdata", 0, "idkelas")
            slueParamedis.EditValue = sqls.getDataSet("getdata", 0, "idparamedis")
            slueKamar.EditValue = sqls.getDataSet("getdata", 0, "idlokasi")

            meDiagnosa.EditValue = sqls.getDataSet("getdata", 0, "diagnosa")
            meRencana.EditValue = sqls.getDataSet("getdata", 0, "rencana")
            tePayment.EditValue = sqls.getDataSet("getdata", 0, "pembayaran")

            deTanggal.ReadOnly = True
            teNoRM.ReadOnly = True
            tePasien.ReadOnly = True
            slueParamedis.ReadOnly = True
            slueKelas.ReadOnly = True
            meDiagnosa.ReadOnly = True
            meRencana.ReadOnly = True
            tePayment.ReadOnly = True
        End If
    End Sub

    Private Sub loadLOV()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idparamedis as id,nama as content from paramedis where paramedistype in (2,3,4,5) and isservice=1 and isdeleted=0 order by nama asc", "param")
        slueParamedis.Properties.DataSource = sqls.dataTable("param")
        slueParamedis.Properties.DisplayMember = "content"
        slueParamedis.Properties.ValueMember = "id"
        slueParamedis.EditValue = Nothing

        sqls.DMLQuery("select distinct kk.idkelas as id,k.kelas as content from kelaskamar kk left join kelas k on kk.idkelas=k.idkelas where kk.idlokasi in (select l.idlokasi from lokasi l where l.lokasitype=22 and l.iddepartment=(select value from sys_appsetting where variable='idirnadept')) order by k.kelas", "kelas")
        slueKelas.Properties.DataSource = sqls.dataTable("kelas")
        slueKelas.Properties.DisplayMember = "content"
        slueKelas.Properties.ValueMember = "id"
        slueKelas.EditValue = Nothing

        sqls.DMLQuery("select idlokasi as id,nama as content from lokasi where lokasitype=22 or idlokasi='0' order by nama", "kamar")
        slueKamar.Properties.DataSource = sqls.dataTable("kamar")
        slueKamar.Properties.DisplayMember = "content"
        slueKamar.Properties.ValueMember = "id"
        slueKamar.EditValue = Nothing
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs)
        deTanggal.EditValue = Nothing
        tePasien.EditValue = Nothing
        slueKelas.EditValue = Nothing
        slueParamedis.EditValue = Nothing
        slueKamar.EditValue = Nothing
        teNoRM.Text = "00000000"
        tePayment.EditValue = Nothing
        meDiagnosa.EditValue = Nothing
        meRencana.EditValue = Nothing
    End Sub

    Private Function cekIsian() As Boolean
        Dim cekbool As Boolean = True
        If slueKamar.EditValue Is Nothing Then cekbool = False
        Return cekbool
    End Function

    Private statdata As statusData = statusData.Baru
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cekIsian() = False Then
            dizMsgbox("Isian belum benar", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        If _iddata = "" Then
            _iddata = GenerateGUID()
            statdata = statusData.Baru
        Else
            statdata = statusData.Edit
        End If
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        Dim dtsqls As New dtsetSQLS(dbstring)
        field.AddRange(New String() {"idbookingkelas", "idlokasi", "updatedby", "updateddate"})
        value.AddRange(New Object() {iddata, slueKamar.EditValue, userid, nowTime})
        If dtsqls.datasetSave("bookingkelas", iddata, field, value, False) = True Then
            dizMsgbox("Data telah tersimpan", dizMsgboxStyle.Info, Me)
            Me.Dispose()
        End If
    End Sub

End Class