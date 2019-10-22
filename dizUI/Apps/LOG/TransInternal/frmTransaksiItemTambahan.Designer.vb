<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTransaksiItemTambahan
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
        Me.tlpField = New System.Windows.Forms.TableLayoutPanel()
        Me.teGrup = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lueItem = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.slueView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.teSatuan = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.teKode = New DevExpress.XtraEditors.TextEdit()
        Me.lblKaryawan = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.teType = New DevExpress.XtraEditors.TextEdit()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.teSearch = New DevExpress.XtraEditors.TextEdit()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBody.SuspendLayout()
        Me.tlpField.SuspendLayout()
        CType(Me.teGrup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teSatuan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teKode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeader.SuspendLayout()
        CType(Me.teSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpForm
        '
        Me.tlpForm.BackColor = System.Drawing.Color.DarkGreen
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
        Me.tlpForm.Size = New System.Drawing.Size(402, 194)
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
        Me.pTitle.Size = New System.Drawing.Size(398, 30)
        Me.pTitle.TabIndex = 36
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.DarkGreen
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(308, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Item Tambahan"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pMinimize
        '
        Me.pMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.pMinimize.Image = Global.dizUI.My.Resources.Resources.min_w
        Me.pMinimize.Location = New System.Drawing.Point(308, 0)
        Me.pMinimize.Margin = New System.Windows.Forms.Padding(0)
        Me.pMinimize.Name = "pMinimize"
        Me.pMinimize.Size = New System.Drawing.Size(30, 30)
        Me.pMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pMinimize.TabIndex = 12
        Me.pMinimize.TabStop = False
        '
        'pMaximize
        '
        Me.pMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pMaximize.Dock = System.Windows.Forms.DockStyle.Right
        Me.pMaximize.Image = Global.dizUI.My.Resources.Resources.max_w
        Me.pMaximize.Location = New System.Drawing.Point(338, 0)
        Me.pMaximize.Margin = New System.Windows.Forms.Padding(0)
        Me.pMaximize.Name = "pMaximize"
        Me.pMaximize.Size = New System.Drawing.Size(30, 30)
        Me.pMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pMaximize.TabIndex = 11
        Me.pMaximize.TabStop = False
        '
        'pExit
        '
        Me.pExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.pExit.Image = Global.dizUI.My.Resources.Resources.exit_w
        Me.pExit.Location = New System.Drawing.Point(368, 0)
        Me.pExit.Margin = New System.Windows.Forms.Padding(0)
        Me.pExit.Name = "pExit"
        Me.pExit.Size = New System.Drawing.Size(30, 30)
        Me.pExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pExit.TabIndex = 10
        Me.pExit.TabStop = False
        '
        'pBody
        '
        Me.pBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pBody.Controls.Add(Me.tlpField)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(398, 162)
        Me.pBody.TabIndex = 7
        '
        'tlpField
        '
        Me.tlpField.AutoSize = True
        Me.tlpField.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpField.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlpField.ColumnCount = 4
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.Controls.Add(Me.teGrup, 2, 2)
        Me.tlpField.Controls.Add(Me.Label3, 1, 2)
        Me.tlpField.Controls.Add(Me.lueItem, 2, 4)
        Me.tlpField.Controls.Add(Me.teSatuan, 2, 5)
        Me.tlpField.Controls.Add(Me.Label2, 1, 5)
        Me.tlpField.Controls.Add(Me.Label1, 1, 3)
        Me.tlpField.Controls.Add(Me.teKode, 2, 1)
        Me.tlpField.Controls.Add(Me.lblKaryawan, 1, 1)
        Me.tlpField.Controls.Add(Me.Label8, 1, 4)
        Me.tlpField.Controls.Add(Me.teType, 2, 3)
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
        Me.tlpField.Size = New System.Drawing.Size(398, 132)
        Me.tlpField.TabIndex = 7
        '
        'teGrup
        '
        Me.teGrup.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teGrup.Location = New System.Drawing.Point(124, 32)
        Me.teGrup.Margin = New System.Windows.Forms.Padding(0)
        Me.teGrup.Name = "teGrup"
        Me.teGrup.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teGrup.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teGrup.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teGrup.Properties.Appearance.Options.UseBackColor = True
        Me.teGrup.Properties.Appearance.Options.UseFont = True
        Me.teGrup.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teGrup.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teGrup.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teGrup.Properties.AppearanceDisabled.Options.UseFont = True
        Me.teGrup.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teGrup.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teGrup.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teGrup.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.teGrup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teGrup.Properties.MaxLength = 300
        Me.teGrup.Properties.NullText = "[Belum Diisi]"
        Me.teGrup.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teGrup.Properties.ReadOnly = True
        Me.teGrup.Size = New System.Drawing.Size(180, 20)
        Me.teGrup.TabIndex = 20
        Me.teGrup.Tag = "namapasien"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(88, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 14)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Grup"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueItem
        '
        Me.lueItem.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueItem.Location = New System.Drawing.Point(124, 80)
        Me.lueItem.Margin = New System.Windows.Forms.Padding(0)
        Me.lueItem.Name = "lueItem"
        Me.lueItem.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueItem.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueItem.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lueItem.Properties.Appearance.Options.UseBackColor = True
        Me.lueItem.Properties.Appearance.Options.UseFont = True
        Me.lueItem.Properties.Appearance.Options.UseForeColor = True
        Me.lueItem.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueItem.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueItem.Properties.NullText = "[Isian belum dipilih]"
        Me.lueItem.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueItem.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Simple
        Me.lueItem.Properties.PopupFindMode = DevExpress.XtraEditors.FindMode.Always
        Me.lueItem.Properties.PopupView = Me.slueView
        Me.lueItem.Properties.ShowFooter = False
        Me.lueItem.Properties.ShowPopupShadow = False
        Me.lueItem.Properties.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView
        Me.lueItem.Size = New System.Drawing.Size(234, 20)
        Me.lueItem.TabIndex = 48
        Me.lueItem.Tag = "reffid"
        '
        'slueView
        '
        Me.slueView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.slueView.Appearance.EvenRow.Options.UseBackColor = True
        Me.slueView.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.slueView.Appearance.OddRow.Options.UseBackColor = True
        Me.slueView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn13, Me.GridColumn14, Me.GridColumn1})
        Me.slueView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.slueView.Name = "slueView"
        Me.slueView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.slueView.OptionsView.EnableAppearanceEvenRow = True
        Me.slueView.OptionsView.EnableAppearanceOddRow = True
        Me.slueView.OptionsView.ShowGroupPanel = False
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "ID"
        Me.GridColumn13.FieldName = "id"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        Me.GridColumn13.OptionsColumn.ReadOnly = True
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Content"
        Me.GridColumn14.FieldName = "content"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.AllowEdit = False
        Me.GridColumn14.OptionsColumn.ReadOnly = True
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 0
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Type"
        Me.GridColumn1.FieldName = "itemtype"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        '
        'teSatuan
        '
        Me.teSatuan.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teSatuan.Location = New System.Drawing.Point(124, 104)
        Me.teSatuan.Margin = New System.Windows.Forms.Padding(0)
        Me.teSatuan.Name = "teSatuan"
        Me.teSatuan.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teSatuan.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teSatuan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teSatuan.Properties.Appearance.Options.UseBackColor = True
        Me.teSatuan.Properties.Appearance.Options.UseFont = True
        Me.teSatuan.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teSatuan.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teSatuan.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teSatuan.Properties.AppearanceDisabled.Options.UseFont = True
        Me.teSatuan.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teSatuan.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teSatuan.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teSatuan.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.teSatuan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teSatuan.Properties.MaxLength = 300
        Me.teSatuan.Properties.NullText = "[Belum Diisi]"
        Me.teSatuan.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teSatuan.Properties.ReadOnly = True
        Me.teSatuan.Size = New System.Drawing.Size(180, 20)
        Me.teSatuan.TabIndex = 20
        Me.teSatuan.Tag = "namapasien"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(76, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 14)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Satuan"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(86, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 14)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Type"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teKode
        '
        Me.teKode.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teKode.Location = New System.Drawing.Point(124, 8)
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
        Me.teKode.Size = New System.Drawing.Size(180, 20)
        Me.teKode.TabIndex = 21
        Me.teKode.Tag = "namapanggilan"
        '
        'lblKaryawan
        '
        Me.lblKaryawan.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblKaryawan.AutoSize = True
        Me.lblKaryawan.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKaryawan.Location = New System.Drawing.Point(86, 11)
        Me.lblKaryawan.Name = "lblKaryawan"
        Me.lblKaryawan.Size = New System.Drawing.Size(35, 14)
        Me.lblKaryawan.TabIndex = 9
        Me.lblKaryawan.Text = "Kode"
        Me.lblKaryawan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(54, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 14)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Nama Item"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teType
        '
        Me.teType.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teType.Location = New System.Drawing.Point(124, 56)
        Me.teType.Margin = New System.Windows.Forms.Padding(0)
        Me.teType.Name = "teType"
        Me.teType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teType.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teType.Properties.Appearance.Options.UseBackColor = True
        Me.teType.Properties.Appearance.Options.UseFont = True
        Me.teType.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teType.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teType.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teType.Properties.AppearanceDisabled.Options.UseFont = True
        Me.teType.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teType.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teType.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teType.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.teType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teType.Properties.MaxLength = 300
        Me.teType.Properties.NullText = "[Belum Diisi]"
        Me.teType.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teType.Properties.ReadOnly = True
        Me.teType.Size = New System.Drawing.Size(180, 20)
        Me.teType.TabIndex = 19
        Me.teType.Tag = "namapasien"
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Controls.Add(Me.Label6)
        Me.pHeader.Controls.Add(Me.teSearch)
        Me.pHeader.Controls.Add(Me.btnSave)
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.ForeColor = System.Drawing.Color.White
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(398, 30)
        Me.pHeader.TabIndex = 4
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
        Me.btnSave.Location = New System.Drawing.Point(318, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "SIMPAN"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(67, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 14)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Scan"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teSearch
        '
        Me.teSearch.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.teSearch.EditValue = ""
        Me.teSearch.Location = New System.Drawing.Point(103, 4)
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
        Me.teSearch.TabIndex = 24
        Me.teSearch.Tag = ""
        '
        'frmTransaksiItemTambahan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(402, 194)
        Me.ControlBox = False
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTransaksiItemTambahan"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Tambahan"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        Me.pBody.PerformLayout()
        Me.tlpField.ResumeLayout(False)
        Me.tlpField.PerformLayout()
        CType(Me.teGrup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teSatuan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teKode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        Me.pHeader.PerformLayout()
        CType(Me.teSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents pHeader As System.Windows.Forms.Panel
    Public WithEvents pBody As System.Windows.Forms.Panel
    Public WithEvents tlpField As System.Windows.Forms.TableLayoutPanel
    Public WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblKaryawan As System.Windows.Forms.Label
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Label1 As Label
    Friend WithEvents teKode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teType As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label8 As Label
    Public WithEvents btnSave As Button
    Friend WithEvents pExit As PictureBox
    Friend WithEvents pMinimize As PictureBox
    Friend WithEvents pMaximize As PictureBox
    Friend WithEvents teSatuan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents lueItem As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents slueView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents teGrup As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As Label
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents teSearch As DevExpress.XtraEditors.TextEdit
End Class
