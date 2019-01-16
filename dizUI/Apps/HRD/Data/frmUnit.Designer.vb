<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUnit
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
        Me.xtcProfile = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpEntry = New DevExpress.XtraTab.XtraTabPage()
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
        Me.GridColumn44 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpAlamat1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.teKodepos = New DevExpress.XtraEditors.TextEdit()
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
        Me.Label12 = New System.Windows.Forms.Label()
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
        Me.Label14 = New System.Windows.Forms.Label()
        Me.teEmail = New DevExpress.XtraEditors.TextEdit()
        Me.lueEmailType = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.pHeaderEmail = New System.Windows.Forms.Panel()
        Me.btnNewEmail = New System.Windows.Forms.Button()
        Me.btnSaveEmail = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
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
        Me.GridColumn36 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn30 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn31 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn32 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tlpTelepon = New System.Windows.Forms.TableLayoutPanel()
        Me.teExtension = New DevExpress.XtraEditors.TextEdit()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.lblHandphone = New System.Windows.Forms.Label()
        Me.tePhone = New DevExpress.XtraEditors.TextEdit()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.luePhoneType = New DevExpress.XtraEditors.LookUpEdit()
        Me.pHeaderTelepon = New System.Windows.Forms.Panel()
        Me.btnNewTelepon = New System.Windows.Forms.Button()
        Me.btnSaveTelepon = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnPrimaryTelepon = New System.Windows.Forms.Button()
        Me.btnDeleteTelepon = New System.Windows.Forms.Button()
        Me.xtpCOA = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn38 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn39 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn40 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn41 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn42 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn43 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn45 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn46 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn47 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn48 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn49 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn51 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn52 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn53 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn54 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn57 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn58 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn59 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.tlpField = New System.Windows.Forms.TableLayoutPanel()
        Me.teNPWP = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.teAlias = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.teKodeAngka = New DevExpress.XtraEditors.TextEdit()
        Me.teUnit = New DevExpress.XtraEditors.TextEdit()
        Me.lblBank = New System.Windows.Forms.Label()
        Me.teKode = New DevExpress.XtraEditors.TextEdit()
        Me.lblKode = New System.Windows.Forms.Label()
        Me.teRemarks = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.xtpData = New DevExpress.XtraTab.XtraTabPage()
        Me.gcData = New DevExpress.XtraGrid.GridControl()
        Me.gvData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcIDStatData = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn34 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn33 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn37 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn35 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcStatData = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblSep5 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lueJenisCOA = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.slueCOA = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.slueCOAView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn60 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn61 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn62 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lblJabatan = New System.Windows.Forms.Label()
        Me.teCOA = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBody.SuspendLayout()
        CType(Me.xtcProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcProfile.SuspendLayout()
        Me.xtpEntry.SuspendLayout()
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
        Me.xtpCOA.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.tlpField.SuspendLayout()
        CType(Me.teNPWP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teAlias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teKodeAngka.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teKode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpData.SuspendLayout()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeader.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.lueJenisCOA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueCOA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueCOAView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teCOA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tlpForm.Size = New System.Drawing.Size(900, 620)
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
        Me.pTitle.Size = New System.Drawing.Size(896, 30)
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
        Me.lblTitle.Size = New System.Drawing.Size(806, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Unit"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pMinimize
        '
        Me.pMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.pMinimize.Image = Global.dizUI.My.Resources.Resources.min_w
        Me.pMinimize.Location = New System.Drawing.Point(806, 0)
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
        Me.pMaximize.Location = New System.Drawing.Point(836, 0)
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
        Me.pExit.Location = New System.Drawing.Point(866, 0)
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
        Me.pBody.Size = New System.Drawing.Size(896, 590)
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
        Me.xtcProfile.Size = New System.Drawing.Size(896, 560)
        Me.xtcProfile.TabIndex = 101
        Me.xtcProfile.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpEntry, Me.xtpData})
        '
        'xtpEntry
        '
        Me.xtpEntry.Appearance.PageClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.xtpEntry.Appearance.PageClient.Options.UseBackColor = True
        Me.xtpEntry.Controls.Add(Me.xtcAdditional)
        Me.xtpEntry.Controls.Add(Me.tlpField)
        Me.xtpEntry.Name = "xtpEntry"
        Me.xtpEntry.Size = New System.Drawing.Size(844, 554)
        Me.xtpEntry.Text = "ISIAN"
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
        Me.xtcAdditional.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[False]
        Me.xtcAdditional.HeaderButtons = DevExpress.XtraTab.TabButtons.None
        Me.xtcAdditional.HeaderButtonsShowMode = DevExpress.XtraTab.TabButtonShowMode.Never
        Me.xtcAdditional.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Right
        Me.xtcAdditional.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
        Me.xtcAdditional.Location = New System.Drawing.Point(0, 84)
        Me.xtcAdditional.Margin = New System.Windows.Forms.Padding(0)
        Me.xtcAdditional.Name = "xtcAdditional"
        Me.xtcAdditional.SelectedTabPage = Me.xtpAddress
        Me.xtcAdditional.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.[True]
        Me.xtcAdditional.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[True]
        Me.xtcAdditional.ShowToolTips = DevExpress.Utils.DefaultBoolean.[True]
        Me.xtcAdditional.Size = New System.Drawing.Size(844, 470)
        Me.xtcAdditional.TabIndex = 100
        Me.xtcAdditional.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpAddress, Me.xtpEmail, Me.xtpTelepon, Me.xtpCOA})
        '
        'xtpAddress
        '
        Me.xtpAddress.Appearance.PageClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.xtpAddress.Appearance.PageClient.Options.UseBackColor = True
        Me.xtpAddress.Controls.Add(Me.pAlamat)
        Me.xtpAddress.Controls.Add(Me.pHeaderAlamat)
        Me.xtpAddress.Margin = New System.Windows.Forms.Padding(0)
        Me.xtpAddress.Name = "xtpAddress"
        Me.xtpAddress.Size = New System.Drawing.Size(780, 464)
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
        Me.pAlamat.Size = New System.Drawing.Size(780, 434)
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
        Me.gcAlamat.Size = New System.Drawing.Size(780, 278)
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
        Me.gvAlamat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn55, Me.GridColumn11, Me.GridColumn3, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.GridColumn27, Me.GridColumn2, Me.GridColumn56, Me.GridColumn44})
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
        Me.GridColumn2.VisibleIndex = 7
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
        'GridColumn44
        '
        Me.GridColumn44.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn44.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn44.Caption = "Kode Pos"
        Me.GridColumn44.FieldName = "kodepos"
        Me.GridColumn44.Name = "GridColumn44"
        Me.GridColumn44.OptionsColumn.AllowEdit = False
        Me.GridColumn44.OptionsColumn.ReadOnly = True
        Me.GridColumn44.Visible = True
        Me.GridColumn44.VisibleIndex = 8
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
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(780, 156)
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
        Me.tlpAlamat1.Controls.Add(Me.Label38, 2, 2)
        Me.tlpAlamat1.Controls.Add(Me.teKodepos, 3, 2)
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
        Me.tlpAlamat1.Controls.Add(Me.Label12, 0, 3)
        Me.tlpAlamat1.Controls.Add(Me.lueAddressType, 1, 3)
        Me.tlpAlamat1.Location = New System.Drawing.Point(120, 6)
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
        'Label38
        '
        Me.Label38.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(329, 53)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(58, 14)
        Me.Label38.TabIndex = 54
        Me.Label38.Text = "Kode Pos"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.teKodepos.TabIndex = 40
        Me.teKodepos.Tag = "kodepos"
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
        Me.lueNegara.TabIndex = 34
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
        Me.luePropinsi.TabIndex = 35
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
        Me.lueKabupaten.TabIndex = 36
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
        Me.lueKecamatan.TabIndex = 38
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
        Me.lueKelurahan.TabIndex = 39
        Me.lueKelurahan.Tag = "idkelurahan"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(43, 77)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 14)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "Jenis Alamat"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.lueAddressType.TabIndex = 37
        Me.lueAddressType.Tag = "addresstype"
        '
        'tlpAlamat2
        '
        Me.tlpAlamat2.ColumnCount = 2
        Me.tlpAlamat2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpAlamat2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 420.0!))
        Me.tlpAlamat2.Controls.Add(Me.lblAlamat, 0, 0)
        Me.tlpAlamat2.Controls.Add(Me.meAlamat, 1, 0)
        Me.tlpAlamat2.Location = New System.Drawing.Point(120, 102)
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
        Me.pHeaderAlamat.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
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
        Me.pHeaderAlamat.Size = New System.Drawing.Size(780, 30)
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
        Me.btnNewAlamat.Location = New System.Drawing.Point(460, 0)
        Me.btnNewAlamat.Name = "btnNewAlamat"
        Me.btnNewAlamat.Size = New System.Drawing.Size(60, 30)
        Me.btnNewAlamat.TabIndex = 31
        Me.btnNewAlamat.Text = "BARU"
        Me.btnNewAlamat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNewAlamat.UseVisualStyleBackColor = True
        '
        'btnSaveAlamat
        '
        Me.btnSaveAlamat.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnSaveAlamat.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSaveAlamat.FlatAppearance.BorderSize = 0
        Me.btnSaveAlamat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnSaveAlamat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnSaveAlamat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveAlamat.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveAlamat.Location = New System.Drawing.Point(520, 0)
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
        Me.btnPrimaryAlamat.Location = New System.Drawing.Point(600, 0)
        Me.btnPrimaryAlamat.Name = "btnPrimaryAlamat"
        Me.btnPrimaryAlamat.Size = New System.Drawing.Size(100, 30)
        Me.btnPrimaryAlamat.TabIndex = 34
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
        Me.btnDeleteAlamat.Location = New System.Drawing.Point(700, 0)
        Me.btnDeleteAlamat.Name = "btnDeleteAlamat"
        Me.btnDeleteAlamat.Size = New System.Drawing.Size(80, 30)
        Me.btnDeleteAlamat.TabIndex = 33
        Me.btnDeleteAlamat.Text = "HAPUS"
        Me.btnDeleteAlamat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeleteAlamat.UseVisualStyleBackColor = True
        '
        'xtpEmail
        '
        Me.xtpEmail.Controls.Add(Me.pEmail)
        Me.xtpEmail.Controls.Add(Me.pHeaderEmail)
        Me.xtpEmail.Margin = New System.Windows.Forms.Padding(0)
        Me.xtpEmail.Name = "xtpEmail"
        Me.xtpEmail.Size = New System.Drawing.Size(780, 464)
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
        Me.pEmail.Size = New System.Drawing.Size(780, 434)
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
        Me.gcEmail.Size = New System.Drawing.Size(780, 398)
        Me.gcEmail.TabIndex = 67
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
        Me.tlpEmail.AutoSize = True
        Me.tlpEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlpEmail.ColumnCount = 6
        Me.tlpEmail.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpEmail.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpEmail.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpEmail.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpEmail.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpEmail.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpEmail.Controls.Add(Me.Label14, 1, 1)
        Me.tlpEmail.Controls.Add(Me.teEmail, 2, 1)
        Me.tlpEmail.Controls.Add(Me.lueEmailType, 4, 1)
        Me.tlpEmail.Controls.Add(Me.Label15, 3, 1)
        Me.tlpEmail.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpEmail.Location = New System.Drawing.Point(0, 0)
        Me.tlpEmail.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEmail.Name = "tlpEmail"
        Me.tlpEmail.RowCount = 3
        Me.tlpEmail.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpEmail.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpEmail.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpEmail.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpEmail.Size = New System.Drawing.Size(780, 36)
        Me.tlpEmail.TabIndex = 8
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(203, 11)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 14)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = "Email"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teEmail
        '
        Me.teEmail.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teEmail.Location = New System.Drawing.Point(240, 8)
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
        Me.teEmail.TabIndex = 64
        Me.teEmail.Tag = "email"
        '
        'lueEmailType
        '
        Me.lueEmailType.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueEmailType.Location = New System.Drawing.Point(510, 8)
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
        Me.lueEmailType.TabIndex = 65
        Me.lueEmailType.Tag = "emailtype"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(443, 11)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 14)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "Jenis Email"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pHeaderEmail
        '
        Me.pHeaderEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pHeaderEmail.Controls.Add(Me.btnNewEmail)
        Me.pHeaderEmail.Controls.Add(Me.btnSaveEmail)
        Me.pHeaderEmail.Controls.Add(Me.Label18)
        Me.pHeaderEmail.Controls.Add(Me.btnPrimaryEmail)
        Me.pHeaderEmail.Controls.Add(Me.btnDeleteEmail)
        Me.pHeaderEmail.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeaderEmail.ForeColor = System.Drawing.Color.White
        Me.pHeaderEmail.Location = New System.Drawing.Point(0, 0)
        Me.pHeaderEmail.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeaderEmail.Name = "pHeaderEmail"
        Me.pHeaderEmail.Size = New System.Drawing.Size(780, 30)
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
        Me.btnNewEmail.Location = New System.Drawing.Point(460, 0)
        Me.btnNewEmail.Name = "btnNewEmail"
        Me.btnNewEmail.Size = New System.Drawing.Size(60, 30)
        Me.btnNewEmail.TabIndex = 61
        Me.btnNewEmail.Text = "BARU"
        Me.btnNewEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNewEmail.UseVisualStyleBackColor = True
        '
        'btnSaveEmail
        '
        Me.btnSaveEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnSaveEmail.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSaveEmail.FlatAppearance.BorderSize = 0
        Me.btnSaveEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnSaveEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnSaveEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveEmail.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveEmail.Location = New System.Drawing.Point(520, 0)
        Me.btnSaveEmail.Name = "btnSaveEmail"
        Me.btnSaveEmail.Size = New System.Drawing.Size(80, 30)
        Me.btnSaveEmail.TabIndex = 62
        Me.btnSaveEmail.Text = "SIMPAN"
        Me.btnSaveEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveEmail.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(0, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label18.Size = New System.Drawing.Size(200, 30)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Email"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btnPrimaryEmail.Location = New System.Drawing.Point(600, 0)
        Me.btnPrimaryEmail.Name = "btnPrimaryEmail"
        Me.btnPrimaryEmail.Size = New System.Drawing.Size(100, 30)
        Me.btnPrimaryEmail.TabIndex = 84
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
        Me.btnDeleteEmail.Location = New System.Drawing.Point(700, 0)
        Me.btnDeleteEmail.Name = "btnDeleteEmail"
        Me.btnDeleteEmail.Size = New System.Drawing.Size(80, 30)
        Me.btnDeleteEmail.TabIndex = 63
        Me.btnDeleteEmail.Text = "HAPUS"
        Me.btnDeleteEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeleteEmail.UseVisualStyleBackColor = True
        '
        'xtpTelepon
        '
        Me.xtpTelepon.Controls.Add(Me.pTelepon)
        Me.xtpTelepon.Controls.Add(Me.pHeaderTelepon)
        Me.xtpTelepon.Margin = New System.Windows.Forms.Padding(0)
        Me.xtpTelepon.Name = "xtpTelepon"
        Me.xtpTelepon.Size = New System.Drawing.Size(780, 464)
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
        Me.pTelepon.Size = New System.Drawing.Size(780, 434)
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
        Me.gcTelepon.Size = New System.Drawing.Size(780, 374)
        Me.gcTelepon.TabIndex = 78
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
        Me.gvTelepon.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn15, Me.GridColumn16, Me.GridColumn23, Me.GridColumn25, Me.GridColumn36, Me.GridColumn30, Me.GridColumn31, Me.GridColumn32})
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
        'GridColumn36
        '
        Me.GridColumn36.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn36.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn36.Caption = "Extension"
        Me.GridColumn36.FieldName = "extension"
        Me.GridColumn36.Name = "GridColumn36"
        Me.GridColumn36.OptionsColumn.AllowEdit = False
        Me.GridColumn36.Visible = True
        Me.GridColumn36.VisibleIndex = 1
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
        Me.tlpTelepon.Controls.Add(Me.teExtension, 4, 1)
        Me.tlpTelepon.Controls.Add(Me.Label35, 3, 1)
        Me.tlpTelepon.Controls.Add(Me.lblHandphone, 1, 1)
        Me.tlpTelepon.Controls.Add(Me.tePhone, 2, 1)
        Me.tlpTelepon.Controls.Add(Me.Label19, 1, 2)
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
        Me.tlpTelepon.Size = New System.Drawing.Size(780, 60)
        Me.tlpTelepon.TabIndex = 8
        '
        'teExtension
        '
        Me.teExtension.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teExtension.Location = New System.Drawing.Point(510, 8)
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
        Me.teExtension.TabIndex = 76
        Me.teExtension.Tag = "extension"
        '
        'Label35
        '
        Me.Label35.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(447, 11)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(60, 14)
        Me.Label35.TabIndex = 55
        Me.Label35.Text = "Extension"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHandphone
        '
        Me.lblHandphone.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblHandphone.AutoSize = True
        Me.lblHandphone.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHandphone.Location = New System.Drawing.Point(145, 11)
        Me.lblHandphone.Name = "lblHandphone"
        Me.lblHandphone.Size = New System.Drawing.Size(92, 14)
        Me.lblHandphone.TabIndex = 54
        Me.lblHandphone.Text = "Nomor Telepon"
        Me.lblHandphone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tePhone
        '
        Me.tePhone.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tePhone.Location = New System.Drawing.Point(240, 8)
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
        Me.tePhone.TabIndex = 74
        Me.tePhone.Tag = "phone"
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(155, 35)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(82, 14)
        Me.Label19.TabIndex = 40
        Me.Label19.Text = "Jenis Telepon"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'luePhoneType
        '
        Me.luePhoneType.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.luePhoneType.Location = New System.Drawing.Point(240, 32)
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
        Me.luePhoneType.TabIndex = 75
        Me.luePhoneType.Tag = "phonetype"
        '
        'pHeaderTelepon
        '
        Me.pHeaderTelepon.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pHeaderTelepon.Controls.Add(Me.btnNewTelepon)
        Me.pHeaderTelepon.Controls.Add(Me.btnSaveTelepon)
        Me.pHeaderTelepon.Controls.Add(Me.Label21)
        Me.pHeaderTelepon.Controls.Add(Me.btnPrimaryTelepon)
        Me.pHeaderTelepon.Controls.Add(Me.btnDeleteTelepon)
        Me.pHeaderTelepon.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeaderTelepon.ForeColor = System.Drawing.Color.White
        Me.pHeaderTelepon.Location = New System.Drawing.Point(0, 0)
        Me.pHeaderTelepon.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeaderTelepon.Name = "pHeaderTelepon"
        Me.pHeaderTelepon.Size = New System.Drawing.Size(780, 30)
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
        Me.btnNewTelepon.Location = New System.Drawing.Point(460, 0)
        Me.btnNewTelepon.Name = "btnNewTelepon"
        Me.btnNewTelepon.Size = New System.Drawing.Size(60, 30)
        Me.btnNewTelepon.TabIndex = 71
        Me.btnNewTelepon.Text = "BARU"
        Me.btnNewTelepon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNewTelepon.UseVisualStyleBackColor = True
        '
        'btnSaveTelepon
        '
        Me.btnSaveTelepon.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnSaveTelepon.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSaveTelepon.FlatAppearance.BorderSize = 0
        Me.btnSaveTelepon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnSaveTelepon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnSaveTelepon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveTelepon.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveTelepon.Location = New System.Drawing.Point(520, 0)
        Me.btnSaveTelepon.Name = "btnSaveTelepon"
        Me.btnSaveTelepon.Size = New System.Drawing.Size(80, 30)
        Me.btnSaveTelepon.TabIndex = 72
        Me.btnSaveTelepon.Text = "SIMPAN"
        Me.btnSaveTelepon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveTelepon.UseVisualStyleBackColor = False
        '
        'Label21
        '
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(0, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label21.Size = New System.Drawing.Size(200, 30)
        Me.Label21.TabIndex = 10
        Me.Label21.Text = "Telepon"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btnPrimaryTelepon.Location = New System.Drawing.Point(600, 0)
        Me.btnPrimaryTelepon.Name = "btnPrimaryTelepon"
        Me.btnPrimaryTelepon.Size = New System.Drawing.Size(100, 30)
        Me.btnPrimaryTelepon.TabIndex = 94
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
        Me.btnDeleteTelepon.Location = New System.Drawing.Point(700, 0)
        Me.btnDeleteTelepon.Name = "btnDeleteTelepon"
        Me.btnDeleteTelepon.Size = New System.Drawing.Size(80, 30)
        Me.btnDeleteTelepon.TabIndex = 73
        Me.btnDeleteTelepon.Text = "HAPUS"
        Me.btnDeleteTelepon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeleteTelepon.UseVisualStyleBackColor = True
        '
        'xtpCOA
        '
        Me.xtpCOA.Controls.Add(Me.Panel1)
        Me.xtpCOA.Controls.Add(Me.Panel2)
        Me.xtpCOA.Name = "xtpCOA"
        Me.xtpCOA.Size = New System.Drawing.Size(780, 464)
        Me.xtpCOA.Text = "COA"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GridControl1)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(780, 434)
        Me.Panel1.TabIndex = 13
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridControl1.Location = New System.Drawing.Point(0, 84)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(780, 350)
        Me.GridControl1.TabIndex = 43
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GridView1.Appearance.Empty.Options.UseBackColor = True
        Me.GridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.OddRow.Options.UseBackColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn38, Me.GridColumn39, Me.GridColumn40, Me.GridColumn41, Me.GridColumn42, Me.GridColumn43, Me.GridColumn45, Me.GridColumn46, Me.GridColumn47, Me.GridColumn48, Me.GridColumn49, Me.GridColumn50, Me.GridColumn51, Me.GridColumn52, Me.GridColumn53, Me.GridColumn54, Me.GridColumn57, Me.GridColumn58, Me.GridColumn59})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn38
        '
        Me.GridColumn38.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn38.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn38.Caption = "ID"
        Me.GridColumn38.FieldName = "idalamat"
        Me.GridColumn38.Name = "GridColumn38"
        Me.GridColumn38.OptionsColumn.AllowEdit = False
        Me.GridColumn38.OptionsColumn.ReadOnly = True
        '
        'GridColumn39
        '
        Me.GridColumn39.Caption = "ID Negara"
        Me.GridColumn39.FieldName = "idnegara"
        Me.GridColumn39.Name = "GridColumn39"
        Me.GridColumn39.OptionsColumn.AllowEdit = False
        Me.GridColumn39.OptionsColumn.ReadOnly = True
        '
        'GridColumn40
        '
        Me.GridColumn40.Caption = "ID Propinsi"
        Me.GridColumn40.FieldName = "idpropinsi"
        Me.GridColumn40.Name = "GridColumn40"
        Me.GridColumn40.OptionsColumn.AllowEdit = False
        Me.GridColumn40.OptionsColumn.ReadOnly = True
        '
        'GridColumn41
        '
        Me.GridColumn41.Caption = "ID Kabupaten"
        Me.GridColumn41.FieldName = "idkabupaten"
        Me.GridColumn41.Name = "GridColumn41"
        Me.GridColumn41.OptionsColumn.AllowEdit = False
        Me.GridColumn41.OptionsColumn.ReadOnly = True
        '
        'GridColumn42
        '
        Me.GridColumn42.Caption = "ID Kecamatan"
        Me.GridColumn42.FieldName = "idkecamatan"
        Me.GridColumn42.Name = "GridColumn42"
        Me.GridColumn42.OptionsColumn.AllowEdit = False
        Me.GridColumn42.OptionsColumn.ReadOnly = True
        '
        'GridColumn43
        '
        Me.GridColumn43.Caption = "ID Kelurahan"
        Me.GridColumn43.FieldName = "idkelurahan"
        Me.GridColumn43.Name = "GridColumn43"
        Me.GridColumn43.OptionsColumn.AllowEdit = False
        Me.GridColumn43.OptionsColumn.ReadOnly = True
        '
        'GridColumn45
        '
        Me.GridColumn45.Caption = "AddressType"
        Me.GridColumn45.FieldName = "addresstype"
        Me.GridColumn45.Name = "GridColumn45"
        '
        'GridColumn46
        '
        Me.GridColumn46.Caption = "Status Data"
        Me.GridColumn46.FieldName = "isdeleted"
        Me.GridColumn46.Name = "GridColumn46"
        Me.GridColumn46.OptionsColumn.AllowEdit = False
        Me.GridColumn46.OptionsColumn.ReadOnly = True
        '
        'GridColumn47
        '
        Me.GridColumn47.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn47.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn47.Caption = "Is Primary"
        Me.GridColumn47.FieldName = "isprimary"
        Me.GridColumn47.Name = "GridColumn47"
        Me.GridColumn47.OptionsColumn.AllowEdit = False
        Me.GridColumn47.OptionsColumn.ReadOnly = True
        '
        'GridColumn48
        '
        Me.GridColumn48.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn48.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn48.Caption = "Alamat"
        Me.GridColumn48.FieldName = "alamat"
        Me.GridColumn48.Name = "GridColumn48"
        Me.GridColumn48.OptionsColumn.AllowEdit = False
        Me.GridColumn48.OptionsColumn.ReadOnly = True
        Me.GridColumn48.Visible = True
        Me.GridColumn48.VisibleIndex = 6
        Me.GridColumn48.Width = 200
        '
        'GridColumn49
        '
        Me.GridColumn49.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn49.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn49.Caption = "Negara"
        Me.GridColumn49.FieldName = "negara"
        Me.GridColumn49.Name = "GridColumn49"
        Me.GridColumn49.OptionsColumn.AllowEdit = False
        Me.GridColumn49.OptionsColumn.ReadOnly = True
        Me.GridColumn49.Visible = True
        Me.GridColumn49.VisibleIndex = 1
        '
        'GridColumn50
        '
        Me.GridColumn50.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn50.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn50.Caption = "Propinsi"
        Me.GridColumn50.FieldName = "propinsi"
        Me.GridColumn50.Name = "GridColumn50"
        Me.GridColumn50.OptionsColumn.AllowEdit = False
        Me.GridColumn50.OptionsColumn.ReadOnly = True
        Me.GridColumn50.Visible = True
        Me.GridColumn50.VisibleIndex = 2
        '
        'GridColumn51
        '
        Me.GridColumn51.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn51.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn51.Caption = "Kabupaten"
        Me.GridColumn51.FieldName = "kabupaten"
        Me.GridColumn51.Name = "GridColumn51"
        Me.GridColumn51.OptionsColumn.AllowEdit = False
        Me.GridColumn51.OptionsColumn.ReadOnly = True
        Me.GridColumn51.Visible = True
        Me.GridColumn51.VisibleIndex = 3
        '
        'GridColumn52
        '
        Me.GridColumn52.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn52.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn52.Caption = "Kecamatan"
        Me.GridColumn52.FieldName = "kecamatan"
        Me.GridColumn52.Name = "GridColumn52"
        Me.GridColumn52.OptionsColumn.AllowEdit = False
        Me.GridColumn52.OptionsColumn.ReadOnly = True
        Me.GridColumn52.Visible = True
        Me.GridColumn52.VisibleIndex = 4
        '
        'GridColumn53
        '
        Me.GridColumn53.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn53.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn53.Caption = "Kelurahan"
        Me.GridColumn53.FieldName = "kelurahan"
        Me.GridColumn53.Name = "GridColumn53"
        Me.GridColumn53.OptionsColumn.AllowEdit = False
        Me.GridColumn53.OptionsColumn.ReadOnly = True
        Me.GridColumn53.Visible = True
        Me.GridColumn53.VisibleIndex = 5
        '
        'GridColumn54
        '
        Me.GridColumn54.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn54.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn54.Caption = "Status Data"
        Me.GridColumn54.FieldName = "statdata"
        Me.GridColumn54.Name = "GridColumn54"
        Me.GridColumn54.OptionsColumn.AllowEdit = False
        Me.GridColumn54.OptionsColumn.ReadOnly = True
        Me.GridColumn54.Visible = True
        Me.GridColumn54.VisibleIndex = 9
        '
        'GridColumn57
        '
        Me.GridColumn57.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn57.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn57.Caption = "Primary"
        Me.GridColumn57.FieldName = "primary"
        Me.GridColumn57.Name = "GridColumn57"
        Me.GridColumn57.OptionsColumn.AllowEdit = False
        Me.GridColumn57.OptionsColumn.ReadOnly = True
        Me.GridColumn57.Visible = True
        Me.GridColumn57.VisibleIndex = 7
        '
        'GridColumn58
        '
        Me.GridColumn58.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn58.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn58.Caption = "Jenis Alamat"
        Me.GridColumn58.FieldName = "jenisalamat"
        Me.GridColumn58.Name = "GridColumn58"
        Me.GridColumn58.OptionsColumn.AllowEdit = False
        Me.GridColumn58.OptionsColumn.ReadOnly = True
        Me.GridColumn58.Visible = True
        Me.GridColumn58.VisibleIndex = 0
        Me.GridColumn58.Width = 89
        '
        'GridColumn59
        '
        Me.GridColumn59.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn59.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn59.Caption = "Kode Pos"
        Me.GridColumn59.FieldName = "kodepos"
        Me.GridColumn59.Name = "GridColumn59"
        Me.GridColumn59.OptionsColumn.AllowEdit = False
        Me.GridColumn59.OptionsColumn.ReadOnly = True
        Me.GridColumn59.Visible = True
        Me.GridColumn59.VisibleIndex = 8
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(780, 30)
        Me.Panel2.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(560, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 30)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "BARU"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(620, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 30)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "SIMPAN"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(0, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label16.Size = New System.Drawing.Size(200, 30)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "COA"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(700, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 30)
        Me.Button4.TabIndex = 33
        Me.Button4.Text = "HAPUS"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'tlpField
        '
        Me.tlpField.AutoSize = True
        Me.tlpField.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpField.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlpField.ColumnCount = 6
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.Controls.Add(Me.teNPWP, 2, 3)
        Me.tlpField.Controls.Add(Me.Label4, 1, 3)
        Me.tlpField.Controls.Add(Me.teAlias, 4, 2)
        Me.tlpField.Controls.Add(Me.Label3, 3, 2)
        Me.tlpField.Controls.Add(Me.Label1, 1, 1)
        Me.tlpField.Controls.Add(Me.teKodeAngka, 2, 1)
        Me.tlpField.Controls.Add(Me.teUnit, 4, 1)
        Me.tlpField.Controls.Add(Me.lblBank, 3, 1)
        Me.tlpField.Controls.Add(Me.teKode, 2, 2)
        Me.tlpField.Controls.Add(Me.lblKode, 1, 2)
        Me.tlpField.Controls.Add(Me.teRemarks, 4, 3)
        Me.tlpField.Controls.Add(Me.Label2, 3, 3)
        Me.tlpField.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpField.Location = New System.Drawing.Point(0, 0)
        Me.tlpField.Name = "tlpField"
        Me.tlpField.RowCount = 5
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpField.Size = New System.Drawing.Size(844, 84)
        Me.tlpField.TabIndex = 7
        '
        'teNPWP
        '
        Me.teNPWP.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNPWP.Location = New System.Drawing.Point(222, 56)
        Me.teNPWP.Margin = New System.Windows.Forms.Padding(0)
        Me.teNPWP.Name = "teNPWP"
        Me.teNPWP.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teNPWP.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNPWP.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNPWP.Properties.Appearance.Options.UseBackColor = True
        Me.teNPWP.Properties.Appearance.Options.UseFont = True
        Me.teNPWP.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNPWP.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teNPWP.Properties.MaxLength = 10
        Me.teNPWP.Properties.NullText = "[Belum Diisi]"
        Me.teNPWP.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNPWP.Size = New System.Drawing.Size(199, 20)
        Me.teNPWP.TabIndex = 19
        Me.teNPWP.Tag = "npwp"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(178, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 14)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "NPWP"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teAlias
        '
        Me.teAlias.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teAlias.Location = New System.Drawing.Point(522, 32)
        Me.teAlias.Margin = New System.Windows.Forms.Padding(0)
        Me.teAlias.Name = "teAlias"
        Me.teAlias.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teAlias.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teAlias.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teAlias.Properties.Appearance.Options.UseBackColor = True
        Me.teAlias.Properties.Appearance.Options.UseFont = True
        Me.teAlias.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teAlias.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teAlias.Properties.MaxLength = 10
        Me.teAlias.Properties.NullText = "[Belum Diisi]"
        Me.teAlias.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teAlias.Size = New System.Drawing.Size(199, 20)
        Me.teAlias.TabIndex = 19
        Me.teAlias.Tag = "alias"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(489, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 14)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Alias"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(146, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 14)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Kode Angka"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teKodeAngka
        '
        Me.teKodeAngka.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teKodeAngka.Location = New System.Drawing.Point(222, 8)
        Me.teKodeAngka.Margin = New System.Windows.Forms.Padding(0)
        Me.teKodeAngka.Name = "teKodeAngka"
        Me.teKodeAngka.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teKodeAngka.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teKodeAngka.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teKodeAngka.Properties.Appearance.Options.UseBackColor = True
        Me.teKodeAngka.Properties.Appearance.Options.UseFont = True
        Me.teKodeAngka.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teKodeAngka.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teKodeAngka.Properties.MaxLength = 3
        Me.teKodeAngka.Properties.NullText = "[Belum Diisi]"
        Me.teKodeAngka.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teKodeAngka.Size = New System.Drawing.Size(93, 20)
        Me.teKodeAngka.TabIndex = 29
        Me.teKodeAngka.Tag = "kodeangka"
        '
        'teUnit
        '
        Me.teUnit.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teUnit.Location = New System.Drawing.Point(522, 8)
        Me.teUnit.Margin = New System.Windows.Forms.Padding(0)
        Me.teUnit.Name = "teUnit"
        Me.teUnit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teUnit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teUnit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teUnit.Properties.Appearance.Options.UseBackColor = True
        Me.teUnit.Properties.Appearance.Options.UseFont = True
        Me.teUnit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teUnit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teUnit.Properties.MaxLength = 10
        Me.teUnit.Properties.NullText = "[Belum Diisi]"
        Me.teUnit.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teUnit.Size = New System.Drawing.Size(199, 20)
        Me.teUnit.TabIndex = 17
        Me.teUnit.Tag = "unit"
        '
        'lblBank
        '
        Me.lblBank.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblBank.AutoSize = True
        Me.lblBank.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBank.Location = New System.Drawing.Point(490, 11)
        Me.lblBank.Name = "lblBank"
        Me.lblBank.Size = New System.Drawing.Size(29, 14)
        Me.lblBank.TabIndex = 9
        Me.lblBank.Text = "Unit"
        Me.lblBank.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teKode
        '
        Me.teKode.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teKode.Location = New System.Drawing.Point(222, 32)
        Me.teKode.Margin = New System.Windows.Forms.Padding(0)
        Me.teKode.Name = "teKode"
        Me.teKode.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teKode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teKode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teKode.Properties.Appearance.Options.UseBackColor = True
        Me.teKode.Properties.Appearance.Options.UseFont = True
        Me.teKode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teKode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teKode.Properties.MaxLength = 10
        Me.teKode.Properties.NullText = "[Belum Diisi]"
        Me.teKode.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teKode.Size = New System.Drawing.Size(93, 20)
        Me.teKode.TabIndex = 19
        Me.teKode.Tag = "kode"
        '
        'lblKode
        '
        Me.lblKode.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblKode.AutoSize = True
        Me.lblKode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKode.Location = New System.Drawing.Point(150, 35)
        Me.lblKode.Name = "lblKode"
        Me.lblKode.Size = New System.Drawing.Size(69, 14)
        Me.lblKode.TabIndex = 19
        Me.lblKode.Text = "Kode Huruf"
        Me.lblKode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teRemarks
        '
        Me.teRemarks.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teRemarks.Location = New System.Drawing.Point(522, 56)
        Me.teRemarks.Margin = New System.Windows.Forms.Padding(0)
        Me.teRemarks.Name = "teRemarks"
        Me.teRemarks.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teRemarks.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teRemarks.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teRemarks.Properties.Appearance.Options.UseBackColor = True
        Me.teRemarks.Properties.Appearance.Options.UseFont = True
        Me.teRemarks.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teRemarks.Properties.MaxLength = 10
        Me.teRemarks.Properties.NullText = "[Belum Diisi]"
        Me.teRemarks.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teRemarks.Size = New System.Drawing.Size(199, 20)
        Me.teRemarks.TabIndex = 30
        Me.teRemarks.Tag = "remarks"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(449, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 14)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Keterangan"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'xtpData
        '
        Me.xtpData.Controls.Add(Me.gcData)
        Me.xtpData.Name = "xtpData"
        Me.xtpData.Size = New System.Drawing.Size(844, 554)
        Me.xtpData.Text = "DATA"
        '
        'gcData
        '
        Me.gcData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcData.Location = New System.Drawing.Point(0, 0)
        Me.gcData.MainView = Me.gvData
        Me.gcData.Name = "gcData"
        Me.gcData.Size = New System.Drawing.Size(844, 554)
        Me.gcData.TabIndex = 8
        Me.gcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvData})
        '
        'gvData
        '
        Me.gvData.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gvData.Appearance.Empty.Options.UseBackColor = True
        Me.gvData.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvData.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.OddRow.Options.UseBackColor = True
        Me.gvData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcID, Me.gcIDStatData, Me.GridColumn34, Me.GridColumn33, Me.gcUnit, Me.gcRemarks, Me.GridColumn37, Me.GridColumn35, Me.gcStatData})
        Me.gvData.GridControl = Me.gcData
        Me.gvData.Name = "gvData"
        Me.gvData.OptionsView.EnableAppearanceEvenRow = True
        Me.gvData.OptionsView.EnableAppearanceOddRow = True
        Me.gvData.OptionsView.ShowGroupPanel = False
        '
        'gcID
        '
        Me.gcID.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gcID.AppearanceCell.Options.UseBackColor = True
        Me.gcID.AppearanceHeader.Options.UseTextOptions = True
        Me.gcID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcID.Caption = "ID"
        Me.gcID.FieldName = "idbank"
        Me.gcID.Name = "gcID"
        Me.gcID.OptionsColumn.AllowEdit = False
        Me.gcID.OptionsColumn.ReadOnly = True
        '
        'gcIDStatData
        '
        Me.gcIDStatData.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gcIDStatData.AppearanceCell.Options.UseBackColor = True
        Me.gcIDStatData.AppearanceHeader.Options.UseTextOptions = True
        Me.gcIDStatData.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcIDStatData.Caption = "ID Status Data"
        Me.gcIDStatData.FieldName = "isdeleted"
        Me.gcIDStatData.Name = "gcIDStatData"
        Me.gcIDStatData.OptionsColumn.AllowEdit = False
        Me.gcIDStatData.OptionsColumn.ReadOnly = True
        '
        'GridColumn34
        '
        Me.GridColumn34.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn34.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn34.Caption = "Kode Angka"
        Me.GridColumn34.FieldName = "kodeangka"
        Me.GridColumn34.Name = "GridColumn34"
        Me.GridColumn34.OptionsColumn.AllowEdit = False
        Me.GridColumn34.OptionsColumn.ReadOnly = True
        Me.GridColumn34.Visible = True
        Me.GridColumn34.VisibleIndex = 1
        '
        'GridColumn33
        '
        Me.GridColumn33.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn33.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn33.Caption = "Kode Huruf"
        Me.GridColumn33.FieldName = "kode"
        Me.GridColumn33.Name = "GridColumn33"
        Me.GridColumn33.OptionsColumn.AllowEdit = False
        Me.GridColumn33.OptionsColumn.ReadOnly = True
        Me.GridColumn33.Visible = True
        Me.GridColumn33.VisibleIndex = 2
        '
        'gcUnit
        '
        Me.gcUnit.AppearanceHeader.Options.UseTextOptions = True
        Me.gcUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcUnit.Caption = "Unit"
        Me.gcUnit.FieldName = "unit"
        Me.gcUnit.Name = "gcUnit"
        Me.gcUnit.OptionsColumn.AllowEdit = False
        Me.gcUnit.OptionsColumn.ReadOnly = True
        Me.gcUnit.Visible = True
        Me.gcUnit.VisibleIndex = 0
        '
        'gcRemarks
        '
        Me.gcRemarks.AppearanceHeader.Options.UseTextOptions = True
        Me.gcRemarks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcRemarks.Caption = "Keterangan"
        Me.gcRemarks.FieldName = "remarks"
        Me.gcRemarks.Name = "gcRemarks"
        Me.gcRemarks.OptionsColumn.AllowEdit = False
        Me.gcRemarks.OptionsColumn.ReadOnly = True
        Me.gcRemarks.Visible = True
        Me.gcRemarks.VisibleIndex = 5
        '
        'GridColumn37
        '
        Me.GridColumn37.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn37.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn37.Caption = "Alias"
        Me.GridColumn37.FieldName = "alias"
        Me.GridColumn37.Name = "GridColumn37"
        Me.GridColumn37.OptionsColumn.AllowEdit = False
        Me.GridColumn37.OptionsColumn.ReadOnly = True
        Me.GridColumn37.Visible = True
        Me.GridColumn37.VisibleIndex = 3
        '
        'GridColumn35
        '
        Me.GridColumn35.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn35.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn35.Caption = "NPWP"
        Me.GridColumn35.FieldName = "npwp"
        Me.GridColumn35.Name = "GridColumn35"
        Me.GridColumn35.OptionsColumn.AllowEdit = False
        Me.GridColumn35.OptionsColumn.ReadOnly = True
        Me.GridColumn35.Visible = True
        Me.GridColumn35.VisibleIndex = 4
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
        Me.gcStatData.VisibleIndex = 6
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
        Me.pHeader.Size = New System.Drawing.Size(896, 30)
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
        Me.btnExport.Location = New System.Drawing.Point(576, 0)
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
        Me.btnNew.Location = New System.Drawing.Point(676, 0)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(60, 30)
        Me.btnNew.TabIndex = 17
        Me.btnNew.Text = "BARU"
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(736, 0)
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
        Me.btnDelete.Location = New System.Drawing.Point(816, 0)
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
        'btnPrint
        '
        Me.btnPrint.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Image = Global.dizUI.My.Resources.Resources.print
        Me.btnPrint.Location = New System.Drawing.Point(-26, 0)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(100, 1)
        Me.btnPrint.TabIndex = 0
        Me.btnPrint.Text = "PRINT"
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 440.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lueJenisCOA, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.slueCOA, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblJabatan, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.teCOA, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(780, 84)
        Me.TableLayoutPanel1.TabIndex = 48
        '
        'lueJenisCOA
        '
        Me.lueJenisCOA.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueJenisCOA.Location = New System.Drawing.Point(240, 56)
        Me.lueJenisCOA.Margin = New System.Windows.Forms.Padding(0)
        Me.lueJenisCOA.Name = "lueJenisCOA"
        Me.lueJenisCOA.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueJenisCOA.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueJenisCOA.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueJenisCOA.Properties.Appearance.Options.UseBackColor = True
        Me.lueJenisCOA.Properties.Appearance.Options.UseFont = True
        Me.lueJenisCOA.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueJenisCOA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueJenisCOA.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueJenisCOA.Properties.NullText = "[Isian belum dipilih]"
        Me.lueJenisCOA.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueJenisCOA.Size = New System.Drawing.Size(150, 20)
        Me.lueJenisCOA.TabIndex = 50
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(140, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 14)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Jenis Kode Akun"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'slueCOA
        '
        Me.slueCOA.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.slueCOA.Location = New System.Drawing.Point(240, 8)
        Me.slueCOA.Margin = New System.Windows.Forms.Padding(0)
        Me.slueCOA.Name = "slueCOA"
        Me.slueCOA.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.slueCOA.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.slueCOA.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.slueCOA.Properties.Appearance.Options.UseBackColor = True
        Me.slueCOA.Properties.Appearance.Options.UseFont = True
        Me.slueCOA.Properties.Appearance.Options.UseForeColor = True
        Me.slueCOA.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.slueCOA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueCOA.Properties.NullText = "[Isian belum dipilih]"
        Me.slueCOA.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.slueCOA.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Simple
        Me.slueCOA.Properties.PopupFindMode = DevExpress.XtraEditors.FindMode.Always
        Me.slueCOA.Properties.PopupView = Me.slueCOAView
        Me.slueCOA.Properties.ShowFooter = False
        Me.slueCOA.Properties.ShowPopupShadow = False
        Me.slueCOA.Properties.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView
        Me.slueCOA.Size = New System.Drawing.Size(150, 20)
        Me.slueCOA.TabIndex = 35
        '
        'slueCOAView
        '
        Me.slueCOAView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.slueCOAView.Appearance.EvenRow.Options.UseBackColor = True
        Me.slueCOAView.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.slueCOAView.Appearance.OddRow.Options.UseBackColor = True
        Me.slueCOAView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn60, Me.GridColumn61, Me.GridColumn62})
        Me.slueCOAView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.slueCOAView.Name = "slueCOAView"
        Me.slueCOAView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.slueCOAView.OptionsView.ShowGroupPanel = False
        '
        'GridColumn60
        '
        Me.GridColumn60.Caption = "ID"
        Me.GridColumn60.FieldName = "idcoa"
        Me.GridColumn60.Name = "GridColumn60"
        Me.GridColumn60.OptionsColumn.AllowEdit = False
        Me.GridColumn60.OptionsColumn.ReadOnly = True
        '
        'GridColumn61
        '
        Me.GridColumn61.Caption = "COA"
        Me.GridColumn61.FieldName = "coa"
        Me.GridColumn61.Name = "GridColumn61"
        Me.GridColumn61.OptionsColumn.AllowEdit = False
        Me.GridColumn61.OptionsColumn.ReadOnly = True
        Me.GridColumn61.Visible = True
        Me.GridColumn61.VisibleIndex = 0
        '
        'GridColumn62
        '
        Me.GridColumn62.Caption = "Remarks"
        Me.GridColumn62.FieldName = "remarks"
        Me.GridColumn62.Name = "GridColumn62"
        Me.GridColumn62.OptionsColumn.AllowEdit = False
        Me.GridColumn62.OptionsColumn.ReadOnly = True
        Me.GridColumn62.Visible = True
        Me.GridColumn62.VisibleIndex = 1
        '
        'lblJabatan
        '
        Me.lblJabatan.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblJabatan.AutoSize = True
        Me.lblJabatan.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJabatan.Location = New System.Drawing.Point(148, 11)
        Me.lblJabatan.Name = "lblJabatan"
        Me.lblJabatan.Size = New System.Drawing.Size(89, 14)
        Me.lblJabatan.TabIndex = 9
        Me.lblJabatan.Text = "Kode Rekening"
        Me.lblJabatan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teCOA
        '
        Me.teCOA.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teCOA.Location = New System.Drawing.Point(240, 32)
        Me.teCOA.Margin = New System.Windows.Forms.Padding(0)
        Me.teCOA.Name = "teCOA"
        Me.teCOA.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teCOA.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teCOA.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teCOA.Properties.Appearance.Options.UseBackColor = True
        Me.teCOA.Properties.Appearance.Options.UseFont = True
        Me.teCOA.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teCOA.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teCOA.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teCOA.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teCOA.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teCOA.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teCOA.Properties.MaxLength = 10
        Me.teCOA.Properties.NullText = "[Belum Diisi]"
        Me.teCOA.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teCOA.Properties.ReadOnly = True
        Me.teCOA.Size = New System.Drawing.Size(432, 20)
        Me.teCOA.TabIndex = 29
        Me.teCOA.Tag = "remarks"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(180, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 14)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Rekening"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmUnit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(900, 620)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUnit"
        Me.ShowInTaskbar = False
        Me.Text = "Unit"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        CType(Me.xtcProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcProfile.ResumeLayout(False)
        Me.xtpEntry.ResumeLayout(False)
        Me.xtpEntry.PerformLayout()
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
        Me.pEmail.PerformLayout()
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
        Me.xtpCOA.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.tlpField.ResumeLayout(False)
        Me.tlpField.PerformLayout()
        CType(Me.teNPWP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teAlias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teKodeAngka.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teKode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpData.ResumeLayout(False)
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.lueJenisCOA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueCOA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueCOAView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teCOA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents lblSep5 As System.Windows.Forms.Label
    Public WithEvents pHeader As System.Windows.Forms.Panel
    Public WithEvents btnNew As System.Windows.Forms.Button
    Public WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents pBody As System.Windows.Forms.Panel
    Public WithEvents gcData As DevExpress.XtraGrid.GridControl
    Public WithEvents gvData As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents tlpField As System.Windows.Forms.TableLayoutPanel
    Public WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblBank As System.Windows.Forms.Label
    Friend WithEvents teUnit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gcID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcUnit As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents gcStatData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcIDStatData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents teRemarks As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gcRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Friend WithEvents xtcAdditional As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpAddress As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents pAlamat As Panel
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
    Friend WithEvents GridColumn44 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Public WithEvents tlpAlamat1 As TableLayoutPanel
    Friend WithEvents Label38 As Label
    Friend WithEvents teKodepos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lueNegara As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents luePropinsi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueKabupaten As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblNegara As Label
    Friend WithEvents lblPropinsi As Label
    Friend WithEvents lblKabupaten As Label
    Friend WithEvents lueKecamatan As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblKelurahan As Label
    Friend WithEvents lblKecamatan As Label
    Friend WithEvents lueKelurahan As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label12 As Label
    Friend WithEvents lueAddressType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents tlpAlamat2 As TableLayoutPanel
    Friend WithEvents lblAlamat As Label
    Friend WithEvents meAlamat As DevExpress.XtraEditors.MemoEdit
    Public WithEvents pHeaderAlamat As Panel
    Public WithEvents btnNewAlamat As Button
    Public WithEvents btnSaveAlamat As Button
    Public WithEvents btnDeleteAlamat As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents xtpEmail As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents pEmail As Panel
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
    Public WithEvents tlpEmail As TableLayoutPanel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents teEmail As DevExpress.XtraEditors.TextEdit
    Public WithEvents pHeaderEmail As Panel
    Public WithEvents btnNewEmail As Button
    Public WithEvents btnSaveEmail As Button
    Public WithEvents btnDeleteEmail As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents xtpTelepon As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents pTelepon As Panel
    Public WithEvents gcTelepon As DevExpress.XtraGrid.GridControl
    Public WithEvents gvTelepon As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn36 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn30 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn31 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn32 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents tlpTelepon As TableLayoutPanel
    Friend WithEvents teExtension As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label35 As Label
    Friend WithEvents lblHandphone As Label
    Friend WithEvents tePhone As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label19 As Label
    Friend WithEvents luePhoneType As DevExpress.XtraEditors.LookUpEdit
    Public WithEvents pHeaderTelepon As Panel
    Public WithEvents btnNewTelepon As Button
    Public WithEvents btnSaveTelepon As Button
    Public WithEvents btnDeleteTelepon As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents xtcProfile As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpEntry As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpData As DevExpress.XtraTab.XtraTabPage
    Public WithEvents btnExport As Button
    Public WithEvents btnPrimaryAlamat As Button
    Public WithEvents btnPrimaryEmail As Button
    Friend WithEvents lueEmailType As DevExpress.XtraEditors.LookUpEdit
    Public WithEvents btnPrimaryTelepon As Button
    Friend WithEvents teKode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblKode As Label
    Friend WithEvents teKodeAngka As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents GridColumn34 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn33 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents teNPWP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As Label
    Friend WithEvents teAlias As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As Label
    Friend WithEvents GridColumn37 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn35 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents xtpCOA As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel1 As Panel
    Public WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Public WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn38 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn39 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn40 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn41 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn42 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn43 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn45 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn46 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn47 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn48 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn49 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn51 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn52 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn53 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn54 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn57 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn58 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn59 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents Panel2 As Panel
    Public WithEvents Button1 As Button
    Public WithEvents Button2 As Button
    Friend WithEvents Label16 As Label
    Public WithEvents Button4 As Button
    Public WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lueJenisCOA As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label7 As Label
    Friend WithEvents slueCOA As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents slueCOAView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn60 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn61 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn62 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblJabatan As Label
    Friend WithEvents teCOA As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As Label
End Class
