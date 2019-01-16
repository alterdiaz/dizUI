<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBank
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
        Me.gcIDStatData = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcIDCOA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcBank = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcNoRekening = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcKodeRekening = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcCOA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcStatData = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tlpField = New System.Windows.Forms.TableLayoutPanel()
        Me.slueCOA = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.slueCOAView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lblBank = New System.Windows.Forms.Label()
        Me.teBank = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.teNoRekening = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.teRemarks = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnClearCOA = New System.Windows.Forms.Button()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblSep5 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBody.SuspendLayout()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpField.SuspendLayout()
        CType(Me.slueCOA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueCOAView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teBank.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNoRekening.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblTitle.Text = "Bank"
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
        Me.gcData.Location = New System.Drawing.Point(0, 101)
        Me.gcData.MainView = Me.gvData
        Me.gcData.Name = "gcData"
        Me.gcData.Size = New System.Drawing.Size(786, 277)
        Me.gcData.TabIndex = 8
        Me.gcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvData})
        '
        'gvData
        '
        Me.gvData.Appearance.Empty.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.gvData.Appearance.Empty.Options.UseBackColor = True
        Me.gvData.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvData.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.OddRow.Options.UseBackColor = True
        Me.gvData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcID, Me.gcIDStatData, Me.gcIDCOA, Me.gcBank, Me.gcNoRekening, Me.gcRemarks, Me.gcKodeRekening, Me.gcCOA, Me.gcStatData})
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
        Me.gcID.FieldName = "idbank"
        Me.gcID.Name = "gcID"
        Me.gcID.OptionsColumn.AllowEdit = False
        Me.gcID.OptionsColumn.ReadOnly = True
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
        'gcIDCOA
        '
        Me.gcIDCOA.AppearanceHeader.Options.UseTextOptions = True
        Me.gcIDCOA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcIDCOA.Caption = "IDCOA"
        Me.gcIDCOA.FieldName = "idcoa"
        Me.gcIDCOA.Name = "gcIDCOA"
        '
        'gcBank
        '
        Me.gcBank.AppearanceHeader.Options.UseTextOptions = True
        Me.gcBank.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcBank.Caption = "Bank"
        Me.gcBank.FieldName = "bank"
        Me.gcBank.Name = "gcBank"
        Me.gcBank.OptionsColumn.AllowEdit = False
        Me.gcBank.OptionsColumn.ReadOnly = True
        Me.gcBank.Visible = True
        Me.gcBank.VisibleIndex = 0
        '
        'gcNoRekening
        '
        Me.gcNoRekening.AppearanceHeader.Options.UseTextOptions = True
        Me.gcNoRekening.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcNoRekening.Caption = "No Rekening"
        Me.gcNoRekening.FieldName = "norekening"
        Me.gcNoRekening.Name = "gcNoRekening"
        Me.gcNoRekening.OptionsColumn.AllowEdit = False
        Me.gcNoRekening.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.gcNoRekening.OptionsColumn.ReadOnly = True
        Me.gcNoRekening.Visible = True
        Me.gcNoRekening.VisibleIndex = 1
        '
        'gcRemarks
        '
        Me.gcRemarks.AppearanceHeader.Options.UseTextOptions = True
        Me.gcRemarks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcRemarks.Caption = "Keterangan"
        Me.gcRemarks.FieldName = "remarks"
        Me.gcRemarks.Name = "gcRemarks"
        Me.gcRemarks.OptionsColumn.AllowEdit = False
        Me.gcRemarks.OptionsColumn.ReadOnly = True
        Me.gcRemarks.Visible = True
        Me.gcRemarks.VisibleIndex = 2
        '
        'gcKodeRekening
        '
        Me.gcKodeRekening.AppearanceHeader.Options.UseTextOptions = True
        Me.gcKodeRekening.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcKodeRekening.Caption = "Kode Rekening"
        Me.gcKodeRekening.FieldName = "coa"
        Me.gcKodeRekening.Name = "gcKodeRekening"
        Me.gcKodeRekening.OptionsColumn.AllowEdit = False
        Me.gcKodeRekening.OptionsColumn.ReadOnly = True
        Me.gcKodeRekening.Visible = True
        Me.gcKodeRekening.VisibleIndex = 3
        '
        'gcCOA
        '
        Me.gcCOA.AppearanceHeader.Options.UseTextOptions = True
        Me.gcCOA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcCOA.Caption = "Rekening"
        Me.gcCOA.FieldName = "rcoa"
        Me.gcCOA.Name = "gcCOA"
        Me.gcCOA.OptionsColumn.AllowEdit = False
        Me.gcCOA.OptionsColumn.ReadOnly = True
        Me.gcCOA.Visible = True
        Me.gcCOA.VisibleIndex = 4
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
        Me.gcStatData.VisibleIndex = 5
        '
        'tlpField
        '
        Me.tlpField.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.tlpField.ColumnCount = 6
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.Controls.Add(Me.slueCOA, 4, 1)
        Me.tlpField.Controls.Add(Me.lblBank, 1, 1)
        Me.tlpField.Controls.Add(Me.teBank, 2, 1)
        Me.tlpField.Controls.Add(Me.Label1, 1, 2)
        Me.tlpField.Controls.Add(Me.teNoRekening, 2, 2)
        Me.tlpField.Controls.Add(Me.Label2, 3, 2)
        Me.tlpField.Controls.Add(Me.teRemarks, 4, 2)
        Me.tlpField.Controls.Add(Me.Label3, 3, 1)
        Me.tlpField.Controls.Add(Me.btnClearCOA, 5, 1)
        Me.tlpField.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpField.Location = New System.Drawing.Point(0, 30)
        Me.tlpField.Name = "tlpField"
        Me.tlpField.RowCount = 4
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.Size = New System.Drawing.Size(786, 71)
        Me.tlpField.TabIndex = 7
        '
        'slueCOA
        '
        Me.slueCOA.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.slueCOA.Location = New System.Drawing.Point(503, 13)
        Me.slueCOA.Margin = New System.Windows.Forms.Padding(0)
        Me.slueCOA.Name = "slueCOA"
        Me.slueCOA.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.slueCOA.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.slueCOA.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.slueCOA.Properties.Appearance.Options.UseBackColor = True
        Me.slueCOA.Properties.Appearance.Options.UseFont = True
        Me.slueCOA.Properties.Appearance.Options.UseForeColor = True
        Me.slueCOA.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.slueCOA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueCOA.Properties.NullText = "[Isian belum dipilih]"
        Me.slueCOA.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.slueCOA.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Simple
        Me.slueCOA.Properties.PopupFindMode = DevExpress.XtraEditors.FindMode.Always
        Me.slueCOA.Properties.ShowFooter = False
        Me.slueCOA.Properties.ShowPopupShadow = False
        Me.slueCOA.Properties.View = Me.slueCOAView
        Me.slueCOA.Properties.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView
        Me.slueCOA.Size = New System.Drawing.Size(150, 20)
        Me.slueCOA.TabIndex = 24
        '
        'slueCOAView
        '
        Me.slueCOAView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.slueCOAView.Appearance.EvenRow.Options.UseBackColor = True
        Me.slueCOAView.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.slueCOAView.Appearance.OddRow.Options.UseBackColor = True
        Me.slueCOAView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3})
        Me.slueCOAView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.slueCOAView.Name = "slueCOAView"
        Me.slueCOAView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.slueCOAView.OptionsView.EnableAppearanceEvenRow = True
        Me.slueCOAView.OptionsView.EnableAppearanceOddRow = True
        Me.slueCOAView.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ID"
        Me.GridColumn1.FieldName = "idcoa"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "COA"
        Me.GridColumn2.FieldName = "coa"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Remarks"
        Me.GridColumn3.FieldName = "remarks"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        '
        'lblBank
        '
        Me.lblBank.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblBank.AutoSize = True
        Me.lblBank.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBank.Location = New System.Drawing.Point(197, 16)
        Me.lblBank.Name = "lblBank"
        Me.lblBank.Size = New System.Drawing.Size(33, 14)
        Me.lblBank.TabIndex = 9
        Me.lblBank.Text = "Bank"
        Me.lblBank.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teBank
        '
        Me.teBank.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teBank.Location = New System.Drawing.Point(233, 13)
        Me.teBank.Margin = New System.Windows.Forms.Padding(0)
        Me.teBank.Name = "teBank"
        Me.teBank.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teBank.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teBank.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teBank.Properties.Appearance.Options.UseBackColor = True
        Me.teBank.Properties.Appearance.Options.UseFont = True
        Me.teBank.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teBank.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teBank.Properties.MaxLength = 10
        Me.teBank.Properties.NullText = "[Belum Diisi]"
        Me.teBank.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teBank.Size = New System.Drawing.Size(150, 20)
        Me.teBank.TabIndex = 17
        Me.teBank.Tag = "bank"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(154, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 14)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "No Rekening"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teNoRekening
        '
        Me.teNoRekening.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNoRekening.Location = New System.Drawing.Point(233, 37)
        Me.teNoRekening.Margin = New System.Windows.Forms.Padding(0)
        Me.teNoRekening.Name = "teNoRekening"
        Me.teNoRekening.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teNoRekening.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNoRekening.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNoRekening.Properties.Appearance.Options.UseBackColor = True
        Me.teNoRekening.Properties.Appearance.Options.UseFont = True
        Me.teNoRekening.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNoRekening.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teNoRekening.Properties.MaxLength = 10
        Me.teNoRekening.Properties.NullText = "[Belum Diisi]"
        Me.teNoRekening.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNoRekening.Size = New System.Drawing.Size(150, 20)
        Me.teNoRekening.TabIndex = 28
        Me.teNoRekening.Tag = "norekening"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(430, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 14)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Keterangan"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teRemarks
        '
        Me.teRemarks.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teRemarks.Location = New System.Drawing.Point(503, 37)
        Me.teRemarks.Margin = New System.Windows.Forms.Padding(0)
        Me.teRemarks.Name = "teRemarks"
        Me.teRemarks.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teRemarks.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teRemarks.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teRemarks.Properties.Appearance.Options.UseBackColor = True
        Me.teRemarks.Properties.Appearance.Options.UseFont = True
        Me.teRemarks.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teRemarks.Properties.MaxLength = 10
        Me.teRemarks.Properties.NullText = "[Belum Diisi]"
        Me.teRemarks.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teRemarks.Size = New System.Drawing.Size(150, 20)
        Me.teRemarks.TabIndex = 30
        Me.teRemarks.Tag = "remarks"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(402, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 14)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Kode Saldo Awal"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnClearCOA
        '
        Me.btnClearCOA.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnClearCOA.FlatAppearance.BorderSize = 0
        Me.btnClearCOA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnClearCOA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnClearCOA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearCOA.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearCOA.ForeColor = System.Drawing.Color.White
        Me.btnClearCOA.Location = New System.Drawing.Point(657, 11)
        Me.btnClearCOA.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnClearCOA.Name = "btnClearCOA"
        Me.btnClearCOA.Size = New System.Drawing.Size(120, 24)
        Me.btnClearCOA.TabIndex = 67
        Me.btnClearCOA.Text = "CLEAR KODE"
        Me.btnClearCOA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClearCOA.UseVisualStyleBackColor = False
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
        'btnPrint
        '
        Me.btnPrint.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Image = Global.dizUI.My.Resources.Resources.print
        Me.btnPrint.Location = New System.Drawing.Point(-26, 0)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(100, 1)
        Me.btnPrint.TabIndex = 0
        Me.btnPrint.Text = "PRINT"
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'frmBank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.ClientSize = New System.Drawing.Size(790, 408)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBank"
        Me.ShowInTaskbar = False
        Me.Text = "Bank"
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
        CType(Me.slueCOA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueCOAView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teBank.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNoRekening.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents lblSep5 As System.Windows.Forms.Label
    Public WithEvents pHeader As System.Windows.Forms.Panel
    Public WithEvents btnNew As System.Windows.Forms.Button
    Public WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents pBody As System.Windows.Forms.Panel
    Public WithEvents gcData As DevExpress.XtraGrid.GridControl
    Public WithEvents gvData As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents tlpField As System.Windows.Forms.TableLayoutPanel
    Public WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblBank As System.Windows.Forms.Label
    Friend WithEvents teBank As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gcID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcBank As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents gcStatData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcIDStatData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcNoRekening As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents teNoRekening As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents teRemarks As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gcRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gcIDCOA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcKodeRekening As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents btnClearCOA As System.Windows.Forms.Button
    Friend WithEvents gcCOA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Friend WithEvents slueCOA As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents slueCOAView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
End Class
