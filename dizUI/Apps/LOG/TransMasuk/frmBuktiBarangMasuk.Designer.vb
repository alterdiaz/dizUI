<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBuktiBarangMasuk
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
        Me.gcData = New DevExpress.XtraGrid.GridControl()
        Me.gvData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcitemtype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcidsatuan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcKode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcNama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.seQty = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.gcSatuan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rimeMemo = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.sePrice = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.seDisc = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.seDiscP = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.seSubtotal = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.tlpField = New System.Windows.Forms.TableLayoutPanel()
        Me.teDeptTujuan = New DevExpress.XtraEditors.TextEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lueUnitAsal = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.teNote = New DevExpress.XtraEditors.TextEdit()
        Me.deTanggalPermintaan = New DevExpress.XtraEditors.DateEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.deTanggal = New DevExpress.XtraEditors.DateEdit()
        Me.lueKendaraan = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.teTransNo = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tePermintaanNo = New DevExpress.XtraEditors.TextEdit()
        Me.lblParent = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.teUnitTujuan = New DevExpress.XtraEditors.TextEdit()
        Me.teNotePermintaan = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.btnItemSelect = New System.Windows.Forms.Button()
        Me.pHeader = New System.Windows.Forms.Panel()
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
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rimeMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sePrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seDisc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seDiscP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seSubtotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpField.SuspendLayout()
        CType(Me.teDeptTujuan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueUnitAsal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggalPermintaan.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggalPermintaan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueKendaraan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teTransNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tePermintaanNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teUnitTujuan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNotePermintaan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblTitle.Text = "Bukti Barang Masuk"
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
        'gcData
        '
        Me.gcData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcData.Location = New System.Drawing.Point(0, 162)
        Me.gcData.MainView = Me.gvData
        Me.gcData.Name = "gcData"
        Me.gcData.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.seQty, Me.sePrice, Me.seDisc, Me.seDiscP, Me.seSubtotal, Me.rimeMemo, Me.RepositoryItemLookUpEdit1})
        Me.gcData.Size = New System.Drawing.Size(613, 292)
        Me.gcData.TabIndex = 14
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
        Me.gvData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn15, Me.gcID, Me.gcitemtype, Me.gcidsatuan, Me.gcType, Me.gcKode, Me.gcNama, Me.gcQty, Me.gcSatuan, Me.GridColumn10, Me.GridColumn7, Me.GridColumn1})
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
        'gcidsatuan
        '
        Me.gcidsatuan.Caption = "idsatuan"
        Me.gcidsatuan.FieldName = "idsatuan"
        Me.gcidsatuan.Name = "gcidsatuan"
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
        Me.gcType.Width = 44
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
        Me.gcKode.Width = 46
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
        Me.gcNama.Width = 61
        '
        'gcQty
        '
        Me.gcQty.AppearanceHeader.Options.UseTextOptions = True
        Me.gcQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcQty.Caption = "Qty"
        Me.gcQty.ColumnEdit = Me.seQty
        Me.gcQty.DisplayFormat.FormatString = "n0"
        Me.gcQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcQty.FieldName = "qtycharges"
        Me.gcQty.Name = "gcQty"
        Me.gcQty.OptionsColumn.AllowEdit = False
        Me.gcQty.OptionsColumn.ReadOnly = True
        Me.gcQty.Visible = True
        Me.gcQty.VisibleIndex = 3
        Me.gcQty.Width = 69
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
        'gcSatuan
        '
        Me.gcSatuan.AppearanceHeader.Options.UseTextOptions = True
        Me.gcSatuan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcSatuan.Caption = "Satuan"
        Me.gcSatuan.FieldName = "satuan"
        Me.gcSatuan.Name = "gcSatuan"
        Me.gcSatuan.OptionsColumn.AllowEdit = False
        Me.gcSatuan.OptionsColumn.ReadOnly = True
        Me.gcSatuan.Visible = True
        Me.gcSatuan.VisibleIndex = 4
        Me.gcSatuan.Width = 49
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn10.Caption = "Harga"
        Me.GridColumn10.DisplayFormat.FormatString = "n2"
        Me.GridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn10.FieldName = "harga"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.OptionsColumn.ReadOnly = True
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Subtotal"
        Me.GridColumn7.FieldName = "subtotaldisclainppn"
        Me.GridColumn7.Name = "GridColumn7"
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Keterangan"
        Me.GridColumn1.ColumnEdit = Me.rimeMemo
        Me.GridColumn1.FieldName = "remarks"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 5
        '
        'rimeMemo
        '
        Me.rimeMemo.MaxLength = 200
        Me.rimeMemo.Name = "rimeMemo"
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
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
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
        Me.tlpField.Controls.Add(Me.teDeptTujuan, 2, 4)
        Me.tlpField.Controls.Add(Me.Label9, 1, 4)
        Me.tlpField.Controls.Add(Me.lueUnitAsal, 4, 3)
        Me.tlpField.Controls.Add(Me.Label8, 3, 5)
        Me.tlpField.Controls.Add(Me.teNote, 4, 5)
        Me.tlpField.Controls.Add(Me.deTanggalPermintaan, 2, 1)
        Me.tlpField.Controls.Add(Me.Label7, 1, 1)
        Me.tlpField.Controls.Add(Me.Label3, 3, 1)
        Me.tlpField.Controls.Add(Me.deTanggal, 4, 1)
        Me.tlpField.Controls.Add(Me.lueKendaraan, 4, 4)
        Me.tlpField.Controls.Add(Me.lblDepartment, 3, 4)
        Me.tlpField.Controls.Add(Me.Label5, 3, 3)
        Me.tlpField.Controls.Add(Me.teTransNo, 4, 2)
        Me.tlpField.Controls.Add(Me.Label2, 3, 2)
        Me.tlpField.Controls.Add(Me.tePermintaanNo, 2, 2)
        Me.tlpField.Controls.Add(Me.lblParent, 1, 2)
        Me.tlpField.Controls.Add(Me.Label1, 1, 3)
        Me.tlpField.Controls.Add(Me.teUnitTujuan, 2, 3)
        Me.tlpField.Controls.Add(Me.teNotePermintaan, 2, 5)
        Me.tlpField.Controls.Add(Me.Label4, 1, 5)
        Me.tlpField.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpField.Location = New System.Drawing.Point(0, 30)
        Me.tlpField.Name = "tlpField"
        Me.tlpField.RowCount = 7
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpField.Size = New System.Drawing.Size(613, 132)
        Me.tlpField.TabIndex = 7
        '
        'teDeptTujuan
        '
        Me.teDeptTujuan.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teDeptTujuan.Enabled = False
        Me.teDeptTujuan.Location = New System.Drawing.Point(106, 80)
        Me.teDeptTujuan.Margin = New System.Windows.Forms.Padding(0)
        Me.teDeptTujuan.Name = "teDeptTujuan"
        Me.teDeptTujuan.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teDeptTujuan.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teDeptTujuan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teDeptTujuan.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teDeptTujuan.Properties.Appearance.Options.UseBackColor = True
        Me.teDeptTujuan.Properties.Appearance.Options.UseFont = True
        Me.teDeptTujuan.Properties.Appearance.Options.UseForeColor = True
        Me.teDeptTujuan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teDeptTujuan.Properties.MaxLength = 300
        Me.teDeptTujuan.Properties.NullText = "[Belum Diisi]"
        Me.teDeptTujuan.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teDeptTujuan.Properties.ReadOnly = True
        Me.teDeptTujuan.Size = New System.Drawing.Size(190, 20)
        Me.teDeptTujuan.TabIndex = 20
        Me.teDeptTujuan.Tag = "kode"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(27, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 14)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Dept Tujuan"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueUnitAsal
        '
        Me.lueUnitAsal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueUnitAsal.Location = New System.Drawing.Point(406, 56)
        Me.lueUnitAsal.Margin = New System.Windows.Forms.Padding(0)
        Me.lueUnitAsal.Name = "lueUnitAsal"
        Me.lueUnitAsal.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueUnitAsal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueUnitAsal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueUnitAsal.Properties.Appearance.Options.UseBackColor = True
        Me.lueUnitAsal.Properties.Appearance.Options.UseFont = True
        Me.lueUnitAsal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueUnitAsal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueUnitAsal.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueUnitAsal.Properties.NullText = "[Isian belum dipilih]"
        Me.lueUnitAsal.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueUnitAsal.Size = New System.Drawing.Size(200, 20)
        Me.lueUnitAsal.TabIndex = 50
        Me.lueUnitAsal.Tag = "idunitasal"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(324, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 14)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Ket.Transaksi"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teNote
        '
        Me.teNote.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNote.Location = New System.Drawing.Point(406, 104)
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
        Me.teNote.TabIndex = 21
        Me.teNote.Tag = "remarks"
        '
        'deTanggalPermintaan
        '
        Me.deTanggalPermintaan.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.deTanggalPermintaan.EditValue = Nothing
        Me.deTanggalPermintaan.Enabled = False
        Me.deTanggalPermintaan.Location = New System.Drawing.Point(106, 8)
        Me.deTanggalPermintaan.Margin = New System.Windows.Forms.Padding(0)
        Me.deTanggalPermintaan.Name = "deTanggalPermintaan"
        Me.deTanggalPermintaan.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deTanggalPermintaan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalPermintaan.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.deTanggalPermintaan.Properties.Appearance.Options.UseBackColor = True
        Me.deTanggalPermintaan.Properties.Appearance.Options.UseFont = True
        Me.deTanggalPermintaan.Properties.Appearance.Options.UseForeColor = True
        Me.deTanggalPermintaan.Properties.AppearanceCalendar.DayCellHighlighted.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalPermintaan.Properties.AppearanceCalendar.DayCellHighlighted.Options.UseFont = True
        Me.deTanggalPermintaan.Properties.AppearanceCalendar.Header.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalPermintaan.Properties.AppearanceCalendar.Header.Options.UseFont = True
        Me.deTanggalPermintaan.Properties.AppearanceCalendar.HeaderHighlighted.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalPermintaan.Properties.AppearanceCalendar.HeaderHighlighted.Options.UseFont = True
        Me.deTanggalPermintaan.Properties.AppearanceCalendar.WeekNumber.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalPermintaan.Properties.AppearanceCalendar.WeekNumber.Options.UseFont = True
        Me.deTanggalPermintaan.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalPermintaan.Properties.AppearanceDisabled.Options.UseFont = True
        Me.deTanggalPermintaan.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalPermintaan.Properties.AppearanceDropDown.Options.UseFont = True
        Me.deTanggalPermintaan.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalPermintaan.Properties.AppearanceFocused.Options.UseFont = True
        Me.deTanggalPermintaan.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalPermintaan.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.deTanggalPermintaan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.deTanggalPermintaan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deTanggalPermintaan.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.[True]
        Me.deTanggalPermintaan.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.deTanggalPermintaan.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista
        Me.deTanggalPermintaan.Properties.DisplayFormat.FormatString = "dd-MM-yyyy HH:mm:ss"
        Me.deTanggalPermintaan.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTanggalPermintaan.Properties.EditFormat.FormatString = "dd-MM-yyyy HH:mm:ss"
        Me.deTanggalPermintaan.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTanggalPermintaan.Properties.Mask.EditMask = "dd-MM-yyyy HH:mm:ss"
        Me.deTanggalPermintaan.Properties.ReadOnly = True
        Me.deTanggalPermintaan.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.deTanggalPermintaan.Size = New System.Drawing.Size(135, 20)
        Me.deTanggalPermintaan.TabIndex = 34
        Me.deTanggalPermintaan.Tag = "createddate"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 14)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Tgl. Permintaan"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(322, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 14)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Tgl. Transaksi"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'deTanggal
        '
        Me.deTanggal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.deTanggal.EditValue = Nothing
        Me.deTanggal.Enabled = False
        Me.deTanggal.Location = New System.Drawing.Point(406, 8)
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
        'lueKendaraan
        '
        Me.lueKendaraan.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueKendaraan.Location = New System.Drawing.Point(406, 80)
        Me.lueKendaraan.Margin = New System.Windows.Forms.Padding(0)
        Me.lueKendaraan.Name = "lueKendaraan"
        Me.lueKendaraan.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueKendaraan.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueKendaraan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueKendaraan.Properties.Appearance.Options.UseBackColor = True
        Me.lueKendaraan.Properties.Appearance.Options.UseFont = True
        Me.lueKendaraan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueKendaraan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueKendaraan.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueKendaraan.Properties.NullText = "[Isian belum dipilih]"
        Me.lueKendaraan.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueKendaraan.Size = New System.Drawing.Size(200, 20)
        Me.lueKendaraan.TabIndex = 49
        Me.lueKendaraan.Tag = "idunitasal"
        '
        'lblDepartment
        '
        Me.lblDepartment.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.Location = New System.Drawing.Point(339, 83)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(64, 14)
        Me.lblDepartment.TabIndex = 9
        Me.lblDepartment.Text = "Kendaraan"
        Me.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(349, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 14)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Unit Asal"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teTransNo
        '
        Me.teTransNo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teTransNo.Enabled = False
        Me.teTransNo.Location = New System.Drawing.Point(406, 32)
        Me.teTransNo.Margin = New System.Windows.Forms.Padding(0)
        Me.teTransNo.Name = "teTransNo"
        Me.teTransNo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teTransNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teTransNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teTransNo.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teTransNo.Properties.Appearance.Options.UseBackColor = True
        Me.teTransNo.Properties.Appearance.Options.UseFont = True
        Me.teTransNo.Properties.Appearance.Options.UseForeColor = True
        Me.teTransNo.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teTransNo.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teTransNo.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teTransNo.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teTransNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teTransNo.Properties.MaxLength = 300
        Me.teTransNo.Properties.NullText = "[Belum Diisi]"
        Me.teTransNo.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teTransNo.Properties.ReadOnly = True
        Me.teTransNo.Size = New System.Drawing.Size(190, 20)
        Me.teTransNo.TabIndex = 19
        Me.teTransNo.Tag = "transaksino"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(314, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 14)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "No. Surat Jalan"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tePermintaanNo
        '
        Me.tePermintaanNo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tePermintaanNo.Enabled = False
        Me.tePermintaanNo.Location = New System.Drawing.Point(106, 32)
        Me.tePermintaanNo.Margin = New System.Windows.Forms.Padding(0)
        Me.tePermintaanNo.Name = "tePermintaanNo"
        Me.tePermintaanNo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.tePermintaanNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tePermintaanNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tePermintaanNo.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.tePermintaanNo.Properties.Appearance.Options.UseBackColor = True
        Me.tePermintaanNo.Properties.Appearance.Options.UseFont = True
        Me.tePermintaanNo.Properties.Appearance.Options.UseForeColor = True
        Me.tePermintaanNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tePermintaanNo.Properties.MaxLength = 300
        Me.tePermintaanNo.Properties.NullText = "[Belum Diisi]"
        Me.tePermintaanNo.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.tePermintaanNo.Properties.ReadOnly = True
        Me.tePermintaanNo.Size = New System.Drawing.Size(190, 20)
        Me.tePermintaanNo.TabIndex = 18
        Me.tePermintaanNo.Tag = "kode"
        '
        'lblParent
        '
        Me.lblParent.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblParent.AutoSize = True
        Me.lblParent.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParent.Location = New System.Drawing.Point(12, 35)
        Me.lblParent.Name = "lblParent"
        Me.lblParent.Size = New System.Drawing.Size(91, 14)
        Me.lblParent.TabIndex = 20
        Me.lblParent.Text = "No. Permintaan"
        Me.lblParent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 14)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Unit Tujuan"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teUnitTujuan
        '
        Me.teUnitTujuan.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teUnitTujuan.Enabled = False
        Me.teUnitTujuan.Location = New System.Drawing.Point(106, 56)
        Me.teUnitTujuan.Margin = New System.Windows.Forms.Padding(0)
        Me.teUnitTujuan.Name = "teUnitTujuan"
        Me.teUnitTujuan.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teUnitTujuan.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teUnitTujuan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teUnitTujuan.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teUnitTujuan.Properties.Appearance.Options.UseBackColor = True
        Me.teUnitTujuan.Properties.Appearance.Options.UseFont = True
        Me.teUnitTujuan.Properties.Appearance.Options.UseForeColor = True
        Me.teUnitTujuan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teUnitTujuan.Properties.MaxLength = 300
        Me.teUnitTujuan.Properties.NullText = "[Belum Diisi]"
        Me.teUnitTujuan.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teUnitTujuan.Properties.ReadOnly = True
        Me.teUnitTujuan.Size = New System.Drawing.Size(190, 20)
        Me.teUnitTujuan.TabIndex = 19
        Me.teUnitTujuan.Tag = "kode"
        '
        'teNotePermintaan
        '
        Me.teNotePermintaan.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNotePermintaan.Location = New System.Drawing.Point(106, 104)
        Me.teNotePermintaan.Margin = New System.Windows.Forms.Padding(0)
        Me.teNotePermintaan.Name = "teNotePermintaan"
        Me.teNotePermintaan.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teNotePermintaan.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNotePermintaan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNotePermintaan.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teNotePermintaan.Properties.Appearance.Options.UseBackColor = True
        Me.teNotePermintaan.Properties.Appearance.Options.UseFont = True
        Me.teNotePermintaan.Properties.Appearance.Options.UseForeColor = True
        Me.teNotePermintaan.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNotePermintaan.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teNotePermintaan.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNotePermintaan.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teNotePermintaan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNotePermintaan.Properties.MaxLength = 300
        Me.teNotePermintaan.Properties.NullText = "[Belum Diisi]"
        Me.teNotePermintaan.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNotePermintaan.Properties.ReadOnly = True
        Me.teNotePermintaan.Size = New System.Drawing.Size(150, 20)
        Me.teNotePermintaan.TabIndex = 20
        Me.teNotePermintaan.Tag = "remarks"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 14)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Ket.Permintaan"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.xtcItem.TabIndex = 15
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
        Me.gclItem.Caption = "Permintaan"
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
        Me.pItem.Controls.Add(Me.btnItemSelect)
        Me.pItem.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pItem.ForeColor = System.Drawing.Color.White
        Me.pItem.Location = New System.Drawing.Point(0, 364)
        Me.pItem.Margin = New System.Windows.Forms.Padding(0)
        Me.pItem.Name = "pItem"
        Me.pItem.Size = New System.Drawing.Size(262, 30)
        Me.pItem.TabIndex = 12
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
        Me.btnItemSelect.Text = "PILIH SPB"
        Me.btnItemSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnItemSelect.UseVisualStyleBackColor = False
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
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
        Me.btnNew.TabIndex = 19
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
        'frmBuktiBarangMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(887, 484)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBuktiBarangMasuk"
        Me.ShowInTaskbar = False
        Me.Text = "Bukti Barang Masuk"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        Me.pBody.PerformLayout()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rimeMemo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sePrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seDisc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seDiscP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seSubtotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpField.ResumeLayout(False)
        Me.tlpField.PerformLayout()
        CType(Me.teDeptTujuan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueUnitAsal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggalPermintaan.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggalPermintaan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueKendaraan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teTransNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tePermintaanNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teUnitTujuan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNotePermintaan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents tePermintaanNo As DevExpress.XtraEditors.TextEdit
    Public WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents deTanggal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents teNotePermintaan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents teUnitTujuan As DevExpress.XtraEditors.TextEdit
    Public WithEvents gcData As DevExpress.XtraGrid.GridControl
    Public WithEvents gvData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcitemtype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcidsatuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcKode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcNama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents seQty As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents gcSatuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sePrice As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents seDiscP As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents seDisc As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rimeMemo As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents seSubtotal As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents teTransNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As Label
    Public WithEvents btnNew As Button
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueKendaraan As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents xtcItem As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpItem As DevExpress.XtraTab.XtraTabPage
    Public WithEvents gcItem As DevExpress.XtraGrid.GridControl
    Public WithEvents gvItem As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gclID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gclItem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gclCek As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ceCek As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents pSearch As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents teSearch As DevExpress.XtraEditors.TextEdit
    Public WithEvents pItem As Panel
    Public WithEvents btnItemSelect As Button
    Friend WithEvents deTanggalPermintaan As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lueUnitAsal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label8 As Label
    Friend WithEvents teNote As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teDeptTujuan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As Label
End Class
