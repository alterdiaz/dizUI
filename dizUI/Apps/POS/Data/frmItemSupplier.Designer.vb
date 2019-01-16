<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemSupplier
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
        Me.gcdisctype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcidsupplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gciditem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcisdeleted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcKode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcNama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcsupplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcprice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcdiscpercent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcdiscamount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcStatData = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tlpField = New System.Windows.Forms.TableLayoutPanel()
        Me.lueItem = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.seDiscAmount = New DevExpress.XtraEditors.SpinEdit()
        Me.seDiscPercent = New DevExpress.XtraEditors.SpinEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.teKode = New DevExpress.XtraEditors.TextEdit()
        Me.lblParent = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.lblKode = New System.Windows.Forms.Label()
        Me.lueType = New DevExpress.XtraEditors.LookUpEdit()
        Me.sePrice = New DevExpress.XtraEditors.SpinEdit()
        Me.lueSupplier = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pHeader = New System.Windows.Forms.Panel()
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
        Me.tlpField.SuspendLayout()
        CType(Me.lueItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seDiscAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seDiscPercent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teKode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sePrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblTitle.Text = "Item Supplier"
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
        Me.gcData.Location = New System.Drawing.Point(0, 134)
        Me.gcData.MainView = Me.gvData
        Me.gcData.Name = "gcData"
        Me.gcData.Size = New System.Drawing.Size(786, 244)
        Me.gcData.TabIndex = 8
        Me.gcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvData})
        '
        'gvData
        '
        Me.gvData.Appearance.Empty.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.gvData.Appearance.Empty.Options.UseBackColor = True
        Me.gvData.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.Row.Options.UseBackColor = True
        Me.gvData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcID, Me.gcdisctype, Me.gcidsupplier, Me.gciditem, Me.gcisdeleted, Me.gcType, Me.gcKode, Me.gcNama, Me.gcsupplier, Me.gcprice, Me.gcdiscpercent, Me.gcdiscamount, Me.gcStatData})
        Me.gvData.GridControl = Me.gcData
        Me.gvData.Name = "gvData"
        Me.gvData.OptionsView.ShowGroupPanel = False
        '
        'gcID
        '
        Me.gcID.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gcID.AppearanceCell.Options.UseBackColor = True
        Me.gcID.Caption = "ID"
        Me.gcID.FieldName = "iditemsupplier"
        Me.gcID.Name = "gcID"
        Me.gcID.OptionsColumn.AllowEdit = False
        Me.gcID.OptionsColumn.ReadOnly = True
        '
        'gcdisctype
        '
        Me.gcdisctype.Caption = "disctype"
        Me.gcdisctype.FieldName = "disctype"
        Me.gcdisctype.Name = "gcdisctype"
        '
        'gcidsupplier
        '
        Me.gcidsupplier.Caption = "idsupplier"
        Me.gcidsupplier.FieldName = "idsupplier"
        Me.gcidsupplier.Name = "gcidsupplier"
        '
        'gciditem
        '
        Me.gciditem.Caption = "gciditem"
        Me.gciditem.FieldName = "iditem"
        Me.gciditem.Name = "gciditem"
        '
        'gcisdeleted
        '
        Me.gcisdeleted.Caption = "isdeleted"
        Me.gcisdeleted.FieldName = "isdeleted"
        Me.gcisdeleted.Name = "gcisdeleted"
        Me.gcisdeleted.OptionsColumn.AllowEdit = False
        Me.gcisdeleted.OptionsColumn.ReadOnly = True
        '
        'gcType
        '
        Me.gcType.Caption = "Tipe Disc"
        Me.gcType.FieldName = "disctypestr"
        Me.gcType.Name = "gcType"
        Me.gcType.OptionsColumn.AllowEdit = False
        Me.gcType.OptionsColumn.ReadOnly = True
        Me.gcType.Visible = True
        Me.gcType.VisibleIndex = 4
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
        Me.gcKode.VisibleIndex = 0
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
        Me.gcNama.VisibleIndex = 1
        '
        'gcsupplier
        '
        Me.gcsupplier.Caption = "Supplier"
        Me.gcsupplier.FieldName = "nama"
        Me.gcsupplier.Name = "gcsupplier"
        Me.gcsupplier.OptionsColumn.AllowEdit = False
        Me.gcsupplier.OptionsColumn.ReadOnly = True
        Me.gcsupplier.Visible = True
        Me.gcsupplier.VisibleIndex = 2
        '
        'gcprice
        '
        Me.gcprice.Caption = "Harga"
        Me.gcprice.FieldName = "price"
        Me.gcprice.Name = "gcprice"
        Me.gcprice.OptionsColumn.AllowEdit = False
        Me.gcprice.OptionsColumn.ReadOnly = True
        Me.gcprice.Visible = True
        Me.gcprice.VisibleIndex = 3
        '
        'gcdiscpercent
        '
        Me.gcdiscpercent.Caption = "Persen Disc"
        Me.gcdiscpercent.FieldName = "discpersen"
        Me.gcdiscpercent.Name = "gcdiscpercent"
        Me.gcdiscpercent.OptionsColumn.AllowEdit = False
        Me.gcdiscpercent.OptionsColumn.ReadOnly = True
        Me.gcdiscpercent.Visible = True
        Me.gcdiscpercent.VisibleIndex = 5
        '
        'gcdiscamount
        '
        Me.gcdiscamount.Caption = "Besar Disc"
        Me.gcdiscamount.FieldName = "discamount"
        Me.gcdiscamount.Name = "gcdiscamount"
        Me.gcdiscamount.OptionsColumn.AllowEdit = False
        Me.gcdiscamount.OptionsColumn.ReadOnly = True
        Me.gcdiscamount.Visible = True
        Me.gcdiscamount.VisibleIndex = 6
        '
        'gcStatData
        '
        Me.gcStatData.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gcStatData.AppearanceCell.Options.UseBackColor = True
        Me.gcStatData.Caption = "Status Data"
        Me.gcStatData.FieldName = "statdata"
        Me.gcStatData.Name = "gcStatData"
        Me.gcStatData.OptionsColumn.AllowEdit = False
        Me.gcStatData.OptionsColumn.ReadOnly = True
        Me.gcStatData.Visible = True
        Me.gcStatData.VisibleIndex = 7
        '
        'tlpField
        '
        Me.tlpField.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.tlpField.ColumnCount = 6
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.Controls.Add(Me.lueItem, 2, 2)
        Me.tlpField.Controls.Add(Me.Label3, 3, 4)
        Me.tlpField.Controls.Add(Me.seDiscAmount, 4, 4)
        Me.tlpField.Controls.Add(Me.seDiscPercent, 2, 4)
        Me.tlpField.Controls.Add(Me.Label2, 1, 4)
        Me.tlpField.Controls.Add(Me.teKode, 2, 1)
        Me.tlpField.Controls.Add(Me.lblParent, 1, 1)
        Me.tlpField.Controls.Add(Me.lblDepartment, 1, 2)
        Me.tlpField.Controls.Add(Me.lblKode, 1, 3)
        Me.tlpField.Controls.Add(Me.lueType, 2, 3)
        Me.tlpField.Controls.Add(Me.sePrice, 4, 3)
        Me.tlpField.Controls.Add(Me.lueSupplier, 4, 2)
        Me.tlpField.Controls.Add(Me.Label1, 3, 3)
        Me.tlpField.Controls.Add(Me.Label5, 3, 2)
        Me.tlpField.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpField.Location = New System.Drawing.Point(0, 30)
        Me.tlpField.Name = "tlpField"
        Me.tlpField.RowCount = 6
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.Size = New System.Drawing.Size(786, 104)
        Me.tlpField.TabIndex = 7
        '
        'lueItem
        '
        Me.lueItem.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueItem.Location = New System.Drawing.Point(193, 30)
        Me.lueItem.Margin = New System.Windows.Forms.Padding(0)
        Me.lueItem.Name = "lueItem"
        Me.lueItem.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueItem.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueItem.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueItem.Properties.Appearance.Options.UseBackColor = True
        Me.lueItem.Properties.Appearance.Options.UseFont = True
        Me.lueItem.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueItem.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueItem.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueItem.Properties.NullText = "[Isian belum dipilih]"
        Me.lueItem.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueItem.Size = New System.Drawing.Size(200, 20)
        Me.lueItem.TabIndex = 49
        Me.lueItem.Tag = "iditem"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(469, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 14)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Besar Disc"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'seDiscAmount
        '
        Me.seDiscAmount.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.seDiscAmount.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seDiscAmount.Location = New System.Drawing.Point(533, 78)
        Me.seDiscAmount.Margin = New System.Windows.Forms.Padding(0)
        Me.seDiscAmount.Name = "seDiscAmount"
        Me.seDiscAmount.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.seDiscAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.seDiscAmount.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.seDiscAmount.Properties.Appearance.Options.UseBackColor = True
        Me.seDiscAmount.Properties.Appearance.Options.UseFont = True
        Me.seDiscAmount.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.seDiscAmount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.seDiscAmount.Properties.DisplayFormat.FormatString = "n2"
        Me.seDiscAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seDiscAmount.Properties.EditFormat.FormatString = "n2"
        Me.seDiscAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seDiscAmount.Properties.IsFloatValue = False
        Me.seDiscAmount.Properties.Mask.EditMask = "N00"
        Me.seDiscAmount.Properties.MaxLength = 11
        Me.seDiscAmount.Properties.MaxValue = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.seDiscAmount.Size = New System.Drawing.Size(150, 20)
        Me.seDiscAmount.TabIndex = 50
        Me.seDiscAmount.Tag = "discamount"
        '
        'seDiscPercent
        '
        Me.seDiscPercent.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.seDiscPercent.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seDiscPercent.Location = New System.Drawing.Point(193, 78)
        Me.seDiscPercent.Margin = New System.Windows.Forms.Padding(0)
        Me.seDiscPercent.Name = "seDiscPercent"
        Me.seDiscPercent.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.seDiscPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.seDiscPercent.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.seDiscPercent.Properties.Appearance.Options.UseBackColor = True
        Me.seDiscPercent.Properties.Appearance.Options.UseFont = True
        Me.seDiscPercent.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.seDiscPercent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.seDiscPercent.Properties.DisplayFormat.FormatString = "n0"
        Me.seDiscPercent.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seDiscPercent.Properties.EditFormat.FormatString = "n0"
        Me.seDiscPercent.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seDiscPercent.Properties.IsFloatValue = False
        Me.seDiscPercent.Properties.Mask.EditMask = "N00"
        Me.seDiscPercent.Properties.MaxLength = 3
        Me.seDiscPercent.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.seDiscPercent.Size = New System.Drawing.Size(57, 20)
        Me.seDiscPercent.TabIndex = 50
        Me.seDiscPercent.Tag = ""
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(121, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 14)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Persen Disc"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teKode
        '
        Me.teKode.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teKode.Location = New System.Drawing.Point(193, 6)
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
        Me.lblParent.Location = New System.Drawing.Point(125, 9)
        Me.lblParent.Name = "lblParent"
        Me.lblParent.Size = New System.Drawing.Size(65, 14)
        Me.lblParent.TabIndex = 20
        Me.lblParent.Text = "Kode Item"
        Me.lblParent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDepartment
        '
        Me.lblDepartment.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.Location = New System.Drawing.Point(157, 33)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(33, 14)
        Me.lblDepartment.TabIndex = 9
        Me.lblDepartment.Text = "Item"
        Me.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblKode
        '
        Me.lblKode.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblKode.AutoSize = True
        Me.lblKode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKode.Location = New System.Drawing.Point(134, 57)
        Me.lblKode.Name = "lblKode"
        Me.lblKode.Size = New System.Drawing.Size(56, 14)
        Me.lblKode.TabIndex = 18
        Me.lblKode.Text = "Tipe Disc"
        Me.lblKode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueType
        '
        Me.lueType.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueType.Location = New System.Drawing.Point(193, 54)
        Me.lueType.Margin = New System.Windows.Forms.Padding(0)
        Me.lueType.Name = "lueType"
        Me.lueType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueType.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueType.Properties.Appearance.Options.UseBackColor = True
        Me.lueType.Properties.Appearance.Options.UseFont = True
        Me.lueType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueType.Properties.NullText = "[Isian belum dipilih]"
        Me.lueType.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueType.Size = New System.Drawing.Size(150, 20)
        Me.lueType.TabIndex = 49
        Me.lueType.Tag = "disctype"
        '
        'sePrice
        '
        Me.sePrice.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.sePrice.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.sePrice.Location = New System.Drawing.Point(533, 54)
        Me.sePrice.Margin = New System.Windows.Forms.Padding(0)
        Me.sePrice.Name = "sePrice"
        Me.sePrice.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.sePrice.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sePrice.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sePrice.Properties.Appearance.Options.UseBackColor = True
        Me.sePrice.Properties.Appearance.Options.UseFont = True
        Me.sePrice.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.sePrice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.sePrice.Properties.DisplayFormat.FormatString = "n2"
        Me.sePrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sePrice.Properties.EditFormat.FormatString = "n2"
        Me.sePrice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sePrice.Properties.IsFloatValue = False
        Me.sePrice.Properties.Mask.EditMask = "N00"
        Me.sePrice.Properties.MaxLength = 11
        Me.sePrice.Properties.MaxValue = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.sePrice.Size = New System.Drawing.Size(150, 20)
        Me.sePrice.TabIndex = 49
        Me.sePrice.Tag = "price"
        '
        'lueSupplier
        '
        Me.lueSupplier.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueSupplier.Location = New System.Drawing.Point(533, 30)
        Me.lueSupplier.Margin = New System.Windows.Forms.Padding(0)
        Me.lueSupplier.Name = "lueSupplier"
        Me.lueSupplier.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueSupplier.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueSupplier.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueSupplier.Properties.Appearance.Options.UseBackColor = True
        Me.lueSupplier.Properties.Appearance.Options.UseFont = True
        Me.lueSupplier.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueSupplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueSupplier.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueSupplier.Properties.NullText = "[Isian belum dipilih]"
        Me.lueSupplier.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueSupplier.Size = New System.Drawing.Size(200, 20)
        Me.lueSupplier.TabIndex = 48
        Me.lueSupplier.Tag = "idsupplier"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(492, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 14)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Harga"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(480, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 14)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Supplier"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.pHeader.Size = New System.Drawing.Size(786, 30)
        Me.pHeader.TabIndex = 4
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
        Me.btnDelete.Text = "HAPUS"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = True
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
        'frmItemSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.ClientSize = New System.Drawing.Size(790, 408)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmItemSupplier"
        Me.ShowInTaskbar = False
        Me.Text = "Item Supplier"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpField.ResumeLayout(False)
        Me.tlpField.PerformLayout()
        CType(Me.lueItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seDiscAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seDiscPercent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teKode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sePrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueSupplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblKode As System.Windows.Forms.Label
    Friend WithEvents gcKode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblParent As System.Windows.Forms.Label
    Friend WithEvents gcStatData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcisdeleted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Friend WithEvents teKode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lueSupplier As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents gcType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcdisctype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcidsupplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents seDiscAmount As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents seDiscPercent As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents sePrice As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gciditem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcsupplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcdiscpercent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcdiscamount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcprice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueItem As DevExpress.XtraEditors.LookUpEdit
End Class
