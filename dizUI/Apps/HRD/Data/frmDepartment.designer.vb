<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepartment
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
        Me.gcIDParent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcIDStatData = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcParent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcDepartment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcKDdepartment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcKDangka = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcStatData = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tlData = New DevExpress.XtraTreeList.TreeList()
        Me.tlcID = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlcIDParent = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlcIDStatData = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlcParent = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlcDepartment = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlcKode = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlcKodeAngka = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlcStatData = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlpField = New System.Windows.Forms.TableLayoutPanel()
        Me.teKodeAngka = New DevExpress.XtraEditors.TextEdit()
        Me.lblParent = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.teDepartment = New DevExpress.XtraEditors.TextEdit()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.lblKode = New System.Windows.Forms.Label()
        Me.lueParent = New DevExpress.XtraEditors.LookUpEdit()
        Me.teKode = New DevExpress.XtraEditors.TextEdit()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblSep5 = New System.Windows.Forms.Label()
        Me.xtcViewer = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage16 = New DevExpress.XtraTab.XtraTabPage()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBody.SuspendLayout()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tlData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpField.SuspendLayout()
        CType(Me.teKodeAngka.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teDepartment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueParent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teKode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeader.SuspendLayout()
        CType(Me.xtcViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcViewer.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage16.SuspendLayout()
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
        Me.lblTitle.Text = "Department"
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
        Me.pBody.Controls.Add(Me.xtcViewer)
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
        Me.gcData.Location = New System.Drawing.Point(0, 0)
        Me.gcData.MainView = Me.gvData
        Me.gcData.Name = "gcData"
        Me.gcData.Size = New System.Drawing.Size(737, 288)
        Me.gcData.TabIndex = 8
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
        Me.gvData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcID, Me.gcIDParent, Me.gcIDStatData, Me.gcParent, Me.gcDepartment, Me.gcKDdepartment, Me.gcKDangka, Me.gcStatData})
        Me.gvData.GridControl = Me.gcData
        Me.gvData.Name = "gvData"
        Me.gvData.OptionsView.EnableAppearanceEvenRow = True
        Me.gvData.OptionsView.EnableAppearanceOddRow = True
        Me.gvData.OptionsView.ShowGroupPanel = False
        '
        'gcID
        '
        Me.gcID.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gcID.AppearanceCell.Options.UseBackColor = True
        Me.gcID.AppearanceHeader.Options.UseTextOptions = True
        Me.gcID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcID.Caption = "ID"
        Me.gcID.FieldName = "iddepartment"
        Me.gcID.Name = "gcID"
        Me.gcID.OptionsColumn.AllowEdit = False
        Me.gcID.OptionsColumn.ReadOnly = True
        '
        'gcIDParent
        '
        Me.gcIDParent.AppearanceHeader.Options.UseTextOptions = True
        Me.gcIDParent.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcIDParent.Caption = "ID Parent"
        Me.gcIDParent.FieldName = "idparent"
        Me.gcIDParent.Name = "gcIDParent"
        Me.gcIDParent.OptionsColumn.AllowEdit = False
        Me.gcIDParent.OptionsColumn.ReadOnly = True
        '
        'gcIDStatData
        '
        Me.gcIDStatData.AppearanceHeader.Options.UseTextOptions = True
        Me.gcIDStatData.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcIDStatData.Caption = "ID Status Data"
        Me.gcIDStatData.FieldName = "statusdata"
        Me.gcIDStatData.Name = "gcIDStatData"
        Me.gcIDStatData.OptionsColumn.AllowEdit = False
        Me.gcIDStatData.OptionsColumn.ReadOnly = True
        '
        'gcParent
        '
        Me.gcParent.AppearanceHeader.Options.UseTextOptions = True
        Me.gcParent.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcParent.Caption = "Dept. Induk"
        Me.gcParent.FieldName = "induk"
        Me.gcParent.Name = "gcParent"
        Me.gcParent.OptionsColumn.AllowEdit = False
        Me.gcParent.OptionsColumn.ReadOnly = True
        Me.gcParent.Visible = True
        Me.gcParent.VisibleIndex = 0
        '
        'gcDepartment
        '
        Me.gcDepartment.AppearanceHeader.Options.UseTextOptions = True
        Me.gcDepartment.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcDepartment.Caption = "Department"
        Me.gcDepartment.FieldName = "department"
        Me.gcDepartment.Name = "gcDepartment"
        Me.gcDepartment.OptionsColumn.AllowEdit = False
        Me.gcDepartment.OptionsColumn.ReadOnly = True
        Me.gcDepartment.Visible = True
        Me.gcDepartment.VisibleIndex = 1
        '
        'gcKDdepartment
        '
        Me.gcKDdepartment.AppearanceHeader.Options.UseTextOptions = True
        Me.gcKDdepartment.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcKDdepartment.Caption = "Kode Huruf"
        Me.gcKDdepartment.FieldName = "kode"
        Me.gcKDdepartment.Name = "gcKDdepartment"
        Me.gcKDdepartment.OptionsColumn.AllowEdit = False
        Me.gcKDdepartment.OptionsColumn.ReadOnly = True
        Me.gcKDdepartment.Visible = True
        Me.gcKDdepartment.VisibleIndex = 2
        '
        'gcKDangka
        '
        Me.gcKDangka.AppearanceHeader.Options.UseTextOptions = True
        Me.gcKDangka.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcKDangka.Caption = "Kode Angka"
        Me.gcKDangka.FieldName = "kodeangka"
        Me.gcKDangka.Name = "gcKDangka"
        Me.gcKDangka.OptionsColumn.AllowEdit = False
        Me.gcKDangka.OptionsColumn.ReadOnly = True
        Me.gcKDangka.Visible = True
        Me.gcKDangka.VisibleIndex = 3
        '
        'gcStatData
        '
        Me.gcStatData.AppearanceHeader.Options.UseTextOptions = True
        Me.gcStatData.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcStatData.Caption = "Status Data"
        Me.gcStatData.FieldName = "statdata"
        Me.gcStatData.Name = "gcStatData"
        Me.gcStatData.OptionsColumn.AllowEdit = False
        Me.gcStatData.OptionsColumn.ReadOnly = True
        Me.gcStatData.Visible = True
        Me.gcStatData.VisibleIndex = 4
        '
        'tlData
        '
        Me.tlData.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlData.Appearance.Empty.Options.UseBackColor = True
        Me.tlData.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlData.Appearance.EvenRow.Options.UseBackColor = True
        Me.tlData.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlData.Appearance.OddRow.Options.UseBackColor = True
        Me.tlData.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.tlcID, Me.tlcIDParent, Me.tlcIDStatData, Me.tlcParent, Me.tlcDepartment, Me.tlcKode, Me.tlcKodeAngka, Me.tlcStatData})
        Me.tlData.Cursor = System.Windows.Forms.Cursors.Default
        Me.tlData.DataSource = Nothing
        Me.tlData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlData.Location = New System.Drawing.Point(0, 0)
        Me.tlData.Name = "tlData"
        Me.tlData.OptionsView.EnableAppearanceEvenRow = True
        Me.tlData.OptionsView.EnableAppearanceOddRow = True
        Me.tlData.Size = New System.Drawing.Size(617, 413)
        Me.tlData.TabIndex = 0
        '
        'tlcID
        '
        Me.tlcID.Caption = "ID"
        Me.tlcID.FieldName = "iddepartment"
        Me.tlcID.Name = "tlcID"
        Me.tlcID.OptionsColumn.AllowEdit = False
        Me.tlcID.OptionsColumn.ReadOnly = True
        '
        'tlcIDParent
        '
        Me.tlcIDParent.Caption = "ID Parent"
        Me.tlcIDParent.FieldName = "idparent"
        Me.tlcIDParent.Name = "tlcIDParent"
        Me.tlcIDParent.OptionsColumn.AllowEdit = False
        Me.tlcIDParent.OptionsColumn.ReadOnly = True
        '
        'tlcIDStatData
        '
        Me.tlcIDStatData.Caption = "ID Stat Data"
        Me.tlcIDStatData.FieldName = "statusdata"
        Me.tlcIDStatData.Name = "tlcIDStatData"
        Me.tlcIDStatData.OptionsColumn.AllowEdit = False
        Me.tlcIDStatData.OptionsColumn.ReadOnly = True
        '
        'tlcParent
        '
        Me.tlcParent.Caption = "Department Induk"
        Me.tlcParent.FieldName = "induk"
        Me.tlcParent.Name = "tlcParent"
        Me.tlcParent.OptionsColumn.AllowEdit = False
        Me.tlcParent.OptionsColumn.ReadOnly = True
        '
        'tlcDepartment
        '
        Me.tlcDepartment.Caption = "Department"
        Me.tlcDepartment.FieldName = "department"
        Me.tlcDepartment.Name = "tlcDepartment"
        Me.tlcDepartment.OptionsColumn.AllowEdit = False
        Me.tlcDepartment.OptionsColumn.ReadOnly = True
        Me.tlcDepartment.Visible = True
        Me.tlcDepartment.VisibleIndex = 0
        '
        'tlcKode
        '
        Me.tlcKode.Caption = "Kode Huruf"
        Me.tlcKode.FieldName = "kode"
        Me.tlcKode.Name = "tlcKode"
        Me.tlcKode.OptionsColumn.AllowEdit = False
        Me.tlcKode.OptionsColumn.ReadOnly = True
        Me.tlcKode.Visible = True
        Me.tlcKode.VisibleIndex = 1
        '
        'tlcKodeAngka
        '
        Me.tlcKodeAngka.Caption = "Kode Angka"
        Me.tlcKodeAngka.FieldName = "Kode Angka"
        Me.tlcKodeAngka.Name = "tlcKodeAngka"
        Me.tlcKodeAngka.OptionsColumn.AllowEdit = False
        Me.tlcKodeAngka.OptionsColumn.ReadOnly = True
        Me.tlcKodeAngka.Visible = True
        Me.tlcKodeAngka.VisibleIndex = 2
        '
        'tlcStatData
        '
        Me.tlcStatData.Caption = "Status Data"
        Me.tlcStatData.FieldName = "statdata"
        Me.tlcStatData.Name = "tlcStatData"
        Me.tlcStatData.OptionsColumn.AllowEdit = False
        Me.tlcStatData.OptionsColumn.ReadOnly = True
        Me.tlcStatData.Visible = True
        Me.tlcStatData.VisibleIndex = 3
        '
        'tlpField
        '
        Me.tlpField.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlpField.ColumnCount = 6
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.Controls.Add(Me.teKodeAngka, 2, 1)
        Me.tlpField.Controls.Add(Me.lblParent, 3, 1)
        Me.tlpField.Controls.Add(Me.Label1, 1, 1)
        Me.tlpField.Controls.Add(Me.teDepartment, 4, 2)
        Me.tlpField.Controls.Add(Me.lblDepartment, 3, 2)
        Me.tlpField.Controls.Add(Me.lblKode, 1, 2)
        Me.tlpField.Controls.Add(Me.lueParent, 4, 1)
        Me.tlpField.Controls.Add(Me.teKode, 2, 2)
        Me.tlpField.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpField.Location = New System.Drawing.Point(0, 30)
        Me.tlpField.Name = "tlpField"
        Me.tlpField.RowCount = 4
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpField.Size = New System.Drawing.Size(786, 54)
        Me.tlpField.TabIndex = 7
        '
        'teKodeAngka
        '
        Me.teKodeAngka.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teKodeAngka.Location = New System.Drawing.Point(243, 5)
        Me.teKodeAngka.Margin = New System.Windows.Forms.Padding(0)
        Me.teKodeAngka.Name = "teKodeAngka"
        Me.teKodeAngka.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teKodeAngka.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teKodeAngka.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teKodeAngka.Properties.Appearance.Options.UseBackColor = True
        Me.teKodeAngka.Properties.Appearance.Options.UseFont = True
        Me.teKodeAngka.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teKodeAngka.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teKodeAngka.Properties.MaxLength = 3
        Me.teKodeAngka.Properties.NullText = "[Belum Diisi]"
        Me.teKodeAngka.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teKodeAngka.Size = New System.Drawing.Size(150, 20)
        Me.teKodeAngka.TabIndex = 28
        Me.teKodeAngka.Tag = "kodeangka"
        '
        'lblParent
        '
        Me.lblParent.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblParent.AutoSize = True
        Me.lblParent.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParent.Location = New System.Drawing.Point(422, 8)
        Me.lblParent.Name = "lblParent"
        Me.lblParent.Size = New System.Drawing.Size(108, 14)
        Me.lblParent.TabIndex = 20
        Me.lblParent.Text = "Department Induk"
        Me.lblParent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(167, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 14)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Kode Angka"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teDepartment
        '
        Me.teDepartment.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teDepartment.Location = New System.Drawing.Point(533, 29)
        Me.teDepartment.Margin = New System.Windows.Forms.Padding(0)
        Me.teDepartment.Name = "teDepartment"
        Me.teDepartment.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teDepartment.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teDepartment.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teDepartment.Properties.Appearance.Options.UseBackColor = True
        Me.teDepartment.Properties.Appearance.Options.UseFont = True
        Me.teDepartment.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teDepartment.Properties.MaxLength = 300
        Me.teDepartment.Properties.NullText = "[Belum Diisi]"
        Me.teDepartment.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teDepartment.Size = New System.Drawing.Size(150, 20)
        Me.teDepartment.TabIndex = 17
        Me.teDepartment.Tag = "department"
        '
        'lblDepartment
        '
        Me.lblDepartment.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.Location = New System.Drawing.Point(457, 32)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(73, 14)
        Me.lblDepartment.TabIndex = 9
        Me.lblDepartment.Text = "Department"
        Me.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblKode
        '
        Me.lblKode.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblKode.AutoSize = True
        Me.lblKode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKode.Location = New System.Drawing.Point(171, 32)
        Me.lblKode.Name = "lblKode"
        Me.lblKode.Size = New System.Drawing.Size(69, 14)
        Me.lblKode.TabIndex = 18
        Me.lblKode.Text = "Kode Huruf"
        Me.lblKode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueParent
        '
        Me.lueParent.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueParent.Location = New System.Drawing.Point(533, 5)
        Me.lueParent.Margin = New System.Windows.Forms.Padding(0)
        Me.lueParent.Name = "lueParent"
        Me.lueParent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueParent.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueParent.Properties.Appearance.Options.UseBackColor = True
        Me.lueParent.Properties.Appearance.Options.UseFont = True
        Me.lueParent.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueParent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueParent.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("iddepartment", "ID Parent", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("department", "Department Induk")})
        Me.lueParent.Properties.NullText = "[Isian belum dipilih]"
        Me.lueParent.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueParent.Size = New System.Drawing.Size(150, 20)
        Me.lueParent.TabIndex = 21
        '
        'teKode
        '
        Me.teKode.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teKode.Location = New System.Drawing.Point(243, 29)
        Me.teKode.Margin = New System.Windows.Forms.Padding(0)
        Me.teKode.Name = "teKode"
        Me.teKode.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teKode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teKode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teKode.Properties.Appearance.Options.UseBackColor = True
        Me.teKode.Properties.Appearance.Options.UseFont = True
        Me.teKode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teKode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teKode.Properties.MaxLength = 3
        Me.teKode.Properties.NullText = "[Belum Diisi]"
        Me.teKode.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teKode.Size = New System.Drawing.Size(150, 20)
        Me.teKode.TabIndex = 27
        Me.teKode.Tag = "kode"
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
        Me.btnSave.BackColor = System.Drawing.Color.Green
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
        'xtcViewer
        '
        Me.xtcViewer.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.xtcViewer.Appearance.Options.UseBackColor = True
        Me.xtcViewer.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcViewer.AppearancePage.Header.Options.UseFont = True
        Me.xtcViewer.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcViewer.AppearancePage.HeaderActive.Options.UseFont = True
        Me.xtcViewer.AppearancePage.HeaderDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcViewer.AppearancePage.HeaderDisabled.Options.UseFont = True
        Me.xtcViewer.AppearancePage.HeaderHotTracked.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcViewer.AppearancePage.HeaderHotTracked.Options.UseFont = True
        Me.xtcViewer.AppearancePage.PageClient.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcViewer.AppearancePage.PageClient.Options.UseFont = True
        Me.xtcViewer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.xtcViewer.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.xtcViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtcViewer.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[False]
        Me.xtcViewer.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Right
        Me.xtcViewer.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
        Me.xtcViewer.Location = New System.Drawing.Point(0, 84)
        Me.xtcViewer.Margin = New System.Windows.Forms.Padding(0)
        Me.xtcViewer.Name = "xtcViewer"
        Me.xtcViewer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.xtcViewer.SelectedTabPage = Me.XtraTabPage1
        Me.xtcViewer.Size = New System.Drawing.Size(786, 294)
        Me.xtcViewer.TabIndex = 74
        Me.xtcViewer.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage16})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.XtraTabPage1.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage1.Controls.Add(Me.gcData)
        Me.XtraTabPage1.Margin = New System.Windows.Forms.Padding(0)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(737, 288)
        Me.XtraTabPage1.Text = "GRID"
        '
        'XtraTabPage16
        '
        Me.XtraTabPage16.Controls.Add(Me.tlData)
        Me.XtraTabPage16.Margin = New System.Windows.Forms.Padding(0)
        Me.XtraTabPage16.Name = "XtraTabPage16"
        Me.XtraTabPage16.Size = New System.Drawing.Size(617, 413)
        Me.XtraTabPage16.Text = "TREE"
        '
        'frmDepartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(790, 408)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDepartment"
        Me.ShowInTaskbar = False
        Me.Text = "Department"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tlData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpField.ResumeLayout(False)
        Me.tlpField.PerformLayout()
        CType(Me.teKodeAngka.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teDepartment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueParent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teKode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        CType(Me.xtcViewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcViewer.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage16.ResumeLayout(False)
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
    Friend WithEvents teDepartment As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gcID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcDepartment As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lblKode As System.Windows.Forms.Label
    Friend WithEvents gcKDdepartment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblParent As System.Windows.Forms.Label
    Friend WithEvents lueParent As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents gcParent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcStatData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcIDParent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcIDStatData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tlData As DevExpress.XtraTreeList.TreeList
    Friend WithEvents tlcID As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlcIDParent As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlcIDStatData As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlcParent As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlcDepartment As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlcKode As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlcStatData As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents teKode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Friend WithEvents gcKDangka As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tlcKodeAngka As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents teKodeAngka As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents xtcViewer As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage16 As DevExpress.XtraTab.XtraTabPage
End Class
