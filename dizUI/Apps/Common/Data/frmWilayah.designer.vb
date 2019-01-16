<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWilayah
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
        Me.tlpForm = New System.Windows.Forms.TableLayoutPanel()
        Me.pTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pMinimize = New System.Windows.Forms.PictureBox()
        Me.pMaximize = New System.Windows.Forms.PictureBox()
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.pBody = New System.Windows.Forms.Panel()
        Me.xtcViewer = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpGrid = New DevExpress.XtraTab.XtraTabPage()
        Me.gcData = New DevExpress.XtraGrid.GridControl()
        Me.gvData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcIDParent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcIDStatData = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gclevelwilayah = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcParent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcWilayah = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcKodepos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcKodeWilayah = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcStatData = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.xtpTree = New DevExpress.XtraTab.XtraTabPage()
        Me.tlData = New DevExpress.XtraTreeList.TreeList()
        Me.tlcID = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlcIDParent = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlcIDStatData = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlclevelwilayah = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlcParent = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlcWilayah = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlcKodepos = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlcStatData = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.tlpField = New System.Windows.Forms.TableLayoutPanel()
        Me.teWilayah = New DevExpress.XtraEditors.TextEdit()
        Me.lblWilayah = New System.Windows.Forms.Label()
        Me.lueParent = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblParent = New System.Windows.Forms.Label()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.lueLevel = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblKodepos = New System.Windows.Forms.Label()
        Me.nudKodepos = New DevExpress.XtraEditors.SpinEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.teKodeWilayah = New DevExpress.XtraEditors.TextEdit()
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
        CType(Me.xtcViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcViewer.SuspendLayout()
        Me.xtpGrid.SuspendLayout()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpTree.SuspendLayout()
        CType(Me.tlData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpField.SuspendLayout()
        CType(Me.teWilayah.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueParent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudKodepos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teKodeWilayah.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblTitle.Text = "Wilayah"
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
        'xtcViewer
        '
        Me.xtcViewer.Appearance.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.xtcViewer.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcViewer.Appearance.Options.UseBackColor = True
        Me.xtcViewer.Appearance.Options.UseFont = True
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
        Me.xtcViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtcViewer.Location = New System.Drawing.Point(0, 125)
        Me.xtcViewer.Margin = New System.Windows.Forms.Padding(0)
        Me.xtcViewer.Name = "xtcViewer"
        Me.xtcViewer.SelectedTabPage = Me.xtpGrid
        Me.xtcViewer.Size = New System.Drawing.Size(786, 253)
        Me.xtcViewer.TabIndex = 8
        Me.xtcViewer.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpGrid, Me.xtpTree})
        '
        'xtpGrid
        '
        Me.xtpGrid.Controls.Add(Me.gcData)
        Me.xtpGrid.Name = "xtpGrid"
        Me.xtpGrid.Size = New System.Drawing.Size(780, 224)
        Me.xtpGrid.Text = "Gridview"
        '
        'gcData
        '
        Me.gcData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcData.Location = New System.Drawing.Point(0, 0)
        Me.gcData.MainView = Me.gvData
        Me.gcData.Name = "gcData"
        Me.gcData.Size = New System.Drawing.Size(780, 224)
        Me.gcData.TabIndex = 8
        Me.gcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvData})
        '
        'gvData
        '
        Me.gvData.Appearance.Empty.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.gvData.Appearance.Empty.Options.UseBackColor = True
        Me.gvData.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvData.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.OddRow.Options.UseBackColor = True
        Me.gvData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcID, Me.gcIDParent, Me.gcIDStatData, Me.gclevelwilayah, Me.gcParent, Me.gcWilayah, Me.gcKodepos, Me.gcKodeWilayah, Me.gcStatData})
        Me.gvData.GridControl = Me.gcData
        Me.gvData.Name = "gvData"
        Me.gvData.OptionsView.EnableAppearanceEvenRow = True
        Me.gvData.OptionsView.EnableAppearanceOddRow = True
        Me.gvData.OptionsView.ShowGroupPanel = False
        '
        'gcID
        '
        Me.gcID.AppearanceHeader.Options.UseTextOptions = True
        Me.gcID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcID.Caption = "ID"
        Me.gcID.FieldName = "idwilayah"
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
        Me.gcIDStatData.FieldName = "isdeleted"
        Me.gcIDStatData.Name = "gcIDStatData"
        Me.gcIDStatData.OptionsColumn.AllowEdit = False
        Me.gcIDStatData.OptionsColumn.ReadOnly = True
        '
        'gclevelwilayah
        '
        Me.gclevelwilayah.AppearanceHeader.Options.UseTextOptions = True
        Me.gclevelwilayah.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gclevelwilayah.Caption = "ID Level Wilayah"
        Me.gclevelwilayah.FieldName = "levelwilayah"
        Me.gclevelwilayah.Name = "gclevelwilayah"
        Me.gclevelwilayah.OptionsColumn.AllowEdit = False
        Me.gclevelwilayah.OptionsColumn.ReadOnly = True
        '
        'gcParent
        '
        Me.gcParent.AppearanceHeader.Options.UseTextOptions = True
        Me.gcParent.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcParent.Caption = "Wilayah Induk"
        Me.gcParent.FieldName = "induk"
        Me.gcParent.Name = "gcParent"
        Me.gcParent.OptionsColumn.AllowEdit = False
        Me.gcParent.OptionsColumn.ReadOnly = True
        Me.gcParent.Visible = True
        Me.gcParent.VisibleIndex = 0
        '
        'gcWilayah
        '
        Me.gcWilayah.AppearanceHeader.Options.UseTextOptions = True
        Me.gcWilayah.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcWilayah.Caption = "Wilayah"
        Me.gcWilayah.FieldName = "wilayah"
        Me.gcWilayah.Name = "gcWilayah"
        Me.gcWilayah.OptionsColumn.AllowEdit = False
        Me.gcWilayah.OptionsColumn.ReadOnly = True
        Me.gcWilayah.Visible = True
        Me.gcWilayah.VisibleIndex = 1
        '
        'gcKodepos
        '
        Me.gcKodepos.AppearanceHeader.Options.UseTextOptions = True
        Me.gcKodepos.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcKodepos.Caption = "Kodepos"
        Me.gcKodepos.FieldName = "kodepos"
        Me.gcKodepos.Name = "gcKodepos"
        Me.gcKodepos.OptionsColumn.AllowEdit = False
        Me.gcKodepos.OptionsColumn.ReadOnly = True
        Me.gcKodepos.Visible = True
        Me.gcKodepos.VisibleIndex = 2
        '
        'gcKodeWilayah
        '
        Me.gcKodeWilayah.AppearanceHeader.Options.UseTextOptions = True
        Me.gcKodeWilayah.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcKodeWilayah.Caption = "Kode Wilayah"
        Me.gcKodeWilayah.FieldName = "kodewilayah"
        Me.gcKodeWilayah.Name = "gcKodeWilayah"
        Me.gcKodeWilayah.OptionsColumn.AllowEdit = False
        Me.gcKodeWilayah.OptionsColumn.ReadOnly = True
        Me.gcKodeWilayah.Visible = True
        Me.gcKodeWilayah.VisibleIndex = 3
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
        'xtpTree
        '
        Me.xtpTree.Controls.Add(Me.tlData)
        Me.xtpTree.Name = "xtpTree"
        Me.xtpTree.Size = New System.Drawing.Size(780, 224)
        Me.xtpTree.Text = "Treelist"
        '
        'tlData
        '
        Me.tlData.Appearance.Empty.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.tlData.Appearance.Empty.Options.UseBackColor = True
        Me.tlData.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlData.Appearance.EvenRow.Options.UseBackColor = True
        Me.tlData.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlData.Appearance.OddRow.Options.UseBackColor = True
        Me.tlData.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.tlcID, Me.tlcIDParent, Me.tlcIDStatData, Me.tlclevelwilayah, Me.tlcParent, Me.tlcWilayah, Me.tlcKodepos, Me.tlcStatData})
        Me.tlData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlData.Location = New System.Drawing.Point(0, 0)
        Me.tlData.Name = "tlData"
        Me.tlData.Size = New System.Drawing.Size(780, 224)
        Me.tlData.TabIndex = 0
        '
        'tlcID
        '
        Me.tlcID.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlcID.AppearanceCell.Options.UseBackColor = True
        Me.tlcID.Caption = "ID"
        Me.tlcID.FieldName = "idwilayah"
        Me.tlcID.Name = "tlcID"
        Me.tlcID.OptionsColumn.AllowEdit = False
        Me.tlcID.OptionsColumn.ReadOnly = True
        '
        'tlcIDParent
        '
        Me.tlcIDParent.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlcIDParent.AppearanceCell.Options.UseBackColor = True
        Me.tlcIDParent.Caption = "ID Parent"
        Me.tlcIDParent.FieldName = "idparent"
        Me.tlcIDParent.Name = "tlcIDParent"
        Me.tlcIDParent.OptionsColumn.AllowEdit = False
        Me.tlcIDParent.OptionsColumn.ReadOnly = True
        '
        'tlcIDStatData
        '
        Me.tlcIDStatData.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlcIDStatData.AppearanceCell.Options.UseBackColor = True
        Me.tlcIDStatData.Caption = "ID Stat Data"
        Me.tlcIDStatData.FieldName = "statusdata"
        Me.tlcIDStatData.Name = "tlcIDStatData"
        Me.tlcIDStatData.OptionsColumn.AllowEdit = False
        Me.tlcIDStatData.OptionsColumn.ReadOnly = True
        '
        'tlclevelwilayah
        '
        Me.tlclevelwilayah.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlclevelwilayah.AppearanceCell.Options.UseBackColor = True
        Me.tlclevelwilayah.Caption = "ID Level Wilayah"
        Me.tlclevelwilayah.FieldName = "levelwilayah"
        Me.tlclevelwilayah.Name = "tlclevelwilayah"
        Me.tlclevelwilayah.OptionsColumn.AllowEdit = False
        Me.tlclevelwilayah.OptionsColumn.ReadOnly = True
        '
        'tlcParent
        '
        Me.tlcParent.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlcParent.AppearanceCell.Options.UseBackColor = True
        Me.tlcParent.Caption = "Wilayah Induk"
        Me.tlcParent.FieldName = "induk"
        Me.tlcParent.Name = "tlcParent"
        Me.tlcParent.OptionsColumn.AllowEdit = False
        Me.tlcParent.OptionsColumn.ReadOnly = True
        '
        'tlcWilayah
        '
        Me.tlcWilayah.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlcWilayah.AppearanceCell.Options.UseBackColor = True
        Me.tlcWilayah.Caption = "Wilayah"
        Me.tlcWilayah.FieldName = "wilayah"
        Me.tlcWilayah.Name = "tlcWilayah"
        Me.tlcWilayah.OptionsColumn.AllowEdit = False
        Me.tlcWilayah.OptionsColumn.ReadOnly = True
        Me.tlcWilayah.Visible = True
        Me.tlcWilayah.VisibleIndex = 0
        '
        'tlcKodepos
        '
        Me.tlcKodepos.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlcKodepos.AppearanceCell.Options.UseBackColor = True
        Me.tlcKodepos.Caption = "Kodepos"
        Me.tlcKodepos.FieldName = "kodepos"
        Me.tlcKodepos.Name = "tlcKodepos"
        Me.tlcKodepos.OptionsColumn.AllowEdit = False
        Me.tlcKodepos.OptionsColumn.ReadOnly = True
        Me.tlcKodepos.Visible = True
        Me.tlcKodepos.VisibleIndex = 1
        '
        'tlcStatData
        '
        Me.tlcStatData.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tlcStatData.AppearanceCell.Options.UseBackColor = True
        Me.tlcStatData.Caption = "Status Data"
        Me.tlcStatData.FieldName = "statdata"
        Me.tlcStatData.Name = "tlcStatData"
        Me.tlcStatData.OptionsColumn.AllowEdit = False
        Me.tlcStatData.OptionsColumn.ReadOnly = True
        Me.tlcStatData.Visible = True
        Me.tlcStatData.VisibleIndex = 2
        '
        'tlpField
        '
        Me.tlpField.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.tlpField.ColumnCount = 6
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.Controls.Add(Me.teWilayah, 2, 3)
        Me.tlpField.Controls.Add(Me.lblWilayah, 1, 3)
        Me.tlpField.Controls.Add(Me.lueParent, 2, 2)
        Me.tlpField.Controls.Add(Me.lblParent, 1, 2)
        Me.tlpField.Controls.Add(Me.lblLevel, 1, 1)
        Me.tlpField.Controls.Add(Me.lueLevel, 2, 1)
        Me.tlpField.Controls.Add(Me.lblKodepos, 3, 2)
        Me.tlpField.Controls.Add(Me.nudKodepos, 4, 2)
        Me.tlpField.Controls.Add(Me.Label1, 3, 3)
        Me.tlpField.Controls.Add(Me.teKodeWilayah, 4, 3)
        Me.tlpField.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpField.Location = New System.Drawing.Point(0, 30)
        Me.tlpField.Name = "tlpField"
        Me.tlpField.RowCount = 5
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.Size = New System.Drawing.Size(786, 95)
        Me.tlpField.TabIndex = 7
        '
        'teWilayah
        '
        Me.teWilayah.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teWilayah.Location = New System.Drawing.Point(243, 61)
        Me.teWilayah.Margin = New System.Windows.Forms.Padding(0)
        Me.teWilayah.Name = "teWilayah"
        Me.teWilayah.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teWilayah.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teWilayah.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teWilayah.Properties.Appearance.Options.UseBackColor = True
        Me.teWilayah.Properties.Appearance.Options.UseFont = True
        Me.teWilayah.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teWilayah.Properties.MaxLength = 300
        Me.teWilayah.Properties.NullText = "[Belum Diisi]"
        Me.teWilayah.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teWilayah.Size = New System.Drawing.Size(150, 20)
        Me.teWilayah.TabIndex = 17
        Me.teWilayah.Tag = "wilayah"
        '
        'lblWilayah
        '
        Me.lblWilayah.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblWilayah.AutoSize = True
        Me.lblWilayah.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWilayah.Location = New System.Drawing.Point(192, 64)
        Me.lblWilayah.Name = "lblWilayah"
        Me.lblWilayah.Size = New System.Drawing.Size(48, 14)
        Me.lblWilayah.TabIndex = 9
        Me.lblWilayah.Text = "Wilayah"
        Me.lblWilayah.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueParent
        '
        Me.lueParent.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueParent.Location = New System.Drawing.Point(243, 37)
        Me.lueParent.Margin = New System.Windows.Forms.Padding(0)
        Me.lueParent.Name = "lueParent"
        Me.lueParent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueParent.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueParent.Properties.Appearance.Options.UseBackColor = True
        Me.lueParent.Properties.Appearance.Options.UseFont = True
        Me.lueParent.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueParent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueParent.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("idwilayah", "ID Parent", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("induk", "Wilayah Induk")})
        Me.lueParent.Properties.NullText = "[Isian belum dipilih]"
        Me.lueParent.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueParent.Size = New System.Drawing.Size(150, 20)
        Me.lueParent.TabIndex = 21
        '
        'lblParent
        '
        Me.lblParent.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblParent.AutoSize = True
        Me.lblParent.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParent.Location = New System.Drawing.Point(157, 40)
        Me.lblParent.Name = "lblParent"
        Me.lblParent.Size = New System.Drawing.Size(83, 14)
        Me.lblParent.TabIndex = 20
        Me.lblParent.Text = "Wilayah Induk"
        Me.lblParent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLevel
        '
        Me.lblLevel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblLevel.AutoSize = True
        Me.lblLevel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.Location = New System.Drawing.Point(160, 16)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(80, 14)
        Me.lblLevel.TabIndex = 25
        Me.lblLevel.Text = "Level Wilayah"
        Me.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueLevel
        '
        Me.lueLevel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueLevel.Location = New System.Drawing.Point(243, 13)
        Me.lueLevel.Margin = New System.Windows.Forms.Padding(0)
        Me.lueLevel.Name = "lueLevel"
        Me.lueLevel.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueLevel.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueLevel.Properties.Appearance.Options.UseBackColor = True
        Me.lueLevel.Properties.Appearance.Options.UseFont = True
        Me.lueLevel.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueLevel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLevel.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("levelwilayah", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("levelwilayah", "Level Wilayah")})
        Me.lueLevel.Properties.NullText = "[Isian belum dipilih]"
        Me.lueLevel.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueLevel.Size = New System.Drawing.Size(150, 20)
        Me.lueLevel.TabIndex = 26
        '
        'lblKodepos
        '
        Me.lblKodepos.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblKodepos.AutoSize = True
        Me.lblKodepos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKodepos.Location = New System.Drawing.Point(476, 40)
        Me.lblKodepos.Name = "lblKodepos"
        Me.lblKodepos.Size = New System.Drawing.Size(54, 14)
        Me.lblKodepos.TabIndex = 18
        Me.lblKodepos.Text = "Kodepos"
        Me.lblKodepos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudKodepos
        '
        Me.nudKodepos.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.nudKodepos.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.nudKodepos.Location = New System.Drawing.Point(533, 37)
        Me.nudKodepos.Margin = New System.Windows.Forms.Padding(0)
        Me.nudKodepos.Name = "nudKodepos"
        Me.nudKodepos.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.nudKodepos.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.nudKodepos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.nudKodepos.Properties.Appearance.Options.UseBackColor = True
        Me.nudKodepos.Properties.Appearance.Options.UseFont = True
        Me.nudKodepos.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.nudKodepos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.nudKodepos.Properties.MaxLength = 10
        Me.nudKodepos.Properties.MaxValue = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.nudKodepos.Size = New System.Drawing.Size(100, 20)
        Me.nudKodepos.TabIndex = 19
        Me.nudKodepos.Tag = "kodepos"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(450, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 14)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Kode Wilayah"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teKodeWilayah
        '
        Me.teKodeWilayah.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teKodeWilayah.Location = New System.Drawing.Point(533, 61)
        Me.teKodeWilayah.Margin = New System.Windows.Forms.Padding(0)
        Me.teKodeWilayah.Name = "teKodeWilayah"
        Me.teKodeWilayah.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teKodeWilayah.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teKodeWilayah.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teKodeWilayah.Properties.Appearance.Options.UseBackColor = True
        Me.teKodeWilayah.Properties.Appearance.Options.UseFont = True
        Me.teKodeWilayah.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teKodeWilayah.Properties.MaxLength = 300
        Me.teKodeWilayah.Properties.NullText = "[Belum Diisi]"
        Me.teKodeWilayah.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teKodeWilayah.Size = New System.Drawing.Size(150, 20)
        Me.teKodeWilayah.TabIndex = 28
        Me.teKodeWilayah.Tag = "kodewilayah"
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
        'frmWilayah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.ClientSize = New System.Drawing.Size(790, 408)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmWilayah"
        Me.ShowInTaskbar = False
        Me.Text = "Wilayah"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        CType(Me.xtcViewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcViewer.ResumeLayout(False)
        Me.xtpGrid.ResumeLayout(False)
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpTree.ResumeLayout(False)
        CType(Me.tlData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpField.ResumeLayout(False)
        Me.tlpField.PerformLayout()
        CType(Me.teWilayah.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueParent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudKodepos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teKodeWilayah.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblWilayah As System.Windows.Forms.Label
    Friend WithEvents teWilayah As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gcID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcWilayah As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lblKodepos As System.Windows.Forms.Label
    Friend WithEvents gcKodepos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nudKodepos As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lblParent As System.Windows.Forms.Label
    Friend WithEvents lueParent As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents gcParent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcIDParent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcIDStatData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblLevel As System.Windows.Forms.Label
    Friend WithEvents lueLevel As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents gclevelwilayah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents xtcViewer As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpGrid As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpTree As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tlData As DevExpress.XtraTreeList.TreeList
    Friend WithEvents tlcID As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlcIDParent As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlcIDStatData As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlclevelwilayah As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlcParent As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlcWilayah As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlcKodepos As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents tlcStatData As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gcKodeWilayah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcStatData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents teKodeWilayah As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
End Class
