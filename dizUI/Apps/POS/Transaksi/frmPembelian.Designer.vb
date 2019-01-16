<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPembelian
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
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.tlpForm = New System.Windows.Forms.TableLayoutPanel()
        Me.pTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pMinimize = New System.Windows.Forms.PictureBox()
        Me.pMaximize = New System.Windows.Forms.PictureBox()
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.pBody = New System.Windows.Forms.Panel()
        Me.gcData = New DevExpress.XtraGrid.GridControl()
        Me.gvData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcitemtype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcidsatuan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcKode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcNama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcSatuan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcDiscAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.seDisc = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.gcDiscP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.seDiscP = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.gcPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sePrice = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.gcSubtotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.seSubtotal = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.gcQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.seQty = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDeleteAllItem = New System.Windows.Forms.Button()
        Me.btnDeleteItem = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.nudSubtotal = New DevExpress.XtraEditors.SpinEdit()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.luePayment = New DevExpress.XtraEditors.LookUpEdit()
        Me.deTerima = New DevExpress.XtraEditors.DateEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lueJenis = New DevExpress.XtraEditors.LookUpEdit()
        Me.nudOngkir = New DevExpress.XtraEditors.SpinEdit()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nudBayar = New DevExpress.XtraEditors.SpinEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nudTotal = New DevExpress.XtraEditors.SpinEdit()
        Me.nudPajak = New DevExpress.XtraEditors.SpinEdit()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.nudDiskonGlobal = New DevExpress.XtraEditors.SpinEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nudDiskon = New DevExpress.XtraEditors.SpinEdit()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tlpField = New System.Windows.Forms.TableLayoutPanel()
        Me.btnLockSupplier = New System.Windows.Forms.Button()
        Me.btnPermintaan = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.deTanggal = New DevExpress.XtraEditors.DateEdit()
        Me.teNoPermintaan = New DevExpress.XtraEditors.TextEdit()
        Me.teKode = New DevExpress.XtraEditors.TextEdit()
        Me.lblParent = New System.Windows.Forms.Label()
        Me.lueUnit = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.lueSupplier = New DevExpress.XtraEditors.LookUpEdit()
        Me.teNote = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.teCP = New DevExpress.XtraEditors.TextEdit()
        Me.lblCP = New System.Windows.Forms.Label()
        Me.btnLockUnit = New System.Windows.Forms.Button()
        Me.teEmail = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pRightBar = New System.Windows.Forms.Panel()
        Me.xtcItem = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpItemSupplier = New DevExpress.XtraTab.XtraTabPage()
        Me.gcItemSupplier = New DevExpress.XtraGrid.GridControl()
        Me.gvItemSupplier = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcsID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcsPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcsItem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcsDisc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcsCek = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.pItemSupplier = New System.Windows.Forms.Panel()
        Me.btnAllItemSupplier = New System.Windows.Forms.Button()
        Me.btnItemSupplierSelect = New System.Windows.Forms.Button()
        Me.xtpItem = New DevExpress.XtraTab.XtraTabPage()
        Me.gcItem = New DevExpress.XtraGrid.GridControl()
        Me.gvItem = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gclID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gclPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gclItem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gclCek = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.celCek = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.pItem = New System.Windows.Forms.Panel()
        Me.btnAllItemSelect = New System.Windows.Forms.Button()
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
        CType(Me.seDisc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seDiscP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sePrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seSubtotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.nudSubtotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePayment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTerima.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTerima.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueJenis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudOngkir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBayar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPajak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDiskonGlobal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDiskon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpField.SuspendLayout()
        CType(Me.deTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNoPermintaan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teKode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teCP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pRightBar.SuspendLayout()
        CType(Me.xtcItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcItem.SuspendLayout()
        Me.xtpItemSupplier.SuspendLayout()
        CType(Me.gcItemSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvItemSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pItemSupplier.SuspendLayout()
        Me.xtpItem.SuspendLayout()
        CType(Me.gcItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.celCek, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblTitle.Text = "Pembelian"
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
        Me.pBody.Controls.Add(Me.Panel1)
        Me.pBody.Controls.Add(Me.TableLayoutPanel1)
        Me.pBody.Controls.Add(Me.tlpField)
        Me.pBody.Controls.Add(Me.pRightBar)
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
        Me.gcData.Location = New System.Drawing.Point(0, 158)
        Me.gcData.MainView = Me.gvData
        Me.gcData.Name = "gcData"
        Me.gcData.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.seQty, Me.sePrice, Me.seDisc, Me.seDiscP, Me.seSubtotal})
        Me.gcData.Size = New System.Drawing.Size(613, 138)
        Me.gcData.TabIndex = 10
        Me.gcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvData})
        '
        'gvData
        '
        Me.gvData.Appearance.Empty.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.gvData.Appearance.Empty.Options.UseBackColor = True
        Me.gvData.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.Row.Options.UseBackColor = True
        Me.gvData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcID, Me.gcitemtype, Me.gcidsatuan, Me.gcType, Me.gcKode, Me.gcNama, Me.gcSatuan, Me.gcDiscAmount, Me.gcDiscP, Me.gcPrice, Me.gcSubtotal, Me.gcQty})
        Me.gvData.GridControl = Me.gcData
        Me.gvData.Name = "gvData"
        Me.gvData.OptionsView.ShowGroupPanel = False
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
        Me.gcKode.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gcKode.AppearanceCell.Options.UseBackColor = True
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
        Me.gcNama.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gcNama.AppearanceCell.Options.UseBackColor = True
        Me.gcNama.Caption = "Nama"
        Me.gcNama.FieldName = "item"
        Me.gcNama.Name = "gcNama"
        Me.gcNama.OptionsColumn.AllowEdit = False
        Me.gcNama.OptionsColumn.ReadOnly = True
        Me.gcNama.Visible = True
        Me.gcNama.VisibleIndex = 2
        '
        'gcSatuan
        '
        Me.gcSatuan.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gcSatuan.AppearanceCell.Options.UseBackColor = True
        Me.gcSatuan.Caption = "Satuan"
        Me.gcSatuan.FieldName = "satuan"
        Me.gcSatuan.Name = "gcSatuan"
        Me.gcSatuan.OptionsColumn.AllowEdit = False
        Me.gcSatuan.OptionsColumn.ReadOnly = True
        Me.gcSatuan.Visible = True
        Me.gcSatuan.VisibleIndex = 3
        '
        'gcDiscAmount
        '
        Me.gcDiscAmount.Caption = "Disc/pc"
        Me.gcDiscAmount.ColumnEdit = Me.seDisc
        Me.gcDiscAmount.FieldName = "discamount"
        Me.gcDiscAmount.Name = "gcDiscAmount"
        Me.gcDiscAmount.OptionsColumn.AllowEdit = False
        Me.gcDiscAmount.OptionsColumn.ReadOnly = True
        Me.gcDiscAmount.Visible = True
        Me.gcDiscAmount.VisibleIndex = 7
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
        'gcDiscP
        '
        Me.gcDiscP.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gcDiscP.AppearanceCell.Options.UseBackColor = True
        Me.gcDiscP.Caption = "Disc/pc (%)"
        Me.gcDiscP.ColumnEdit = Me.seDiscP
        Me.gcDiscP.DisplayFormat.FormatString = "n0"
        Me.gcDiscP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcDiscP.FieldName = "discpersen"
        Me.gcDiscP.Name = "gcDiscP"
        Me.gcDiscP.Visible = True
        Me.gcDiscP.VisibleIndex = 6
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
        'gcPrice
        '
        Me.gcPrice.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gcPrice.AppearanceCell.Options.UseBackColor = True
        Me.gcPrice.Caption = "Harga/pc"
        Me.gcPrice.ColumnEdit = Me.sePrice
        Me.gcPrice.DisplayFormat.FormatString = "n2"
        Me.gcPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcPrice.FieldName = "price"
        Me.gcPrice.Name = "gcPrice"
        Me.gcPrice.Visible = True
        Me.gcPrice.VisibleIndex = 5
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
        'gcSubtotal
        '
        Me.gcSubtotal.Caption = "Subtotal"
        Me.gcSubtotal.ColumnEdit = Me.seSubtotal
        Me.gcSubtotal.FieldName = "subtotal"
        Me.gcSubtotal.Name = "gcSubtotal"
        Me.gcSubtotal.OptionsColumn.AllowEdit = False
        Me.gcSubtotal.OptionsColumn.ReadOnly = True
        Me.gcSubtotal.Visible = True
        Me.gcSubtotal.VisibleIndex = 8
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
        'gcQty
        '
        Me.gcQty.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gcQty.AppearanceCell.Options.UseBackColor = True
        Me.gcQty.Caption = "Qty"
        Me.gcQty.ColumnEdit = Me.seQty
        Me.gcQty.DisplayFormat.FormatString = "n0"
        Me.gcQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcQty.FieldName = "qty"
        Me.gcQty.Name = "gcQty"
        Me.gcQty.Visible = True
        Me.gcQty.VisibleIndex = 4
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnDeleteAllItem)
        Me.Panel1.Controls.Add(Me.btnDeleteItem)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 296)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(613, 30)
        Me.Panel1.TabIndex = 14
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
        Me.btnDeleteAllItem.Text = "DELETE ALL ITEM"
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
        Me.btnDeleteItem.Text = "DELETE ITEM"
        Me.btnDeleteItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeleteItem.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.nudSubtotal, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label14, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.luePayment, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.deTerima, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lueJenis, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.nudOngkir, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.nudBayar, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.nudTotal, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.nudPajak, 4, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.nudDiskonGlobal, 4, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.nudDiskon, 4, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 3, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 326)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(613, 128)
        Me.TableLayoutPanel1.TabIndex = 11
        '
        'nudSubtotal
        '
        Me.nudSubtotal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.nudSubtotal.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.nudSubtotal.Enabled = False
        Me.nudSubtotal.Location = New System.Drawing.Point(431, 30)
        Me.nudSubtotal.Margin = New System.Windows.Forms.Padding(0)
        Me.nudSubtotal.Name = "nudSubtotal"
        Me.nudSubtotal.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.nudSubtotal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.nudSubtotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.nudSubtotal.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.nudSubtotal.Properties.Appearance.Options.UseBackColor = True
        Me.nudSubtotal.Properties.Appearance.Options.UseFont = True
        Me.nudSubtotal.Properties.Appearance.Options.UseForeColor = True
        Me.nudSubtotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.nudSubtotal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.nudSubtotal.Properties.DisplayFormat.FormatString = "n2"
        Me.nudSubtotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.nudSubtotal.Properties.EditFormat.FormatString = "n2"
        Me.nudSubtotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.nudSubtotal.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.nudSubtotal.Properties.MaxValue = New Decimal(New Integer() {1316134911, 2328, 0, 0})
        Me.nudSubtotal.Properties.ReadOnly = True
        Me.nudSubtotal.Size = New System.Drawing.Size(150, 20)
        Me.nudSubtotal.TabIndex = 42
        Me.nudSubtotal.Tag = ""
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(375, 33)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 14)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Subtotal"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(355, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 14)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Pembayaran"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'luePayment
        '
        Me.luePayment.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.luePayment.Location = New System.Drawing.Point(431, 6)
        Me.luePayment.Margin = New System.Windows.Forms.Padding(0)
        Me.luePayment.Name = "luePayment"
        Me.luePayment.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.luePayment.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.luePayment.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.luePayment.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.luePayment.Properties.Appearance.Options.UseBackColor = True
        Me.luePayment.Properties.Appearance.Options.UseFont = True
        Me.luePayment.Properties.Appearance.Options.UseForeColor = True
        Me.luePayment.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.luePayment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePayment.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.luePayment.Properties.NullText = "[Isian belum dipilih]"
        Me.luePayment.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.luePayment.Size = New System.Drawing.Size(150, 20)
        Me.luePayment.TabIndex = 49
        Me.luePayment.Tag = ""
        '
        'deTerima
        '
        Me.deTerima.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.deTerima.EditValue = Nothing
        Me.deTerima.Location = New System.Drawing.Point(131, 30)
        Me.deTerima.Margin = New System.Windows.Forms.Padding(0)
        Me.deTerima.Name = "deTerima"
        Me.deTerima.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deTerima.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTerima.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.deTerima.Properties.Appearance.Options.UseBackColor = True
        Me.deTerima.Properties.Appearance.Options.UseFont = True
        Me.deTerima.Properties.Appearance.Options.UseForeColor = True
        Me.deTerima.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTerima.Properties.AppearanceDisabled.Options.UseFont = True
        Me.deTerima.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTerima.Properties.AppearanceDropDown.Options.UseFont = True
        Me.deTerima.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTerima.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.deTerima.Properties.AppearanceDropDownHeaderHighlight.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTerima.Properties.AppearanceDropDownHeaderHighlight.Options.UseFont = True
        Me.deTerima.Properties.AppearanceDropDownHighlight.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTerima.Properties.AppearanceDropDownHighlight.Options.UseFont = True
        Me.deTerima.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTerima.Properties.AppearanceFocused.Options.UseFont = True
        Me.deTerima.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTerima.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.deTerima.Properties.AppearanceWeekNumber.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTerima.Properties.AppearanceWeekNumber.Options.UseFont = True
        Me.deTerima.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.deTerima.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deTerima.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.deTerima.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.deTerima.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTerima.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.deTerima.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTerima.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.deTerima.Properties.ReadOnly = True
        Me.deTerima.Size = New System.Drawing.Size(135, 20)
        Me.deTerima.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(75, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 14)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Jenis PO"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(37, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 14)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Tanggal Terima"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueJenis
        '
        Me.lueJenis.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueJenis.Location = New System.Drawing.Point(131, 6)
        Me.lueJenis.Margin = New System.Windows.Forms.Padding(0)
        Me.lueJenis.Name = "lueJenis"
        Me.lueJenis.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueJenis.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueJenis.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueJenis.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lueJenis.Properties.Appearance.Options.UseBackColor = True
        Me.lueJenis.Properties.Appearance.Options.UseFont = True
        Me.lueJenis.Properties.Appearance.Options.UseForeColor = True
        Me.lueJenis.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueJenis.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueJenis.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueJenis.Properties.NullText = "[Isian belum dipilih]"
        Me.lueJenis.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueJenis.Size = New System.Drawing.Size(200, 20)
        Me.lueJenis.TabIndex = 48
        Me.lueJenis.Tag = ""
        '
        'nudOngkir
        '
        Me.nudOngkir.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.nudOngkir.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.nudOngkir.Location = New System.Drawing.Point(131, 54)
        Me.nudOngkir.Margin = New System.Windows.Forms.Padding(0)
        Me.nudOngkir.Name = "nudOngkir"
        Me.nudOngkir.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.nudOngkir.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.nudOngkir.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.nudOngkir.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.nudOngkir.Properties.Appearance.Options.UseBackColor = True
        Me.nudOngkir.Properties.Appearance.Options.UseFont = True
        Me.nudOngkir.Properties.Appearance.Options.UseForeColor = True
        Me.nudOngkir.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.nudOngkir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.nudOngkir.Properties.DisplayFormat.FormatString = "n2"
        Me.nudOngkir.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.nudOngkir.Properties.EditFormat.FormatString = "n2"
        Me.nudOngkir.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.nudOngkir.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.nudOngkir.Properties.IsFloatValue = False
        Me.nudOngkir.Properties.Mask.EditMask = "N00"
        Me.nudOngkir.Properties.MaxValue = New Decimal(New Integer() {1316134911, 2328, 0, 0})
        Me.nudOngkir.Size = New System.Drawing.Size(150, 20)
        Me.nudOngkir.TabIndex = 40
        Me.nudOngkir.Tag = "ongkir"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(51, 57)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 14)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Ongkos Kirim"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(60, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 14)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Total Bayar"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudBayar
        '
        Me.nudBayar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.nudBayar.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.nudBayar.Location = New System.Drawing.Point(131, 78)
        Me.nudBayar.Margin = New System.Windows.Forms.Padding(0)
        Me.nudBayar.Name = "nudBayar"
        Me.nudBayar.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.nudBayar.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.nudBayar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.nudBayar.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.nudBayar.Properties.Appearance.Options.UseBackColor = True
        Me.nudBayar.Properties.Appearance.Options.UseFont = True
        Me.nudBayar.Properties.Appearance.Options.UseForeColor = True
        Me.nudBayar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.nudBayar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.nudBayar.Properties.DisplayFormat.FormatString = "n2"
        Me.nudBayar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.nudBayar.Properties.EditFormat.FormatString = "n2"
        Me.nudBayar.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.nudBayar.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.nudBayar.Properties.IsFloatValue = False
        Me.nudBayar.Properties.Mask.EditMask = "N00"
        Me.nudBayar.Properties.MaxValue = New Decimal(New Integer() {1316134911, 2328, 0, 0})
        Me.nudBayar.Size = New System.Drawing.Size(150, 20)
        Me.nudBayar.TabIndex = 41
        Me.nudBayar.Tag = ""
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(57, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 14)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Grand Total"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudTotal
        '
        Me.nudTotal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.nudTotal.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.nudTotal.Enabled = False
        Me.nudTotal.Location = New System.Drawing.Point(131, 102)
        Me.nudTotal.Margin = New System.Windows.Forms.Padding(0)
        Me.nudTotal.Name = "nudTotal"
        Me.nudTotal.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.nudTotal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.nudTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.nudTotal.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.nudTotal.Properties.Appearance.Options.UseBackColor = True
        Me.nudTotal.Properties.Appearance.Options.UseFont = True
        Me.nudTotal.Properties.Appearance.Options.UseForeColor = True
        Me.nudTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.nudTotal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing, True)})
        Me.nudTotal.Properties.DisplayFormat.FormatString = "n2"
        Me.nudTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.nudTotal.Properties.EditFormat.FormatString = "n2"
        Me.nudTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.nudTotal.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.nudTotal.Properties.MaxValue = New Decimal(New Integer() {1316134911, 2328, 0, 0})
        Me.nudTotal.Properties.ReadOnly = True
        Me.nudTotal.Size = New System.Drawing.Size(150, 20)
        Me.nudTotal.TabIndex = 41
        Me.nudTotal.Tag = ""
        '
        'nudPajak
        '
        Me.nudPajak.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.nudPajak.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.nudPajak.Enabled = False
        Me.nudPajak.Location = New System.Drawing.Point(431, 102)
        Me.nudPajak.Margin = New System.Windows.Forms.Padding(0)
        Me.nudPajak.Name = "nudPajak"
        Me.nudPajak.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.nudPajak.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.nudPajak.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.nudPajak.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.nudPajak.Properties.Appearance.Options.UseBackColor = True
        Me.nudPajak.Properties.Appearance.Options.UseFont = True
        Me.nudPajak.Properties.Appearance.Options.UseForeColor = True
        Me.nudPajak.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.nudPajak.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, "", Nothing, Nothing, True)})
        Me.nudPajak.Properties.DisplayFormat.FormatString = "n2"
        Me.nudPajak.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.nudPajak.Properties.EditFormat.FormatString = "n2"
        Me.nudPajak.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.nudPajak.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.nudPajak.Properties.MaxValue = New Decimal(New Integer() {1316134911, 2328, 0, 0})
        Me.nudPajak.Properties.ReadOnly = True
        Me.nudPajak.Size = New System.Drawing.Size(150, 20)
        Me.nudPajak.TabIndex = 41
        Me.nudPajak.Tag = ""
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(393, 105)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 14)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Pajak"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudDiskonGlobal
        '
        Me.nudDiskonGlobal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.nudDiskonGlobal.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.nudDiskonGlobal.Location = New System.Drawing.Point(431, 78)
        Me.nudDiskonGlobal.Margin = New System.Windows.Forms.Padding(0)
        Me.nudDiskonGlobal.Name = "nudDiskonGlobal"
        Me.nudDiskonGlobal.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.nudDiskonGlobal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.nudDiskonGlobal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.nudDiskonGlobal.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.nudDiskonGlobal.Properties.Appearance.Options.UseBackColor = True
        Me.nudDiskonGlobal.Properties.Appearance.Options.UseFont = True
        Me.nudDiskonGlobal.Properties.Appearance.Options.UseForeColor = True
        Me.nudDiskonGlobal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.nudDiskonGlobal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject6, "", Nothing, Nothing, True)})
        Me.nudDiskonGlobal.Properties.DisplayFormat.FormatString = "n2"
        Me.nudDiskonGlobal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.nudDiskonGlobal.Properties.EditFormat.FormatString = "n2"
        Me.nudDiskonGlobal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.nudDiskonGlobal.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.nudDiskonGlobal.Properties.IsFloatValue = False
        Me.nudDiskonGlobal.Properties.Mask.EditMask = "N00"
        Me.nudDiskonGlobal.Properties.MaxValue = New Decimal(New Integer() {1316134911, 2328, 0, 0})
        Me.nudDiskonGlobal.Size = New System.Drawing.Size(150, 20)
        Me.nudDiskonGlobal.TabIndex = 42
        Me.nudDiskonGlobal.Tag = ""
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(350, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 14)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Global Diskon"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudDiskon
        '
        Me.nudDiskon.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.nudDiskon.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.nudDiskon.Enabled = False
        Me.nudDiskon.Location = New System.Drawing.Point(431, 54)
        Me.nudDiskon.Margin = New System.Windows.Forms.Padding(0)
        Me.nudDiskon.Name = "nudDiskon"
        Me.nudDiskon.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.nudDiskon.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.nudDiskon.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.nudDiskon.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.nudDiskon.Properties.Appearance.Options.UseBackColor = True
        Me.nudDiskon.Properties.Appearance.Options.UseFont = True
        Me.nudDiskon.Properties.Appearance.Options.UseForeColor = True
        Me.nudDiskon.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.nudDiskon.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject7, "", Nothing, Nothing, True)})
        Me.nudDiskon.Properties.DisplayFormat.FormatString = "n2"
        Me.nudDiskon.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.nudDiskon.Properties.EditFormat.FormatString = "n2"
        Me.nudDiskon.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.nudDiskon.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.nudDiskon.Properties.MaxValue = New Decimal(New Integer() {1316134911, 2328, 0, 0})
        Me.nudDiskon.Properties.ReadOnly = True
        Me.nudDiskon.Size = New System.Drawing.Size(150, 20)
        Me.nudDiskon.TabIndex = 41
        Me.nudDiskon.Tag = ""
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(336, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 14)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Subtotal Diskon"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpField
        '
        Me.tlpField.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.tlpField.ColumnCount = 6
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.Controls.Add(Me.btnLockSupplier, 2, 4)
        Me.tlpField.Controls.Add(Me.btnPermintaan, 1, 2)
        Me.tlpField.Controls.Add(Me.Label3, 3, 1)
        Me.tlpField.Controls.Add(Me.deTanggal, 4, 1)
        Me.tlpField.Controls.Add(Me.teNoPermintaan, 2, 2)
        Me.tlpField.Controls.Add(Me.teKode, 2, 1)
        Me.tlpField.Controls.Add(Me.lblParent, 1, 1)
        Me.tlpField.Controls.Add(Me.lueUnit, 4, 2)
        Me.tlpField.Controls.Add(Me.Label1, 3, 2)
        Me.tlpField.Controls.Add(Me.lblDepartment, 1, 3)
        Me.tlpField.Controls.Add(Me.lueSupplier, 2, 3)
        Me.tlpField.Controls.Add(Me.teNote, 4, 5)
        Me.tlpField.Controls.Add(Me.Label4, 3, 5)
        Me.tlpField.Controls.Add(Me.teCP, 4, 4)
        Me.tlpField.Controls.Add(Me.lblCP, 3, 4)
        Me.tlpField.Controls.Add(Me.btnLockUnit, 4, 3)
        Me.tlpField.Controls.Add(Me.teEmail, 2, 5)
        Me.tlpField.Controls.Add(Me.Label5, 1, 5)
        Me.tlpField.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpField.Location = New System.Drawing.Point(0, 30)
        Me.tlpField.Name = "tlpField"
        Me.tlpField.RowCount = 7
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.Size = New System.Drawing.Size(613, 128)
        Me.tlpField.TabIndex = 7
        '
        'btnLockSupplier
        '
        Me.btnLockSupplier.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnLockSupplier.FlatAppearance.BorderSize = 0
        Me.btnLockSupplier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnLockSupplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnLockSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLockSupplier.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLockSupplier.ForeColor = System.Drawing.Color.White
        Me.btnLockSupplier.Location = New System.Drawing.Point(135, 76)
        Me.btnLockSupplier.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnLockSupplier.Name = "btnLockSupplier"
        Me.btnLockSupplier.Size = New System.Drawing.Size(110, 24)
        Me.btnLockSupplier.TabIndex = 21
        Me.btnLockSupplier.Text = "LOCK SUPPLIER"
        Me.btnLockSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLockSupplier.UseVisualStyleBackColor = False
        '
        'btnPermintaan
        '
        Me.btnPermintaan.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnPermintaan.FlatAppearance.BorderSize = 0
        Me.btnPermintaan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnPermintaan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnPermintaan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPermintaan.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPermintaan.Location = New System.Drawing.Point(31, 28)
        Me.btnPermintaan.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPermintaan.Name = "btnPermintaan"
        Me.btnPermintaan.Size = New System.Drawing.Size(100, 24)
        Me.btnPermintaan.TabIndex = 19
        Me.btnPermintaan.Text = "No Permintaan"
        Me.btnPermintaan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPermintaan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPermintaan.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(358, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 14)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Tanggal PO"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'deTanggal
        '
        Me.deTanggal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.deTanggal.EditValue = Nothing
        Me.deTanggal.Enabled = False
        Me.deTanggal.Location = New System.Drawing.Point(431, 6)
        Me.deTanggal.Margin = New System.Windows.Forms.Padding(0)
        Me.deTanggal.Name = "deTanggal"
        Me.deTanggal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deTanggal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.deTanggal.Properties.Appearance.Options.UseBackColor = True
        Me.deTanggal.Properties.Appearance.Options.UseFont = True
        Me.deTanggal.Properties.Appearance.Options.UseForeColor = True
        Me.deTanggal.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceDisabled.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceDropDown.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceDropDownHeaderHighlight.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceDropDownHeaderHighlight.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceDropDownHighlight.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceDropDownHighlight.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceFocused.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceWeekNumber.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceWeekNumber.Options.UseFont = True
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
        'teNoPermintaan
        '
        Me.teNoPermintaan.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNoPermintaan.Enabled = False
        Me.teNoPermintaan.Location = New System.Drawing.Point(131, 30)
        Me.teNoPermintaan.Margin = New System.Windows.Forms.Padding(0)
        Me.teNoPermintaan.Name = "teNoPermintaan"
        Me.teNoPermintaan.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teNoPermintaan.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNoPermintaan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNoPermintaan.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teNoPermintaan.Properties.Appearance.Options.UseBackColor = True
        Me.teNoPermintaan.Properties.Appearance.Options.UseFont = True
        Me.teNoPermintaan.Properties.Appearance.Options.UseForeColor = True
        Me.teNoPermintaan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNoPermintaan.Properties.MaxLength = 300
        Me.teNoPermintaan.Properties.NullText = "[Belum Diisi]"
        Me.teNoPermintaan.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNoPermintaan.Properties.ReadOnly = True
        Me.teNoPermintaan.Size = New System.Drawing.Size(150, 20)
        Me.teNoPermintaan.TabIndex = 19
        Me.teNoPermintaan.Tag = "transaksino"
        '
        'teKode
        '
        Me.teKode.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teKode.Enabled = False
        Me.teKode.Location = New System.Drawing.Point(131, 6)
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
        Me.teKode.Size = New System.Drawing.Size(150, 20)
        Me.teKode.TabIndex = 18
        Me.teKode.Tag = "kode"
        '
        'lblParent
        '
        Me.lblParent.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblParent.AutoSize = True
        Me.lblParent.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParent.Location = New System.Drawing.Point(85, 9)
        Me.lblParent.Name = "lblParent"
        Me.lblParent.Size = New System.Drawing.Size(43, 14)
        Me.lblParent.TabIndex = 20
        Me.lblParent.Text = "Nomor"
        Me.lblParent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueUnit
        '
        Me.lueUnit.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueUnit.Location = New System.Drawing.Point(431, 30)
        Me.lueUnit.Margin = New System.Windows.Forms.Padding(0)
        Me.lueUnit.Name = "lueUnit"
        Me.lueUnit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueUnit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueUnit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueUnit.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lueUnit.Properties.Appearance.Options.UseBackColor = True
        Me.lueUnit.Properties.Appearance.Options.UseFont = True
        Me.lueUnit.Properties.Appearance.Options.UseForeColor = True
        Me.lueUnit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueUnit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueUnit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueUnit.Properties.NullText = "[Isian belum dipilih]"
        Me.lueUnit.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueUnit.Size = New System.Drawing.Size(150, 20)
        Me.lueUnit.TabIndex = 48
        Me.lueUnit.Tag = "idunitasal"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(399, 33)
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
        Me.lblDepartment.Location = New System.Drawing.Point(78, 57)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(50, 14)
        Me.lblDepartment.TabIndex = 9
        Me.lblDepartment.Text = "Supplier"
        Me.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueSupplier
        '
        Me.lueSupplier.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueSupplier.Location = New System.Drawing.Point(131, 54)
        Me.lueSupplier.Margin = New System.Windows.Forms.Padding(0)
        Me.lueSupplier.Name = "lueSupplier"
        Me.lueSupplier.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueSupplier.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueSupplier.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueSupplier.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lueSupplier.Properties.Appearance.Options.UseBackColor = True
        Me.lueSupplier.Properties.Appearance.Options.UseFont = True
        Me.lueSupplier.Properties.Appearance.Options.UseForeColor = True
        Me.lueSupplier.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueSupplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueSupplier.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueSupplier.Properties.NullText = "[Isian belum dipilih]"
        Me.lueSupplier.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueSupplier.Size = New System.Drawing.Size(200, 20)
        Me.lueSupplier.TabIndex = 48
        Me.lueSupplier.Tag = "idbusinesspartner"
        '
        'teNote
        '
        Me.teNote.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNote.Location = New System.Drawing.Point(431, 102)
        Me.teNote.Margin = New System.Windows.Forms.Padding(0)
        Me.teNote.Name = "teNote"
        Me.teNote.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teNote.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNote.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNote.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teNote.Properties.Appearance.Options.UseBackColor = True
        Me.teNote.Properties.Appearance.Options.UseFont = True
        Me.teNote.Properties.Appearance.Options.UseForeColor = True
        Me.teNote.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNote.Properties.MaxLength = 300
        Me.teNote.Properties.NullText = "[Belum Diisi]"
        Me.teNote.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNote.Size = New System.Drawing.Size(150, 20)
        Me.teNote.TabIndex = 20
        Me.teNote.Tag = "remarks"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(394, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 14)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Note"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teCP
        '
        Me.teCP.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teCP.Enabled = False
        Me.teCP.Location = New System.Drawing.Point(431, 78)
        Me.teCP.Margin = New System.Windows.Forms.Padding(0)
        Me.teCP.Name = "teCP"
        Me.teCP.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teCP.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teCP.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teCP.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teCP.Properties.Appearance.Options.UseBackColor = True
        Me.teCP.Properties.Appearance.Options.UseFont = True
        Me.teCP.Properties.Appearance.Options.UseForeColor = True
        Me.teCP.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teCP.Properties.MaxLength = 300
        Me.teCP.Properties.NullText = "[Belum Diisi]"
        Me.teCP.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teCP.Properties.ReadOnly = True
        Me.teCP.Size = New System.Drawing.Size(150, 20)
        Me.teCP.TabIndex = 20
        Me.teCP.Tag = "contactperson"
        '
        'lblCP
        '
        Me.lblCP.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblCP.AutoSize = True
        Me.lblCP.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCP.Location = New System.Drawing.Point(337, 81)
        Me.lblCP.Name = "lblCP"
        Me.lblCP.Size = New System.Drawing.Size(91, 14)
        Me.lblCP.TabIndex = 18
        Me.lblCP.Text = "Contact Person"
        Me.lblCP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnLockUnit
        '
        Me.btnLockUnit.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnLockUnit.FlatAppearance.BorderSize = 0
        Me.btnLockUnit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnLockUnit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnLockUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLockUnit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLockUnit.ForeColor = System.Drawing.Color.White
        Me.btnLockUnit.Location = New System.Drawing.Point(435, 52)
        Me.btnLockUnit.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnLockUnit.Name = "btnLockUnit"
        Me.btnLockUnit.Size = New System.Drawing.Size(100, 24)
        Me.btnLockUnit.TabIndex = 20
        Me.btnLockUnit.Text = "LOCK UNIT"
        Me.btnLockUnit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLockUnit.UseVisualStyleBackColor = False
        '
        'teEmail
        '
        Me.teEmail.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teEmail.Enabled = False
        Me.teEmail.Location = New System.Drawing.Point(131, 102)
        Me.teEmail.Margin = New System.Windows.Forms.Padding(0)
        Me.teEmail.Name = "teEmail"
        Me.teEmail.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teEmail.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teEmail.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teEmail.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teEmail.Properties.Appearance.Options.UseBackColor = True
        Me.teEmail.Properties.Appearance.Options.UseFont = True
        Me.teEmail.Properties.Appearance.Options.UseForeColor = True
        Me.teEmail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teEmail.Properties.MaxLength = 300
        Me.teEmail.Properties.NullText = "[Belum Diisi]"
        Me.teEmail.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teEmail.Properties.ReadOnly = True
        Me.teEmail.Size = New System.Drawing.Size(150, 20)
        Me.teEmail.TabIndex = 19
        Me.teEmail.Tag = "email"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(94, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 14)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Email"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pRightBar
        '
        Me.pRightBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pRightBar.Controls.Add(Me.xtcItem)
        Me.pRightBar.Dock = System.Windows.Forms.DockStyle.Right
        Me.pRightBar.Location = New System.Drawing.Point(613, 30)
        Me.pRightBar.Margin = New System.Windows.Forms.Padding(0)
        Me.pRightBar.Name = "pRightBar"
        Me.pRightBar.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.pRightBar.Size = New System.Drawing.Size(270, 424)
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
        Me.xtcItem.Location = New System.Drawing.Point(4, 0)
        Me.xtcItem.Margin = New System.Windows.Forms.Padding(0)
        Me.xtcItem.Name = "xtcItem"
        Me.xtcItem.SelectedTabPage = Me.xtpItemSupplier
        Me.xtcItem.Size = New System.Drawing.Size(266, 424)
        Me.xtcItem.TabIndex = 11
        Me.xtcItem.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpItemSupplier, Me.xtpItem})
        '
        'xtpItemSupplier
        '
        Me.xtpItemSupplier.Controls.Add(Me.gcItemSupplier)
        Me.xtpItemSupplier.Controls.Add(Me.pItemSupplier)
        Me.xtpItemSupplier.Name = "xtpItemSupplier"
        Me.xtpItemSupplier.Size = New System.Drawing.Size(258, 394)
        Me.xtpItemSupplier.Text = "Item Supplier"
        '
        'gcItemSupplier
        '
        Me.gcItemSupplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcItemSupplier.Location = New System.Drawing.Point(0, 0)
        Me.gcItemSupplier.MainView = Me.gvItemSupplier
        Me.gcItemSupplier.Name = "gcItemSupplier"
        Me.gcItemSupplier.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.gcItemSupplier.Size = New System.Drawing.Size(258, 364)
        Me.gcItemSupplier.TabIndex = 14
        Me.gcItemSupplier.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvItemSupplier})
        '
        'gvItemSupplier
        '
        Me.gvItemSupplier.Appearance.Empty.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.gvItemSupplier.Appearance.Empty.Options.UseBackColor = True
        Me.gvItemSupplier.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.gvItemSupplier.Appearance.Preview.ForeColor = System.Drawing.Color.White
        Me.gvItemSupplier.Appearance.Preview.Options.UseBackColor = True
        Me.gvItemSupplier.Appearance.Preview.Options.UseForeColor = True
        Me.gvItemSupplier.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvItemSupplier.Appearance.Row.Options.UseBackColor = True
        Me.gvItemSupplier.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcsID, Me.gcsPrice, Me.gcsItem, Me.gcsDisc, Me.gcsCek})
        Me.gvItemSupplier.GridControl = Me.gcItemSupplier
        Me.gvItemSupplier.Name = "gvItemSupplier"
        Me.gvItemSupplier.OptionsSelection.MultiSelect = True
        Me.gvItemSupplier.OptionsView.ShowGroupPanel = False
        Me.gvItemSupplier.OptionsView.ShowIndicator = False
        Me.gvItemSupplier.OptionsView.ShowPreview = True
        Me.gvItemSupplier.PreviewFieldName = "note"
        '
        'gcsID
        '
        Me.gcsID.Caption = "ID"
        Me.gcsID.FieldName = "iditem"
        Me.gcsID.Name = "gcsID"
        '
        'gcsPrice
        '
        Me.gcsPrice.Caption = "Price"
        Me.gcsPrice.FieldName = "price"
        Me.gcsPrice.Name = "gcsPrice"
        '
        'gcsItem
        '
        Me.gcsItem.Caption = "Item"
        Me.gcsItem.FieldName = "item"
        Me.gcsItem.Name = "gcsItem"
        Me.gcsItem.OptionsColumn.AllowEdit = False
        Me.gcsItem.OptionsColumn.ReadOnly = True
        Me.gcsItem.Visible = True
        Me.gcsItem.VisibleIndex = 0
        Me.gcsItem.Width = 159
        '
        'gcsDisc
        '
        Me.gcsDisc.Caption = "Disc %"
        Me.gcsDisc.DisplayFormat.FormatString = "n0"
        Me.gcsDisc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcsDisc.FieldName = "discpersen"
        Me.gcsDisc.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.gcsDisc.MaxWidth = 40
        Me.gcsDisc.Name = "gcsDisc"
        Me.gcsDisc.Visible = True
        Me.gcsDisc.VisibleIndex = 1
        Me.gcsDisc.Width = 40
        '
        'gcsCek
        '
        Me.gcsCek.Caption = "Cek"
        Me.gcsCek.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.gcsCek.FieldName = "cek"
        Me.gcsCek.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.gcsCek.MaxWidth = 30
        Me.gcsCek.MinWidth = 30
        Me.gcsCek.Name = "gcsCek"
        Me.gcsCek.Visible = True
        Me.gcsCek.VisibleIndex = 2
        Me.gcsCek.Width = 30
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'pItemSupplier
        '
        Me.pItemSupplier.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pItemSupplier.Controls.Add(Me.btnAllItemSupplier)
        Me.pItemSupplier.Controls.Add(Me.btnItemSupplierSelect)
        Me.pItemSupplier.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pItemSupplier.ForeColor = System.Drawing.Color.White
        Me.pItemSupplier.Location = New System.Drawing.Point(0, 364)
        Me.pItemSupplier.Margin = New System.Windows.Forms.Padding(0)
        Me.pItemSupplier.Name = "pItemSupplier"
        Me.pItemSupplier.Size = New System.Drawing.Size(258, 30)
        Me.pItemSupplier.TabIndex = 10
        '
        'btnAllItemSupplier
        '
        Me.btnAllItemSupplier.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnAllItemSupplier.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAllItemSupplier.FlatAppearance.BorderSize = 0
        Me.btnAllItemSupplier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnAllItemSupplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnAllItemSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAllItemSupplier.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAllItemSupplier.Location = New System.Drawing.Point(0, 0)
        Me.btnAllItemSupplier.Name = "btnAllItemSupplier"
        Me.btnAllItemSupplier.Size = New System.Drawing.Size(100, 30)
        Me.btnAllItemSupplier.TabIndex = 17
        Me.btnAllItemSupplier.Text = "ALL ITEM"
        Me.btnAllItemSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAllItemSupplier.UseVisualStyleBackColor = False
        '
        'btnItemSupplierSelect
        '
        Me.btnItemSupplierSelect.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnItemSupplierSelect.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnItemSupplierSelect.FlatAppearance.BorderSize = 0
        Me.btnItemSupplierSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnItemSupplierSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnItemSupplierSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItemSupplierSelect.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItemSupplierSelect.Location = New System.Drawing.Point(158, 0)
        Me.btnItemSupplierSelect.Name = "btnItemSupplierSelect"
        Me.btnItemSupplierSelect.Size = New System.Drawing.Size(100, 30)
        Me.btnItemSupplierSelect.TabIndex = 15
        Me.btnItemSupplierSelect.Text = "SELECT ITEM"
        Me.btnItemSupplierSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnItemSupplierSelect.UseVisualStyleBackColor = False
        '
        'xtpItem
        '
        Me.xtpItem.Controls.Add(Me.gcItem)
        Me.xtpItem.Controls.Add(Me.pItem)
        Me.xtpItem.Name = "xtpItem"
        Me.xtpItem.Size = New System.Drawing.Size(258, 394)
        Me.xtpItem.Text = "Daftar Item"
        '
        'gcItem
        '
        Me.gcItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcItem.Location = New System.Drawing.Point(0, 0)
        Me.gcItem.MainView = Me.gvItem
        Me.gcItem.Name = "gcItem"
        Me.gcItem.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.celCek})
        Me.gcItem.Size = New System.Drawing.Size(258, 364)
        Me.gcItem.TabIndex = 13
        Me.gcItem.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvItem})
        '
        'gvItem
        '
        Me.gvItem.Appearance.Empty.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.gvItem.Appearance.Empty.Options.UseBackColor = True
        Me.gvItem.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.gvItem.Appearance.Preview.ForeColor = System.Drawing.Color.White
        Me.gvItem.Appearance.Preview.Options.UseBackColor = True
        Me.gvItem.Appearance.Preview.Options.UseForeColor = True
        Me.gvItem.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvItem.Appearance.Row.Options.UseBackColor = True
        Me.gvItem.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gclID, Me.gclPrice, Me.gclItem, Me.gclCek})
        Me.gvItem.GridControl = Me.gcItem
        Me.gvItem.Name = "gvItem"
        Me.gvItem.OptionsSelection.MultiSelect = True
        Me.gvItem.OptionsView.ShowGroupPanel = False
        Me.gvItem.OptionsView.ShowIndicator = False
        Me.gvItem.OptionsView.ShowPreview = True
        Me.gvItem.PreviewFieldName = "note"
        '
        'gclID
        '
        Me.gclID.Caption = "ID"
        Me.gclID.FieldName = "iditem"
        Me.gclID.Name = "gclID"
        '
        'gclPrice
        '
        Me.gclPrice.Caption = "Price"
        Me.gclPrice.FieldName = "price"
        Me.gclPrice.Name = "gclPrice"
        '
        'gclItem
        '
        Me.gclItem.Caption = "Item"
        Me.gclItem.FieldName = "item"
        Me.gclItem.Name = "gclItem"
        Me.gclItem.OptionsColumn.AllowEdit = False
        Me.gclItem.OptionsColumn.ReadOnly = True
        Me.gclItem.Visible = True
        Me.gclItem.VisibleIndex = 0
        Me.gclItem.Width = 159
        '
        'gclCek
        '
        Me.gclCek.Caption = "Cek"
        Me.gclCek.ColumnEdit = Me.celCek
        Me.gclCek.FieldName = "cek"
        Me.gclCek.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.gclCek.MaxWidth = 30
        Me.gclCek.MinWidth = 30
        Me.gclCek.Name = "gclCek"
        Me.gclCek.Visible = True
        Me.gclCek.VisibleIndex = 1
        Me.gclCek.Width = 30
        '
        'celCek
        '
        Me.celCek.AutoHeight = False
        Me.celCek.Name = "celCek"
        '
        'pItem
        '
        Me.pItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pItem.Controls.Add(Me.btnAllItemSelect)
        Me.pItem.Controls.Add(Me.btnItemSelect)
        Me.pItem.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pItem.ForeColor = System.Drawing.Color.White
        Me.pItem.Location = New System.Drawing.Point(0, 364)
        Me.pItem.Margin = New System.Windows.Forms.Padding(0)
        Me.pItem.Name = "pItem"
        Me.pItem.Size = New System.Drawing.Size(258, 30)
        Me.pItem.TabIndex = 12
        '
        'btnAllItemSelect
        '
        Me.btnAllItemSelect.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnAllItemSelect.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAllItemSelect.FlatAppearance.BorderSize = 0
        Me.btnAllItemSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnAllItemSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnAllItemSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAllItemSelect.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAllItemSelect.Location = New System.Drawing.Point(0, 0)
        Me.btnAllItemSelect.Name = "btnAllItemSelect"
        Me.btnAllItemSelect.Size = New System.Drawing.Size(100, 30)
        Me.btnAllItemSelect.TabIndex = 17
        Me.btnAllItemSelect.Text = "ALL ITEM"
        Me.btnAllItemSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAllItemSelect.UseVisualStyleBackColor = False
        '
        'btnItemSelect
        '
        Me.btnItemSelect.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnItemSelect.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnItemSelect.FlatAppearance.BorderSize = 0
        Me.btnItemSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnItemSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnItemSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItemSelect.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItemSelect.Location = New System.Drawing.Point(158, 0)
        Me.btnItemSelect.Name = "btnItemSelect"
        Me.btnItemSelect.Size = New System.Drawing.Size(100, 30)
        Me.btnItemSelect.TabIndex = 15
        Me.btnItemSelect.Text = "SELECT ITEM"
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
        'frmPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.ClientSize = New System.Drawing.Size(887, 484)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPembelian"
        Me.ShowInTaskbar = False
        Me.Text = "Pembelian"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seDisc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seDiscP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sePrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seSubtotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.nudSubtotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePayment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTerima.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTerima.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueJenis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudOngkir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBayar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPajak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDiskonGlobal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDiskon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpField.ResumeLayout(False)
        Me.tlpField.PerformLayout()
        CType(Me.deTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNoPermintaan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teKode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueSupplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teCP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pRightBar.ResumeLayout(False)
        CType(Me.xtcItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcItem.ResumeLayout(False)
        Me.xtpItemSupplier.ResumeLayout(False)
        CType(Me.gcItemSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvItemSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pItemSupplier.ResumeLayout(False)
        Me.xtpItem.ResumeLayout(False)
        CType(Me.gcItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.celCek, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblCP As System.Windows.Forms.Label
    Friend WithEvents lblParent As System.Windows.Forms.Label
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Friend WithEvents teKode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lueSupplier As DevExpress.XtraEditors.LookUpEdit
    Public WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents pRightBar As System.Windows.Forms.Panel
    Public WithEvents pItemSupplier As System.Windows.Forms.Panel
    Public WithEvents btnItemSupplierSelect As System.Windows.Forms.Button
    Friend WithEvents xtcItem As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpItemSupplier As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpItem As DevExpress.XtraTab.XtraTabPage
    Public WithEvents pItem As System.Windows.Forms.Panel
    Public WithEvents btnItemSelect As System.Windows.Forms.Button
    Friend WithEvents lueUnit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents teEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teCP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents luePayment As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
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
    Friend WithEvents gcSatuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents seQty As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Public WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents deTerima As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lueJenis As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents teNoPermintaan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents nudTotal As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents nudPajak As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents nudDiskon As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents nudBayar As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents nudOngkir As DevExpress.XtraEditors.SpinEdit
    Public WithEvents btnPermintaan As System.Windows.Forms.Button
    Public WithEvents btnAllItemSupplier As System.Windows.Forms.Button
    Public WithEvents btnAllItemSelect As System.Windows.Forms.Button
    Public WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents btnDeleteAllItem As System.Windows.Forms.Button
    Public WithEvents btnDeleteItem As System.Windows.Forms.Button
    Public WithEvents gcItem As DevExpress.XtraGrid.GridControl
    Public WithEvents gvItem As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gclID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gclItem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gclCek As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents celCek As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Public WithEvents gcItemSupplier As DevExpress.XtraGrid.GridControl
    Public WithEvents gvItemSupplier As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcsID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcsItem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcsDisc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcsCek As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents gcDiscAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcDiscP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sePrice As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents seDisc As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents seDiscP As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents gcSubtotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents seSubtotal As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Public WithEvents btnLockUnit As System.Windows.Forms.Button
    Public WithEvents btnLockSupplier As System.Windows.Forms.Button
    Friend WithEvents gcsPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gclPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents nudDiskonGlobal As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents nudSubtotal As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
