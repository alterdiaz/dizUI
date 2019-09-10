<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFarmasiRujukan
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
        Dim TileItemElement1 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement2 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement3 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Me.tlpForm = New System.Windows.Forms.TableLayoutPanel()
        Me.pTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pMinimize = New System.Windows.Forms.PictureBox()
        Me.pMaximize = New System.Windows.Forms.PictureBox()
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.pBody = New System.Windows.Forms.Panel()
        Me.xtcProfile = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpEntry = New DevExpress.XtraTab.XtraTabPage()
        Me.pEntry = New System.Windows.Forms.Panel()
        Me.xtcAdditional = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpAddress = New DevExpress.XtraTab.XtraTabPage()
        Me.pAlamat = New System.Windows.Forms.Panel()
        Me.gcAlamat = New DevExpress.XtraGrid.GridControl()
        Me.gvAlamat = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn55 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn56 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn86 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpAlamat1 = New System.Windows.Forms.TableLayoutPanel()
        Me.teKodepos = New DevExpress.XtraEditors.TextEdit()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.lueNegara = New DevExpress.XtraEditors.LookUpEdit()
        Me.luePropinsi = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueKabupaten = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblNegara = New System.Windows.Forms.Label()
        Me.lblPropinsi = New System.Windows.Forms.Label()
        Me.lblKabupaten = New System.Windows.Forms.Label()
        Me.lueKecamatan = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblKelurahan = New System.Windows.Forms.Label()
        Me.lblKecamatan = New System.Windows.Forms.Label()
        Me.lueKelurahan = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lueAddressType = New DevExpress.XtraEditors.LookUpEdit()
        Me.tlpAlamat2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblAlamat = New System.Windows.Forms.Label()
        Me.meAlamat = New DevExpress.XtraEditors.MemoEdit()
        Me.pHeaderAlamat = New System.Windows.Forms.Panel()
        Me.btnNewAlamat = New System.Windows.Forms.Button()
        Me.btnSaveAlamat = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnPrimaryAlamat = New System.Windows.Forms.Button()
        Me.btnDeleteAlamat = New System.Windows.Forms.Button()
        Me.xtpEmail = New DevExpress.XtraTab.XtraTabPage()
        Me.pEmail = New System.Windows.Forms.Panel()
        Me.gcEmail = New DevExpress.XtraGrid.GridControl()
        Me.gvEmail = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn28 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn29 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tlpEmail = New System.Windows.Forms.TableLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.teEmail = New DevExpress.XtraEditors.TextEdit()
        Me.lueEmailType = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pHeaderEmail = New System.Windows.Forms.Panel()
        Me.btnNewEmail = New System.Windows.Forms.Button()
        Me.btnSaveEmail = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnPrimaryEmail = New System.Windows.Forms.Button()
        Me.btnDeleteEmail = New System.Windows.Forms.Button()
        Me.xtpTelepon = New DevExpress.XtraTab.XtraTabPage()
        Me.pTelepon = New System.Windows.Forms.Panel()
        Me.gcTelepon = New DevExpress.XtraGrid.GridControl()
        Me.gvTelepon = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn85 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn30 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn31 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn32 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tlpTelepon = New System.Windows.Forms.TableLayoutPanel()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.teExtension = New DevExpress.XtraEditors.TextEdit()
        Me.lblHandphone = New System.Windows.Forms.Label()
        Me.tePhone = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.luePhoneType = New DevExpress.XtraEditors.LookUpEdit()
        Me.pHeaderTelepon = New System.Windows.Forms.Panel()
        Me.btnNewTelepon = New System.Windows.Forms.Button()
        Me.btnSaveTelepon = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnPrimaryTelepon = New System.Windows.Forms.Button()
        Me.btnDeleteTelepon = New System.Windows.Forms.Button()
        Me.tbAdditional = New DevExpress.XtraBars.Navigation.TileBar()
        Me.TileBarGroup2 = New DevExpress.XtraBars.Navigation.TileBarGroup()
        Me.tbiAlamat = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.tbiEmail = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.tbiTelepon = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.tlpField = New System.Windows.Forms.TableLayoutPanel()
        Me.lueType = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.teKode = New DevExpress.XtraEditors.TextEdit()
        Me.lblParent = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.teNama = New DevExpress.XtraEditors.TextEdit()
        Me.luePaymentType = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.xtpData = New DevExpress.XtraTab.XtraTabPage()
        Me.gcData = New DevExpress.XtraGrid.GridControl()
        Me.gvData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcbptype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcisdeleted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcpaymenttype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcKode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcNama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcStatData = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcJenisPembayaran = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblSep5 = New System.Windows.Forms.Label()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBody.SuspendLayout()
        CType(Me.xtcProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcProfile.SuspendLayout()
        Me.xtpEntry.SuspendLayout()
        Me.pEntry.SuspendLayout()
        CType(Me.xtcAdditional, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcAdditional.SuspendLayout()
        Me.xtpAddress.SuspendLayout()
        Me.pAlamat.SuspendLayout()
        CType(Me.gcAlamat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvAlamat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.tlpAlamat1.SuspendLayout()
        CType(Me.teKodepos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueNegara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePropinsi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueKabupaten.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueKecamatan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueKelurahan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueAddressType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpAlamat2.SuspendLayout()
        CType(Me.meAlamat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeaderAlamat.SuspendLayout()
        Me.xtpEmail.SuspendLayout()
        Me.pEmail.SuspendLayout()
        CType(Me.gcEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpEmail.SuspendLayout()
        CType(Me.teEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueEmailType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeaderEmail.SuspendLayout()
        Me.xtpTelepon.SuspendLayout()
        Me.pTelepon.SuspendLayout()
        CType(Me.gcTelepon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvTelepon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpTelepon.SuspendLayout()
        CType(Me.teExtension.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tePhone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePhoneType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeaderTelepon.SuspendLayout()
        Me.tlpField.SuspendLayout()
        CType(Me.lueType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teKode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePaymentType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpData.SuspendLayout()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpForm
        '
        Me.tlpForm.BackColor = System.Drawing.Color.DarkOliveGreen
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
        Me.tlpForm.Size = New System.Drawing.Size(790, 408)
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
        Me.pTitle.Size = New System.Drawing.Size(786, 30)
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
        Me.lblTitle.Size = New System.Drawing.Size(696, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Farmasi Rujukan"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pMinimize
        '
        Me.pMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.pMinimize.Image = Global.dizUI.My.Resources.Resources.min_w
        Me.pMinimize.Location = New System.Drawing.Point(696, 0)
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
        Me.pMaximize.Location = New System.Drawing.Point(726, 0)
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
        Me.pExit.Location = New System.Drawing.Point(756, 0)
        Me.pExit.Margin = New System.Windows.Forms.Padding(0)
        Me.pExit.Name = "pExit"
        Me.pExit.Size = New System.Drawing.Size(30, 30)
        Me.pExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pExit.TabIndex = 9
        Me.pExit.TabStop = False
        '
        'pBody
        '
        Me.pBody.Controls.Add(Me.xtcProfile)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(786, 378)
        Me.pBody.TabIndex = 7
        '
        'xtcProfile
        '
        Me.xtcProfile.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.xtcProfile.Appearance.Options.UseBackColor = True
        Me.xtcProfile.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcProfile.AppearancePage.Header.Options.UseFont = True
        Me.xtcProfile.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcProfile.AppearancePage.HeaderActive.Options.UseFont = True
        Me.xtcProfile.AppearancePage.HeaderDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcProfile.AppearancePage.HeaderDisabled.Options.UseFont = True
        Me.xtcProfile.AppearancePage.HeaderHotTracked.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcProfile.AppearancePage.HeaderHotTracked.Options.UseFont = True
        Me.xtcProfile.AppearancePage.PageClient.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcProfile.AppearancePage.PageClient.Options.UseFont = True
        Me.xtcProfile.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.xtcProfile.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.xtcProfile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtcProfile.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[False]
        Me.xtcProfile.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Right
        Me.xtcProfile.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
        Me.xtcProfile.Location = New System.Drawing.Point(0, 30)
        Me.xtcProfile.Margin = New System.Windows.Forms.Padding(0)
        Me.xtcProfile.Name = "xtcProfile"
        Me.xtcProfile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.xtcProfile.SelectedTabPage = Me.xtpEntry
        Me.xtcProfile.Size = New System.Drawing.Size(786, 348)
        Me.xtcProfile.TabIndex = 19
        Me.xtcProfile.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpEntry, Me.xtpData})
        '
        'xtpEntry
        '
        Me.xtpEntry.Appearance.PageClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.xtpEntry.Appearance.PageClient.Options.UseBackColor = True
        Me.xtpEntry.Controls.Add(Me.pEntry)
        Me.xtpEntry.Name = "xtpEntry"
        Me.xtpEntry.Size = New System.Drawing.Size(734, 342)
        Me.xtpEntry.Text = "ISIAN"
        '
        'pEntry
        '
        Me.pEntry.AutoScroll = True
        Me.pEntry.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pEntry.Controls.Add(Me.xtcAdditional)
        Me.pEntry.Controls.Add(Me.tbAdditional)
        Me.pEntry.Controls.Add(Me.tlpField)
        Me.pEntry.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pEntry.Location = New System.Drawing.Point(0, 0)
        Me.pEntry.Name = "pEntry"
        Me.pEntry.Size = New System.Drawing.Size(734, 342)
        Me.pEntry.TabIndex = 0
        '
        'xtcAdditional
        '
        Me.xtcAdditional.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.xtcAdditional.Appearance.Options.UseBackColor = True
        Me.xtcAdditional.AppearancePage.PageClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.xtcAdditional.AppearancePage.PageClient.Options.UseBackColor = True
        Me.xtcAdditional.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.xtcAdditional.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.xtcAdditional.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtcAdditional.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[True]
        Me.xtcAdditional.HeaderButtons = DevExpress.XtraTab.TabButtons.None
        Me.xtcAdditional.HeaderButtonsShowMode = DevExpress.XtraTab.TabButtonShowMode.Never
        Me.xtcAdditional.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Right
        Me.xtcAdditional.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
        Me.xtcAdditional.Location = New System.Drawing.Point(0, 108)
        Me.xtcAdditional.Name = "xtcAdditional"
        Me.xtcAdditional.SelectedTabPage = Me.xtpAddress
        Me.xtcAdditional.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.[True]
        Me.xtcAdditional.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[False]
        Me.xtcAdditional.ShowToolTips = DevExpress.Utils.DefaultBoolean.[True]
        Me.xtcAdditional.Size = New System.Drawing.Size(734, 234)
        Me.xtcAdditional.TabIndex = 14
        Me.xtcAdditional.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpAddress, Me.xtpEmail, Me.xtpTelepon})
        '
        'xtpAddress
        '
        Me.xtpAddress.Appearance.PageClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.xtpAddress.Appearance.PageClient.Options.UseBackColor = True
        Me.xtpAddress.Controls.Add(Me.pAlamat)
        Me.xtpAddress.Controls.Add(Me.pHeaderAlamat)
        Me.xtpAddress.Name = "xtpAddress"
        Me.xtpAddress.Size = New System.Drawing.Size(728, 228)
        Me.xtpAddress.Text = "ALAMAT"
        '
        'pAlamat
        '
        Me.pAlamat.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pAlamat.Controls.Add(Me.gcAlamat)
        Me.pAlamat.Controls.Add(Me.TableLayoutPanel3)
        Me.pAlamat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pAlamat.Location = New System.Drawing.Point(0, 30)
        Me.pAlamat.Name = "pAlamat"
        Me.pAlamat.Size = New System.Drawing.Size(728, 198)
        Me.pAlamat.TabIndex = 11
        '
        'gcAlamat
        '
        Me.gcAlamat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcAlamat.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gcAlamat.Location = New System.Drawing.Point(0, 156)
        Me.gcAlamat.MainView = Me.gvAlamat
        Me.gcAlamat.Margin = New System.Windows.Forms.Padding(0)
        Me.gcAlamat.Name = "gcAlamat"
        Me.gcAlamat.Size = New System.Drawing.Size(728, 42)
        Me.gcAlamat.TabIndex = 43
        Me.gcAlamat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvAlamat})
        '
        'gvAlamat
        '
        Me.gvAlamat.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gvAlamat.Appearance.Empty.Options.UseBackColor = True
        Me.gvAlamat.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvAlamat.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvAlamat.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvAlamat.Appearance.OddRow.Options.UseBackColor = True
        Me.gvAlamat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn55, Me.GridColumn11, Me.GridColumn3, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.GridColumn27, Me.GridColumn2, Me.GridColumn56, Me.GridColumn86})
        Me.gvAlamat.GridControl = Me.gcAlamat
        Me.gvAlamat.Name = "gvAlamat"
        Me.gvAlamat.OptionsView.ColumnAutoWidth = False
        Me.gvAlamat.OptionsView.EnableAppearanceEvenRow = True
        Me.gvAlamat.OptionsView.EnableAppearanceOddRow = True
        Me.gvAlamat.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn1.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn1.Caption = "ID"
        Me.GridColumn1.FieldName = "idalamat"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "ID Negara"
        Me.GridColumn5.FieldName = "idnegara"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "ID Propinsi"
        Me.GridColumn6.FieldName = "idpropinsi"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "ID Kabupaten"
        Me.GridColumn7.FieldName = "idkabupaten"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "ID Kecamatan"
        Me.GridColumn8.FieldName = "idkecamatan"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "ID Kelurahan"
        Me.GridColumn9.FieldName = "idkelurahan"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.OptionsColumn.ReadOnly = True
        '
        'GridColumn55
        '
        Me.GridColumn55.Caption = "AddressType"
        Me.GridColumn55.FieldName = "addresstype"
        Me.GridColumn55.Name = "GridColumn55"
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Status Data"
        Me.GridColumn11.FieldName = "isdeleted"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.OptionsColumn.ReadOnly = True
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Is Primary"
        Me.GridColumn3.FieldName = "isprimary"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        '
        'GridColumn17
        '
        Me.GridColumn17.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn17.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn17.Caption = "Alamat"
        Me.GridColumn17.FieldName = "alamat"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.AllowEdit = False
        Me.GridColumn17.OptionsColumn.ReadOnly = True
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 6
        Me.GridColumn17.Width = 200
        '
        'GridColumn18
        '
        Me.GridColumn18.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn18.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn18.Caption = "Negara"
        Me.GridColumn18.FieldName = "negara"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.OptionsColumn.AllowEdit = False
        Me.GridColumn18.OptionsColumn.ReadOnly = True
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 1
        '
        'GridColumn19
        '
        Me.GridColumn19.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn19.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn19.Caption = "Propinsi"
        Me.GridColumn19.FieldName = "propinsi"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.OptionsColumn.AllowEdit = False
        Me.GridColumn19.OptionsColumn.ReadOnly = True
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 2
        '
        'GridColumn20
        '
        Me.GridColumn20.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn20.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn20.Caption = "Kabupaten"
        Me.GridColumn20.FieldName = "kabupaten"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.OptionsColumn.AllowEdit = False
        Me.GridColumn20.OptionsColumn.ReadOnly = True
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 3
        '
        'GridColumn21
        '
        Me.GridColumn21.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn21.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn21.Caption = "Kecamatan"
        Me.GridColumn21.FieldName = "kecamatan"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.OptionsColumn.AllowEdit = False
        Me.GridColumn21.OptionsColumn.ReadOnly = True
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 4
        '
        'GridColumn22
        '
        Me.GridColumn22.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn22.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn22.Caption = "Kelurahan"
        Me.GridColumn22.FieldName = "kelurahan"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.OptionsColumn.AllowEdit = False
        Me.GridColumn22.OptionsColumn.ReadOnly = True
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 5
        '
        'GridColumn27
        '
        Me.GridColumn27.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn27.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn27.Caption = "Status Data"
        Me.GridColumn27.FieldName = "statdata"
        Me.GridColumn27.Name = "GridColumn27"
        Me.GridColumn27.OptionsColumn.AllowEdit = False
        Me.GridColumn27.OptionsColumn.ReadOnly = True
        Me.GridColumn27.Visible = True
        Me.GridColumn27.VisibleIndex = 9
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Primary"
        Me.GridColumn2.FieldName = "primary"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 8
        '
        'GridColumn56
        '
        Me.GridColumn56.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn56.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn56.Caption = "Jenis Alamat"
        Me.GridColumn56.FieldName = "jenisalamat"
        Me.GridColumn56.Name = "GridColumn56"
        Me.GridColumn56.OptionsColumn.AllowEdit = False
        Me.GridColumn56.OptionsColumn.ReadOnly = True
        Me.GridColumn56.Visible = True
        Me.GridColumn56.VisibleIndex = 0
        Me.GridColumn56.Width = 89
        '
        'GridColumn86
        '
        Me.GridColumn86.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn86.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn86.Caption = "Kodepos"
        Me.GridColumn86.FieldName = "kodepos"
        Me.GridColumn86.Name = "GridColumn86"
        Me.GridColumn86.OptionsColumn.AllowEdit = False
        Me.GridColumn86.OptionsColumn.ReadOnly = True
        Me.GridColumn86.Visible = True
        Me.GridColumn86.VisibleIndex = 7
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 540.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.tlpAlamat1, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.tlpAlamat2, 1, 2)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(728, 156)
        Me.TableLayoutPanel3.TabIndex = 10
        '
        'tlpAlamat1
        '
        Me.tlpAlamat1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tlpAlamat1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlpAlamat1.ColumnCount = 4
        Me.tlpAlamat1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpAlamat1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpAlamat1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpAlamat1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpAlamat1.Controls.Add(Me.teKodepos, 3, 2)
        Me.tlpAlamat1.Controls.Add(Me.Label42, 2, 2)
        Me.tlpAlamat1.Controls.Add(Me.lueNegara, 1, 0)
        Me.tlpAlamat1.Controls.Add(Me.luePropinsi, 1, 1)
        Me.tlpAlamat1.Controls.Add(Me.lueKabupaten, 1, 2)
        Me.tlpAlamat1.Controls.Add(Me.lblNegara, 0, 0)
        Me.tlpAlamat1.Controls.Add(Me.lblPropinsi, 0, 1)
        Me.tlpAlamat1.Controls.Add(Me.lblKabupaten, 0, 2)
        Me.tlpAlamat1.Controls.Add(Me.lueKecamatan, 3, 0)
        Me.tlpAlamat1.Controls.Add(Me.lblKelurahan, 2, 1)
        Me.tlpAlamat1.Controls.Add(Me.lblKecamatan, 2, 0)
        Me.tlpAlamat1.Controls.Add(Me.lueKelurahan, 3, 1)
        Me.tlpAlamat1.Controls.Add(Me.Label6, 0, 3)
        Me.tlpAlamat1.Controls.Add(Me.lueAddressType, 1, 3)
        Me.tlpAlamat1.Location = New System.Drawing.Point(94, 6)
        Me.tlpAlamat1.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpAlamat1.Name = "tlpAlamat1"
        Me.tlpAlamat1.RowCount = 4
        Me.tlpAlamat1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpAlamat1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpAlamat1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpAlamat1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpAlamat1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpAlamat1.Size = New System.Drawing.Size(540, 96)
        Me.tlpAlamat1.TabIndex = 8
        '
        'teKodepos
        '
        Me.teKodepos.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teKodepos.Location = New System.Drawing.Point(390, 50)
        Me.teKodepos.Margin = New System.Windows.Forms.Padding(0)
        Me.teKodepos.Name = "teKodepos"
        Me.teKodepos.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teKodepos.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teKodepos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teKodepos.Properties.Appearance.Options.UseBackColor = True
        Me.teKodepos.Properties.Appearance.Options.UseFont = True
        Me.teKodepos.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teKodepos.Properties.MaxLength = 300
        Me.teKodepos.Properties.NullText = "[Belum Diisi]"
        Me.teKodepos.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teKodepos.Size = New System.Drawing.Size(133, 20)
        Me.teKodepos.TabIndex = 41
        Me.teKodepos.Tag = "kodepos"
        '
        'Label42
        '
        Me.Label42.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(329, 53)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(58, 14)
        Me.Label42.TabIndex = 54
        Me.Label42.Text = "Kode Pos"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueNegara
        '
        Me.lueNegara.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueNegara.Location = New System.Drawing.Point(120, 2)
        Me.lueNegara.Margin = New System.Windows.Forms.Padding(0)
        Me.lueNegara.Name = "lueNegara"
        Me.lueNegara.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.lueNegara.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueNegara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueNegara.Properties.Appearance.Options.UseBackColor = True
        Me.lueNegara.Properties.Appearance.Options.UseFont = True
        Me.lueNegara.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueNegara.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueNegara.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueNegara.Properties.NullText = "[Isian belum dipilih]"
        Me.lueNegara.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueNegara.Size = New System.Drawing.Size(150, 20)
        Me.lueNegara.TabIndex = 35
        Me.lueNegara.Tag = "idnegara"
        '
        'luePropinsi
        '
        Me.luePropinsi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.luePropinsi.Location = New System.Drawing.Point(120, 26)
        Me.luePropinsi.Margin = New System.Windows.Forms.Padding(0)
        Me.luePropinsi.Name = "luePropinsi"
        Me.luePropinsi.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.luePropinsi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.luePropinsi.Properties.Appearance.Options.UseBackColor = True
        Me.luePropinsi.Properties.Appearance.Options.UseFont = True
        Me.luePropinsi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.luePropinsi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePropinsi.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.luePropinsi.Properties.NullText = "[Isian belum dipilih]"
        Me.luePropinsi.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.luePropinsi.Size = New System.Drawing.Size(150, 20)
        Me.luePropinsi.TabIndex = 36
        Me.luePropinsi.Tag = "idpropinsi"
        '
        'lueKabupaten
        '
        Me.lueKabupaten.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueKabupaten.Location = New System.Drawing.Point(120, 50)
        Me.lueKabupaten.Margin = New System.Windows.Forms.Padding(0)
        Me.lueKabupaten.Name = "lueKabupaten"
        Me.lueKabupaten.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueKabupaten.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueKabupaten.Properties.Appearance.Options.UseBackColor = True
        Me.lueKabupaten.Properties.Appearance.Options.UseFont = True
        Me.lueKabupaten.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueKabupaten.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueKabupaten.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueKabupaten.Properties.NullText = "[Isian belum dipilih]"
        Me.lueKabupaten.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueKabupaten.Size = New System.Drawing.Size(150, 20)
        Me.lueKabupaten.TabIndex = 37
        Me.lueKabupaten.Tag = "idkabupaten"
        '
        'lblNegara
        '
        Me.lblNegara.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblNegara.AutoSize = True
        Me.lblNegara.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNegara.Location = New System.Drawing.Point(54, 5)
        Me.lblNegara.Name = "lblNegara"
        Me.lblNegara.Size = New System.Drawing.Size(63, 14)
        Me.lblNegara.TabIndex = 32
        Me.lblNegara.Text = "Negara *1"
        Me.lblNegara.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPropinsi
        '
        Me.lblPropinsi.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblPropinsi.AutoSize = True
        Me.lblPropinsi.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPropinsi.Location = New System.Drawing.Point(51, 29)
        Me.lblPropinsi.Name = "lblPropinsi"
        Me.lblPropinsi.Size = New System.Drawing.Size(66, 14)
        Me.lblPropinsi.TabIndex = 30
        Me.lblPropinsi.Text = "Propinsi *2"
        Me.lblPropinsi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblKabupaten
        '
        Me.lblKabupaten.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblKabupaten.AutoSize = True
        Me.lblKabupaten.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKabupaten.Location = New System.Drawing.Point(3, 53)
        Me.lblKabupaten.Name = "lblKabupaten"
        Me.lblKabupaten.Size = New System.Drawing.Size(114, 14)
        Me.lblKabupaten.TabIndex = 40
        Me.lblKabupaten.Text = "Kota/Kabupaten *3"
        Me.lblKabupaten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueKecamatan
        '
        Me.lueKecamatan.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueKecamatan.Location = New System.Drawing.Point(390, 2)
        Me.lueKecamatan.Margin = New System.Windows.Forms.Padding(0)
        Me.lueKecamatan.Name = "lueKecamatan"
        Me.lueKecamatan.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueKecamatan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueKecamatan.Properties.Appearance.Options.UseBackColor = True
        Me.lueKecamatan.Properties.Appearance.Options.UseFont = True
        Me.lueKecamatan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueKecamatan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueKecamatan.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueKecamatan.Properties.NullText = "[Isian belum dipilih]"
        Me.lueKecamatan.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueKecamatan.Size = New System.Drawing.Size(150, 20)
        Me.lueKecamatan.TabIndex = 39
        Me.lueKecamatan.Tag = "idkecamatan"
        '
        'lblKelurahan
        '
        Me.lblKelurahan.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblKelurahan.AutoSize = True
        Me.lblKelurahan.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKelurahan.Location = New System.Drawing.Point(309, 29)
        Me.lblKelurahan.Name = "lblKelurahan"
        Me.lblKelurahan.Size = New System.Drawing.Size(78, 14)
        Me.lblKelurahan.TabIndex = 52
        Me.lblKelurahan.Text = "Kelurahan *5"
        Me.lblKelurahan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblKecamatan
        '
        Me.lblKecamatan.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblKecamatan.AutoSize = True
        Me.lblKecamatan.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKecamatan.Location = New System.Drawing.Point(302, 5)
        Me.lblKecamatan.Name = "lblKecamatan"
        Me.lblKecamatan.Size = New System.Drawing.Size(85, 14)
        Me.lblKecamatan.TabIndex = 50
        Me.lblKecamatan.Text = "Kecamatan *4"
        Me.lblKecamatan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueKelurahan
        '
        Me.lueKelurahan.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueKelurahan.Location = New System.Drawing.Point(390, 26)
        Me.lueKelurahan.Margin = New System.Windows.Forms.Padding(0)
        Me.lueKelurahan.Name = "lueKelurahan"
        Me.lueKelurahan.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueKelurahan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueKelurahan.Properties.Appearance.Options.UseBackColor = True
        Me.lueKelurahan.Properties.Appearance.Options.UseFont = True
        Me.lueKelurahan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueKelurahan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueKelurahan.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueKelurahan.Properties.NullText = "[Isian belum dipilih]"
        Me.lueKelurahan.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueKelurahan.Size = New System.Drawing.Size(150, 20)
        Me.lueKelurahan.TabIndex = 40
        Me.lueKelurahan.Tag = "idkelurahan"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(43, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 14)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Jenis Alamat"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueAddressType
        '
        Me.lueAddressType.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueAddressType.Location = New System.Drawing.Point(120, 74)
        Me.lueAddressType.Margin = New System.Windows.Forms.Padding(0)
        Me.lueAddressType.Name = "lueAddressType"
        Me.lueAddressType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueAddressType.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueAddressType.Properties.Appearance.Options.UseBackColor = True
        Me.lueAddressType.Properties.Appearance.Options.UseFont = True
        Me.lueAddressType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueAddressType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueAddressType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueAddressType.Properties.NullText = "[Isian belum dipilih]"
        Me.lueAddressType.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueAddressType.Size = New System.Drawing.Size(150, 20)
        Me.lueAddressType.TabIndex = 38
        Me.lueAddressType.Tag = "addresstype"
        '
        'tlpAlamat2
        '
        Me.tlpAlamat2.ColumnCount = 2
        Me.tlpAlamat2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpAlamat2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 420.0!))
        Me.tlpAlamat2.Controls.Add(Me.lblAlamat, 0, 0)
        Me.tlpAlamat2.Controls.Add(Me.meAlamat, 1, 0)
        Me.tlpAlamat2.Location = New System.Drawing.Point(94, 102)
        Me.tlpAlamat2.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpAlamat2.Name = "tlpAlamat2"
        Me.tlpAlamat2.RowCount = 1
        Me.tlpAlamat2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpAlamat2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpAlamat2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpAlamat2.Size = New System.Drawing.Size(540, 48)
        Me.tlpAlamat2.TabIndex = 9
        '
        'lblAlamat
        '
        Me.lblAlamat.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblAlamat.AutoSize = True
        Me.lblAlamat.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlamat.Location = New System.Drawing.Point(73, 17)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(44, 14)
        Me.lblAlamat.TabIndex = 48
        Me.lblAlamat.Text = "Alamat"
        Me.lblAlamat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'meAlamat
        '
        Me.meAlamat.Location = New System.Drawing.Point(120, 0)
        Me.meAlamat.Margin = New System.Windows.Forms.Padding(0)
        Me.meAlamat.Name = "meAlamat"
        Me.meAlamat.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.meAlamat.Properties.Appearance.Options.UseBackColor = True
        Me.meAlamat.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.meAlamat.Size = New System.Drawing.Size(420, 48)
        Me.meAlamat.TabIndex = 42
        Me.meAlamat.Tag = "alamat"
        '
        'pHeaderAlamat
        '
        Me.pHeaderAlamat.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeaderAlamat.Controls.Add(Me.btnNewAlamat)
        Me.pHeaderAlamat.Controls.Add(Me.btnSaveAlamat)
        Me.pHeaderAlamat.Controls.Add(Me.Label17)
        Me.pHeaderAlamat.Controls.Add(Me.btnPrimaryAlamat)
        Me.pHeaderAlamat.Controls.Add(Me.btnDeleteAlamat)
        Me.pHeaderAlamat.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeaderAlamat.ForeColor = System.Drawing.Color.White
        Me.pHeaderAlamat.Location = New System.Drawing.Point(0, 0)
        Me.pHeaderAlamat.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeaderAlamat.Name = "pHeaderAlamat"
        Me.pHeaderAlamat.Size = New System.Drawing.Size(728, 30)
        Me.pHeaderAlamat.TabIndex = 12
        '
        'btnNewAlamat
        '
        Me.btnNewAlamat.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnNewAlamat.FlatAppearance.BorderSize = 0
        Me.btnNewAlamat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnNewAlamat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnNewAlamat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewAlamat.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewAlamat.Location = New System.Drawing.Point(408, 0)
        Me.btnNewAlamat.Name = "btnNewAlamat"
        Me.btnNewAlamat.Size = New System.Drawing.Size(60, 30)
        Me.btnNewAlamat.TabIndex = 31
        Me.btnNewAlamat.Text = "BARU"
        Me.btnNewAlamat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNewAlamat.UseVisualStyleBackColor = True
        '
        'btnSaveAlamat
        '
        Me.btnSaveAlamat.BackColor = System.Drawing.Color.green
        Me.btnSaveAlamat.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSaveAlamat.FlatAppearance.BorderSize = 0
        Me.btnSaveAlamat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnSaveAlamat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnSaveAlamat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveAlamat.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveAlamat.Location = New System.Drawing.Point(468, 0)
        Me.btnSaveAlamat.Name = "btnSaveAlamat"
        Me.btnSaveAlamat.Size = New System.Drawing.Size(80, 30)
        Me.btnSaveAlamat.TabIndex = 32
        Me.btnSaveAlamat.Text = "SIMPAN"
        Me.btnSaveAlamat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveAlamat.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(0, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label17.Size = New System.Drawing.Size(200, 30)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Alamat"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnPrimaryAlamat
        '
        Me.btnPrimaryAlamat.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrimaryAlamat.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnPrimaryAlamat.FlatAppearance.BorderSize = 0
        Me.btnPrimaryAlamat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnPrimaryAlamat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnPrimaryAlamat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrimaryAlamat.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimaryAlamat.Location = New System.Drawing.Point(548, 0)
        Me.btnPrimaryAlamat.Name = "btnPrimaryAlamat"
        Me.btnPrimaryAlamat.Size = New System.Drawing.Size(100, 30)
        Me.btnPrimaryAlamat.TabIndex = 33
        Me.btnPrimaryAlamat.Text = "PRIMARY"
        Me.btnPrimaryAlamat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrimaryAlamat.UseVisualStyleBackColor = False
        '
        'btnDeleteAlamat
        '
        Me.btnDeleteAlamat.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDeleteAlamat.FlatAppearance.BorderSize = 0
        Me.btnDeleteAlamat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnDeleteAlamat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnDeleteAlamat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteAlamat.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteAlamat.Location = New System.Drawing.Point(648, 0)
        Me.btnDeleteAlamat.Name = "btnDeleteAlamat"
        Me.btnDeleteAlamat.Size = New System.Drawing.Size(80, 30)
        Me.btnDeleteAlamat.TabIndex = 34
        Me.btnDeleteAlamat.Text = "HAPUS"
        Me.btnDeleteAlamat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeleteAlamat.UseVisualStyleBackColor = True
        '
        'xtpEmail
        '
        Me.xtpEmail.Controls.Add(Me.pEmail)
        Me.xtpEmail.Controls.Add(Me.pHeaderEmail)
        Me.xtpEmail.Name = "xtpEmail"
        Me.xtpEmail.Size = New System.Drawing.Size(728, 228)
        Me.xtpEmail.Text = "EMAIL"
        '
        'pEmail
        '
        Me.pEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pEmail.Controls.Add(Me.gcEmail)
        Me.pEmail.Controls.Add(Me.tlpEmail)
        Me.pEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pEmail.Location = New System.Drawing.Point(0, 30)
        Me.pEmail.Margin = New System.Windows.Forms.Padding(0)
        Me.pEmail.Name = "pEmail"
        Me.pEmail.Size = New System.Drawing.Size(728, 198)
        Me.pEmail.TabIndex = 13
        '
        'gcEmail
        '
        Me.gcEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcEmail.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gcEmail.Location = New System.Drawing.Point(0, 36)
        Me.gcEmail.MainView = Me.gvEmail
        Me.gcEmail.Margin = New System.Windows.Forms.Padding(0)
        Me.gcEmail.Name = "gcEmail"
        Me.gcEmail.Size = New System.Drawing.Size(728, 162)
        Me.gcEmail.TabIndex = 87
        Me.gcEmail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvEmail})
        '
        'gvEmail
        '
        Me.gvEmail.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gvEmail.Appearance.Empty.Options.UseBackColor = True
        Me.gvEmail.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvEmail.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvEmail.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvEmail.Appearance.OddRow.Options.UseBackColor = True
        Me.gvEmail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn10, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn24, Me.GridColumn26, Me.GridColumn28, Me.GridColumn29})
        Me.gvEmail.GridControl = Me.gcEmail
        Me.gvEmail.Name = "gvEmail"
        Me.gvEmail.OptionsView.ColumnAutoWidth = False
        Me.gvEmail.OptionsView.EnableAppearanceEvenRow = True
        Me.gvEmail.OptionsView.EnableAppearanceOddRow = True
        Me.gvEmail.OptionsView.ShowGroupPanel = False
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn10.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn10.Caption = "ID"
        Me.GridColumn10.FieldName = "idphone"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.OptionsColumn.ReadOnly = True
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "ID PhoneType"
        Me.GridColumn12.FieldName = "phonetype"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.OptionsColumn.ReadOnly = True
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Status Data"
        Me.GridColumn13.FieldName = "isdeleted"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        Me.GridColumn13.OptionsColumn.ReadOnly = True
        '
        'GridColumn14
        '
        Me.GridColumn14.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn14.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn14.Caption = "Is Primary"
        Me.GridColumn14.FieldName = "isprimary"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.AllowEdit = False
        Me.GridColumn14.OptionsColumn.ReadOnly = True
        '
        'GridColumn24
        '
        Me.GridColumn24.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn24.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn24.Caption = "Email"
        Me.GridColumn24.FieldName = "email"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.OptionsColumn.AllowEdit = False
        Me.GridColumn24.OptionsColumn.ReadOnly = True
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 0
        Me.GridColumn24.Width = 100
        '
        'GridColumn26
        '
        Me.GridColumn26.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn26.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn26.Caption = "Jenis Email"
        Me.GridColumn26.FieldName = "jenisemail"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.OptionsColumn.AllowEdit = False
        Me.GridColumn26.OptionsColumn.ReadOnly = True
        Me.GridColumn26.Visible = True
        Me.GridColumn26.VisibleIndex = 1
        '
        'GridColumn28
        '
        Me.GridColumn28.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn28.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn28.Caption = "Status Data"
        Me.GridColumn28.FieldName = "statdata"
        Me.GridColumn28.Name = "GridColumn28"
        Me.GridColumn28.OptionsColumn.AllowEdit = False
        Me.GridColumn28.OptionsColumn.ReadOnly = True
        Me.GridColumn28.Visible = True
        Me.GridColumn28.VisibleIndex = 3
        '
        'GridColumn29
        '
        Me.GridColumn29.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn29.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn29.Caption = "Primary"
        Me.GridColumn29.FieldName = "primary"
        Me.GridColumn29.Name = "GridColumn29"
        Me.GridColumn29.OptionsColumn.AllowEdit = False
        Me.GridColumn29.OptionsColumn.ReadOnly = True
        Me.GridColumn29.Visible = True
        Me.GridColumn29.VisibleIndex = 2
        '
        'tlpEmail
        '
        Me.tlpEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlpEmail.ColumnCount = 6
        Me.tlpEmail.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpEmail.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpEmail.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpEmail.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpEmail.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpEmail.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpEmail.Controls.Add(Me.Label8, 1, 1)
        Me.tlpEmail.Controls.Add(Me.teEmail, 2, 1)
        Me.tlpEmail.Controls.Add(Me.lueEmailType, 4, 1)
        Me.tlpEmail.Controls.Add(Me.Label9, 3, 1)
        Me.tlpEmail.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpEmail.Location = New System.Drawing.Point(0, 0)
        Me.tlpEmail.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEmail.Name = "tlpEmail"
        Me.tlpEmail.RowCount = 3
        Me.tlpEmail.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpEmail.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpEmail.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpEmail.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpEmail.Size = New System.Drawing.Size(728, 36)
        Me.tlpEmail.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(177, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 14)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Email"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teEmail
        '
        Me.teEmail.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teEmail.Location = New System.Drawing.Point(214, 8)
        Me.teEmail.Margin = New System.Windows.Forms.Padding(0)
        Me.teEmail.Name = "teEmail"
        Me.teEmail.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teEmail.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teEmail.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teEmail.Properties.Appearance.Options.UseBackColor = True
        Me.teEmail.Properties.Appearance.Options.UseFont = True
        Me.teEmail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teEmail.Properties.MaxLength = 10
        Me.teEmail.Properties.NullText = "[Belum Diisi]"
        Me.teEmail.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teEmail.Size = New System.Drawing.Size(150, 20)
        Me.teEmail.TabIndex = 85
        Me.teEmail.Tag = "email"
        '
        'lueEmailType
        '
        Me.lueEmailType.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueEmailType.Location = New System.Drawing.Point(484, 8)
        Me.lueEmailType.Margin = New System.Windows.Forms.Padding(0)
        Me.lueEmailType.Name = "lueEmailType"
        Me.lueEmailType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueEmailType.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueEmailType.Properties.Appearance.Options.UseBackColor = True
        Me.lueEmailType.Properties.Appearance.Options.UseFont = True
        Me.lueEmailType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueEmailType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueEmailType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueEmailType.Properties.NullText = "[Isian belum dipilih]"
        Me.lueEmailType.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueEmailType.Size = New System.Drawing.Size(150, 20)
        Me.lueEmailType.TabIndex = 86
        Me.lueEmailType.Tag = "emailtype"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(417, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 14)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Jenis Email"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pHeaderEmail
        '
        Me.pHeaderEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeaderEmail.Controls.Add(Me.btnNewEmail)
        Me.pHeaderEmail.Controls.Add(Me.btnSaveEmail)
        Me.pHeaderEmail.Controls.Add(Me.Label12)
        Me.pHeaderEmail.Controls.Add(Me.btnPrimaryEmail)
        Me.pHeaderEmail.Controls.Add(Me.btnDeleteEmail)
        Me.pHeaderEmail.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeaderEmail.ForeColor = System.Drawing.Color.White
        Me.pHeaderEmail.Location = New System.Drawing.Point(0, 0)
        Me.pHeaderEmail.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeaderEmail.Name = "pHeaderEmail"
        Me.pHeaderEmail.Size = New System.Drawing.Size(728, 30)
        Me.pHeaderEmail.TabIndex = 14
        '
        'btnNewEmail
        '
        Me.btnNewEmail.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnNewEmail.FlatAppearance.BorderSize = 0
        Me.btnNewEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnNewEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnNewEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewEmail.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewEmail.Location = New System.Drawing.Point(408, 0)
        Me.btnNewEmail.Name = "btnNewEmail"
        Me.btnNewEmail.Size = New System.Drawing.Size(60, 30)
        Me.btnNewEmail.TabIndex = 81
        Me.btnNewEmail.Text = "BARU"
        Me.btnNewEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNewEmail.UseVisualStyleBackColor = True
        '
        'btnSaveEmail
        '
        Me.btnSaveEmail.BackColor = System.Drawing.Color.green
        Me.btnSaveEmail.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSaveEmail.FlatAppearance.BorderSize = 0
        Me.btnSaveEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnSaveEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnSaveEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveEmail.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveEmail.Location = New System.Drawing.Point(468, 0)
        Me.btnSaveEmail.Name = "btnSaveEmail"
        Me.btnSaveEmail.Size = New System.Drawing.Size(80, 30)
        Me.btnSaveEmail.TabIndex = 82
        Me.btnSaveEmail.Text = "SIMPAN"
        Me.btnSaveEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveEmail.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(0, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label12.Size = New System.Drawing.Size(200, 30)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Email"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnPrimaryEmail
        '
        Me.btnPrimaryEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrimaryEmail.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnPrimaryEmail.FlatAppearance.BorderSize = 0
        Me.btnPrimaryEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnPrimaryEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnPrimaryEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrimaryEmail.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimaryEmail.Location = New System.Drawing.Point(548, 0)
        Me.btnPrimaryEmail.Name = "btnPrimaryEmail"
        Me.btnPrimaryEmail.Size = New System.Drawing.Size(100, 30)
        Me.btnPrimaryEmail.TabIndex = 83
        Me.btnPrimaryEmail.Text = "NOT PRIMARY"
        Me.btnPrimaryEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrimaryEmail.UseVisualStyleBackColor = False
        '
        'btnDeleteEmail
        '
        Me.btnDeleteEmail.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDeleteEmail.FlatAppearance.BorderSize = 0
        Me.btnDeleteEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnDeleteEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnDeleteEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteEmail.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteEmail.Location = New System.Drawing.Point(648, 0)
        Me.btnDeleteEmail.Name = "btnDeleteEmail"
        Me.btnDeleteEmail.Size = New System.Drawing.Size(80, 30)
        Me.btnDeleteEmail.TabIndex = 84
        Me.btnDeleteEmail.Text = "HAPUS"
        Me.btnDeleteEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeleteEmail.UseVisualStyleBackColor = True
        '
        'xtpTelepon
        '
        Me.xtpTelepon.Controls.Add(Me.pTelepon)
        Me.xtpTelepon.Controls.Add(Me.pHeaderTelepon)
        Me.xtpTelepon.Name = "xtpTelepon"
        Me.xtpTelepon.Size = New System.Drawing.Size(728, 228)
        Me.xtpTelepon.Text = "TELEPON"
        '
        'pTelepon
        '
        Me.pTelepon.Controls.Add(Me.gcTelepon)
        Me.pTelepon.Controls.Add(Me.tlpTelepon)
        Me.pTelepon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pTelepon.Location = New System.Drawing.Point(0, 30)
        Me.pTelepon.Margin = New System.Windows.Forms.Padding(0)
        Me.pTelepon.Name = "pTelepon"
        Me.pTelepon.Size = New System.Drawing.Size(728, 198)
        Me.pTelepon.TabIndex = 12
        '
        'gcTelepon
        '
        Me.gcTelepon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcTelepon.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gcTelepon.Location = New System.Drawing.Point(0, 60)
        Me.gcTelepon.MainView = Me.gvTelepon
        Me.gcTelepon.Margin = New System.Windows.Forms.Padding(0)
        Me.gcTelepon.Name = "gcTelepon"
        Me.gcTelepon.Size = New System.Drawing.Size(728, 138)
        Me.gcTelepon.TabIndex = 98
        Me.gcTelepon.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvTelepon})
        '
        'gvTelepon
        '
        Me.gvTelepon.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gvTelepon.Appearance.Empty.Options.UseBackColor = True
        Me.gvTelepon.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvTelepon.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvTelepon.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvTelepon.Appearance.OddRow.Options.UseBackColor = True
        Me.gvTelepon.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn15, Me.GridColumn16, Me.GridColumn23, Me.GridColumn25, Me.GridColumn85, Me.GridColumn30, Me.GridColumn31, Me.GridColumn32})
        Me.gvTelepon.GridControl = Me.gcTelepon
        Me.gvTelepon.Name = "gvTelepon"
        Me.gvTelepon.OptionsView.ColumnAutoWidth = False
        Me.gvTelepon.OptionsView.EnableAppearanceEvenRow = True
        Me.gvTelepon.OptionsView.EnableAppearanceOddRow = True
        Me.gvTelepon.OptionsView.ShowGroupPanel = False
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn4.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn4.Caption = "ID"
        Me.GridColumn4.FieldName = "idphone"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "ID PhoneType"
        Me.GridColumn15.FieldName = "phonetype"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.AllowEdit = False
        Me.GridColumn15.OptionsColumn.ReadOnly = True
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Status Data"
        Me.GridColumn16.FieldName = "isdeleted"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.AllowEdit = False
        Me.GridColumn16.OptionsColumn.ReadOnly = True
        '
        'GridColumn23
        '
        Me.GridColumn23.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn23.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn23.Caption = "Is Primary"
        Me.GridColumn23.FieldName = "isprimary"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.OptionsColumn.AllowEdit = False
        Me.GridColumn23.OptionsColumn.ReadOnly = True
        '
        'GridColumn25
        '
        Me.GridColumn25.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn25.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn25.Caption = "Nomor Telepon"
        Me.GridColumn25.FieldName = "phone"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.OptionsColumn.AllowEdit = False
        Me.GridColumn25.OptionsColumn.ReadOnly = True
        Me.GridColumn25.Visible = True
        Me.GridColumn25.VisibleIndex = 0
        Me.GridColumn25.Width = 100
        '
        'GridColumn85
        '
        Me.GridColumn85.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn85.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn85.Caption = "Extension"
        Me.GridColumn85.FieldName = "extension"
        Me.GridColumn85.Name = "GridColumn85"
        Me.GridColumn85.OptionsColumn.AllowEdit = False
        Me.GridColumn85.OptionsColumn.ReadOnly = True
        Me.GridColumn85.Visible = True
        Me.GridColumn85.VisibleIndex = 1
        '
        'GridColumn30
        '
        Me.GridColumn30.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn30.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn30.Caption = "Jenis Telepon"
        Me.GridColumn30.FieldName = "jenistelepon"
        Me.GridColumn30.Name = "GridColumn30"
        Me.GridColumn30.OptionsColumn.AllowEdit = False
        Me.GridColumn30.OptionsColumn.ReadOnly = True
        Me.GridColumn30.Visible = True
        Me.GridColumn30.VisibleIndex = 2
        '
        'GridColumn31
        '
        Me.GridColumn31.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn31.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn31.Caption = "Status Data"
        Me.GridColumn31.FieldName = "statdata"
        Me.GridColumn31.Name = "GridColumn31"
        Me.GridColumn31.OptionsColumn.AllowEdit = False
        Me.GridColumn31.OptionsColumn.ReadOnly = True
        Me.GridColumn31.Visible = True
        Me.GridColumn31.VisibleIndex = 4
        '
        'GridColumn32
        '
        Me.GridColumn32.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn32.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn32.Caption = "Primary"
        Me.GridColumn32.FieldName = "primary"
        Me.GridColumn32.Name = "GridColumn32"
        Me.GridColumn32.OptionsColumn.AllowEdit = False
        Me.GridColumn32.OptionsColumn.ReadOnly = True
        Me.GridColumn32.Visible = True
        Me.GridColumn32.VisibleIndex = 3
        '
        'tlpTelepon
        '
        Me.tlpTelepon.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlpTelepon.ColumnCount = 6
        Me.tlpTelepon.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTelepon.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpTelepon.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpTelepon.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpTelepon.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpTelepon.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTelepon.Controls.Add(Me.Label41, 3, 1)
        Me.tlpTelepon.Controls.Add(Me.teExtension, 4, 1)
        Me.tlpTelepon.Controls.Add(Me.lblHandphone, 1, 1)
        Me.tlpTelepon.Controls.Add(Me.tePhone, 2, 1)
        Me.tlpTelepon.Controls.Add(Me.Label5, 1, 2)
        Me.tlpTelepon.Controls.Add(Me.luePhoneType, 2, 2)
        Me.tlpTelepon.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpTelepon.Location = New System.Drawing.Point(0, 0)
        Me.tlpTelepon.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpTelepon.Name = "tlpTelepon"
        Me.tlpTelepon.RowCount = 4
        Me.tlpTelepon.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpTelepon.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpTelepon.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpTelepon.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpTelepon.Size = New System.Drawing.Size(728, 60)
        Me.tlpTelepon.TabIndex = 8
        '
        'Label41
        '
        Me.Label41.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(421, 11)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(60, 14)
        Me.Label41.TabIndex = 56
        Me.Label41.Text = "Extension"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teExtension
        '
        Me.teExtension.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teExtension.Location = New System.Drawing.Point(484, 8)
        Me.teExtension.Margin = New System.Windows.Forms.Padding(0)
        Me.teExtension.Name = "teExtension"
        Me.teExtension.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teExtension.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teExtension.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teExtension.Properties.Appearance.Options.UseBackColor = True
        Me.teExtension.Properties.Appearance.Options.UseFont = True
        Me.teExtension.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teExtension.Properties.MaxLength = 10
        Me.teExtension.Properties.NullText = "[Belum Diisi]"
        Me.teExtension.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teExtension.Size = New System.Drawing.Size(150, 20)
        Me.teExtension.TabIndex = 97
        Me.teExtension.Tag = "extension"
        '
        'lblHandphone
        '
        Me.lblHandphone.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblHandphone.AutoSize = True
        Me.lblHandphone.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHandphone.Location = New System.Drawing.Point(119, 11)
        Me.lblHandphone.Name = "lblHandphone"
        Me.lblHandphone.Size = New System.Drawing.Size(92, 14)
        Me.lblHandphone.TabIndex = 54
        Me.lblHandphone.Text = "Nomor Telepon"
        Me.lblHandphone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tePhone
        '
        Me.tePhone.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tePhone.Location = New System.Drawing.Point(214, 8)
        Me.tePhone.Margin = New System.Windows.Forms.Padding(0)
        Me.tePhone.Name = "tePhone"
        Me.tePhone.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.tePhone.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tePhone.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tePhone.Properties.Appearance.Options.UseBackColor = True
        Me.tePhone.Properties.Appearance.Options.UseFont = True
        Me.tePhone.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tePhone.Properties.MaxLength = 10
        Me.tePhone.Properties.NullText = "[Belum Diisi]"
        Me.tePhone.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.tePhone.Size = New System.Drawing.Size(150, 20)
        Me.tePhone.TabIndex = 95
        Me.tePhone.Tag = "phone"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(129, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 14)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Jenis Telepon"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'luePhoneType
        '
        Me.luePhoneType.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.luePhoneType.Location = New System.Drawing.Point(214, 32)
        Me.luePhoneType.Margin = New System.Windows.Forms.Padding(0)
        Me.luePhoneType.Name = "luePhoneType"
        Me.luePhoneType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.luePhoneType.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.luePhoneType.Properties.Appearance.Options.UseBackColor = True
        Me.luePhoneType.Properties.Appearance.Options.UseFont = True
        Me.luePhoneType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.luePhoneType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePhoneType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.luePhoneType.Properties.NullText = "[Isian belum dipilih]"
        Me.luePhoneType.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.luePhoneType.Size = New System.Drawing.Size(150, 20)
        Me.luePhoneType.TabIndex = 96
        Me.luePhoneType.Tag = "phonetype"
        '
        'pHeaderTelepon
        '
        Me.pHeaderTelepon.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeaderTelepon.Controls.Add(Me.btnNewTelepon)
        Me.pHeaderTelepon.Controls.Add(Me.btnSaveTelepon)
        Me.pHeaderTelepon.Controls.Add(Me.Label13)
        Me.pHeaderTelepon.Controls.Add(Me.btnPrimaryTelepon)
        Me.pHeaderTelepon.Controls.Add(Me.btnDeleteTelepon)
        Me.pHeaderTelepon.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeaderTelepon.ForeColor = System.Drawing.Color.White
        Me.pHeaderTelepon.Location = New System.Drawing.Point(0, 0)
        Me.pHeaderTelepon.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeaderTelepon.Name = "pHeaderTelepon"
        Me.pHeaderTelepon.Size = New System.Drawing.Size(728, 30)
        Me.pHeaderTelepon.TabIndex = 15
        '
        'btnNewTelepon
        '
        Me.btnNewTelepon.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnNewTelepon.FlatAppearance.BorderSize = 0
        Me.btnNewTelepon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnNewTelepon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnNewTelepon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewTelepon.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewTelepon.Location = New System.Drawing.Point(408, 0)
        Me.btnNewTelepon.Name = "btnNewTelepon"
        Me.btnNewTelepon.Size = New System.Drawing.Size(60, 30)
        Me.btnNewTelepon.TabIndex = 91
        Me.btnNewTelepon.Text = "BARU"
        Me.btnNewTelepon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNewTelepon.UseVisualStyleBackColor = True
        '
        'btnSaveTelepon
        '
        Me.btnSaveTelepon.BackColor = System.Drawing.Color.green
        Me.btnSaveTelepon.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSaveTelepon.FlatAppearance.BorderSize = 0
        Me.btnSaveTelepon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnSaveTelepon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnSaveTelepon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveTelepon.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveTelepon.Location = New System.Drawing.Point(468, 0)
        Me.btnSaveTelepon.Name = "btnSaveTelepon"
        Me.btnSaveTelepon.Size = New System.Drawing.Size(80, 30)
        Me.btnSaveTelepon.TabIndex = 92
        Me.btnSaveTelepon.Text = "SIMPAN"
        Me.btnSaveTelepon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveTelepon.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label13.Size = New System.Drawing.Size(200, 30)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Telepon"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnPrimaryTelepon
        '
        Me.btnPrimaryTelepon.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrimaryTelepon.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnPrimaryTelepon.FlatAppearance.BorderSize = 0
        Me.btnPrimaryTelepon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnPrimaryTelepon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnPrimaryTelepon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrimaryTelepon.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimaryTelepon.Location = New System.Drawing.Point(548, 0)
        Me.btnPrimaryTelepon.Name = "btnPrimaryTelepon"
        Me.btnPrimaryTelepon.Size = New System.Drawing.Size(100, 30)
        Me.btnPrimaryTelepon.TabIndex = 93
        Me.btnPrimaryTelepon.Text = "NOT PRIMARY"
        Me.btnPrimaryTelepon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrimaryTelepon.UseVisualStyleBackColor = False
        '
        'btnDeleteTelepon
        '
        Me.btnDeleteTelepon.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDeleteTelepon.FlatAppearance.BorderSize = 0
        Me.btnDeleteTelepon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnDeleteTelepon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnDeleteTelepon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteTelepon.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteTelepon.Location = New System.Drawing.Point(648, 0)
        Me.btnDeleteTelepon.Name = "btnDeleteTelepon"
        Me.btnDeleteTelepon.Size = New System.Drawing.Size(80, 30)
        Me.btnDeleteTelepon.TabIndex = 94
        Me.btnDeleteTelepon.Text = "HAPUS"
        Me.btnDeleteTelepon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeleteTelepon.UseVisualStyleBackColor = True
        '
        'tbAdditional
        '
        Me.tbAdditional.AllowDrag = False
        Me.tbAdditional.AllowSelectedItem = True
        Me.tbAdditional.AppearanceItem.Hovered.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbAdditional.AppearanceItem.Hovered.BorderColor = System.Drawing.Color.White
        Me.tbAdditional.AppearanceItem.Hovered.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tbAdditional.AppearanceItem.Hovered.ForeColor = System.Drawing.Color.White
        Me.tbAdditional.AppearanceItem.Hovered.Options.UseBackColor = True
        Me.tbAdditional.AppearanceItem.Hovered.Options.UseBorderColor = True
        Me.tbAdditional.AppearanceItem.Hovered.Options.UseFont = True
        Me.tbAdditional.AppearanceItem.Hovered.Options.UseForeColor = True
        Me.tbAdditional.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbAdditional.AppearanceItem.Normal.BorderColor = System.Drawing.Color.White
        Me.tbAdditional.AppearanceItem.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tbAdditional.AppearanceItem.Normal.ForeColor = System.Drawing.Color.White
        Me.tbAdditional.AppearanceItem.Normal.Options.UseBackColor = True
        Me.tbAdditional.AppearanceItem.Normal.Options.UseBorderColor = True
        Me.tbAdditional.AppearanceItem.Normal.Options.UseFont = True
        Me.tbAdditional.AppearanceItem.Normal.Options.UseForeColor = True
        Me.tbAdditional.AppearanceItem.Pressed.BackColor = System.Drawing.Color.OrangeRed
        Me.tbAdditional.AppearanceItem.Pressed.BorderColor = System.Drawing.Color.White
        Me.tbAdditional.AppearanceItem.Pressed.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tbAdditional.AppearanceItem.Pressed.ForeColor = System.Drawing.Color.White
        Me.tbAdditional.AppearanceItem.Pressed.Options.UseBackColor = True
        Me.tbAdditional.AppearanceItem.Pressed.Options.UseBorderColor = True
        Me.tbAdditional.AppearanceItem.Pressed.Options.UseFont = True
        Me.tbAdditional.AppearanceItem.Pressed.Options.UseForeColor = True
        Me.tbAdditional.AppearanceItem.Selected.BackColor = System.Drawing.Color.OrangeRed
        Me.tbAdditional.AppearanceItem.Selected.BorderColor = System.Drawing.Color.White
        Me.tbAdditional.AppearanceItem.Selected.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tbAdditional.AppearanceItem.Selected.ForeColor = System.Drawing.Color.White
        Me.tbAdditional.AppearanceItem.Selected.Options.UseBackColor = True
        Me.tbAdditional.AppearanceItem.Selected.Options.UseBorderColor = True
        Me.tbAdditional.AppearanceItem.Selected.Options.UseFont = True
        Me.tbAdditional.AppearanceItem.Selected.Options.UseForeColor = True
        Me.tbAdditional.Dock = System.Windows.Forms.DockStyle.Top
        Me.tbAdditional.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        Me.tbAdditional.Groups.Add(Me.TileBarGroup2)
        Me.tbAdditional.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tbAdditional.ItemPadding = New System.Windows.Forms.Padding(0)
        Me.tbAdditional.ItemSize = 40
        Me.tbAdditional.ItemTextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Always
        Me.tbAdditional.Location = New System.Drawing.Point(0, 60)
        Me.tbAdditional.Margin = New System.Windows.Forms.Padding(0)
        Me.tbAdditional.MaxId = 15
        Me.tbAdditional.Name = "tbAdditional"
        Me.tbAdditional.Padding = New System.Windows.Forms.Padding(10, 12, 10, 12)
        Me.tbAdditional.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons
        Me.tbAdditional.SelectionColor = System.Drawing.Color.OrangeRed
        Me.tbAdditional.ShowGroupText = False
        Me.tbAdditional.Size = New System.Drawing.Size(734, 48)
        Me.tbAdditional.TabIndex = 16
        Me.tbAdditional.Text = "TileBar1"
        Me.tbAdditional.WideTileWidth = 100
        '
        'TileBarGroup2
        '
        Me.TileBarGroup2.Items.Add(Me.tbiAlamat)
        Me.TileBarGroup2.Items.Add(Me.tbiEmail)
        Me.TileBarGroup2.Items.Add(Me.tbiTelepon)
        Me.TileBarGroup2.Name = "TileBarGroup2"
        '
        'tbiAlamat
        '
        Me.tbiAlamat.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement1.Text = "Alamat"
        TileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        Me.tbiAlamat.Elements.Add(TileItemElement1)
        Me.tbiAlamat.Id = 3
        Me.tbiAlamat.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.tbiAlamat.Name = "tbiAlamat"
        Me.tbiAlamat.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        '
        'tbiEmail
        '
        Me.tbiEmail.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement2.Text = "Email"
        TileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        Me.tbiEmail.Elements.Add(TileItemElement2)
        Me.tbiEmail.Id = 6
        Me.tbiEmail.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.tbiEmail.Name = "tbiEmail"
        Me.tbiEmail.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        '
        'tbiTelepon
        '
        Me.tbiTelepon.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement3.Text = "Telepon"
        TileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        Me.tbiTelepon.Elements.Add(TileItemElement3)
        Me.tbiTelepon.Id = 7
        Me.tbiTelepon.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.tbiTelepon.Name = "tbiTelepon"
        Me.tbiTelepon.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        '
        'tlpField
        '
        Me.tlpField.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlpField.ColumnCount = 6
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.Controls.Add(Me.lueType, 4, 1)
        Me.tlpField.Controls.Add(Me.Label1, 3, 1)
        Me.tlpField.Controls.Add(Me.teKode, 2, 1)
        Me.tlpField.Controls.Add(Me.lblParent, 1, 1)
        Me.tlpField.Controls.Add(Me.lblDepartment, 1, 2)
        Me.tlpField.Controls.Add(Me.teNama, 2, 2)
        Me.tlpField.Controls.Add(Me.luePaymentType, 4, 2)
        Me.tlpField.Controls.Add(Me.Label2, 3, 2)
        Me.tlpField.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpField.Location = New System.Drawing.Point(0, 0)
        Me.tlpField.Name = "tlpField"
        Me.tlpField.RowCount = 4
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpField.Size = New System.Drawing.Size(734, 60)
        Me.tlpField.TabIndex = 17
        '
        'lueType
        '
        Me.lueType.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueType.Location = New System.Drawing.Point(512, 8)
        Me.lueType.Margin = New System.Windows.Forms.Padding(0)
        Me.lueType.Name = "lueType"
        Me.lueType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueType.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueType.Properties.Appearance.Options.UseBackColor = True
        Me.lueType.Properties.Appearance.Options.UseFont = True
        Me.lueType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueType.Properties.NullText = "[Isian belum dipilih]"
        Me.lueType.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueType.Size = New System.Drawing.Size(150, 20)
        Me.lueType.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(474, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 14)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Type"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teKode
        '
        Me.teKode.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teKode.Location = New System.Drawing.Point(192, 8)
        Me.teKode.Margin = New System.Windows.Forms.Padding(0)
        Me.teKode.Name = "teKode"
        Me.teKode.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teKode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teKode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teKode.Properties.Appearance.Options.UseBackColor = True
        Me.teKode.Properties.Appearance.Options.UseFont = True
        Me.teKode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teKode.Properties.MaxLength = 300
        Me.teKode.Properties.NullText = "[Belum Diisi]"
        Me.teKode.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teKode.Properties.ReadOnly = True
        Me.teKode.Size = New System.Drawing.Size(150, 20)
        Me.teKode.TabIndex = 18
        Me.teKode.Tag = "kode"
        '
        'lblParent
        '
        Me.lblParent.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblParent.AutoSize = True
        Me.lblParent.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParent.Location = New System.Drawing.Point(154, 11)
        Me.lblParent.Name = "lblParent"
        Me.lblParent.Size = New System.Drawing.Size(35, 14)
        Me.lblParent.TabIndex = 20
        Me.lblParent.Text = "Kode"
        Me.lblParent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDepartment
        '
        Me.lblDepartment.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.Location = New System.Drawing.Point(152, 35)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(37, 14)
        Me.lblDepartment.TabIndex = 9
        Me.lblDepartment.Text = "Nama"
        Me.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teNama
        '
        Me.teNama.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNama.Location = New System.Drawing.Point(192, 32)
        Me.teNama.Margin = New System.Windows.Forms.Padding(0)
        Me.teNama.Name = "teNama"
        Me.teNama.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teNama.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNama.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNama.Properties.Appearance.Options.UseBackColor = True
        Me.teNama.Properties.Appearance.Options.UseFont = True
        Me.teNama.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNama.Properties.MaxLength = 300
        Me.teNama.Properties.NullText = "[Belum Diisi]"
        Me.teNama.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNama.Size = New System.Drawing.Size(197, 20)
        Me.teNama.TabIndex = 17
        Me.teNama.Tag = "nama"
        '
        'luePaymentType
        '
        Me.luePaymentType.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.luePaymentType.Location = New System.Drawing.Point(512, 32)
        Me.luePaymentType.Margin = New System.Windows.Forms.Padding(0)
        Me.luePaymentType.Name = "luePaymentType"
        Me.luePaymentType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.luePaymentType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.luePaymentType.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.luePaymentType.Properties.Appearance.Options.UseBackColor = True
        Me.luePaymentType.Properties.Appearance.Options.UseFont = True
        Me.luePaymentType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.luePaymentType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePaymentType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.luePaymentType.Properties.NullText = "[Isian belum dipilih]"
        Me.luePaymentType.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.luePaymentType.Size = New System.Drawing.Size(150, 20)
        Me.luePaymentType.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(406, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 14)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Jenis Pembayaran"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'xtpData
        '
        Me.xtpData.Controls.Add(Me.gcData)
        Me.xtpData.Name = "xtpData"
        Me.xtpData.Size = New System.Drawing.Size(734, 342)
        Me.xtpData.Text = "DATA"
        '
        'gcData
        '
        Me.gcData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcData.Location = New System.Drawing.Point(0, 0)
        Me.gcData.MainView = Me.gvData
        Me.gcData.Name = "gcData"
        Me.gcData.Size = New System.Drawing.Size(734, 342)
        Me.gcData.TabIndex = 9
        Me.gcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvData})
        '
        'gvData
        '
        Me.gvData.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gvData.Appearance.Empty.Options.UseBackColor = True
        Me.gvData.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvData.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.OddRow.Options.UseBackColor = True
        Me.gvData.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.Row.Options.UseBackColor = True
        Me.gvData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcID, Me.gcbptype, Me.gcisdeleted, Me.gcpaymenttype, Me.gcType, Me.gcKode, Me.gcNama, Me.gcStatData, Me.gcJenisPembayaran})
        Me.gvData.GridControl = Me.gcData
        Me.gvData.Name = "gvData"
        Me.gvData.OptionsView.EnableAppearanceEvenRow = True
        Me.gvData.OptionsView.EnableAppearanceOddRow = True
        Me.gvData.OptionsView.ShowGroupPanel = False
        '
        'gcID
        '
        Me.gcID.Caption = "ID"
        Me.gcID.FieldName = "idbusinesspartner"
        Me.gcID.Name = "gcID"
        Me.gcID.OptionsColumn.AllowEdit = False
        Me.gcID.OptionsColumn.ReadOnly = True
        '
        'gcbptype
        '
        Me.gcbptype.Caption = "bptype"
        Me.gcbptype.FieldName = "businesspartnertype"
        Me.gcbptype.Name = "gcbptype"
        '
        'gcisdeleted
        '
        Me.gcisdeleted.Caption = "isdeleted"
        Me.gcisdeleted.FieldName = "isdeleted"
        Me.gcisdeleted.Name = "gcisdeleted"
        Me.gcisdeleted.OptionsColumn.AllowEdit = False
        Me.gcisdeleted.OptionsColumn.ReadOnly = True
        '
        'gcpaymenttype
        '
        Me.gcpaymenttype.Caption = "paymenttype"
        Me.gcpaymenttype.FieldName = "paymenttype"
        Me.gcpaymenttype.Name = "gcpaymenttype"
        '
        'gcType
        '
        Me.gcType.AppearanceHeader.Options.UseTextOptions = True
        Me.gcType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcType.Caption = "Type"
        Me.gcType.FieldName = "type"
        Me.gcType.Name = "gcType"
        Me.gcType.OptionsColumn.AllowEdit = False
        Me.gcType.OptionsColumn.ReadOnly = True
        Me.gcType.Visible = True
        Me.gcType.VisibleIndex = 0
        '
        'gcKode
        '
        Me.gcKode.AppearanceHeader.Options.UseTextOptions = True
        Me.gcKode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcKode.Caption = "Kode"
        Me.gcKode.FieldName = "kode"
        Me.gcKode.Name = "gcKode"
        Me.gcKode.OptionsColumn.AllowEdit = False
        Me.gcKode.OptionsColumn.ReadOnly = True
        Me.gcKode.Visible = True
        Me.gcKode.VisibleIndex = 2
        '
        'gcNama
        '
        Me.gcNama.AppearanceHeader.Options.UseTextOptions = True
        Me.gcNama.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcNama.Caption = "Nama"
        Me.gcNama.FieldName = "nama"
        Me.gcNama.Name = "gcNama"
        Me.gcNama.OptionsColumn.AllowEdit = False
        Me.gcNama.OptionsColumn.ReadOnly = True
        Me.gcNama.Visible = True
        Me.gcNama.VisibleIndex = 3
        '
        'gcStatData
        '
        Me.gcStatData.AppearanceHeader.Options.UseTextOptions = True
        Me.gcStatData.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcStatData.Caption = "Status Data"
        Me.gcStatData.FieldName = "statdata"
        Me.gcStatData.Name = "gcStatData"
        Me.gcStatData.OptionsColumn.AllowEdit = False
        Me.gcStatData.OptionsColumn.ReadOnly = True
        Me.gcStatData.Visible = True
        Me.gcStatData.VisibleIndex = 4
        '
        'gcJenisPembayaran
        '
        Me.gcJenisPembayaran.AppearanceHeader.Options.UseTextOptions = True
        Me.gcJenisPembayaran.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcJenisPembayaran.Caption = "Jenis Pembayaran"
        Me.gcJenisPembayaran.FieldName = "jenisbayar"
        Me.gcJenisPembayaran.Name = "gcJenisPembayaran"
        Me.gcJenisPembayaran.OptionsColumn.AllowEdit = False
        Me.gcJenisPembayaran.OptionsColumn.ReadOnly = True
        Me.gcJenisPembayaran.Visible = True
        Me.gcJenisPembayaran.VisibleIndex = 1
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Controls.Add(Me.btnExport)
        Me.pHeader.Controls.Add(Me.btnNew)
        Me.pHeader.Controls.Add(Me.btnSave)
        Me.pHeader.Controls.Add(Me.btnDelete)
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.ForeColor = System.Drawing.Color.White
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(786, 30)
        Me.pHeader.TabIndex = 4
        '
        'btnExport
        '
        Me.btnExport.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExport.FlatAppearance.BorderSize = 0
        Me.btnExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExport.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.Location = New System.Drawing.Point(466, 0)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(100, 30)
        Me.btnExport.TabIndex = 18
        Me.btnExport.Text = "EXPORT"
        Me.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnNew.FlatAppearance.BorderSize = 0
        Me.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(566, 0)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(60, 30)
        Me.btnNew.TabIndex = 17
        Me.btnNew.Text = "BARU"
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.green
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(626, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "SIMPAN"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(706, 0)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 30)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "HAPUS"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = True
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
        'frmFarmasiRujukan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(790, 408)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmFarmasiRujukan"
        Me.ShowInTaskbar = False
        Me.Text = "Farmasi Rujukan"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        CType(Me.xtcProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcProfile.ResumeLayout(False)
        Me.xtpEntry.ResumeLayout(False)
        Me.pEntry.ResumeLayout(False)
        CType(Me.xtcAdditional, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcAdditional.ResumeLayout(False)
        Me.xtpAddress.ResumeLayout(False)
        Me.pAlamat.ResumeLayout(False)
        CType(Me.gcAlamat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvAlamat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.tlpAlamat1.ResumeLayout(False)
        Me.tlpAlamat1.PerformLayout()
        CType(Me.teKodepos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueNegara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePropinsi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueKabupaten.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueKecamatan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueKelurahan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueAddressType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpAlamat2.ResumeLayout(False)
        Me.tlpAlamat2.PerformLayout()
        CType(Me.meAlamat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeaderAlamat.ResumeLayout(False)
        Me.xtpEmail.ResumeLayout(False)
        Me.pEmail.ResumeLayout(False)
        CType(Me.gcEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvEmail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpEmail.ResumeLayout(False)
        Me.tlpEmail.PerformLayout()
        CType(Me.teEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueEmailType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeaderEmail.ResumeLayout(False)
        Me.xtpTelepon.ResumeLayout(False)
        Me.pTelepon.ResumeLayout(False)
        CType(Me.gcTelepon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvTelepon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpTelepon.ResumeLayout(False)
        Me.tlpTelepon.PerformLayout()
        CType(Me.teExtension.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tePhone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePhoneType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeaderTelepon.ResumeLayout(False)
        Me.tlpField.ResumeLayout(False)
        Me.tlpField.PerformLayout()
        CType(Me.lueType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teKode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePaymentType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpData.ResumeLayout(False)
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblSep5 As System.Windows.Forms.Label
    Public WithEvents pHeader As System.Windows.Forms.Panel
    Public WithEvents btnNew As System.Windows.Forms.Button
    Public WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents pBody As System.Windows.Forms.Panel
    Public WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Public WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Public WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents xtcProfile As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpEntry As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents pEntry As System.Windows.Forms.Panel
    Friend WithEvents xtcAdditional As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpAddress As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents pAlamat As System.Windows.Forms.Panel
    Public WithEvents gcAlamat As DevExpress.XtraGrid.GridControl
    Public WithEvents gvAlamat As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn55 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn56 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn86 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Public WithEvents tlpAlamat1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents teKodepos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents lueNegara As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents luePropinsi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueKabupaten As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblNegara As System.Windows.Forms.Label
    Friend WithEvents lblPropinsi As System.Windows.Forms.Label
    Friend WithEvents lblKabupaten As System.Windows.Forms.Label
    Friend WithEvents lueKecamatan As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblKelurahan As System.Windows.Forms.Label
    Friend WithEvents lblKecamatan As System.Windows.Forms.Label
    Friend WithEvents lueKelurahan As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lueAddressType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents tlpAlamat2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblAlamat As System.Windows.Forms.Label
    Friend WithEvents meAlamat As DevExpress.XtraEditors.MemoEdit
    Public WithEvents pHeaderAlamat As System.Windows.Forms.Panel
    Public WithEvents btnNewAlamat As System.Windows.Forms.Button
    Public WithEvents btnSaveAlamat As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Public WithEvents btnPrimaryAlamat As System.Windows.Forms.Button
    Public WithEvents btnDeleteAlamat As System.Windows.Forms.Button
    Friend WithEvents xtpEmail As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents pEmail As System.Windows.Forms.Panel
    Public WithEvents gcEmail As DevExpress.XtraGrid.GridControl
    Public WithEvents gvEmail As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn28 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn29 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents tlpEmail As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents teEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lueEmailType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents pHeaderEmail As System.Windows.Forms.Panel
    Public WithEvents btnNewEmail As System.Windows.Forms.Button
    Public WithEvents btnSaveEmail As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents btnPrimaryEmail As System.Windows.Forms.Button
    Public WithEvents btnDeleteEmail As System.Windows.Forms.Button
    Friend WithEvents xtpTelepon As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents pTelepon As System.Windows.Forms.Panel
    Public WithEvents gcTelepon As DevExpress.XtraGrid.GridControl
    Public WithEvents gvTelepon As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn85 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn30 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn31 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn32 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents tlpTelepon As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents teExtension As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblHandphone As System.Windows.Forms.Label
    Friend WithEvents tePhone As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents luePhoneType As DevExpress.XtraEditors.LookUpEdit
    Public WithEvents pHeaderTelepon As System.Windows.Forms.Panel
    Public WithEvents btnNewTelepon As System.Windows.Forms.Button
    Public WithEvents btnSaveTelepon As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents btnPrimaryTelepon As System.Windows.Forms.Button
    Public WithEvents btnDeleteTelepon As System.Windows.Forms.Button
    Friend WithEvents tbAdditional As DevExpress.XtraBars.Navigation.TileBar
    Friend WithEvents TileBarGroup2 As DevExpress.XtraBars.Navigation.TileBarGroup
    Friend WithEvents tbiAlamat As DevExpress.XtraBars.Navigation.TileBarItem
    Friend WithEvents tbiEmail As DevExpress.XtraBars.Navigation.TileBarItem
    Friend WithEvents tbiTelepon As DevExpress.XtraBars.Navigation.TileBarItem
    Public WithEvents tlpField As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lueType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents teKode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblParent As System.Windows.Forms.Label
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents teNama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents luePaymentType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents xtpData As DevExpress.XtraTab.XtraTabPage
    Public WithEvents gcData As DevExpress.XtraGrid.GridControl
    Public WithEvents gvData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcbptype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcisdeleted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcpaymenttype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcKode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcNama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcStatData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcJenisPembayaran As DevExpress.XtraGrid.Columns.GridColumn
End Class
