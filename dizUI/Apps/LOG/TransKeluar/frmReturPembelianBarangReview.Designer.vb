<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReturPembelianBarangReview
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
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
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
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcitemtype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcidsatuan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcKode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcNama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.seQty = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.gcSatuan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.seDiscP = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rimeMemo = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.sePrice = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.seDisc = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.seSubtotal = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.tlpField = New System.Windows.Forms.TableLayoutPanel()
        Me.teReturNo = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.teDokumen = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.teUnit = New DevExpress.XtraEditors.TextEdit()
        Me.teSupplier = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.deTanggal = New DevExpress.XtraEditors.DateEdit()
        Me.teKode = New DevExpress.XtraEditors.TextEdit()
        Me.lblParent = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.teNote = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblSep5 = New System.Windows.Forms.Label()
        Me.slueDCOA = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.slueCOAView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.slueKCOA = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.seTotalRetur = New DevExpress.XtraEditors.SpinEdit()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBody.SuspendLayout()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seDiscP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rimeMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sePrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seDisc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seSubtotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpField.SuspendLayout()
        CType(Me.teReturNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teDokumen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teKode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeader.SuspendLayout()
        CType(Me.slueDCOA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueCOAView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueKCOA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seTotalRetur.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblTitle.Text = "Retur Pembelian Review"
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
        Me.gcData.Size = New System.Drawing.Size(883, 292)
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
        Me.gvData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn15, Me.GridColumn2, Me.gcID, Me.gcitemtype, Me.gcidsatuan, Me.GridColumn14, Me.gcType, Me.gcKode, Me.gcNama, Me.gcQty, Me.gcSatuan, Me.GridColumn5, Me.GridColumn3, Me.GridColumn4, Me.GridColumn6, Me.GridColumn10, Me.GridColumn9, Me.GridColumn11, Me.GridColumn13, Me.GridColumn1})
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
        'GridColumn2
        '
        Me.GridColumn2.Caption = "GridColumn2"
        Me.GridColumn2.FieldName = "idtransaksidt2"
        Me.GridColumn2.Name = "GridColumn2"
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
        Me.gcidsatuan.FieldName = "idsatuan2"
        Me.gcidsatuan.Name = "gcidsatuan"
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "is PPn"
        Me.GridColumn14.FieldName = "isppn"
        Me.GridColumn14.Name = "GridColumn14"
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
        Me.gcQty.FieldName = "qtycharges2"
        Me.gcQty.Name = "gcQty"
        Me.gcQty.OptionsColumn.AllowEdit = False
        Me.gcQty.OptionsColumn.ReadOnly = True
        Me.gcQty.Visible = True
        Me.gcQty.VisibleIndex = 3
        Me.gcQty.Width = 51
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
        Me.gcSatuan.FieldName = "satuan2"
        Me.gcSatuan.Name = "gcSatuan"
        Me.gcSatuan.OptionsColumn.AllowEdit = False
        Me.gcSatuan.OptionsColumn.ReadOnly = True
        Me.gcSatuan.Visible = True
        Me.gcSatuan.VisibleIndex = 4
        Me.gcSatuan.Width = 49
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Isi"
        Me.GridColumn5.ColumnEdit = Me.seQty
        Me.GridColumn5.DisplayFormat.FormatString = "n0"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "qtycontent"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 7
        Me.GridColumn5.Width = 45
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Qty Fakt"
        Me.GridColumn3.ColumnEdit = Me.seQty
        Me.GridColumn3.DisplayFormat.FormatString = "n0"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "qtycharges"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 5
        Me.GridColumn3.Width = 61
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
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "Satuan Fakt"
        Me.GridColumn6.FieldName = "satuan2"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 6
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
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Disc Amount"
        Me.GridColumn9.ColumnEdit = Me.seDiscP
        Me.GridColumn9.DisplayFormat.FormatString = "n2"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn9.FieldName = "discamount"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.OptionsColumn.ReadOnly = True
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
        'GridColumn11
        '
        Me.GridColumn11.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn11.Caption = "PPn"
        Me.GridColumn11.DisplayFormat.FormatString = "n2"
        Me.GridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn11.FieldName = "ppn"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.OptionsColumn.ReadOnly = True
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
        Me.GridColumn1.VisibleIndex = 8
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
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.Controls.Add(Me.seTotalRetur, 4, 4)
        Me.tlpField.Controls.Add(Me.Label5, 3, 4)
        Me.tlpField.Controls.Add(Me.slueKCOA, 4, 5)
        Me.tlpField.Controls.Add(Me.Label10, 3, 5)
        Me.tlpField.Controls.Add(Me.slueDCOA, 2, 5)
        Me.tlpField.Controls.Add(Me.teReturNo, 4, 3)
        Me.tlpField.Controls.Add(Me.Label2, 3, 3)
        Me.tlpField.Controls.Add(Me.Label9, 1, 5)
        Me.tlpField.Controls.Add(Me.teDokumen, 2, 3)
        Me.tlpField.Controls.Add(Me.Label6, 1, 3)
        Me.tlpField.Controls.Add(Me.teUnit, 4, 2)
        Me.tlpField.Controls.Add(Me.teSupplier, 2, 2)
        Me.tlpField.Controls.Add(Me.Label3, 3, 1)
        Me.tlpField.Controls.Add(Me.deTanggal, 4, 1)
        Me.tlpField.Controls.Add(Me.teKode, 2, 1)
        Me.tlpField.Controls.Add(Me.lblParent, 1, 1)
        Me.tlpField.Controls.Add(Me.Label4, 1, 4)
        Me.tlpField.Controls.Add(Me.teNote, 2, 4)
        Me.tlpField.Controls.Add(Me.Label1, 3, 2)
        Me.tlpField.Controls.Add(Me.lblDepartment, 1, 2)
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
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpField.Size = New System.Drawing.Size(883, 132)
        Me.tlpField.TabIndex = 7
        '
        'teReturNo
        '
        Me.teReturNo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teReturNo.Enabled = False
        Me.teReturNo.Location = New System.Drawing.Point(541, 56)
        Me.teReturNo.Margin = New System.Windows.Forms.Padding(0)
        Me.teReturNo.Name = "teReturNo"
        Me.teReturNo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teReturNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teReturNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teReturNo.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teReturNo.Properties.Appearance.Options.UseBackColor = True
        Me.teReturNo.Properties.Appearance.Options.UseFont = True
        Me.teReturNo.Properties.Appearance.Options.UseForeColor = True
        Me.teReturNo.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teReturNo.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teReturNo.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teReturNo.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teReturNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teReturNo.Properties.MaxLength = 300
        Me.teReturNo.Properties.NullText = "[Belum Diisi]"
        Me.teReturNo.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teReturNo.Properties.ReadOnly = True
        Me.teReturNo.Size = New System.Drawing.Size(190, 20)
        Me.teReturNo.TabIndex = 19
        Me.teReturNo.Tag = "transaksino"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(478, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 14)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "No. Retur"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teDokumen
        '
        Me.teDokumen.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teDokumen.Location = New System.Drawing.Point(241, 56)
        Me.teDokumen.Margin = New System.Windows.Forms.Padding(0)
        Me.teDokumen.Name = "teDokumen"
        Me.teDokumen.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teDokumen.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teDokumen.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teDokumen.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teDokumen.Properties.Appearance.Options.UseBackColor = True
        Me.teDokumen.Properties.Appearance.Options.UseFont = True
        Me.teDokumen.Properties.Appearance.Options.UseForeColor = True
        Me.teDokumen.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teDokumen.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teDokumen.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teDokumen.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teDokumen.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teDokumen.Properties.MaxLength = 300
        Me.teDokumen.Properties.NullText = "[Belum Diisi]"
        Me.teDokumen.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teDokumen.Properties.ReadOnly = True
        Me.teDokumen.Size = New System.Drawing.Size(190, 20)
        Me.teDokumen.TabIndex = 20
        Me.teDokumen.Tag = "dokumenno"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(174, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 14)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "No. Faktur"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teUnit
        '
        Me.teUnit.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teUnit.Enabled = False
        Me.teUnit.Location = New System.Drawing.Point(541, 32)
        Me.teUnit.Margin = New System.Windows.Forms.Padding(0)
        Me.teUnit.Name = "teUnit"
        Me.teUnit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teUnit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teUnit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teUnit.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teUnit.Properties.Appearance.Options.UseBackColor = True
        Me.teUnit.Properties.Appearance.Options.UseFont = True
        Me.teUnit.Properties.Appearance.Options.UseForeColor = True
        Me.teUnit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teUnit.Properties.MaxLength = 300
        Me.teUnit.Properties.NullText = "[Belum Diisi]"
        Me.teUnit.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teUnit.Properties.ReadOnly = True
        Me.teUnit.Size = New System.Drawing.Size(190, 20)
        Me.teUnit.TabIndex = 19
        Me.teUnit.Tag = "kode"
        '
        'teSupplier
        '
        Me.teSupplier.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teSupplier.Enabled = False
        Me.teSupplier.Location = New System.Drawing.Point(241, 32)
        Me.teSupplier.Margin = New System.Windows.Forms.Padding(0)
        Me.teSupplier.Name = "teSupplier"
        Me.teSupplier.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teSupplier.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teSupplier.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teSupplier.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teSupplier.Properties.Appearance.Options.UseBackColor = True
        Me.teSupplier.Properties.Appearance.Options.UseFont = True
        Me.teSupplier.Properties.Appearance.Options.UseForeColor = True
        Me.teSupplier.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teSupplier.Properties.MaxLength = 300
        Me.teSupplier.Properties.NullText = "[Belum Diisi]"
        Me.teSupplier.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teSupplier.Properties.ReadOnly = True
        Me.teSupplier.Size = New System.Drawing.Size(190, 20)
        Me.teSupplier.TabIndex = 19
        Me.teSupplier.Tag = "kode"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(457, 11)
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
        Me.deTanggal.Location = New System.Drawing.Point(541, 8)
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
        Me.teKode.Location = New System.Drawing.Point(241, 8)
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
        Me.lblParent.Location = New System.Drawing.Point(145, 11)
        Me.lblParent.Name = "lblParent"
        Me.lblParent.Size = New System.Drawing.Size(93, 14)
        Me.lblParent.TabIndex = 20
        Me.lblParent.Text = "No. Penerimaan"
        Me.lblParent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(168, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 14)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Keterangan"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teNote
        '
        Me.teNote.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNote.Location = New System.Drawing.Point(241, 80)
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
        Me.teNote.Properties.ReadOnly = True
        Me.teNote.Size = New System.Drawing.Size(150, 20)
        Me.teNote.TabIndex = 20
        Me.teNote.Tag = "remarks"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(509, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 14)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Unit"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDepartment
        '
        Me.lblDepartment.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.Location = New System.Drawing.Point(188, 35)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(50, 14)
        Me.lblDepartment.TabIndex = 9
        Me.lblDepartment.Text = "Supplier"
        Me.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Controls.Add(Me.btnSearch)
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
        Me.btnSearch.Location = New System.Drawing.Point(663, 0)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(60, 30)
        Me.btnSearch.TabIndex = 18
        Me.btnSearch.Text = "CARI"
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearch.UseVisualStyleBackColor = True
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
        Me.btnSave.Text = "REVIEW"
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
        'slueDCOA
        '
        Me.slueDCOA.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.slueDCOA.Location = New System.Drawing.Point(241, 104)
        Me.slueDCOA.Margin = New System.Windows.Forms.Padding(0)
        Me.slueDCOA.Name = "slueDCOA"
        Me.slueDCOA.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.slueDCOA.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.slueDCOA.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.slueDCOA.Properties.Appearance.Options.UseBackColor = True
        Me.slueDCOA.Properties.Appearance.Options.UseFont = True
        Me.slueDCOA.Properties.Appearance.Options.UseForeColor = True
        Me.slueDCOA.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.slueDCOA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueDCOA.Properties.NullText = "[Isian belum dipilih]"
        Me.slueDCOA.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.slueDCOA.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Simple
        Me.slueDCOA.Properties.PopupFindMode = DevExpress.XtraEditors.FindMode.Always
        Me.slueDCOA.Properties.PopupView = Me.slueCOAView
        Me.slueDCOA.Properties.ShowFooter = False
        Me.slueDCOA.Properties.ShowPopupShadow = False
        Me.slueDCOA.Properties.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView
        Me.slueDCOA.Size = New System.Drawing.Size(150, 20)
        Me.slueDCOA.TabIndex = 25
        '
        'slueCOAView
        '
        Me.slueCOAView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.slueCOAView.Appearance.EvenRow.Options.UseBackColor = True
        Me.slueCOAView.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.slueCOAView.Appearance.OddRow.Options.UseBackColor = True
        Me.slueCOAView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7, Me.GridColumn16, Me.GridColumn17})
        Me.slueCOAView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.slueCOAView.Name = "slueCOAView"
        Me.slueCOAView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.slueCOAView.OptionsView.EnableAppearanceEvenRow = True
        Me.slueCOAView.OptionsView.EnableAppearanceOddRow = True
        Me.slueCOAView.OptionsView.ShowGroupPanel = False
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "ID"
        Me.GridColumn7.FieldName = "idcoa"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "COA"
        Me.GridColumn16.FieldName = "coa"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.AllowEdit = False
        Me.GridColumn16.OptionsColumn.ReadOnly = True
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 0
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Remarks"
        Me.GridColumn17.FieldName = "remarks"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.AllowEdit = False
        Me.GridColumn17.OptionsColumn.ReadOnly = True
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 1
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(471, 107)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 14)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "COA Kredit"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(169, 107)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 14)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "COA Debet"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'slueKCOA
        '
        Me.slueKCOA.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.slueKCOA.Location = New System.Drawing.Point(541, 104)
        Me.slueKCOA.Margin = New System.Windows.Forms.Padding(0)
        Me.slueKCOA.Name = "slueKCOA"
        Me.slueKCOA.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.slueKCOA.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.slueKCOA.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.slueKCOA.Properties.Appearance.Options.UseBackColor = True
        Me.slueKCOA.Properties.Appearance.Options.UseFont = True
        Me.slueKCOA.Properties.Appearance.Options.UseForeColor = True
        Me.slueKCOA.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.slueKCOA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueKCOA.Properties.NullText = "[Isian belum dipilih]"
        Me.slueKCOA.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.slueKCOA.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Simple
        Me.slueKCOA.Properties.PopupFindMode = DevExpress.XtraEditors.FindMode.Always
        Me.slueKCOA.Properties.PopupView = Me.GridView2
        Me.slueKCOA.Properties.ShowFooter = False
        Me.slueKCOA.Properties.ShowPopupShadow = False
        Me.slueKCOA.Properties.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView
        Me.slueKCOA.Size = New System.Drawing.Size(150, 20)
        Me.slueKCOA.TabIndex = 26
        '
        'GridView2
        '
        Me.GridView2.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView2.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView2.Appearance.OddRow.Options.UseBackColor = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn8, Me.GridColumn12, Me.GridColumn18})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView2.OptionsView.EnableAppearanceOddRow = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "ID"
        Me.GridColumn8.FieldName = "idcoa"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "COA"
        Me.GridColumn12.FieldName = "coa"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.OptionsColumn.ReadOnly = True
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 0
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Remarks"
        Me.GridColumn18.FieldName = "remarks"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.OptionsColumn.AllowEdit = False
        Me.GridColumn18.OptionsColumn.ReadOnly = True
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 1
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Subtotal"
        Me.GridColumn13.FieldName = "subtotaldisclainppn"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        Me.GridColumn13.OptionsColumn.ReadOnly = True
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(469, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 14)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Total Retur"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'seTotalRetur
        '
        Me.seTotalRetur.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.seTotalRetur.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seTotalRetur.Location = New System.Drawing.Point(541, 80)
        Me.seTotalRetur.Margin = New System.Windows.Forms.Padding(0)
        Me.seTotalRetur.Name = "seTotalRetur"
        Me.seTotalRetur.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.seTotalRetur.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.seTotalRetur.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.seTotalRetur.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.seTotalRetur.Properties.Appearance.Options.UseBackColor = True
        Me.seTotalRetur.Properties.Appearance.Options.UseFont = True
        Me.seTotalRetur.Properties.Appearance.Options.UseForeColor = True
        Me.seTotalRetur.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.seTotalRetur.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.seTotalRetur.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.seTotalRetur.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.seTotalRetur.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.seTotalRetur.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.seTotalRetur.Properties.DisplayFormat.FormatString = "n2"
        Me.seTotalRetur.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seTotalRetur.Properties.EditFormat.FormatString = "n2"
        Me.seTotalRetur.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seTotalRetur.Properties.IsFloatValue = False
        Me.seTotalRetur.Properties.Mask.EditMask = "N00"
        Me.seTotalRetur.Properties.MaxLength = 11
        Me.seTotalRetur.Properties.MaxValue = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.seTotalRetur.Properties.ReadOnly = True
        Me.seTotalRetur.Size = New System.Drawing.Size(150, 20)
        Me.seTotalRetur.TabIndex = 50
        Me.seTotalRetur.Tag = ""
        '
        'frmReturPembelianReview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(887, 484)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReturPembelianReview"
        Me.ShowInTaskbar = False
        Me.Text = "Retur Pembelian Review"
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
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seDiscP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rimeMemo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sePrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seDisc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seSubtotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpField.ResumeLayout(False)
        Me.tlpField.PerformLayout()
        CType(Me.teReturNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teDokumen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teSupplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teKode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        CType(Me.slueDCOA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueCOAView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueKCOA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seTotalRetur.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents teKode As DevExpress.XtraEditors.TextEdit
    Public WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents deTanggal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents teNote As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents teUnit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teSupplier As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teDokumen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As Label
    Public WithEvents gcData As DevExpress.XtraGrid.GridControl
    Public WithEvents gvData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcitemtype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcidsatuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcKode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcNama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents seQty As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents gcSatuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sePrice As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents seDiscP As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents seDisc As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rimeMemo As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents seSubtotal As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents teReturNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents slueKCOA As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label10 As Label
    Friend WithEvents slueDCOA As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents slueCOAView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label9 As Label
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents seTotalRetur As DevExpress.XtraEditors.SpinEdit
End Class
