<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInfoPasien
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
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.tlpAlamat = New System.Windows.Forms.TableLayoutPanel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.meAlamat = New DevExpress.XtraEditors.MemoEdit()
        Me.tlpPasien = New System.Windows.Forms.TableLayoutPanel()
        Me.teHamil = New DevExpress.XtraEditors.TextEdit()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.teTanggalLahir = New DevExpress.XtraEditors.TextEdit()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.teUmur = New DevExpress.XtraEditors.TextEdit()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.teJenisKartu = New DevExpress.XtraEditors.TextEdit()
        Me.teWarganegara = New DevExpress.XtraEditors.TextEdit()
        Me.teRhesus = New DevExpress.XtraEditors.TextEdit()
        Me.teGolonganDarah = New DevExpress.XtraEditors.TextEdit()
        Me.teJenisKelamin = New DevExpress.XtraEditors.TextEdit()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.teNoRM = New DevExpress.XtraEditors.TextEdit()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.teNomorKartu = New DevExpress.XtraEditors.TextEdit()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.teNama = New DevExpress.XtraEditors.TextEdit()
        Me.teNamaPanggilan = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBody.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.tlpAlamat.SuspendLayout()
        CType(Me.meAlamat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpPasien.SuspendLayout()
        CType(Me.teHamil.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teTanggalLahir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teUmur.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teJenisKartu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teWarganegara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teRhesus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teGolonganDarah.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teJenisKelamin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNoRM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNomorKartu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNamaPanggilan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tlpForm.Size = New System.Drawing.Size(690, 428)
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
        Me.pTitle.Size = New System.Drawing.Size(686, 30)
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
        Me.lblTitle.Size = New System.Drawing.Size(596, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Informasi Pasien"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pMinimize
        '
        Me.pMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.pMinimize.Image = Global.dizUI.My.Resources.Resources.min_w
        Me.pMinimize.Location = New System.Drawing.Point(596, 0)
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
        Me.pMaximize.Location = New System.Drawing.Point(626, 0)
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
        Me.pExit.Location = New System.Drawing.Point(656, 0)
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
        Me.pBody.Controls.Add(Me.TableLayoutPanel3)
        Me.pBody.Controls.Add(Me.tlpAlamat)
        Me.pBody.Controls.Add(Me.tlpPasien)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(686, 396)
        Me.pBody.TabIndex = 7
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.lblStatus, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 288)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(686, 100)
        Me.TableLayoutPanel3.TabIndex = 12
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(124, 29)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(437, 42)
        Me.lblStatus.TabIndex = 9
        Me.lblStatus.Text = "Pemindahan Register Pasien akan menonaktifkan Nomor Rekam Medis Lama" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nomor Rekam" &
    " Medis Lama yang dinonaktifkan akan tersedia untuk Pendaftaran Pasien Baru"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tlpAlamat
        '
        Me.tlpAlamat.AutoSize = True
        Me.tlpAlamat.ColumnCount = 2
        Me.tlpAlamat.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpAlamat.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpAlamat.Controls.Add(Me.Label10, 0, 0)
        Me.tlpAlamat.Controls.Add(Me.meAlamat, 1, 0)
        Me.tlpAlamat.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpAlamat.Location = New System.Drawing.Point(0, 192)
        Me.tlpAlamat.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpAlamat.Name = "tlpAlamat"
        Me.tlpAlamat.RowCount = 1
        Me.tlpAlamat.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpAlamat.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96.0!))
        Me.tlpAlamat.Size = New System.Drawing.Size(686, 96)
        Me.tlpAlamat.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(73, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 14)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Alamat"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'meAlamat
        '
        Me.meAlamat.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.meAlamat.Location = New System.Drawing.Point(120, 0)
        Me.meAlamat.Margin = New System.Windows.Forms.Padding(0)
        Me.meAlamat.Name = "meAlamat"
        Me.meAlamat.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.meAlamat.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.meAlamat.Properties.Appearance.Options.UseBackColor = True
        Me.meAlamat.Properties.Appearance.Options.UseFont = True
        Me.meAlamat.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.meAlamat.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.meAlamat.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.meAlamat.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.meAlamat.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.meAlamat.Properties.ReadOnly = True
        Me.meAlamat.Size = New System.Drawing.Size(444, 96)
        Me.meAlamat.TabIndex = 20
        Me.meAlamat.Tag = ""
        '
        'tlpPasien
        '
        Me.tlpPasien.AutoSize = True
        Me.tlpPasien.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpPasien.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlpPasien.ColumnCount = 4
        Me.tlpPasien.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpPasien.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220.0!))
        Me.tlpPasien.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpPasien.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 226.0!))
        Me.tlpPasien.Controls.Add(Me.teHamil, 3, 1)
        Me.tlpPasien.Controls.Add(Me.Label44, 2, 6)
        Me.tlpPasien.Controls.Add(Me.teTanggalLahir, 3, 6)
        Me.tlpPasien.Controls.Add(Me.Label43, 0, 6)
        Me.tlpPasien.Controls.Add(Me.Label41, 0, 1)
        Me.tlpPasien.Controls.Add(Me.Label22, 2, 1)
        Me.tlpPasien.Controls.Add(Me.teUmur, 3, 7)
        Me.tlpPasien.Controls.Add(Me.Label14, 2, 7)
        Me.tlpPasien.Controls.Add(Me.teJenisKartu, 1, 2)
        Me.tlpPasien.Controls.Add(Me.teWarganegara, 3, 5)
        Me.tlpPasien.Controls.Add(Me.teRhesus, 3, 3)
        Me.tlpPasien.Controls.Add(Me.teGolonganDarah, 3, 2)
        Me.tlpPasien.Controls.Add(Me.teJenisKelamin, 1, 7)
        Me.tlpPasien.Controls.Add(Me.Label12, 0, 2)
        Me.tlpPasien.Controls.Add(Me.teNoRM, 1, 1)
        Me.tlpPasien.Controls.Add(Me.Label11, 2, 5)
        Me.tlpPasien.Controls.Add(Me.Label9, 2, 3)
        Me.tlpPasien.Controls.Add(Me.Label1, 2, 2)
        Me.tlpPasien.Controls.Add(Me.teNomorKartu, 1, 3)
        Me.tlpPasien.Controls.Add(Me.Label28, 0, 3)
        Me.tlpPasien.Controls.Add(Me.teNama, 1, 6)
        Me.tlpPasien.Controls.Add(Me.teNamaPanggilan, 1, 5)
        Me.tlpPasien.Controls.Add(Me.Label5, 0, 7)
        Me.tlpPasien.Controls.Add(Me.Label7, 0, 5)
        Me.tlpPasien.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpPasien.Location = New System.Drawing.Point(0, 30)
        Me.tlpPasien.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpPasien.Name = "tlpPasien"
        Me.tlpPasien.RowCount = 9
        Me.tlpPasien.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpPasien.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPasien.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPasien.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPasien.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpPasien.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPasien.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPasien.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPasien.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpPasien.Size = New System.Drawing.Size(686, 162)
        Me.tlpPasien.TabIndex = 14
        '
        'teHamil
        '
        Me.teHamil.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teHamil.Location = New System.Drawing.Point(460, 8)
        Me.teHamil.Margin = New System.Windows.Forms.Padding(0)
        Me.teHamil.Name = "teHamil"
        Me.teHamil.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teHamil.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teHamil.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teHamil.Properties.Appearance.Options.UseBackColor = True
        Me.teHamil.Properties.Appearance.Options.UseFont = True
        Me.teHamil.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teHamil.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teHamil.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teHamil.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teHamil.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teHamil.Properties.MaxLength = 300
        Me.teHamil.Properties.NullText = "[Belum Diisi]"
        Me.teHamil.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teHamil.Properties.ReadOnly = True
        Me.teHamil.Size = New System.Drawing.Size(133, 20)
        Me.teHamil.TabIndex = 11
        Me.teHamil.Tag = ""
        '
        'Label44
        '
        Me.Label44.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(378, 113)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(79, 14)
        Me.Label44.TabIndex = 25
        Me.Label44.Text = "Tanggal Lahir"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teTanggalLahir
        '
        Me.teTanggalLahir.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teTanggalLahir.Location = New System.Drawing.Point(460, 110)
        Me.teTanggalLahir.Margin = New System.Windows.Forms.Padding(0)
        Me.teTanggalLahir.Name = "teTanggalLahir"
        Me.teTanggalLahir.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teTanggalLahir.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teTanggalLahir.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teTanggalLahir.Properties.Appearance.Options.UseBackColor = True
        Me.teTanggalLahir.Properties.Appearance.Options.UseFont = True
        Me.teTanggalLahir.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teTanggalLahir.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teTanggalLahir.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teTanggalLahir.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teTanggalLahir.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teTanggalLahir.Properties.MaxLength = 300
        Me.teTanggalLahir.Properties.NullText = "[Belum Diisi]"
        Me.teTanggalLahir.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teTanggalLahir.Properties.ReadOnly = True
        Me.teTanggalLahir.Size = New System.Drawing.Size(133, 20)
        Me.teTanggalLahir.TabIndex = 18
        Me.teTanggalLahir.Tag = ""
        '
        'Label43
        '
        Me.Label43.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(42, 113)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(75, 14)
        Me.Label43.TabIndex = 43
        Me.Label43.Text = "Nama Pasien"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label41
        '
        Me.Label41.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(17, 11)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(100, 14)
        Me.Label41.TabIndex = 42
        Me.Label41.Text = "No. Rekam Medis"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(377, 11)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(80, 14)
        Me.Label22.TabIndex = 23
        Me.Label22.Text = "Sedang Hamil"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teUmur
        '
        Me.teUmur.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teUmur.Location = New System.Drawing.Point(460, 134)
        Me.teUmur.Margin = New System.Windows.Forms.Padding(0)
        Me.teUmur.Name = "teUmur"
        Me.teUmur.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teUmur.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teUmur.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teUmur.Properties.Appearance.Options.UseBackColor = True
        Me.teUmur.Properties.Appearance.Options.UseFont = True
        Me.teUmur.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teUmur.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teUmur.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teUmur.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teUmur.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teUmur.Properties.MaxLength = 300
        Me.teUmur.Properties.NullText = "[Belum Diisi]"
        Me.teUmur.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teUmur.Properties.ReadOnly = True
        Me.teUmur.Size = New System.Drawing.Size(150, 20)
        Me.teUmur.TabIndex = 19
        Me.teUmur.Tag = ""
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(421, 137)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 14)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Umur"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teJenisKartu
        '
        Me.teJenisKartu.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teJenisKartu.Location = New System.Drawing.Point(120, 32)
        Me.teJenisKartu.Margin = New System.Windows.Forms.Padding(0)
        Me.teJenisKartu.Name = "teJenisKartu"
        Me.teJenisKartu.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teJenisKartu.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teJenisKartu.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teJenisKartu.Properties.Appearance.Options.UseBackColor = True
        Me.teJenisKartu.Properties.Appearance.Options.UseFont = True
        Me.teJenisKartu.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teJenisKartu.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teJenisKartu.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teJenisKartu.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teJenisKartu.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teJenisKartu.Properties.MaxLength = 300
        Me.teJenisKartu.Properties.NullText = "[Belum Diisi]"
        Me.teJenisKartu.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teJenisKartu.Properties.ReadOnly = True
        Me.teJenisKartu.Size = New System.Drawing.Size(150, 20)
        Me.teJenisKartu.TabIndex = 9
        Me.teJenisKartu.Tag = ""
        '
        'teWarganegara
        '
        Me.teWarganegara.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teWarganegara.Location = New System.Drawing.Point(460, 86)
        Me.teWarganegara.Margin = New System.Windows.Forms.Padding(0)
        Me.teWarganegara.Name = "teWarganegara"
        Me.teWarganegara.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teWarganegara.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teWarganegara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teWarganegara.Properties.Appearance.Options.UseBackColor = True
        Me.teWarganegara.Properties.Appearance.Options.UseFont = True
        Me.teWarganegara.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teWarganegara.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teWarganegara.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teWarganegara.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teWarganegara.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teWarganegara.Properties.MaxLength = 300
        Me.teWarganegara.Properties.NullText = "[Belum Diisi]"
        Me.teWarganegara.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teWarganegara.Properties.ReadOnly = True
        Me.teWarganegara.Size = New System.Drawing.Size(180, 20)
        Me.teWarganegara.TabIndex = 17
        Me.teWarganegara.Tag = ""
        '
        'teRhesus
        '
        Me.teRhesus.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teRhesus.Location = New System.Drawing.Point(460, 56)
        Me.teRhesus.Margin = New System.Windows.Forms.Padding(0)
        Me.teRhesus.Name = "teRhesus"
        Me.teRhesus.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teRhesus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teRhesus.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teRhesus.Properties.Appearance.Options.UseBackColor = True
        Me.teRhesus.Properties.Appearance.Options.UseFont = True
        Me.teRhesus.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teRhesus.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teRhesus.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teRhesus.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teRhesus.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teRhesus.Properties.MaxLength = 300
        Me.teRhesus.Properties.NullText = "[Belum Diisi]"
        Me.teRhesus.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teRhesus.Properties.ReadOnly = True
        Me.teRhesus.Size = New System.Drawing.Size(77, 20)
        Me.teRhesus.TabIndex = 13
        Me.teRhesus.Tag = ""
        '
        'teGolonganDarah
        '
        Me.teGolonganDarah.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teGolonganDarah.Location = New System.Drawing.Point(460, 32)
        Me.teGolonganDarah.Margin = New System.Windows.Forms.Padding(0)
        Me.teGolonganDarah.Name = "teGolonganDarah"
        Me.teGolonganDarah.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teGolonganDarah.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teGolonganDarah.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teGolonganDarah.Properties.Appearance.Options.UseBackColor = True
        Me.teGolonganDarah.Properties.Appearance.Options.UseFont = True
        Me.teGolonganDarah.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teGolonganDarah.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teGolonganDarah.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teGolonganDarah.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teGolonganDarah.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teGolonganDarah.Properties.MaxLength = 300
        Me.teGolonganDarah.Properties.NullText = "[Belum Diisi]"
        Me.teGolonganDarah.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teGolonganDarah.Properties.ReadOnly = True
        Me.teGolonganDarah.Size = New System.Drawing.Size(77, 20)
        Me.teGolonganDarah.TabIndex = 12
        Me.teGolonganDarah.Tag = ""
        '
        'teJenisKelamin
        '
        Me.teJenisKelamin.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teJenisKelamin.Location = New System.Drawing.Point(120, 134)
        Me.teJenisKelamin.Margin = New System.Windows.Forms.Padding(0)
        Me.teJenisKelamin.Name = "teJenisKelamin"
        Me.teJenisKelamin.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teJenisKelamin.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teJenisKelamin.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teJenisKelamin.Properties.Appearance.Options.UseBackColor = True
        Me.teJenisKelamin.Properties.Appearance.Options.UseFont = True
        Me.teJenisKelamin.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teJenisKelamin.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teJenisKelamin.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teJenisKelamin.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teJenisKelamin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teJenisKelamin.Properties.MaxLength = 300
        Me.teJenisKelamin.Properties.NullText = "[Belum Diisi]"
        Me.teJenisKelamin.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teJenisKelamin.Properties.ReadOnly = True
        Me.teJenisKelamin.Size = New System.Drawing.Size(150, 20)
        Me.teJenisKelamin.TabIndex = 16
        Me.teJenisKelamin.Tag = ""
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(32, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 14)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Jenis Identitas"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teNoRM
        '
        Me.teNoRM.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNoRM.EditValue = "00-00-00-00"
        Me.teNoRM.Location = New System.Drawing.Point(120, 8)
        Me.teNoRM.Margin = New System.Windows.Forms.Padding(0)
        Me.teNoRM.Name = "teNoRM"
        Me.teNoRM.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teNoRM.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNoRM.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNoRM.Properties.Appearance.Options.UseBackColor = True
        Me.teNoRM.Properties.Appearance.Options.UseFont = True
        Me.teNoRM.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNoRM.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNoRM.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teNoRM.Properties.AppearanceDisabled.Options.UseFont = True
        Me.teNoRM.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNoRM.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNoRM.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teNoRM.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.teNoRM.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNoRM.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.teNoRM.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.teNoRM.Properties.Mask.EditMask = "##-##-##-#0"
        Me.teNoRM.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.teNoRM.Properties.Mask.PlaceHolder = Global.Microsoft.VisualBasic.ChrW(48)
        Me.teNoRM.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teNoRM.Properties.MaxLength = 300
        Me.teNoRM.Properties.NullText = "[Belum Diisi]"
        Me.teNoRM.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNoRM.Properties.ReadOnly = True
        Me.teNoRM.Size = New System.Drawing.Size(99, 20)
        Me.teNoRM.TabIndex = 8
        Me.teNoRM.Tag = ""
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(378, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 14)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Warganegara"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(412, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 14)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Rhesus"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(364, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 14)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Golongan Darah"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teNomorKartu
        '
        Me.teNomorKartu.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNomorKartu.Location = New System.Drawing.Point(120, 56)
        Me.teNomorKartu.Margin = New System.Windows.Forms.Padding(0)
        Me.teNomorKartu.Name = "teNomorKartu"
        Me.teNomorKartu.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teNomorKartu.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNomorKartu.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNomorKartu.Properties.Appearance.Options.UseBackColor = True
        Me.teNomorKartu.Properties.Appearance.Options.UseFont = True
        Me.teNomorKartu.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNomorKartu.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teNomorKartu.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNomorKartu.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teNomorKartu.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNomorKartu.Properties.MaxLength = 300
        Me.teNomorKartu.Properties.NullText = "[Belum Diisi]"
        Me.teNomorKartu.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNomorKartu.Properties.ReadOnly = True
        Me.teNomorKartu.Size = New System.Drawing.Size(150, 20)
        Me.teNomorKartu.TabIndex = 10
        Me.teNomorKartu.Tag = ""
        '
        'Label28
        '
        Me.Label28.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(22, 59)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(95, 14)
        Me.Label28.TabIndex = 56
        Me.Label28.Text = "Nomor Identitas"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teNama
        '
        Me.teNama.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNama.Location = New System.Drawing.Point(120, 110)
        Me.teNama.Margin = New System.Windows.Forms.Padding(0)
        Me.teNama.Name = "teNama"
        Me.teNama.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teNama.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNama.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNama.Properties.Appearance.Options.UseBackColor = True
        Me.teNama.Properties.Appearance.Options.UseFont = True
        Me.teNama.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNama.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNama.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teNama.Properties.AppearanceDisabled.Options.UseFont = True
        Me.teNama.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNama.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNama.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teNama.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.teNama.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNama.Properties.MaxLength = 300
        Me.teNama.Properties.NullText = "[Belum Diisi]"
        Me.teNama.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNama.Properties.ReadOnly = True
        Me.teNama.Size = New System.Drawing.Size(220, 20)
        Me.teNama.TabIndex = 15
        Me.teNama.Tag = ""
        '
        'teNamaPanggilan
        '
        Me.teNamaPanggilan.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNamaPanggilan.Location = New System.Drawing.Point(120, 86)
        Me.teNamaPanggilan.Margin = New System.Windows.Forms.Padding(0)
        Me.teNamaPanggilan.Name = "teNamaPanggilan"
        Me.teNamaPanggilan.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teNamaPanggilan.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNamaPanggilan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNamaPanggilan.Properties.Appearance.Options.UseBackColor = True
        Me.teNamaPanggilan.Properties.Appearance.Options.UseFont = True
        Me.teNamaPanggilan.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNamaPanggilan.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teNamaPanggilan.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNamaPanggilan.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teNamaPanggilan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNamaPanggilan.Properties.MaxLength = 300
        Me.teNamaPanggilan.Properties.NullText = "[Belum Diisi]"
        Me.teNamaPanggilan.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNamaPanggilan.Properties.ReadOnly = True
        Me.teNamaPanggilan.Size = New System.Drawing.Size(150, 20)
        Me.teNamaPanggilan.TabIndex = 14
        Me.teNamaPanggilan.Tag = ""
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(39, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 14)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Jenis Kelamin"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 14)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Nama Panggilan"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.ForeColor = System.Drawing.Color.White
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(686, 30)
        Me.pHeader.TabIndex = 4
        '
        'frmInfoPasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(690, 428)
        Me.ControlBox = False
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInfoPasien"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informasi Pasien"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        Me.pBody.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.tlpAlamat.ResumeLayout(False)
        Me.tlpAlamat.PerformLayout()
        CType(Me.meAlamat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpPasien.ResumeLayout(False)
        Me.tlpPasien.PerformLayout()
        CType(Me.teHamil.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teTanggalLahir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teUmur.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teJenisKartu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teWarganegara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teRhesus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teGolonganDarah.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teJenisKelamin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNoRM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNomorKartu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNamaPanggilan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Public WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents lblStatus As Label
    Friend WithEvents tlpAlamat As TableLayoutPanel
    Friend WithEvents Label10 As Label
    Friend WithEvents meAlamat As DevExpress.XtraEditors.MemoEdit
    Public WithEvents tlpPasien As TableLayoutPanel
    Friend WithEvents teHamil As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label44 As Label
    Friend WithEvents teTanggalLahir As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label43 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents teUmur As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label14 As Label
    Friend WithEvents teJenisKartu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teWarganegara As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teRhesus As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teGolonganDarah As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teJenisKelamin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label12 As Label
    Friend WithEvents teNoRM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents teNomorKartu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label28 As Label
    Friend WithEvents teNama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teNamaPanggilan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
End Class
