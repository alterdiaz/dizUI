<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnggaran
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
        Me.gcData = New DevExpress.XtraGrid.GridControl()
        Me.gvData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcIDStatData = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcIDCOA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcCOA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcJenis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcPeriode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcJumlahUang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcStatData = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tlpField = New System.Windows.Forms.TableLayoutPanel()
        Me.lblBank = New System.Windows.Forms.Label()
        Me.lueCOA = New DevExpress.XtraEditors.LookUpEdit()
        Me.nudJumlahUang = New DevExpress.XtraEditors.SpinEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lueJenis = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dePeriode = New DevExpress.XtraEditors.DateEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.teCOA = New DevExpress.XtraEditors.TextEdit()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblSep5 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.slueCOA = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.slueCOAView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBody.SuspendLayout()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpField.SuspendLayout()
        CType(Me.lueCOA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudJumlahUang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueJenis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dePeriode.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dePeriode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teCOA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeader.SuspendLayout()
        CType(Me.slueCOA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueCOAView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpForm
        '
        Me.tlpForm.BackColor = System.Drawing.Color.Teal
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
        Me.pTitle.TabIndex = 11
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
        Me.lblTitle.Text = "Anggaran"
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
        Me.gcData.Location = New System.Drawing.Point(0, 125)
        Me.gcData.MainView = Me.gvData
        Me.gcData.Name = "gcData"
        Me.gcData.Size = New System.Drawing.Size(786, 253)
        Me.gcData.TabIndex = 8
        Me.gcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvData})
        '
        'gvData
        '
        Me.gvData.Appearance.Empty.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.gvData.Appearance.Empty.Options.UseBackColor = True
        Me.gvData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcID, Me.gcIDStatData, Me.gcIDCOA, Me.gcCOA, Me.gcRemarks, Me.gcJenis, Me.gcPeriode, Me.gcJumlahUang, Me.gcStatData})
        Me.gvData.GridControl = Me.gcData
        Me.gvData.Name = "gvData"
        Me.gvData.OptionsView.ShowGroupPanel = False
        '
        'gcID
        '
        Me.gcID.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gcID.AppearanceCell.Options.UseBackColor = True
        Me.gcID.Caption = "ID"
        Me.gcID.FieldName = "idanggaran"
        Me.gcID.Name = "gcID"
        Me.gcID.OptionsColumn.AllowEdit = False
        Me.gcID.OptionsColumn.ReadOnly = True
        '
        'gcIDStatData
        '
        Me.gcIDStatData.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gcIDStatData.AppearanceCell.Options.UseBackColor = True
        Me.gcIDStatData.Caption = "ID Status Data"
        Me.gcIDStatData.FieldName = "isdeleted"
        Me.gcIDStatData.Name = "gcIDStatData"
        Me.gcIDStatData.OptionsColumn.AllowEdit = False
        Me.gcIDStatData.OptionsColumn.ReadOnly = True
        '
        'gcIDCOA
        '
        Me.gcIDCOA.Caption = "IDCOA"
        Me.gcIDCOA.FieldName = "idcoa"
        Me.gcIDCOA.Name = "gcIDCOA"
        '
        'gcCOA
        '
        Me.gcCOA.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gcCOA.AppearanceCell.Options.UseBackColor = True
        Me.gcCOA.Caption = "Kode Rekening"
        Me.gcCOA.FieldName = "coa"
        Me.gcCOA.Name = "gcCOA"
        Me.gcCOA.OptionsColumn.AllowEdit = False
        Me.gcCOA.OptionsColumn.ReadOnly = True
        Me.gcCOA.Visible = True
        Me.gcCOA.VisibleIndex = 0
        '
        'gcRemarks
        '
        Me.gcRemarks.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gcRemarks.AppearanceCell.Options.UseBackColor = True
        Me.gcRemarks.Caption = "Remarks"
        Me.gcRemarks.FieldName = "remarks"
        Me.gcRemarks.Name = "gcRemarks"
        Me.gcRemarks.OptionsColumn.AllowEdit = False
        Me.gcRemarks.OptionsColumn.ReadOnly = True
        Me.gcRemarks.Visible = True
        Me.gcRemarks.VisibleIndex = 1
        '
        'gcJenis
        '
        Me.gcJenis.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gcJenis.AppearanceCell.Options.UseBackColor = True
        Me.gcJenis.Caption = "Jenis Anggaran"
        Me.gcJenis.FieldName = "jenis"
        Me.gcJenis.Name = "gcJenis"
        Me.gcJenis.OptionsColumn.AllowEdit = False
        Me.gcJenis.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.gcJenis.OptionsColumn.ReadOnly = True
        Me.gcJenis.Visible = True
        Me.gcJenis.VisibleIndex = 2
        '
        'gcPeriode
        '
        Me.gcPeriode.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gcPeriode.AppearanceCell.Options.UseBackColor = True
        Me.gcPeriode.Caption = "Periode"
        Me.gcPeriode.FieldName = "periode"
        Me.gcPeriode.Name = "gcPeriode"
        Me.gcPeriode.OptionsColumn.AllowEdit = False
        Me.gcPeriode.OptionsColumn.ReadOnly = True
        Me.gcPeriode.Visible = True
        Me.gcPeriode.VisibleIndex = 3
        '
        'gcJumlahUang
        '
        Me.gcJumlahUang.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gcJumlahUang.AppearanceCell.Options.UseBackColor = True
        Me.gcJumlahUang.Caption = "Besar Anggaran"
        Me.gcJumlahUang.DisplayFormat.FormatString = "{0:n2}"
        Me.gcJumlahUang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcJumlahUang.FieldName = "jumlahuang"
        Me.gcJumlahUang.Name = "gcJumlahUang"
        Me.gcJumlahUang.OptionsColumn.AllowEdit = False
        Me.gcJumlahUang.OptionsColumn.ReadOnly = True
        Me.gcJumlahUang.Visible = True
        Me.gcJumlahUang.VisibleIndex = 4
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
        Me.gcStatData.VisibleIndex = 5
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
        Me.tlpField.Controls.Add(Me.lblBank, 1, 1)
        Me.tlpField.Controls.Add(Me.lueCOA, 2, 1)
        Me.tlpField.Controls.Add(Me.nudJumlahUang, 4, 3)
        Me.tlpField.Controls.Add(Me.Label2, 3, 3)
        Me.tlpField.Controls.Add(Me.lueJenis, 4, 1)
        Me.tlpField.Controls.Add(Me.Label3, 3, 1)
        Me.tlpField.Controls.Add(Me.dePeriode, 4, 2)
        Me.tlpField.Controls.Add(Me.Label1, 3, 2)
        Me.tlpField.Controls.Add(Me.Label4, 1, 2)
        Me.tlpField.Controls.Add(Me.teCOA, 2, 2)
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
        'lblBank
        '
        Me.lblBank.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblBank.AutoSize = True
        Me.lblBank.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBank.Location = New System.Drawing.Point(151, 16)
        Me.lblBank.Name = "lblBank"
        Me.lblBank.Size = New System.Drawing.Size(89, 14)
        Me.lblBank.TabIndex = 9
        Me.lblBank.Text = "Kode Rekening"
        Me.lblBank.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueCOA
        '
        Me.lueCOA.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueCOA.Location = New System.Drawing.Point(243, 13)
        Me.lueCOA.Margin = New System.Windows.Forms.Padding(0)
        Me.lueCOA.Name = "lueCOA"
        Me.lueCOA.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueCOA.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueCOA.Properties.Appearance.Options.UseBackColor = True
        Me.lueCOA.Properties.Appearance.Options.UseFont = True
        Me.lueCOA.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueCOA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueCOA.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("idcoa", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("coa", "Kode Rekening"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("remarks", "Remarks")})
        Me.lueCOA.Properties.NullText = "[Isian belum dipilih]"
        Me.lueCOA.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueCOA.Size = New System.Drawing.Size(150, 20)
        Me.lueCOA.TabIndex = 52
        '
        'nudJumlahUang
        '
        Me.nudJumlahUang.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.nudJumlahUang.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.nudJumlahUang.Location = New System.Drawing.Point(533, 61)
        Me.nudJumlahUang.Margin = New System.Windows.Forms.Padding(0)
        Me.nudJumlahUang.Name = "nudJumlahUang"
        Me.nudJumlahUang.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.nudJumlahUang.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.nudJumlahUang.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.nudJumlahUang.Properties.Appearance.Options.UseBackColor = True
        Me.nudJumlahUang.Properties.Appearance.Options.UseFont = True
        Me.nudJumlahUang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.nudJumlahUang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.nudJumlahUang.Properties.DisplayFormat.FormatString = "n2"
        Me.nudJumlahUang.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.nudJumlahUang.Properties.EditFormat.FormatString = "n2"
        Me.nudJumlahUang.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.nudJumlahUang.Properties.IsFloatValue = False
        Me.nudJumlahUang.Properties.Mask.EditMask = "N00"
        Me.nudJumlahUang.Properties.MaxLength = 15
        Me.nudJumlahUang.Properties.MaxValue = New Decimal(New Integer() {-1530494977, 232830, 0, 0})
        Me.nudJumlahUang.Size = New System.Drawing.Size(150, 20)
        Me.nudJumlahUang.TabIndex = 56
        Me.nudJumlahUang.Tag = ""
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(438, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 14)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Besar Anggaran"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueJenis
        '
        Me.lueJenis.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueJenis.Location = New System.Drawing.Point(533, 13)
        Me.lueJenis.Margin = New System.Windows.Forms.Padding(0)
        Me.lueJenis.Name = "lueJenis"
        Me.lueJenis.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueJenis.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueJenis.Properties.Appearance.Options.UseBackColor = True
        Me.lueJenis.Properties.Appearance.Options.UseFont = True
        Me.lueJenis.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueJenis.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueJenis.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("idjenis", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("jenis", "Jenis Anggaran")})
        Me.lueJenis.Properties.NullText = "[Isian belum dipilih]"
        Me.lueJenis.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueJenis.Size = New System.Drawing.Size(150, 20)
        Me.lueJenis.TabIndex = 55
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(441, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 14)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Jenis Anggaran"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dePeriode
        '
        Me.dePeriode.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dePeriode.EditValue = Nothing
        Me.dePeriode.Location = New System.Drawing.Point(533, 37)
        Me.dePeriode.Margin = New System.Windows.Forms.Padding(0)
        Me.dePeriode.Name = "dePeriode"
        Me.dePeriode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dePeriode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dePeriode.Properties.Appearance.Options.UseBackColor = True
        Me.dePeriode.Properties.Appearance.Options.UseFont = True
        Me.dePeriode.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dePeriode.Properties.AppearanceDisabled.Options.UseFont = True
        Me.dePeriode.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dePeriode.Properties.AppearanceDropDown.Options.UseFont = True
        Me.dePeriode.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dePeriode.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.dePeriode.Properties.AppearanceDropDownHeaderHighlight.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dePeriode.Properties.AppearanceDropDownHeaderHighlight.Options.UseFont = True
        Me.dePeriode.Properties.AppearanceDropDownHighlight.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dePeriode.Properties.AppearanceDropDownHighlight.Options.UseFont = True
        Me.dePeriode.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dePeriode.Properties.AppearanceFocused.Options.UseFont = True
        Me.dePeriode.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dePeriode.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.dePeriode.Properties.AppearanceWeekNumber.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dePeriode.Properties.AppearanceWeekNumber.Options.UseFont = True
        Me.dePeriode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.dePeriode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dePeriode.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dePeriode.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.dePeriode.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dePeriode.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.dePeriode.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dePeriode.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.dePeriode.Size = New System.Drawing.Size(135, 20)
        Me.dePeriode.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(482, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 14)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Periode"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(188, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 14)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Remarks"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teCOA
        '
        Me.teCOA.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teCOA.Location = New System.Drawing.Point(243, 37)
        Me.teCOA.Margin = New System.Windows.Forms.Padding(0)
        Me.teCOA.Name = "teCOA"
        Me.teCOA.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.teCOA.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teCOA.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teCOA.Properties.Appearance.Options.UseBackColor = True
        Me.teCOA.Properties.Appearance.Options.UseFont = True
        Me.teCOA.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teCOA.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teCOA.Properties.MaxLength = 500
        Me.teCOA.Properties.NullText = "[Belum Diisi]"
        Me.teCOA.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teCOA.Properties.ReadOnly = True
        Me.teCOA.Size = New System.Drawing.Size(150, 20)
        Me.teCOA.TabIndex = 58
        Me.teCOA.Tag = ""
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Controls.Add(Me.slueCOA)
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
        'slueCOA
        '
        Me.slueCOA.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.slueCOA.Location = New System.Drawing.Point(304, 5)
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
        Me.slueCOA.Size = New System.Drawing.Size(178, 20)
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
        'frmAnggaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.ClientSize = New System.Drawing.Size(790, 408)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAnggaran"
        Me.ShowInTaskbar = False
        Me.Text = "Anggaran"
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
        CType(Me.lueCOA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudJumlahUang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueJenis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dePeriode.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dePeriode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teCOA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        CType(Me.slueCOA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueCOAView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents gcID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcCOA As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents gcStatData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcIDStatData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcJenis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lueCOA As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dePeriode As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lueJenis As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents nudJumlahUang As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents gcIDCOA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcPeriode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcJumlahUang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents teCOA As DevExpress.XtraEditors.TextEdit
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
