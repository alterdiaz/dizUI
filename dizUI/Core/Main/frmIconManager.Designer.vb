<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIconManager
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
        Me.tboFilename = New System.Windows.Forms.TextBox()
        Me.lblFilename = New System.Windows.Forms.Label()
        Me.tboDescription = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.tcControl = New System.Windows.Forms.TabControl()
        Me.tpInfo = New System.Windows.Forms.TabPage()
        Me.lbliSize = New System.Windows.Forms.Label()
        Me.tpNew = New System.Windows.Forms.TabPage()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.btnnBrowse = New System.Windows.Forms.Button()
        Me.btnnSave = New System.Windows.Forms.Button()
        Me.tpFolder = New System.Windows.Forms.TabPage()
        Me.btnfBrowse = New System.Windows.Forms.Button()
        Me.btnfSave = New System.Windows.Forms.Button()
        Me.lblFiles = New System.Windows.Forms.Label()
        Me.tboPath = New System.Windows.Forms.TextBox()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.lboFilenames = New System.Windows.Forms.ListBox()
        Me.tlpForm = New System.Windows.Forms.TableLayoutPanel()
        Me.pTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.pBody = New System.Windows.Forms.Panel()
        Me.gcData = New DevExpress.XtraGrid.GridControl()
        Me.lvImages = New DevExpress.XtraGrid.Views.Layout.LayoutView()
        Me.lvcImages = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.peImages = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.layoutViewField_LayoutViewColumn1_1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.lvcID = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_LayoutViewColumn1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.lvcDateTime = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_LayoutViewColumn1_2 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.lvcSize = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_LayoutViewColumn2 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.lvcFilename = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_LayoutViewColumn1_3 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.LayoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.tcControl.SuspendLayout()
        Me.tpInfo.SuspendLayout()
        Me.tpNew.SuspendLayout()
        Me.tpFolder.SuspendLayout()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBody.SuspendLayout()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lvImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.peImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn1_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn1_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn1_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tboFilename
        '
        Me.tboFilename.BackColor = System.Drawing.Color.White
        Me.tboFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboFilename.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tboFilename.Location = New System.Drawing.Point(77, 6)
        Me.tboFilename.MaxLength = 10
        Me.tboFilename.Name = "tboFilename"
        Me.tboFilename.ReadOnly = True
        Me.tboFilename.Size = New System.Drawing.Size(287, 22)
        Me.tboFilename.TabIndex = 4
        '
        'lblFilename
        '
        Me.lblFilename.AutoSize = True
        Me.lblFilename.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblFilename.Location = New System.Drawing.Point(6, 10)
        Me.lblFilename.Margin = New System.Windows.Forms.Padding(0)
        Me.lblFilename.Name = "lblFilename"
        Me.lblFilename.Size = New System.Drawing.Size(54, 14)
        Me.lblFilename.TabIndex = 3
        Me.lblFilename.Text = "Filename"
        '
        'tboDescription
        '
        Me.tboDescription.BackColor = System.Drawing.Color.White
        Me.tboDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboDescription.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tboDescription.Location = New System.Drawing.Point(77, 6)
        Me.tboDescription.MaxLength = 10
        Me.tboDescription.Name = "tboDescription"
        Me.tboDescription.ReadOnly = True
        Me.tboDescription.Size = New System.Drawing.Size(352, 22)
        Me.tboDescription.TabIndex = 6
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblDescription.Location = New System.Drawing.Point(6, 10)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(54, 14)
        Me.lblDescription.TabIndex = 5
        Me.lblDescription.Text = "Filename"
        '
        'tcControl
        '
        Me.tcControl.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.tcControl.Controls.Add(Me.tpInfo)
        Me.tcControl.Controls.Add(Me.tpNew)
        Me.tcControl.Controls.Add(Me.tpFolder)
        Me.tcControl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tcControl.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tcControl.Location = New System.Drawing.Point(0, 425)
        Me.tcControl.Multiline = True
        Me.tcControl.Name = "tcControl"
        Me.tcControl.SelectedIndex = 0
        Me.tcControl.Size = New System.Drawing.Size(670, 65)
        Me.tcControl.TabIndex = 7
        '
        'tpInfo
        '
        Me.tpInfo.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.tpInfo.Controls.Add(Me.lbliSize)
        Me.tpInfo.Controls.Add(Me.lblDescription)
        Me.tpInfo.Controls.Add(Me.tboDescription)
        Me.tpInfo.Location = New System.Drawing.Point(4, 26)
        Me.tpInfo.Name = "tpInfo"
        Me.tpInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.tpInfo.Size = New System.Drawing.Size(662, 35)
        Me.tpInfo.TabIndex = 1
        Me.tpInfo.Text = "Image Info"
        Me.tpInfo.UseVisualStyleBackColor = True
        '
        'lbliSize
        '
        Me.lbliSize.AutoSize = True
        Me.lbliSize.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lbliSize.Location = New System.Drawing.Point(435, 10)
        Me.lbliSize.Name = "lbliSize"
        Me.lbliSize.Size = New System.Drawing.Size(103, 14)
        Me.lbliSize.TabIndex = 19
        Me.lbliSize.Text = "1000px x 1000px"
        '
        'tpNew
        '
        Me.tpNew.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.tpNew.Controls.Add(Me.lblSize)
        Me.tpNew.Controls.Add(Me.tboFilename)
        Me.tpNew.Controls.Add(Me.btnnBrowse)
        Me.tpNew.Controls.Add(Me.btnnSave)
        Me.tpNew.Controls.Add(Me.lblFilename)
        Me.tpNew.Location = New System.Drawing.Point(4, 26)
        Me.tpNew.Name = "tpNew"
        Me.tpNew.Padding = New System.Windows.Forms.Padding(3)
        Me.tpNew.Size = New System.Drawing.Size(662, 35)
        Me.tpNew.TabIndex = 0
        Me.tpNew.Text = "Image Upload"
        Me.tpNew.UseVisualStyleBackColor = True
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblSize.Location = New System.Drawing.Point(367, 10)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(103, 14)
        Me.lblSize.TabIndex = 18
        Me.lblSize.Text = "1000px x 1000px"
        '
        'btnnBrowse
        '
        Me.btnnBrowse.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnnBrowse.FlatAppearance.BorderSize = 0
        Me.btnnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnBrowse.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnBrowse.Location = New System.Drawing.Point(499, 3)
        Me.btnnBrowse.Name = "btnnBrowse"
        Me.btnnBrowse.Size = New System.Drawing.Size(80, 29)
        Me.btnnBrowse.TabIndex = 14
        Me.btnnBrowse.Text = "BROWSE"
        Me.btnnBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnnBrowse.UseVisualStyleBackColor = True
        '
        'btnnSave
        '
        Me.btnnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnnSave.FlatAppearance.BorderSize = 0
        Me.btnnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnSave.Location = New System.Drawing.Point(579, 3)
        Me.btnnSave.Name = "btnnSave"
        Me.btnnSave.Size = New System.Drawing.Size(80, 29)
        Me.btnnSave.TabIndex = 13
        Me.btnnSave.Text = "SAVE"
        Me.btnnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnnSave.UseVisualStyleBackColor = True
        '
        'tpFolder
        '
        Me.tpFolder.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.tpFolder.Controls.Add(Me.btnfBrowse)
        Me.tpFolder.Controls.Add(Me.btnfSave)
        Me.tpFolder.Controls.Add(Me.lblFiles)
        Me.tpFolder.Controls.Add(Me.tboPath)
        Me.tpFolder.Controls.Add(Me.lblPath)
        Me.tpFolder.Controls.Add(Me.lboFilenames)
        Me.tpFolder.Location = New System.Drawing.Point(4, 26)
        Me.tpFolder.Name = "tpFolder"
        Me.tpFolder.Padding = New System.Windows.Forms.Padding(3)
        Me.tpFolder.Size = New System.Drawing.Size(662, 35)
        Me.tpFolder.TabIndex = 2
        Me.tpFolder.Text = "Images in Folder Upload"
        '
        'btnfBrowse
        '
        Me.btnfBrowse.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnfBrowse.FlatAppearance.BorderSize = 0
        Me.btnfBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnfBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnfBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfBrowse.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfBrowse.Location = New System.Drawing.Point(499, 3)
        Me.btnfBrowse.Name = "btnfBrowse"
        Me.btnfBrowse.Size = New System.Drawing.Size(80, 29)
        Me.btnfBrowse.TabIndex = 21
        Me.btnfBrowse.Text = "BROWSE"
        Me.btnfBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnfBrowse.UseVisualStyleBackColor = True
        '
        'btnfSave
        '
        Me.btnfSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnfSave.FlatAppearance.BorderSize = 0
        Me.btnfSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnfSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnfSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfSave.Location = New System.Drawing.Point(579, 3)
        Me.btnfSave.Name = "btnfSave"
        Me.btnfSave.Size = New System.Drawing.Size(80, 29)
        Me.btnfSave.TabIndex = 20
        Me.btnfSave.Text = "SAVE"
        Me.btnfSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnfSave.UseVisualStyleBackColor = True
        '
        'lblFiles
        '
        Me.lblFiles.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblFiles.Location = New System.Drawing.Point(367, 10)
        Me.lblFiles.Name = "lblFiles"
        Me.lblFiles.Size = New System.Drawing.Size(90, 15)
        Me.lblFiles.TabIndex = 19
        Me.lblFiles.Text = "1000px x 1000px"
        '
        'tboPath
        '
        Me.tboPath.BackColor = System.Drawing.Color.White
        Me.tboPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboPath.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tboPath.Location = New System.Drawing.Point(77, 6)
        Me.tboPath.MaxLength = 10
        Me.tboPath.Name = "tboPath"
        Me.tboPath.ReadOnly = True
        Me.tboPath.Size = New System.Drawing.Size(287, 22)
        Me.tboPath.TabIndex = 5
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblPath.Location = New System.Drawing.Point(6, 10)
        Me.lblPath.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(69, 14)
        Me.lblPath.TabIndex = 4
        Me.lblPath.Text = "Folder Path"
        '
        'lboFilenames
        '
        Me.lboFilenames.FormattingEnabled = True
        Me.lboFilenames.ItemHeight = 14
        Me.lboFilenames.Location = New System.Drawing.Point(157, -67)
        Me.lboFilenames.Name = "lboFilenames"
        Me.lboFilenames.Size = New System.Drawing.Size(342, 158)
        Me.lboFilenames.TabIndex = 22
        Me.lboFilenames.Visible = False
        '
        'tlpForm
        '
        Me.tlpForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
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
        Me.tlpForm.Size = New System.Drawing.Size(674, 522)
        Me.tlpForm.TabIndex = 8
        '
        'pTitle
        '
        Me.pTitle.Controls.Add(Me.lblTitle)
        Me.pTitle.Controls.Add(Me.pExit)
        Me.pTitle.Location = New System.Drawing.Point(2, 0)
        Me.pTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.pTitle.Name = "pTitle"
        Me.pTitle.Size = New System.Drawing.Size(670, 30)
        Me.pTitle.TabIndex = 36
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(640, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Manajemen Icon"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pExit
        '
        Me.pExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.pExit.Image = Global.dizUI.My.Resources.Resources.exit_w
        Me.pExit.Location = New System.Drawing.Point(640, 0)
        Me.pExit.Margin = New System.Windows.Forms.Padding(0)
        Me.pExit.Name = "pExit"
        Me.pExit.Size = New System.Drawing.Size(30, 30)
        Me.pExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pExit.TabIndex = 10
        Me.pExit.TabStop = False
        '
        'pBody
        '
        Me.pBody.Controls.Add(Me.gcData)
        Me.pBody.Controls.Add(Me.tcControl)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(670, 490)
        Me.pBody.TabIndex = 7
        '
        'gcData
        '
        Me.gcData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcData.Location = New System.Drawing.Point(0, 30)
        Me.gcData.MainView = Me.lvImages
        Me.gcData.Name = "gcData"
        Me.gcData.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.peImages})
        Me.gcData.Size = New System.Drawing.Size(670, 395)
        Me.gcData.TabIndex = 8
        Me.gcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.lvImages})
        '
        'lvImages
        '
        Me.lvImages.Appearance.ViewBackground.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.lvImages.Appearance.ViewBackground.Options.UseBackColor = True
        Me.lvImages.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.lvImages.CardMinSize = New System.Drawing.Size(200, 40)
        Me.lvImages.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() {Me.lvcImages, Me.lvcID, Me.lvcDateTime, Me.lvcSize, Me.lvcFilename})
        Me.lvImages.GridControl = Me.gcData
        Me.lvImages.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_LayoutViewColumn1_3})
        Me.lvImages.Name = "lvImages"
        Me.lvImages.OptionsBehavior.AllowRuntimeCustomization = False
        Me.lvImages.OptionsBehavior.Editable = False
        Me.lvImages.OptionsBehavior.ReadOnly = True
        Me.lvImages.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
        Me.lvImages.TemplateCard = Me.LayoutViewCard1
        '
        'lvcImages
        '
        Me.lvcImages.Caption = "Images"
        Me.lvcImages.ColumnEdit = Me.peImages
        Me.lvcImages.FieldName = "imagesicon"
        Me.lvcImages.LayoutViewField = Me.layoutViewField_LayoutViewColumn1_1
        Me.lvcImages.Name = "lvcImages"
        Me.lvcImages.OptionsColumn.AllowEdit = False
        Me.lvcImages.OptionsColumn.ReadOnly = True
        Me.lvcImages.OptionsColumn.ShowCaption = False
        '
        'peImages
        '
        Me.peImages.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.peImages.Name = "peImages"
        Me.peImages.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.peImages.ReadOnly = True
        Me.peImages.ShowMenu = False
        '
        'layoutViewField_LayoutViewColumn1_1
        '
        Me.layoutViewField_LayoutViewColumn1_1.EditorPreferredWidth = 40
        Me.layoutViewField_LayoutViewColumn1_1.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_LayoutViewColumn1_1.Name = "layoutViewField_LayoutViewColumn1_1"
        Me.layoutViewField_LayoutViewColumn1_1.Size = New System.Drawing.Size(118, 40)
        Me.layoutViewField_LayoutViewColumn1_1.TextSize = New System.Drawing.Size(52, 13)
        '
        'lvcID
        '
        Me.lvcID.Caption = "ID"
        Me.lvcID.FieldName = "idiconmenu"
        Me.lvcID.LayoutViewField = Me.layoutViewField_LayoutViewColumn1
        Me.lvcID.Name = "lvcID"
        Me.lvcID.OptionsColumn.AllowEdit = False
        Me.lvcID.OptionsColumn.ReadOnly = True
        '
        'layoutViewField_LayoutViewColumn1
        '
        Me.layoutViewField_LayoutViewColumn1.EditorPreferredWidth = 10
        Me.layoutViewField_LayoutViewColumn1.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_LayoutViewColumn1.Name = "layoutViewField_LayoutViewColumn1"
        Me.layoutViewField_LayoutViewColumn1.Size = New System.Drawing.Size(57, 20)
        Me.layoutViewField_LayoutViewColumn1.TextSize = New System.Drawing.Size(0, 20)
        '
        'lvcDateTime
        '
        Me.lvcDateTime.Caption = "Date Time"
        Me.lvcDateTime.FieldName = "datetime"
        Me.lvcDateTime.LayoutViewField = Me.layoutViewField_LayoutViewColumn1_2
        Me.lvcDateTime.Name = "lvcDateTime"
        Me.lvcDateTime.OptionsColumn.AllowEdit = False
        Me.lvcDateTime.OptionsColumn.ReadOnly = True
        '
        'layoutViewField_LayoutViewColumn1_2
        '
        Me.layoutViewField_LayoutViewColumn1_2.EditorPreferredWidth = 10
        Me.layoutViewField_LayoutViewColumn1_2.Location = New System.Drawing.Point(0, 24)
        Me.layoutViewField_LayoutViewColumn1_2.Name = "layoutViewField_LayoutViewColumn1_2"
        Me.layoutViewField_LayoutViewColumn1_2.Size = New System.Drawing.Size(118, 20)
        Me.layoutViewField_LayoutViewColumn1_2.TextSize = New System.Drawing.Size(52, 13)
        '
        'lvcSize
        '
        Me.lvcSize.Caption = "Size"
        Me.lvcSize.FieldName = "size"
        Me.lvcSize.LayoutViewField = Me.layoutViewField_LayoutViewColumn2
        Me.lvcSize.Name = "lvcSize"
        Me.lvcSize.OptionsColumn.AllowEdit = False
        Me.lvcSize.OptionsColumn.ReadOnly = True
        '
        'layoutViewField_LayoutViewColumn2
        '
        Me.layoutViewField_LayoutViewColumn2.EditorPreferredWidth = 10
        Me.layoutViewField_LayoutViewColumn2.Location = New System.Drawing.Point(0, 44)
        Me.layoutViewField_LayoutViewColumn2.Name = "layoutViewField_LayoutViewColumn2"
        Me.layoutViewField_LayoutViewColumn2.Size = New System.Drawing.Size(118, 40)
        Me.layoutViewField_LayoutViewColumn2.TextSize = New System.Drawing.Size(52, 13)
        '
        'lvcFilename
        '
        Me.lvcFilename.Caption = "Filename"
        Me.lvcFilename.FieldName = "filename"
        Me.lvcFilename.LayoutViewField = Me.layoutViewField_LayoutViewColumn1_3
        Me.lvcFilename.Name = "lvcFilename"
        Me.lvcFilename.OptionsColumn.AllowEdit = False
        Me.lvcFilename.OptionsColumn.ReadOnly = True
        '
        'layoutViewField_LayoutViewColumn1_3
        '
        Me.layoutViewField_LayoutViewColumn1_3.EditorPreferredWidth = 10
        Me.layoutViewField_LayoutViewColumn1_3.Location = New System.Drawing.Point(0, 64)
        Me.layoutViewField_LayoutViewColumn1_3.Name = "layoutViewField_LayoutViewColumn1_3"
        Me.layoutViewField_LayoutViewColumn1_3.Size = New System.Drawing.Size(118, 20)
        Me.layoutViewField_LayoutViewColumn1_3.TextSize = New System.Drawing.Size(52, 20)
        '
        'LayoutViewCard1
        '
        Me.LayoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_LayoutViewColumn1_1, Me.layoutViewField_LayoutViewColumn1_2, Me.layoutViewField_LayoutViewColumn2})
        Me.LayoutViewCard1.Name = "LayoutViewCard1"
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.ForeColor = System.Drawing.Color.White
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(670, 30)
        Me.pHeader.TabIndex = 4
        '
        'frmIconManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.ClientSize = New System.Drawing.Size(674, 522)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmIconManager"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manajemen Icon"
        Me.tcControl.ResumeLayout(False)
        Me.tpInfo.ResumeLayout(False)
        Me.tpInfo.PerformLayout()
        Me.tpNew.ResumeLayout(False)
        Me.tpNew.PerformLayout()
        Me.tpFolder.ResumeLayout(False)
        Me.tpFolder.PerformLayout()
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lvImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.peImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn1_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn1_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn1_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tboFilename As System.Windows.Forms.TextBox
    Friend WithEvents lblFilename As System.Windows.Forms.Label
    Friend WithEvents tboDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents tcControl As System.Windows.Forms.TabControl
    Friend WithEvents tpNew As System.Windows.Forms.TabPage
    Friend WithEvents tpInfo As System.Windows.Forms.TabPage
    Public WithEvents btnnBrowse As System.Windows.Forms.Button
    Public WithEvents btnnSave As System.Windows.Forms.Button
    Friend WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pBody As System.Windows.Forms.Panel
    Friend WithEvents pHeader As System.Windows.Forms.Panel
    Friend WithEvents lblSize As System.Windows.Forms.Label
    Friend WithEvents gcData As DevExpress.XtraGrid.GridControl
    Friend WithEvents lvImages As DevExpress.XtraGrid.Views.Layout.LayoutView
    Friend WithEvents lvcID As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_LayoutViewColumn1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents lvcImages As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_LayoutViewColumn1_1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
    Friend WithEvents peImages As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents tpFolder As System.Windows.Forms.TabPage
    Friend WithEvents lblPath As System.Windows.Forms.Label
    Friend WithEvents lblFiles As System.Windows.Forms.Label
    Friend WithEvents tboPath As System.Windows.Forms.TextBox
    Public WithEvents btnfBrowse As System.Windows.Forms.Button
    Public WithEvents btnfSave As System.Windows.Forms.Button
    Friend WithEvents lbliSize As System.Windows.Forms.Label
    Friend WithEvents lboFilenames As System.Windows.Forms.ListBox
    Friend WithEvents lvcDateTime As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_LayoutViewColumn1_2 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents lvcSize As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_LayoutViewColumn2 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents lvcFilename As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_LayoutViewColumn1_3 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
End Class
