<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAppointment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tlpForm = New System.Windows.Forms.TableLayoutPanel()
        Me.pTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pMinimize = New System.Windows.Forms.PictureBox()
        Me.pMaximize = New System.Windows.Forms.PictureBox()
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.pBody = New System.Windows.Forms.Panel()
        Me.tlpAppointment = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlKanan = New System.Windows.Forms.Panel()
        Me.pnlPasienSesi = New System.Windows.Forms.Panel()
        Me.tlpPasienSesi = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpScheduleDate = New System.Windows.Forms.TableLayoutPanel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnRefreshSlot = New System.Windows.Forms.Button()
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.tlpJadwalSesi = New System.Windows.Forms.TableLayoutPanel()
        Me.lueJadwalSesi = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.gcSlot = New DevExpress.XtraEditors.GroupControl()
        Me.pnlSlot = New System.Windows.Forms.Panel()
        Me.tlpSlot = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlInfoSlot = New System.Windows.Forms.Panel()
        Me.lblcContentSlot = New System.Windows.Forms.Label()
        Me.lblcTitleSlot = New System.Windows.Forms.Label()
        Me.pbcIconSlot = New System.Windows.Forms.PictureBox()
        Me.gcDataPasien = New DevExpress.XtraEditors.GroupControl()
        Me.xtccPatientData = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpPasienLama = New DevExpress.XtraTab.XtraTabPage()
        Me.tlpPasienLama = New System.Windows.Forms.TableLayoutPanel()
        Me.teLamaRemarks = New DevExpress.XtraEditors.TextEdit()
        Me.slueLamaNama = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.slueView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.teLamaAlamat = New DevExpress.XtraEditors.MemoEdit()
        Me.lueLamaNoRM = New DevExpress.XtraEditors.LookUpEdit()
        Me.teLamaTelepon2 = New DevExpress.XtraEditors.TextEdit()
        Me.teLamaTelepon1 = New DevExpress.XtraEditors.TextEdit()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.teLamaJenisKelamin = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.teLamaTanggalLahir = New DevExpress.XtraEditors.TextEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.xtpPasienBaru = New DevExpress.XtraTab.XtraTabPage()
        Me.tlpPasienBaru = New System.Windows.Forms.TableLayoutPanel()
        Me.teBaruRemarks = New DevExpress.XtraEditors.TextEdit()
        Me.deBaruTanggalLahir = New DevExpress.XtraEditors.DateEdit()
        Me.lueBaruJenisKelamin = New DevExpress.XtraEditors.LookUpEdit()
        Me.teBaruAlamat = New DevExpress.XtraEditors.MemoEdit()
        Me.teBaruNoRM = New DevExpress.XtraEditors.TextEdit()
        Me.teBaruNama = New DevExpress.XtraEditors.TextEdit()
        Me.teBaruTelepon2 = New DevExpress.XtraEditors.TextEdit()
        Me.teBaruTelepon1 = New DevExpress.XtraEditors.TextEdit()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.pnlInfo = New System.Windows.Forms.Panel()
        Me.lblcContent = New System.Windows.Forms.Label()
        Me.lblcTitle = New System.Windows.Forms.Label()
        Me.pbcIcon = New System.Windows.Forms.PictureBox()
        Me.panelDoctor = New System.Windows.Forms.Panel()
        Me.xtcTanggal = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpTanggalSlot = New DevExpress.XtraTab.XtraTabPage()
        Me.pnlTanggal = New System.Windows.Forms.Panel()
        Me.tlpTanggal = New System.Windows.Forms.TableLayoutPanel()
        Me.xtpTanggalKalender = New DevExpress.XtraTab.XtraTabPage()
        Me.dnKalender = New DevExpress.XtraScheduler.DateNavigator()
        Me.gcParamedis = New DevExpress.XtraEditors.GroupControl()
        Me.tlpParamedis = New System.Windows.Forms.TableLayoutPanel()
        Me.lueSpesialis = New DevExpress.XtraEditors.LookUpEdit()
        Me.teParamedisTelepon2 = New DevExpress.XtraEditors.TextEdit()
        Me.teParamedisTelepon1 = New DevExpress.XtraEditors.TextEdit()
        Me.lueParamedis = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnAppHarian = New System.Windows.Forms.Button()
        Me.btnAppPasien = New System.Windows.Forms.Button()
        Me.btnAppDokter = New System.Windows.Forms.Button()
        Me.btnShowHideParamedis = New System.Windows.Forms.Button()
        Me.btnRefreshPasien = New System.Windows.Forms.Button()
        Me.btnShowHidePasien = New System.Windows.Forms.Button()
        Me.btnRefreshDokter = New System.Windows.Forms.Button()
        Me.lblSep5 = New System.Windows.Forms.Label()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBody.SuspendLayout()
        Me.tlpAppointment.SuspendLayout()
        Me.pnlKanan.SuspendLayout()
        Me.pnlPasienSesi.SuspendLayout()
        Me.tlpPasienSesi.SuspendLayout()
        Me.tlpScheduleDate.SuspendLayout()
        Me.tlpJadwalSesi.SuspendLayout()
        CType(Me.lueJadwalSesi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcSlot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcSlot.SuspendLayout()
        Me.pnlSlot.SuspendLayout()
        Me.pnlInfoSlot.SuspendLayout()
        CType(Me.pbcIconSlot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcDataPasien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcDataPasien.SuspendLayout()
        CType(Me.xtccPatientData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtccPatientData.SuspendLayout()
        Me.xtpPasienLama.SuspendLayout()
        Me.tlpPasienLama.SuspendLayout()
        CType(Me.teLamaRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueLamaNama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teLamaAlamat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLamaNoRM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teLamaTelepon2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teLamaTelepon1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teLamaJenisKelamin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teLamaTanggalLahir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpPasienBaru.SuspendLayout()
        Me.tlpPasienBaru.SuspendLayout()
        CType(Me.teBaruRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deBaruTanggalLahir.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deBaruTanggalLahir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueBaruJenisKelamin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teBaruAlamat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teBaruNoRM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teBaruNama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teBaruTelepon2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teBaruTelepon1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInfo.SuspendLayout()
        CType(Me.pbcIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDoctor.SuspendLayout()
        CType(Me.xtcTanggal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcTanggal.SuspendLayout()
        Me.xtpTanggalSlot.SuspendLayout()
        Me.pnlTanggal.SuspendLayout()
        Me.xtpTanggalKalender.SuspendLayout()
        CType(Me.dnKalender, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dnKalender.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcParamedis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcParamedis.SuspendLayout()
        Me.tlpParamedis.SuspendLayout()
        CType(Me.lueSpesialis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teParamedisTelepon2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teParamedisTelepon1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueParamedis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpForm
        '
        Me.tlpForm.BackColor = System.Drawing.Color.Teal
        Me.tlpForm.ColumnCount = 3
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.Controls.Add(Me.pTitle, 1, 0)
        Me.tlpForm.Controls.Add(Me.pBody, 1, 1)
        Me.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpForm.Location = New System.Drawing.Point(0, 0)
        Me.tlpForm.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpForm.Name = "tlpForm"
        Me.tlpForm.RowCount = 2
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpForm.Size = New System.Drawing.Size(1243, 700)
        Me.tlpForm.TabIndex = 0
        '
        'pTitle
        '
        Me.pTitle.Controls.Add(Me.lblTitle)
        Me.pTitle.Controls.Add(Me.pMinimize)
        Me.pTitle.Controls.Add(Me.pMaximize)
        Me.pTitle.Controls.Add(Me.pExit)
        Me.pTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pTitle.Location = New System.Drawing.Point(2, 0)
        Me.pTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.pTitle.Name = "pTitle"
        Me.pTitle.Size = New System.Drawing.Size(1239, 30)
        Me.pTitle.TabIndex = 10
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblTitle.Size = New System.Drawing.Size(1149, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Appointment"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pMinimize
        '
        Me.pMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.pMinimize.Image = Global.dizUI.My.Resources.Resources.min_w
        Me.pMinimize.Location = New System.Drawing.Point(1149, 0)
        Me.pMinimize.Margin = New System.Windows.Forms.Padding(0)
        Me.pMinimize.Name = "pMinimize"
        Me.pMinimize.Size = New System.Drawing.Size(30, 30)
        Me.pMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pMinimize.TabIndex = 8
        Me.pMinimize.TabStop = False
        '
        'pMaximize
        '
        Me.pMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pMaximize.Dock = System.Windows.Forms.DockStyle.Right
        Me.pMaximize.Image = Global.dizUI.My.Resources.Resources.max_w
        Me.pMaximize.Location = New System.Drawing.Point(1179, 0)
        Me.pMaximize.Margin = New System.Windows.Forms.Padding(0)
        Me.pMaximize.Name = "pMaximize"
        Me.pMaximize.Size = New System.Drawing.Size(30, 30)
        Me.pMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pMaximize.TabIndex = 7
        Me.pMaximize.TabStop = False
        '
        'pExit
        '
        Me.pExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.pExit.Image = Global.dizUI.My.Resources.Resources.exit_w
        Me.pExit.Location = New System.Drawing.Point(1209, 0)
        Me.pExit.Margin = New System.Windows.Forms.Padding(0)
        Me.pExit.Name = "pExit"
        Me.pExit.Size = New System.Drawing.Size(30, 30)
        Me.pExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pExit.TabIndex = 9
        Me.pExit.TabStop = False
        '
        'pBody
        '
        Me.pBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pBody.Controls.Add(Me.tlpAppointment)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(1239, 670)
        Me.pBody.TabIndex = 7
        '
        'tlpAppointment
        '
        Me.tlpAppointment.ColumnCount = 2
        Me.tlpAppointment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400.0!))
        Me.tlpAppointment.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpAppointment.Controls.Add(Me.pnlKanan, 1, 0)
        Me.tlpAppointment.Controls.Add(Me.panelDoctor, 0, 0)
        Me.tlpAppointment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpAppointment.Location = New System.Drawing.Point(0, 30)
        Me.tlpAppointment.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpAppointment.Name = "tlpAppointment"
        Me.tlpAppointment.RowCount = 1
        Me.tlpAppointment.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpAppointment.Size = New System.Drawing.Size(1239, 640)
        Me.tlpAppointment.TabIndex = 5
        '
        'pnlKanan
        '
        Me.pnlKanan.Controls.Add(Me.pnlPasienSesi)
        Me.pnlKanan.Controls.Add(Me.pnlInfo)
        Me.pnlKanan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlKanan.Location = New System.Drawing.Point(400, 0)
        Me.pnlKanan.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlKanan.Name = "pnlKanan"
        Me.pnlKanan.Size = New System.Drawing.Size(839, 640)
        Me.pnlKanan.TabIndex = 2
        '
        'pnlPasienSesi
        '
        Me.pnlPasienSesi.Controls.Add(Me.tlpPasienSesi)
        Me.pnlPasienSesi.Controls.Add(Me.gcDataPasien)
        Me.pnlPasienSesi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPasienSesi.Location = New System.Drawing.Point(0, 0)
        Me.pnlPasienSesi.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlPasienSesi.Name = "pnlPasienSesi"
        Me.pnlPasienSesi.Padding = New System.Windows.Forms.Padding(8)
        Me.pnlPasienSesi.Size = New System.Drawing.Size(839, 640)
        Me.pnlPasienSesi.TabIndex = 36
        '
        'tlpPasienSesi
        '
        Me.tlpPasienSesi.ColumnCount = 1
        Me.tlpPasienSesi.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPasienSesi.Controls.Add(Me.tlpScheduleDate, 0, 0)
        Me.tlpPasienSesi.Controls.Add(Me.tlpJadwalSesi, 0, 1)
        Me.tlpPasienSesi.Controls.Add(Me.gcSlot, 0, 2)
        Me.tlpPasienSesi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPasienSesi.Location = New System.Drawing.Point(8, 218)
        Me.tlpPasienSesi.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpPasienSesi.Name = "tlpPasienSesi"
        Me.tlpPasienSesi.RowCount = 3
        Me.tlpPasienSesi.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPasienSesi.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPasienSesi.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPasienSesi.Size = New System.Drawing.Size(823, 414)
        Me.tlpPasienSesi.TabIndex = 35
        '
        'tlpScheduleDate
        '
        Me.tlpScheduleDate.ColumnCount = 6
        Me.tlpScheduleDate.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpScheduleDate.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136.0!))
        Me.tlpScheduleDate.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpScheduleDate.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpScheduleDate.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124.0!))
        Me.tlpScheduleDate.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpScheduleDate.Controls.Add(Me.Label14, 1, 0)
        Me.tlpScheduleDate.Controls.Add(Me.btnRefreshSlot, 4, 0)
        Me.tlpScheduleDate.Controls.Add(Me.lblTanggal, 3, 0)
        Me.tlpScheduleDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpScheduleDate.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tlpScheduleDate.Location = New System.Drawing.Point(0, 0)
        Me.tlpScheduleDate.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpScheduleDate.Name = "tlpScheduleDate"
        Me.tlpScheduleDate.RowCount = 1
        Me.tlpScheduleDate.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpScheduleDate.Size = New System.Drawing.Size(823, 24)
        Me.tlpScheduleDate.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label14.Location = New System.Drawing.Point(88, 5)
        Me.Label14.Margin = New System.Windows.Forms.Padding(0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 14)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Tanggal :"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnRefreshSlot
        '
        Me.btnRefreshSlot.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnRefreshSlot.FlatAppearance.BorderSize = 0
        Me.btnRefreshSlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefreshSlot.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnRefreshSlot.ForeColor = System.Drawing.Color.White
        Me.btnRefreshSlot.Location = New System.Drawing.Point(689, 0)
        Me.btnRefreshSlot.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRefreshSlot.Name = "btnRefreshSlot"
        Me.btnRefreshSlot.Size = New System.Drawing.Size(124, 24)
        Me.btnRefreshSlot.TabIndex = 35
        Me.btnRefreshSlot.Text = "Refresh App. Slot"
        Me.btnRefreshSlot.UseVisualStyleBackColor = False
        '
        'lblTanggal
        '
        Me.lblTanggal.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblTanggal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTanggal.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblTanggal.Location = New System.Drawing.Point(156, 0)
        Me.lblTanggal.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblTanggal.Size = New System.Drawing.Size(533, 24)
        Me.lblTanggal.TabIndex = 31
        Me.lblTanggal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpJadwalSesi
        '
        Me.tlpJadwalSesi.ColumnCount = 4
        Me.tlpJadwalSesi.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpJadwalSesi.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136.0!))
        Me.tlpJadwalSesi.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpJadwalSesi.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpJadwalSesi.Controls.Add(Me.lueJadwalSesi, 3, 0)
        Me.tlpJadwalSesi.Controls.Add(Me.Label13, 1, 0)
        Me.tlpJadwalSesi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpJadwalSesi.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tlpJadwalSesi.Location = New System.Drawing.Point(0, 24)
        Me.tlpJadwalSesi.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpJadwalSesi.Name = "tlpJadwalSesi"
        Me.tlpJadwalSesi.RowCount = 1
        Me.tlpJadwalSesi.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpJadwalSesi.Size = New System.Drawing.Size(823, 24)
        Me.tlpJadwalSesi.TabIndex = 36
        '
        'lueJadwalSesi
        '
        Me.lueJadwalSesi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueJadwalSesi.Location = New System.Drawing.Point(156, 2)
        Me.lueJadwalSesi.Margin = New System.Windows.Forms.Padding(0)
        Me.lueJadwalSesi.Name = "lueJadwalSesi"
        Me.lueJadwalSesi.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueJadwalSesi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueJadwalSesi.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lueJadwalSesi.Properties.Appearance.Options.UseBackColor = True
        Me.lueJadwalSesi.Properties.Appearance.Options.UseFont = True
        Me.lueJadwalSesi.Properties.Appearance.Options.UseForeColor = True
        Me.lueJadwalSesi.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueJadwalSesi.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueJadwalSesi.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.lueJadwalSesi.Properties.AppearanceDisabled.Options.UseFont = True
        Me.lueJadwalSesi.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueJadwalSesi.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueJadwalSesi.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.lueJadwalSesi.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.lueJadwalSesi.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lueJadwalSesi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueJadwalSesi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueJadwalSesi.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueJadwalSesi.Properties.NullText = "[Isian belum dipilih]"
        Me.lueJadwalSesi.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueJadwalSesi.Size = New System.Drawing.Size(219, 20)
        Me.lueJadwalSesi.TabIndex = 45
        Me.lueJadwalSesi.Tag = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label13.Location = New System.Drawing.Point(70, 0)
        Me.Label13.Margin = New System.Windows.Forms.Padding(0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 24)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Sesi Jadwal :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gcSlot
        '
        Me.gcSlot.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gcSlot.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.gcSlot.Appearance.Options.UseBackColor = True
        Me.gcSlot.Appearance.Options.UseFont = True
        Me.gcSlot.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.gcSlot.AppearanceCaption.Options.UseFont = True
        Me.gcSlot.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.gcSlot.Controls.Add(Me.pnlSlot)
        Me.gcSlot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcSlot.Location = New System.Drawing.Point(0, 56)
        Me.gcSlot.Margin = New System.Windows.Forms.Padding(0, 8, 0, 8)
        Me.gcSlot.Name = "gcSlot"
        Me.gcSlot.Size = New System.Drawing.Size(823, 350)
        Me.gcSlot.TabIndex = 37
        Me.gcSlot.Text = "Slot Appointment"
        '
        'pnlSlot
        '
        Me.pnlSlot.AutoScroll = True
        Me.pnlSlot.Controls.Add(Me.tlpSlot)
        Me.pnlSlot.Controls.Add(Me.pnlInfoSlot)
        Me.pnlSlot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSlot.Location = New System.Drawing.Point(2, 23)
        Me.pnlSlot.Name = "pnlSlot"
        Me.pnlSlot.Size = New System.Drawing.Size(819, 325)
        Me.pnlSlot.TabIndex = 0
        '
        'tlpSlot
        '
        Me.tlpSlot.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlpSlot.ColumnCount = 3
        Me.tlpSlot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpSlot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 900.0!))
        Me.tlpSlot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSlot.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpSlot.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.tlpSlot.Location = New System.Drawing.Point(0, 0)
        Me.tlpSlot.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpSlot.Name = "tlpSlot"
        Me.tlpSlot.RowCount = 3
        Me.tlpSlot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpSlot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.tlpSlot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpSlot.Size = New System.Drawing.Size(802, 70)
        Me.tlpSlot.TabIndex = 3
        '
        'pnlInfoSlot
        '
        Me.pnlInfoSlot.Controls.Add(Me.lblcContentSlot)
        Me.pnlInfoSlot.Controls.Add(Me.lblcTitleSlot)
        Me.pnlInfoSlot.Controls.Add(Me.pbcIconSlot)
        Me.pnlInfoSlot.Location = New System.Drawing.Point(38, 28)
        Me.pnlInfoSlot.Name = "pnlInfoSlot"
        Me.pnlInfoSlot.Size = New System.Drawing.Size(726, 402)
        Me.pnlInfoSlot.TabIndex = 4
        Me.pnlInfoSlot.Visible = False
        '
        'lblcContentSlot
        '
        Me.lblcContentSlot.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblcContentSlot.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblcContentSlot.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblcContentSlot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.lblcContentSlot.Location = New System.Drawing.Point(12, 80)
        Me.lblcContentSlot.Margin = New System.Windows.Forms.Padding(16)
        Me.lblcContentSlot.Name = "lblcContentSlot"
        Me.lblcContentSlot.Padding = New System.Windows.Forms.Padding(16)
        Me.lblcContentSlot.Size = New System.Drawing.Size(698, 309)
        Me.lblcContentSlot.TabIndex = 32
        Me.lblcContentSlot.Text = "ALASAN :"
        '
        'lblcTitleSlot
        '
        Me.lblcTitleSlot.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblcTitleSlot.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblcTitleSlot.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblcTitleSlot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.lblcTitleSlot.Location = New System.Drawing.Point(93, 16)
        Me.lblcTitleSlot.Margin = New System.Windows.Forms.Padding(16)
        Me.lblcTitleSlot.Name = "lblcTitleSlot"
        Me.lblcTitleSlot.Padding = New System.Windows.Forms.Padding(0, 16, 16, 16)
        Me.lblcTitleSlot.Size = New System.Drawing.Size(617, 64)
        Me.lblcTitleSlot.TabIndex = 31
        Me.lblcTitleSlot.Text = "WARNING : APPOINTMENT SLOT NOT AVAILABLE"
        Me.lblcTitleSlot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbcIconSlot
        '
        Me.pbcIconSlot.Image = Global.dizUI.My.Resources.Resources.cancel21
        Me.pbcIconSlot.Location = New System.Drawing.Point(16, 16)
        Me.pbcIconSlot.Margin = New System.Windows.Forms.Padding(16)
        Me.pbcIconSlot.Name = "pbcIconSlot"
        Me.pbcIconSlot.Size = New System.Drawing.Size(64, 64)
        Me.pbcIconSlot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbcIconSlot.TabIndex = 0
        Me.pbcIconSlot.TabStop = False
        '
        'gcDataPasien
        '
        Me.gcDataPasien.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gcDataPasien.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.gcDataPasien.Appearance.Options.UseBackColor = True
        Me.gcDataPasien.Appearance.Options.UseFont = True
        Me.gcDataPasien.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.gcDataPasien.AppearanceCaption.Options.UseFont = True
        Me.gcDataPasien.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.gcDataPasien.Controls.Add(Me.xtccPatientData)
        Me.gcDataPasien.Dock = System.Windows.Forms.DockStyle.Top
        Me.gcDataPasien.Location = New System.Drawing.Point(8, 8)
        Me.gcDataPasien.Margin = New System.Windows.Forms.Padding(8)
        Me.gcDataPasien.Name = "gcDataPasien"
        Me.gcDataPasien.Size = New System.Drawing.Size(823, 210)
        Me.gcDataPasien.TabIndex = 0
        Me.gcDataPasien.Text = "Pasien Data"
        '
        'xtccPatientData
        '
        Me.xtccPatientData.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.xtccPatientData.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.xtccPatientData.Appearance.Options.UseBackColor = True
        Me.xtccPatientData.Appearance.Options.UseFont = True
        Me.xtccPatientData.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.xtccPatientData.AppearancePage.Header.Options.UseFont = True
        Me.xtccPatientData.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtccPatientData.AppearancePage.HeaderActive.Options.UseFont = True
        Me.xtccPatientData.AppearancePage.HeaderDisabled.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.xtccPatientData.AppearancePage.HeaderDisabled.Options.UseFont = True
        Me.xtccPatientData.AppearancePage.HeaderHotTracked.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.xtccPatientData.AppearancePage.HeaderHotTracked.Options.UseFont = True
        Me.xtccPatientData.AppearancePage.PageClient.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.xtccPatientData.AppearancePage.PageClient.Options.UseFont = True
        Me.xtccPatientData.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.xtccPatientData.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.xtccPatientData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtccPatientData.Location = New System.Drawing.Point(2, 23)
        Me.xtccPatientData.Margin = New System.Windows.Forms.Padding(0)
        Me.xtccPatientData.Name = "xtccPatientData"
        Me.xtccPatientData.SelectedTabPage = Me.xtpPasienLama
        Me.xtccPatientData.Size = New System.Drawing.Size(819, 185)
        Me.xtccPatientData.TabIndex = 1
        Me.xtccPatientData.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpPasienLama, Me.xtpPasienBaru})
        '
        'xtpPasienLama
        '
        Me.xtpPasienLama.Appearance.PageClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.xtpPasienLama.Appearance.PageClient.Options.UseBackColor = True
        Me.xtpPasienLama.Controls.Add(Me.tlpPasienLama)
        Me.xtpPasienLama.Name = "xtpPasienLama"
        Me.xtpPasienLama.Size = New System.Drawing.Size(813, 154)
        Me.xtpPasienLama.Text = "Pasien Lama"
        '
        'tlpPasienLama
        '
        Me.tlpPasienLama.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlpPasienLama.ColumnCount = 6
        Me.tlpPasienLama.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tlpPasienLama.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115.0!))
        Me.tlpPasienLama.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.tlpPasienLama.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115.0!))
        Me.tlpPasienLama.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.tlpPasienLama.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPasienLama.Controls.Add(Me.teLamaRemarks, 4, 4)
        Me.tlpPasienLama.Controls.Add(Me.slueLamaNama, 2, 1)
        Me.tlpPasienLama.Controls.Add(Me.teLamaAlamat, 2, 4)
        Me.tlpPasienLama.Controls.Add(Me.lueLamaNoRM, 4, 1)
        Me.tlpPasienLama.Controls.Add(Me.teLamaTelepon2, 4, 3)
        Me.tlpPasienLama.Controls.Add(Me.teLamaTelepon1, 4, 2)
        Me.tlpPasienLama.Controls.Add(Me.Label12, 3, 4)
        Me.tlpPasienLama.Controls.Add(Me.Label11, 3, 3)
        Me.tlpPasienLama.Controls.Add(Me.Label10, 3, 2)
        Me.tlpPasienLama.Controls.Add(Me.Label7, 1, 1)
        Me.tlpPasienLama.Controls.Add(Me.Label8, 3, 1)
        Me.tlpPasienLama.Controls.Add(Me.Label6, 1, 2)
        Me.tlpPasienLama.Controls.Add(Me.teLamaJenisKelamin, 2, 2)
        Me.tlpPasienLama.Controls.Add(Me.Label5, 1, 3)
        Me.tlpPasienLama.Controls.Add(Me.teLamaTanggalLahir, 2, 3)
        Me.tlpPasienLama.Controls.Add(Me.Label9, 1, 4)
        Me.tlpPasienLama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPasienLama.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tlpPasienLama.ForeColor = System.Drawing.Color.Black
        Me.tlpPasienLama.Location = New System.Drawing.Point(0, 0)
        Me.tlpPasienLama.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpPasienLama.Name = "tlpPasienLama"
        Me.tlpPasienLama.RowCount = 6
        Me.tlpPasienLama.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tlpPasienLama.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPasienLama.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPasienLama.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPasienLama.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.tlpPasienLama.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPasienLama.Size = New System.Drawing.Size(813, 154)
        Me.tlpPasienLama.TabIndex = 0
        '
        'teLamaRemarks
        '
        Me.teLamaRemarks.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teLamaRemarks.Location = New System.Drawing.Point(484, 102)
        Me.teLamaRemarks.Margin = New System.Windows.Forms.Padding(0)
        Me.teLamaRemarks.Name = "teLamaRemarks"
        Me.teLamaRemarks.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teLamaRemarks.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teLamaRemarks.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teLamaRemarks.Properties.Appearance.Options.UseBackColor = True
        Me.teLamaRemarks.Properties.Appearance.Options.UseFont = True
        Me.teLamaRemarks.Properties.Appearance.Options.UseForeColor = True
        Me.teLamaRemarks.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teLamaRemarks.Properties.MaxLength = 300
        Me.teLamaRemarks.Size = New System.Drawing.Size(234, 20)
        Me.teLamaRemarks.TabIndex = 39
        Me.teLamaRemarks.Tag = ""
        '
        'slueLamaNama
        '
        Me.slueLamaNama.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.slueLamaNama.Location = New System.Drawing.Point(119, 6)
        Me.slueLamaNama.Margin = New System.Windows.Forms.Padding(0)
        Me.slueLamaNama.Name = "slueLamaNama"
        Me.slueLamaNama.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.slueLamaNama.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.slueLamaNama.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.slueLamaNama.Properties.Appearance.Options.UseBackColor = True
        Me.slueLamaNama.Properties.Appearance.Options.UseFont = True
        Me.slueLamaNama.Properties.Appearance.Options.UseForeColor = True
        Me.slueLamaNama.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.slueLamaNama.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueLamaNama.Properties.NullText = "[Isian belum dipilih]"
        Me.slueLamaNama.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.slueLamaNama.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Simple
        Me.slueLamaNama.Properties.PopupFindMode = DevExpress.XtraEditors.FindMode.Always
        Me.slueLamaNama.Properties.PopupView = Me.slueView
        Me.slueLamaNama.Properties.ShowFooter = False
        Me.slueLamaNama.Properties.ShowPopupShadow = False
        Me.slueLamaNama.Properties.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView
        Me.slueLamaNama.Size = New System.Drawing.Size(234, 20)
        Me.slueLamaNama.TabIndex = 46
        Me.slueLamaNama.Tag = "reffid"
        '
        'slueView
        '
        Me.slueView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.slueView.Appearance.EvenRow.Options.UseBackColor = True
        Me.slueView.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.slueView.Appearance.OddRow.Options.UseBackColor = True
        Me.slueView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn8, Me.GridColumn9, Me.GridColumn1, Me.GridColumn2})
        Me.slueView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.slueView.Name = "slueView"
        Me.slueView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.slueView.OptionsView.EnableAppearanceEvenRow = True
        Me.slueView.OptionsView.EnableAppearanceOddRow = True
        Me.slueView.OptionsView.ShowGroupPanel = False
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "ID"
        Me.GridColumn8.FieldName = "id"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "No RM"
        Me.GridColumn9.FieldName = "rekammedisno"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.OptionsColumn.ReadOnly = True
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 0
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Nama"
        Me.GridColumn1.FieldName = "nama"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Tgl. Lahir"
        Me.GridColumn2.FieldName = "tanggallahir"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        '
        'teLamaAlamat
        '
        Me.teLamaAlamat.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teLamaAlamat.Location = New System.Drawing.Point(119, 79)
        Me.teLamaAlamat.Margin = New System.Windows.Forms.Padding(0)
        Me.teLamaAlamat.Name = "teLamaAlamat"
        Me.teLamaAlamat.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teLamaAlamat.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teLamaAlamat.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teLamaAlamat.Properties.Appearance.Options.UseBackColor = True
        Me.teLamaAlamat.Properties.Appearance.Options.UseFont = True
        Me.teLamaAlamat.Properties.Appearance.Options.UseForeColor = True
        Me.teLamaAlamat.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teLamaAlamat.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teLamaAlamat.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.teLamaAlamat.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teLamaAlamat.Properties.AppearanceDisabled.Options.UseFont = True
        Me.teLamaAlamat.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.teLamaAlamat.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.teLamaAlamat.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.teLamaAlamat.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teLamaAlamat.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teLamaAlamat.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.teLamaAlamat.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teLamaAlamat.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.teLamaAlamat.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.teLamaAlamat.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teLamaAlamat.Properties.MaxLength = 2000
        Me.teLamaAlamat.Properties.NullText = "-"
        Me.teLamaAlamat.Properties.ReadOnly = True
        Me.teLamaAlamat.Size = New System.Drawing.Size(234, 66)
        Me.teLamaAlamat.TabIndex = 73
        '
        'lueLamaNoRM
        '
        Me.lueLamaNoRM.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueLamaNoRM.Location = New System.Drawing.Point(484, 6)
        Me.lueLamaNoRM.Margin = New System.Windows.Forms.Padding(0)
        Me.lueLamaNoRM.Name = "lueLamaNoRM"
        Me.lueLamaNoRM.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueLamaNoRM.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueLamaNoRM.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lueLamaNoRM.Properties.Appearance.Options.UseBackColor = True
        Me.lueLamaNoRM.Properties.Appearance.Options.UseFont = True
        Me.lueLamaNoRM.Properties.Appearance.Options.UseForeColor = True
        Me.lueLamaNoRM.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueLamaNoRM.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueLamaNoRM.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.lueLamaNoRM.Properties.AppearanceDisabled.Options.UseFont = True
        Me.lueLamaNoRM.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueLamaNoRM.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueLamaNoRM.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.lueLamaNoRM.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.lueLamaNoRM.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lueLamaNoRM.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueLamaNoRM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLamaNoRM.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("rekammedisno", "No RM"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Nama")})
        Me.lueLamaNoRM.Properties.NullText = "[Isian belum dipilih]"
        Me.lueLamaNoRM.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueLamaNoRM.Properties.ShowPopupShadow = False
        Me.lueLamaNoRM.Size = New System.Drawing.Size(135, 20)
        Me.lueLamaNoRM.TabIndex = 46
        Me.lueLamaNoRM.Tag = "reffid"
        '
        'teLamaTelepon2
        '
        Me.teLamaTelepon2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teLamaTelepon2.Location = New System.Drawing.Point(484, 54)
        Me.teLamaTelepon2.Margin = New System.Windows.Forms.Padding(0)
        Me.teLamaTelepon2.Name = "teLamaTelepon2"
        Me.teLamaTelepon2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teLamaTelepon2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teLamaTelepon2.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teLamaTelepon2.Properties.Appearance.Options.UseBackColor = True
        Me.teLamaTelepon2.Properties.Appearance.Options.UseFont = True
        Me.teLamaTelepon2.Properties.Appearance.Options.UseForeColor = True
        Me.teLamaTelepon2.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teLamaTelepon2.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teLamaTelepon2.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teLamaTelepon2.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teLamaTelepon2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teLamaTelepon2.Properties.MaxLength = 30
        Me.teLamaTelepon2.Properties.NullText = "0"
        Me.teLamaTelepon2.Size = New System.Drawing.Size(157, 20)
        Me.teLamaTelepon2.TabIndex = 30
        Me.teLamaTelepon2.Tag = ""
        '
        'teLamaTelepon1
        '
        Me.teLamaTelepon1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teLamaTelepon1.Location = New System.Drawing.Point(484, 30)
        Me.teLamaTelepon1.Margin = New System.Windows.Forms.Padding(0)
        Me.teLamaTelepon1.Name = "teLamaTelepon1"
        Me.teLamaTelepon1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teLamaTelepon1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teLamaTelepon1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teLamaTelepon1.Properties.Appearance.Options.UseBackColor = True
        Me.teLamaTelepon1.Properties.Appearance.Options.UseFont = True
        Me.teLamaTelepon1.Properties.Appearance.Options.UseForeColor = True
        Me.teLamaTelepon1.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teLamaTelepon1.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teLamaTelepon1.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teLamaTelepon1.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teLamaTelepon1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teLamaTelepon1.Properties.MaxLength = 30
        Me.teLamaTelepon1.Properties.NullText = "0"
        Me.teLamaTelepon1.Size = New System.Drawing.Size(157, 20)
        Me.teLamaTelepon1.TabIndex = 30
        Me.teLamaTelepon1.Tag = ""
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label12.Location = New System.Drawing.Point(435, 105)
        Me.Label12.Margin = New System.Windows.Forms.Padding(0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 14)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Catatan"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label11.Location = New System.Drawing.Point(421, 57)
        Me.Label11.Margin = New System.Windows.Forms.Padding(0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 14)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Telepon 2"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label10.Location = New System.Drawing.Point(421, 33)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 14)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Telepon 1"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(75, 9)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 14)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Nama*"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(377, 9)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 14)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "No. Rekam Medis*"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(41, 33)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 14)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Jenis Kelamin"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'teLamaJenisKelamin
        '
        Me.teLamaJenisKelamin.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teLamaJenisKelamin.Location = New System.Drawing.Point(119, 30)
        Me.teLamaJenisKelamin.Margin = New System.Windows.Forms.Padding(0)
        Me.teLamaJenisKelamin.Name = "teLamaJenisKelamin"
        Me.teLamaJenisKelamin.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teLamaJenisKelamin.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teLamaJenisKelamin.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teLamaJenisKelamin.Properties.Appearance.Options.UseBackColor = True
        Me.teLamaJenisKelamin.Properties.Appearance.Options.UseFont = True
        Me.teLamaJenisKelamin.Properties.Appearance.Options.UseForeColor = True
        Me.teLamaJenisKelamin.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teLamaJenisKelamin.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teLamaJenisKelamin.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teLamaJenisKelamin.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teLamaJenisKelamin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teLamaJenisKelamin.Properties.MaxLength = 100
        Me.teLamaJenisKelamin.Properties.NullText = "-"
        Me.teLamaJenisKelamin.Properties.ReadOnly = True
        Me.teLamaJenisKelamin.Size = New System.Drawing.Size(157, 20)
        Me.teLamaJenisKelamin.TabIndex = 29
        Me.teLamaJenisKelamin.Tag = ""
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(40, 57)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 14)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Tanggal Lahir"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'teLamaTanggalLahir
        '
        Me.teLamaTanggalLahir.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teLamaTanggalLahir.Location = New System.Drawing.Point(119, 54)
        Me.teLamaTanggalLahir.Margin = New System.Windows.Forms.Padding(0)
        Me.teLamaTanggalLahir.Name = "teLamaTanggalLahir"
        Me.teLamaTanggalLahir.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teLamaTanggalLahir.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teLamaTanggalLahir.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teLamaTanggalLahir.Properties.Appearance.Options.UseBackColor = True
        Me.teLamaTanggalLahir.Properties.Appearance.Options.UseFont = True
        Me.teLamaTanggalLahir.Properties.Appearance.Options.UseForeColor = True
        Me.teLamaTanggalLahir.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teLamaTanggalLahir.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teLamaTanggalLahir.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teLamaTanggalLahir.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teLamaTanggalLahir.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teLamaTanggalLahir.Properties.MaxLength = 30
        Me.teLamaTanggalLahir.Properties.NullText = "-"
        Me.teLamaTanggalLahir.Properties.ReadOnly = True
        Me.teLamaTanggalLahir.Size = New System.Drawing.Size(157, 20)
        Me.teLamaTanggalLahir.TabIndex = 29
        Me.teLamaTanggalLahir.Tag = ""
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(75, 105)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 14)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Alamat"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'xtpPasienBaru
        '
        Me.xtpPasienBaru.Controls.Add(Me.tlpPasienBaru)
        Me.xtpPasienBaru.Name = "xtpPasienBaru"
        Me.xtpPasienBaru.Size = New System.Drawing.Size(813, 154)
        Me.xtpPasienBaru.Text = "Pasien Baru"
        '
        'tlpPasienBaru
        '
        Me.tlpPasienBaru.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlpPasienBaru.ColumnCount = 6
        Me.tlpPasienBaru.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tlpPasienBaru.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115.0!))
        Me.tlpPasienBaru.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.tlpPasienBaru.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115.0!))
        Me.tlpPasienBaru.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.tlpPasienBaru.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPasienBaru.Controls.Add(Me.teBaruRemarks, 4, 4)
        Me.tlpPasienBaru.Controls.Add(Me.deBaruTanggalLahir, 2, 3)
        Me.tlpPasienBaru.Controls.Add(Me.lueBaruJenisKelamin, 2, 2)
        Me.tlpPasienBaru.Controls.Add(Me.teBaruAlamat, 2, 4)
        Me.tlpPasienBaru.Controls.Add(Me.teBaruNoRM, 4, 1)
        Me.tlpPasienBaru.Controls.Add(Me.teBaruNama, 2, 1)
        Me.tlpPasienBaru.Controls.Add(Me.teBaruTelepon2, 4, 3)
        Me.tlpPasienBaru.Controls.Add(Me.teBaruTelepon1, 4, 2)
        Me.tlpPasienBaru.Controls.Add(Me.Label26, 3, 4)
        Me.tlpPasienBaru.Controls.Add(Me.Label27, 3, 3)
        Me.tlpPasienBaru.Controls.Add(Me.Label28, 3, 2)
        Me.tlpPasienBaru.Controls.Add(Me.Label29, 1, 1)
        Me.tlpPasienBaru.Controls.Add(Me.Label30, 3, 1)
        Me.tlpPasienBaru.Controls.Add(Me.Label31, 1, 2)
        Me.tlpPasienBaru.Controls.Add(Me.Label32, 1, 3)
        Me.tlpPasienBaru.Controls.Add(Me.Label33, 1, 4)
        Me.tlpPasienBaru.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPasienBaru.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.tlpPasienBaru.ForeColor = System.Drawing.Color.Black
        Me.tlpPasienBaru.Location = New System.Drawing.Point(0, 0)
        Me.tlpPasienBaru.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpPasienBaru.Name = "tlpPasienBaru"
        Me.tlpPasienBaru.RowCount = 6
        Me.tlpPasienBaru.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tlpPasienBaru.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPasienBaru.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPasienBaru.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPasienBaru.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.tlpPasienBaru.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPasienBaru.Size = New System.Drawing.Size(813, 154)
        Me.tlpPasienBaru.TabIndex = 1
        '
        'teBaruRemarks
        '
        Me.teBaruRemarks.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teBaruRemarks.Location = New System.Drawing.Point(484, 102)
        Me.teBaruRemarks.Margin = New System.Windows.Forms.Padding(0)
        Me.teBaruRemarks.Name = "teBaruRemarks"
        Me.teBaruRemarks.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teBaruRemarks.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teBaruRemarks.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teBaruRemarks.Properties.Appearance.Options.UseBackColor = True
        Me.teBaruRemarks.Properties.Appearance.Options.UseFont = True
        Me.teBaruRemarks.Properties.Appearance.Options.UseForeColor = True
        Me.teBaruRemarks.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teBaruRemarks.Properties.MaxLength = 300
        Me.teBaruRemarks.Size = New System.Drawing.Size(234, 20)
        Me.teBaruRemarks.TabIndex = 40
        Me.teBaruRemarks.Tag = ""
        '
        'deBaruTanggalLahir
        '
        Me.deBaruTanggalLahir.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.deBaruTanggalLahir.EditValue = Nothing
        Me.deBaruTanggalLahir.Location = New System.Drawing.Point(119, 54)
        Me.deBaruTanggalLahir.Margin = New System.Windows.Forms.Padding(0)
        Me.deBaruTanggalLahir.Name = "deBaruTanggalLahir"
        Me.deBaruTanggalLahir.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deBaruTanggalLahir.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deBaruTanggalLahir.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.deBaruTanggalLahir.Properties.Appearance.Options.UseBackColor = True
        Me.deBaruTanggalLahir.Properties.Appearance.Options.UseFont = True
        Me.deBaruTanggalLahir.Properties.Appearance.Options.UseForeColor = True
        Me.deBaruTanggalLahir.Properties.AppearanceCalendar.DayCellHighlighted.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deBaruTanggalLahir.Properties.AppearanceCalendar.DayCellHighlighted.Options.UseFont = True
        Me.deBaruTanggalLahir.Properties.AppearanceCalendar.Header.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deBaruTanggalLahir.Properties.AppearanceCalendar.Header.Options.UseFont = True
        Me.deBaruTanggalLahir.Properties.AppearanceCalendar.HeaderHighlighted.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deBaruTanggalLahir.Properties.AppearanceCalendar.HeaderHighlighted.Options.UseFont = True
        Me.deBaruTanggalLahir.Properties.AppearanceCalendar.WeekNumber.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deBaruTanggalLahir.Properties.AppearanceCalendar.WeekNumber.Options.UseFont = True
        Me.deBaruTanggalLahir.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deBaruTanggalLahir.Properties.AppearanceDisabled.Options.UseFont = True
        Me.deBaruTanggalLahir.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deBaruTanggalLahir.Properties.AppearanceDropDown.Options.UseFont = True
        Me.deBaruTanggalLahir.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deBaruTanggalLahir.Properties.AppearanceFocused.Options.UseFont = True
        Me.deBaruTanggalLahir.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deBaruTanggalLahir.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.deBaruTanggalLahir.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.deBaruTanggalLahir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deBaruTanggalLahir.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.[True]
        Me.deBaruTanggalLahir.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.deBaruTanggalLahir.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic
        Me.deBaruTanggalLahir.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.deBaruTanggalLahir.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deBaruTanggalLahir.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.deBaruTanggalLahir.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deBaruTanggalLahir.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.deBaruTanggalLahir.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.deBaruTanggalLahir.Size = New System.Drawing.Size(133, 20)
        Me.deBaruTanggalLahir.TabIndex = 36
        Me.deBaruTanggalLahir.Tag = "tanggallahir"
        '
        'lueBaruJenisKelamin
        '
        Me.lueBaruJenisKelamin.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueBaruJenisKelamin.Location = New System.Drawing.Point(119, 30)
        Me.lueBaruJenisKelamin.Margin = New System.Windows.Forms.Padding(0)
        Me.lueBaruJenisKelamin.Name = "lueBaruJenisKelamin"
        Me.lueBaruJenisKelamin.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueBaruJenisKelamin.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueBaruJenisKelamin.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueBaruJenisKelamin.Properties.Appearance.Options.UseBackColor = True
        Me.lueBaruJenisKelamin.Properties.Appearance.Options.UseFont = True
        Me.lueBaruJenisKelamin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueBaruJenisKelamin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueBaruJenisKelamin.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueBaruJenisKelamin.Properties.NullText = "[Isian belum dipilih]"
        Me.lueBaruJenisKelamin.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueBaruJenisKelamin.Size = New System.Drawing.Size(150, 20)
        Me.lueBaruJenisKelamin.TabIndex = 36
        Me.lueBaruJenisKelamin.Tag = "jeniskelamin"
        '
        'teBaruAlamat
        '
        Me.teBaruAlamat.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teBaruAlamat.Location = New System.Drawing.Point(119, 79)
        Me.teBaruAlamat.Margin = New System.Windows.Forms.Padding(0)
        Me.teBaruAlamat.Name = "teBaruAlamat"
        Me.teBaruAlamat.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teBaruAlamat.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teBaruAlamat.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teBaruAlamat.Properties.Appearance.Options.UseBackColor = True
        Me.teBaruAlamat.Properties.Appearance.Options.UseFont = True
        Me.teBaruAlamat.Properties.Appearance.Options.UseForeColor = True
        Me.teBaruAlamat.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teBaruAlamat.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teBaruAlamat.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.teBaruAlamat.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teBaruAlamat.Properties.AppearanceDisabled.Options.UseFont = True
        Me.teBaruAlamat.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.teBaruAlamat.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teBaruAlamat.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teBaruAlamat.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.teBaruAlamat.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teBaruAlamat.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.teBaruAlamat.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.teBaruAlamat.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teBaruAlamat.Properties.MaxLength = 1000
        Me.teBaruAlamat.Properties.NullText = "-"
        Me.teBaruAlamat.Properties.ReadOnly = True
        Me.teBaruAlamat.Size = New System.Drawing.Size(234, 66)
        Me.teBaruAlamat.TabIndex = 73
        '
        'teBaruNoRM
        '
        Me.teBaruNoRM.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teBaruNoRM.Location = New System.Drawing.Point(484, 6)
        Me.teBaruNoRM.Margin = New System.Windows.Forms.Padding(0)
        Me.teBaruNoRM.Name = "teBaruNoRM"
        Me.teBaruNoRM.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teBaruNoRM.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teBaruNoRM.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teBaruNoRM.Properties.Appearance.Options.UseBackColor = True
        Me.teBaruNoRM.Properties.Appearance.Options.UseFont = True
        Me.teBaruNoRM.Properties.Appearance.Options.UseForeColor = True
        Me.teBaruNoRM.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teBaruNoRM.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teBaruNoRM.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teBaruNoRM.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teBaruNoRM.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teBaruNoRM.Properties.MaxLength = 50
        Me.teBaruNoRM.Properties.NullText = "00-00-00-00"
        Me.teBaruNoRM.Properties.ReadOnly = True
        Me.teBaruNoRM.Size = New System.Drawing.Size(135, 20)
        Me.teBaruNoRM.TabIndex = 31
        Me.teBaruNoRM.Tag = ""
        '
        'teBaruNama
        '
        Me.teBaruNama.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teBaruNama.Location = New System.Drawing.Point(119, 6)
        Me.teBaruNama.Margin = New System.Windows.Forms.Padding(0)
        Me.teBaruNama.Name = "teBaruNama"
        Me.teBaruNama.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teBaruNama.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teBaruNama.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teBaruNama.Properties.Appearance.Options.UseBackColor = True
        Me.teBaruNama.Properties.Appearance.Options.UseFont = True
        Me.teBaruNama.Properties.Appearance.Options.UseForeColor = True
        Me.teBaruNama.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teBaruNama.Properties.MaxLength = 300
        Me.teBaruNama.Size = New System.Drawing.Size(234, 20)
        Me.teBaruNama.TabIndex = 31
        Me.teBaruNama.Tag = ""
        '
        'teBaruTelepon2
        '
        Me.teBaruTelepon2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teBaruTelepon2.Location = New System.Drawing.Point(484, 54)
        Me.teBaruTelepon2.Margin = New System.Windows.Forms.Padding(0)
        Me.teBaruTelepon2.Name = "teBaruTelepon2"
        Me.teBaruTelepon2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teBaruTelepon2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teBaruTelepon2.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teBaruTelepon2.Properties.Appearance.Options.UseBackColor = True
        Me.teBaruTelepon2.Properties.Appearance.Options.UseFont = True
        Me.teBaruTelepon2.Properties.Appearance.Options.UseForeColor = True
        Me.teBaruTelepon2.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teBaruTelepon2.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teBaruTelepon2.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teBaruTelepon2.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teBaruTelepon2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teBaruTelepon2.Properties.MaxLength = 30
        Me.teBaruTelepon2.Properties.NullText = "0"
        Me.teBaruTelepon2.Size = New System.Drawing.Size(157, 20)
        Me.teBaruTelepon2.TabIndex = 30
        Me.teBaruTelepon2.Tag = ""
        '
        'teBaruTelepon1
        '
        Me.teBaruTelepon1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teBaruTelepon1.Location = New System.Drawing.Point(484, 30)
        Me.teBaruTelepon1.Margin = New System.Windows.Forms.Padding(0)
        Me.teBaruTelepon1.Name = "teBaruTelepon1"
        Me.teBaruTelepon1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teBaruTelepon1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teBaruTelepon1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teBaruTelepon1.Properties.Appearance.Options.UseBackColor = True
        Me.teBaruTelepon1.Properties.Appearance.Options.UseFont = True
        Me.teBaruTelepon1.Properties.Appearance.Options.UseForeColor = True
        Me.teBaruTelepon1.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teBaruTelepon1.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teBaruTelepon1.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teBaruTelepon1.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teBaruTelepon1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teBaruTelepon1.Properties.MaxLength = 30
        Me.teBaruTelepon1.Properties.NullText = "0"
        Me.teBaruTelepon1.Size = New System.Drawing.Size(157, 20)
        Me.teBaruTelepon1.TabIndex = 30
        Me.teBaruTelepon1.Tag = ""
        '
        'Label26
        '
        Me.Label26.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label26.Location = New System.Drawing.Point(428, 105)
        Me.Label26.Margin = New System.Windows.Forms.Padding(0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(56, 14)
        Me.Label26.TabIndex = 34
        Me.Label26.Text = "Catatan*"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label27.Location = New System.Drawing.Point(414, 57)
        Me.Label27.Margin = New System.Windows.Forms.Padding(0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(70, 14)
        Me.Label27.TabIndex = 34
        Me.Label27.Text = "Telepon 2*"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label28
        '
        Me.Label28.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label28.Location = New System.Drawing.Point(414, 33)
        Me.Label28.Margin = New System.Windows.Forms.Padding(0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(70, 14)
        Me.Label28.TabIndex = 33
        Me.Label28.Text = "Telepon 1*"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label29
        '
        Me.Label29.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label29.Location = New System.Drawing.Point(75, 9)
        Me.Label29.Margin = New System.Windows.Forms.Padding(0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(44, 14)
        Me.Label29.TabIndex = 30
        Me.Label29.Text = "Nama*"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label30
        '
        Me.Label30.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label30.Location = New System.Drawing.Point(384, 9)
        Me.Label30.Margin = New System.Windows.Forms.Padding(0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(100, 14)
        Me.Label30.TabIndex = 31
        Me.Label30.Text = "No. Rekam Medis"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label31
        '
        Me.Label31.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label31.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label31.Location = New System.Drawing.Point(41, 33)
        Me.Label31.Margin = New System.Windows.Forms.Padding(0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(78, 14)
        Me.Label31.TabIndex = 31
        Me.Label31.Text = "Jenis Kelamin"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label32
        '
        Me.Label32.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label32.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label32.Location = New System.Drawing.Point(40, 57)
        Me.Label32.Margin = New System.Windows.Forms.Padding(0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(79, 14)
        Me.Label32.TabIndex = 32
        Me.Label32.Text = "Tanggal Lahir"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label33
        '
        Me.Label33.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label33.Location = New System.Drawing.Point(75, 105)
        Me.Label33.Margin = New System.Windows.Forms.Padding(0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(44, 14)
        Me.Label33.TabIndex = 33
        Me.Label33.Text = "Alamat"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlInfo
        '
        Me.pnlInfo.Controls.Add(Me.lblcContent)
        Me.pnlInfo.Controls.Add(Me.lblcTitle)
        Me.pnlInfo.Controls.Add(Me.pbcIcon)
        Me.pnlInfo.Location = New System.Drawing.Point(34, 31)
        Me.pnlInfo.Name = "pnlInfo"
        Me.pnlInfo.Size = New System.Drawing.Size(726, 402)
        Me.pnlInfo.TabIndex = 3
        '
        'lblcContent
        '
        Me.lblcContent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblcContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblcContent.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblcContent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.lblcContent.Location = New System.Drawing.Point(12, 80)
        Me.lblcContent.Margin = New System.Windows.Forms.Padding(16)
        Me.lblcContent.Name = "lblcContent"
        Me.lblcContent.Padding = New System.Windows.Forms.Padding(16)
        Me.lblcContent.Size = New System.Drawing.Size(698, 309)
        Me.lblcContent.TabIndex = 32
        Me.lblcContent.Text = "ALASAN :"
        '
        'lblcTitle
        '
        Me.lblcTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblcTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblcTitle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblcTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.lblcTitle.Location = New System.Drawing.Point(93, 16)
        Me.lblcTitle.Margin = New System.Windows.Forms.Padding(16)
        Me.lblcTitle.Name = "lblcTitle"
        Me.lblcTitle.Padding = New System.Windows.Forms.Padding(0, 16, 16, 16)
        Me.lblcTitle.Size = New System.Drawing.Size(617, 64)
        Me.lblcTitle.TabIndex = 31
        Me.lblcTitle.Text = "WARNING : APPOINTMENT SLOT NOT AVAILABLE"
        Me.lblcTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbcIcon
        '
        Me.pbcIcon.Image = Global.dizUI.My.Resources.Resources.cancel21
        Me.pbcIcon.Location = New System.Drawing.Point(16, 16)
        Me.pbcIcon.Margin = New System.Windows.Forms.Padding(16)
        Me.pbcIcon.Name = "pbcIcon"
        Me.pbcIcon.Size = New System.Drawing.Size(64, 64)
        Me.pbcIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbcIcon.TabIndex = 0
        Me.pbcIcon.TabStop = False
        '
        'panelDoctor
        '
        Me.panelDoctor.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.panelDoctor.Controls.Add(Me.xtcTanggal)
        Me.panelDoctor.Controls.Add(Me.gcParamedis)
        Me.panelDoctor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelDoctor.ForeColor = System.Drawing.Color.Black
        Me.panelDoctor.Location = New System.Drawing.Point(0, 0)
        Me.panelDoctor.Margin = New System.Windows.Forms.Padding(0)
        Me.panelDoctor.Name = "panelDoctor"
        Me.panelDoctor.Size = New System.Drawing.Size(400, 640)
        Me.panelDoctor.TabIndex = 1
        '
        'xtcTanggal
        '
        Me.xtcTanggal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xtcTanggal.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.xtcTanggal.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.xtcTanggal.Appearance.Options.UseBackColor = True
        Me.xtcTanggal.Appearance.Options.UseFont = True
        Me.xtcTanggal.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.xtcTanggal.AppearancePage.Header.Options.UseFont = True
        Me.xtcTanggal.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtcTanggal.AppearancePage.HeaderActive.Options.UseFont = True
        Me.xtcTanggal.AppearancePage.HeaderDisabled.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.xtcTanggal.AppearancePage.HeaderDisabled.Options.UseFont = True
        Me.xtcTanggal.AppearancePage.HeaderHotTracked.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.xtcTanggal.AppearancePage.HeaderHotTracked.Options.UseFont = True
        Me.xtcTanggal.AppearancePage.PageClient.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.xtcTanggal.AppearancePage.PageClient.Options.UseFont = True
        Me.xtcTanggal.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.xtcTanggal.Location = New System.Drawing.Point(8, 147)
        Me.xtcTanggal.Margin = New System.Windows.Forms.Padding(8)
        Me.xtcTanggal.Name = "xtcTanggal"
        Me.xtcTanggal.SelectedTabPage = Me.xtpTanggalSlot
        Me.xtcTanggal.Size = New System.Drawing.Size(384, 485)
        Me.xtcTanggal.TabIndex = 2
        Me.xtcTanggal.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpTanggalSlot, Me.xtpTanggalKalender})
        '
        'xtpTanggalSlot
        '
        Me.xtpTanggalSlot.Appearance.PageClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.xtpTanggalSlot.Appearance.PageClient.Options.UseBackColor = True
        Me.xtpTanggalSlot.Controls.Add(Me.pnlTanggal)
        Me.xtpTanggalSlot.Name = "xtpTanggalSlot"
        Me.xtpTanggalSlot.Size = New System.Drawing.Size(378, 454)
        Me.xtpTanggalSlot.Text = "Slot Tanggal"
        '
        'pnlTanggal
        '
        Me.pnlTanggal.AutoScroll = True
        Me.pnlTanggal.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlTanggal.Controls.Add(Me.tlpTanggal)
        Me.pnlTanggal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTanggal.Location = New System.Drawing.Point(0, 0)
        Me.pnlTanggal.Name = "pnlTanggal"
        Me.pnlTanggal.Size = New System.Drawing.Size(378, 454)
        Me.pnlTanggal.TabIndex = 0
        '
        'tlpTanggal
        '
        Me.tlpTanggal.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlpTanggal.ColumnCount = 3
        Me.tlpTanggal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTanggal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 275.0!))
        Me.tlpTanggal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTanggal.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpTanggal.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.tlpTanggal.Location = New System.Drawing.Point(0, 0)
        Me.tlpTanggal.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpTanggal.Name = "tlpTanggal"
        Me.tlpTanggal.RowCount = 3
        Me.tlpTanggal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpTanggal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpTanggal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpTanggal.Size = New System.Drawing.Size(378, 70)
        Me.tlpTanggal.TabIndex = 2
        '
        'xtpTanggalKalender
        '
        Me.xtpTanggalKalender.Controls.Add(Me.dnKalender)
        Me.xtpTanggalKalender.Name = "xtpTanggalKalender"
        Me.xtpTanggalKalender.Size = New System.Drawing.Size(378, 454)
        Me.xtpTanggalKalender.Text = "Kalender"
        '
        'dnKalender
        '
        Me.dnKalender.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dnKalender.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dnKalender.Appearance.Options.UseBackColor = True
        Me.dnKalender.Appearance.Options.UseFont = True
        Me.dnKalender.Appearance.Options.UseTextOptions = True
        Me.dnKalender.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dnKalender.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.dnKalender.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.dnKalender.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.dnKalender.CalendarAppearance.DayCellDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dnKalender.CalendarAppearance.DayCellDisabled.ForeColor = System.Drawing.Color.White
        Me.dnKalender.CalendarAppearance.DayCellDisabled.Options.UseBackColor = True
        Me.dnKalender.CalendarAppearance.DayCellDisabled.Options.UseForeColor = True
        Me.dnKalender.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dnKalender.CellPadding = New System.Windows.Forms.Padding(2)
        Me.dnKalender.Cursor = System.Windows.Forms.Cursors.Default
        Me.dnKalender.DateTime = New Date(2017, 12, 14, 0, 0, 0, 0)
        Me.dnKalender.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dnKalender.EditValue = New Date(2017, 12, 14, 0, 0, 0, 0)
        Me.dnKalender.FirstDayOfWeek = System.DayOfWeek.Sunday
        Me.dnKalender.HeaderPadding = New System.Windows.Forms.Padding(0)
        Me.dnKalender.Location = New System.Drawing.Point(0, 0)
        Me.dnKalender.Margin = New System.Windows.Forms.Padding(0)
        Me.dnKalender.MonthHeaderPadding = New System.Windows.Forms.Padding(0)
        Me.dnKalender.Name = "dnKalender"
        Me.dnKalender.Padding = New System.Windows.Forms.Padding(0)
        Me.dnKalender.SelectionBehavior = DevExpress.XtraEditors.Controls.CalendarSelectionBehavior.Simple
        Me.dnKalender.SelectionMode = DevExpress.XtraEditors.Repository.CalendarSelectionMode.[Single]
        Me.dnKalender.ShowMonthNavigationButtons = DevExpress.Utils.DefaultBoolean.[True]
        Me.dnKalender.ShowYearNavigationButtons = DevExpress.Utils.DefaultBoolean.[True]
        Me.dnKalender.Size = New System.Drawing.Size(378, 454)
        Me.dnKalender.TabIndex = 1
        '
        'gcParamedis
        '
        Me.gcParamedis.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gcParamedis.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.gcParamedis.Appearance.Options.UseBackColor = True
        Me.gcParamedis.Appearance.Options.UseFont = True
        Me.gcParamedis.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.gcParamedis.AppearanceCaption.Options.UseFont = True
        Me.gcParamedis.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.gcParamedis.Controls.Add(Me.tlpParamedis)
        Me.gcParamedis.Location = New System.Drawing.Point(8, 8)
        Me.gcParamedis.Margin = New System.Windows.Forms.Padding(8)
        Me.gcParamedis.Name = "gcParamedis"
        Me.gcParamedis.Size = New System.Drawing.Size(384, 130)
        Me.gcParamedis.TabIndex = 0
        Me.gcParamedis.Text = "Paramedis Data"
        '
        'tlpParamedis
        '
        Me.tlpParamedis.ColumnCount = 4
        Me.tlpParamedis.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpParamedis.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpParamedis.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260.0!))
        Me.tlpParamedis.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpParamedis.Controls.Add(Me.lueSpesialis, 2, 2)
        Me.tlpParamedis.Controls.Add(Me.teParamedisTelepon2, 2, 4)
        Me.tlpParamedis.Controls.Add(Me.teParamedisTelepon1, 2, 3)
        Me.tlpParamedis.Controls.Add(Me.lueParamedis, 2, 1)
        Me.tlpParamedis.Controls.Add(Me.Label4, 1, 4)
        Me.tlpParamedis.Controls.Add(Me.Label3, 1, 3)
        Me.tlpParamedis.Controls.Add(Me.Label1, 1, 1)
        Me.tlpParamedis.Controls.Add(Me.Label2, 1, 2)
        Me.tlpParamedis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpParamedis.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.tlpParamedis.Location = New System.Drawing.Point(2, 23)
        Me.tlpParamedis.Name = "tlpParamedis"
        Me.tlpParamedis.RowCount = 6
        Me.tlpParamedis.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpParamedis.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpParamedis.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpParamedis.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpParamedis.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpParamedis.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpParamedis.Size = New System.Drawing.Size(380, 105)
        Me.tlpParamedis.TabIndex = 0
        '
        'lueSpesialis
        '
        Me.lueSpesialis.Location = New System.Drawing.Point(113, 31)
        Me.lueSpesialis.Name = "lueSpesialis"
        Me.lueSpesialis.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueSpesialis.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueSpesialis.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lueSpesialis.Properties.Appearance.Options.UseBackColor = True
        Me.lueSpesialis.Properties.Appearance.Options.UseFont = True
        Me.lueSpesialis.Properties.Appearance.Options.UseForeColor = True
        Me.lueSpesialis.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueSpesialis.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueSpesialis.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.lueSpesialis.Properties.AppearanceDisabled.Options.UseFont = True
        Me.lueSpesialis.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueSpesialis.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueSpesialis.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.lueSpesialis.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.lueSpesialis.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lueSpesialis.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueSpesialis.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueSpesialis.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueSpesialis.Properties.NullText = "[Isian belum dipilih]"
        Me.lueSpesialis.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueSpesialis.Properties.ShowPopupShadow = False
        Me.lueSpesialis.Size = New System.Drawing.Size(254, 20)
        Me.lueSpesialis.TabIndex = 45
        Me.lueSpesialis.Tag = ""
        '
        'teParamedisTelepon2
        '
        Me.teParamedisTelepon2.Enabled = False
        Me.teParamedisTelepon2.Location = New System.Drawing.Point(113, 79)
        Me.teParamedisTelepon2.Name = "teParamedisTelepon2"
        Me.teParamedisTelepon2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teParamedisTelepon2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teParamedisTelepon2.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teParamedisTelepon2.Properties.Appearance.Options.UseBackColor = True
        Me.teParamedisTelepon2.Properties.Appearance.Options.UseFont = True
        Me.teParamedisTelepon2.Properties.Appearance.Options.UseForeColor = True
        Me.teParamedisTelepon2.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teParamedisTelepon2.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teParamedisTelepon2.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teParamedisTelepon2.Properties.AppearanceDisabled.Options.UseFont = True
        Me.teParamedisTelepon2.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teParamedisTelepon2.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teParamedisTelepon2.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teParamedisTelepon2.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.teParamedisTelepon2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teParamedisTelepon2.Properties.MaxLength = 30
        Me.teParamedisTelepon2.Properties.ReadOnly = True
        Me.teParamedisTelepon2.Size = New System.Drawing.Size(157, 20)
        Me.teParamedisTelepon2.TabIndex = 29
        Me.teParamedisTelepon2.Tag = ""
        '
        'teParamedisTelepon1
        '
        Me.teParamedisTelepon1.Enabled = False
        Me.teParamedisTelepon1.Location = New System.Drawing.Point(113, 55)
        Me.teParamedisTelepon1.Name = "teParamedisTelepon1"
        Me.teParamedisTelepon1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teParamedisTelepon1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teParamedisTelepon1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teParamedisTelepon1.Properties.Appearance.Options.UseBackColor = True
        Me.teParamedisTelepon1.Properties.Appearance.Options.UseFont = True
        Me.teParamedisTelepon1.Properties.Appearance.Options.UseForeColor = True
        Me.teParamedisTelepon1.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teParamedisTelepon1.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teParamedisTelepon1.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teParamedisTelepon1.Properties.AppearanceDisabled.Options.UseFont = True
        Me.teParamedisTelepon1.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teParamedisTelepon1.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teParamedisTelepon1.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teParamedisTelepon1.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.teParamedisTelepon1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teParamedisTelepon1.Properties.MaxLength = 30
        Me.teParamedisTelepon1.Properties.ReadOnly = True
        Me.teParamedisTelepon1.Size = New System.Drawing.Size(157, 20)
        Me.teParamedisTelepon1.TabIndex = 29
        Me.teParamedisTelepon1.Tag = ""
        '
        'lueParamedis
        '
        Me.lueParamedis.Location = New System.Drawing.Point(113, 7)
        Me.lueParamedis.Name = "lueParamedis"
        Me.lueParamedis.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueParamedis.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueParamedis.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lueParamedis.Properties.Appearance.Options.UseBackColor = True
        Me.lueParamedis.Properties.Appearance.Options.UseFont = True
        Me.lueParamedis.Properties.Appearance.Options.UseForeColor = True
        Me.lueParamedis.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueParamedis.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueParamedis.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.lueParamedis.Properties.AppearanceDisabled.Options.UseFont = True
        Me.lueParamedis.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueParamedis.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueParamedis.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.lueParamedis.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.lueParamedis.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lueParamedis.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueParamedis.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueParamedis.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueParamedis.Properties.NullText = "[Isian belum dipilih]"
        Me.lueParamedis.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueParamedis.Properties.ShowPopupShadow = False
        Me.lueParamedis.Size = New System.Drawing.Size(254, 20)
        Me.lueParamedis.TabIndex = 44
        Me.lueParamedis.Tag = ""
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(47, 81)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 14)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Telepon 2"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(47, 57)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 14)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Telepon 1"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(15, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 14)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Nama Paramedis"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(60, 33)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 14)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Spesialis"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Controls.Add(Me.btnAppHarian)
        Me.pHeader.Controls.Add(Me.btnAppPasien)
        Me.pHeader.Controls.Add(Me.btnAppDokter)
        Me.pHeader.Controls.Add(Me.btnShowHideParamedis)
        Me.pHeader.Controls.Add(Me.btnRefreshPasien)
        Me.pHeader.Controls.Add(Me.btnShowHidePasien)
        Me.pHeader.Controls.Add(Me.btnRefreshDokter)
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.ForeColor = System.Drawing.Color.White
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(1239, 30)
        Me.pHeader.TabIndex = 4
        '
        'btnAppHarian
        '
        Me.btnAppHarian.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAppHarian.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAppHarian.FlatAppearance.BorderSize = 0
        Me.btnAppHarian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAppHarian.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnAppHarian.ForeColor = System.Drawing.Color.White
        Me.btnAppHarian.Location = New System.Drawing.Point(500, 0)
        Me.btnAppHarian.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAppHarian.Name = "btnAppHarian"
        Me.btnAppHarian.Size = New System.Drawing.Size(120, 30)
        Me.btnAppHarian.TabIndex = 38
        Me.btnAppHarian.Text = "MON APP HARIAN"
        Me.btnAppHarian.UseVisualStyleBackColor = False
        '
        'btnAppPasien
        '
        Me.btnAppPasien.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAppPasien.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAppPasien.FlatAppearance.BorderSize = 0
        Me.btnAppPasien.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAppPasien.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnAppPasien.ForeColor = System.Drawing.Color.White
        Me.btnAppPasien.Location = New System.Drawing.Point(380, 0)
        Me.btnAppPasien.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAppPasien.Name = "btnAppPasien"
        Me.btnAppPasien.Size = New System.Drawing.Size(120, 30)
        Me.btnAppPasien.TabIndex = 37
        Me.btnAppPasien.Text = "MON APP PASIEN"
        Me.btnAppPasien.UseVisualStyleBackColor = False
        '
        'btnAppDokter
        '
        Me.btnAppDokter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAppDokter.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAppDokter.FlatAppearance.BorderSize = 0
        Me.btnAppDokter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAppDokter.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnAppDokter.ForeColor = System.Drawing.Color.White
        Me.btnAppDokter.Location = New System.Drawing.Point(260, 0)
        Me.btnAppDokter.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAppDokter.Name = "btnAppDokter"
        Me.btnAppDokter.Size = New System.Drawing.Size(120, 30)
        Me.btnAppDokter.TabIndex = 36
        Me.btnAppDokter.Text = "MON APP DOKTER"
        Me.btnAppDokter.UseVisualStyleBackColor = False
        '
        'btnShowHideParamedis
        '
        Me.btnShowHideParamedis.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnShowHideParamedis.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnShowHideParamedis.FlatAppearance.BorderSize = 0
        Me.btnShowHideParamedis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowHideParamedis.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnShowHideParamedis.ForeColor = System.Drawing.Color.White
        Me.btnShowHideParamedis.Location = New System.Drawing.Point(120, 0)
        Me.btnShowHideParamedis.Margin = New System.Windows.Forms.Padding(0)
        Me.btnShowHideParamedis.Name = "btnShowHideParamedis"
        Me.btnShowHideParamedis.Size = New System.Drawing.Size(140, 30)
        Me.btnShowHideParamedis.TabIndex = 35
        Me.btnShowHideParamedis.Text = "<< PARAMEDIS DATA"
        Me.btnShowHideParamedis.UseVisualStyleBackColor = False
        '
        'btnRefreshPasien
        '
        Me.btnRefreshPasien.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRefreshPasien.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnRefreshPasien.FlatAppearance.BorderSize = 0
        Me.btnRefreshPasien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnRefreshPasien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnRefreshPasien.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefreshPasien.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefreshPasien.Location = New System.Drawing.Point(979, 0)
        Me.btnRefreshPasien.Name = "btnRefreshPasien"
        Me.btnRefreshPasien.Size = New System.Drawing.Size(120, 30)
        Me.btnRefreshPasien.TabIndex = 4
        Me.btnRefreshPasien.Text = "REFRESH PASIEN"
        Me.btnRefreshPasien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRefreshPasien.UseVisualStyleBackColor = False
        '
        'btnShowHidePasien
        '
        Me.btnShowHidePasien.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnShowHidePasien.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnShowHidePasien.FlatAppearance.BorderSize = 0
        Me.btnShowHidePasien.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowHidePasien.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnShowHidePasien.ForeColor = System.Drawing.Color.White
        Me.btnShowHidePasien.Location = New System.Drawing.Point(0, 0)
        Me.btnShowHidePasien.Margin = New System.Windows.Forms.Padding(0)
        Me.btnShowHidePasien.Name = "btnShowHidePasien"
        Me.btnShowHidePasien.Size = New System.Drawing.Size(120, 30)
        Me.btnShowHidePasien.TabIndex = 34
        Me.btnShowHidePasien.Text = "<< PASIEN DATA"
        Me.btnShowHidePasien.UseVisualStyleBackColor = False
        '
        'btnRefreshDokter
        '
        Me.btnRefreshDokter.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRefreshDokter.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnRefreshDokter.FlatAppearance.BorderSize = 0
        Me.btnRefreshDokter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnRefreshDokter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnRefreshDokter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefreshDokter.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefreshDokter.Location = New System.Drawing.Point(1099, 0)
        Me.btnRefreshDokter.Name = "btnRefreshDokter"
        Me.btnRefreshDokter.Size = New System.Drawing.Size(140, 30)
        Me.btnRefreshDokter.TabIndex = 3
        Me.btnRefreshDokter.Text = "REFRESH PARAMEDIS"
        Me.btnRefreshDokter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRefreshDokter.UseVisualStyleBackColor = False
        '
        'lblSep5
        '
        Me.lblSep5.BackColor = System.Drawing.Color.Transparent
        Me.lblSep5.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblSep5.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSep5.Location = New System.Drawing.Point(74, 0)
        Me.lblSep5.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSep5.Name = "lblSep5"
        Me.lblSep5.Size = New System.Drawing.Size(16, 1)
        Me.lblSep5.TabIndex = 19
        Me.lblSep5.Text = "|"
        Me.lblSep5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1243, 700)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAppointment"
        Me.ShowInTaskbar = False
        Me.Text = "Appointment"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        Me.tlpAppointment.ResumeLayout(False)
        Me.pnlKanan.ResumeLayout(False)
        Me.pnlPasienSesi.ResumeLayout(False)
        Me.tlpPasienSesi.ResumeLayout(False)
        Me.tlpScheduleDate.ResumeLayout(False)
        Me.tlpScheduleDate.PerformLayout()
        Me.tlpJadwalSesi.ResumeLayout(False)
        Me.tlpJadwalSesi.PerformLayout()
        CType(Me.lueJadwalSesi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcSlot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcSlot.ResumeLayout(False)
        Me.pnlSlot.ResumeLayout(False)
        Me.pnlInfoSlot.ResumeLayout(False)
        CType(Me.pbcIconSlot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcDataPasien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcDataPasien.ResumeLayout(False)
        CType(Me.xtccPatientData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtccPatientData.ResumeLayout(False)
        Me.xtpPasienLama.ResumeLayout(False)
        Me.tlpPasienLama.ResumeLayout(False)
        Me.tlpPasienLama.PerformLayout()
        CType(Me.teLamaRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueLamaNama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teLamaAlamat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLamaNoRM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teLamaTelepon2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teLamaTelepon1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teLamaJenisKelamin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teLamaTanggalLahir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpPasienBaru.ResumeLayout(False)
        Me.tlpPasienBaru.ResumeLayout(False)
        Me.tlpPasienBaru.PerformLayout()
        CType(Me.teBaruRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deBaruTanggalLahir.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deBaruTanggalLahir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueBaruJenisKelamin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teBaruAlamat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teBaruNoRM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teBaruNama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teBaruTelepon2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teBaruTelepon1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInfo.ResumeLayout(False)
        CType(Me.pbcIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDoctor.ResumeLayout(False)
        CType(Me.xtcTanggal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcTanggal.ResumeLayout(False)
        Me.xtpTanggalSlot.ResumeLayout(False)
        Me.pnlTanggal.ResumeLayout(False)
        Me.xtpTanggalKalender.ResumeLayout(False)
        CType(Me.dnKalender.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dnKalender, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcParamedis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcParamedis.ResumeLayout(False)
        Me.tlpParamedis.ResumeLayout(False)
        Me.tlpParamedis.PerformLayout()
        CType(Me.lueSpesialis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teParamedisTelepon2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teParamedisTelepon1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueParamedis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblSep5 As System.Windows.Forms.Label
    Public WithEvents pHeader As System.Windows.Forms.Panel
    Public WithEvents pBody As System.Windows.Forms.Panel
    Public WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Public WithEvents btnRefreshPasien As System.Windows.Forms.Button
    Public WithEvents btnRefreshDokter As System.Windows.Forms.Button
    Friend WithEvents tlpAppointment As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents panelDoctor As System.Windows.Forms.Panel
    Friend WithEvents gcParamedis As DevExpress.XtraEditors.GroupControl
    Friend WithEvents tlpParamedis As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents teParamedisTelepon2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teParamedisTelepon1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lueParamedis As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lueSpesialis As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents pnlKanan As System.Windows.Forms.Panel
    Friend WithEvents btnShowHidePasien As System.Windows.Forms.Button
    Friend WithEvents lblTanggal As System.Windows.Forms.Label
    Friend WithEvents gcDataPasien As DevExpress.XtraEditors.GroupControl
    Friend WithEvents xtccPatientData As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpPasienLama As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tlpPasienLama As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents teLamaAlamat As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lueLamaNoRM As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents teLamaTelepon2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teLamaTelepon1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents teLamaJenisKelamin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents teLamaTanggalLahir As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents xtpPasienBaru As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tlpPasienBaru As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents teBaruAlamat As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents teBaruNoRM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teBaruNama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teBaruTelepon2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teBaruTelepon1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents pnlInfo As System.Windows.Forms.Panel
    Friend WithEvents lblcContent As System.Windows.Forms.Label
    Friend WithEvents lblcTitle As System.Windows.Forms.Label
    Friend WithEvents pbcIcon As System.Windows.Forms.PictureBox
    Friend WithEvents tlpPasienSesi As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpJadwalSesi As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lueJadwalSesi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tlpScheduleDate As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlPasienSesi As System.Windows.Forms.Panel
    Friend WithEvents gcSlot As DevExpress.XtraEditors.GroupControl
    Friend WithEvents pnlSlot As System.Windows.Forms.Panel
    Friend WithEvents pnlTanggal As System.Windows.Forms.Panel
    Friend WithEvents tlpTanggal As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents xtcTanggal As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpTanggalSlot As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpTanggalKalender As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents dnKalender As DevExpress.XtraScheduler.DateNavigator
    Friend WithEvents btnRefreshSlot As System.Windows.Forms.Button
    Friend WithEvents tlpSlot As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnShowHideParamedis As System.Windows.Forms.Button
    Friend WithEvents lueBaruJenisKelamin As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents deBaruTanggalLahir As DevExpress.XtraEditors.DateEdit
    Friend WithEvents pnlInfoSlot As Panel
    Friend WithEvents lblcContentSlot As Label
    Friend WithEvents lblcTitleSlot As Label
    Friend WithEvents pbcIconSlot As PictureBox
    Friend WithEvents slueLamaNama As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents slueView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAppPasien As Button
    Friend WithEvents btnAppDokter As Button
    Friend WithEvents btnAppHarian As Button
    Friend WithEvents teLamaRemarks As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teBaruRemarks As DevExpress.XtraEditors.TextEdit
End Class
