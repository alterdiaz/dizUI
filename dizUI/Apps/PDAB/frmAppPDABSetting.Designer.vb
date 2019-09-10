<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAppPDABSetting
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
        Me.pBody = New System.Windows.Forms.Panel()
        Me.tlpTop = New System.Windows.Forms.TableLayoutPanel()
        Me.lblSuperUser = New System.Windows.Forms.Label()
        Me.lblUserData = New System.Windows.Forms.Label()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.lueBankKas = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueSystem = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lueKabidKeu = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueDirKeu = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueDirut = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueNonKas = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueKas = New DevExpress.XtraEditors.LookUpEdit()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.tlpForm.SuspendLayout()
        Me.pBody.SuspendLayout()
        Me.tlpTop.SuspendLayout()
        CType(Me.lueBankKas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueSystem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueKabidKeu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueDirKeu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueDirut.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueNonKas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueKas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeader.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpForm
        '
        Me.tlpForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tlpForm.ColumnCount = 3
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.Controls.Add(Me.pBody, 1, 1)
        Me.tlpForm.Controls.Add(Me.Panel1, 1, 0)
        Me.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpForm.Location = New System.Drawing.Point(0, 0)
        Me.tlpForm.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpForm.Name = "tlpForm"
        Me.tlpForm.RowCount = 3
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.Size = New System.Drawing.Size(507, 293)
        Me.tlpForm.TabIndex = 8
        '
        'pBody
        '
        Me.pBody.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.pBody.Controls.Add(Me.tlpTop)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(503, 261)
        Me.pBody.TabIndex = 7
        '
        'tlpTop
        '
        Me.tlpTop.ColumnCount = 4
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTop.Controls.Add(Me.lblSuperUser, 1, 3)
        Me.tlpTop.Controls.Add(Me.lblUserData, 1, 2)
        Me.tlpTop.Controls.Add(Me.lblLevel, 1, 1)
        Me.tlpTop.Controls.Add(Me.lueBankKas, 2, 1)
        Me.tlpTop.Controls.Add(Me.lueSystem, 2, 2)
        Me.tlpTop.Controls.Add(Me.Label1, 1, 4)
        Me.tlpTop.Controls.Add(Me.Label2, 1, 5)
        Me.tlpTop.Controls.Add(Me.Label3, 1, 6)
        Me.tlpTop.Controls.Add(Me.Label4, 1, 7)
        Me.tlpTop.Controls.Add(Me.lueKabidKeu, 2, 3)
        Me.tlpTop.Controls.Add(Me.lueDirKeu, 2, 4)
        Me.tlpTop.Controls.Add(Me.lueDirut, 2, 5)
        Me.tlpTop.Controls.Add(Me.lueNonKas, 2, 6)
        Me.tlpTop.Controls.Add(Me.lueKas, 2, 7)
        Me.tlpTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTop.Location = New System.Drawing.Point(0, 30)
        Me.tlpTop.Name = "tlpTop"
        Me.tlpTop.RowCount = 9
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTop.Size = New System.Drawing.Size(503, 231)
        Me.tlpTop.TabIndex = 5
        '
        'lblSuperUser
        '
        Me.lblSuperUser.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblSuperUser.AutoSize = True
        Me.lblSuperUser.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuperUser.Location = New System.Drawing.Point(79, 84)
        Me.lblSuperUser.Name = "lblSuperUser"
        Me.lblSuperUser.Size = New System.Drawing.Size(94, 14)
        Me.lblSuperUser.TabIndex = 32
        Me.lblSuperUser.Text = "Kabid Keuangan"
        Me.lblSuperUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUserData
        '
        Me.lblUserData.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblUserData.AutoSize = True
        Me.lblUserData.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserData.Location = New System.Drawing.Point(70, 60)
        Me.lblUserData.Name = "lblUserData"
        Me.lblUserData.Size = New System.Drawing.Size(103, 14)
        Me.lblUserData.TabIndex = 32
        Me.lblUserData.Text = "Karyawan System"
        Me.lblUserData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLevel
        '
        Me.lblLevel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblLevel.AutoSize = True
        Me.lblLevel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.Location = New System.Drawing.Point(118, 36)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(55, 14)
        Me.lblLevel.TabIndex = 32
        Me.lblLevel.Text = "Bank Kas"
        Me.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueBankKas
        '
        Me.lueBankKas.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueBankKas.Location = New System.Drawing.Point(176, 33)
        Me.lueBankKas.Margin = New System.Windows.Forms.Padding(0)
        Me.lueBankKas.Name = "lueBankKas"
        Me.lueBankKas.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueBankKas.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueBankKas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueBankKas.Properties.Appearance.Options.UseBackColor = True
        Me.lueBankKas.Properties.Appearance.Options.UseFont = True
        Me.lueBankKas.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueBankKas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueBankKas.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueBankKas.Properties.NullText = "[Isian belum dipilih]"
        Me.lueBankKas.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueBankKas.Size = New System.Drawing.Size(291, 20)
        Me.lueBankKas.TabIndex = 47
        '
        'lueSystem
        '
        Me.lueSystem.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueSystem.Location = New System.Drawing.Point(176, 57)
        Me.lueSystem.Margin = New System.Windows.Forms.Padding(0)
        Me.lueSystem.Name = "lueSystem"
        Me.lueSystem.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueSystem.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueSystem.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueSystem.Properties.Appearance.Options.UseBackColor = True
        Me.lueSystem.Properties.Appearance.Options.UseFont = True
        Me.lueSystem.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueSystem.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueSystem.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueSystem.Properties.NullText = "[Isian belum dipilih]"
        Me.lueSystem.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueSystem.Size = New System.Drawing.Size(291, 20)
        Me.lueSystem.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 14)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Direktur Keuangan"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(84, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 14)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Direktur Utama"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 14)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Pemohon PPUB NonKas"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(59, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 14)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Pemohon PPUB Kas"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueKabidKeu
        '
        Me.lueKabidKeu.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueKabidKeu.Location = New System.Drawing.Point(176, 81)
        Me.lueKabidKeu.Margin = New System.Windows.Forms.Padding(0)
        Me.lueKabidKeu.Name = "lueKabidKeu"
        Me.lueKabidKeu.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueKabidKeu.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueKabidKeu.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueKabidKeu.Properties.Appearance.Options.UseBackColor = True
        Me.lueKabidKeu.Properties.Appearance.Options.UseFont = True
        Me.lueKabidKeu.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueKabidKeu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueKabidKeu.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueKabidKeu.Properties.NullText = "[Isian belum dipilih]"
        Me.lueKabidKeu.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueKabidKeu.Size = New System.Drawing.Size(291, 20)
        Me.lueKabidKeu.TabIndex = 53
        '
        'lueDirKeu
        '
        Me.lueDirKeu.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueDirKeu.Location = New System.Drawing.Point(176, 105)
        Me.lueDirKeu.Margin = New System.Windows.Forms.Padding(0)
        Me.lueDirKeu.Name = "lueDirKeu"
        Me.lueDirKeu.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueDirKeu.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueDirKeu.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueDirKeu.Properties.Appearance.Options.UseBackColor = True
        Me.lueDirKeu.Properties.Appearance.Options.UseFont = True
        Me.lueDirKeu.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueDirKeu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDirKeu.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueDirKeu.Properties.NullText = "[Isian belum dipilih]"
        Me.lueDirKeu.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueDirKeu.Size = New System.Drawing.Size(291, 20)
        Me.lueDirKeu.TabIndex = 54
        '
        'lueDirut
        '
        Me.lueDirut.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueDirut.Location = New System.Drawing.Point(176, 129)
        Me.lueDirut.Margin = New System.Windows.Forms.Padding(0)
        Me.lueDirut.Name = "lueDirut"
        Me.lueDirut.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueDirut.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueDirut.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueDirut.Properties.Appearance.Options.UseBackColor = True
        Me.lueDirut.Properties.Appearance.Options.UseFont = True
        Me.lueDirut.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueDirut.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDirut.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueDirut.Properties.NullText = "[Isian belum dipilih]"
        Me.lueDirut.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueDirut.Size = New System.Drawing.Size(291, 20)
        Me.lueDirut.TabIndex = 55
        '
        'lueNonKas
        '
        Me.lueNonKas.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueNonKas.Location = New System.Drawing.Point(176, 153)
        Me.lueNonKas.Margin = New System.Windows.Forms.Padding(0)
        Me.lueNonKas.Name = "lueNonKas"
        Me.lueNonKas.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueNonKas.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueNonKas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueNonKas.Properties.Appearance.Options.UseBackColor = True
        Me.lueNonKas.Properties.Appearance.Options.UseFont = True
        Me.lueNonKas.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueNonKas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueNonKas.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueNonKas.Properties.NullText = "[Isian belum dipilih]"
        Me.lueNonKas.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueNonKas.Size = New System.Drawing.Size(291, 20)
        Me.lueNonKas.TabIndex = 56
        '
        'lueKas
        '
        Me.lueKas.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueKas.Location = New System.Drawing.Point(176, 177)
        Me.lueKas.Margin = New System.Windows.Forms.Padding(0)
        Me.lueKas.Name = "lueKas"
        Me.lueKas.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueKas.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueKas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueKas.Properties.Appearance.Options.UseBackColor = True
        Me.lueKas.Properties.Appearance.Options.UseFont = True
        Me.lueKas.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueKas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueKas.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueKas.Properties.NullText = "[Isian belum dipilih]"
        Me.lueKas.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueKas.Size = New System.Drawing.Size(291, 20)
        Me.lueKas.TabIndex = 57
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Controls.Add(Me.btnSave)
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.ForeColor = System.Drawing.Color.White
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(503, 30)
        Me.pHeader.TabIndex = 4
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
        Me.btnSave.Location = New System.Drawing.Point(403, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 30)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "SAVE"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Controls.Add(Me.pExit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(2, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(503, 30)
        Me.Panel1.TabIndex = 8
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(473, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "App Setting"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pExit
        '
        Me.pExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.pExit.Image = Global.dizUI.My.Resources.Resources.exit_w
        Me.pExit.Location = New System.Drawing.Point(473, 0)
        Me.pExit.Margin = New System.Windows.Forms.Padding(0)
        Me.pExit.Name = "pExit"
        Me.pExit.Size = New System.Drawing.Size(30, 30)
        Me.pExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pExit.TabIndex = 12
        Me.pExit.TabStop = False
        '
        'frmAppPDABSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.ClientSize = New System.Drawing.Size(507, 293)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAppPDABSetting"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "App Setting"
        Me.tlpForm.ResumeLayout(False)
        Me.pBody.ResumeLayout(False)
        Me.tlpTop.ResumeLayout(False)
        Me.tlpTop.PerformLayout()
        CType(Me.lueBankKas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueSystem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueKabidKeu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueDirKeu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueDirut.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueNonKas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueKas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pBody As System.Windows.Forms.Panel
    Friend WithEvents pHeader As System.Windows.Forms.Panel
    Friend WithEvents tlpTop As System.Windows.Forms.TableLayoutPanel
    Public WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblSuperUser As System.Windows.Forms.Label
    Friend WithEvents lblUserData As System.Windows.Forms.Label
    Friend WithEvents lblLevel As System.Windows.Forms.Label
    Friend WithEvents lueBankKas As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueSystem As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lueKabidKeu As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueDirKeu As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueDirut As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueNonKas As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueKas As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
End Class
