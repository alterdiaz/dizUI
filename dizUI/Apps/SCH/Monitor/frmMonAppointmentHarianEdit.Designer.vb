<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMonAppointmentHarianEdit
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
        Me.tlpPasienBaru = New System.Windows.Forms.TableLayoutPanel()
        Me.teAppType = New DevExpress.XtraEditors.TextEdit()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.teJenisKelamin = New DevExpress.XtraEditors.TextEdit()
        Me.teTanggalLahir = New DevExpress.XtraEditors.TextEdit()
        Me.teAppVia = New DevExpress.XtraEditors.TextEdit()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.teAlamat = New DevExpress.XtraEditors.MemoEdit()
        Me.teNoRM = New DevExpress.XtraEditors.TextEdit()
        Me.teNama = New DevExpress.XtraEditors.TextEdit()
        Me.teTelepon2 = New DevExpress.XtraEditors.TextEdit()
        Me.teTelepon1 = New DevExpress.XtraEditors.TextEdit()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.meRemarks = New DevExpress.XtraEditors.MemoEdit()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBody.SuspendLayout()
        Me.tlpPasienBaru.SuspendLayout()
        CType(Me.teAppType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teJenisKelamin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teTanggalLahir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teAppVia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teAlamat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNoRM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teTelepon2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teTelepon1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeader.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.meRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tlpForm.Size = New System.Drawing.Size(739, 252)
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
        Me.pTitle.Size = New System.Drawing.Size(735, 30)
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
        Me.lblTitle.Size = New System.Drawing.Size(645, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Appointment Remarks"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pMinimize
        '
        Me.pMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.pMinimize.Image = Global.dizUI.My.Resources.Resources.min_w
        Me.pMinimize.Location = New System.Drawing.Point(645, 0)
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
        Me.pMaximize.Location = New System.Drawing.Point(675, 0)
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
        Me.pExit.Location = New System.Drawing.Point(705, 0)
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
        Me.pBody.Controls.Add(Me.TableLayoutPanel1)
        Me.pBody.Controls.Add(Me.tlpPasienBaru)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(735, 220)
        Me.pBody.TabIndex = 7
        '
        'tlpPasienBaru
        '
        Me.tlpPasienBaru.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlpPasienBaru.ColumnCount = 6
        Me.tlpPasienBaru.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tlpPasienBaru.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.tlpPasienBaru.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.tlpPasienBaru.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.tlpPasienBaru.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.tlpPasienBaru.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPasienBaru.Controls.Add(Me.teAppType, 2, 5)
        Me.tlpPasienBaru.Controls.Add(Me.Label17, 1, 5)
        Me.tlpPasienBaru.Controls.Add(Me.teJenisKelamin, 2, 2)
        Me.tlpPasienBaru.Controls.Add(Me.teTanggalLahir, 2, 3)
        Me.tlpPasienBaru.Controls.Add(Me.teAppVia, 4, 4)
        Me.tlpPasienBaru.Controls.Add(Me.Label16, 3, 4)
        Me.tlpPasienBaru.Controls.Add(Me.teAlamat, 2, 4)
        Me.tlpPasienBaru.Controls.Add(Me.teNoRM, 4, 1)
        Me.tlpPasienBaru.Controls.Add(Me.teNama, 2, 1)
        Me.tlpPasienBaru.Controls.Add(Me.teTelepon2, 4, 3)
        Me.tlpPasienBaru.Controls.Add(Me.teTelepon1, 4, 2)
        Me.tlpPasienBaru.Controls.Add(Me.Label27, 3, 3)
        Me.tlpPasienBaru.Controls.Add(Me.Label28, 3, 2)
        Me.tlpPasienBaru.Controls.Add(Me.Label29, 1, 1)
        Me.tlpPasienBaru.Controls.Add(Me.Label30, 3, 1)
        Me.tlpPasienBaru.Controls.Add(Me.Label31, 1, 2)
        Me.tlpPasienBaru.Controls.Add(Me.Label32, 1, 3)
        Me.tlpPasienBaru.Controls.Add(Me.Label33, 1, 4)
        Me.tlpPasienBaru.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpPasienBaru.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.tlpPasienBaru.ForeColor = System.Drawing.Color.Black
        Me.tlpPasienBaru.Location = New System.Drawing.Point(0, 30)
        Me.tlpPasienBaru.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpPasienBaru.Name = "tlpPasienBaru"
        Me.tlpPasienBaru.RowCount = 7
        Me.tlpPasienBaru.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPasienBaru.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPasienBaru.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPasienBaru.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPasienBaru.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPasienBaru.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPasienBaru.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPasienBaru.Size = New System.Drawing.Size(735, 129)
        Me.tlpPasienBaru.TabIndex = 44
        '
        'teAppType
        '
        Me.teAppType.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teAppType.EditValue = ""
        Me.teAppType.Location = New System.Drawing.Point(114, 102)
        Me.teAppType.Margin = New System.Windows.Forms.Padding(0)
        Me.teAppType.Name = "teAppType"
        Me.teAppType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teAppType.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teAppType.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teAppType.Properties.Appearance.Options.UseBackColor = True
        Me.teAppType.Properties.Appearance.Options.UseFont = True
        Me.teAppType.Properties.Appearance.Options.UseForeColor = True
        Me.teAppType.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teAppType.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teAppType.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teAppType.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teAppType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teAppType.Properties.MaxLength = 50
        Me.teAppType.Properties.NullText = "00-00-00-00"
        Me.teAppType.Properties.ReadOnly = True
        Me.teAppType.Size = New System.Drawing.Size(133, 20)
        Me.teAppType.TabIndex = 34
        Me.teAppType.Tag = ""
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label17.Location = New System.Drawing.Point(53, 105)
        Me.Label17.Margin = New System.Windows.Forms.Padding(0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 14)
        Me.Label17.TabIndex = 41
        Me.Label17.Text = "App Type"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'teJenisKelamin
        '
        Me.teJenisKelamin.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teJenisKelamin.EditValue = ""
        Me.teJenisKelamin.Location = New System.Drawing.Point(114, 30)
        Me.teJenisKelamin.Margin = New System.Windows.Forms.Padding(0)
        Me.teJenisKelamin.Name = "teJenisKelamin"
        Me.teJenisKelamin.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teJenisKelamin.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teJenisKelamin.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teJenisKelamin.Properties.Appearance.Options.UseBackColor = True
        Me.teJenisKelamin.Properties.Appearance.Options.UseFont = True
        Me.teJenisKelamin.Properties.Appearance.Options.UseForeColor = True
        Me.teJenisKelamin.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teJenisKelamin.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teJenisKelamin.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teJenisKelamin.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teJenisKelamin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teJenisKelamin.Properties.MaxLength = 50
        Me.teJenisKelamin.Properties.NullText = "00-00-00-00"
        Me.teJenisKelamin.Properties.ReadOnly = True
        Me.teJenisKelamin.Size = New System.Drawing.Size(150, 20)
        Me.teJenisKelamin.TabIndex = 33
        Me.teJenisKelamin.Tag = ""
        '
        'teTanggalLahir
        '
        Me.teTanggalLahir.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teTanggalLahir.EditValue = ""
        Me.teTanggalLahir.Location = New System.Drawing.Point(114, 54)
        Me.teTanggalLahir.Margin = New System.Windows.Forms.Padding(0)
        Me.teTanggalLahir.Name = "teTanggalLahir"
        Me.teTanggalLahir.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teTanggalLahir.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teTanggalLahir.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teTanggalLahir.Properties.Appearance.Options.UseBackColor = True
        Me.teTanggalLahir.Properties.Appearance.Options.UseFont = True
        Me.teTanggalLahir.Properties.Appearance.Options.UseForeColor = True
        Me.teTanggalLahir.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teTanggalLahir.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teTanggalLahir.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teTanggalLahir.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teTanggalLahir.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teTanggalLahir.Properties.MaxLength = 50
        Me.teTanggalLahir.Properties.NullText = "00-00-00-00"
        Me.teTanggalLahir.Properties.ReadOnly = True
        Me.teTanggalLahir.Size = New System.Drawing.Size(133, 20)
        Me.teTanggalLahir.TabIndex = 33
        Me.teTanggalLahir.Tag = ""
        '
        'teAppVia
        '
        Me.teAppVia.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teAppVia.EditValue = ""
        Me.teAppVia.Location = New System.Drawing.Point(474, 78)
        Me.teAppVia.Margin = New System.Windows.Forms.Padding(0)
        Me.teAppVia.Name = "teAppVia"
        Me.teAppVia.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teAppVia.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teAppVia.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teAppVia.Properties.Appearance.Options.UseBackColor = True
        Me.teAppVia.Properties.Appearance.Options.UseFont = True
        Me.teAppVia.Properties.Appearance.Options.UseForeColor = True
        Me.teAppVia.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teAppVia.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teAppVia.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teAppVia.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teAppVia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teAppVia.Properties.MaxLength = 50
        Me.teAppVia.Properties.NullText = "00-00-00-00"
        Me.teAppVia.Properties.ReadOnly = True
        Me.teAppVia.Size = New System.Drawing.Size(135, 20)
        Me.teAppVia.TabIndex = 32
        Me.teAppVia.Tag = ""
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label16.Location = New System.Drawing.Point(377, 81)
        Me.Label16.Margin = New System.Windows.Forms.Padding(0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(97, 14)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "Appointment via"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'teAlamat
        '
        Me.teAlamat.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teAlamat.Location = New System.Drawing.Point(114, 76)
        Me.teAlamat.Margin = New System.Windows.Forms.Padding(0)
        Me.teAlamat.Name = "teAlamat"
        Me.teAlamat.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teAlamat.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teAlamat.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teAlamat.Properties.Appearance.Options.UseBackColor = True
        Me.teAlamat.Properties.Appearance.Options.UseFont = True
        Me.teAlamat.Properties.Appearance.Options.UseForeColor = True
        Me.teAlamat.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teAlamat.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teAlamat.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.teAlamat.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teAlamat.Properties.AppearanceDisabled.Options.UseFont = True
        Me.teAlamat.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.teAlamat.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teAlamat.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teAlamat.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.teAlamat.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teAlamat.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.teAlamat.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.teAlamat.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teAlamat.Properties.MaxLength = 1000
        Me.teAlamat.Properties.NullText = "-"
        Me.teAlamat.Properties.ReadOnly = True
        Me.teAlamat.Size = New System.Drawing.Size(234, 24)
        Me.teAlamat.TabIndex = 73
        '
        'teNoRM
        '
        Me.teNoRM.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNoRM.Location = New System.Drawing.Point(474, 6)
        Me.teNoRM.Margin = New System.Windows.Forms.Padding(0)
        Me.teNoRM.Name = "teNoRM"
        Me.teNoRM.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNoRM.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNoRM.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teNoRM.Properties.Appearance.Options.UseBackColor = True
        Me.teNoRM.Properties.Appearance.Options.UseFont = True
        Me.teNoRM.Properties.Appearance.Options.UseForeColor = True
        Me.teNoRM.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNoRM.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teNoRM.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNoRM.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teNoRM.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNoRM.Properties.MaxLength = 50
        Me.teNoRM.Properties.NullText = "00-00-00-00"
        Me.teNoRM.Properties.ReadOnly = True
        Me.teNoRM.Size = New System.Drawing.Size(135, 20)
        Me.teNoRM.TabIndex = 31
        Me.teNoRM.Tag = ""
        '
        'teNama
        '
        Me.teNama.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNama.Location = New System.Drawing.Point(114, 6)
        Me.teNama.Margin = New System.Windows.Forms.Padding(0)
        Me.teNama.Name = "teNama"
        Me.teNama.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNama.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNama.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teNama.Properties.Appearance.Options.UseBackColor = True
        Me.teNama.Properties.Appearance.Options.UseFont = True
        Me.teNama.Properties.Appearance.Options.UseForeColor = True
        Me.teNama.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNama.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teNama.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNama.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teNama.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNama.Properties.MaxLength = 300
        Me.teNama.Properties.ReadOnly = True
        Me.teNama.Size = New System.Drawing.Size(234, 20)
        Me.teNama.TabIndex = 31
        Me.teNama.Tag = ""
        '
        'teTelepon2
        '
        Me.teTelepon2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teTelepon2.Location = New System.Drawing.Point(474, 54)
        Me.teTelepon2.Margin = New System.Windows.Forms.Padding(0)
        Me.teTelepon2.Name = "teTelepon2"
        Me.teTelepon2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teTelepon2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teTelepon2.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teTelepon2.Properties.Appearance.Options.UseBackColor = True
        Me.teTelepon2.Properties.Appearance.Options.UseFont = True
        Me.teTelepon2.Properties.Appearance.Options.UseForeColor = True
        Me.teTelepon2.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teTelepon2.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teTelepon2.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teTelepon2.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teTelepon2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teTelepon2.Properties.MaxLength = 30
        Me.teTelepon2.Properties.NullText = "0"
        Me.teTelepon2.Properties.ReadOnly = True
        Me.teTelepon2.Size = New System.Drawing.Size(157, 20)
        Me.teTelepon2.TabIndex = 30
        Me.teTelepon2.Tag = ""
        '
        'teTelepon1
        '
        Me.teTelepon1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teTelepon1.Location = New System.Drawing.Point(474, 30)
        Me.teTelepon1.Margin = New System.Windows.Forms.Padding(0)
        Me.teTelepon1.Name = "teTelepon1"
        Me.teTelepon1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teTelepon1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teTelepon1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teTelepon1.Properties.Appearance.Options.UseBackColor = True
        Me.teTelepon1.Properties.Appearance.Options.UseFont = True
        Me.teTelepon1.Properties.Appearance.Options.UseForeColor = True
        Me.teTelepon1.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teTelepon1.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teTelepon1.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teTelepon1.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teTelepon1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teTelepon1.Properties.MaxLength = 30
        Me.teTelepon1.Properties.NullText = "0"
        Me.teTelepon1.Properties.ReadOnly = True
        Me.teTelepon1.Size = New System.Drawing.Size(157, 20)
        Me.teTelepon1.TabIndex = 30
        Me.teTelepon1.Tag = ""
        '
        'Label27
        '
        Me.Label27.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label27.Location = New System.Drawing.Point(411, 57)
        Me.Label27.Margin = New System.Windows.Forms.Padding(0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(63, 14)
        Me.Label27.TabIndex = 34
        Me.Label27.Text = "Telepon 2"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label28
        '
        Me.Label28.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label28.Location = New System.Drawing.Point(411, 33)
        Me.Label28.Margin = New System.Windows.Forms.Padding(0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(63, 14)
        Me.Label28.TabIndex = 33
        Me.Label28.Text = "Telepon 1"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label29
        '
        Me.Label29.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label29.Location = New System.Drawing.Point(77, 9)
        Me.Label29.Margin = New System.Windows.Forms.Padding(0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(37, 14)
        Me.Label29.TabIndex = 30
        Me.Label29.Text = "Nama"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label30
        '
        Me.Label30.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label30.Location = New System.Drawing.Point(374, 9)
        Me.Label30.Margin = New System.Windows.Forms.Padding(0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(100, 14)
        Me.Label30.TabIndex = 31
        Me.Label30.Text = "No. Rekam Medis"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label31
        '
        Me.Label31.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label31.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label31.Location = New System.Drawing.Point(36, 33)
        Me.Label31.Margin = New System.Windows.Forms.Padding(0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(78, 14)
        Me.Label31.TabIndex = 31
        Me.Label31.Text = "Jenis Kelamin"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label32
        '
        Me.Label32.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label32.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label32.Location = New System.Drawing.Point(35, 57)
        Me.Label32.Margin = New System.Windows.Forms.Padding(0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(79, 14)
        Me.Label32.TabIndex = 32
        Me.Label32.Text = "Tanggal Lahir"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label33
        '
        Me.Label33.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label33.Location = New System.Drawing.Point(70, 81)
        Me.Label33.Margin = New System.Windows.Forms.Padding(0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(44, 14)
        Me.Label33.TabIndex = 33
        Me.Label33.Text = "Alamat"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.pHeader.Size = New System.Drawing.Size(735, 30)
        Me.pHeader.TabIndex = 4
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
        Me.btnSave.Location = New System.Drawing.Point(655, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 26
        Me.btnSave.Text = "SIMPAN"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 520.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.meRemarks, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 159)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(735, 61)
        Me.TableLayoutPanel1.TabIndex = 45
        '
        'meRemarks
        '
        Me.meRemarks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.meRemarks.Location = New System.Drawing.Point(107, 0)
        Me.meRemarks.Margin = New System.Windows.Forms.Padding(0)
        Me.meRemarks.Name = "meRemarks"
        Me.meRemarks.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.meRemarks.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.meRemarks.Properties.Appearance.Options.UseBackColor = True
        Me.meRemarks.Properties.Appearance.Options.UseFont = True
        Me.meRemarks.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.meRemarks.Properties.MaxLength = 8000
        Me.meRemarks.Properties.NullValuePrompt = "Belum Diisi"
        Me.meRemarks.Size = New System.Drawing.Size(520, 55)
        Me.meRemarks.TabIndex = 43
        Me.meRemarks.Tag = "remarks"
        '
        'frmMonAppointmentHarianEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(739, 252)
        Me.ControlBox = False
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMonAppointmentHarianEdit"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Appointment Remarks"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        Me.pBody.PerformLayout()
        Me.tlpPasienBaru.ResumeLayout(False)
        Me.tlpPasienBaru.PerformLayout()
        CType(Me.teAppType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teJenisKelamin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teTanggalLahir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teAppVia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teAlamat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNoRM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teTelepon2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teTelepon1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.meRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents tlpPasienBaru As TableLayoutPanel
    Friend WithEvents teAppVia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label16 As Label
    Friend WithEvents teAlamat As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents teNoRM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teNama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teTelepon2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teTelepon1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents teJenisKelamin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teTanggalLahir As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teAppType As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label17 As Label
    Public WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents meRemarks As DevExpress.XtraEditors.MemoEdit
End Class
