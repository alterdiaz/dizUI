<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmParamedisQuickAdd
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
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.tlpField = New System.Windows.Forms.TableLayoutPanel()
        Me.lueService = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.lueParamedisType = New DevExpress.XtraEditors.LookUpEdit()
        Me.teParamedis = New DevExpress.XtraEditors.TextEdit()
        Me.lblKaryawan = New System.Windows.Forms.Label()
        Me.lblNIK = New System.Windows.Forms.Label()
        Me.lueAgama = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lueJenisKelamin = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueKewarganegaraan = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueTempatLahir = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.deTanggalLahir = New DevExpress.XtraEditors.DateEdit()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lueUsername = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnClearUsername = New System.Windows.Forms.Button()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBody.SuspendLayout()
        Me.pHeader.SuspendLayout()
        Me.tlpField.SuspendLayout()
        CType(Me.lueService.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueParamedisType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teParamedis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueAgama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueJenisKelamin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueKewarganegaraan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueTempatLahir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggalLahir.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggalLahir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueUsername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tlpForm.Size = New System.Drawing.Size(458, 288)
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
        Me.pTitle.Size = New System.Drawing.Size(454, 30)
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
        Me.lblTitle.Size = New System.Drawing.Size(364, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Data Paramedis - Tambah Cepat"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pMinimize
        '
        Me.pMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.pMinimize.Image = Global.dizUI.My.Resources.Resources.min_w
        Me.pMinimize.Location = New System.Drawing.Point(364, 0)
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
        Me.pMaximize.Location = New System.Drawing.Point(394, 0)
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
        Me.pExit.Location = New System.Drawing.Point(424, 0)
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
        Me.pBody.Size = New System.Drawing.Size(454, 256)
        Me.pBody.TabIndex = 7
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Controls.Add(Me.btnNew)
        Me.pHeader.Controls.Add(Me.btnSave)
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.ForeColor = System.Drawing.Color.White
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(454, 30)
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
        Me.btnNew.Location = New System.Drawing.Point(314, 0)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(60, 30)
        Me.btnNew.TabIndex = 22
        Me.btnNew.Text = "BARU"
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNew.UseVisualStyleBackColor = True
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
        Me.btnSave.Location = New System.Drawing.Point(374, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 21
        Me.btnSave.Text = "SIMPAN"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'tlpField
        '
        Me.tlpField.AutoSize = True
        Me.tlpField.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpField.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlpField.ColumnCount = 5
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpField.Controls.Add(Me.lueService, 2, 5)
        Me.tlpField.Controls.Add(Me.Label66, 1, 5)
        Me.tlpField.Controls.Add(Me.lueParamedisType, 2, 1)
        Me.tlpField.Controls.Add(Me.teParamedis, 2, 2)
        Me.tlpField.Controls.Add(Me.lblKaryawan, 1, 2)
        Me.tlpField.Controls.Add(Me.lblNIK, 1, 1)
        Me.tlpField.Controls.Add(Me.lueKewarganegaraan, 2, 3)
        Me.tlpField.Controls.Add(Me.lueTempatLahir, 2, 4)
        Me.tlpField.Controls.Add(Me.Label40, 1, 3)
        Me.tlpField.Controls.Add(Me.Label43, 1, 4)
        Me.tlpField.Controls.Add(Me.Label38, 1, 6)
        Me.tlpField.Controls.Add(Me.lueAgama, 2, 6)
        Me.tlpField.Controls.Add(Me.lueJenisKelamin, 2, 7)
        Me.tlpField.Controls.Add(Me.Label24, 1, 7)
        Me.tlpField.Controls.Add(Me.deTanggalLahir, 2, 8)
        Me.tlpField.Controls.Add(Me.Label39, 1, 8)
        Me.tlpField.Controls.Add(Me.lblUsername, 1, 9)
        Me.tlpField.Controls.Add(Me.lueUsername, 2, 9)
        Me.tlpField.Controls.Add(Me.btnClearUsername, 3, 9)
        Me.tlpField.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpField.Location = New System.Drawing.Point(0, 30)
        Me.tlpField.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpField.Name = "tlpField"
        Me.tlpField.RowCount = 11
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpField.Size = New System.Drawing.Size(454, 228)
        Me.tlpField.TabIndex = 8
        '
        'lueService
        '
        Me.lueService.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueService.Location = New System.Drawing.Point(152, 104)
        Me.lueService.Margin = New System.Windows.Forms.Padding(0)
        Me.lueService.Name = "lueService"
        Me.lueService.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueService.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueService.Properties.Appearance.Options.UseBackColor = True
        Me.lueService.Properties.Appearance.Options.UseFont = True
        Me.lueService.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueService.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueService.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueService.Properties.NullText = "[Isian belum dipilih]"
        Me.lueService.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueService.Size = New System.Drawing.Size(150, 20)
        Me.lueService.TabIndex = 20
        Me.lueService.Tag = "agama"
        '
        'Label66
        '
        Me.Label66.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label66.AutoSize = True
        Me.Label66.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label66.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.Location = New System.Drawing.Point(72, 107)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(77, 14)
        Me.Label66.TabIndex = 44
        Me.Label66.Text = "Ketersediaan"
        Me.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueParamedisType
        '
        Me.lueParamedisType.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueParamedisType.Location = New System.Drawing.Point(152, 8)
        Me.lueParamedisType.Margin = New System.Windows.Forms.Padding(0)
        Me.lueParamedisType.Name = "lueParamedisType"
        Me.lueParamedisType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueParamedisType.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueParamedisType.Properties.Appearance.Options.UseBackColor = True
        Me.lueParamedisType.Properties.Appearance.Options.UseFont = True
        Me.lueParamedisType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueParamedisType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueParamedisType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueParamedisType.Properties.NullText = "[Isian belum dipilih]"
        Me.lueParamedisType.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueParamedisType.Size = New System.Drawing.Size(150, 20)
        Me.lueParamedisType.TabIndex = 19
        Me.lueParamedisType.Tag = "agama"
        '
        'teParamedis
        '
        Me.teParamedis.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teParamedis.Location = New System.Drawing.Point(152, 32)
        Me.teParamedis.Margin = New System.Windows.Forms.Padding(0)
        Me.teParamedis.Name = "teParamedis"
        Me.teParamedis.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teParamedis.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teParamedis.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teParamedis.Properties.Appearance.Options.UseBackColor = True
        Me.teParamedis.Properties.Appearance.Options.UseFont = True
        Me.teParamedis.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teParamedis.Properties.MaxLength = 10
        Me.teParamedis.Properties.NullText = "[Belum Diisi]"
        Me.teParamedis.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teParamedis.Size = New System.Drawing.Size(150, 20)
        Me.teParamedis.TabIndex = 12
        Me.teParamedis.Tag = "nama"
        '
        'lblKaryawan
        '
        Me.lblKaryawan.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblKaryawan.AutoSize = True
        Me.lblKaryawan.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKaryawan.Location = New System.Drawing.Point(54, 35)
        Me.lblKaryawan.Name = "lblKaryawan"
        Me.lblKaryawan.Size = New System.Drawing.Size(95, 14)
        Me.lblKaryawan.TabIndex = 9
        Me.lblKaryawan.Text = "Nama Paramedis"
        Me.lblKaryawan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNIK
        '
        Me.lblNIK.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblNIK.AutoSize = True
        Me.lblNIK.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNIK.Location = New System.Drawing.Point(58, 11)
        Me.lblNIK.Name = "lblNIK"
        Me.lblNIK.Size = New System.Drawing.Size(91, 14)
        Me.lblNIK.TabIndex = 18
        Me.lblNIK.Text = "Jenis Paramedis"
        Me.lblNIK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueAgama
        '
        Me.lueAgama.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueAgama.Location = New System.Drawing.Point(152, 128)
        Me.lueAgama.Margin = New System.Windows.Forms.Padding(0)
        Me.lueAgama.Name = "lueAgama"
        Me.lueAgama.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueAgama.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueAgama.Properties.Appearance.Options.UseBackColor = True
        Me.lueAgama.Properties.Appearance.Options.UseFont = True
        Me.lueAgama.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueAgama.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueAgama.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueAgama.Properties.NullText = "[Isian belum dipilih]"
        Me.lueAgama.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueAgama.Size = New System.Drawing.Size(150, 20)
        Me.lueAgama.TabIndex = 18
        Me.lueAgama.Tag = "agama"
        '
        'Label38
        '
        Me.Label38.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(105, 131)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(44, 14)
        Me.Label38.TabIndex = 67
        Me.Label38.Text = "Agama"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(71, 155)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(78, 14)
        Me.Label24.TabIndex = 67
        Me.Label24.Text = "Jenis Kelamin"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueJenisKelamin
        '
        Me.lueJenisKelamin.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueJenisKelamin.Location = New System.Drawing.Point(152, 152)
        Me.lueJenisKelamin.Margin = New System.Windows.Forms.Padding(0)
        Me.lueJenisKelamin.Name = "lueJenisKelamin"
        Me.lueJenisKelamin.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueJenisKelamin.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueJenisKelamin.Properties.Appearance.Options.UseBackColor = True
        Me.lueJenisKelamin.Properties.Appearance.Options.UseFont = True
        Me.lueJenisKelamin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueJenisKelamin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueJenisKelamin.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueJenisKelamin.Properties.NullText = "[Isian belum dipilih]"
        Me.lueJenisKelamin.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueJenisKelamin.Size = New System.Drawing.Size(150, 20)
        Me.lueJenisKelamin.TabIndex = 20
        Me.lueJenisKelamin.Tag = "jeniskelamin"
        '
        'lueKewarganegaraan
        '
        Me.lueKewarganegaraan.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueKewarganegaraan.Location = New System.Drawing.Point(152, 56)
        Me.lueKewarganegaraan.Margin = New System.Windows.Forms.Padding(0)
        Me.lueKewarganegaraan.Name = "lueKewarganegaraan"
        Me.lueKewarganegaraan.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueKewarganegaraan.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueKewarganegaraan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueKewarganegaraan.Properties.Appearance.Options.UseBackColor = True
        Me.lueKewarganegaraan.Properties.Appearance.Options.UseFont = True
        Me.lueKewarganegaraan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueKewarganegaraan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueKewarganegaraan.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueKewarganegaraan.Properties.NullText = "[Isian belum dipilih]"
        Me.lueKewarganegaraan.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueKewarganegaraan.Size = New System.Drawing.Size(150, 20)
        Me.lueKewarganegaraan.TabIndex = 16
        Me.lueKewarganegaraan.Tag = "kewarganegaraan"
        '
        'lueTempatLahir
        '
        Me.lueTempatLahir.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueTempatLahir.Location = New System.Drawing.Point(152, 80)
        Me.lueTempatLahir.Margin = New System.Windows.Forms.Padding(0)
        Me.lueTempatLahir.Name = "lueTempatLahir"
        Me.lueTempatLahir.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueTempatLahir.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueTempatLahir.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueTempatLahir.Properties.Appearance.Options.UseBackColor = True
        Me.lueTempatLahir.Properties.Appearance.Options.UseFont = True
        Me.lueTempatLahir.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueTempatLahir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueTempatLahir.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueTempatLahir.Properties.NullText = "[Isian belum dipilih]"
        Me.lueTempatLahir.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueTempatLahir.Size = New System.Drawing.Size(150, 20)
        Me.lueTempatLahir.TabIndex = 17
        Me.lueTempatLahir.Tag = "kotalahir"
        '
        'Label40
        '
        Me.Label40.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label40.AutoSize = True
        Me.Label40.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label40.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(52, 59)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(97, 14)
        Me.Label40.TabIndex = 42
        Me.Label40.Text = "Warganegara *1"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label43
        '
        Me.Label43.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label43.AutoSize = True
        Me.Label43.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label43.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(70, 83)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(79, 14)
        Me.Label43.TabIndex = 43
        Me.Label43.Text = "Kota Lahir *2"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label39
        '
        Me.Label39.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(70, 179)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(79, 14)
        Me.Label39.TabIndex = 42
        Me.Label39.Text = "Tanggal Lahir"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'deTanggalLahir
        '
        Me.deTanggalLahir.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.deTanggalLahir.EditValue = Nothing
        Me.deTanggalLahir.Location = New System.Drawing.Point(152, 176)
        Me.deTanggalLahir.Margin = New System.Windows.Forms.Padding(0)
        Me.deTanggalLahir.Name = "deTanggalLahir"
        Me.deTanggalLahir.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deTanggalLahir.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalLahir.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.deTanggalLahir.Properties.Appearance.Options.UseBackColor = True
        Me.deTanggalLahir.Properties.Appearance.Options.UseFont = True
        Me.deTanggalLahir.Properties.Appearance.Options.UseForeColor = True
        Me.deTanggalLahir.Properties.AppearanceCalendar.DayCellHighlighted.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalLahir.Properties.AppearanceCalendar.DayCellHighlighted.Options.UseFont = True
        Me.deTanggalLahir.Properties.AppearanceCalendar.Header.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalLahir.Properties.AppearanceCalendar.Header.Options.UseFont = True
        Me.deTanggalLahir.Properties.AppearanceCalendar.HeaderHighlighted.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalLahir.Properties.AppearanceCalendar.HeaderHighlighted.Options.UseFont = True
        Me.deTanggalLahir.Properties.AppearanceCalendar.WeekNumber.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalLahir.Properties.AppearanceCalendar.WeekNumber.Options.UseFont = True
        Me.deTanggalLahir.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalLahir.Properties.AppearanceDisabled.Options.UseFont = True
        Me.deTanggalLahir.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalLahir.Properties.AppearanceDropDown.Options.UseFont = True
        Me.deTanggalLahir.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalLahir.Properties.AppearanceFocused.Options.UseFont = True
        Me.deTanggalLahir.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalLahir.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.deTanggalLahir.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.deTanggalLahir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deTanggalLahir.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.[True]
        Me.deTanggalLahir.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.deTanggalLahir.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic
        Me.deTanggalLahir.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.deTanggalLahir.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTanggalLahir.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.deTanggalLahir.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTanggalLahir.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.deTanggalLahir.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.deTanggalLahir.Size = New System.Drawing.Size(133, 20)
        Me.deTanggalLahir.TabIndex = 23
        Me.deTanggalLahir.Tag = "tanggallahir"
        '
        'lblUsername
        '
        Me.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(88, 203)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(61, 14)
        Me.lblUsername.TabIndex = 62
        Me.lblUsername.Text = "Username"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueUsername
        '
        Me.lueUsername.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueUsername.Location = New System.Drawing.Point(152, 200)
        Me.lueUsername.Margin = New System.Windows.Forms.Padding(0)
        Me.lueUsername.Name = "lueUsername"
        Me.lueUsername.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.lueUsername.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueUsername.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueUsername.Properties.Appearance.Options.UseBackColor = True
        Me.lueUsername.Properties.Appearance.Options.UseFont = True
        Me.lueUsername.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueUsername.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueUsername.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("iduser", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("username", "Username"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("userlevel", "User Level")})
        Me.lueUsername.Properties.NullText = "[Isian belum dipilih]"
        Me.lueUsername.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueUsername.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never
        Me.lueUsername.Size = New System.Drawing.Size(150, 20)
        Me.lueUsername.TabIndex = 24
        Me.lueUsername.Tag = "iduser"
        '
        'btnClearUsername
        '
        Me.btnClearUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnClearUsername.FlatAppearance.BorderSize = 0
        Me.btnClearUsername.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnClearUsername.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnClearUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearUsername.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearUsername.ForeColor = System.Drawing.Color.White
        Me.btnClearUsername.Location = New System.Drawing.Point(306, 198)
        Me.btnClearUsername.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnClearUsername.Name = "btnClearUsername"
        Me.btnClearUsername.Size = New System.Drawing.Size(116, 24)
        Me.btnClearUsername.TabIndex = 25
        Me.btnClearUsername.Text = "CLEAR USERNAME"
        Me.btnClearUsername.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClearUsername.UseVisualStyleBackColor = False
        '
        'frmParamedisQuickAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(458, 288)
        Me.ControlBox = False
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmParamedisQuickAdd"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Paramedis - Tambah Cepat"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        Me.pBody.PerformLayout()
        Me.pHeader.ResumeLayout(False)
        Me.tlpField.ResumeLayout(False)
        Me.tlpField.PerformLayout()
        CType(Me.lueService.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueParamedisType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teParamedis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueAgama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueJenisKelamin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueKewarganegaraan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueTempatLahir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggalLahir.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggalLahir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents pHeader As System.Windows.Forms.Panel
    Public WithEvents pBody As System.Windows.Forms.Panel
    Public WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pExit As PictureBox
    Friend WithEvents pMinimize As PictureBox
    Friend WithEvents pMaximize As PictureBox
    Public WithEvents btnSave As Button
    Public WithEvents btnNew As Button
    Public WithEvents tlpField As TableLayoutPanel
    Friend WithEvents lueService As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label66 As Label
    Friend WithEvents lueParamedisType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents teParamedis As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblKaryawan As Label
    Friend WithEvents lblNIK As Label
    Friend WithEvents lueAgama As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label38 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents lueJenisKelamin As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueKewarganegaraan As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueTempatLahir As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label40 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents deTanggalLahir As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblUsername As Label
    Friend WithEvents lueUsername As DevExpress.XtraEditors.LookUpEdit
    Public WithEvents btnClearUsername As Button
End Class
