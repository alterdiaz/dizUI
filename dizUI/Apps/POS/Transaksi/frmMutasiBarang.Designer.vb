<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMutasiBarang
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
        Me.gcQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.seQty = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.tlpField = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lueTujuan = New DevExpress.XtraEditors.LookUpEdit()
        Me.teNote = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.deTanggal = New DevExpress.XtraEditors.DateEdit()
        Me.teKode = New DevExpress.XtraEditors.TextEdit()
        Me.lblParent = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.lueAsal = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pRightBar = New System.Windows.Forms.Panel()
        Me.xtcItem = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpItem = New DevExpress.XtraTab.XtraTabPage()
        Me.gcItem = New DevExpress.XtraGrid.GridControl()
        Me.gvItem = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.tlpField.SuspendLayout()
        CType(Me.lueTujuan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teKode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueAsal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pRightBar.SuspendLayout()
        CType(Me.xtcItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcItem.SuspendLayout()
        Me.xtpItem.SuspendLayout()
        CType(Me.gcItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvItem, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tlpForm.Size = New System.Drawing.Size(790, 408)
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
        Me.pTitle.Size = New System.Drawing.Size(786, 30)
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
        Me.lblTitle.Size = New System.Drawing.Size(696, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Mutasi Barang"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pMinimize
        '
        Me.pMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.pMinimize.Image = Global.dizUI.My.Resources.Resources.min_w
        Me.pMinimize.Location = New System.Drawing.Point(696, 0)
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
        Me.pMaximize.Location = New System.Drawing.Point(726, 0)
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
        Me.pExit.Location = New System.Drawing.Point(756, 0)
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
        Me.pBody.Controls.Add(Me.pRightBar)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(786, 378)
        Me.pBody.TabIndex = 7
        '
        'gcData
        '
        Me.gcData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcData.Location = New System.Drawing.Point(0, 108)
        Me.gcData.MainView = Me.gvData
        Me.gcData.Name = "gcData"
        Me.gcData.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.seQty})
        Me.gcData.Size = New System.Drawing.Size(536, 270)
        Me.gcData.TabIndex = 8
        Me.gcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvData})
        '
        'gvData
        '
        Me.gvData.Appearance.Empty.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.gvData.Appearance.Empty.Options.UseBackColor = True
        Me.gvData.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.Row.Options.UseBackColor = True
        Me.gvData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcID, Me.gcitemtype, Me.gcidsatuan, Me.gcType, Me.gcKode, Me.gcNama, Me.gcSatuan, Me.gcQty})
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
        'gcQty
        '
        Me.gcQty.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gcQty.AppearanceCell.Options.UseBackColor = True
        Me.gcQty.Caption = "Qty"
        Me.gcQty.ColumnEdit = Me.seQty
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
        Me.seQty.Name = "seQty"
        '
        'tlpField
        '
        Me.tlpField.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.tlpField.ColumnCount = 6
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.Controls.Add(Me.Label1, 1, 3)
        Me.tlpField.Controls.Add(Me.lueTujuan, 2, 3)
        Me.tlpField.Controls.Add(Me.teNote, 4, 2)
        Me.tlpField.Controls.Add(Me.Label4, 3, 2)
        Me.tlpField.Controls.Add(Me.deTanggal, 4, 1)
        Me.tlpField.Controls.Add(Me.teKode, 2, 1)
        Me.tlpField.Controls.Add(Me.lblParent, 1, 1)
        Me.tlpField.Controls.Add(Me.lblDepartment, 1, 2)
        Me.tlpField.Controls.Add(Me.lueAsal, 2, 2)
        Me.tlpField.Controls.Add(Me.Label2, 3, 1)
        Me.tlpField.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpField.Location = New System.Drawing.Point(0, 30)
        Me.tlpField.Name = "tlpField"
        Me.tlpField.RowCount = 5
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.Size = New System.Drawing.Size(536, 78)
        Me.tlpField.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 14)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Unit Tujuan"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueTujuan
        '
        Me.lueTujuan.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueTujuan.Location = New System.Drawing.Point(83, 53)
        Me.lueTujuan.Margin = New System.Windows.Forms.Padding(0)
        Me.lueTujuan.Name = "lueTujuan"
        Me.lueTujuan.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueTujuan.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueTujuan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueTujuan.Properties.Appearance.Options.UseBackColor = True
        Me.lueTujuan.Properties.Appearance.Options.UseFont = True
        Me.lueTujuan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueTujuan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueTujuan.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueTujuan.Properties.NullText = "[Isian belum dipilih]"
        Me.lueTujuan.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueTujuan.Size = New System.Drawing.Size(200, 20)
        Me.lueTujuan.TabIndex = 49
        Me.lueTujuan.Tag = "idbusinesspartner"
        '
        'teNote
        '
        Me.teNote.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNote.Location = New System.Drawing.Point(383, 29)
        Me.teNote.Margin = New System.Windows.Forms.Padding(0)
        Me.teNote.Name = "teNote"
        Me.teNote.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teNote.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNote.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNote.Properties.Appearance.Options.UseBackColor = True
        Me.teNote.Properties.Appearance.Options.UseFont = True
        Me.teNote.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNote.Properties.MaxLength = 300
        Me.teNote.Properties.NullText = "[Belum Diisi]"
        Me.teNote.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNote.Size = New System.Drawing.Size(150, 20)
        Me.teNote.TabIndex = 21
        Me.teNote.Tag = "remarks"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(346, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 14)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Note"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'deTanggal
        '
        Me.deTanggal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.deTanggal.EditValue = Nothing
        Me.deTanggal.Location = New System.Drawing.Point(383, 5)
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
        Me.deTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.deTanggal.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.deTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTanggal.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.deTanggal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTanggal.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.deTanggal.Properties.ReadOnly = True
        Me.deTanggal.Size = New System.Drawing.Size(135, 20)
        Me.deTanggal.TabIndex = 32
        '
        'teKode
        '
        Me.teKode.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teKode.Location = New System.Drawing.Point(83, 5)
        Me.teKode.Margin = New System.Windows.Forms.Padding(0)
        Me.teKode.Name = "teKode"
        Me.teKode.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teKode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teKode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teKode.Properties.Appearance.Options.UseBackColor = True
        Me.teKode.Properties.Appearance.Options.UseFont = True
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
        Me.lblParent.Location = New System.Drawing.Point(37, 8)
        Me.lblParent.Name = "lblParent"
        Me.lblParent.Size = New System.Drawing.Size(43, 14)
        Me.lblParent.TabIndex = 20
        Me.lblParent.Text = "Nomor"
        Me.lblParent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDepartment
        '
        Me.lblDepartment.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.Location = New System.Drawing.Point(26, 32)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(54, 14)
        Me.lblDepartment.TabIndex = 9
        Me.lblDepartment.Text = "Unit Asal"
        Me.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueAsal
        '
        Me.lueAsal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueAsal.Location = New System.Drawing.Point(83, 29)
        Me.lueAsal.Margin = New System.Windows.Forms.Padding(0)
        Me.lueAsal.Name = "lueAsal"
        Me.lueAsal.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueAsal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueAsal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueAsal.Properties.Appearance.Options.UseBackColor = True
        Me.lueAsal.Properties.Appearance.Options.UseFont = True
        Me.lueAsal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueAsal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueAsal.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueAsal.Properties.NullText = "[Isian belum dipilih]"
        Me.lueAsal.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueAsal.Size = New System.Drawing.Size(200, 20)
        Me.lueAsal.TabIndex = 48
        Me.lueAsal.Tag = "idbusinesspartner"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(330, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 14)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Tanggal"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pRightBar
        '
        Me.pRightBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pRightBar.Controls.Add(Me.xtcItem)
        Me.pRightBar.Dock = System.Windows.Forms.DockStyle.Right
        Me.pRightBar.Location = New System.Drawing.Point(536, 30)
        Me.pRightBar.Margin = New System.Windows.Forms.Padding(0)
        Me.pRightBar.Name = "pRightBar"
        Me.pRightBar.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.pRightBar.Size = New System.Drawing.Size(250, 348)
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
        Me.xtcItem.SelectedTabPage = Me.xtpItem
        Me.xtcItem.Size = New System.Drawing.Size(246, 348)
        Me.xtcItem.TabIndex = 11
        Me.xtcItem.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpItem})
        '
        'xtpItem
        '
        Me.xtpItem.Controls.Add(Me.gcItem)
        Me.xtpItem.Controls.Add(Me.pItem)
        Me.xtpItem.Name = "xtpItem"
        Me.xtpItem.Size = New System.Drawing.Size(238, 318)
        Me.xtpItem.Text = "Daftar Item"
        '
        'gcItem
        '
        Me.gcItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcItem.Location = New System.Drawing.Point(0, 0)
        Me.gcItem.MainView = Me.gvItem
        Me.gcItem.Name = "gcItem"
        Me.gcItem.Size = New System.Drawing.Size(238, 288)
        Me.gcItem.TabIndex = 11
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
        Me.gvItem.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn3})
        Me.gvItem.GridControl = Me.gcItem
        Me.gvItem.Name = "gvItem"
        Me.gvItem.OptionsSelection.MultiSelect = True
        Me.gvItem.OptionsView.ShowGroupPanel = False
        Me.gvItem.PreviewFieldName = "note"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ID"
        Me.GridColumn1.FieldName = "id"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Item"
        Me.GridColumn3.FieldName = "item"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        Me.GridColumn3.Width = 63
        '
        'pItem
        '
        Me.pItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pItem.Controls.Add(Me.btnItemSelect)
        Me.pItem.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pItem.ForeColor = System.Drawing.Color.White
        Me.pItem.Location = New System.Drawing.Point(0, 288)
        Me.pItem.Margin = New System.Windows.Forms.Padding(0)
        Me.pItem.Name = "pItem"
        Me.pItem.Size = New System.Drawing.Size(238, 30)
        Me.pItem.TabIndex = 12
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
        Me.btnItemSelect.Location = New System.Drawing.Point(138, 0)
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
        Me.pHeader.Size = New System.Drawing.Size(786, 30)
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
        Me.btnSearch.Location = New System.Drawing.Point(506, 0)
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
        Me.btnNew.Location = New System.Drawing.Point(566, 0)
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
        Me.btnSave.Location = New System.Drawing.Point(626, 0)
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
        Me.btnDelete.Location = New System.Drawing.Point(706, 0)
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
        'frmMutasiBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.ClientSize = New System.Drawing.Size(790, 408)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMutasiBarang"
        Me.ShowInTaskbar = False
        Me.Text = "Mutasi Barang"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpField.ResumeLayout(False)
        Me.tlpField.PerformLayout()
        CType(Me.lueTujuan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teKode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueAsal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pRightBar.ResumeLayout(False)
        CType(Me.xtcItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcItem.ResumeLayout(False)
        Me.xtpItem.ResumeLayout(False)
        CType(Me.gcItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvItem, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents teKode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gcSatuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueAsal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents gcType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcitemtype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcidsatuan As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents pRightBar As System.Windows.Forms.Panel
    Friend WithEvents xtcItem As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpItem As DevExpress.XtraTab.XtraTabPage
    Public WithEvents pItem As System.Windows.Forms.Panel
    Public WithEvents btnItemSelect As System.Windows.Forms.Button
    Public WithEvents gcItem As DevExpress.XtraGrid.GridControl
    Public WithEvents gvItem As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents deTanggal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents gcQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents seQty As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents teNote As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lueTujuan As DevExpress.XtraEditors.LookUpEdit
End Class
