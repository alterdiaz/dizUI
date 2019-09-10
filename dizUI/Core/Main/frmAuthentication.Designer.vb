<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAuthentication
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
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.pBody = New System.Windows.Forms.Panel()
        Me.tlpEntry = New System.Windows.Forms.TableLayoutPanel()
        Me.pInBody = New System.Windows.Forms.Panel()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.lueLevel = New DevExpress.XtraEditors.LookUpEdit()
        Me.tlData = New DevExpress.XtraTreeList.TreeList()
        Me.tlcID = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlcIDP = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlcMenuName = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlcAktif = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.lueAktif = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnSalinPermission = New System.Windows.Forms.Button()
        Me.btnNonAktif = New System.Windows.Forms.Button()
        Me.btnAktif = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUserLevel = New System.Windows.Forms.Button()
        Me.lblSep2 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBody.SuspendLayout()
        Me.tlpEntry.SuspendLayout()
        Me.pInBody.SuspendLayout()
        CType(Me.lueLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tlData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueAktif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpForm
        '
        Me.tlpForm.BackColor = System.Drawing.Color.Maroon
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
        Me.tlpForm.RowCount = 3
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.Size = New System.Drawing.Size(1024, 506)
        Me.tlpForm.TabIndex = 1
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
        Me.pTitle.TabIndex = 35
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
        Me.lblTitle.Text = "Manajemen Akses Panel"
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
        'pBody
        '
        Me.pBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pBody.Controls.Add(Me.tlpEntry)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(1020, 474)
        Me.pBody.TabIndex = 7
        '
        'tlpEntry
        '
        Me.tlpEntry.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlpEntry.ColumnCount = 3
        Me.tlpEntry.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpEntry.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEntry.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpEntry.Controls.Add(Me.pInBody, 1, 1)
        Me.tlpEntry.Controls.Add(Me.tlData, 1, 2)
        Me.tlpEntry.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpEntry.Location = New System.Drawing.Point(0, 30)
        Me.tlpEntry.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEntry.Name = "tlpEntry"
        Me.tlpEntry.RowCount = 4
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpEntry.Size = New System.Drawing.Size(1020, 444)
        Me.tlpEntry.TabIndex = 17
        '
        'pInBody
        '
        Me.pInBody.Controls.Add(Me.lblLevel)
        Me.pInBody.Controls.Add(Me.lueLevel)
        Me.pInBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pInBody.Location = New System.Drawing.Point(6, 6)
        Me.pInBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pInBody.Name = "pInBody"
        Me.pInBody.Size = New System.Drawing.Size(1008, 24)
        Me.pInBody.TabIndex = 0
        '
        'lblLevel
        '
        Me.lblLevel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLevel.AutoSize = True
        Me.lblLevel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.Location = New System.Drawing.Point(728, 5)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(107, 14)
        Me.lblLevel.TabIndex = 31
        Me.lblLevel.Text = "Tingkat Pengguna"
        Me.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueLevel
        '
        Me.lueLevel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lueLevel.Location = New System.Drawing.Point(838, 2)
        Me.lueLevel.Margin = New System.Windows.Forms.Padding(0)
        Me.lueLevel.Name = "lueLevel"
        Me.lueLevel.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueLevel.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueLevel.Properties.Appearance.Options.UseBackColor = True
        Me.lueLevel.Properties.Appearance.Options.UseFont = True
        Me.lueLevel.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueLevel.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.lueLevel.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lueLevel.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueLevel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLevel.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("userlevel", "User Level", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("userdata", "User"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("assuper", "Super"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("iduserlevel", "id", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.lueLevel.Properties.NullText = "[Isian belum dipilih]"
        Me.lueLevel.Size = New System.Drawing.Size(146, 20)
        Me.lueLevel.TabIndex = 30
        '
        'tlData
        '
        Me.tlData.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlData.Appearance.Empty.Options.UseBackColor = True
        Me.tlData.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlData.Appearance.EvenRow.Options.UseBackColor = True
        Me.tlData.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlData.Appearance.OddRow.Options.UseBackColor = True
        Me.tlData.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.tlData.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.tlcID, Me.tlcIDP, Me.tlcMenuName, Me.tlcAktif})
        Me.tlData.Cursor = System.Windows.Forms.Cursors.Default
        Me.tlData.DataSource = Nothing
        Me.tlData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlData.KeyFieldName = "idmenu"
        Me.tlData.Location = New System.Drawing.Point(6, 30)
        Me.tlData.Margin = New System.Windows.Forms.Padding(0)
        Me.tlData.Name = "tlData"
        Me.tlData.OptionsView.AnimationType = DevExpress.XtraTreeList.TreeListAnimationType.AnimateAllContent
        Me.tlData.OptionsView.EnableAppearanceEvenRow = True
        Me.tlData.OptionsView.EnableAppearanceOddRow = True
        Me.tlData.OptionsView.ShowIndicator = False
        Me.tlData.ParentFieldName = "idparent"
        Me.tlData.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lueAktif})
        Me.tlData.Size = New System.Drawing.Size(1008, 408)
        Me.tlData.TabIndex = 0
        '
        'tlcID
        '
        Me.tlcID.Caption = "ID"
        Me.tlcID.FieldName = "idmenu"
        Me.tlcID.Name = "tlcID"
        '
        'tlcIDP
        '
        Me.tlcIDP.Caption = "IDP"
        Me.tlcIDP.FieldName = "idparent"
        Me.tlcIDP.Name = "tlcIDP"
        '
        'tlcMenuName
        '
        Me.tlcMenuName.AppearanceHeader.Options.UseTextOptions = True
        Me.tlcMenuName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tlcMenuName.Caption = "Menu Name"
        Me.tlcMenuName.FieldName = "menuname"
        Me.tlcMenuName.Name = "tlcMenuName"
        Me.tlcMenuName.OptionsColumn.AllowEdit = False
        Me.tlcMenuName.OptionsColumn.AllowSort = False
        Me.tlcMenuName.OptionsColumn.ReadOnly = True
        Me.tlcMenuName.SortOrder = System.Windows.Forms.SortOrder.Ascending
        Me.tlcMenuName.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.[String]
        Me.tlcMenuName.Visible = True
        Me.tlcMenuName.VisibleIndex = 0
        Me.tlcMenuName.Width = 868
        '
        'tlcAktif
        '
        Me.tlcAktif.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlcAktif.AppearanceCell.Options.UseBackColor = True
        Me.tlcAktif.AppearanceHeader.Options.UseTextOptions = True
        Me.tlcAktif.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tlcAktif.Caption = "Aktif"
        Me.tlcAktif.ColumnEdit = Me.lueAktif
        Me.tlcAktif.FieldName = "aktif"
        Me.tlcAktif.MaxWidth = 140
        Me.tlcAktif.Name = "tlcAktif"
        Me.tlcAktif.OptionsColumn.AllowSort = False
        Me.tlcAktif.Visible = True
        Me.tlcAktif.VisibleIndex = 1
        Me.tlcAktif.Width = 140
        '
        'lueAktif
        '
        Me.lueAktif.AutoHeight = False
        Me.lueAktif.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueAktif.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("idstatusdata", "idstatusdata", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("statusdata", "Aktif")})
        Me.lueAktif.Name = "lueAktif"
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Controls.Add(Me.btnSalinPermission)
        Me.pHeader.Controls.Add(Me.btnNonAktif)
        Me.pHeader.Controls.Add(Me.btnAktif)
        Me.pHeader.Controls.Add(Me.Label1)
        Me.pHeader.Controls.Add(Me.btnUserLevel)
        Me.pHeader.Controls.Add(Me.lblSep2)
        Me.pHeader.Controls.Add(Me.btnSave)
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.ForeColor = System.Drawing.Color.White
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(1020, 30)
        Me.pHeader.TabIndex = 4
        '
        'btnSalinPermission
        '
        Me.btnSalinPermission.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalinPermission.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSalinPermission.FlatAppearance.BorderSize = 0
        Me.btnSalinPermission.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnSalinPermission.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnSalinPermission.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalinPermission.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalinPermission.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalinPermission.Location = New System.Drawing.Point(0, 0)
        Me.btnSalinPermission.Name = "btnSalinPermission"
        Me.btnSalinPermission.Size = New System.Drawing.Size(120, 30)
        Me.btnSalinPermission.TabIndex = 35
        Me.btnSalinPermission.Text = "SALIN HAK AKSES"
        Me.btnSalinPermission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalinPermission.UseVisualStyleBackColor = True
        '
        'btnNonAktif
        '
        Me.btnNonAktif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNonAktif.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnNonAktif.FlatAppearance.BorderSize = 0
        Me.btnNonAktif.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnNonAktif.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnNonAktif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNonAktif.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNonAktif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNonAktif.Location = New System.Drawing.Point(538, 0)
        Me.btnNonAktif.Name = "btnNonAktif"
        Me.btnNonAktif.Size = New System.Drawing.Size(130, 30)
        Me.btnNonAktif.TabIndex = 34
        Me.btnNonAktif.Text = "SEMUA NON-AKTIF"
        Me.btnNonAktif.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNonAktif.UseVisualStyleBackColor = True
        '
        'btnAktif
        '
        Me.btnAktif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAktif.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAktif.FlatAppearance.BorderSize = 0
        Me.btnAktif.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnAktif.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnAktif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAktif.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAktif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAktif.Location = New System.Drawing.Point(668, 0)
        Me.btnAktif.Name = "btnAktif"
        Me.btnAktif.Size = New System.Drawing.Size(100, 30)
        Me.btnAktif.TabIndex = 32
        Me.btnAktif.Text = "SEMUA AKTIF"
        Me.btnAktif.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAktif.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(768, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 30)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "|"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnUserLevel
        '
        Me.btnUserLevel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnUserLevel.FlatAppearance.BorderSize = 0
        Me.btnUserLevel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnUserLevel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnUserLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserLevel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserLevel.Location = New System.Drawing.Point(784, 0)
        Me.btnUserLevel.Name = "btnUserLevel"
        Me.btnUserLevel.Size = New System.Drawing.Size(140, 30)
        Me.btnUserLevel.TabIndex = 21
        Me.btnUserLevel.Text = "TINGKAT PENGGUNA"
        Me.btnUserLevel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUserLevel.UseVisualStyleBackColor = True
        '
        'lblSep2
        '
        Me.lblSep2.BackColor = System.Drawing.Color.Transparent
        Me.lblSep2.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblSep2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblSep2.Location = New System.Drawing.Point(924, 0)
        Me.lblSep2.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSep2.Name = "lblSep2"
        Me.lblSep2.Size = New System.Drawing.Size(16, 30)
        Me.lblSep2.TabIndex = 22
        Me.lblSep2.Text = "|"
        Me.lblSep2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Green
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
        'frmAuthentication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 506)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAuthentication"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manajemen Akses Panel"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        Me.tlpEntry.ResumeLayout(False)
        Me.pInBody.ResumeLayout(False)
        Me.pInBody.PerformLayout()
        CType(Me.lueLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tlData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueAktif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pBody As System.Windows.Forms.Panel
    Friend WithEvents pHeader As System.Windows.Forms.Panel
    Public WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents tlpEntry As System.Windows.Forms.TableLayoutPanel
    Public WithEvents btnUserLevel As System.Windows.Forms.Button
    Public WithEvents lblSep2 As System.Windows.Forms.Label
    Friend WithEvents pInBody As System.Windows.Forms.Panel
    Friend WithEvents tlData As DevExpress.XtraTreeList.TreeList
    Friend WithEvents tlcMenuName As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlcAktif As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents lueAktif As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lueLevel As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblLevel As System.Windows.Forms.Label
    Public WithEvents btnAktif As System.Windows.Forms.Button
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents btnNonAktif As System.Windows.Forms.Button
    Friend WithEvents tlcID As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlcIDP As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Public WithEvents btnSalinPermission As Button
End Class
