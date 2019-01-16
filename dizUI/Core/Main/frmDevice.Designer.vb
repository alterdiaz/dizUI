<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDevice
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tlpForm = New System.Windows.Forms.TableLayoutPanel()
        Me.pBody = New System.Windows.Forms.Panel()
        Me.gcData = New DevExpress.XtraGrid.GridControl()
        Me.gvData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rimeNote = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.tlpTop = New System.Windows.Forms.TableLayoutPanel()
        Me.tboShare = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tboDevice = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tboIPAddress = New DevExpress.XtraEditors.TextEdit()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lueJenisDevice = New DevExpress.XtraEditors.LookUpEdit()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tlpForm.SuspendLayout()
        Me.pBody.SuspendLayout()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rimeNote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpTop.SuspendLayout()
        CType(Me.tboShare.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tboDevice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tboIPAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeader.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueJenisDevice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpForm
        '
        Me.tlpForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tlpForm.ColumnCount = 3
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.Controls.Add(Me.pBody, 1, 1)
        Me.tlpForm.Controls.Add(Me.Panel1, 1, 0)
        Me.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpForm.Location = New System.Drawing.Point(0, 0)
        Me.tlpForm.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpForm.Name = "tlpForm"
        Me.tlpForm.RowCount = 3
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.Size = New System.Drawing.Size(719, 360)
        Me.tlpForm.TabIndex = 8
        '
        'pBody
        '
        Me.pBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pBody.Controls.Add(Me.gcData)
        Me.pBody.Controls.Add(Me.tlpTop)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(715, 328)
        Me.pBody.TabIndex = 7
        '
        'gcData
        '
        Me.gcData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcData.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.gcData.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gcData.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.gcData.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gcData.EmbeddedNavigator.Buttons.First.Visible = False
        Me.gcData.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.gcData.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.gcData.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.gcData.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.gcData.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.gcData.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(0)
        Me.gcData.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.None
        Me.gcData.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gcData.Location = New System.Drawing.Point(0, 138)
        Me.gcData.MainView = Me.gvData
        Me.gcData.Name = "gcData"
        Me.gcData.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rimeNote})
        Me.gcData.Size = New System.Drawing.Size(715, 190)
        Me.gcData.TabIndex = 14
        Me.gcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvData})
        '
        'gvData
        '
        Me.gvData.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gvData.Appearance.Empty.Options.UseBackColor = True
        Me.gvData.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvData.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gvData.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvData.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.OddRow.Options.UseBackColor = True
        Me.gvData.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gvData.Appearance.Row.Options.UseFont = True
        Me.gvData.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.TopNewRow.Options.UseBackColor = True
        Me.gvData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn6, Me.GridColumn5, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.gvData.GridControl = Me.gcData
        Me.gvData.Name = "gvData"
        Me.gvData.NewItemRowText = "Tambah Data Disini"
        Me.gvData.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
        Me.gvData.OptionsView.ColumnAutoWidth = False
        Me.gvData.OptionsView.EnableAppearanceEvenRow = True
        Me.gvData.OptionsView.EnableAppearanceOddRow = True
        Me.gvData.OptionsView.RowAutoHeight = True
        Me.gvData.OptionsView.ShowGroupPanel = False
        Me.gvData.OptionsView.ShowViewCaption = True
        Me.gvData.ViewCaption = " "
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "ID"
        Me.GridColumn1.FieldName = "iddevice"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Nama Device"
        Me.GridColumn2.FieldName = "device"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 163
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "IP Address"
        Me.GridColumn3.FieldName = "ipaddress"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 100
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Nama Share"
        Me.GridColumn4.FieldName = "sharename"
        Me.GridColumn4.MinWidth = 160
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 160
        '
        'rimeNote
        '
        Me.rimeNote.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rimeNote.Name = "rimeNote"
        Me.rimeNote.ReadOnly = True
        Me.rimeNote.ScrollBars = System.Windows.Forms.ScrollBars.None
        '
        'tlpTop
        '
        Me.tlpTop.AutoSize = True
        Me.tlpTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpTop.ColumnCount = 4
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTop.Controls.Add(Me.lueJenisDevice, 2, 4)
        Me.tlpTop.Controls.Add(Me.Label3, 1, 4)
        Me.tlpTop.Controls.Add(Me.tboShare, 2, 3)
        Me.tlpTop.Controls.Add(Me.Label2, 1, 3)
        Me.tlpTop.Controls.Add(Me.tboDevice, 2, 1)
        Me.tlpTop.Controls.Add(Me.Label1, 1, 1)
        Me.tlpTop.Controls.Add(Me.tboIPAddress, 2, 2)
        Me.tlpTop.Controls.Add(Me.lblLevel, 1, 2)
        Me.tlpTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpTop.Location = New System.Drawing.Point(0, 30)
        Me.tlpTop.Name = "tlpTop"
        Me.tlpTop.RowCount = 6
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpTop.Size = New System.Drawing.Size(715, 108)
        Me.tlpTop.TabIndex = 5
        '
        'tboShare
        '
        Me.tboShare.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tboShare.Location = New System.Drawing.Point(282, 56)
        Me.tboShare.Margin = New System.Windows.Forms.Padding(0)
        Me.tboShare.Name = "tboShare"
        Me.tboShare.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.tboShare.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tboShare.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tboShare.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.tboShare.Properties.Appearance.Options.UseBackColor = True
        Me.tboShare.Properties.Appearance.Options.UseFont = True
        Me.tboShare.Properties.Appearance.Options.UseForeColor = True
        Me.tboShare.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tboShare.Properties.MaxLength = 20
        Me.tboShare.Properties.NullText = "[Kosong]"
        Me.tboShare.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.tboShare.Size = New System.Drawing.Size(250, 20)
        Me.tboShare.TabIndex = 38
        Me.tboShare.Tag = "sharename"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(207, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 14)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Nama Share"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tboDevice
        '
        Me.tboDevice.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tboDevice.Location = New System.Drawing.Point(282, 8)
        Me.tboDevice.Margin = New System.Windows.Forms.Padding(0)
        Me.tboDevice.Name = "tboDevice"
        Me.tboDevice.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.tboDevice.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tboDevice.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tboDevice.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.tboDevice.Properties.Appearance.Options.UseBackColor = True
        Me.tboDevice.Properties.Appearance.Options.UseFont = True
        Me.tboDevice.Properties.Appearance.Options.UseForeColor = True
        Me.tboDevice.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tboDevice.Properties.MaxLength = 50
        Me.tboDevice.Properties.NullText = "[Kosong]"
        Me.tboDevice.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.tboDevice.Size = New System.Drawing.Size(187, 20)
        Me.tboDevice.TabIndex = 38
        Me.tboDevice.Tag = "device"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(202, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 14)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Nama Device"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tboIPAddress
        '
        Me.tboIPAddress.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tboIPAddress.Location = New System.Drawing.Point(282, 32)
        Me.tboIPAddress.Margin = New System.Windows.Forms.Padding(0)
        Me.tboIPAddress.Name = "tboIPAddress"
        Me.tboIPAddress.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.tboIPAddress.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tboIPAddress.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tboIPAddress.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.tboIPAddress.Properties.Appearance.Options.UseBackColor = True
        Me.tboIPAddress.Properties.Appearance.Options.UseFont = True
        Me.tboIPAddress.Properties.Appearance.Options.UseForeColor = True
        Me.tboIPAddress.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tboIPAddress.Properties.MaxLength = 20
        Me.tboIPAddress.Properties.NullText = "[Kosong]"
        Me.tboIPAddress.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.tboIPAddress.Size = New System.Drawing.Size(187, 20)
        Me.tboIPAddress.TabIndex = 37
        Me.tboIPAddress.Tag = "ipaddress"
        '
        'lblLevel
        '
        Me.lblLevel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblLevel.AutoSize = True
        Me.lblLevel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.Location = New System.Drawing.Point(214, 35)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(65, 14)
        Me.lblLevel.TabIndex = 32
        Me.lblLevel.Text = "IP Address"
        Me.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Controls.Add(Me.btnNew)
        Me.pHeader.Controls.Add(Me.btnSave)
        Me.pHeader.Controls.Add(Me.btnDelete)
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.ForeColor = System.Drawing.Color.White
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(715, 30)
        Me.pHeader.TabIndex = 4
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnNew.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnNew.FlatAppearance.BorderSize = 0
        Me.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(455, 0)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(80, 30)
        Me.btnNew.TabIndex = 21
        Me.btnNew.Text = "BARU"
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Green
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(535, 0)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 30)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "SIMPAN"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Maroon
        Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(635, 0)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 30)
        Me.btnDelete.TabIndex = 20
        Me.btnDelete.Text = "HAPUS"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Controls.Add(Me.pExit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(2, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(715, 30)
        Me.Panel1.TabIndex = 8
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(685, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Daftar Device"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pExit
        '
        Me.pExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.pExit.Image = Global.dizUI.My.Resources.Resources.exit_w
        Me.pExit.Location = New System.Drawing.Point(685, 0)
        Me.pExit.Margin = New System.Windows.Forms.Padding(0)
        Me.pExit.Name = "pExit"
        Me.pExit.Size = New System.Drawing.Size(30, 30)
        Me.pExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pExit.TabIndex = 12
        Me.pExit.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(206, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 14)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Jenis Device"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueJenisDevice
        '
        Me.lueJenisDevice.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueJenisDevice.Location = New System.Drawing.Point(282, 80)
        Me.lueJenisDevice.Margin = New System.Windows.Forms.Padding(0)
        Me.lueJenisDevice.Name = "lueJenisDevice"
        Me.lueJenisDevice.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueJenisDevice.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueJenisDevice.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueJenisDevice.Properties.Appearance.Options.UseBackColor = True
        Me.lueJenisDevice.Properties.Appearance.Options.UseFont = True
        Me.lueJenisDevice.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueJenisDevice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueJenisDevice.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueJenisDevice.Properties.NullText = "[Isian belum dipilih]"
        Me.lueJenisDevice.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueJenisDevice.Size = New System.Drawing.Size(150, 20)
        Me.lueJenisDevice.TabIndex = 49
        Me.lueJenisDevice.Tag = "idlokasi"
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Jenis Device"
        Me.GridColumn5.FieldName = "jenisdevice"
        Me.GridColumn5.MinWidth = 100
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        Me.GridColumn5.Width = 123
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "GridColumn6"
        Me.GridColumn6.FieldName = "devicetype"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'frmDevice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(719, 360)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDevice"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daftar Komputer Klien"
        Me.tlpForm.ResumeLayout(False)
        Me.pBody.ResumeLayout(False)
        Me.pBody.PerformLayout()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rimeNote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpTop.ResumeLayout(False)
        Me.tlpTop.PerformLayout()
        CType(Me.tboShare.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tboDevice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tboIPAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueJenisDevice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pBody As System.Windows.Forms.Panel
    Friend WithEvents pHeader As System.Windows.Forms.Panel
    Friend WithEvents tlpTop As System.Windows.Forms.TableLayoutPanel
    Public WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblLevel As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Friend WithEvents tboIPAddress As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents tboDevice As DevExpress.XtraEditors.TextEdit
    Public WithEvents gcData As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rimeNote As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Public WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tboShare As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lueJenisDevice As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
End Class
