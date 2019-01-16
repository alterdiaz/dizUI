<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfile
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
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.pBody = New System.Windows.Forms.Panel()
        Me.tlpEntry = New System.Windows.Forms.TableLayoutPanel()
        Me.xtcProfile = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpUsername = New DevExpress.XtraTab.XtraTabPage()
        Me.tlpPengguna = New System.Windows.Forms.TableLayoutPanel()
        Me.lueJenis = New DevExpress.XtraEditors.LookUpEdit()
        Me.teID = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.lblHint = New System.Windows.Forms.Label()
        Me.lblHandphone = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.teRecAns = New DevExpress.XtraEditors.TextEdit()
        Me.teNamaLengkap = New DevExpress.XtraEditors.TextEdit()
        Me.teEmail = New DevExpress.XtraEditors.TextEdit()
        Me.teRecQuest = New DevExpress.XtraEditors.TextEdit()
        Me.teHandphone = New DevExpress.XtraEditors.TextEdit()
        Me.teHint = New DevExpress.XtraEditors.TextEdit()
        Me.xtpProfile = New DevExpress.XtraTab.XtraTabPage()
        Me.tlpProfile = New System.Windows.Forms.TableLayoutPanel()
        Me.teLastCheck = New DevExpress.XtraEditors.TextEdit()
        Me.teBannedReason = New DevExpress.XtraEditors.TextEdit()
        Me.teUserStatus = New DevExpress.XtraEditors.TextEdit()
        Me.teUserLevel = New DevExpress.XtraEditors.TextEdit()
        Me.tePassword = New DevExpress.XtraEditors.TextEdit()
        Me.teUsername = New DevExpress.XtraEditors.TextEdit()
        Me.lblLastCheck = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblReason = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.tlpField = New System.Windows.Forms.TableLayoutPanel()
        Me.pbUser = New System.Windows.Forms.PictureBox()
        Me.btnnBrowse = New System.Windows.Forms.Button()
        Me.lblWarning = New System.Windows.Forms.Label()
        Me.pboPrev = New System.Windows.Forms.PictureBox()
        Me.pboNext = New System.Windows.Forms.PictureBox()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnImgManager = New System.Windows.Forms.Button()
        Me.lblSep2 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBody.SuspendLayout()
        Me.tlpEntry.SuspendLayout()
        CType(Me.xtcProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcProfile.SuspendLayout()
        Me.xtpUsername.SuspendLayout()
        Me.tlpPengguna.SuspendLayout()
        CType(Me.lueJenis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teRecAns.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNamaLengkap.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teRecQuest.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teHandphone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teHint.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpProfile.SuspendLayout()
        Me.tlpProfile.SuspendLayout()
        CType(Me.teLastCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teBannedReason.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teUserStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teUserLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tePassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teUsername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpField.SuspendLayout()
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboPrev, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboNext, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeader.SuspendLayout()
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
        Me.tlpForm.Size = New System.Drawing.Size(728, 418)
        Me.tlpForm.TabIndex = 1
        '
        'pTitle
        '
        Me.pTitle.Controls.Add(Me.lblTitle)
        Me.pTitle.Controls.Add(Me.pExit)
        Me.pTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pTitle.Location = New System.Drawing.Point(2, 0)
        Me.pTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.pTitle.Name = "pTitle"
        Me.pTitle.Size = New System.Drawing.Size(724, 30)
        Me.pTitle.TabIndex = 37
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
        Me.lblTitle.Size = New System.Drawing.Size(694, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Profil Pengguna"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pExit
        '
        Me.pExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.pExit.Image = Global.dizUI.My.Resources.Resources.exit_w
        Me.pExit.Location = New System.Drawing.Point(694, 0)
        Me.pExit.Margin = New System.Windows.Forms.Padding(0)
        Me.pExit.Name = "pExit"
        Me.pExit.Size = New System.Drawing.Size(30, 30)
        Me.pExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pExit.TabIndex = 10
        Me.pExit.TabStop = False
        '
        'pBody
        '
        Me.pBody.Controls.Add(Me.tlpEntry)
        Me.pBody.Controls.Add(Me.tlpField)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(724, 386)
        Me.pBody.TabIndex = 7
        '
        'tlpEntry
        '
        Me.tlpEntry.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.tlpEntry.ColumnCount = 3
        Me.tlpEntry.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpEntry.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 356.0!))
        Me.tlpEntry.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpEntry.Controls.Add(Me.xtcProfile, 1, 1)
        Me.tlpEntry.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpEntry.Location = New System.Drawing.Point(0, 30)
        Me.tlpEntry.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEntry.Name = "tlpEntry"
        Me.tlpEntry.RowCount = 3
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEntry.Size = New System.Drawing.Size(451, 356)
        Me.tlpEntry.TabIndex = 17
        '
        'xtcProfile
        '
        Me.xtcProfile.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcProfile.Location = New System.Drawing.Point(47, 22)
        Me.xtcProfile.Margin = New System.Windows.Forms.Padding(0)
        Me.xtcProfile.Name = "xtcProfile"
        Me.xtcProfile.SelectedTabPage = Me.xtpUsername
        Me.xtcProfile.Size = New System.Drawing.Size(356, 300)
        Me.xtcProfile.TabIndex = 16
        Me.xtcProfile.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpUsername, Me.xtpProfile})
        '
        'xtpUsername
        '
        Me.xtpUsername.Controls.Add(Me.tlpPengguna)
        Me.xtpUsername.Name = "xtpUsername"
        Me.xtpUsername.Size = New System.Drawing.Size(350, 272)
        Me.xtpUsername.Text = "Data Pengguna"
        '
        'tlpPengguna
        '
        Me.tlpPengguna.ColumnCount = 4
        Me.tlpPengguna.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPengguna.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.tlpPengguna.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpPengguna.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPengguna.Controls.Add(Me.lueJenis, 2, 3)
        Me.tlpPengguna.Controls.Add(Me.teID, 2, 2)
        Me.tlpPengguna.Controls.Add(Me.Label2, 1, 3)
        Me.tlpPengguna.Controls.Add(Me.Label1, 1, 2)
        Me.tlpPengguna.Controls.Add(Me.lblAnswer, 1, 8)
        Me.tlpPengguna.Controls.Add(Me.lblQuestion, 1, 7)
        Me.tlpPengguna.Controls.Add(Me.lblHint, 1, 6)
        Me.tlpPengguna.Controls.Add(Me.lblHandphone, 1, 5)
        Me.tlpPengguna.Controls.Add(Me.lblEmail, 1, 4)
        Me.tlpPengguna.Controls.Add(Me.lblNama, 1, 1)
        Me.tlpPengguna.Controls.Add(Me.teRecAns, 2, 8)
        Me.tlpPengguna.Controls.Add(Me.teNamaLengkap, 2, 1)
        Me.tlpPengguna.Controls.Add(Me.teEmail, 2, 4)
        Me.tlpPengguna.Controls.Add(Me.teRecQuest, 2, 7)
        Me.tlpPengguna.Controls.Add(Me.teHandphone, 2, 5)
        Me.tlpPengguna.Controls.Add(Me.teHint, 2, 6)
        Me.tlpPengguna.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPengguna.Location = New System.Drawing.Point(0, 0)
        Me.tlpPengguna.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpPengguna.Name = "tlpPengguna"
        Me.tlpPengguna.RowCount = 11
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpPengguna.Size = New System.Drawing.Size(350, 272)
        Me.tlpPengguna.TabIndex = 15
        '
        'lueJenis
        '
        Me.lueJenis.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueJenis.Location = New System.Drawing.Point(145, 82)
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
        Me.lueJenis.TabIndex = 31
        '
        'teID
        '
        Me.teID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teID.Location = New System.Drawing.Point(145, 58)
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
        Me.teID.TabIndex = 26
        Me.teID.Tag = "personalno"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 14)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Jenis Kartu Identitas"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 14)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "No Identitas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAnswer
        '
        Me.lblAnswer.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(40, 209)
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
        Me.lblQuestion.Location = New System.Drawing.Point(32, 181)
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
        Me.lblHint.Location = New System.Drawing.Point(113, 157)
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
        Me.lblHandphone.Location = New System.Drawing.Point(72, 133)
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
        Me.lblEmail.Location = New System.Drawing.Point(108, 109)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(34, 14)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "Email"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNama
        '
        Me.lblNama.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.Location = New System.Drawing.Point(55, 37)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(87, 14)
        Me.lblNama.TabIndex = 3
        Me.lblNama.Text = "Nama Lengkap"
        Me.lblNama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teRecAns
        '
        Me.teRecAns.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teRecAns.Location = New System.Drawing.Point(145, 206)
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
        Me.teRecAns.Size = New System.Drawing.Size(187, 20)
        Me.teRecAns.TabIndex = 21
        Me.teRecAns.Tag = "recoveryanswer"
        '
        'teNamaLengkap
        '
        Me.teNamaLengkap.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNamaLengkap.Location = New System.Drawing.Point(145, 34)
        Me.teNamaLengkap.Margin = New System.Windows.Forms.Padding(0)
        Me.teNamaLengkap.Name = "teNamaLengkap"
        Me.teNamaLengkap.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teNamaLengkap.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNamaLengkap.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNamaLengkap.Properties.Appearance.Options.UseBackColor = True
        Me.teNamaLengkap.Properties.Appearance.Options.UseFont = True
        Me.teNamaLengkap.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNamaLengkap.Properties.NullText = "[Kosong]"
        Me.teNamaLengkap.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNamaLengkap.Size = New System.Drawing.Size(187, 20)
        Me.teNamaLengkap.TabIndex = 16
        Me.teNamaLengkap.Tag = "namalengkap"
        '
        'teEmail
        '
        Me.teEmail.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teEmail.Location = New System.Drawing.Point(145, 106)
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
        Me.teEmail.Size = New System.Drawing.Size(187, 20)
        Me.teEmail.TabIndex = 17
        Me.teEmail.Tag = "email"
        '
        'teRecQuest
        '
        Me.teRecQuest.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teRecQuest.Location = New System.Drawing.Point(145, 178)
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
        Me.teRecQuest.Size = New System.Drawing.Size(187, 20)
        Me.teRecQuest.TabIndex = 20
        Me.teRecQuest.Tag = "recoveryquestion"
        '
        'teHandphone
        '
        Me.teHandphone.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teHandphone.Location = New System.Drawing.Point(145, 130)
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
        Me.teHandphone.Size = New System.Drawing.Size(187, 20)
        Me.teHandphone.TabIndex = 18
        Me.teHandphone.Tag = "handphone"
        '
        'teHint
        '
        Me.teHint.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teHint.Location = New System.Drawing.Point(145, 154)
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
        Me.teHint.Size = New System.Drawing.Size(187, 20)
        Me.teHint.TabIndex = 19
        Me.teHint.Tag = "hint"
        '
        'xtpProfile
        '
        Me.xtpProfile.Controls.Add(Me.tlpProfile)
        Me.xtpProfile.Name = "xtpProfile"
        Me.xtpProfile.Size = New System.Drawing.Size(350, 272)
        Me.xtpProfile.Text = "Data Profile"
        '
        'tlpProfile
        '
        Me.tlpProfile.ColumnCount = 4
        Me.tlpProfile.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpProfile.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpProfile.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpProfile.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpProfile.Controls.Add(Me.teLastCheck, 2, 6)
        Me.tlpProfile.Controls.Add(Me.teBannedReason, 2, 5)
        Me.tlpProfile.Controls.Add(Me.teUserStatus, 2, 4)
        Me.tlpProfile.Controls.Add(Me.teUserLevel, 2, 3)
        Me.tlpProfile.Controls.Add(Me.tePassword, 2, 2)
        Me.tlpProfile.Controls.Add(Me.teUsername, 2, 1)
        Me.tlpProfile.Controls.Add(Me.lblLastCheck, 1, 6)
        Me.tlpProfile.Controls.Add(Me.lblStatus, 1, 4)
        Me.tlpProfile.Controls.Add(Me.lblReason, 1, 5)
        Me.tlpProfile.Controls.Add(Me.lblPassword, 1, 2)
        Me.tlpProfile.Controls.Add(Me.lblLevel, 1, 3)
        Me.tlpProfile.Controls.Add(Me.lblUsername, 1, 1)
        Me.tlpProfile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpProfile.Location = New System.Drawing.Point(0, 0)
        Me.tlpProfile.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpProfile.Name = "tlpProfile"
        Me.tlpProfile.RowCount = 8
        Me.tlpProfile.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpProfile.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpProfile.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpProfile.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpProfile.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpProfile.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpProfile.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpProfile.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpProfile.Size = New System.Drawing.Size(350, 272)
        Me.tlpProfile.TabIndex = 0
        '
        'teLastCheck
        '
        Me.teLastCheck.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teLastCheck.Enabled = False
        Me.teLastCheck.Location = New System.Drawing.Point(135, 186)
        Me.teLastCheck.Margin = New System.Windows.Forms.Padding(0)
        Me.teLastCheck.Name = "teLastCheck"
        Me.teLastCheck.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teLastCheck.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teLastCheck.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teLastCheck.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teLastCheck.Properties.Appearance.Options.UseBackColor = True
        Me.teLastCheck.Properties.Appearance.Options.UseFont = True
        Me.teLastCheck.Properties.Appearance.Options.UseForeColor = True
        Me.teLastCheck.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teLastCheck.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.teLastCheck.Properties.AppearanceDisabled.Options.UseFont = True
        Me.teLastCheck.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.teLastCheck.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teLastCheck.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.teLastCheck.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.teLastCheck.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.teLastCheck.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teLastCheck.Properties.NullText = "[Kosong]"
        Me.teLastCheck.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teLastCheck.Properties.ReadOnly = True
        Me.teLastCheck.Size = New System.Drawing.Size(187, 20)
        Me.teLastCheck.TabIndex = 27
        '
        'teBannedReason
        '
        Me.teBannedReason.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teBannedReason.Enabled = False
        Me.teBannedReason.Location = New System.Drawing.Point(135, 162)
        Me.teBannedReason.Margin = New System.Windows.Forms.Padding(0)
        Me.teBannedReason.Name = "teBannedReason"
        Me.teBannedReason.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teBannedReason.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teBannedReason.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teBannedReason.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teBannedReason.Properties.Appearance.Options.UseBackColor = True
        Me.teBannedReason.Properties.Appearance.Options.UseFont = True
        Me.teBannedReason.Properties.Appearance.Options.UseForeColor = True
        Me.teBannedReason.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teBannedReason.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.teBannedReason.Properties.AppearanceDisabled.Options.UseFont = True
        Me.teBannedReason.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.teBannedReason.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teBannedReason.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.teBannedReason.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.teBannedReason.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.teBannedReason.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teBannedReason.Properties.NullText = "[Kosong]"
        Me.teBannedReason.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teBannedReason.Properties.ReadOnly = True
        Me.teBannedReason.Size = New System.Drawing.Size(187, 20)
        Me.teBannedReason.TabIndex = 26
        '
        'teUserStatus
        '
        Me.teUserStatus.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teUserStatus.Enabled = False
        Me.teUserStatus.Location = New System.Drawing.Point(135, 138)
        Me.teUserStatus.Margin = New System.Windows.Forms.Padding(0)
        Me.teUserStatus.Name = "teUserStatus"
        Me.teUserStatus.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teUserStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teUserStatus.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teUserStatus.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teUserStatus.Properties.Appearance.Options.UseBackColor = True
        Me.teUserStatus.Properties.Appearance.Options.UseFont = True
        Me.teUserStatus.Properties.Appearance.Options.UseForeColor = True
        Me.teUserStatus.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teUserStatus.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.teUserStatus.Properties.AppearanceDisabled.Options.UseFont = True
        Me.teUserStatus.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.teUserStatus.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teUserStatus.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.teUserStatus.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.teUserStatus.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.teUserStatus.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teUserStatus.Properties.NullText = "[Kosong]"
        Me.teUserStatus.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teUserStatus.Properties.ReadOnly = True
        Me.teUserStatus.Size = New System.Drawing.Size(187, 20)
        Me.teUserStatus.TabIndex = 25
        '
        'teUserLevel
        '
        Me.teUserLevel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teUserLevel.Enabled = False
        Me.teUserLevel.Location = New System.Drawing.Point(135, 114)
        Me.teUserLevel.Margin = New System.Windows.Forms.Padding(0)
        Me.teUserLevel.Name = "teUserLevel"
        Me.teUserLevel.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teUserLevel.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teUserLevel.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teUserLevel.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teUserLevel.Properties.Appearance.Options.UseBackColor = True
        Me.teUserLevel.Properties.Appearance.Options.UseFont = True
        Me.teUserLevel.Properties.Appearance.Options.UseForeColor = True
        Me.teUserLevel.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teUserLevel.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.teUserLevel.Properties.AppearanceDisabled.Options.UseFont = True
        Me.teUserLevel.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.teUserLevel.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teUserLevel.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.teUserLevel.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.teUserLevel.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.teUserLevel.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teUserLevel.Properties.NullText = "[Kosong]"
        Me.teUserLevel.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teUserLevel.Properties.ReadOnly = True
        Me.teUserLevel.Size = New System.Drawing.Size(187, 20)
        Me.teUserLevel.TabIndex = 24
        '
        'tePassword
        '
        Me.tePassword.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tePassword.Location = New System.Drawing.Point(135, 90)
        Me.tePassword.Margin = New System.Windows.Forms.Padding(0)
        Me.tePassword.Name = "tePassword"
        Me.tePassword.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.tePassword.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tePassword.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tePassword.Properties.Appearance.Options.UseBackColor = True
        Me.tePassword.Properties.Appearance.Options.UseFont = True
        Me.tePassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tePassword.Properties.NullText = "[Kosong]"
        Me.tePassword.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.tePassword.Size = New System.Drawing.Size(187, 20)
        Me.tePassword.TabIndex = 23
        Me.tePassword.Tag = "password"
        '
        'teUsername
        '
        Me.teUsername.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teUsername.Enabled = False
        Me.teUsername.Location = New System.Drawing.Point(135, 66)
        Me.teUsername.Margin = New System.Windows.Forms.Padding(0)
        Me.teUsername.Name = "teUsername"
        Me.teUsername.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teUsername.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
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
        Me.teUsername.Properties.ReadOnly = True
        Me.teUsername.Size = New System.Drawing.Size(187, 20)
        Me.teUsername.TabIndex = 22
        '
        'lblLastCheck
        '
        Me.lblLastCheck.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblLastCheck.AutoSize = True
        Me.lblLastCheck.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastCheck.Location = New System.Drawing.Point(66, 189)
        Me.lblLastCheck.Name = "lblLastCheck"
        Me.lblLastCheck.Size = New System.Drawing.Size(66, 14)
        Me.lblLastCheck.TabIndex = 13
        Me.lblLastCheck.Text = "Last Check"
        Me.lblLastCheck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(62, 141)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(70, 14)
        Me.lblStatus.TabIndex = 10
        Me.lblStatus.Text = "User Status"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblReason
        '
        Me.lblReason.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblReason.AutoSize = True
        Me.lblReason.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReason.Location = New System.Drawing.Point(41, 165)
        Me.lblReason.Name = "lblReason"
        Me.lblReason.Size = New System.Drawing.Size(91, 14)
        Me.lblReason.TabIndex = 15
        Me.lblReason.Text = "Banned Reason"
        Me.lblReason.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPassword
        '
        Me.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(74, 93)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(58, 14)
        Me.lblPassword.TabIndex = 12
        Me.lblPassword.Text = "Password"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLevel
        '
        Me.lblLevel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblLevel.AutoSize = True
        Me.lblLevel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.Location = New System.Drawing.Point(69, 117)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(63, 14)
        Me.lblLevel.TabIndex = 9
        Me.lblLevel.Text = "User Level"
        Me.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUsername
        '
        Me.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(71, 69)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(61, 14)
        Me.lblUsername.TabIndex = 11
        Me.lblUsername.Text = "Username"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpField
        '
        Me.tlpField.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.tlpField.ColumnCount = 3
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.Controls.Add(Me.pbUser, 1, 1)
        Me.tlpField.Controls.Add(Me.btnnBrowse, 1, 2)
        Me.tlpField.Controls.Add(Me.lblWarning, 1, 3)
        Me.tlpField.Controls.Add(Me.pboPrev, 0, 1)
        Me.tlpField.Controls.Add(Me.pboNext, 2, 1)
        Me.tlpField.Dock = System.Windows.Forms.DockStyle.Right
        Me.tlpField.Location = New System.Drawing.Point(451, 30)
        Me.tlpField.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpField.Name = "tlpField"
        Me.tlpField.RowCount = 4
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpField.Size = New System.Drawing.Size(273, 356)
        Me.tlpField.TabIndex = 5
        '
        'pbUser
        '
        Me.pbUser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbUser.BackColor = System.Drawing.Color.White
        Me.pbUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbUser.Image = Global.dizUI.My.Resources.Resources.defprofile
        Me.pbUser.Location = New System.Drawing.Point(36, 60)
        Me.pbUser.Margin = New System.Windows.Forms.Padding(0)
        Me.pbUser.Name = "pbUser"
        Me.pbUser.Size = New System.Drawing.Size(200, 200)
        Me.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbUser.TabIndex = 14
        Me.pbUser.TabStop = False
        '
        'btnnBrowse
        '
        Me.btnnBrowse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnnBrowse.FlatAppearance.BorderSize = 0
        Me.btnnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnBrowse.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnBrowse.Location = New System.Drawing.Point(36, 260)
        Me.btnnBrowse.Margin = New System.Windows.Forms.Padding(0)
        Me.btnnBrowse.Name = "btnnBrowse"
        Me.btnnBrowse.Size = New System.Drawing.Size(200, 24)
        Me.btnnBrowse.TabIndex = 15
        Me.btnnBrowse.Text = "BROWSE"
        Me.btnnBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnnBrowse.UseVisualStyleBackColor = True
        '
        'lblWarning
        '
        Me.lblWarning.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblWarning.AutoSize = True
        Me.lblWarning.BackColor = System.Drawing.Color.Transparent
        Me.lblWarning.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarning.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblWarning.Location = New System.Drawing.Point(85, 284)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(102, 14)
        Me.lblWarning.TabIndex = 16
        Me.lblWarning.Text = "Recovery Answer"
        Me.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblWarning.Visible = False
        '
        'pboPrev
        '
        Me.pboPrev.BackColor = System.Drawing.Color.Transparent
        Me.pboPrev.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pboPrev.Image = Global.dizUI.My.Resources.Resources.hovprev
        Me.pboPrev.Location = New System.Drawing.Point(0, 60)
        Me.pboPrev.Margin = New System.Windows.Forms.Padding(0)
        Me.pboPrev.Name = "pboPrev"
        Me.pboPrev.Size = New System.Drawing.Size(36, 200)
        Me.pboPrev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboPrev.TabIndex = 17
        Me.pboPrev.TabStop = False
        '
        'pboNext
        '
        Me.pboNext.BackColor = System.Drawing.Color.Transparent
        Me.pboNext.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pboNext.Image = Global.dizUI.My.Resources.Resources.hovnext
        Me.pboNext.Location = New System.Drawing.Point(236, 60)
        Me.pboNext.Margin = New System.Windows.Forms.Padding(0)
        Me.pboNext.Name = "pboNext"
        Me.pboNext.Size = New System.Drawing.Size(37, 200)
        Me.pboNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboNext.TabIndex = 18
        Me.pboNext.TabStop = False
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Controls.Add(Me.btnImgManager)
        Me.pHeader.Controls.Add(Me.lblSep2)
        Me.pHeader.Controls.Add(Me.btnSave)
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.ForeColor = System.Drawing.Color.White
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(724, 30)
        Me.pHeader.TabIndex = 4
        '
        'btnImgManager
        '
        Me.btnImgManager.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnImgManager.FlatAppearance.BorderSize = 0
        Me.btnImgManager.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnImgManager.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnImgManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImgManager.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImgManager.Location = New System.Drawing.Point(476, 0)
        Me.btnImgManager.Name = "btnImgManager"
        Me.btnImgManager.Size = New System.Drawing.Size(152, 30)
        Me.btnImgManager.TabIndex = 25
        Me.btnImgManager.Text = "MANAJEMEN GAMBAR"
        Me.btnImgManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImgManager.UseVisualStyleBackColor = True
        '
        'lblSep2
        '
        Me.lblSep2.BackColor = System.Drawing.Color.Transparent
        Me.lblSep2.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblSep2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblSep2.Location = New System.Drawing.Point(628, 0)
        Me.lblSep2.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSep2.Name = "lblSep2"
        Me.lblSep2.Size = New System.Drawing.Size(16, 30)
        Me.lblSep2.TabIndex = 24
        Me.lblSep2.Text = "|"
        Me.lblSep2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btnSave.Location = New System.Drawing.Point(644, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "SIMPAN"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'frmProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.ClientSize = New System.Drawing.Size(728, 418)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProfile"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Profil Pengguna"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        Me.tlpEntry.ResumeLayout(False)
        CType(Me.xtcProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcProfile.ResumeLayout(False)
        Me.xtpUsername.ResumeLayout(False)
        Me.tlpPengguna.ResumeLayout(False)
        Me.tlpPengguna.PerformLayout()
        CType(Me.lueJenis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teRecAns.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNamaLengkap.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teRecQuest.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teHandphone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teHint.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpProfile.ResumeLayout(False)
        Me.tlpProfile.ResumeLayout(False)
        Me.tlpProfile.PerformLayout()
        CType(Me.teLastCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teBannedReason.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teUserStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teUserLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tePassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpField.ResumeLayout(False)
        Me.tlpField.PerformLayout()
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboPrev, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboNext, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pBody As System.Windows.Forms.Panel
    Friend WithEvents pHeader As System.Windows.Forms.Panel
    Public WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents tlpField As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblHandphone As System.Windows.Forms.Label
    Friend WithEvents lblHint As System.Windows.Forms.Label
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents lblLevel As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblLastCheck As System.Windows.Forms.Label
    Friend WithEvents pbUser As System.Windows.Forms.PictureBox
    Friend WithEvents lblReason As System.Windows.Forms.Label
    Friend WithEvents teNamaLengkap As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teHandphone As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teHint As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teRecQuest As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teRecAns As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teUsername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tePassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teUserLevel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teUserStatus As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teBannedReason As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teLastCheck As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tlpPengguna As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents xtcProfile As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpUsername As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpProfile As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tlpProfile As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpEntry As System.Windows.Forms.TableLayoutPanel
    Public WithEvents btnnBrowse As System.Windows.Forms.Button
    Friend WithEvents lblWarning As System.Windows.Forms.Label
    Friend WithEvents pboPrev As System.Windows.Forms.PictureBox
    Friend WithEvents pboNext As System.Windows.Forms.PictureBox
    Public WithEvents btnImgManager As System.Windows.Forms.Button
    Public WithEvents lblSep2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents teID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lueJenis As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
End Class
