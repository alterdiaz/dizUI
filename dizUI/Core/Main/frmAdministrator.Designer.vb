<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdministrator
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
        Me.components = New System.ComponentModel.Container()
        Me.tlpForm = New System.Windows.Forms.TableLayoutPanel()
        Me.pBody = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gcData = New DevExpress.XtraGrid.GridControl()
        Me.gvData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcIDLevel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcIDStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcImages = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.peImages = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.gcUsername = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcPassword = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcLevel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcBannedReason = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcNama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcHandphone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcLastCheck = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tlpEntry = New System.Windows.Forms.TableLayoutPanel()
        Me.xtcProfile = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpUsername = New DevExpress.XtraTab.XtraTabPage()
        Me.tlpPengguna = New System.Windows.Forms.TableLayoutPanel()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.lblHint = New System.Windows.Forms.Label()
        Me.lblHandphone = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.teRecAnswer = New DevExpress.XtraEditors.TextEdit()
        Me.teEmail = New DevExpress.XtraEditors.TextEdit()
        Me.teRecQuestion = New DevExpress.XtraEditors.TextEdit()
        Me.teHandphone = New DevExpress.XtraEditors.TextEdit()
        Me.teHint = New DevExpress.XtraEditors.TextEdit()
        Me.teNama = New DevExpress.XtraEditors.TextEdit()
        Me.xtpProfile = New DevExpress.XtraTab.XtraTabPage()
        Me.tlpAdministrator = New System.Windows.Forms.TableLayoutPanel()
        Me.lueStatus = New DevExpress.XtraEditors.LookUpEdit()
        Me.teLastCheck = New DevExpress.XtraEditors.TextEdit()
        Me.teReason = New DevExpress.XtraEditors.TextEdit()
        Me.tePassword = New DevExpress.XtraEditors.TextEdit()
        Me.teUsername = New DevExpress.XtraEditors.TextEdit()
        Me.lblLastCheck = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblReason = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lueLevel = New DevExpress.XtraEditors.LookUpEdit()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnSetting = New System.Windows.Forms.Button()
        Me.btnDevice = New System.Windows.Forms.Button()
        Me.lblLoad = New System.Windows.Forms.Label()
        Me.pbSync = New System.Windows.Forms.PictureBox()
        Me.btnAuthorization = New System.Windows.Forms.Button()
        Me.btnIconMenu = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.lblSep4 = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.pTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.tmrCounter = New System.Windows.Forms.Timer(Me.components)
        Me.bwServer = New System.ComponentModel.BackgroundWorker()
        Me.btnAppDevice = New System.Windows.Forms.Button()
        Me.tlpForm.SuspendLayout()
        Me.pBody.SuspendLayout()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.peImages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpEntry.SuspendLayout()
        CType(Me.xtcProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcProfile.SuspendLayout()
        Me.xtpUsername.SuspendLayout()
        Me.tlpPengguna.SuspendLayout()
        CType(Me.teRecAnswer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teRecQuestion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teHandphone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teHint.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpProfile.SuspendLayout()
        Me.tlpAdministrator.SuspendLayout()
        CType(Me.lueStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teLastCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teReason.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tePassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teUsername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeader.SuspendLayout()
        CType(Me.pbSync, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pTitle.SuspendLayout()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpForm
        '
        Me.tlpForm.BackColor = System.Drawing.Color.Maroon
        Me.tlpForm.ColumnCount = 3
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.Controls.Add(Me.pBody, 1, 1)
        Me.tlpForm.Controls.Add(Me.pTitle, 1, 0)
        Me.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpForm.Location = New System.Drawing.Point(0, 0)
        Me.tlpForm.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpForm.Name = "tlpForm"
        Me.tlpForm.RowCount = 3
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.Size = New System.Drawing.Size(1024, 600)
        Me.tlpForm.TabIndex = 1
        '
        'pBody
        '
        Me.pBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pBody.Controls.Add(Me.Panel1)
        Me.pBody.Controls.Add(Me.gcData)
        Me.pBody.Controls.Add(Me.tlpEntry)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(1020, 568)
        Me.pBody.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(380, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2, 538)
        Me.Panel1.TabIndex = 19
        '
        'gcData
        '
        Me.gcData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcData.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gcData.Location = New System.Drawing.Point(380, 30)
        Me.gcData.MainView = Me.gvData
        Me.gcData.Name = "gcData"
        Me.gcData.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.peImages})
        Me.gcData.Size = New System.Drawing.Size(640, 538)
        Me.gcData.TabIndex = 18
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
        Me.gvData.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.gvData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcID, Me.gcIDLevel, Me.gcIDStatus, Me.gcImages, Me.gcUsername, Me.gcPassword, Me.gcLevel, Me.gcStatus, Me.gcBannedReason, Me.gcNama, Me.gcEmail, Me.gcHandphone, Me.gcLastCheck})
        Me.gvData.GridControl = Me.gcData
        Me.gvData.Name = "gvData"
        Me.gvData.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
        Me.gvData.OptionsView.ColumnAutoWidth = False
        Me.gvData.OptionsView.EnableAppearanceEvenRow = True
        Me.gvData.OptionsView.EnableAppearanceOddRow = True
        Me.gvData.OptionsView.ShowGroupPanel = False
        Me.gvData.RowHeight = 40
        '
        'gcID
        '
        Me.gcID.Caption = "ID"
        Me.gcID.FieldName = "iduser"
        Me.gcID.Name = "gcID"
        Me.gcID.OptionsColumn.AllowEdit = False
        Me.gcID.OptionsColumn.ReadOnly = True
        '
        'gcIDLevel
        '
        Me.gcIDLevel.Caption = "IDLevel"
        Me.gcIDLevel.FieldName = "iduserlevel"
        Me.gcIDLevel.Name = "gcIDLevel"
        Me.gcIDLevel.OptionsColumn.AllowEdit = False
        Me.gcIDLevel.OptionsColumn.ReadOnly = True
        '
        'gcIDStatus
        '
        Me.gcIDStatus.Caption = "IDStatus"
        Me.gcIDStatus.FieldName = "userstatus"
        Me.gcIDStatus.Name = "gcIDStatus"
        Me.gcIDStatus.OptionsColumn.AllowEdit = False
        Me.gcIDStatus.OptionsColumn.ReadOnly = True
        '
        'gcImages
        '
        Me.gcImages.AppearanceHeader.Options.UseTextOptions = True
        Me.gcImages.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcImages.Caption = "Images"
        Me.gcImages.ColumnEdit = Me.peImages
        Me.gcImages.FieldName = "images"
        Me.gcImages.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.gcImages.MaxWidth = 100
        Me.gcImages.Name = "gcImages"
        Me.gcImages.OptionsColumn.AllowEdit = False
        Me.gcImages.OptionsColumn.ReadOnly = True
        Me.gcImages.Visible = True
        Me.gcImages.VisibleIndex = 0
        '
        'peImages
        '
        Me.peImages.Name = "peImages"
        Me.peImages.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.peImages.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        '
        'gcUsername
        '
        Me.gcUsername.AppearanceHeader.Options.UseTextOptions = True
        Me.gcUsername.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcUsername.Caption = "Username"
        Me.gcUsername.FieldName = "username"
        Me.gcUsername.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.gcUsername.Name = "gcUsername"
        Me.gcUsername.OptionsColumn.AllowEdit = False
        Me.gcUsername.OptionsColumn.ReadOnly = True
        Me.gcUsername.Visible = True
        Me.gcUsername.VisibleIndex = 1
        '
        'gcPassword
        '
        Me.gcPassword.AppearanceHeader.Options.UseTextOptions = True
        Me.gcPassword.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcPassword.Caption = "Password"
        Me.gcPassword.FieldName = "password"
        Me.gcPassword.Name = "gcPassword"
        Me.gcPassword.OptionsColumn.AllowEdit = False
        Me.gcPassword.OptionsColumn.ReadOnly = True
        Me.gcPassword.Visible = True
        Me.gcPassword.VisibleIndex = 3
        '
        'gcLevel
        '
        Me.gcLevel.AppearanceHeader.Options.UseTextOptions = True
        Me.gcLevel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcLevel.Caption = "User Level"
        Me.gcLevel.FieldName = "userlevel"
        Me.gcLevel.Name = "gcLevel"
        Me.gcLevel.OptionsColumn.AllowEdit = False
        Me.gcLevel.OptionsColumn.ReadOnly = True
        Me.gcLevel.Visible = True
        Me.gcLevel.VisibleIndex = 4
        '
        'gcStatus
        '
        Me.gcStatus.AppearanceHeader.Options.UseTextOptions = True
        Me.gcStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcStatus.Caption = "Status"
        Me.gcStatus.FieldName = "status"
        Me.gcStatus.Name = "gcStatus"
        Me.gcStatus.OptionsColumn.AllowEdit = False
        Me.gcStatus.OptionsColumn.ReadOnly = True
        Me.gcStatus.Visible = True
        Me.gcStatus.VisibleIndex = 2
        '
        'gcBannedReason
        '
        Me.gcBannedReason.AppearanceHeader.Options.UseTextOptions = True
        Me.gcBannedReason.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcBannedReason.Caption = "Ban Reason"
        Me.gcBannedReason.FieldName = "reason"
        Me.gcBannedReason.Name = "gcBannedReason"
        Me.gcBannedReason.OptionsColumn.AllowEdit = False
        Me.gcBannedReason.OptionsColumn.ReadOnly = True
        Me.gcBannedReason.Visible = True
        Me.gcBannedReason.VisibleIndex = 5
        '
        'gcNama
        '
        Me.gcNama.AppearanceHeader.Options.UseTextOptions = True
        Me.gcNama.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcNama.Caption = "Nama Lengkap"
        Me.gcNama.FieldName = "namalengkap"
        Me.gcNama.Name = "gcNama"
        Me.gcNama.OptionsColumn.AllowEdit = False
        Me.gcNama.OptionsColumn.ReadOnly = True
        Me.gcNama.Visible = True
        Me.gcNama.VisibleIndex = 6
        '
        'gcEmail
        '
        Me.gcEmail.AppearanceHeader.Options.UseTextOptions = True
        Me.gcEmail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcEmail.Caption = "Email"
        Me.gcEmail.FieldName = "email"
        Me.gcEmail.Name = "gcEmail"
        Me.gcEmail.OptionsColumn.AllowEdit = False
        Me.gcEmail.OptionsColumn.ReadOnly = True
        Me.gcEmail.Visible = True
        Me.gcEmail.VisibleIndex = 7
        '
        'gcHandphone
        '
        Me.gcHandphone.AppearanceHeader.Options.UseTextOptions = True
        Me.gcHandphone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcHandphone.Caption = "Handphone"
        Me.gcHandphone.FieldName = "handphone"
        Me.gcHandphone.Name = "gcHandphone"
        Me.gcHandphone.OptionsColumn.AllowEdit = False
        Me.gcHandphone.OptionsColumn.ReadOnly = True
        Me.gcHandphone.Visible = True
        Me.gcHandphone.VisibleIndex = 8
        '
        'gcLastCheck
        '
        Me.gcLastCheck.AppearanceHeader.Options.UseTextOptions = True
        Me.gcLastCheck.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcLastCheck.Caption = "Last Check"
        Me.gcLastCheck.FieldName = "waktucek"
        Me.gcLastCheck.Name = "gcLastCheck"
        Me.gcLastCheck.OptionsColumn.AllowEdit = False
        Me.gcLastCheck.OptionsColumn.ReadOnly = True
        Me.gcLastCheck.Visible = True
        Me.gcLastCheck.VisibleIndex = 9
        '
        'tlpEntry
        '
        Me.tlpEntry.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlpEntry.ColumnCount = 3
        Me.tlpEntry.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpEntry.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 356.0!))
        Me.tlpEntry.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpEntry.Controls.Add(Me.xtcProfile, 1, 1)
        Me.tlpEntry.Dock = System.Windows.Forms.DockStyle.Left
        Me.tlpEntry.Location = New System.Drawing.Point(0, 30)
        Me.tlpEntry.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEntry.Name = "tlpEntry"
        Me.tlpEntry.RowCount = 4
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 232.0!))
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEntry.Size = New System.Drawing.Size(380, 538)
        Me.tlpEntry.TabIndex = 17
        '
        'xtcProfile
        '
        Me.xtcProfile.Location = New System.Drawing.Point(12, 22)
        Me.xtcProfile.Margin = New System.Windows.Forms.Padding(0)
        Me.xtcProfile.Name = "xtcProfile"
        Me.xtcProfile.SelectedTabPage = Me.xtpUsername
        Me.xtcProfile.Size = New System.Drawing.Size(356, 230)
        Me.xtcProfile.TabIndex = 16
        Me.xtcProfile.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpUsername, Me.xtpProfile})
        '
        'xtpUsername
        '
        Me.xtpUsername.Controls.Add(Me.tlpPengguna)
        Me.xtpUsername.Name = "xtpUsername"
        Me.xtpUsername.Size = New System.Drawing.Size(350, 202)
        Me.xtpUsername.Text = "Data Pengguna"
        '
        'tlpPengguna
        '
        Me.tlpPengguna.ColumnCount = 4
        Me.tlpPengguna.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPengguna.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpPengguna.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpPengguna.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPengguna.Controls.Add(Me.lblAnswer, 1, 6)
        Me.tlpPengguna.Controls.Add(Me.lblQuestion, 1, 5)
        Me.tlpPengguna.Controls.Add(Me.lblHint, 1, 4)
        Me.tlpPengguna.Controls.Add(Me.lblHandphone, 1, 3)
        Me.tlpPengguna.Controls.Add(Me.lblEmail, 1, 2)
        Me.tlpPengguna.Controls.Add(Me.lblNama, 1, 1)
        Me.tlpPengguna.Controls.Add(Me.teRecAnswer, 2, 6)
        Me.tlpPengguna.Controls.Add(Me.teEmail, 2, 2)
        Me.tlpPengguna.Controls.Add(Me.teRecQuestion, 2, 5)
        Me.tlpPengguna.Controls.Add(Me.teHandphone, 2, 3)
        Me.tlpPengguna.Controls.Add(Me.teHint, 2, 4)
        Me.tlpPengguna.Controls.Add(Me.teNama, 2, 1)
        Me.tlpPengguna.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPengguna.Location = New System.Drawing.Point(0, 0)
        Me.tlpPengguna.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpPengguna.Name = "tlpPengguna"
        Me.tlpPengguna.RowCount = 8
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpPengguna.Size = New System.Drawing.Size(350, 202)
        Me.tlpPengguna.TabIndex = 15
        '
        'lblAnswer
        '
        Me.lblAnswer.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(30, 154)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(102, 14)
        Me.lblAnswer.TabIndex = 8
        Me.lblAnswer.Text = "Recovery Answer"
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblQuestion
        '
        Me.lblQuestion.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(22, 130)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(110, 14)
        Me.lblQuestion.TabIndex = 7
        Me.lblQuestion.Text = "Recovery Question"
        Me.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHint
        '
        Me.lblHint.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblHint.AutoSize = True
        Me.lblHint.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHint.Location = New System.Drawing.Point(103, 106)
        Me.lblHint.Name = "lblHint"
        Me.lblHint.Size = New System.Drawing.Size(29, 14)
        Me.lblHint.TabIndex = 6
        Me.lblHint.Text = "Hint"
        Me.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHandphone
        '
        Me.lblHandphone.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblHandphone.AutoSize = True
        Me.lblHandphone.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHandphone.Location = New System.Drawing.Point(62, 82)
        Me.lblHandphone.Name = "lblHandphone"
        Me.lblHandphone.Size = New System.Drawing.Size(70, 14)
        Me.lblHandphone.TabIndex = 5
        Me.lblHandphone.Text = "Handphone"
        Me.lblHandphone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEmail
        '
        Me.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(98, 58)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(34, 14)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "Email"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNama
        '
        Me.lblNama.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.Location = New System.Drawing.Point(45, 34)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(87, 14)
        Me.lblNama.TabIndex = 3
        Me.lblNama.Text = "Nama Lengkap"
        Me.lblNama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teRecAnswer
        '
        Me.teRecAnswer.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teRecAnswer.Location = New System.Drawing.Point(135, 151)
        Me.teRecAnswer.Margin = New System.Windows.Forms.Padding(0)
        Me.teRecAnswer.Name = "teRecAnswer"
        Me.teRecAnswer.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teRecAnswer.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teRecAnswer.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teRecAnswer.Properties.Appearance.Options.UseBackColor = True
        Me.teRecAnswer.Properties.Appearance.Options.UseFont = True
        Me.teRecAnswer.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teRecAnswer.Properties.NullText = "[Kosong]"
        Me.teRecAnswer.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teRecAnswer.Size = New System.Drawing.Size(187, 20)
        Me.teRecAnswer.TabIndex = 21
        Me.teRecAnswer.Tag = "recoveryanswer"
        '
        'teEmail
        '
        Me.teEmail.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teEmail.Location = New System.Drawing.Point(135, 55)
        Me.teEmail.Margin = New System.Windows.Forms.Padding(0)
        Me.teEmail.Name = "teEmail"
        Me.teEmail.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teEmail.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teEmail.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teEmail.Properties.Appearance.Options.UseBackColor = True
        Me.teEmail.Properties.Appearance.Options.UseFont = True
        Me.teEmail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teEmail.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.teEmail.Properties.NullText = "[Kosong]"
        Me.teEmail.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teEmail.Size = New System.Drawing.Size(187, 20)
        Me.teEmail.TabIndex = 17
        Me.teEmail.Tag = "email"
        '
        'teRecQuestion
        '
        Me.teRecQuestion.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teRecQuestion.Location = New System.Drawing.Point(135, 127)
        Me.teRecQuestion.Margin = New System.Windows.Forms.Padding(0)
        Me.teRecQuestion.Name = "teRecQuestion"
        Me.teRecQuestion.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teRecQuestion.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teRecQuestion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teRecQuestion.Properties.Appearance.Options.UseBackColor = True
        Me.teRecQuestion.Properties.Appearance.Options.UseFont = True
        Me.teRecQuestion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teRecQuestion.Properties.NullText = "[Kosong]"
        Me.teRecQuestion.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teRecQuestion.Size = New System.Drawing.Size(187, 20)
        Me.teRecQuestion.TabIndex = 20
        Me.teRecQuestion.Tag = "recoveryquestion"
        '
        'teHandphone
        '
        Me.teHandphone.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teHandphone.Location = New System.Drawing.Point(135, 79)
        Me.teHandphone.Margin = New System.Windows.Forms.Padding(0)
        Me.teHandphone.Name = "teHandphone"
        Me.teHandphone.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teHandphone.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teHandphone.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teHandphone.Properties.Appearance.Options.UseBackColor = True
        Me.teHandphone.Properties.Appearance.Options.UseFont = True
        Me.teHandphone.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teHandphone.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.teHandphone.Properties.NullText = "[Kosong]"
        Me.teHandphone.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teHandphone.Size = New System.Drawing.Size(187, 20)
        Me.teHandphone.TabIndex = 18
        Me.teHandphone.Tag = "handphone"
        '
        'teHint
        '
        Me.teHint.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teHint.Location = New System.Drawing.Point(135, 103)
        Me.teHint.Margin = New System.Windows.Forms.Padding(0)
        Me.teHint.Name = "teHint"
        Me.teHint.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teHint.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teHint.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teHint.Properties.Appearance.Options.UseBackColor = True
        Me.teHint.Properties.Appearance.Options.UseFont = True
        Me.teHint.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teHint.Properties.NullText = "[Kosong]"
        Me.teHint.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teHint.Size = New System.Drawing.Size(187, 20)
        Me.teHint.TabIndex = 19
        Me.teHint.Tag = "hint"
        '
        'teNama
        '
        Me.teNama.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNama.Location = New System.Drawing.Point(135, 31)
        Me.teNama.Margin = New System.Windows.Forms.Padding(0)
        Me.teNama.Name = "teNama"
        Me.teNama.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teNama.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNama.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNama.Properties.Appearance.Options.UseBackColor = True
        Me.teNama.Properties.Appearance.Options.UseFont = True
        Me.teNama.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNama.Properties.NullText = "[Kosong]"
        Me.teNama.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNama.Size = New System.Drawing.Size(187, 20)
        Me.teNama.TabIndex = 35
        Me.teNama.Tag = "namalengkap"
        '
        'xtpProfile
        '
        Me.xtpProfile.Controls.Add(Me.tlpAdministrator)
        Me.xtpProfile.Name = "xtpProfile"
        Me.xtpProfile.Size = New System.Drawing.Size(350, 202)
        Me.xtpProfile.Text = "Data Profile"
        '
        'tlpAdministrator
        '
        Me.tlpAdministrator.ColumnCount = 4
        Me.tlpAdministrator.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpAdministrator.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpAdministrator.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpAdministrator.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpAdministrator.Controls.Add(Me.lueStatus, 2, 4)
        Me.tlpAdministrator.Controls.Add(Me.teLastCheck, 2, 6)
        Me.tlpAdministrator.Controls.Add(Me.teReason, 2, 5)
        Me.tlpAdministrator.Controls.Add(Me.tePassword, 2, 2)
        Me.tlpAdministrator.Controls.Add(Me.teUsername, 2, 1)
        Me.tlpAdministrator.Controls.Add(Me.lblLastCheck, 1, 6)
        Me.tlpAdministrator.Controls.Add(Me.lblStatus, 1, 4)
        Me.tlpAdministrator.Controls.Add(Me.lblReason, 1, 5)
        Me.tlpAdministrator.Controls.Add(Me.lblPassword, 1, 2)
        Me.tlpAdministrator.Controls.Add(Me.lblLevel, 1, 3)
        Me.tlpAdministrator.Controls.Add(Me.lblUsername, 1, 1)
        Me.tlpAdministrator.Controls.Add(Me.lueLevel, 2, 3)
        Me.tlpAdministrator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpAdministrator.Location = New System.Drawing.Point(0, 0)
        Me.tlpAdministrator.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpAdministrator.Name = "tlpAdministrator"
        Me.tlpAdministrator.RowCount = 8
        Me.tlpAdministrator.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpAdministrator.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpAdministrator.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpAdministrator.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpAdministrator.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpAdministrator.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpAdministrator.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpAdministrator.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpAdministrator.Size = New System.Drawing.Size(350, 202)
        Me.tlpAdministrator.TabIndex = 0
        '
        'lueStatus
        '
        Me.lueStatus.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueStatus.Location = New System.Drawing.Point(135, 103)
        Me.lueStatus.Margin = New System.Windows.Forms.Padding(0)
        Me.lueStatus.Name = "lueStatus"
        Me.lueStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueStatus.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueStatus.Properties.Appearance.Options.UseBackColor = True
        Me.lueStatus.Properties.Appearance.Options.UseFont = True
        Me.lueStatus.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueStatus.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("status", "User Status"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("userstatus", "id", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.lueStatus.Properties.NullText = "[Isian belum dipilih]"
        Me.lueStatus.Size = New System.Drawing.Size(146, 20)
        Me.lueStatus.TabIndex = 30
        '
        'teLastCheck
        '
        Me.teLastCheck.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teLastCheck.Location = New System.Drawing.Point(135, 151)
        Me.teLastCheck.Margin = New System.Windows.Forms.Padding(0)
        Me.teLastCheck.Name = "teLastCheck"
        Me.teLastCheck.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teLastCheck.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teLastCheck.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teLastCheck.Properties.Appearance.Options.UseBackColor = True
        Me.teLastCheck.Properties.Appearance.Options.UseFont = True
        Me.teLastCheck.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teLastCheck.Properties.NullText = "[Kosong]"
        Me.teLastCheck.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teLastCheck.Properties.ReadOnly = True
        Me.teLastCheck.Size = New System.Drawing.Size(187, 20)
        Me.teLastCheck.TabIndex = 27
        '
        'teReason
        '
        Me.teReason.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teReason.Location = New System.Drawing.Point(135, 127)
        Me.teReason.Margin = New System.Windows.Forms.Padding(0)
        Me.teReason.Name = "teReason"
        Me.teReason.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teReason.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teReason.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teReason.Properties.Appearance.Options.UseBackColor = True
        Me.teReason.Properties.Appearance.Options.UseFont = True
        Me.teReason.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teReason.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.teReason.Properties.NullText = "[Kosong]"
        Me.teReason.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teReason.Size = New System.Drawing.Size(187, 20)
        Me.teReason.TabIndex = 26
        Me.teReason.Tag = "reason"
        '
        'tePassword
        '
        Me.tePassword.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tePassword.Location = New System.Drawing.Point(135, 55)
        Me.tePassword.Margin = New System.Windows.Forms.Padding(0)
        Me.tePassword.Name = "tePassword"
        Me.tePassword.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.tePassword.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tePassword.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tePassword.Properties.Appearance.Options.UseBackColor = True
        Me.tePassword.Properties.Appearance.Options.UseFont = True
        Me.tePassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tePassword.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tePassword.Properties.NullText = "[Kosong]"
        Me.tePassword.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.tePassword.Properties.UseSystemPasswordChar = True
        Me.tePassword.Size = New System.Drawing.Size(187, 20)
        Me.tePassword.TabIndex = 23
        Me.tePassword.Tag = "password"
        '
        'teUsername
        '
        Me.teUsername.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teUsername.Location = New System.Drawing.Point(135, 31)
        Me.teUsername.Margin = New System.Windows.Forms.Padding(0)
        Me.teUsername.Name = "teUsername"
        Me.teUsername.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teUsername.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teUsername.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teUsername.Properties.Appearance.Options.UseBackColor = True
        Me.teUsername.Properties.Appearance.Options.UseFont = True
        Me.teUsername.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teUsername.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teUsername.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.teUsername.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teUsername.Properties.AppearanceDisabled.Options.UseFont = True
        Me.teUsername.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.teUsername.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teUsername.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.teUsername.Properties.MaxLength = 10
        Me.teUsername.Properties.NullText = "[Kosong]"
        Me.teUsername.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teUsername.Size = New System.Drawing.Size(187, 20)
        Me.teUsername.TabIndex = 22
        Me.teUsername.Tag = "username"
        '
        'lblLastCheck
        '
        Me.lblLastCheck.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblLastCheck.AutoSize = True
        Me.lblLastCheck.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastCheck.Location = New System.Drawing.Point(66, 154)
        Me.lblLastCheck.Name = "lblLastCheck"
        Me.lblLastCheck.Size = New System.Drawing.Size(66, 14)
        Me.lblLastCheck.TabIndex = 13
        Me.lblLastCheck.Text = "Last Check"
        Me.lblLastCheck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(62, 106)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(70, 14)
        Me.lblStatus.TabIndex = 10
        Me.lblStatus.Text = "User Status"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblReason
        '
        Me.lblReason.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblReason.AutoSize = True
        Me.lblReason.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReason.Location = New System.Drawing.Point(41, 130)
        Me.lblReason.Name = "lblReason"
        Me.lblReason.Size = New System.Drawing.Size(91, 14)
        Me.lblReason.TabIndex = 15
        Me.lblReason.Text = "Banned Reason"
        Me.lblReason.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPassword
        '
        Me.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(74, 58)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(58, 14)
        Me.lblPassword.TabIndex = 12
        Me.lblPassword.Text = "Password"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLevel
        '
        Me.lblLevel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblLevel.AutoSize = True
        Me.lblLevel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.Location = New System.Drawing.Point(69, 82)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(63, 14)
        Me.lblLevel.TabIndex = 9
        Me.lblLevel.Text = "User Level"
        Me.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUsername
        '
        Me.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(71, 34)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(61, 14)
        Me.lblUsername.TabIndex = 11
        Me.lblUsername.Text = "Username"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueLevel
        '
        Me.lueLevel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueLevel.Location = New System.Drawing.Point(135, 79)
        Me.lueLevel.Margin = New System.Windows.Forms.Padding(0)
        Me.lueLevel.Name = "lueLevel"
        Me.lueLevel.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueLevel.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueLevel.Properties.Appearance.Options.UseBackColor = True
        Me.lueLevel.Properties.Appearance.Options.UseFont = True
        Me.lueLevel.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueLevel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLevel.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("userlevel", "User Level", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("userdata", "User"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("assuper", "Super"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("iduserlevel", "id", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.lueLevel.Properties.NullText = "[Isian belum dipilih]"
        Me.lueLevel.Size = New System.Drawing.Size(146, 20)
        Me.lueLevel.TabIndex = 29
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Controls.Add(Me.btnAppDevice)
        Me.pHeader.Controls.Add(Me.btnSetting)
        Me.pHeader.Controls.Add(Me.btnDevice)
        Me.pHeader.Controls.Add(Me.lblLoad)
        Me.pHeader.Controls.Add(Me.pbSync)
        Me.pHeader.Controls.Add(Me.btnAuthorization)
        Me.pHeader.Controls.Add(Me.btnIconMenu)
        Me.pHeader.Controls.Add(Me.btnMenu)
        Me.pHeader.Controls.Add(Me.lblSep4)
        Me.pHeader.Controls.Add(Me.btnNew)
        Me.pHeader.Controls.Add(Me.btnSave)
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.ForeColor = System.Drawing.Color.White
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(1020, 30)
        Me.pHeader.TabIndex = 4
        '
        'btnSetting
        '
        Me.btnSetting.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSetting.FlatAppearance.BorderSize = 0
        Me.btnSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSetting.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetting.Location = New System.Drawing.Point(334, 0)
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.Size = New System.Drawing.Size(100, 30)
        Me.btnSetting.TabIndex = 26
        Me.btnSetting.Text = "PENGATURAN"
        Me.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSetting.UseVisualStyleBackColor = True
        '
        'btnDevice
        '
        Me.btnDevice.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDevice.FlatAppearance.BorderSize = 0
        Me.btnDevice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnDevice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDevice.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDevice.Location = New System.Drawing.Point(434, 0)
        Me.btnDevice.Name = "btnDevice"
        Me.btnDevice.Size = New System.Drawing.Size(80, 30)
        Me.btnDevice.TabIndex = 29
        Me.btnDevice.Text = "DEVICE"
        Me.btnDevice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDevice.UseVisualStyleBackColor = True
        '
        'lblLoad
        '
        Me.lblLoad.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblLoad.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoad.Location = New System.Drawing.Point(30, 0)
        Me.lblLoad.Name = "lblLoad"
        Me.lblLoad.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.lblLoad.Size = New System.Drawing.Size(150, 30)
        Me.lblLoad.TabIndex = 28
        Me.lblLoad.Text = "LOAD (0/0)"
        Me.lblLoad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbSync
        '
        Me.pbSync.Dock = System.Windows.Forms.DockStyle.Left
        Me.pbSync.Image = Global.dizUI.My.Resources.Resources.loading
        Me.pbSync.Location = New System.Drawing.Point(0, 0)
        Me.pbSync.Name = "pbSync"
        Me.pbSync.Size = New System.Drawing.Size(30, 30)
        Me.pbSync.TabIndex = 27
        Me.pbSync.TabStop = False
        '
        'btnAuthorization
        '
        Me.btnAuthorization.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAuthorization.FlatAppearance.BorderSize = 0
        Me.btnAuthorization.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnAuthorization.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnAuthorization.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAuthorization.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAuthorization.Location = New System.Drawing.Point(514, 0)
        Me.btnAuthorization.Name = "btnAuthorization"
        Me.btnAuthorization.Size = New System.Drawing.Size(150, 30)
        Me.btnAuthorization.TabIndex = 21
        Me.btnAuthorization.Text = "MANAJEMEN AKSES"
        Me.btnAuthorization.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAuthorization.UseVisualStyleBackColor = True
        '
        'btnIconMenu
        '
        Me.btnIconMenu.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnIconMenu.FlatAppearance.BorderSize = 0
        Me.btnIconMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnIconMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnIconMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIconMenu.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIconMenu.Location = New System.Drawing.Point(664, 0)
        Me.btnIconMenu.Name = "btnIconMenu"
        Me.btnIconMenu.Size = New System.Drawing.Size(120, 30)
        Me.btnIconMenu.TabIndex = 23
        Me.btnIconMenu.Text = "MANAJEMEN ICON"
        Me.btnIconMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIconMenu.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMenu.FlatAppearance.BorderSize = 0
        Me.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.Location = New System.Drawing.Point(784, 0)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(80, 30)
        Me.btnMenu.TabIndex = 19
        Me.btnMenu.Text = "MENU"
        Me.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'lblSep4
        '
        Me.lblSep4.BackColor = System.Drawing.Color.Transparent
        Me.lblSep4.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblSep4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblSep4.Location = New System.Drawing.Point(864, 0)
        Me.lblSep4.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSep4.Name = "lblSep4"
        Me.lblSep4.Size = New System.Drawing.Size(16, 30)
        Me.lblSep4.TabIndex = 18
        Me.lblSep4.Text = "|"
        Me.lblSep4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNew
        '
        Me.btnNew.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnNew.FlatAppearance.BorderSize = 0
        Me.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(880, 0)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(60, 30)
        Me.btnNew.TabIndex = 25
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
        Me.btnSave.Location = New System.Drawing.Point(940, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "SIMPAN"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'pTitle
        '
        Me.pTitle.Controls.Add(Me.lblTitle)
        Me.pTitle.Controls.Add(Me.pExit)
        Me.pTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pTitle.Location = New System.Drawing.Point(2, 0)
        Me.pTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.pTitle.Name = "pTitle"
        Me.pTitle.Size = New System.Drawing.Size(1020, 30)
        Me.pTitle.TabIndex = 8
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Maroon
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(990, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Administrator"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pExit
        '
        Me.pExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.pExit.Image = Global.dizUI.My.Resources.Resources.exit_w
        Me.pExit.Location = New System.Drawing.Point(990, 0)
        Me.pExit.Margin = New System.Windows.Forms.Padding(0)
        Me.pExit.Name = "pExit"
        Me.pExit.Size = New System.Drawing.Size(30, 30)
        Me.pExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pExit.TabIndex = 10
        Me.pExit.TabStop = False
        '
        'tmrCounter
        '
        Me.tmrCounter.Interval = 5000
        '
        'bwServer
        '
        Me.bwServer.WorkerSupportsCancellation = True
        '
        'btnAppDevice
        '
        Me.btnAppDevice.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAppDevice.FlatAppearance.BorderSize = 0
        Me.btnAppDevice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnAppDevice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnAppDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAppDevice.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAppDevice.Location = New System.Drawing.Point(234, 0)
        Me.btnAppDevice.Name = "btnAppDevice"
        Me.btnAppDevice.Size = New System.Drawing.Size(100, 30)
        Me.btnAppDevice.TabIndex = 30
        Me.btnAppDevice.Text = "APP DEVICE"
        Me.btnAppDevice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAppDevice.UseVisualStyleBackColor = True
        '
        'frmAdministrator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 600)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAdministrator"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrator"
        Me.tlpForm.ResumeLayout(False)
        Me.pBody.ResumeLayout(False)
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.peImages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpEntry.ResumeLayout(False)
        CType(Me.xtcProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcProfile.ResumeLayout(False)
        Me.xtpUsername.ResumeLayout(False)
        Me.tlpPengguna.ResumeLayout(False)
        Me.tlpPengguna.PerformLayout()
        CType(Me.teRecAnswer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teRecQuestion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teHandphone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teHint.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpProfile.ResumeLayout(False)
        Me.tlpAdministrator.ResumeLayout(False)
        Me.tlpAdministrator.PerformLayout()
        CType(Me.lueStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teLastCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teReason.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tePassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        CType(Me.pbSync, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pTitle.ResumeLayout(False)
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pBody As System.Windows.Forms.Panel
    Friend WithEvents pHeader As System.Windows.Forms.Panel
    Public WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblHandphone As System.Windows.Forms.Label
    Friend WithEvents lblHint As System.Windows.Forms.Label
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents lblLevel As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblLastCheck As System.Windows.Forms.Label
    Friend WithEvents lblReason As System.Windows.Forms.Label
    Friend WithEvents teEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teHandphone As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teHint As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teRecQuestion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teRecAnswer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teUsername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tePassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teReason As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teLastCheck As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tlpPengguna As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents xtcProfile As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpUsername As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpProfile As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tlpAdministrator As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpEntry As System.Windows.Forms.TableLayoutPanel
    Public WithEvents gcData As DevExpress.XtraGrid.GridControl
    Public WithEvents gvData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lueLevel As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents gcID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcUsername As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcPassword As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcLevel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcBannedReason As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcNama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcHandphone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcLastCheck As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents btnMenu As System.Windows.Forms.Button
    Public WithEvents lblSep4 As System.Windows.Forms.Label
    Public WithEvents btnAuthorization As System.Windows.Forms.Button
    Public WithEvents btnIconMenu As System.Windows.Forms.Button
    Public WithEvents btnNew As System.Windows.Forms.Button
    Public WithEvents btnSetting As System.Windows.Forms.Button
    Friend WithEvents teNama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gcIDLevel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcIDStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcImages As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents peImages As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents lueStatus As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents pbSync As System.Windows.Forms.PictureBox
    Friend WithEvents lblLoad As System.Windows.Forms.Label
    Friend WithEvents tmrCounter As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents bwServer As System.ComponentModel.BackgroundWorker
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Public WithEvents btnDevice As System.Windows.Forms.Button
    Public WithEvents btnAppDevice As Button
End Class
