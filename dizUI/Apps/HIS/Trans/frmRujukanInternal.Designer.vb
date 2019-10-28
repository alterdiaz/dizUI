<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRujukanInternal
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
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.pBody = New System.Windows.Forms.Panel()
        Me.tlpField = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpKunjungan = New System.Windows.Forms.TableLayoutPanel()
        Me.lueParamedis = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.slueView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lueODS = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lueSesi = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lueSpesialis = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.teJenisKunjungan = New DevExpress.XtraEditors.TextEdit()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lueRuang = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tlpRegistrasi = New System.Windows.Forms.TableLayoutPanel()
        Me.teDeptInduk = New DevExpress.XtraEditors.TextEdit()
        Me.lblDeptInduk = New System.Windows.Forms.Label()
        Me.teNoRegistrasiInduk = New DevExpress.XtraEditors.TextEdit()
        Me.teNoRegistrasi = New DevExpress.XtraEditors.TextEdit()
        Me.teTanggalPendaftaran = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeader.SuspendLayout()
        Me.pBody.SuspendLayout()
        Me.tlpField.SuspendLayout()
        Me.tlpKunjungan.SuspendLayout()
        CType(Me.lueParamedis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueODS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueSesi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueSpesialis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teJenisKunjungan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueRuang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.tlpRegistrasi.SuspendLayout()
        CType(Me.teDeptInduk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNoRegistrasiInduk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNoRegistrasi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teTanggalPendaftaran.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tlpForm.Controls.Add(Me.pHeader, 1, 1)
        Me.tlpForm.Controls.Add(Me.pBody, 1, 2)
        Me.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpForm.Location = New System.Drawing.Point(0, 0)
        Me.tlpForm.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpForm.Name = "tlpForm"
        Me.tlpForm.RowCount = 3
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.Size = New System.Drawing.Size(654, 228)
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
        Me.pTitle.Size = New System.Drawing.Size(650, 30)
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
        Me.lblTitle.Size = New System.Drawing.Size(560, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Rujukan Internal"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pMinimize
        '
        Me.pMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.pMinimize.Image = Global.dizUI.My.Resources.Resources.min_w
        Me.pMinimize.Location = New System.Drawing.Point(560, 0)
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
        Me.pMaximize.Location = New System.Drawing.Point(590, 0)
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
        Me.pExit.Location = New System.Drawing.Point(620, 0)
        Me.pExit.Margin = New System.Windows.Forms.Padding(0)
        Me.pExit.Name = "pExit"
        Me.pExit.Size = New System.Drawing.Size(30, 30)
        Me.pExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pExit.TabIndex = 9
        Me.pExit.TabStop = False
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Controls.Add(Me.btnSave)
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pHeader.ForeColor = System.Drawing.Color.White
        Me.pHeader.Location = New System.Drawing.Point(2, 30)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(650, 30)
        Me.pHeader.TabIndex = 103
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
        Me.btnSave.Location = New System.Drawing.Point(570, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "SIMPAN"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'pBody
        '
        Me.pBody.AutoScroll = True
        Me.pBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pBody.Controls.Add(Me.tlpField)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 60)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(650, 168)
        Me.pBody.TabIndex = 7
        '
        'tlpField
        '
        Me.tlpField.AutoSize = True
        Me.tlpField.ColumnCount = 3
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 640.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.Controls.Add(Me.tlpKunjungan, 1, 4)
        Me.tlpField.Controls.Add(Me.Panel2, 1, 3)
        Me.tlpField.Controls.Add(Me.tlpRegistrasi, 1, 1)
        Me.tlpField.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpField.Location = New System.Drawing.Point(0, 0)
        Me.tlpField.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpField.Name = "tlpField"
        Me.tlpField.RowCount = 6
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpField.Size = New System.Drawing.Size(650, 168)
        Me.tlpField.TabIndex = 102
        '
        'tlpKunjungan
        '
        Me.tlpKunjungan.AutoSize = True
        Me.tlpKunjungan.ColumnCount = 4
        Me.tlpKunjungan.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.tlpKunjungan.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.tlpKunjungan.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpKunjungan.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220.0!))
        Me.tlpKunjungan.Controls.Add(Me.lueParamedis, 1, 0)
        Me.tlpKunjungan.Controls.Add(Me.lueODS, 3, 2)
        Me.tlpKunjungan.Controls.Add(Me.Label4, 2, 2)
        Me.tlpKunjungan.Controls.Add(Me.lueSesi, 1, 1)
        Me.tlpKunjungan.Controls.Add(Me.Label3, 0, 1)
        Me.tlpKunjungan.Controls.Add(Me.lueSpesialis, 3, 0)
        Me.tlpKunjungan.Controls.Add(Me.Label18, 0, 0)
        Me.tlpKunjungan.Controls.Add(Me.Label20, 2, 0)
        Me.tlpKunjungan.Controls.Add(Me.teJenisKunjungan, 1, 2)
        Me.tlpKunjungan.Controls.Add(Me.Label19, 0, 2)
        Me.tlpKunjungan.Controls.Add(Me.lueRuang, 3, 1)
        Me.tlpKunjungan.Controls.Add(Me.Label21, 2, 1)
        Me.tlpKunjungan.Location = New System.Drawing.Point(5, 90)
        Me.tlpKunjungan.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpKunjungan.Name = "tlpKunjungan"
        Me.tlpKunjungan.RowCount = 3
        Me.tlpKunjungan.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpKunjungan.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpKunjungan.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpKunjungan.Size = New System.Drawing.Size(640, 72)
        Me.tlpKunjungan.TabIndex = 102
        '
        'lueParamedis
        '
        Me.lueParamedis.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueParamedis.Location = New System.Drawing.Point(140, 2)
        Me.lueParamedis.Margin = New System.Windows.Forms.Padding(0)
        Me.lueParamedis.Name = "lueParamedis"
        Me.lueParamedis.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueParamedis.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueParamedis.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lueParamedis.Properties.Appearance.Options.UseBackColor = True
        Me.lueParamedis.Properties.Appearance.Options.UseFont = True
        Me.lueParamedis.Properties.Appearance.Options.UseForeColor = True
        Me.lueParamedis.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueParamedis.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueParamedis.Properties.NullText = "[Isian belum dipilih]"
        Me.lueParamedis.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueParamedis.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Simple
        Me.lueParamedis.Properties.PopupFindMode = DevExpress.XtraEditors.FindMode.Always
        Me.lueParamedis.Properties.PopupView = Me.slueView
        Me.lueParamedis.Properties.ShowFooter = False
        Me.lueParamedis.Properties.ShowPopupShadow = False
        Me.lueParamedis.Properties.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView
        Me.lueParamedis.Size = New System.Drawing.Size(160, 20)
        Me.lueParamedis.TabIndex = 48
        Me.lueParamedis.Tag = "idparamedis"
        '
        'slueView
        '
        Me.slueView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.slueView.Appearance.EvenRow.Options.UseBackColor = True
        Me.slueView.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.slueView.Appearance.OddRow.Options.UseBackColor = True
        Me.slueView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn13, Me.GridColumn14})
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
        'lueODS
        '
        Me.lueODS.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueODS.Location = New System.Drawing.Point(420, 50)
        Me.lueODS.Margin = New System.Windows.Forms.Padding(0)
        Me.lueODS.Name = "lueODS"
        Me.lueODS.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueODS.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueODS.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueODS.Properties.Appearance.Options.UseBackColor = True
        Me.lueODS.Properties.Appearance.Options.UseFont = True
        Me.lueODS.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueODS.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.lueODS.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueODS.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.lueODS.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lueODS.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueODS.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueODS.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueODS.Properties.NullText = "[Isian belum dipilih]"
        Me.lueODS.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueODS.Size = New System.Drawing.Size(138, 20)
        Me.lueODS.TabIndex = 15
        Me.lueODS.Tag = "idlokasi"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(349, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 14)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "ODC / ODS"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueSesi
        '
        Me.lueSesi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueSesi.Location = New System.Drawing.Point(140, 26)
        Me.lueSesi.Margin = New System.Windows.Forms.Padding(0)
        Me.lueSesi.Name = "lueSesi"
        Me.lueSesi.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueSesi.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueSesi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueSesi.Properties.Appearance.Options.UseBackColor = True
        Me.lueSesi.Properties.Appearance.Options.UseFont = True
        Me.lueSesi.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lueSesi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueSesi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueSesi.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueSesi.Properties.NullText = "[Isian belum dipilih]"
        Me.lueSesi.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueSesi.Size = New System.Drawing.Size(160, 20)
        Me.lueSesi.TabIndex = 16
        Me.lueSesi.Tag = "idjadwalsesi"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(109, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 14)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Sesi"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueSpesialis
        '
        Me.lueSpesialis.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueSpesialis.Location = New System.Drawing.Point(420, 2)
        Me.lueSpesialis.Margin = New System.Windows.Forms.Padding(0)
        Me.lueSpesialis.Name = "lueSpesialis"
        Me.lueSpesialis.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueSpesialis.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueSpesialis.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueSpesialis.Properties.Appearance.Options.UseBackColor = True
        Me.lueSpesialis.Properties.Appearance.Options.UseFont = True
        Me.lueSpesialis.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lueSpesialis.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueSpesialis.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueSpesialis.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueSpesialis.Properties.NullText = "[Isian belum dipilih]"
        Me.lueSpesialis.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueSpesialis.Size = New System.Drawing.Size(220, 20)
        Me.lueSpesialis.TabIndex = 15
        Me.lueSpesialis.Tag = "idspesialis"
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(5, 5)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(132, 14)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "Dokter / Tenaga Medis"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(354, 5)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(63, 14)
        Me.Label20.TabIndex = 23
        Me.Label20.Text = "Spesialisasi"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teJenisKunjungan
        '
        Me.teJenisKunjungan.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teJenisKunjungan.Location = New System.Drawing.Point(140, 50)
        Me.teJenisKunjungan.Margin = New System.Windows.Forms.Padding(0)
        Me.teJenisKunjungan.Name = "teJenisKunjungan"
        Me.teJenisKunjungan.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teJenisKunjungan.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teJenisKunjungan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teJenisKunjungan.Properties.Appearance.Options.UseBackColor = True
        Me.teJenisKunjungan.Properties.Appearance.Options.UseFont = True
        Me.teJenisKunjungan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teJenisKunjungan.Properties.MaxLength = 300
        Me.teJenisKunjungan.Properties.NullText = "[Belum Diisi]"
        Me.teJenisKunjungan.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teJenisKunjungan.Size = New System.Drawing.Size(160, 20)
        Me.teJenisKunjungan.TabIndex = 22
        Me.teJenisKunjungan.Tag = "namapanggilan"
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(42, 53)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(95, 14)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "Jenis Kunjungan"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueRuang
        '
        Me.lueRuang.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueRuang.Location = New System.Drawing.Point(420, 26)
        Me.lueRuang.Margin = New System.Windows.Forms.Padding(0)
        Me.lueRuang.Name = "lueRuang"
        Me.lueRuang.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueRuang.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueRuang.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueRuang.Properties.Appearance.Options.UseBackColor = True
        Me.lueRuang.Properties.Appearance.Options.UseFont = True
        Me.lueRuang.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lueRuang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueRuang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueRuang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueRuang.Properties.NullText = "[Isian belum dipilih]"
        Me.lueRuang.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueRuang.Size = New System.Drawing.Size(220, 20)
        Me.lueRuang.TabIndex = 14
        Me.lueRuang.Tag = "idlokasi"
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(376, 29)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(41, 14)
        Me.Label21.TabIndex = 24
        Me.Label21.Text = "Ruang"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(5, 60)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(640, 30)
        Me.Panel2.TabIndex = 101
        '
        'Label17
        '
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(0, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label17.Size = New System.Drawing.Size(200, 30)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Kunjungan"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpRegistrasi
        '
        Me.tlpRegistrasi.ColumnCount = 4
        Me.tlpRegistrasi.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.tlpRegistrasi.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190.0!))
        Me.tlpRegistrasi.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpRegistrasi.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190.0!))
        Me.tlpRegistrasi.Controls.Add(Me.Label1, 0, 1)
        Me.tlpRegistrasi.Controls.Add(Me.teDeptInduk, 3, 1)
        Me.tlpRegistrasi.Controls.Add(Me.lblDeptInduk, 2, 1)
        Me.tlpRegistrasi.Controls.Add(Me.teNoRegistrasiInduk, 1, 1)
        Me.tlpRegistrasi.Controls.Add(Me.teNoRegistrasi, 1, 0)
        Me.tlpRegistrasi.Controls.Add(Me.teTanggalPendaftaran, 3, 0)
        Me.tlpRegistrasi.Controls.Add(Me.Label6, 2, 0)
        Me.tlpRegistrasi.Controls.Add(Me.Label13, 0, 0)
        Me.tlpRegistrasi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpRegistrasi.Location = New System.Drawing.Point(5, 6)
        Me.tlpRegistrasi.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpRegistrasi.Name = "tlpRegistrasi"
        Me.tlpRegistrasi.RowCount = 2
        Me.tlpRegistrasi.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpRegistrasi.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpRegistrasi.Size = New System.Drawing.Size(640, 48)
        Me.tlpRegistrasi.TabIndex = 102
        '
        'teDeptInduk
        '
        Me.teDeptInduk.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teDeptInduk.Location = New System.Drawing.Point(450, 26)
        Me.teDeptInduk.Margin = New System.Windows.Forms.Padding(0)
        Me.teDeptInduk.Name = "teDeptInduk"
        Me.teDeptInduk.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teDeptInduk.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teDeptInduk.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teDeptInduk.Properties.Appearance.Options.UseBackColor = True
        Me.teDeptInduk.Properties.Appearance.Options.UseFont = True
        Me.teDeptInduk.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teDeptInduk.Properties.MaxLength = 300
        Me.teDeptInduk.Properties.NullText = "[Belum Diisi]"
        Me.teDeptInduk.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teDeptInduk.Size = New System.Drawing.Size(150, 20)
        Me.teDeptInduk.TabIndex = 22
        Me.teDeptInduk.Tag = "namapanggilan"
        '
        'lblDeptInduk
        '
        Me.lblDeptInduk.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblDeptInduk.AutoSize = True
        Me.lblDeptInduk.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeptInduk.Location = New System.Drawing.Point(365, 29)
        Me.lblDeptInduk.Name = "lblDeptInduk"
        Me.lblDeptInduk.Size = New System.Drawing.Size(82, 14)
        Me.lblDeptInduk.TabIndex = 23
        Me.lblDeptInduk.Text = "Asal Registrasi"
        Me.lblDeptInduk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teNoRegistrasiInduk
        '
        Me.teNoRegistrasiInduk.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNoRegistrasiInduk.Location = New System.Drawing.Point(140, 26)
        Me.teNoRegistrasiInduk.Margin = New System.Windows.Forms.Padding(0)
        Me.teNoRegistrasiInduk.Name = "teNoRegistrasiInduk"
        Me.teNoRegistrasiInduk.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teNoRegistrasiInduk.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNoRegistrasiInduk.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNoRegistrasiInduk.Properties.Appearance.Options.UseBackColor = True
        Me.teNoRegistrasiInduk.Properties.Appearance.Options.UseFont = True
        Me.teNoRegistrasiInduk.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNoRegistrasiInduk.Properties.MaxLength = 300
        Me.teNoRegistrasiInduk.Properties.NullText = "[Belum Diisi]"
        Me.teNoRegistrasiInduk.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNoRegistrasiInduk.Size = New System.Drawing.Size(190, 20)
        Me.teNoRegistrasiInduk.TabIndex = 21
        Me.teNoRegistrasiInduk.Tag = "namapanggilan"
        '
        'teNoRegistrasi
        '
        Me.teNoRegistrasi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNoRegistrasi.Location = New System.Drawing.Point(140, 2)
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
        Me.teNoRegistrasi.Size = New System.Drawing.Size(190, 20)
        Me.teNoRegistrasi.TabIndex = 20
        Me.teNoRegistrasi.Tag = "namapanggilan"
        '
        'teTanggalPendaftaran
        '
        Me.teTanggalPendaftaran.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teTanggalPendaftaran.Location = New System.Drawing.Point(450, 2)
        Me.teTanggalPendaftaran.Margin = New System.Windows.Forms.Padding(0)
        Me.teTanggalPendaftaran.Name = "teTanggalPendaftaran"
        Me.teTanggalPendaftaran.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teTanggalPendaftaran.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teTanggalPendaftaran.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teTanggalPendaftaran.Properties.Appearance.Options.UseBackColor = True
        Me.teTanggalPendaftaran.Properties.Appearance.Options.UseFont = True
        Me.teTanggalPendaftaran.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teTanggalPendaftaran.Properties.MaxLength = 300
        Me.teTanggalPendaftaran.Properties.NullText = "[Belum Diisi]"
        Me.teTanggalPendaftaran.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teTanggalPendaftaran.Size = New System.Drawing.Size(150, 20)
        Me.teTanggalPendaftaran.TabIndex = 20
        Me.teTanggalPendaftaran.Tag = "namapanggilan"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(353, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 14)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Tgl Pendaftaran"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(57, 5)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 14)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "No. Registrasi"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 14)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "No. Registrasi Induk"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmRujukanInternal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(654, 228)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRujukanInternal"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rujukan Internal"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        Me.pBody.ResumeLayout(False)
        Me.pBody.PerformLayout()
        Me.tlpField.ResumeLayout(False)
        Me.tlpField.PerformLayout()
        Me.tlpKunjungan.ResumeLayout(False)
        Me.tlpKunjungan.PerformLayout()
        CType(Me.lueParamedis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueODS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueSesi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueSpesialis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teJenisKunjungan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueRuang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.tlpRegistrasi.ResumeLayout(False)
        Me.tlpRegistrasi.PerformLayout()
        CType(Me.teDeptInduk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNoRegistrasiInduk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNoRegistrasi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teTanggalPendaftaran.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents pBody As System.Windows.Forms.Panel
    Public WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Friend WithEvents tlpField As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpRegistrasi As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents teNoRegistrasi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teTanggalPendaftaran As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents pHeader As System.Windows.Forms.Panel
    Public WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents tlpKunjungan As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents teJenisKunjungan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lueRuang As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Public WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lueSpesialis As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueSesi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents teNoRegistrasiInduk As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDeptInduk As Label
    Friend WithEvents teDeptInduk As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lueODS As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label4 As Label
    Friend WithEvents lueParamedis As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents slueView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As Label
End Class
