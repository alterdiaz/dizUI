<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewProfile
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
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.tlpPengguna = New System.Windows.Forms.TableLayoutPanel()
        Me.teKodepos = New DevExpress.XtraEditors.TextEdit()
        Me.teAlamat = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.teID = New DevExpress.XtraEditors.TextEdit()
        Me.lueJenis = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.teNamaLengkap = New DevExpress.XtraEditors.TextEdit()
        Me.tePassword = New DevExpress.XtraEditors.TextEdit()
        Me.teUsername = New DevExpress.XtraEditors.TextEdit()
        Me.teRecAns = New DevExpress.XtraEditors.TextEdit()
        Me.teRecQuest = New DevExpress.XtraEditors.TextEdit()
        Me.teHint = New DevExpress.XtraEditors.TextEdit()
        Me.teHandphone = New DevExpress.XtraEditors.TextEdit()
        Me.teEmail = New DevExpress.XtraEditors.TextEdit()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.lblHint = New System.Windows.Forms.Label()
        Me.lblHandphone = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.pExist = New System.Windows.Forms.Panel()
        Me.btnExistCheck = New System.Windows.Forms.Button()
        Me.texPassword = New DevExpress.XtraEditors.TextEdit()
        Me.texUsername = New DevExpress.XtraEditors.TextEdit()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.pTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.pbSync = New System.Windows.Forms.PictureBox()
        Me.tlpForm.SuspendLayout()
        Me.pBody.SuspendLayout()
        Me.tlpEntry.SuspendLayout()
        Me.tlpPengguna.SuspendLayout()
        CType(Me.teKodepos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teAlamat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueJenis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNamaLengkap.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tePassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teUsername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teRecAns.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teRecQuest.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teHint.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teHandphone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pExist.SuspendLayout()
        CType(Me.texPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.texUsername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeader.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSync, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpForm
        '
        Me.tlpForm.BackColor = System.Drawing.Color.DarkGreen
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
        Me.tlpForm.Size = New System.Drawing.Size(460, 532)
        Me.tlpForm.TabIndex = 1
        '
        'pBody
        '
        Me.pBody.Controls.Add(Me.tlpEntry)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(456, 500)
        Me.pBody.TabIndex = 7
        '
        'tlpEntry
        '
        Me.tlpEntry.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.tlpEntry.ColumnCount = 3
        Me.tlpEntry.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpEntry.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400.0!))
        Me.tlpEntry.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpEntry.Controls.Add(Me.lblInfo, 1, 3)
        Me.tlpEntry.Controls.Add(Me.tlpPengguna, 1, 2)
        Me.tlpEntry.Controls.Add(Me.pExist, 1, 1)
        Me.tlpEntry.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpEntry.Location = New System.Drawing.Point(0, 30)
        Me.tlpEntry.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEntry.Name = "tlpEntry"
        Me.tlpEntry.RowCount = 5
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 298.0!))
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpEntry.Size = New System.Drawing.Size(456, 470)
        Me.tlpEntry.TabIndex = 17
        '
        'lblInfo
        '
        Me.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.Black
        Me.lblInfo.Location = New System.Drawing.Point(184, 427)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(87, 14)
        Me.lblInfo.TabIndex = 18
        Me.lblInfo.Text = "Nama Lengkap"
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblInfo.Visible = False
        '
        'tlpPengguna
        '
        Me.tlpPengguna.ColumnCount = 4
        Me.tlpPengguna.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPengguna.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpPengguna.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpPengguna.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPengguna.Controls.Add(Me.teKodepos, 2, 5)
        Me.tlpPengguna.Controls.Add(Me.teAlamat, 2, 4)
        Me.tlpPengguna.Controls.Add(Me.Label4, 1, 5)
        Me.tlpPengguna.Controls.Add(Me.Label3, 1, 4)
        Me.tlpPengguna.Controls.Add(Me.teID, 2, 2)
        Me.tlpPengguna.Controls.Add(Me.lueJenis, 2, 3)
        Me.tlpPengguna.Controls.Add(Me.Label2, 1, 3)
        Me.tlpPengguna.Controls.Add(Me.Label1, 1, 2)
        Me.tlpPengguna.Controls.Add(Me.lblNama, 1, 1)
        Me.tlpPengguna.Controls.Add(Me.teNamaLengkap, 2, 1)
        Me.tlpPengguna.Controls.Add(Me.tePassword, 2, 12)
        Me.tlpPengguna.Controls.Add(Me.teUsername, 2, 11)
        Me.tlpPengguna.Controls.Add(Me.teRecAns, 2, 10)
        Me.tlpPengguna.Controls.Add(Me.teRecQuest, 2, 9)
        Me.tlpPengguna.Controls.Add(Me.teHint, 2, 8)
        Me.tlpPengguna.Controls.Add(Me.teHandphone, 2, 7)
        Me.tlpPengguna.Controls.Add(Me.teEmail, 2, 6)
        Me.tlpPengguna.Controls.Add(Me.lblPassword, 1, 12)
        Me.tlpPengguna.Controls.Add(Me.lblUsername, 1, 11)
        Me.tlpPengguna.Controls.Add(Me.lblAnswer, 1, 10)
        Me.tlpPengguna.Controls.Add(Me.lblQuestion, 1, 9)
        Me.tlpPengguna.Controls.Add(Me.lblHint, 1, 8)
        Me.tlpPengguna.Controls.Add(Me.lblHandphone, 1, 7)
        Me.tlpPengguna.Controls.Add(Me.lblEmail, 1, 6)
        Me.tlpPengguna.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPengguna.Location = New System.Drawing.Point(28, 107)
        Me.tlpPengguna.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpPengguna.Name = "tlpPengguna"
        Me.tlpPengguna.RowCount = 14
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPengguna.Size = New System.Drawing.Size(400, 298)
        Me.tlpPengguna.TabIndex = 112
        '
        'teKodepos
        '
        Me.teKodepos.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teKodepos.Location = New System.Drawing.Point(175, 103)
        Me.teKodepos.Margin = New System.Windows.Forms.Padding(0)
        Me.teKodepos.Name = "teKodepos"
        Me.teKodepos.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teKodepos.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teKodepos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teKodepos.Properties.Appearance.Options.UseBackColor = True
        Me.teKodepos.Properties.Appearance.Options.UseFont = True
        Me.teKodepos.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teKodepos.Properties.MaxLength = 10
        Me.teKodepos.Properties.NullText = "[Kosong]"
        Me.teKodepos.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teKodepos.Properties.Tag = "email"
        Me.teKodepos.Size = New System.Drawing.Size(84, 20)
        Me.teKodepos.TabIndex = 9
        Me.teKodepos.Tag = "zipcode"
        '
        'teAlamat
        '
        Me.teAlamat.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teAlamat.Location = New System.Drawing.Point(175, 79)
        Me.teAlamat.Margin = New System.Windows.Forms.Padding(0)
        Me.teAlamat.Name = "teAlamat"
        Me.teAlamat.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teAlamat.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teAlamat.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teAlamat.Properties.Appearance.Options.UseBackColor = True
        Me.teAlamat.Properties.Appearance.Options.UseFont = True
        Me.teAlamat.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teAlamat.Properties.MaxLength = 2000
        Me.teAlamat.Properties.NullText = "[Kosong]"
        Me.teAlamat.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teAlamat.Properties.Tag = "namalengkap"
        Me.teAlamat.Size = New System.Drawing.Size(187, 20)
        Me.teAlamat.TabIndex = 8
        Me.teAlamat.Tag = "address"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(118, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 14)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Kodepos"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(128, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 14)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Alamat"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teID
        '
        Me.teID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teID.Location = New System.Drawing.Point(175, 31)
        Me.teID.Margin = New System.Windows.Forms.Padding(0)
        Me.teID.Name = "teID"
        Me.teID.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teID.Properties.Appearance.Options.UseBackColor = True
        Me.teID.Properties.Appearance.Options.UseFont = True
        Me.teID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teID.Properties.MaxLength = 300
        Me.teID.Properties.NullText = "[Kosong]"
        Me.teID.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teID.Properties.Tag = "namalengkap"
        Me.teID.Size = New System.Drawing.Size(187, 20)
        Me.teID.TabIndex = 6
        Me.teID.Tag = "personalno"
        '
        'lueJenis
        '
        Me.lueJenis.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueJenis.Location = New System.Drawing.Point(175, 55)
        Me.lueJenis.Margin = New System.Windows.Forms.Padding(0)
        Me.lueJenis.Name = "lueJenis"
        Me.lueJenis.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueJenis.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueJenis.Properties.Appearance.Options.UseBackColor = True
        Me.lueJenis.Properties.Appearance.Options.UseFont = True
        Me.lueJenis.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueJenis.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueJenis.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Jenis", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.lueJenis.Properties.NullText = "[Isian belum dipilih]"
        Me.lueJenis.Size = New System.Drawing.Size(146, 20)
        Me.lueJenis.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 14)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Jenis Kartu Identitas"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 14)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "No Identitas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNama
        '
        Me.lblNama.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.Location = New System.Drawing.Point(85, 10)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(87, 14)
        Me.lblNama.TabIndex = 3
        Me.lblNama.Text = "Nama Lengkap"
        Me.lblNama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teNamaLengkap
        '
        Me.teNamaLengkap.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNamaLengkap.Location = New System.Drawing.Point(175, 7)
        Me.teNamaLengkap.Margin = New System.Windows.Forms.Padding(0)
        Me.teNamaLengkap.Name = "teNamaLengkap"
        Me.teNamaLengkap.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teNamaLengkap.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNamaLengkap.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNamaLengkap.Properties.Appearance.Options.UseBackColor = True
        Me.teNamaLengkap.Properties.Appearance.Options.UseFont = True
        Me.teNamaLengkap.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNamaLengkap.Properties.MaxLength = 300
        Me.teNamaLengkap.Properties.NullText = "[Kosong]"
        Me.teNamaLengkap.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNamaLengkap.Properties.Tag = "namalengkap"
        Me.teNamaLengkap.Size = New System.Drawing.Size(187, 20)
        Me.teNamaLengkap.TabIndex = 5
        Me.teNamaLengkap.Tag = "namalengkap"
        '
        'tePassword
        '
        Me.tePassword.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tePassword.Location = New System.Drawing.Point(175, 271)
        Me.tePassword.Margin = New System.Windows.Forms.Padding(0)
        Me.tePassword.Name = "tePassword"
        Me.tePassword.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.tePassword.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tePassword.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tePassword.Properties.Appearance.Options.UseBackColor = True
        Me.tePassword.Properties.Appearance.Options.UseFont = True
        Me.tePassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tePassword.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tePassword.Properties.MaxLength = 20
        Me.tePassword.Properties.NullText = "[Kosong]"
        Me.tePassword.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.tePassword.Properties.Tag = "password"
        Me.tePassword.Properties.UseSystemPasswordChar = True
        Me.tePassword.Size = New System.Drawing.Size(187, 20)
        Me.tePassword.TabIndex = 16
        Me.tePassword.Tag = ""
        '
        'teUsername
        '
        Me.teUsername.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teUsername.Location = New System.Drawing.Point(175, 247)
        Me.teUsername.Margin = New System.Windows.Forms.Padding(0)
        Me.teUsername.Name = "teUsername"
        Me.teUsername.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teUsername.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teUsername.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teUsername.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teUsername.Properties.Appearance.Options.UseBackColor = True
        Me.teUsername.Properties.Appearance.Options.UseFont = True
        Me.teUsername.Properties.Appearance.Options.UseForeColor = True
        Me.teUsername.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teUsername.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.teUsername.Properties.AppearanceDisabled.Options.UseFont = True
        Me.teUsername.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.teUsername.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teUsername.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.teUsername.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.teUsername.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.teUsername.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teUsername.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.teUsername.Properties.MaxLength = 10
        Me.teUsername.Properties.NullText = "[Kosong]"
        Me.teUsername.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teUsername.Properties.Tag = "username"
        Me.teUsername.Size = New System.Drawing.Size(187, 20)
        Me.teUsername.TabIndex = 15
        Me.teUsername.Tag = "username"
        '
        'teRecAns
        '
        Me.teRecAns.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teRecAns.Location = New System.Drawing.Point(175, 223)
        Me.teRecAns.Margin = New System.Windows.Forms.Padding(0)
        Me.teRecAns.Name = "teRecAns"
        Me.teRecAns.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teRecAns.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teRecAns.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teRecAns.Properties.Appearance.Options.UseBackColor = True
        Me.teRecAns.Properties.Appearance.Options.UseFont = True
        Me.teRecAns.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teRecAns.Properties.NullText = "[Kosong]"
        Me.teRecAns.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teRecAns.Properties.Tag = "recoveryanswer"
        Me.teRecAns.Size = New System.Drawing.Size(187, 20)
        Me.teRecAns.TabIndex = 14
        '
        'teRecQuest
        '
        Me.teRecQuest.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teRecQuest.Location = New System.Drawing.Point(175, 199)
        Me.teRecQuest.Margin = New System.Windows.Forms.Padding(0)
        Me.teRecQuest.Name = "teRecQuest"
        Me.teRecQuest.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teRecQuest.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teRecQuest.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teRecQuest.Properties.Appearance.Options.UseBackColor = True
        Me.teRecQuest.Properties.Appearance.Options.UseFont = True
        Me.teRecQuest.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teRecQuest.Properties.NullText = "[Kosong]"
        Me.teRecQuest.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teRecQuest.Properties.Tag = "recoveryquestion"
        Me.teRecQuest.Size = New System.Drawing.Size(187, 20)
        Me.teRecQuest.TabIndex = 13
        '
        'teHint
        '
        Me.teHint.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teHint.Location = New System.Drawing.Point(175, 175)
        Me.teHint.Margin = New System.Windows.Forms.Padding(0)
        Me.teHint.Name = "teHint"
        Me.teHint.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teHint.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teHint.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teHint.Properties.Appearance.Options.UseBackColor = True
        Me.teHint.Properties.Appearance.Options.UseFont = True
        Me.teHint.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teHint.Properties.NullText = "[Kosong]"
        Me.teHint.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teHint.Properties.Tag = "hint"
        Me.teHint.Size = New System.Drawing.Size(187, 20)
        Me.teHint.TabIndex = 12
        '
        'teHandphone
        '
        Me.teHandphone.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teHandphone.Location = New System.Drawing.Point(175, 151)
        Me.teHandphone.Margin = New System.Windows.Forms.Padding(0)
        Me.teHandphone.Name = "teHandphone"
        Me.teHandphone.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teHandphone.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teHandphone.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teHandphone.Properties.Appearance.Options.UseBackColor = True
        Me.teHandphone.Properties.Appearance.Options.UseFont = True
        Me.teHandphone.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teHandphone.Properties.NullText = "[Kosong]"
        Me.teHandphone.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teHandphone.Properties.Tag = "handphone"
        Me.teHandphone.Size = New System.Drawing.Size(187, 20)
        Me.teHandphone.TabIndex = 11
        '
        'teEmail
        '
        Me.teEmail.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teEmail.Location = New System.Drawing.Point(175, 127)
        Me.teEmail.Margin = New System.Windows.Forms.Padding(0)
        Me.teEmail.Name = "teEmail"
        Me.teEmail.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teEmail.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teEmail.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teEmail.Properties.Appearance.Options.UseBackColor = True
        Me.teEmail.Properties.Appearance.Options.UseFont = True
        Me.teEmail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teEmail.Properties.NullText = "[Kosong]"
        Me.teEmail.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teEmail.Properties.Tag = "email"
        Me.teEmail.Size = New System.Drawing.Size(187, 20)
        Me.teEmail.TabIndex = 10
        '
        'lblPassword
        '
        Me.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(114, 274)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(58, 14)
        Me.lblPassword.TabIndex = 18
        Me.lblPassword.Text = "Password"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUsername
        '
        Me.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(111, 250)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(61, 14)
        Me.lblUsername.TabIndex = 22
        Me.lblUsername.Text = "Username"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAnswer
        '
        Me.lblAnswer.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(70, 226)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(102, 14)
        Me.lblAnswer.TabIndex = 8
        Me.lblAnswer.Text = "Recovery Answer"
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblQuestion
        '
        Me.lblQuestion.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(62, 202)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(110, 14)
        Me.lblQuestion.TabIndex = 7
        Me.lblQuestion.Text = "Recovery Question"
        Me.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHint
        '
        Me.lblHint.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblHint.AutoSize = True
        Me.lblHint.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHint.Location = New System.Drawing.Point(143, 178)
        Me.lblHint.Name = "lblHint"
        Me.lblHint.Size = New System.Drawing.Size(29, 14)
        Me.lblHint.TabIndex = 6
        Me.lblHint.Text = "Hint"
        Me.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHandphone
        '
        Me.lblHandphone.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblHandphone.AutoSize = True
        Me.lblHandphone.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHandphone.Location = New System.Drawing.Point(102, 154)
        Me.lblHandphone.Name = "lblHandphone"
        Me.lblHandphone.Size = New System.Drawing.Size(70, 14)
        Me.lblHandphone.TabIndex = 5
        Me.lblHandphone.Text = "Handphone"
        Me.lblHandphone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEmail
        '
        Me.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(138, 130)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(34, 14)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "Email"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pExist
        '
        Me.pExist.Controls.Add(Me.btnExistCheck)
        Me.pExist.Controls.Add(Me.texPassword)
        Me.pExist.Controls.Add(Me.texUsername)
        Me.pExist.Controls.Add(Me.Label16)
        Me.pExist.Controls.Add(Me.Label15)
        Me.pExist.Controls.Add(Me.Label9)
        Me.pExist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pExist.Location = New System.Drawing.Point(28, 7)
        Me.pExist.Margin = New System.Windows.Forms.Padding(0)
        Me.pExist.Name = "pExist"
        Me.pExist.Size = New System.Drawing.Size(400, 100)
        Me.pExist.TabIndex = 111
        '
        'btnExistCheck
        '
        Me.btnExistCheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnExistCheck.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnExistCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnExistCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnExistCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExistCheck.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExistCheck.ForeColor = System.Drawing.Color.Black
        Me.btnExistCheck.Location = New System.Drawing.Point(175, 68)
        Me.btnExistCheck.Name = "btnExistCheck"
        Me.btnExistCheck.Size = New System.Drawing.Size(100, 26)
        Me.btnExistCheck.TabIndex = 4
        Me.btnExistCheck.Text = "CHECK"
        Me.btnExistCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExistCheck.UseVisualStyleBackColor = False
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
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(111, 26)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 14)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Username"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(209, 14)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Sudah pernah entry data pengguna?"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.pHeader.TabIndex = 110
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
        Me.btnSave.Text = "SAVE"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
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
        Me.lblTitle.BackColor = System.Drawing.Color.DarkGreen
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(426, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Data Pengguna"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pExit
        '
        Me.pExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.pExit.Image = Global.dizUIlite.My.Resources.Resources.exit_w
        Me.pExit.Location = New System.Drawing.Point(426, 0)
        Me.pExit.Margin = New System.Windows.Forms.Padding(0)
        Me.pExit.Name = "pExit"
        Me.pExit.Size = New System.Drawing.Size(30, 30)
        Me.pExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pExit.TabIndex = 11
        Me.pExit.TabStop = False
        '
        'pbSync
        '
        Me.pbSync.Dock = System.Windows.Forms.DockStyle.Left
        Me.pbSync.Image = Global.dizUIlite.My.Resources.Resources.loading
        Me.pbSync.Location = New System.Drawing.Point(0, 0)
        Me.pbSync.Name = "pbSync"
        Me.pbSync.Size = New System.Drawing.Size(30, 30)
        Me.pbSync.TabIndex = 28
        Me.pbSync.TabStop = False
        '
        'frmNewProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.ClientSize = New System.Drawing.Size(460, 532)
        Me.ControlBox = False
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmNewProfile"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Pengguna"
        Me.tlpForm.ResumeLayout(False)
        Me.pBody.ResumeLayout(False)
        Me.tlpEntry.ResumeLayout(False)
        Me.tlpEntry.PerformLayout()
        Me.tlpPengguna.ResumeLayout(False)
        Me.tlpPengguna.PerformLayout()
        CType(Me.teKodepos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teAlamat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueJenis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNamaLengkap.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tePassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teRecAns.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teRecQuest.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teHint.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teHandphone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pExist.ResumeLayout(False)
        Me.pExist.PerformLayout()
        CType(Me.texPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.texUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSync, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pBody As System.Windows.Forms.Panel
    Friend WithEvents pHeader As System.Windows.Forms.Panel
    Public WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblHandphone As System.Windows.Forms.Label
    Friend WithEvents lblHint As System.Windows.Forms.Label
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents teNamaLengkap As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teHandphone As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teHint As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teRecQuest As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teRecAns As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teUsername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tePassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tlpPengguna As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpEntry As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents teID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lueJenis As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Friend WithEvents pExist As System.Windows.Forms.Panel
    Public WithEvents btnExistCheck As System.Windows.Forms.Button
    Friend WithEvents texPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents texUsername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents teAlamat As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teKodepos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pbSync As System.Windows.Forms.PictureBox
End Class
