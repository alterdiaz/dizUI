<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOrderKonfirmLaboratorium
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
        Me.components = New System.ComponentModel.Container()
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
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcitemtype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcKode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcNama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.seQty = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rimeRemarks = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lueRujukan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnKonfirmAllItem = New System.Windows.Forms.Button()
        Me.btnKonfirmItem = New System.Windows.Forms.Button()
        Me.btnDeleteAllItem = New System.Windows.Forms.Button()
        Me.btnDeleteItem = New System.Windows.Forms.Button()
        Me.tlpField = New System.Windows.Forms.TableLayoutPanel()
        Me.teNoRegInduk = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.teRemarks = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.deTanggal = New DevExpress.XtraEditors.DateEdit()
        Me.teNoTrans = New DevExpress.XtraEditors.TextEdit()
        Me.lblParent = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.lueUnit = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.teNoRegistrasi = New DevExpress.XtraEditors.TextEdit()
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
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnSavePrint = New System.Windows.Forms.Button()
        Me.btnKonfirm = New System.Windows.Forms.Button()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.btnLabel2 = New System.Windows.Forms.Button()
        Me.btnLabel6 = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblSep5 = New System.Windows.Forms.Label()
        Me.tmrCek = New System.Windows.Forms.Timer(Me.components)
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
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
        CType(Me.seQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rimeRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueRujukan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.tlpField.SuspendLayout()
        CType(Me.teNoRegInduk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNoTrans.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNoRegistrasi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tlpForm.Size = New System.Drawing.Size(941, 449)
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
        Me.pTitle.Size = New System.Drawing.Size(937, 30)
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
        Me.lblTitle.Size = New System.Drawing.Size(847, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Konfirm Permintaan Laboratorium"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pMinimize
        '
        Me.pMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.pMinimize.Image = Global.dizUI.My.Resources.Resources.min_w
        Me.pMinimize.Location = New System.Drawing.Point(847, 0)
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
        Me.pMaximize.Location = New System.Drawing.Point(877, 0)
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
        Me.pExit.Location = New System.Drawing.Point(907, 0)
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
        Me.pBody.Size = New System.Drawing.Size(937, 419)
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
        Me.sccForm.Size = New System.Drawing.Size(937, 389)
        Me.sccForm.SplitterPosition = 662
        Me.sccForm.TabIndex = 14
        Me.sccForm.Text = "SplitContainerControl1"
        '
        'gcData
        '
        Me.gcData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcData.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gcData.Location = New System.Drawing.Point(0, 84)
        Me.gcData.MainView = Me.gvData
        Me.gcData.Name = "gcData"
        Me.gcData.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.seQty, Me.rimeRemarks, Me.lueRujukan})
        Me.gcData.Size = New System.Drawing.Size(662, 275)
        Me.gcData.TabIndex = 8
        Me.gcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvData})
        '
        'gvData
        '
        Me.gvData.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gvData.Appearance.Empty.Options.UseBackColor = True
        Me.gvData.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.EvenRow.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gvData.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvData.Appearance.EvenRow.Options.UseFont = True
        Me.gvData.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.OddRow.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gvData.Appearance.OddRow.Options.UseBackColor = True
        Me.gvData.Appearance.OddRow.Options.UseFont = True
        Me.gvData.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gvData.Appearance.Row.Options.UseFont = True
        Me.gvData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.gcID, Me.GridColumn3, Me.GridColumn9, Me.GridColumn8, Me.GridColumn2, Me.gcitemtype, Me.gcType, Me.gcKode, Me.gcNama, Me.GridColumn7, Me.GridColumn1, Me.GridColumn6})
        Me.gvData.GridControl = Me.gcData
        Me.gvData.Name = "gvData"
        Me.gvData.OptionsView.ColumnAutoWidth = False
        Me.gvData.OptionsView.EnableAppearanceEvenRow = True
        Me.gvData.OptionsView.EnableAppearanceOddRow = True
        Me.gvData.OptionsView.ShowGroupPanel = False
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridColumn4.AppearanceHeader.Options.UseFont = True
        Me.GridColumn4.Caption = "GridColumn4"
        Me.GridColumn4.FieldName = "idtransaksidt"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'gcID
        '
        Me.gcID.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gcID.AppearanceCell.Options.UseBackColor = True
        Me.gcID.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gcID.AppearanceHeader.Options.UseFont = True
        Me.gcID.Caption = "ID"
        Me.gcID.FieldName = "iditem"
        Me.gcID.Name = "gcID"
        Me.gcID.OptionsColumn.AllowEdit = False
        Me.gcID.OptionsColumn.ReadOnly = True
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "iditemgrup"
        Me.GridColumn3.FieldName = "iditemgrup"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "GridColumn9"
        Me.GridColumn9.FieldName = "isdone"
        Me.GridColumn9.Name = "GridColumn9"
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn8.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn8.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridColumn8.AppearanceHeader.Options.UseFont = True
        Me.GridColumn8.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn8.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn8.Caption = "Konfirm"
        Me.GridColumn8.FieldName = "isdonestr"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Item Grup"
        Me.GridColumn2.FieldName = "itemgrup"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 90
        '
        'gcitemtype
        '
        Me.gcitemtype.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gcitemtype.AppearanceHeader.Options.UseFont = True
        Me.gcitemtype.Caption = "itemtype"
        Me.gcitemtype.FieldName = "itemtype"
        Me.gcitemtype.Name = "gcitemtype"
        '
        'gcType
        '
        Me.gcType.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gcType.AppearanceHeader.Options.UseFont = True
        Me.gcType.AppearanceHeader.Options.UseTextOptions = True
        Me.gcType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcType.Caption = "Tipe"
        Me.gcType.FieldName = "type"
        Me.gcType.Name = "gcType"
        Me.gcType.OptionsColumn.AllowEdit = False
        Me.gcType.OptionsColumn.ReadOnly = True
        Me.gcType.Visible = True
        Me.gcType.VisibleIndex = 1
        Me.gcType.Width = 92
        '
        'gcKode
        '
        Me.gcKode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gcKode.AppearanceHeader.Options.UseFont = True
        Me.gcKode.AppearanceHeader.Options.UseTextOptions = True
        Me.gcKode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcKode.Caption = "Kode"
        Me.gcKode.FieldName = "kode"
        Me.gcKode.MinWidth = 120
        Me.gcKode.Name = "gcKode"
        Me.gcKode.OptionsColumn.AllowEdit = False
        Me.gcKode.OptionsColumn.ReadOnly = True
        Me.gcKode.Visible = True
        Me.gcKode.VisibleIndex = 3
        Me.gcKode.Width = 120
        '
        'gcNama
        '
        Me.gcNama.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gcNama.AppearanceHeader.Options.UseFont = True
        Me.gcNama.AppearanceHeader.Options.UseTextOptions = True
        Me.gcNama.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcNama.Caption = "Nama"
        Me.gcNama.FieldName = "item"
        Me.gcNama.Name = "gcNama"
        Me.gcNama.OptionsColumn.AllowEdit = False
        Me.gcNama.OptionsColumn.ReadOnly = True
        Me.gcNama.Visible = True
        Me.gcNama.VisibleIndex = 4
        Me.gcNama.Width = 162
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn7.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn7.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridColumn7.AppearanceHeader.Options.UseFont = True
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.Caption = "Harga"
        Me.GridColumn7.ColumnEdit = Me.seQty
        Me.GridColumn7.FieldName = "harga"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 5
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
        Me.seQty.Name = "seQty"
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn1.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Keterangan"
        Me.GridColumn1.ColumnEdit = Me.rimeRemarks
        Me.GridColumn1.FieldName = "remarks"
        Me.GridColumn1.MaxWidth = 200
        Me.GridColumn1.MinWidth = 200
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 6
        Me.GridColumn1.Width = 200
        '
        'rimeRemarks
        '
        Me.rimeRemarks.MaxLength = 200
        Me.rimeRemarks.Name = "rimeRemarks"
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn6.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn6.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridColumn6.AppearanceHeader.Options.UseFont = True
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "Dirujuk"
        Me.GridColumn6.ColumnEdit = Me.lueRujukan
        Me.GridColumn6.FieldName = "idbusinesspartner"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 7
        '
        'lueRujukan
        '
        Me.lueRujukan.AutoHeight = False
        Me.lueRujukan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueRujukan.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueRujukan.Name = "lueRujukan"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnKonfirmAllItem)
        Me.Panel1.Controls.Add(Me.btnKonfirmItem)
        Me.Panel1.Controls.Add(Me.btnDeleteAllItem)
        Me.Panel1.Controls.Add(Me.btnDeleteItem)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 359)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(662, 30)
        Me.Panel1.TabIndex = 13
        '
        'btnKonfirmAllItem
        '
        Me.btnKonfirmAllItem.BackColor = System.Drawing.Color.green
        Me.btnKonfirmAllItem.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnKonfirmAllItem.FlatAppearance.BorderSize = 0
        Me.btnKonfirmAllItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnKonfirmAllItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnKonfirmAllItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKonfirmAllItem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKonfirmAllItem.Location = New System.Drawing.Point(100, 0)
        Me.btnKonfirmAllItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnKonfirmAllItem.Name = "btnKonfirmAllItem"
        Me.btnKonfirmAllItem.Size = New System.Drawing.Size(130, 30)
        Me.btnKonfirmAllItem.TabIndex = 18
        Me.btnKonfirmAllItem.Text = "KONFIRM ALL ITEM"
        Me.btnKonfirmAllItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnKonfirmAllItem.UseVisualStyleBackColor = False
        '
        'btnKonfirmItem
        '
        Me.btnKonfirmItem.BackColor = System.Drawing.Color.green
        Me.btnKonfirmItem.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnKonfirmItem.FlatAppearance.BorderSize = 0
        Me.btnKonfirmItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnKonfirmItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnKonfirmItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKonfirmItem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKonfirmItem.Location = New System.Drawing.Point(0, 0)
        Me.btnKonfirmItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnKonfirmItem.Name = "btnKonfirmItem"
        Me.btnKonfirmItem.Size = New System.Drawing.Size(100, 30)
        Me.btnKonfirmItem.TabIndex = 17
        Me.btnKonfirmItem.Text = "KONFIRM ITEM"
        Me.btnKonfirmItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnKonfirmItem.UseVisualStyleBackColor = False
        '
        'btnDeleteAllItem
        '
        Me.btnDeleteAllItem.BackColor = System.Drawing.Color.Maroon
        Me.btnDeleteAllItem.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDeleteAllItem.FlatAppearance.BorderSize = 0
        Me.btnDeleteAllItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnDeleteAllItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnDeleteAllItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteAllItem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteAllItem.Location = New System.Drawing.Point(442, 0)
        Me.btnDeleteAllItem.Margin = New System.Windows.Forms.Padding(0)
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
        Me.btnDeleteItem.Location = New System.Drawing.Point(562, 0)
        Me.btnDeleteItem.Margin = New System.Windows.Forms.Padding(0)
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
        Me.tlpField.Controls.Add(Me.teNoRegInduk, 4, 1)
        Me.tlpField.Controls.Add(Me.Label3, 3, 1)
        Me.tlpField.Controls.Add(Me.Label1, 1, 1)
        Me.tlpField.Controls.Add(Me.teRemarks, 4, 3)
        Me.tlpField.Controls.Add(Me.Label4, 3, 3)
        Me.tlpField.Controls.Add(Me.deTanggal, 4, 2)
        Me.tlpField.Controls.Add(Me.teNoTrans, 2, 2)
        Me.tlpField.Controls.Add(Me.lblParent, 1, 2)
        Me.tlpField.Controls.Add(Me.lblDepartment, 1, 3)
        Me.tlpField.Controls.Add(Me.lueUnit, 2, 3)
        Me.tlpField.Controls.Add(Me.Label2, 3, 2)
        Me.tlpField.Controls.Add(Me.teNoRegistrasi, 2, 1)
        Me.tlpField.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpField.Location = New System.Drawing.Point(0, 0)
        Me.tlpField.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpField.Name = "tlpField"
        Me.tlpField.RowCount = 5
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpField.Size = New System.Drawing.Size(662, 84)
        Me.tlpField.TabIndex = 7
        '
        'teNoRegInduk
        '
        Me.teNoRegInduk.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNoRegInduk.Location = New System.Drawing.Point(431, 8)
        Me.teNoRegInduk.Margin = New System.Windows.Forms.Padding(0)
        Me.teNoRegInduk.Name = "teNoRegInduk"
        Me.teNoRegInduk.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teNoRegInduk.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNoRegInduk.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNoRegInduk.Properties.Appearance.Options.UseBackColor = True
        Me.teNoRegInduk.Properties.Appearance.Options.UseFont = True
        Me.teNoRegInduk.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNoRegInduk.Properties.MaxLength = 300
        Me.teNoRegInduk.Properties.NullText = "[Belum Diisi]"
        Me.teNoRegInduk.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNoRegInduk.Properties.ReadOnly = True
        Me.teNoRegInduk.Size = New System.Drawing.Size(200, 20)
        Me.teNoRegInduk.TabIndex = 20
        Me.teNoRegInduk.Tag = ""
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(346, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 14)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "No.Reg.Induk"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 14)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "No.Registrasi"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teRemarks
        '
        Me.teRemarks.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teRemarks.Location = New System.Drawing.Point(431, 56)
        Me.teRemarks.Margin = New System.Windows.Forms.Padding(0)
        Me.teRemarks.Name = "teRemarks"
        Me.teRemarks.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teRemarks.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teRemarks.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teRemarks.Properties.Appearance.Options.UseBackColor = True
        Me.teRemarks.Properties.Appearance.Options.UseFont = True
        Me.teRemarks.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teRemarks.Properties.MaxLength = 300
        Me.teRemarks.Properties.NullText = "[Belum Diisi]"
        Me.teRemarks.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teRemarks.Size = New System.Drawing.Size(150, 20)
        Me.teRemarks.TabIndex = 21
        Me.teRemarks.Tag = "remarks"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(358, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 14)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Keterangan"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'deTanggal
        '
        Me.deTanggal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.deTanggal.EditValue = Nothing
        Me.deTanggal.Location = New System.Drawing.Point(431, 32)
        Me.deTanggal.Margin = New System.Windows.Forms.Padding(0)
        Me.deTanggal.Name = "deTanggal"
        Me.deTanggal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
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
        Me.deTanggal.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deTanggal.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.deTanggal.Properties.AppearanceDisabled.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceDropDown.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceFocused.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deTanggal.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.deTanggal.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.deTanggal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.deTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.deTanggal.Properties.DisplayFormat.FormatString = "dd-MM-yyyy HH:mm:ss"
        Me.deTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTanggal.Properties.EditFormat.FormatString = "dd-MM-yyyy HH:mm:ss"
        Me.deTanggal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTanggal.Properties.Mask.EditMask = "dd-MM-yyyy HH:mm:ss"
        Me.deTanggal.Properties.ReadOnly = True
        Me.deTanggal.Size = New System.Drawing.Size(150, 20)
        Me.deTanggal.TabIndex = 32
        Me.deTanggal.Tag = ""
        '
        'teNoTrans
        '
        Me.teNoTrans.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNoTrans.Location = New System.Drawing.Point(131, 32)
        Me.teNoTrans.Margin = New System.Windows.Forms.Padding(0)
        Me.teNoTrans.Name = "teNoTrans"
        Me.teNoTrans.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teNoTrans.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNoTrans.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNoTrans.Properties.Appearance.Options.UseBackColor = True
        Me.teNoTrans.Properties.Appearance.Options.UseFont = True
        Me.teNoTrans.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNoTrans.Properties.MaxLength = 300
        Me.teNoTrans.Properties.NullText = "[Belum Diisi]"
        Me.teNoTrans.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNoTrans.Properties.ReadOnly = True
        Me.teNoTrans.Size = New System.Drawing.Size(200, 20)
        Me.teNoTrans.TabIndex = 18
        Me.teNoTrans.Tag = ""
        '
        'lblParent
        '
        Me.lblParent.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblParent.AutoSize = True
        Me.lblParent.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParent.Location = New System.Drawing.Point(53, 35)
        Me.lblParent.Name = "lblParent"
        Me.lblParent.Size = New System.Drawing.Size(75, 14)
        Me.lblParent.TabIndex = 20
        Me.lblParent.Text = "No.Transaksi"
        Me.lblParent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDepartment
        '
        Me.lblDepartment.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.Location = New System.Drawing.Point(99, 59)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(29, 14)
        Me.lblDepartment.TabIndex = 9
        Me.lblDepartment.Text = "Unit"
        Me.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueUnit
        '
        Me.lueUnit.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueUnit.Location = New System.Drawing.Point(131, 56)
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
        Me.lueUnit.Properties.ReadOnly = True
        Me.lueUnit.Size = New System.Drawing.Size(200, 20)
        Me.lueUnit.TabIndex = 48
        Me.lueUnit.Tag = "idasal"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(378, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 14)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Tanggal"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teNoRegistrasi
        '
        Me.teNoRegistrasi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNoRegistrasi.Location = New System.Drawing.Point(131, 8)
        Me.teNoRegistrasi.Margin = New System.Windows.Forms.Padding(0)
        Me.teNoRegistrasi.Name = "teNoRegistrasi"
        Me.teNoRegistrasi.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teNoRegistrasi.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNoRegistrasi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNoRegistrasi.Properties.Appearance.Options.UseBackColor = True
        Me.teNoRegistrasi.Properties.Appearance.Options.UseFont = True
        Me.teNoRegistrasi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNoRegistrasi.Properties.MaxLength = 300
        Me.teNoRegistrasi.Properties.NullText = "[Belum Diisi]"
        Me.teNoRegistrasi.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNoRegistrasi.Properties.ReadOnly = True
        Me.teNoRegistrasi.Size = New System.Drawing.Size(200, 20)
        Me.teNoRegistrasi.TabIndex = 19
        Me.teNoRegistrasi.Tag = ""
        '
        'pRightBar
        '
        Me.pRightBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pRightBar.Controls.Add(Me.xtcItem)
        Me.pRightBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pRightBar.Location = New System.Drawing.Point(0, 0)
        Me.pRightBar.Margin = New System.Windows.Forms.Padding(0)
        Me.pRightBar.Name = "pRightBar"
        Me.pRightBar.Size = New System.Drawing.Size(270, 389)
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
        Me.xtcItem.Size = New System.Drawing.Size(270, 389)
        Me.xtcItem.TabIndex = 11
        Me.xtcItem.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpItem})
        '
        'xtpItem
        '
        Me.xtpItem.Controls.Add(Me.gcItem)
        Me.xtpItem.Controls.Add(Me.pItem)
        Me.xtpItem.Name = "xtpItem"
        Me.xtpItem.Size = New System.Drawing.Size(262, 359)
        Me.xtpItem.Text = "Daftar Item"
        '
        'gcItem
        '
        Me.gcItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcItem.Location = New System.Drawing.Point(0, 0)
        Me.gcItem.MainView = Me.gvItem
        Me.gcItem.Name = "gcItem"
        Me.gcItem.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ceCek})
        Me.gcItem.Size = New System.Drawing.Size(262, 329)
        Me.gcItem.TabIndex = 11
        Me.gcItem.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvItem})
        '
        'gvItem
        '
        Me.gvItem.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gvItem.Appearance.Empty.Options.UseBackColor = True
        Me.gvItem.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvItem.Appearance.EvenRow.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gvItem.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvItem.Appearance.EvenRow.Options.UseFont = True
        Me.gvItem.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvItem.Appearance.OddRow.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gvItem.Appearance.OddRow.Options.UseBackColor = True
        Me.gvItem.Appearance.OddRow.Options.UseFont = True
        Me.gvItem.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.gvItem.Appearance.Preview.ForeColor = System.Drawing.Color.White
        Me.gvItem.Appearance.Preview.Options.UseBackColor = True
        Me.gvItem.Appearance.Preview.Options.UseForeColor = True
        Me.gvItem.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gvItem.Appearance.Row.Options.UseFont = True
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
        Me.pItem.Location = New System.Drawing.Point(0, 329)
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
        Me.pHeader.Controls.Add(Me.btnSearch)
        Me.pHeader.Controls.Add(Me.btnSave)
        Me.pHeader.Controls.Add(Me.btnSavePrint)
        Me.pHeader.Controls.Add(Me.btnKonfirm)
        Me.pHeader.Controls.Add(Me.btnCetak)
        Me.pHeader.Controls.Add(Me.btnLabel2)
        Me.pHeader.Controls.Add(Me.btnLabel6)
        Me.pHeader.Controls.Add(Me.btnDelete)
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.ForeColor = System.Drawing.Color.White
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(937, 30)
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
        Me.btnSearch.Location = New System.Drawing.Point(537, 0)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(60, 30)
        Me.btnSearch.TabIndex = 18
        Me.btnSearch.Text = "CARI"
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearch.UseVisualStyleBackColor = True
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
        Me.btnSave.Location = New System.Drawing.Point(597, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "SIMPAN"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnSavePrint
        '
        Me.btnSavePrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSavePrint.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSavePrint.FlatAppearance.BorderSize = 0
        Me.btnSavePrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnSavePrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnSavePrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSavePrint.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSavePrint.Location = New System.Drawing.Point(677, 0)
        Me.btnSavePrint.Name = "btnSavePrint"
        Me.btnSavePrint.Size = New System.Drawing.Size(100, 30)
        Me.btnSavePrint.TabIndex = 21
        Me.btnSavePrint.Text = "SIMPAN CETAK"
        Me.btnSavePrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSavePrint.UseMnemonic = False
        Me.btnSavePrint.UseVisualStyleBackColor = False
        '
        'btnKonfirm
        '
        Me.btnKonfirm.BackColor = System.Drawing.Color.green
        Me.btnKonfirm.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnKonfirm.FlatAppearance.BorderSize = 0
        Me.btnKonfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnKonfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnKonfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKonfirm.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKonfirm.Location = New System.Drawing.Point(777, 0)
        Me.btnKonfirm.Name = "btnKonfirm"
        Me.btnKonfirm.Size = New System.Drawing.Size(80, 30)
        Me.btnKonfirm.TabIndex = 23
        Me.btnKonfirm.Text = "KONFIRM"
        Me.btnKonfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnKonfirm.UseVisualStyleBackColor = False
        '
        'btnCetak
        '
        Me.btnCetak.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCetak.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCetak.FlatAppearance.BorderSize = 0
        Me.btnCetak.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnCetak.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCetak.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCetak.Location = New System.Drawing.Point(160, 0)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(80, 30)
        Me.btnCetak.TabIndex = 22
        Me.btnCetak.Text = "CETAK"
        Me.btnCetak.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCetak.UseMnemonic = False
        Me.btnCetak.UseVisualStyleBackColor = False
        '
        'btnLabel2
        '
        Me.btnLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLabel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnLabel2.FlatAppearance.BorderSize = 0
        Me.btnLabel2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnLabel2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLabel2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLabel2.Location = New System.Drawing.Point(80, 0)
        Me.btnLabel2.Name = "btnLabel2"
        Me.btnLabel2.Size = New System.Drawing.Size(80, 30)
        Me.btnLabel2.TabIndex = 20
        Me.btnLabel2.Text = "LABEL 2"
        Me.btnLabel2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLabel2.UseMnemonic = False
        Me.btnLabel2.UseVisualStyleBackColor = False
        '
        'btnLabel6
        '
        Me.btnLabel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLabel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnLabel6.FlatAppearance.BorderSize = 0
        Me.btnLabel6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnLabel6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnLabel6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLabel6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLabel6.Location = New System.Drawing.Point(0, 0)
        Me.btnLabel6.Name = "btnLabel6"
        Me.btnLabel6.Size = New System.Drawing.Size(80, 30)
        Me.btnLabel6.TabIndex = 19
        Me.btnLabel6.Text = "LABEL 6"
        Me.btnLabel6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLabel6.UseMnemonic = False
        Me.btnLabel6.UseVisualStyleBackColor = False
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
        Me.btnDelete.Location = New System.Drawing.Point(857, 0)
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
        'tmrCek
        '
        Me.tmrCek.Interval = 3000
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Cek"
        Me.GridColumn5.ColumnEdit = Me.ceCek
        Me.GridColumn5.FieldName = "cek"
        Me.GridColumn5.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.GridColumn5.MaxWidth = 30
        Me.GridColumn5.MinWidth = 30
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        Me.GridColumn5.Width = 30
        '
        'frmOrderKonfirmLaboratorium
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(941, 449)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmOrderKonfirmLaboratorium"
        Me.ShowInTaskbar = False
        Me.Text = "Konfirm Permintaan Laboratorium"
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
        CType(Me.seQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rimeRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueRujukan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.tlpField.ResumeLayout(False)
        Me.tlpField.PerformLayout()
        CType(Me.teNoRegInduk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNoTrans.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNoRegistrasi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Public WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents pBody As System.Windows.Forms.Panel
    Public WithEvents gcData As DevExpress.XtraGrid.GridControl
    Public WithEvents gvData As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents tlpField As System.Windows.Forms.TableLayoutPanel
    Public WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents gcID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcNama As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents gcKode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblParent As System.Windows.Forms.Label
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Friend WithEvents teNoTrans As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lueUnit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents gcType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcitemtype As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents pRightBar As System.Windows.Forms.Panel
    Friend WithEvents xtcItem As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpItem As DevExpress.XtraTab.XtraTabPage
    Public WithEvents pItem As System.Windows.Forms.Panel
    Public WithEvents btnItemSelect As System.Windows.Forms.Button
    Public WithEvents gcItem As DevExpress.XtraGrid.GridControl
    Public WithEvents gvItem As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gclID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gclItem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents deTanggal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents seQty As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents teRemarks As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gclCek As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ceCek As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Public WithEvents btnAllItem As System.Windows.Forms.Button
    Public WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents btnDeleteAllItem As System.Windows.Forms.Button
    Public WithEvents btnDeleteItem As System.Windows.Forms.Button
    Friend WithEvents sccForm As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents teNoRegistrasi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teNoRegInduk As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As Label
    Friend WithEvents rimeRemarks As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents tmrCek As Timer
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents btnLabel6 As Button
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueRujukan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents btnLabel2 As Button
    Public WithEvents btnSavePrint As Button
    Public WithEvents btnCetak As Button
    Public WithEvents btnKonfirmAllItem As Button
    Public WithEvents btnKonfirmItem As Button
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents btnKonfirm As Button
End Class
