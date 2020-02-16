<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDiagnosaKerja
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
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.pBody = New System.Windows.Forms.Panel()
        Me.gcICD = New DevExpress.XtraGrid.GridControl()
        Me.gvICD = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tlppDK = New System.Windows.Forms.TableLayoutPanel()
        Me.meRemarks = New DevExpress.XtraEditors.MemoEdit()
        Me.lueDiagnosa = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.meDiagnosa = New DevExpress.XtraEditors.MemoEdit()
        Me.slueKode = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.slueView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.lblParent = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.lueType = New DevExpress.XtraEditors.LookUpEdit()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.btnBaruICD = New System.Windows.Forms.Button()
        Me.btnSimpanICD = New System.Windows.Forms.Button()
        Me.btnDeleteICD = New System.Windows.Forms.Button()
        Me.lblSep5 = New System.Windows.Forms.Label()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBody.SuspendLayout()
        CType(Me.gcICD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvICD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlppDK.SuspendLayout()
        CType(Me.meRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueDiagnosa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.meDiagnosa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueKode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel13.SuspendLayout()
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
        Me.lblTitle.Size = New System.Drawing.Size(756, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Diagnosa Kerja"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.pBody.Controls.Add(Me.gcICD)
        Me.pBody.Controls.Add(Me.tlppDK)
        Me.pBody.Controls.Add(Me.Panel13)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(786, 378)
        Me.pBody.TabIndex = 7
        '
        'gcICD
        '
        Me.gcICD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcICD.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.gcICD.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gcICD.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.gcICD.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gcICD.EmbeddedNavigator.Buttons.First.Visible = False
        Me.gcICD.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.gcICD.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.gcICD.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.gcICD.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.gcICD.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.gcICD.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(0)
        Me.gcICD.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.None
        Me.gcICD.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gcICD.Location = New System.Drawing.Point(0, 138)
        Me.gcICD.MainView = Me.gvICD
        Me.gcICD.Margin = New System.Windows.Forms.Padding(0)
        Me.gcICD.Name = "gcICD"
        Me.gcICD.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1})
        Me.gcICD.Size = New System.Drawing.Size(786, 240)
        Me.gcICD.TabIndex = 109
        Me.gcICD.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvICD})
        '
        'gvICD
        '
        Me.gvICD.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gvICD.Appearance.Empty.Options.UseBackColor = True
        Me.gvICD.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvICD.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvICD.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gvICD.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvICD.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvICD.Appearance.OddRow.Options.UseBackColor = True
        Me.gvICD.Appearance.Preview.BackColor = System.Drawing.Color.Black
        Me.gvICD.Appearance.Preview.ForeColor = System.Drawing.Color.White
        Me.gvICD.Appearance.Preview.Options.UseBackColor = True
        Me.gvICD.Appearance.Preview.Options.UseForeColor = True
        Me.gvICD.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gvICD.Appearance.Row.Options.UseFont = True
        Me.gvICD.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvICD.Appearance.TopNewRow.Options.UseBackColor = True
        Me.gvICD.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19})
        Me.gvICD.GridControl = Me.gcICD
        Me.gvICD.Name = "gvICD"
        Me.gvICD.NewItemRowText = "Tambah Data Disini"
        Me.gvICD.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
        Me.gvICD.OptionsView.EnableAppearanceEvenRow = True
        Me.gvICD.OptionsView.EnableAppearanceOddRow = True
        Me.gvICD.OptionsView.RowAutoHeight = True
        Me.gvICD.OptionsView.ShowGroupPanel = False
        Me.gvICD.OptionsView.ShowPreview = True
        Me.gvICD.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.[True]
        Me.gvICD.OptionsView.ShowViewCaption = True
        Me.gvICD.PreviewFieldName = "jnsdiagnosa"
        Me.gvICD.ViewCaption = "Kode ICD"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "idrmdt"
        Me.GridColumn1.FieldName = "idanalisarmdt"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "id"
        Me.GridColumn11.FieldName = "iddiagnosa"
        Me.GridColumn11.Name = "GridColumn11"
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "GridColumn11"
        Me.GridColumn12.FieldName = "idicd"
        Me.GridColumn12.Name = "GridColumn12"
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "GridColumn10"
        Me.GridColumn13.FieldName = "icdtype"
        Me.GridColumn13.Name = "GridColumn13"
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "GridColumn12"
        Me.GridColumn14.FieldName = "isdeleted"
        Me.GridColumn14.Name = "GridColumn14"
        '
        'GridColumn15
        '
        Me.GridColumn15.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn15.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn15.Caption = "Jenis ICD"
        Me.GridColumn15.FieldName = "jenisicd"
        Me.GridColumn15.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.AllowEdit = False
        Me.GridColumn15.OptionsColumn.ReadOnly = True
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 0
        '
        'GridColumn16
        '
        Me.GridColumn16.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn16.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn16.Caption = "Kode"
        Me.GridColumn16.FieldName = "kode"
        Me.GridColumn16.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.AllowEdit = False
        Me.GridColumn16.OptionsColumn.ReadOnly = True
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 1
        '
        'GridColumn17
        '
        Me.GridColumn17.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn17.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn17.Caption = "Diagnosa"
        Me.GridColumn17.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.GridColumn17.FieldName = "diagnosa"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.AllowEdit = False
        Me.GridColumn17.OptionsColumn.ReadOnly = True
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 2
        Me.GridColumn17.Width = 318
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        Me.RepositoryItemMemoEdit1.ReadOnly = True
        '
        'GridColumn18
        '
        Me.GridColumn18.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn18.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn18.Caption = "Remarks"
        Me.GridColumn18.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.GridColumn18.FieldName = "remarks"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.OptionsColumn.AllowEdit = False
        Me.GridColumn18.OptionsColumn.ReadOnly = True
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 3
        Me.GridColumn18.Width = 150
        '
        'GridColumn19
        '
        Me.GridColumn19.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn19.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn19.Caption = "Status Data"
        Me.GridColumn19.FieldName = "statdata"
        Me.GridColumn19.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.OptionsColumn.AllowEdit = False
        Me.GridColumn19.OptionsColumn.ReadOnly = True
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 3
        Me.GridColumn19.Width = 93
        '
        'tlppDK
        '
        Me.tlppDK.AutoSize = True
        Me.tlppDK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlppDK.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlppDK.ColumnCount = 6
        Me.tlppDK.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlppDK.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlppDK.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 330.0!))
        Me.tlppDK.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlppDK.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220.0!))
        Me.tlppDK.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlppDK.Controls.Add(Me.meRemarks, 4, 3)
        Me.tlppDK.Controls.Add(Me.lueDiagnosa, 2, 1)
        Me.tlppDK.Controls.Add(Me.Label80, 1, 1)
        Me.tlppDK.Controls.Add(Me.meDiagnosa, 2, 3)
        Me.tlppDK.Controls.Add(Me.slueKode, 4, 2)
        Me.tlppDK.Controls.Add(Me.Label81, 3, 3)
        Me.tlppDK.Controls.Add(Me.lblParent, 3, 2)
        Me.tlppDK.Controls.Add(Me.lblDepartment, 1, 3)
        Me.tlppDK.Controls.Add(Me.Label82, 1, 2)
        Me.tlppDK.Controls.Add(Me.lueType, 2, 2)
        Me.tlppDK.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlppDK.Location = New System.Drawing.Point(0, 30)
        Me.tlppDK.Margin = New System.Windows.Forms.Padding(0)
        Me.tlppDK.Name = "tlppDK"
        Me.tlppDK.RowCount = 5
        Me.tlppDK.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlppDK.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlppDK.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlppDK.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlppDK.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlppDK.Size = New System.Drawing.Size(786, 108)
        Me.tlppDK.TabIndex = 108
        '
        'meRemarks
        '
        Me.meRemarks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.meRemarks.Location = New System.Drawing.Point(548, 54)
        Me.meRemarks.Margin = New System.Windows.Forms.Padding(0)
        Me.meRemarks.Name = "meRemarks"
        Me.meRemarks.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.meRemarks.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.meRemarks.Properties.Appearance.Options.UseBackColor = True
        Me.meRemarks.Properties.Appearance.Options.UseFont = True
        Me.meRemarks.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.meRemarks.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.meRemarks.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.meRemarks.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.meRemarks.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.meRemarks.Size = New System.Drawing.Size(220, 48)
        Me.meRemarks.TabIndex = 22
        Me.meRemarks.Tag = ""
        '
        'lueDiagnosa
        '
        Me.lueDiagnosa.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueDiagnosa.Location = New System.Drawing.Point(118, 8)
        Me.lueDiagnosa.Margin = New System.Windows.Forms.Padding(0)
        Me.lueDiagnosa.Name = "lueDiagnosa"
        Me.lueDiagnosa.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueDiagnosa.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueDiagnosa.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueDiagnosa.Properties.Appearance.Options.UseBackColor = True
        Me.lueDiagnosa.Properties.Appearance.Options.UseFont = True
        Me.lueDiagnosa.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueDiagnosa.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.lueDiagnosa.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueDiagnosa.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.lueDiagnosa.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueDiagnosa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDiagnosa.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueDiagnosa.Properties.NullText = "[Isian belum dipilih]"
        Me.lueDiagnosa.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueDiagnosa.Size = New System.Drawing.Size(150, 20)
        Me.lueDiagnosa.TabIndex = 49
        Me.lueDiagnosa.Tag = ""
        '
        'Label80
        '
        Me.Label80.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label80.AutoSize = True
        Me.Label80.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.Location = New System.Drawing.Point(30, 11)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(85, 14)
        Me.Label80.TabIndex = 22
        Me.Label80.Text = "Jenis Diagnosa"
        Me.Label80.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'meDiagnosa
        '
        Me.meDiagnosa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.meDiagnosa.Location = New System.Drawing.Point(118, 54)
        Me.meDiagnosa.Margin = New System.Windows.Forms.Padding(0)
        Me.meDiagnosa.Name = "meDiagnosa"
        Me.meDiagnosa.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.meDiagnosa.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.meDiagnosa.Properties.Appearance.Options.UseBackColor = True
        Me.meDiagnosa.Properties.Appearance.Options.UseFont = True
        Me.meDiagnosa.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.meDiagnosa.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.meDiagnosa.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.meDiagnosa.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.meDiagnosa.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.meDiagnosa.Properties.ReadOnly = True
        Me.meDiagnosa.Size = New System.Drawing.Size(330, 48)
        Me.meDiagnosa.TabIndex = 21
        Me.meDiagnosa.Tag = ""
        '
        'slueKode
        '
        Me.slueKode.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.slueKode.Location = New System.Drawing.Point(548, 32)
        Me.slueKode.Margin = New System.Windows.Forms.Padding(0)
        Me.slueKode.Name = "slueKode"
        Me.slueKode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.slueKode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.slueKode.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.slueKode.Properties.Appearance.Options.UseBackColor = True
        Me.slueKode.Properties.Appearance.Options.UseFont = True
        Me.slueKode.Properties.Appearance.Options.UseForeColor = True
        Me.slueKode.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.slueKode.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.slueKode.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.slueKode.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.slueKode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.slueKode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueKode.Properties.NullText = "[Isian belum dipilih]"
        Me.slueKode.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.slueKode.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Simple
        Me.slueKode.Properties.PopupFindMode = DevExpress.XtraEditors.FindMode.Always
        Me.slueKode.Properties.PopupView = Me.slueView
        Me.slueKode.Properties.ShowFooter = False
        Me.slueKode.Properties.ShowPopupShadow = False
        Me.slueKode.Properties.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView
        Me.slueKode.Size = New System.Drawing.Size(150, 20)
        Me.slueKode.TabIndex = 25
        '
        'slueView
        '
        Me.slueView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.slueView.Appearance.EvenRow.Options.UseBackColor = True
        Me.slueView.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.slueView.Appearance.OddRow.Options.UseBackColor = True
        Me.slueView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn8, Me.GridColumn9, Me.GridColumn10})
        Me.slueView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.slueView.Name = "slueView"
        Me.slueView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.slueView.OptionsView.EnableAppearanceEvenRow = True
        Me.slueView.OptionsView.EnableAppearanceOddRow = True
        Me.slueView.OptionsView.ShowGroupPanel = False
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "ID"
        Me.GridColumn8.FieldName = "id"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Kode"
        Me.GridColumn9.FieldName = "kode"
        Me.GridColumn9.MinWidth = 60
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.OptionsColumn.ReadOnly = True
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 0
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Diagnosa"
        Me.GridColumn10.FieldName = "diagnosa"
        Me.GridColumn10.MinWidth = 120
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.OptionsColumn.ReadOnly = True
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 1
        Me.GridColumn10.Width = 120
        '
        'Label81
        '
        Me.Label81.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label81.AutoSize = True
        Me.Label81.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.Location = New System.Drawing.Point(493, 71)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(52, 14)
        Me.Label81.TabIndex = 22
        Me.Label81.Text = "Remarks"
        Me.Label81.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblParent
        '
        Me.lblParent.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblParent.AutoSize = True
        Me.lblParent.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParent.Location = New System.Drawing.Point(510, 35)
        Me.lblParent.Name = "lblParent"
        Me.lblParent.Size = New System.Drawing.Size(35, 14)
        Me.lblParent.TabIndex = 20
        Me.lblParent.Text = "Kode"
        Me.lblParent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDepartment
        '
        Me.lblDepartment.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.Location = New System.Drawing.Point(60, 71)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(55, 14)
        Me.lblDepartment.TabIndex = 9
        Me.lblDepartment.Text = "Diagnosa"
        Me.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label82
        '
        Me.Label82.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label82.AutoSize = True
        Me.Label82.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.Location = New System.Drawing.Point(59, 35)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(56, 14)
        Me.Label82.TabIndex = 21
        Me.Label82.Text = "Jenis ICD"
        Me.Label82.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueType
        '
        Me.lueType.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueType.Location = New System.Drawing.Point(118, 32)
        Me.lueType.Margin = New System.Windows.Forms.Padding(0)
        Me.lueType.Name = "lueType"
        Me.lueType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueType.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueType.Properties.Appearance.Options.UseBackColor = True
        Me.lueType.Properties.Appearance.Options.UseFont = True
        Me.lueType.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueType.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.lueType.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueType.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.lueType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueType.Properties.NullText = "[Isian belum dipilih]"
        Me.lueType.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueType.Size = New System.Drawing.Size(150, 20)
        Me.lueType.TabIndex = 48
        Me.lueType.Tag = ""
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel13.Controls.Add(Me.btnBaruICD)
        Me.Panel13.Controls.Add(Me.btnSimpanICD)
        Me.Panel13.Controls.Add(Me.btnDeleteICD)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel13.ForeColor = System.Drawing.Color.White
        Me.Panel13.Location = New System.Drawing.Point(0, 0)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(786, 30)
        Me.Panel13.TabIndex = 107
        '
        'btnBaruICD
        '
        Me.btnBaruICD.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBaruICD.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnBaruICD.FlatAppearance.BorderSize = 0
        Me.btnBaruICD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnBaruICD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnBaruICD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBaruICD.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBaruICD.Location = New System.Drawing.Point(546, 0)
        Me.btnBaruICD.Name = "btnBaruICD"
        Me.btnBaruICD.Size = New System.Drawing.Size(80, 30)
        Me.btnBaruICD.TabIndex = 12
        Me.btnBaruICD.Text = "BARU"
        Me.btnBaruICD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBaruICD.UseVisualStyleBackColor = False
        '
        'btnSimpanICD
        '
        Me.btnSimpanICD.BackColor = System.Drawing.Color.green
        Me.btnSimpanICD.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSimpanICD.FlatAppearance.BorderSize = 0
        Me.btnSimpanICD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnSimpanICD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnSimpanICD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpanICD.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpanICD.Location = New System.Drawing.Point(626, 0)
        Me.btnSimpanICD.Name = "btnSimpanICD"
        Me.btnSimpanICD.Size = New System.Drawing.Size(80, 30)
        Me.btnSimpanICD.TabIndex = 11
        Me.btnSimpanICD.Text = "SIMPAN"
        Me.btnSimpanICD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSimpanICD.UseVisualStyleBackColor = False
        '
        'btnDeleteICD
        '
        Me.btnDeleteICD.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDeleteICD.FlatAppearance.BorderSize = 0
        Me.btnDeleteICD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnDeleteICD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnDeleteICD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteICD.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteICD.Location = New System.Drawing.Point(706, 0)
        Me.btnDeleteICD.Name = "btnDeleteICD"
        Me.btnDeleteICD.Size = New System.Drawing.Size(80, 30)
        Me.btnDeleteICD.TabIndex = 13
        Me.btnDeleteICD.Text = "HAPUS"
        Me.btnDeleteICD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeleteICD.UseVisualStyleBackColor = True
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
        'frmDiagnosaKerja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(790, 408)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDiagnosaKerja"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Diagnosa Kerja"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        Me.pBody.PerformLayout()
        CType(Me.gcICD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvICD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlppDK.ResumeLayout(False)
        Me.tlppDK.PerformLayout()
        CType(Me.meRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueDiagnosa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.meDiagnosa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueKode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel13.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblSep5 As System.Windows.Forms.Label
    Public WithEvents pBody As System.Windows.Forms.Panel
    Public WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Public WithEvents Panel13 As Panel
    Public WithEvents btnBaruICD As Button
    Public WithEvents btnSimpanICD As Button
    Public WithEvents btnDeleteICD As Button
    Public WithEvents tlppDK As TableLayoutPanel
    Friend WithEvents meRemarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lueDiagnosa As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label80 As Label
    Friend WithEvents meDiagnosa As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents slueKode As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents slueView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label81 As Label
    Friend WithEvents lblParent As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents Label82 As Label
    Friend WithEvents lueType As DevExpress.XtraEditors.LookUpEdit
    Public WithEvents gcICD As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvICD As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
