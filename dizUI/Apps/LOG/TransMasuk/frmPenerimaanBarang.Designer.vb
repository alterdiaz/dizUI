<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPenerimaanBarang
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnDeleteAllItem = New System.Windows.Forms.Button()
        Me.btnDeleteItem = New System.Windows.Forms.Button()
        Me.gcData = New DevExpress.XtraGrid.GridControl()
        Me.gvData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcitemtype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcKode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcNama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.seQty = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcidsatuan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.gcQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sePrice = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.seDiscP = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.seDisc = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rimeMemo = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.seSubtotal = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.tlpField = New System.Windows.Forms.TableLayoutPanel()
        Me.btnLock = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.deTanggal = New DevExpress.XtraEditors.DateEdit()
        Me.teKode = New DevExpress.XtraEditors.TextEdit()
        Me.lblParent = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lueUnit = New DevExpress.XtraEditors.LookUpEdit()
        Me.teNote = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lueSupplier = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.deTanggalTempo = New DevExpress.XtraEditors.DateEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.deTanggalKirim = New DevExpress.XtraEditors.DateEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.xtcItem = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpItem = New DevExpress.XtraTab.XtraTabPage()
        Me.gcItem = New DevExpress.XtraGrid.GridControl()
        Me.gvItem = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gclID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gclItem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gclCek = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ceCek = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.pSearch = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.teSearch = New DevExpress.XtraEditors.TextEdit()
        Me.pItem = New System.Windows.Forms.Panel()
        Me.btnAllItem = New System.Windows.Forms.Button()
        Me.btnItemSelect = New System.Windows.Forms.Button()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnShowHideItem = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
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
        Me.Panel1.SuspendLayout()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sePrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seDiscP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seDisc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rimeMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seSubtotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpField.SuspendLayout()
        CType(Me.deTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teKode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggalTempo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggalTempo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggalKirim.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggalKirim.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xtcItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcItem.SuspendLayout()
        Me.xtpItem.SuspendLayout()
        CType(Me.gcItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceCek, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pSearch.SuspendLayout()
        CType(Me.teSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tlpForm.Size = New System.Drawing.Size(887, 484)
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
        Me.pTitle.Size = New System.Drawing.Size(883, 30)
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
        Me.lblTitle.Size = New System.Drawing.Size(793, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Penerimaan Barang"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pMinimize
        '
        Me.pMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.pMinimize.Image = Global.dizUI.My.Resources.Resources.min_w
        Me.pMinimize.Location = New System.Drawing.Point(793, 0)
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
        Me.pMaximize.Location = New System.Drawing.Point(823, 0)
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
        Me.pExit.Location = New System.Drawing.Point(853, 0)
        Me.pExit.Margin = New System.Windows.Forms.Padding(0)
        Me.pExit.Name = "pExit"
        Me.pExit.Size = New System.Drawing.Size(30, 30)
        Me.pExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pExit.TabIndex = 9
        Me.pExit.TabStop = False
        '
        'pBody
        '
        Me.pBody.Controls.Add(Me.Panel1)
        Me.pBody.Controls.Add(Me.gcData)
        Me.pBody.Controls.Add(Me.tlpField)
        Me.pBody.Controls.Add(Me.xtcItem)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(883, 454)
        Me.pBody.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnAddItem)
        Me.Panel1.Controls.Add(Me.btnDeleteAllItem)
        Me.Panel1.Controls.Add(Me.btnDeleteItem)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 424)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(613, 30)
        Me.Panel1.TabIndex = 14
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.Color.Green
        Me.btnAddItem.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddItem.FlatAppearance.BorderSize = 0
        Me.btnAddItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnAddItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.Location = New System.Drawing.Point(413, 0)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(100, 30)
        Me.btnAddItem.TabIndex = 17
        Me.btnAddItem.Text = "TAMBAH ITEM"
        Me.btnAddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddItem.UseVisualStyleBackColor = False
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
        Me.btnDeleteItem.Location = New System.Drawing.Point(513, 0)
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.Size = New System.Drawing.Size(100, 30)
        Me.btnDeleteItem.TabIndex = 15
        Me.btnDeleteItem.Text = "HAPUS ITEM"
        Me.btnDeleteItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeleteItem.UseVisualStyleBackColor = False
        '
        'gcData
        '
        Me.gcData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcData.Location = New System.Drawing.Point(0, 138)
        Me.gcData.MainView = Me.gvData
        Me.gcData.Name = "gcData"
        Me.gcData.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.seQty, Me.sePrice, Me.seDisc, Me.seDiscP, Me.seSubtotal, Me.rimeMemo, Me.RepositoryItemLookUpEdit1})
        Me.gcData.Size = New System.Drawing.Size(613, 316)
        Me.gcData.TabIndex = 12
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
        Me.gvData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn15, Me.gcID, Me.gcitemtype, Me.gcType, Me.gcKode, Me.gcNama, Me.GridColumn5, Me.GridColumn7, Me.GridColumn9, Me.gcidsatuan, Me.GridColumn8, Me.GridColumn3, Me.GridColumn4, Me.gcQty, Me.GridColumn6, Me.GridColumn2, Me.GridColumn11, Me.GridColumn10, Me.GridColumn12, Me.GridColumn1})
        Me.gvData.GridControl = Me.gcData
        Me.gvData.Name = "gvData"
        Me.gvData.OptionsView.ColumnAutoWidth = False
        Me.gvData.OptionsView.EnableAppearanceEvenRow = True
        Me.gvData.OptionsView.EnableAppearanceOddRow = True
        Me.gvData.OptionsView.ShowFooter = True
        Me.gvData.OptionsView.ShowGroupPanel = False
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "GridColumn15"
        Me.GridColumn15.FieldName = "idtransaksidt"
        Me.GridColumn15.Name = "GridColumn15"
        '
        'gcID
        '
        Me.gcID.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gcID.AppearanceCell.Options.UseBackColor = True
        Me.gcID.Caption = "ID"
        Me.gcID.FieldName = "iditem"
        Me.gcID.Name = "gcID"
        Me.gcID.OptionsColumn.AllowEdit = False
        Me.gcID.OptionsColumn.ReadOnly = True
        '
        'gcitemtype
        '
        Me.gcitemtype.Caption = "itemtype"
        Me.gcitemtype.FieldName = "itemtype"
        Me.gcitemtype.Name = "gcitemtype"
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
        Me.gcKode.VisibleIndex = 1
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
        Me.gcNama.VisibleIndex = 2
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn5.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Isi"
        Me.GridColumn5.ColumnEdit = Me.seQty
        Me.GridColumn5.DisplayFormat.FormatString = "n0"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "qtycontent"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 8
        Me.GridColumn5.Width = 45
        '
        'seQty
        '
        Me.seQty.AutoHeight = False
        Me.seQty.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.seQty.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.seQty.DisplayFormat.FormatString = "n0"
        Me.seQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seQty.EditFormat.FormatString = "n0"
        Me.seQty.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seQty.IsFloatValue = False
        Me.seQty.Mask.EditMask = "N00"
        Me.seQty.MaxLength = 6
        Me.seQty.MaxValue = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.seQty.Name = "seQty"
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.Caption = "Qty PO"
        Me.GridColumn7.ColumnEdit = Me.seQty
        Me.GridColumn7.DisplayFormat.FormatString = "n0"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.FieldName = "qtypo"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 3
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn9.Caption = "Satuan"
        Me.GridColumn9.FieldName = "satuan"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.OptionsColumn.ReadOnly = True
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 5
        Me.GridColumn9.Width = 53
        '
        'gcidsatuan
        '
        Me.gcidsatuan.Caption = "idsatuan"
        Me.gcidsatuan.FieldName = "idsatuan"
        Me.gcidsatuan.Name = "gcidsatuan"
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn8.Caption = "idsatuanpo"
        Me.GridColumn8.FieldName = "idsatuanpo"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn3.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Qty Fakt"
        Me.GridColumn3.ColumnEdit = Me.seQty
        Me.GridColumn3.DisplayFormat.FormatString = "n0"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "qtycharges"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsFilter.AllowFilter = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 6
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn4.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Satuan Fakt"
        Me.GridColumn4.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.GridColumn4.FieldName = "idsatuan2"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 7
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'gcQty
        '
        Me.gcQty.AppearanceHeader.Options.UseTextOptions = True
        Me.gcQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcQty.Caption = "Qty"
        Me.gcQty.ColumnEdit = Me.seQty
        Me.gcQty.DisplayFormat.FormatString = "n0"
        Me.gcQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcQty.FieldName = "qty"
        Me.gcQty.Name = "gcQty"
        Me.gcQty.OptionsColumn.AllowEdit = False
        Me.gcQty.OptionsColumn.ReadOnly = True
        Me.gcQty.Visible = True
        Me.gcQty.VisibleIndex = 4
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Satuan2"
        Me.GridColumn6.FieldName = "satuan2"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn2.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Harga"
        Me.GridColumn2.ColumnEdit = Me.sePrice
        Me.GridColumn2.FieldName = "harga"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 9
        '
        'sePrice
        '
        Me.sePrice.AutoHeight = False
        Me.sePrice.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sePrice.DisplayFormat.FormatString = "n2"
        Me.sePrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sePrice.EditFormat.FormatString = "n2"
        Me.sePrice.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sePrice.IsFloatValue = False
        Me.sePrice.Mask.EditMask = "n2"
        Me.sePrice.Name = "sePrice"
        '
        'GridColumn11
        '
        Me.GridColumn11.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn11.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn11.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn11.Caption = "Disc %"
        Me.GridColumn11.ColumnEdit = Me.seDiscP
        Me.GridColumn11.FieldName = "discpersen"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 10
        '
        'seDiscP
        '
        Me.seDiscP.AutoHeight = False
        Me.seDiscP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.seDiscP.DisplayFormat.FormatString = "n0"
        Me.seDiscP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seDiscP.EditFormat.FormatString = "n0"
        Me.seDiscP.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seDiscP.IsFloatValue = False
        Me.seDiscP.Mask.EditMask = "n0"
        Me.seDiscP.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.seDiscP.Name = "seDiscP"
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn10.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn10.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn10.Caption = "Disc Rp."
        Me.GridColumn10.ColumnEdit = Me.seDisc
        Me.GridColumn10.FieldName = "discamount"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 11
        '
        'seDisc
        '
        Me.seDisc.AutoHeight = False
        Me.seDisc.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.seDisc.DisplayFormat.FormatString = "n2"
        Me.seDisc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seDisc.EditFormat.FormatString = "n2"
        Me.seDisc.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seDisc.IsFloatValue = False
        Me.seDisc.Mask.EditMask = "n2"
        Me.seDisc.Name = "seDisc"
        '
        'GridColumn12
        '
        Me.GridColumn12.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn12.Caption = "Subtotal"
        Me.GridColumn12.DisplayFormat.FormatString = "n2"
        Me.GridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn12.FieldName = "subtotaldisclainppn"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.OptionsColumn.ReadOnly = True
        Me.GridColumn12.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "subtotaldisclainppn", "SUM={0:n2}")})
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 13
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn1.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Keterangan"
        Me.GridColumn1.ColumnEdit = Me.rimeMemo
        Me.GridColumn1.FieldName = "remarks"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 12
        '
        'rimeMemo
        '
        Me.rimeMemo.MaxLength = 200
        Me.rimeMemo.Name = "rimeMemo"
        '
        'seSubtotal
        '
        Me.seSubtotal.AutoHeight = False
        Me.seSubtotal.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.seSubtotal.DisplayFormat.FormatString = "n2"
        Me.seSubtotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seSubtotal.EditFormat.FormatString = "n2"
        Me.seSubtotal.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seSubtotal.Mask.EditMask = "n2"
        Me.seSubtotal.Name = "seSubtotal"
        Me.seSubtotal.ReadOnly = True
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
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.Controls.Add(Me.btnLock, 2, 3)
        Me.tlpField.Controls.Add(Me.Label3, 3, 1)
        Me.tlpField.Controls.Add(Me.deTanggal, 4, 1)
        Me.tlpField.Controls.Add(Me.teKode, 2, 1)
        Me.tlpField.Controls.Add(Me.lblParent, 1, 1)
        Me.tlpField.Controls.Add(Me.Label4, 1, 4)
        Me.tlpField.Controls.Add(Me.lueUnit, 4, 2)
        Me.tlpField.Controls.Add(Me.teNote, 2, 4)
        Me.tlpField.Controls.Add(Me.Label1, 3, 2)
        Me.tlpField.Controls.Add(Me.lueSupplier, 2, 2)
        Me.tlpField.Controls.Add(Me.lblDepartment, 1, 2)
        Me.tlpField.Controls.Add(Me.deTanggalTempo, 4, 4)
        Me.tlpField.Controls.Add(Me.Label5, 3, 4)
        Me.tlpField.Controls.Add(Me.deTanggalKirim, 4, 3)
        Me.tlpField.Controls.Add(Me.Label2, 3, 3)
        Me.tlpField.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpField.Location = New System.Drawing.Point(0, 30)
        Me.tlpField.Name = "tlpField"
        Me.tlpField.RowCount = 6
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpField.Size = New System.Drawing.Size(613, 108)
        Me.tlpField.TabIndex = 7
        '
        'btnLock
        '
        Me.btnLock.BackColor = System.Drawing.Color.Green
        Me.btnLock.FlatAppearance.BorderSize = 0
        Me.btnLock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnLock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLock.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLock.ForeColor = System.Drawing.Color.White
        Me.btnLock.Location = New System.Drawing.Point(135, 54)
        Me.btnLock.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnLock.Name = "btnLock"
        Me.btnLock.Size = New System.Drawing.Size(120, 24)
        Me.btnLock.TabIndex = 20
        Me.btnLock.Text = "LOCK SUPPLIER"
        Me.btnLock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLock.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(378, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 14)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Tanggal"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'deTanggal
        '
        Me.deTanggal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.deTanggal.EditValue = Nothing
        Me.deTanggal.Enabled = False
        Me.deTanggal.Location = New System.Drawing.Point(431, 8)
        Me.deTanggal.Margin = New System.Windows.Forms.Padding(0)
        Me.deTanggal.Name = "deTanggal"
        Me.deTanggal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deTanggal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.deTanggal.Properties.Appearance.Options.UseBackColor = True
        Me.deTanggal.Properties.Appearance.Options.UseFont = True
        Me.deTanggal.Properties.Appearance.Options.UseForeColor = True
        Me.deTanggal.Properties.AppearanceCalendar.DayCellHighlighted.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceCalendar.DayCellHighlighted.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceCalendar.Header.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceCalendar.Header.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceCalendar.HeaderHighlighted.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceCalendar.HeaderHighlighted.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceCalendar.WeekNumber.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceCalendar.WeekNumber.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceDisabled.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceDropDown.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceFocused.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.deTanggal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.deTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deTanggal.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.[True]
        Me.deTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.deTanggal.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista
        Me.deTanggal.Properties.DisplayFormat.FormatString = "dd-MM-yyyy HH:mm:ss"
        Me.deTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTanggal.Properties.EditFormat.FormatString = "dd-MM-yyyy HH:mm:ss"
        Me.deTanggal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTanggal.Properties.Mask.EditMask = "dd-MM-yyyy HH:mm:ss"
        Me.deTanggal.Properties.ReadOnly = True
        Me.deTanggal.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.deTanggal.Size = New System.Drawing.Size(135, 20)
        Me.deTanggal.TabIndex = 33
        Me.deTanggal.Tag = "createddate"
        '
        'teKode
        '
        Me.teKode.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teKode.Enabled = False
        Me.teKode.Location = New System.Drawing.Point(131, 8)
        Me.teKode.Margin = New System.Windows.Forms.Padding(0)
        Me.teKode.Name = "teKode"
        Me.teKode.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teKode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teKode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teKode.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teKode.Properties.Appearance.Options.UseBackColor = True
        Me.teKode.Properties.Appearance.Options.UseFont = True
        Me.teKode.Properties.Appearance.Options.UseForeColor = True
        Me.teKode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teKode.Properties.MaxLength = 300
        Me.teKode.Properties.NullText = "[Belum Diisi]"
        Me.teKode.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teKode.Properties.ReadOnly = True
        Me.teKode.Size = New System.Drawing.Size(190, 20)
        Me.teKode.TabIndex = 18
        Me.teKode.Tag = "kode"
        '
        'lblParent
        '
        Me.lblParent.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblParent.AutoSize = True
        Me.lblParent.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParent.Location = New System.Drawing.Point(85, 11)
        Me.lblParent.Name = "lblParent"
        Me.lblParent.Size = New System.Drawing.Size(43, 14)
        Me.lblParent.TabIndex = 20
        Me.lblParent.Text = "Nomor"
        Me.lblParent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(58, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 14)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Keterangan"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueUnit
        '
        Me.lueUnit.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueUnit.Location = New System.Drawing.Point(431, 32)
        Me.lueUnit.Margin = New System.Windows.Forms.Padding(0)
        Me.lueUnit.Name = "lueUnit"
        Me.lueUnit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueUnit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueUnit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueUnit.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lueUnit.Properties.Appearance.Options.UseBackColor = True
        Me.lueUnit.Properties.Appearance.Options.UseFont = True
        Me.lueUnit.Properties.Appearance.Options.UseForeColor = True
        Me.lueUnit.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueUnit.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.lueUnit.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueUnit.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.lueUnit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueUnit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueUnit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueUnit.Properties.NullText = "[Isian belum dipilih]"
        Me.lueUnit.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueUnit.Size = New System.Drawing.Size(150, 20)
        Me.lueUnit.TabIndex = 48
        Me.lueUnit.Tag = "idunitasal"
        '
        'teNote
        '
        Me.teNote.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNote.Location = New System.Drawing.Point(131, 80)
        Me.teNote.Margin = New System.Windows.Forms.Padding(0)
        Me.teNote.Name = "teNote"
        Me.teNote.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teNote.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNote.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNote.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teNote.Properties.Appearance.Options.UseBackColor = True
        Me.teNote.Properties.Appearance.Options.UseFont = True
        Me.teNote.Properties.Appearance.Options.UseForeColor = True
        Me.teNote.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNote.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teNote.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNote.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teNote.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNote.Properties.MaxLength = 300
        Me.teNote.Properties.NullText = "[Belum Diisi]"
        Me.teNote.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNote.Size = New System.Drawing.Size(150, 20)
        Me.teNote.TabIndex = 20
        Me.teNote.Tag = "remarks"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(399, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 14)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Unit"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueSupplier
        '
        Me.lueSupplier.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueSupplier.Location = New System.Drawing.Point(131, 32)
        Me.lueSupplier.Margin = New System.Windows.Forms.Padding(0)
        Me.lueSupplier.Name = "lueSupplier"
        Me.lueSupplier.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueSupplier.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueSupplier.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueSupplier.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lueSupplier.Properties.Appearance.Options.UseBackColor = True
        Me.lueSupplier.Properties.Appearance.Options.UseFont = True
        Me.lueSupplier.Properties.Appearance.Options.UseForeColor = True
        Me.lueSupplier.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueSupplier.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.lueSupplier.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueSupplier.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.lueSupplier.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueSupplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueSupplier.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueSupplier.Properties.NullText = "[Isian belum dipilih]"
        Me.lueSupplier.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueSupplier.Size = New System.Drawing.Size(200, 20)
        Me.lueSupplier.TabIndex = 48
        Me.lueSupplier.Tag = "idbusinesspartner"
        '
        'lblDepartment
        '
        Me.lblDepartment.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.Location = New System.Drawing.Point(78, 35)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(50, 14)
        Me.lblDepartment.TabIndex = 9
        Me.lblDepartment.Text = "Supplier"
        Me.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'deTanggalTempo
        '
        Me.deTanggalTempo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.deTanggalTempo.EditValue = Nothing
        Me.deTanggalTempo.Location = New System.Drawing.Point(431, 80)
        Me.deTanggalTempo.Margin = New System.Windows.Forms.Padding(0)
        Me.deTanggalTempo.Name = "deTanggalTempo"
        Me.deTanggalTempo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deTanggalTempo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalTempo.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.deTanggalTempo.Properties.Appearance.Options.UseBackColor = True
        Me.deTanggalTempo.Properties.Appearance.Options.UseFont = True
        Me.deTanggalTempo.Properties.Appearance.Options.UseForeColor = True
        Me.deTanggalTempo.Properties.AppearanceCalendar.DayCellHighlighted.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalTempo.Properties.AppearanceCalendar.DayCellHighlighted.Options.UseFont = True
        Me.deTanggalTempo.Properties.AppearanceCalendar.Header.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalTempo.Properties.AppearanceCalendar.Header.Options.UseFont = True
        Me.deTanggalTempo.Properties.AppearanceCalendar.HeaderHighlighted.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalTempo.Properties.AppearanceCalendar.HeaderHighlighted.Options.UseFont = True
        Me.deTanggalTempo.Properties.AppearanceCalendar.WeekNumber.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalTempo.Properties.AppearanceCalendar.WeekNumber.Options.UseFont = True
        Me.deTanggalTempo.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deTanggalTempo.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalTempo.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.deTanggalTempo.Properties.AppearanceDisabled.Options.UseFont = True
        Me.deTanggalTempo.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalTempo.Properties.AppearanceDropDown.Options.UseFont = True
        Me.deTanggalTempo.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalTempo.Properties.AppearanceFocused.Options.UseFont = True
        Me.deTanggalTempo.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deTanggalTempo.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalTempo.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.deTanggalTempo.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.deTanggalTempo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.deTanggalTempo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deTanggalTempo.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.[True]
        Me.deTanggalTempo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.deTanggalTempo.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista
        Me.deTanggalTempo.Properties.DisplayFormat.FormatString = "dd-MM-yyyy HH:mm"
        Me.deTanggalTempo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTanggalTempo.Properties.EditFormat.FormatString = "dd-MM-yyyy HH:mm"
        Me.deTanggalTempo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTanggalTempo.Properties.Mask.EditMask = "dd-MM-yyyy HH:mm"
        Me.deTanggalTempo.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.deTanggalTempo.Size = New System.Drawing.Size(135, 20)
        Me.deTanggalTempo.TabIndex = 38
        Me.deTanggalTempo.Tag = "tempodate"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(348, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 14)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Jatuh Tempo"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'deTanggalKirim
        '
        Me.deTanggalKirim.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.deTanggalKirim.EditValue = Nothing
        Me.deTanggalKirim.Location = New System.Drawing.Point(431, 56)
        Me.deTanggalKirim.Margin = New System.Windows.Forms.Padding(0)
        Me.deTanggalKirim.Name = "deTanggalKirim"
        Me.deTanggalKirim.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deTanggalKirim.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalKirim.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.deTanggalKirim.Properties.Appearance.Options.UseBackColor = True
        Me.deTanggalKirim.Properties.Appearance.Options.UseFont = True
        Me.deTanggalKirim.Properties.Appearance.Options.UseForeColor = True
        Me.deTanggalKirim.Properties.AppearanceCalendar.DayCellHighlighted.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalKirim.Properties.AppearanceCalendar.DayCellHighlighted.Options.UseFont = True
        Me.deTanggalKirim.Properties.AppearanceCalendar.Header.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalKirim.Properties.AppearanceCalendar.Header.Options.UseFont = True
        Me.deTanggalKirim.Properties.AppearanceCalendar.HeaderHighlighted.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalKirim.Properties.AppearanceCalendar.HeaderHighlighted.Options.UseFont = True
        Me.deTanggalKirim.Properties.AppearanceCalendar.WeekNumber.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalKirim.Properties.AppearanceCalendar.WeekNumber.Options.UseFont = True
        Me.deTanggalKirim.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deTanggalKirim.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalKirim.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.deTanggalKirim.Properties.AppearanceDisabled.Options.UseFont = True
        Me.deTanggalKirim.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalKirim.Properties.AppearanceDropDown.Options.UseFont = True
        Me.deTanggalKirim.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalKirim.Properties.AppearanceFocused.Options.UseFont = True
        Me.deTanggalKirim.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deTanggalKirim.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalKirim.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.deTanggalKirim.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.deTanggalKirim.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.deTanggalKirim.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deTanggalKirim.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.[True]
        Me.deTanggalKirim.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.deTanggalKirim.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista
        Me.deTanggalKirim.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.deTanggalKirim.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTanggalKirim.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.deTanggalKirim.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTanggalKirim.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.deTanggalKirim.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.deTanggalKirim.Size = New System.Drawing.Size(135, 20)
        Me.deTanggalKirim.TabIndex = 37
        Me.deTanggalKirim.Tag = "kirimdate"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(337, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 14)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Tanggal Terima"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'xtcItem
        '
        Me.xtcItem.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.xtcItem.Appearance.Options.UseBackColor = True
        Me.xtcItem.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.xtcItem.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.xtcItem.Dock = System.Windows.Forms.DockStyle.Right
        Me.xtcItem.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[True]
        Me.xtcItem.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom
        Me.xtcItem.Location = New System.Drawing.Point(613, 30)
        Me.xtcItem.Margin = New System.Windows.Forms.Padding(0)
        Me.xtcItem.Name = "xtcItem"
        Me.xtcItem.SelectedTabPage = Me.xtpItem
        Me.xtcItem.Size = New System.Drawing.Size(270, 424)
        Me.xtcItem.TabIndex = 11
        Me.xtcItem.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpItem})
        '
        'xtpItem
        '
        Me.xtpItem.Controls.Add(Me.gcItem)
        Me.xtpItem.Controls.Add(Me.pSearch)
        Me.xtpItem.Controls.Add(Me.pItem)
        Me.xtpItem.Name = "xtpItem"
        Me.xtpItem.Size = New System.Drawing.Size(262, 394)
        Me.xtpItem.Text = "Daftar Item"
        '
        'gcItem
        '
        Me.gcItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcItem.Location = New System.Drawing.Point(0, 30)
        Me.gcItem.MainView = Me.gvItem
        Me.gcItem.Name = "gcItem"
        Me.gcItem.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ceCek})
        Me.gcItem.Size = New System.Drawing.Size(262, 334)
        Me.gcItem.TabIndex = 11
        Me.gcItem.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvItem})
        '
        'gvItem
        '
        Me.gvItem.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gvItem.Appearance.Empty.Options.UseBackColor = True
        Me.gvItem.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvItem.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvItem.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
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
        Me.gvItem.OptionsView.ShowPreview = True
        Me.gvItem.PreviewFieldName = "note"
        '
        'gclID
        '
        Me.gclID.Caption = "ID"
        Me.gclID.FieldName = "idtransaksi"
        Me.gclID.Name = "gclID"
        '
        'gclItem
        '
        Me.gclItem.AppearanceHeader.Options.UseTextOptions = True
        Me.gclItem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gclItem.Caption = "Pembelian Barang"
        Me.gclItem.FieldName = "transaksino"
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
        Me.gclCek.Width = 30
        '
        'ceCek
        '
        Me.ceCek.AutoHeight = False
        Me.ceCek.Name = "ceCek"
        '
        'pSearch
        '
        Me.pSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pSearch.Controls.Add(Me.Label6)
        Me.pSearch.Controls.Add(Me.teSearch)
        Me.pSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.pSearch.Location = New System.Drawing.Point(0, 0)
        Me.pSearch.Margin = New System.Windows.Forms.Padding(0)
        Me.pSearch.Name = "pSearch"
        Me.pSearch.Size = New System.Drawing.Size(262, 30)
        Me.pSearch.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 14)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Scan"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teSearch
        '
        Me.teSearch.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.teSearch.EditValue = ""
        Me.teSearch.Location = New System.Drawing.Point(48, 4)
        Me.teSearch.Margin = New System.Windows.Forms.Padding(0)
        Me.teSearch.Name = "teSearch"
        Me.teSearch.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teSearch.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.teSearch.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.teSearch.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teSearch.Properties.Appearance.Options.UseBackColor = True
        Me.teSearch.Properties.Appearance.Options.UseFont = True
        Me.teSearch.Properties.Appearance.Options.UseForeColor = True
        Me.teSearch.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.teSearch.Properties.MaxLength = 50
        Me.teSearch.Properties.NullText = "Pencarian Menu"
        Me.teSearch.Properties.NullValuePrompt = "Pencarian Menu"
        Me.teSearch.Size = New System.Drawing.Size(212, 22)
        Me.teSearch.TabIndex = 22
        Me.teSearch.Tag = ""
        '
        'pItem
        '
        Me.pItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pItem.Controls.Add(Me.btnAllItem)
        Me.pItem.Controls.Add(Me.btnItemSelect)
        Me.pItem.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pItem.ForeColor = System.Drawing.Color.White
        Me.pItem.Location = New System.Drawing.Point(0, 364)
        Me.pItem.Margin = New System.Windows.Forms.Padding(0)
        Me.pItem.Name = "pItem"
        Me.pItem.Size = New System.Drawing.Size(262, 30)
        Me.pItem.TabIndex = 12
        '
        'btnAllItem
        '
        Me.btnAllItem.BackColor = System.Drawing.Color.Green
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
        Me.btnAllItem.Text = "ALL PO"
        Me.btnAllItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAllItem.UseVisualStyleBackColor = False
        Me.btnAllItem.Visible = False
        '
        'btnItemSelect
        '
        Me.btnItemSelect.BackColor = System.Drawing.Color.Green
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
        Me.btnItemSelect.Text = "PILIH PO"
        Me.btnItemSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnItemSelect.UseVisualStyleBackColor = False
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Controls.Add(Me.btnShowHideItem)
        Me.pHeader.Controls.Add(Me.btnSearch)
        Me.pHeader.Controls.Add(Me.btnNew)
        Me.pHeader.Controls.Add(Me.btnSave)
        Me.pHeader.Controls.Add(Me.btnDelete)
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.ForeColor = System.Drawing.Color.White
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(883, 30)
        Me.pHeader.TabIndex = 4
        '
        'btnShowHideItem
        '
        Me.btnShowHideItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnShowHideItem.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnShowHideItem.FlatAppearance.BorderSize = 0
        Me.btnShowHideItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowHideItem.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnShowHideItem.ForeColor = System.Drawing.Color.White
        Me.btnShowHideItem.Location = New System.Drawing.Point(0, 0)
        Me.btnShowHideItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnShowHideItem.Name = "btnShowHideItem"
        Me.btnShowHideItem.Size = New System.Drawing.Size(110, 30)
        Me.btnShowHideItem.TabIndex = 37
        Me.btnShowHideItem.Text = ">> PO DATA"
        Me.btnShowHideItem.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(603, 0)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(60, 30)
        Me.btnSearch.TabIndex = 18
        Me.btnSearch.Text = "CARI"
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnNew.FlatAppearance.BorderSize = 0
        Me.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(663, 0)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(60, 30)
        Me.btnNew.TabIndex = 17
        Me.btnNew.Text = "BARU"
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNew.UseVisualStyleBackColor = True
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
        Me.btnSave.Location = New System.Drawing.Point(723, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "SIMPAN"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Maroon
        Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(803, 0)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 30)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "VOID"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = False
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
        'frmPenerimaanBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(887, 484)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPenerimaanBarang"
        Me.ShowInTaskbar = False
        Me.Text = "Penerimaan Barang"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        Me.pBody.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sePrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seDiscP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seDisc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rimeMemo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seSubtotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpField.ResumeLayout(False)
        Me.tlpField.PerformLayout()
        CType(Me.deTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teKode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueSupplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggalTempo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggalTempo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggalKirim.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggalKirim.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xtcItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcItem.ResumeLayout(False)
        Me.xtpItem.ResumeLayout(False)
        CType(Me.gcItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceCek, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pSearch.ResumeLayout(False)
        Me.pSearch.PerformLayout()
        CType(Me.teSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pItem.ResumeLayout(False)
        Me.pHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblSep5 As System.Windows.Forms.Label
    Public WithEvents pHeader As System.Windows.Forms.Panel
    Public WithEvents btnNew As System.Windows.Forms.Button
    Public WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents pBody As System.Windows.Forms.Panel
    Public WithEvents tlpField As System.Windows.Forms.TableLayoutPanel
    Public WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Public WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lblParent As System.Windows.Forms.Label
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Friend WithEvents teKode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lueSupplier As DevExpress.XtraEditors.LookUpEdit
    Public WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lueUnit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents deTanggal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents teNote As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents gcData As DevExpress.XtraGrid.GridControl
    Public WithEvents gvData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcitemtype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcidsatuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcKode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcNama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents seQty As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sePrice As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents seDiscP As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rimeMemo As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents seDisc As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents seSubtotal As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents deTanggalTempo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label5 As Label
    Friend WithEvents deTanggalKirim As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label2 As Label
    Public WithEvents btnDeleteAllItem As Button
    Public WithEvents btnDeleteItem As Button
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
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
    Public WithEvents btnLock As Button
    Friend WithEvents btnShowHideItem As Button
    Public WithEvents Panel1 As Panel
    Friend WithEvents gcQty As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents btnAddItem As Button
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pSearch As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents teSearch As DevExpress.XtraEditors.TextEdit
End Class
