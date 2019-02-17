<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeHardware
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
        Me.tlpEntry = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpPengguna = New System.Windows.Forms.TableLayoutPanel()
        Me.teNamaPerusahaan = New DevExpress.XtraEditors.TextEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tePerusahaanPIN = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnExistCompany = New System.Windows.Forms.Button()
        Me.teKodeHardware = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.pbSync = New System.Windows.Forms.PictureBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.panelLogin = New System.Windows.Forms.Panel()
        Me.btnUserCheck = New System.Windows.Forms.Button()
        Me.texPassword = New DevExpress.XtraEditors.TextEdit()
        Me.texUsername = New DevExpress.XtraEditors.TextEdit()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.tlpForm.SuspendLayout()
        Me.pBody.SuspendLayout()
        Me.tlpEntry.SuspendLayout()
        Me.tlpPengguna.SuspendLayout()
        CType(Me.teNamaPerusahaan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tePerusahaanPIN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teKodeHardware.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeader.SuspendLayout()
        CType(Me.pbSync, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelLogin.SuspendLayout()
        CType(Me.texPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.texUsername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pTitle.SuspendLayout()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpForm
        '
        Me.tlpForm.BackColor = System.Drawing.Color.DarkCyan
        Me.tlpForm.ColumnCount = 3
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.Controls.Add(Me.pBody, 1, 1)
        Me.tlpForm.Controls.Add(Me.pTitle, 1, 0)
        Me.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpForm.Location = New System.Drawing.Point(0, 0)
        Me.tlpForm.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpForm.Name = "tlpForm"
        Me.tlpForm.RowCount = 3
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.Size = New System.Drawing.Size(460, 190)
        Me.tlpForm.TabIndex = 1
        '
        'pBody
        '
        Me.pBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pBody.Controls.Add(Me.tlpEntry)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Controls.Add(Me.panelLogin)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(456, 158)
        Me.pBody.TabIndex = 7
        '
        'tlpEntry
        '
        Me.tlpEntry.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlpEntry.ColumnCount = 3
        Me.tlpEntry.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tlpEntry.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEntry.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tlpEntry.Controls.Add(Me.tlpPengguna, 1, 1)
        Me.tlpEntry.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpEntry.Location = New System.Drawing.Point(0, 30)
        Me.tlpEntry.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEntry.Name = "tlpEntry"
        Me.tlpEntry.RowCount = 3
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tlpEntry.Size = New System.Drawing.Size(456, 128)
        Me.tlpEntry.TabIndex = 112
        '
        'tlpPengguna
        '
        Me.tlpPengguna.AutoSize = True
        Me.tlpPengguna.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpPengguna.ColumnCount = 4
        Me.tlpPengguna.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPengguna.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.tlpPengguna.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220.0!))
        Me.tlpPengguna.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPengguna.Controls.Add(Me.teNamaPerusahaan, 2, 3)
        Me.tlpPengguna.Controls.Add(Me.Label9, 1, 3)
        Me.tlpPengguna.Controls.Add(Me.tePerusahaanPIN, 2, 1)
        Me.tlpPengguna.Controls.Add(Me.Label5, 1, 1)
        Me.tlpPengguna.Controls.Add(Me.btnExistCompany, 2, 2)
        Me.tlpPengguna.Controls.Add(Me.teKodeHardware, 2, 5)
        Me.tlpPengguna.Controls.Add(Me.Label4, 1, 5)
        Me.tlpPengguna.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPengguna.Location = New System.Drawing.Point(4, 4)
        Me.tlpPengguna.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpPengguna.Name = "tlpPengguna"
        Me.tlpPengguna.RowCount = 7
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpPengguna.Size = New System.Drawing.Size(448, 120)
        Me.tlpPengguna.TabIndex = 114
        '
        'teNamaPerusahaan
        '
        Me.teNamaPerusahaan.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNamaPerusahaan.Location = New System.Drawing.Point(194, 59)
        Me.teNamaPerusahaan.Margin = New System.Windows.Forms.Padding(0)
        Me.teNamaPerusahaan.Name = "teNamaPerusahaan"
        Me.teNamaPerusahaan.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teNamaPerusahaan.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNamaPerusahaan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNamaPerusahaan.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teNamaPerusahaan.Properties.Appearance.Options.UseBackColor = True
        Me.teNamaPerusahaan.Properties.Appearance.Options.UseFont = True
        Me.teNamaPerusahaan.Properties.Appearance.Options.UseForeColor = True
        Me.teNamaPerusahaan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNamaPerusahaan.Properties.MaxLength = 300
        Me.teNamaPerusahaan.Properties.NullText = "[Kosong]"
        Me.teNamaPerusahaan.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNamaPerusahaan.Properties.ReadOnly = True
        Me.teNamaPerusahaan.Properties.Tag = "namalengkap"
        Me.teNamaPerusahaan.Size = New System.Drawing.Size(218, 20)
        Me.teNamaPerusahaan.TabIndex = 31
        Me.teNamaPerusahaan.Tag = ""
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(88, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 14)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Nama Perusahaan"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tePerusahaanPIN
        '
        Me.tePerusahaanPIN.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tePerusahaanPIN.Location = New System.Drawing.Point(194, 11)
        Me.tePerusahaanPIN.Margin = New System.Windows.Forms.Padding(0)
        Me.tePerusahaanPIN.Name = "tePerusahaanPIN"
        Me.tePerusahaanPIN.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.tePerusahaanPIN.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tePerusahaanPIN.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tePerusahaanPIN.Properties.Appearance.Options.UseBackColor = True
        Me.tePerusahaanPIN.Properties.Appearance.Options.UseFont = True
        Me.tePerusahaanPIN.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tePerusahaanPIN.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tePerusahaanPIN.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.tePerusahaanPIN.Properties.AppearanceDisabled.Options.UseFont = True
        Me.tePerusahaanPIN.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tePerusahaanPIN.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tePerusahaanPIN.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.tePerusahaanPIN.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.tePerusahaanPIN.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tePerusahaanPIN.Properties.MaxLength = 500
        Me.tePerusahaanPIN.Properties.NullText = "[Kosong]"
        Me.tePerusahaanPIN.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.tePerusahaanPIN.Properties.Tag = "namalengkap"
        Me.tePerusahaanPIN.Size = New System.Drawing.Size(218, 20)
        Me.tePerusahaanPIN.TabIndex = 29
        Me.tePerusahaanPIN.Tag = ""
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(90, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 14)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Kode Perusahaan"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnExistCompany
        '
        Me.btnExistCompany.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnExistCompany.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnExistCompany.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnExistCompany.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnExistCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExistCompany.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExistCompany.ForeColor = System.Drawing.Color.Black
        Me.btnExistCompany.Location = New System.Drawing.Point(194, 33)
        Me.btnExistCompany.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExistCompany.Name = "btnExistCompany"
        Me.btnExistCompany.Size = New System.Drawing.Size(100, 24)
        Me.btnExistCompany.TabIndex = 30
        Me.btnExistCompany.Text = "CEK KODE"
        Me.btnExistCompany.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExistCompany.UseVisualStyleBackColor = False
        '
        'teKodeHardware
        '
        Me.teKodeHardware.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teKodeHardware.Location = New System.Drawing.Point(194, 89)
        Me.teKodeHardware.Margin = New System.Windows.Forms.Padding(0)
        Me.teKodeHardware.Name = "teKodeHardware"
        Me.teKodeHardware.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teKodeHardware.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teKodeHardware.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teKodeHardware.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teKodeHardware.Properties.Appearance.Options.UseBackColor = True
        Me.teKodeHardware.Properties.Appearance.Options.UseFont = True
        Me.teKodeHardware.Properties.Appearance.Options.UseForeColor = True
        Me.teKodeHardware.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teKodeHardware.Properties.MaxLength = 300
        Me.teKodeHardware.Properties.NullText = "[Kosong]"
        Me.teKodeHardware.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teKodeHardware.Properties.ReadOnly = True
        Me.teKodeHardware.Properties.Tag = "namalengkap"
        Me.teKodeHardware.Size = New System.Drawing.Size(218, 20)
        Me.teKodeHardware.TabIndex = 30
        Me.teKodeHardware.Tag = ""
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(100, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 14)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Kode Hardware"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Controls.Add(Me.pbSync)
        Me.pHeader.Controls.Add(Me.btnSave)
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.ForeColor = System.Drawing.Color.White
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(456, 30)
        Me.pHeader.TabIndex = 111
        '
        'pbSync
        '
        Me.pbSync.Dock = System.Windows.Forms.DockStyle.Left
        Me.pbSync.Image = Global.dizUI.My.Resources.Resources.loading
        Me.pbSync.Location = New System.Drawing.Point(0, 0)
        Me.pbSync.Name = "pbSync"
        Me.pbSync.Size = New System.Drawing.Size(30, 30)
        Me.pbSync.TabIndex = 28
        Me.pbSync.TabStop = False
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
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(356, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 30)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "SIMPAN"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'panelLogin
        '
        Me.panelLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.panelLogin.Controls.Add(Me.btnUserCheck)
        Me.panelLogin.Controls.Add(Me.texPassword)
        Me.panelLogin.Controls.Add(Me.texUsername)
        Me.panelLogin.Controls.Add(Me.Label16)
        Me.panelLogin.Controls.Add(Me.Label7)
        Me.panelLogin.Controls.Add(Me.Label8)
        Me.panelLogin.Location = New System.Drawing.Point(28, 61)
        Me.panelLogin.Margin = New System.Windows.Forms.Padding(0)
        Me.panelLogin.Name = "panelLogin"
        Me.panelLogin.Size = New System.Drawing.Size(400, 100)
        Me.panelLogin.TabIndex = 113
        '
        'btnUserCheck
        '
        Me.btnUserCheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnUserCheck.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnUserCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnUserCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnUserCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserCheck.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserCheck.ForeColor = System.Drawing.Color.Black
        Me.btnUserCheck.Location = New System.Drawing.Point(175, 68)
        Me.btnUserCheck.Name = "btnUserCheck"
        Me.btnUserCheck.Size = New System.Drawing.Size(100, 26)
        Me.btnUserCheck.TabIndex = 4
        Me.btnUserCheck.Text = "CEK"
        Me.btnUserCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUserCheck.UseVisualStyleBackColor = False
        '
        'texPassword
        '
        Me.texPassword.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.texPassword.Location = New System.Drawing.Point(175, 46)
        Me.texPassword.Margin = New System.Windows.Forms.Padding(0)
        Me.texPassword.Name = "texPassword"
        Me.texPassword.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.texPassword.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.texPassword.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.texPassword.Properties.Appearance.Options.UseBackColor = True
        Me.texPassword.Properties.Appearance.Options.UseFont = True
        Me.texPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.texPassword.Properties.MaxLength = 20
        Me.texPassword.Properties.NullText = "[Kosong]"
        Me.texPassword.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.texPassword.Properties.Tag = "namalengkap"
        Me.texPassword.Properties.UseSystemPasswordChar = True
        Me.texPassword.Size = New System.Drawing.Size(187, 20)
        Me.texPassword.TabIndex = 3
        Me.texPassword.Tag = ""
        '
        'texUsername
        '
        Me.texUsername.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.texUsername.Location = New System.Drawing.Point(175, 23)
        Me.texUsername.Margin = New System.Windows.Forms.Padding(0)
        Me.texUsername.Name = "texUsername"
        Me.texUsername.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.texUsername.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.texUsername.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.texUsername.Properties.Appearance.Options.UseBackColor = True
        Me.texUsername.Properties.Appearance.Options.UseFont = True
        Me.texUsername.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.texUsername.Properties.MaxLength = 300
        Me.texUsername.Properties.NullText = "[Kosong]"
        Me.texUsername.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.texUsername.Properties.Tag = "namalengkap"
        Me.texUsername.Size = New System.Drawing.Size(187, 20)
        Me.texUsername.TabIndex = 2
        Me.texUsername.Tag = "username"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(114, 49)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 14)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Password"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(111, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 14)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Username"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 14)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Username Online"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pTitle
        '
        Me.pTitle.Controls.Add(Me.lblTitle)
        Me.pTitle.Controls.Add(Me.pExit)
        Me.pTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pTitle.Location = New System.Drawing.Point(2, 0)
        Me.pTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.pTitle.Name = "pTitle"
        Me.pTitle.Size = New System.Drawing.Size(456, 30)
        Me.pTitle.TabIndex = 8
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.DarkCyan
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(426, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Update Hardware"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pExit
        '
        Me.pExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.pExit.Image = Global.dizUI.My.Resources.Resources.exit_w
        Me.pExit.Location = New System.Drawing.Point(426, 0)
        Me.pExit.Margin = New System.Windows.Forms.Padding(0)
        Me.pExit.Name = "pExit"
        Me.pExit.Size = New System.Drawing.Size(30, 30)
        Me.pExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pExit.TabIndex = 11
        Me.pExit.TabStop = False
        '
        'frmChangeHardware
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(460, 190)
        Me.ControlBox = False
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmChangeHardware"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Konfirm Pembayaran"
        Me.tlpForm.ResumeLayout(False)
        Me.pBody.ResumeLayout(False)
        Me.tlpEntry.ResumeLayout(False)
        Me.tlpEntry.PerformLayout()
        Me.tlpPengguna.ResumeLayout(False)
        Me.tlpPengguna.PerformLayout()
        CType(Me.teNamaPerusahaan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tePerusahaanPIN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teKodeHardware.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        CType(Me.pbSync, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelLogin.ResumeLayout(False)
        Me.panelLogin.PerformLayout()
        CType(Me.texPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.texUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pTitle.ResumeLayout(False)
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pBody As System.Windows.Forms.Panel
    Friend WithEvents pHeader As System.Windows.Forms.Panel
    Public WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents tlpPengguna As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpEntry As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pbSync As System.Windows.Forms.PictureBox
    Friend WithEvents panelLogin As System.Windows.Forms.Panel
    Public WithEvents btnUserCheck As System.Windows.Forms.Button
    Friend WithEvents texPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents texUsername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents teKodeHardware As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tePerusahaanPIN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents btnExistCompany As System.Windows.Forms.Button
    Friend WithEvents teNamaPerusahaan As DevExpress.XtraEditors.TextEdit
End Class
