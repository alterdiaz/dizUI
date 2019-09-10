<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmItemPriceKelas
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
        Me.pTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pMinimize = New System.Windows.Forms.PictureBox()
        Me.pMaximize = New System.Windows.Forms.PictureBox()
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.pBody = New System.Windows.Forms.Panel()
        Me.sccForm = New DevExpress.XtraEditors.SplitContainerControl()
        Me.gcData = New DevExpress.XtraGrid.GridControl()
        Me.gvData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcidunit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gciditem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcKode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcNama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcunit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcHargaTmp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDeleteAllItem = New System.Windows.Forms.Button()
        Me.btnDeleteItem = New System.Windows.Forms.Button()
        Me.tlpField = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lueUnit = New DevExpress.XtraEditors.LookUpEdit()
        Me.deTanggalStart = New DevExpress.XtraEditors.DateEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.deTanggalEnd = New DevExpress.XtraEditors.DateEdit()
        Me.pRightBar = New System.Windows.Forms.Panel()
        Me.xtcItem = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpItem = New DevExpress.XtraTab.XtraTabPage()
        Me.gcItem = New DevExpress.XtraGrid.GridControl()
        Me.gvItem = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gclID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gclItem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gclCek = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ceCek = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.pItem = New System.Windows.Forms.Panel()
        Me.btnAllItem = New System.Windows.Forms.Button()
        Me.btnItemSelect = New System.Windows.Forms.Button()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnImportFormat = New System.Windows.Forms.Button()
        Me.btnExportFormat = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblSep5 = New System.Windows.Forms.Label()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBody.SuspendLayout()
        CType(Me.sccForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sccForm.SuspendLayout()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.tlpField.SuspendLayout()
        CType(Me.lueUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggalStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggalStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggalEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggalEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pRightBar.SuspendLayout()
        CType(Me.xtcItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcItem.SuspendLayout()
        Me.xtpItem.SuspendLayout()
        CType(Me.gcItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceCek, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pItem.SuspendLayout()
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
        Me.tlpForm.Size = New System.Drawing.Size(904, 462)
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
        Me.pTitle.Size = New System.Drawing.Size(900, 30)
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
        Me.lblTitle.Size = New System.Drawing.Size(810, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Item Harga"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pMinimize
        '
        Me.pMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.pMinimize.Image = Global.dizUI.My.Resources.Resources.min_w
        Me.pMinimize.Location = New System.Drawing.Point(810, 0)
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
        Me.pMaximize.Location = New System.Drawing.Point(840, 0)
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
        Me.pExit.Location = New System.Drawing.Point(870, 0)
        Me.pExit.Margin = New System.Windows.Forms.Padding(0)
        Me.pExit.Name = "pExit"
        Me.pExit.Size = New System.Drawing.Size(30, 30)
        Me.pExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pExit.TabIndex = 9
        Me.pExit.TabStop = False
        '
        'pBody
        '
        Me.pBody.Controls.Add(Me.sccForm)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(900, 432)
        Me.pBody.TabIndex = 7
        '
        'sccForm
        '
        Me.sccForm.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.sccForm.Appearance.Options.UseBackColor = True
        Me.sccForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sccForm.Location = New System.Drawing.Point(0, 30)
        Me.sccForm.Margin = New System.Windows.Forms.Padding(0)
        Me.sccForm.Name = "sccForm"
        Me.sccForm.Panel1.Controls.Add(Me.gcData)
        Me.sccForm.Panel1.Controls.Add(Me.Panel1)
        Me.sccForm.Panel1.Controls.Add(Me.tlpField)
        Me.sccForm.Panel1.MinSize = 520
        Me.sccForm.Panel1.Text = "Panel1"
        Me.sccForm.Panel2.Controls.Add(Me.pRightBar)
        Me.sccForm.Panel2.MinSize = 270
        Me.sccForm.Panel2.Text = "Panel2"
        Me.sccForm.Size = New System.Drawing.Size(900, 402)
        Me.sccForm.SplitterPosition = 625
        Me.sccForm.TabIndex = 15
        Me.sccForm.Text = "SplitContainerControl1"
        '
        'gcData
        '
        Me.gcData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcData.Location = New System.Drawing.Point(0, 60)
        Me.gcData.MainView = Me.gvData
        Me.gcData.Name = "gcData"
        Me.gcData.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSpinEdit1})
        Me.gcData.Size = New System.Drawing.Size(625, 312)
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
        Me.gvData.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.Row.Options.UseBackColor = True
        Me.gvData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcidunit, Me.gciditem, Me.GridColumn2, Me.GridColumn1, Me.gcKode, Me.gcNama, Me.gcunit, Me.gcHargaTmp})
        Me.gvData.GridControl = Me.gcData
        Me.gvData.Name = "gvData"
        Me.gvData.OptionsView.ColumnAutoWidth = False
        Me.gvData.OptionsView.EnableAppearanceEvenRow = True
        Me.gvData.OptionsView.EnableAppearanceOddRow = True
        Me.gvData.OptionsView.ShowGroupPanel = False
        '
        'gcidunit
        '
        Me.gcidunit.Caption = "itemtype"
        Me.gcidunit.FieldName = "itemtype"
        Me.gcidunit.Name = "gcidunit"
        '
        'gciditem
        '
        Me.gciditem.Caption = "gciditem"
        Me.gciditem.FieldName = "iditem"
        Me.gciditem.Name = "gciditem"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "iditemgrup"
        Me.GridColumn2.FieldName = "iditemgrup"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Grup"
        Me.GridColumn1.FieldName = "itemgrup"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
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
        Me.gcNama.FieldName = "item"
        Me.gcNama.Name = "gcNama"
        Me.gcNama.OptionsColumn.AllowEdit = False
        Me.gcNama.OptionsColumn.ReadOnly = True
        Me.gcNama.Visible = True
        Me.gcNama.VisibleIndex = 3
        '
        'gcunit
        '
        Me.gcunit.AppearanceHeader.Options.UseTextOptions = True
        Me.gcunit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcunit.Caption = "Jenis"
        Me.gcunit.FieldName = "type"
        Me.gcunit.Name = "gcunit"
        Me.gcunit.OptionsColumn.AllowEdit = False
        Me.gcunit.OptionsColumn.ReadOnly = True
        Me.gcunit.Visible = True
        Me.gcunit.VisibleIndex = 0
        '
        'gcHargaTmp
        '
        Me.gcHargaTmp.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gcHargaTmp.AppearanceCell.Options.UseBackColor = True
        Me.gcHargaTmp.AppearanceHeader.Options.UseTextOptions = True
        Me.gcHargaTmp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcHargaTmp.Caption = "Harga"
        Me.gcHargaTmp.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.gcHargaTmp.FieldName = "harga"
        Me.gcHargaTmp.Name = "gcHargaTmp"
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit1.DisplayFormat.FormatString = "n2"
        Me.RepositoryItemSpinEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemSpinEdit1.EditFormat.FormatString = "n2"
        Me.RepositoryItemSpinEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemSpinEdit1.IsFloatValue = False
        Me.RepositoryItemSpinEdit1.Mask.EditMask = "N00"
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnDeleteAllItem)
        Me.Panel1.Controls.Add(Me.btnDeleteItem)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 372)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(625, 30)
        Me.Panel1.TabIndex = 13
        '
        'btnDeleteAllItem
        '
        Me.btnDeleteAllItem.BackColor = System.Drawing.Color.Maroon
        Me.btnDeleteAllItem.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDeleteAllItem.FlatAppearance.BorderSize = 0
        Me.btnDeleteAllItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnDeleteAllItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnDeleteAllItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteAllItem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteAllItem.Location = New System.Drawing.Point(0, 0)
        Me.btnDeleteAllItem.Name = "btnDeleteAllItem"
        Me.btnDeleteAllItem.Size = New System.Drawing.Size(120, 30)
        Me.btnDeleteAllItem.TabIndex = 16
        Me.btnDeleteAllItem.Text = "HAPUS ALL ITEM"
        Me.btnDeleteAllItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeleteAllItem.UseVisualStyleBackColor = False
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.BackColor = System.Drawing.Color.Maroon
        Me.btnDeleteItem.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDeleteItem.FlatAppearance.BorderSize = 0
        Me.btnDeleteItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnDeleteItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteItem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteItem.Location = New System.Drawing.Point(525, 0)
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.Size = New System.Drawing.Size(100, 30)
        Me.btnDeleteItem.TabIndex = 15
        Me.btnDeleteItem.Text = "HAPUS ITEM"
        Me.btnDeleteItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeleteItem.UseVisualStyleBackColor = False
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
        Me.tlpField.Controls.Add(Me.Label5, 1, 1)
        Me.tlpField.Controls.Add(Me.lueUnit, 2, 1)
        Me.tlpField.Controls.Add(Me.deTanggalStart, 2, 2)
        Me.tlpField.Controls.Add(Me.Label2, 1, 2)
        Me.tlpField.Controls.Add(Me.Label3, 3, 2)
        Me.tlpField.Controls.Add(Me.deTanggalEnd, 4, 2)
        Me.tlpField.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpField.Location = New System.Drawing.Point(0, 0)
        Me.tlpField.Name = "tlpField"
        Me.tlpField.RowCount = 4
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpField.Size = New System.Drawing.Size(625, 60)
        Me.tlpField.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(80, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 14)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Unit"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueUnit
        '
        Me.lueUnit.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueUnit.Location = New System.Drawing.Point(112, 8)
        Me.lueUnit.Margin = New System.Windows.Forms.Padding(0)
        Me.lueUnit.Name = "lueUnit"
        Me.lueUnit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueUnit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueUnit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueUnit.Properties.Appearance.Options.UseBackColor = True
        Me.lueUnit.Properties.Appearance.Options.UseFont = True
        Me.lueUnit.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueUnit.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.lueUnit.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueUnit.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.lueUnit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueUnit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueUnit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueUnit.Properties.NullText = "[Isian belum dipilih]"
        Me.lueUnit.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueUnit.Size = New System.Drawing.Size(200, 20)
        Me.lueUnit.TabIndex = 48
        Me.lueUnit.Tag = "idunit"
        '
        'deTanggalStart
        '
        Me.deTanggalStart.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.deTanggalStart.EditValue = Nothing
        Me.deTanggalStart.Location = New System.Drawing.Point(112, 32)
        Me.deTanggalStart.Margin = New System.Windows.Forms.Padding(0)
        Me.deTanggalStart.Name = "deTanggalStart"
        Me.deTanggalStart.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deTanggalStart.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalStart.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.deTanggalStart.Properties.Appearance.Options.UseBackColor = True
        Me.deTanggalStart.Properties.Appearance.Options.UseFont = True
        Me.deTanggalStart.Properties.Appearance.Options.UseForeColor = True
        Me.deTanggalStart.Properties.AppearanceCalendar.DayCellHighlighted.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalStart.Properties.AppearanceCalendar.DayCellHighlighted.Options.UseFont = True
        Me.deTanggalStart.Properties.AppearanceCalendar.Header.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalStart.Properties.AppearanceCalendar.Header.Options.UseFont = True
        Me.deTanggalStart.Properties.AppearanceCalendar.HeaderHighlighted.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalStart.Properties.AppearanceCalendar.HeaderHighlighted.Options.UseFont = True
        Me.deTanggalStart.Properties.AppearanceCalendar.WeekNumber.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalStart.Properties.AppearanceCalendar.WeekNumber.Options.UseFont = True
        Me.deTanggalStart.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deTanggalStart.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalStart.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.deTanggalStart.Properties.AppearanceDisabled.Options.UseFont = True
        Me.deTanggalStart.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalStart.Properties.AppearanceDropDown.Options.UseFont = True
        Me.deTanggalStart.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalStart.Properties.AppearanceFocused.Options.UseFont = True
        Me.deTanggalStart.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deTanggalStart.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalStart.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.deTanggalStart.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.deTanggalStart.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.deTanggalStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deTanggalStart.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.[True]
        Me.deTanggalStart.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.deTanggalStart.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic
        Me.deTanggalStart.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.deTanggalStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTanggalStart.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.deTanggalStart.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTanggalStart.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.deTanggalStart.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.deTanggalStart.Size = New System.Drawing.Size(133, 20)
        Me.deTanggalStart.TabIndex = 24
        Me.deTanggalStart.Tag = "startdate"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 14)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Tgl Berlaku"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(338, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 14)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Tgl Berakhir"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'deTanggalEnd
        '
        Me.deTanggalEnd.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.deTanggalEnd.EditValue = Nothing
        Me.deTanggalEnd.Location = New System.Drawing.Point(412, 32)
        Me.deTanggalEnd.Margin = New System.Windows.Forms.Padding(0)
        Me.deTanggalEnd.Name = "deTanggalEnd"
        Me.deTanggalEnd.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deTanggalEnd.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalEnd.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.deTanggalEnd.Properties.Appearance.Options.UseBackColor = True
        Me.deTanggalEnd.Properties.Appearance.Options.UseFont = True
        Me.deTanggalEnd.Properties.Appearance.Options.UseForeColor = True
        Me.deTanggalEnd.Properties.AppearanceCalendar.DayCellHighlighted.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalEnd.Properties.AppearanceCalendar.DayCellHighlighted.Options.UseFont = True
        Me.deTanggalEnd.Properties.AppearanceCalendar.Header.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalEnd.Properties.AppearanceCalendar.Header.Options.UseFont = True
        Me.deTanggalEnd.Properties.AppearanceCalendar.HeaderHighlighted.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalEnd.Properties.AppearanceCalendar.HeaderHighlighted.Options.UseFont = True
        Me.deTanggalEnd.Properties.AppearanceCalendar.WeekNumber.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalEnd.Properties.AppearanceCalendar.WeekNumber.Options.UseFont = True
        Me.deTanggalEnd.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deTanggalEnd.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalEnd.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.deTanggalEnd.Properties.AppearanceDisabled.Options.UseFont = True
        Me.deTanggalEnd.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalEnd.Properties.AppearanceDropDown.Options.UseFont = True
        Me.deTanggalEnd.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalEnd.Properties.AppearanceFocused.Options.UseFont = True
        Me.deTanggalEnd.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deTanggalEnd.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalEnd.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.deTanggalEnd.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.deTanggalEnd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.deTanggalEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deTanggalEnd.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.[True]
        Me.deTanggalEnd.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.deTanggalEnd.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic
        Me.deTanggalEnd.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.deTanggalEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTanggalEnd.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.deTanggalEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTanggalEnd.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.deTanggalEnd.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.deTanggalEnd.Size = New System.Drawing.Size(133, 20)
        Me.deTanggalEnd.TabIndex = 24
        Me.deTanggalEnd.Tag = "enddate"
        '
        'pRightBar
        '
        Me.pRightBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pRightBar.Controls.Add(Me.xtcItem)
        Me.pRightBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pRightBar.Location = New System.Drawing.Point(0, 0)
        Me.pRightBar.Margin = New System.Windows.Forms.Padding(0)
        Me.pRightBar.Name = "pRightBar"
        Me.pRightBar.Size = New System.Drawing.Size(270, 402)
        Me.pRightBar.TabIndex = 9
        '
        'xtcItem
        '
        Me.xtcItem.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.xtcItem.Appearance.Options.UseBackColor = True
        Me.xtcItem.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.xtcItem.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.xtcItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtcItem.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[True]
        Me.xtcItem.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom
        Me.xtcItem.Location = New System.Drawing.Point(0, 0)
        Me.xtcItem.Margin = New System.Windows.Forms.Padding(0)
        Me.xtcItem.Name = "xtcItem"
        Me.xtcItem.SelectedTabPage = Me.xtpItem
        Me.xtcItem.Size = New System.Drawing.Size(270, 402)
        Me.xtcItem.TabIndex = 11
        Me.xtcItem.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpItem})
        '
        'xtpItem
        '
        Me.xtpItem.Controls.Add(Me.gcItem)
        Me.xtpItem.Controls.Add(Me.pItem)
        Me.xtpItem.Name = "xtpItem"
        Me.xtpItem.Size = New System.Drawing.Size(262, 372)
        Me.xtpItem.Text = "Daftar Item"
        '
        'gcItem
        '
        Me.gcItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcItem.Location = New System.Drawing.Point(0, 0)
        Me.gcItem.MainView = Me.gvItem
        Me.gcItem.Name = "gcItem"
        Me.gcItem.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ceCek})
        Me.gcItem.Size = New System.Drawing.Size(262, 342)
        Me.gcItem.TabIndex = 11
        Me.gcItem.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvItem})
        '
        'gvItem
        '
        Me.gvItem.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gvItem.Appearance.Empty.Options.UseBackColor = True
        Me.gvItem.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvItem.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvItem.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvItem.Appearance.OddRow.Options.UseBackColor = True
        Me.gvItem.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.gvItem.Appearance.Preview.ForeColor = System.Drawing.Color.White
        Me.gvItem.Appearance.Preview.Options.UseBackColor = True
        Me.gvItem.Appearance.Preview.Options.UseForeColor = True
        Me.gvItem.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvItem.Appearance.Row.Options.UseBackColor = True
        Me.gvItem.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gclID, Me.gclItem, Me.gclCek})
        Me.gvItem.GridControl = Me.gcItem
        Me.gvItem.Name = "gvItem"
        Me.gvItem.OptionsFind.AlwaysVisible = True
        Me.gvItem.OptionsFind.FindNullPrompt = "Cari item ketik disini"
        Me.gvItem.OptionsSelection.MultiSelect = True
        Me.gvItem.OptionsView.EnableAppearanceEvenRow = True
        Me.gvItem.OptionsView.EnableAppearanceOddRow = True
        Me.gvItem.OptionsView.ShowGroupPanel = False
        Me.gvItem.OptionsView.ShowIndicator = False
        Me.gvItem.PreviewFieldName = "note"
        '
        'gclID
        '
        Me.gclID.Caption = "ID"
        Me.gclID.FieldName = "iditem"
        Me.gclID.Name = "gclID"
        '
        'gclItem
        '
        Me.gclItem.AppearanceHeader.Options.UseTextOptions = True
        Me.gclItem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gclItem.Caption = "Item"
        Me.gclItem.FieldName = "item"
        Me.gclItem.Name = "gclItem"
        Me.gclItem.OptionsColumn.AllowEdit = False
        Me.gclItem.OptionsColumn.ReadOnly = True
        Me.gclItem.Visible = True
        Me.gclItem.VisibleIndex = 0
        Me.gclItem.Width = 178
        '
        'gclCek
        '
        Me.gclCek.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gclCek.AppearanceCell.Options.UseBackColor = True
        Me.gclCek.AppearanceHeader.Options.UseTextOptions = True
        Me.gclCek.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gclCek.Caption = "Cek"
        Me.gclCek.ColumnEdit = Me.ceCek
        Me.gclCek.FieldName = "cek"
        Me.gclCek.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.gclCek.MaxWidth = 30
        Me.gclCek.MinWidth = 30
        Me.gclCek.Name = "gclCek"
        Me.gclCek.Visible = True
        Me.gclCek.VisibleIndex = 1
        Me.gclCek.Width = 30
        '
        'ceCek
        '
        Me.ceCek.AutoHeight = False
        Me.ceCek.Name = "ceCek"
        '
        'pItem
        '
        Me.pItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pItem.Controls.Add(Me.btnAllItem)
        Me.pItem.Controls.Add(Me.btnItemSelect)
        Me.pItem.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pItem.ForeColor = System.Drawing.Color.White
        Me.pItem.Location = New System.Drawing.Point(0, 342)
        Me.pItem.Margin = New System.Windows.Forms.Padding(0)
        Me.pItem.Name = "pItem"
        Me.pItem.Size = New System.Drawing.Size(262, 30)
        Me.pItem.TabIndex = 12
        '
        'btnAllItem
        '
        Me.btnAllItem.BackColor = System.Drawing.Color.green
        Me.btnAllItem.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAllItem.FlatAppearance.BorderSize = 0
        Me.btnAllItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnAllItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnAllItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAllItem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAllItem.Location = New System.Drawing.Point(0, 0)
        Me.btnAllItem.Name = "btnAllItem"
        Me.btnAllItem.Size = New System.Drawing.Size(100, 30)
        Me.btnAllItem.TabIndex = 16
        Me.btnAllItem.Text = "ALL ITEM"
        Me.btnAllItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAllItem.UseVisualStyleBackColor = False
        '
        'btnItemSelect
        '
        Me.btnItemSelect.BackColor = System.Drawing.Color.green
        Me.btnItemSelect.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnItemSelect.FlatAppearance.BorderSize = 0
        Me.btnItemSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnItemSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnItemSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItemSelect.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItemSelect.Location = New System.Drawing.Point(162, 0)
        Me.btnItemSelect.Name = "btnItemSelect"
        Me.btnItemSelect.Size = New System.Drawing.Size(100, 30)
        Me.btnItemSelect.TabIndex = 15
        Me.btnItemSelect.Text = "PILIH ITEM"
        Me.btnItemSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnItemSelect.UseVisualStyleBackColor = False
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Controls.Add(Me.btnImportFormat)
        Me.pHeader.Controls.Add(Me.btnExportFormat)
        Me.pHeader.Controls.Add(Me.btnNew)
        Me.pHeader.Controls.Add(Me.btnSave)
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.ForeColor = System.Drawing.Color.White
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(900, 30)
        Me.pHeader.TabIndex = 4
        '
        'btnImportFormat
        '
        Me.btnImportFormat.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnImportFormat.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnImportFormat.FlatAppearance.BorderSize = 0
        Me.btnImportFormat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnImportFormat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnImportFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImportFormat.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportFormat.Location = New System.Drawing.Point(120, 0)
        Me.btnImportFormat.Name = "btnImportFormat"
        Me.btnImportFormat.Size = New System.Drawing.Size(120, 30)
        Me.btnImportFormat.TabIndex = 20
        Me.btnImportFormat.Text = "IMPORT DATA"
        Me.btnImportFormat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImportFormat.UseMnemonic = False
        Me.btnImportFormat.UseVisualStyleBackColor = False
        '
        'btnExportFormat
        '
        Me.btnExportFormat.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExportFormat.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnExportFormat.FlatAppearance.BorderSize = 0
        Me.btnExportFormat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnExportFormat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnExportFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportFormat.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportFormat.Location = New System.Drawing.Point(0, 0)
        Me.btnExportFormat.Name = "btnExportFormat"
        Me.btnExportFormat.Size = New System.Drawing.Size(120, 30)
        Me.btnExportFormat.TabIndex = 19
        Me.btnExportFormat.Text = "EXPORT FORMAT"
        Me.btnExportFormat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExportFormat.UseMnemonic = False
        Me.btnExportFormat.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnNew.FlatAppearance.BorderSize = 0
        Me.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(760, 0)
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
        Me.btnSave.Location = New System.Drawing.Point(820, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "SIMPAN"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
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
        'frmItemPriceKelas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(904, 462)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmItemPriceKelas"
        Me.ShowInTaskbar = False
        Me.Text = "Item Harga"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        CType(Me.sccForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sccForm.ResumeLayout(False)
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.tlpField.ResumeLayout(False)
        Me.tlpField.PerformLayout()
        CType(Me.lueUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggalStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggalStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggalEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggalEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pRightBar.ResumeLayout(False)
        CType(Me.xtcItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcItem.ResumeLayout(False)
        Me.xtpItem.ResumeLayout(False)
        CType(Me.gcItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceCek, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pItem.ResumeLayout(False)
        Me.pHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblSep5 As System.Windows.Forms.Label
    Public WithEvents pHeader As System.Windows.Forms.Panel
    Public WithEvents btnNew As System.Windows.Forms.Button
    Public WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents pBody As System.Windows.Forms.Panel
    Public WithEvents gcData As DevExpress.XtraGrid.GridControl
    Public WithEvents gvData As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents tlpField As System.Windows.Forms.TableLayoutPanel
    Public WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents gcNama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcKode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lueUnit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents gcidunit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gciditem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcunit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcHargaTmp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents deTanggalEnd As DevExpress.XtraEditors.DateEdit
    Friend WithEvents deTanggalStart As DevExpress.XtraEditors.DateEdit
    Friend WithEvents sccForm As DevExpress.XtraEditors.SplitContainerControl
    Public WithEvents Panel1 As Panel
    Public WithEvents btnDeleteAllItem As Button
    Public WithEvents btnDeleteItem As Button
    Friend WithEvents pRightBar As Panel
    Friend WithEvents xtcItem As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpItem As DevExpress.XtraTab.XtraTabPage
    Public WithEvents gcItem As DevExpress.XtraGrid.GridControl
    Public WithEvents gvItem As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gclID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gclItem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gclCek As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ceCek As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Public WithEvents pItem As Panel
    Public WithEvents btnAllItem As Button
    Public WithEvents btnItemSelect As Button
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents btnExportFormat As Button
    Public WithEvents btnImportFormat As Button
End Class
