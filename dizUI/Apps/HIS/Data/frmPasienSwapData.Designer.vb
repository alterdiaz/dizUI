<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPasienSwapData
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.teNoRMbaru = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.teNamaBaru = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.teSearchBaru = New DevExpress.XtraEditors.TextEdit()
        Me.btnSearchBaru = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.tlpField = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.teNoRMlama = New DevExpress.XtraEditors.TextEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.teNamaLama = New DevExpress.XtraEditors.TextEdit()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.lblKaryawan = New System.Windows.Forms.Label()
        Me.teSearchLama = New DevExpress.XtraEditors.TextEdit()
        Me.btnSearchLama = New System.Windows.Forms.Button()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBody.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.teNoRMbaru.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNamaBaru.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.teSearchBaru.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tlpField.SuspendLayout()
        CType(Me.teNoRMlama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNamaLama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeader.SuspendLayout()
        CType(Me.teSearchLama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tlpForm.Size = New System.Drawing.Size(690, 308)
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
        Me.lblTitle.Text = "Swap Data Pasien"
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
        Me.pBody.Controls.Add(Me.TableLayoutPanel2)
        Me.pBody.Controls.Add(Me.Panel1)
        Me.pBody.Controls.Add(Me.TableLayoutPanel1)
        Me.pBody.Controls.Add(Me.tlpField)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(686, 276)
        Me.pBody.TabIndex = 7
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 570.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label8, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 228)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(686, 48)
        Me.TableLayoutPanel3.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(91, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(503, 28)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Pemindahan Register Pasien akan menonaktifkan Nomor Rekam Medis Lama" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nomor Rekam" &
    " Medis Lama yang dinonaktifkan akan tersedia untuk Pendaftaran Pasien Baru"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 6
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.teNoRMbaru, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.teNamaBaru, 4, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 3, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 168)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(686, 60)
        Me.TableLayoutPanel2.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(185, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 14)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Rekam Medis Baru"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teNoRMbaru
        '
        Me.teNoRMbaru.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNoRMbaru.EditValue = "00-00-00-00"
        Me.teNoRMbaru.Location = New System.Drawing.Point(168, 32)
        Me.teNoRMbaru.Margin = New System.Windows.Forms.Padding(0)
        Me.teNoRMbaru.Name = "teNoRMbaru"
        Me.teNoRMbaru.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teNoRMbaru.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNoRMbaru.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNoRMbaru.Properties.Appearance.Options.UseBackColor = True
        Me.teNoRMbaru.Properties.Appearance.Options.UseFont = True
        Me.teNoRMbaru.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNoRMbaru.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNoRMbaru.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teNoRMbaru.Properties.AppearanceDisabled.Options.UseFont = True
        Me.teNoRMbaru.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNoRMbaru.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNoRMbaru.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teNoRMbaru.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.teNoRMbaru.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNoRMbaru.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.teNoRMbaru.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.teNoRMbaru.Properties.Mask.EditMask = "##-##-##-#0"
        Me.teNoRMbaru.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.teNoRMbaru.Properties.Mask.PlaceHolder = Global.Microsoft.VisualBasic.ChrW(48)
        Me.teNoRMbaru.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teNoRMbaru.Properties.MaxLength = 300
        Me.teNoRMbaru.Properties.NullText = "[Belum Diisi]"
        Me.teNoRMbaru.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNoRMbaru.Properties.ReadOnly = True
        Me.teNoRMbaru.Size = New System.Drawing.Size(99, 20)
        Me.teNoRMbaru.TabIndex = 15
        Me.teNoRMbaru.Tag = "norm"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 14)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "No. Rekam Medis"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teNamaBaru
        '
        Me.teNamaBaru.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNamaBaru.Location = New System.Drawing.Point(408, 32)
        Me.teNamaBaru.Margin = New System.Windows.Forms.Padding(0)
        Me.teNamaBaru.Name = "teNamaBaru"
        Me.teNamaBaru.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teNamaBaru.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNamaBaru.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNamaBaru.Properties.Appearance.Options.UseBackColor = True
        Me.teNamaBaru.Properties.Appearance.Options.UseFont = True
        Me.teNamaBaru.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNamaBaru.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNamaBaru.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teNamaBaru.Properties.AppearanceDisabled.Options.UseFont = True
        Me.teNamaBaru.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNamaBaru.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNamaBaru.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teNamaBaru.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.teNamaBaru.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNamaBaru.Properties.MaxLength = 300
        Me.teNamaBaru.Properties.NullText = "[Belum Diisi]"
        Me.teNamaBaru.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNamaBaru.Properties.ReadOnly = True
        Me.teNamaBaru.Size = New System.Drawing.Size(218, 20)
        Me.teNamaBaru.TabIndex = 19
        Me.teNamaBaru.Tag = "namapasien"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(330, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 14)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Nama Pasien"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.teSearchBaru)
        Me.Panel1.Controls.Add(Me.btnSearchBaru)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 138)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(686, 30)
        Me.Panel1.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(314, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 14)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Nama Pasien"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teSearchBaru
        '
        Me.teSearchBaru.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.teSearchBaru.Location = New System.Drawing.Point(392, 5)
        Me.teSearchBaru.Margin = New System.Windows.Forms.Padding(0)
        Me.teSearchBaru.Name = "teSearchBaru"
        Me.teSearchBaru.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teSearchBaru.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teSearchBaru.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teSearchBaru.Properties.Appearance.Options.UseBackColor = True
        Me.teSearchBaru.Properties.Appearance.Options.UseFont = True
        Me.teSearchBaru.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teSearchBaru.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teSearchBaru.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teSearchBaru.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teSearchBaru.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teSearchBaru.Properties.MaxLength = 300
        Me.teSearchBaru.Properties.NullText = "[Belum Diisi]"
        Me.teSearchBaru.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teSearchBaru.Size = New System.Drawing.Size(150, 20)
        Me.teSearchBaru.TabIndex = 21
        Me.teSearchBaru.Tag = ""
        '
        'btnSearchBaru
        '
        Me.btnSearchBaru.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSearchBaru.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSearchBaru.FlatAppearance.BorderSize = 0
        Me.btnSearchBaru.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnSearchBaru.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnSearchBaru.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchBaru.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchBaru.Location = New System.Drawing.Point(546, 0)
        Me.btnSearchBaru.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSearchBaru.Name = "btnSearchBaru"
        Me.btnSearchBaru.Size = New System.Drawing.Size(60, 30)
        Me.btnSearchBaru.TabIndex = 5
        Me.btnSearchBaru.Text = "CARI"
        Me.btnSearchBaru.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchBaru.UseVisualStyleBackColor = False
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
        Me.btnSave.Location = New System.Drawing.Point(606, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 4
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
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 570.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblStatus, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 90)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(686, 48)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(205, 10)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(275, 28)
        Me.lblStatus.TabIndex = 9
        Me.lblStatus.Text = "Jumlah Registrasi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1 IRJ, 2 IRM, 10 IGD, 15 LAB, 20 RAD, 999 IRNA"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tlpField
        '
        Me.tlpField.AutoSize = True
        Me.tlpField.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpField.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlpField.ColumnCount = 6
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.Controls.Add(Me.Label5, 2, 1)
        Me.tlpField.Controls.Add(Me.Label1, 1, 2)
        Me.tlpField.Controls.Add(Me.teNoRMlama, 2, 2)
        Me.tlpField.Controls.Add(Me.Label7, 3, 2)
        Me.tlpField.Controls.Add(Me.teNamaLama, 4, 2)
        Me.tlpField.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpField.Location = New System.Drawing.Point(0, 30)
        Me.tlpField.Name = "tlpField"
        Me.tlpField.RowCount = 4
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpField.Size = New System.Drawing.Size(686, 60)
        Me.tlpField.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(183, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 14)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Rekam Medis Lama"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 14)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "No. Rekam Medis"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teNoRMlama
        '
        Me.teNoRMlama.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNoRMlama.EditValue = "00-00-00-00"
        Me.teNoRMlama.Location = New System.Drawing.Point(168, 32)
        Me.teNoRMlama.Margin = New System.Windows.Forms.Padding(0)
        Me.teNoRMlama.Name = "teNoRMlama"
        Me.teNoRMlama.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teNoRMlama.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNoRMlama.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNoRMlama.Properties.Appearance.Options.UseBackColor = True
        Me.teNoRMlama.Properties.Appearance.Options.UseFont = True
        Me.teNoRMlama.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNoRMlama.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNoRMlama.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teNoRMlama.Properties.AppearanceDisabled.Options.UseFont = True
        Me.teNoRMlama.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNoRMlama.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNoRMlama.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teNoRMlama.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.teNoRMlama.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNoRMlama.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.teNoRMlama.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.teNoRMlama.Properties.Mask.EditMask = "##-##-##-#0"
        Me.teNoRMlama.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.teNoRMlama.Properties.Mask.PlaceHolder = Global.Microsoft.VisualBasic.ChrW(48)
        Me.teNoRMlama.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teNoRMlama.Properties.MaxLength = 300
        Me.teNoRMlama.Properties.NullText = "[Belum Diisi]"
        Me.teNoRMlama.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNoRMlama.Properties.ReadOnly = True
        Me.teNoRMlama.Size = New System.Drawing.Size(99, 20)
        Me.teNoRMlama.TabIndex = 15
        Me.teNoRMlama.Tag = "norm"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(330, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 14)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Nama Pasien"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teNamaLama
        '
        Me.teNamaLama.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNamaLama.Location = New System.Drawing.Point(408, 32)
        Me.teNamaLama.Margin = New System.Windows.Forms.Padding(0)
        Me.teNamaLama.Name = "teNamaLama"
        Me.teNamaLama.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teNamaLama.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNamaLama.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNamaLama.Properties.Appearance.Options.UseBackColor = True
        Me.teNamaLama.Properties.Appearance.Options.UseFont = True
        Me.teNamaLama.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNamaLama.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNamaLama.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teNamaLama.Properties.AppearanceDisabled.Options.UseFont = True
        Me.teNamaLama.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNamaLama.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNamaLama.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teNamaLama.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.teNamaLama.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNamaLama.Properties.MaxLength = 300
        Me.teNamaLama.Properties.NullText = "[Belum Diisi]"
        Me.teNamaLama.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNamaLama.Properties.ReadOnly = True
        Me.teNamaLama.Size = New System.Drawing.Size(218, 20)
        Me.teNamaLama.TabIndex = 19
        Me.teNamaLama.Tag = "namapasien"
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Controls.Add(Me.lblKaryawan)
        Me.pHeader.Controls.Add(Me.teSearchLama)
        Me.pHeader.Controls.Add(Me.btnSearchLama)
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.ForeColor = System.Drawing.Color.White
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(686, 30)
        Me.pHeader.TabIndex = 4
        '
        'lblKaryawan
        '
        Me.lblKaryawan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblKaryawan.AutoSize = True
        Me.lblKaryawan.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKaryawan.Location = New System.Drawing.Point(314, 8)
        Me.lblKaryawan.Name = "lblKaryawan"
        Me.lblKaryawan.Size = New System.Drawing.Size(75, 14)
        Me.lblKaryawan.TabIndex = 20
        Me.lblKaryawan.Text = "Nama Pasien"
        Me.lblKaryawan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teSearchLama
        '
        Me.teSearchLama.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.teSearchLama.Location = New System.Drawing.Point(392, 5)
        Me.teSearchLama.Margin = New System.Windows.Forms.Padding(0)
        Me.teSearchLama.Name = "teSearchLama"
        Me.teSearchLama.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teSearchLama.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teSearchLama.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teSearchLama.Properties.Appearance.Options.UseBackColor = True
        Me.teSearchLama.Properties.Appearance.Options.UseFont = True
        Me.teSearchLama.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teSearchLama.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teSearchLama.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teSearchLama.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teSearchLama.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teSearchLama.Properties.MaxLength = 300
        Me.teSearchLama.Properties.NullText = "[Belum Diisi]"
        Me.teSearchLama.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teSearchLama.Size = New System.Drawing.Size(150, 20)
        Me.teSearchLama.TabIndex = 19
        Me.teSearchLama.Tag = ""
        '
        'btnSearchLama
        '
        Me.btnSearchLama.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSearchLama.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSearchLama.FlatAppearance.BorderSize = 0
        Me.btnSearchLama.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnSearchLama.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnSearchLama.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchLama.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchLama.Location = New System.Drawing.Point(626, 0)
        Me.btnSearchLama.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSearchLama.Name = "btnSearchLama"
        Me.btnSearchLama.Size = New System.Drawing.Size(60, 30)
        Me.btnSearchLama.TabIndex = 5
        Me.btnSearchLama.Text = "CARI"
        Me.btnSearchLama.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchLama.UseVisualStyleBackColor = False
        '
        'frmPasienSwapData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(690, 308)
        Me.ControlBox = False
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPasienSwapData"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Swap Data Pasien"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        Me.pBody.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.teNoRMbaru.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNamaBaru.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.teSearchBaru.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.tlpField.ResumeLayout(False)
        Me.tlpField.PerformLayout()
        CType(Me.teNoRMlama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNamaLama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        Me.pHeader.PerformLayout()
        CType(Me.teSearchLama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents pHeader As System.Windows.Forms.Panel
    Public WithEvents pBody As System.Windows.Forms.Panel
    Public WithEvents tlpField As System.Windows.Forms.TableLayoutPanel
    Public WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Label1 As Label
    Friend WithEvents teNoRMlama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As Label
    Friend WithEvents teNamaLama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pExit As PictureBox
    Public WithEvents btnSearchLama As Button
    Friend WithEvents pMinimize As PictureBox
    Friend WithEvents pMaximize As PictureBox
    Public WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblStatus As Label
    Public WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents teNoRMbaru As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents teNamaBaru As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Public WithEvents Panel1 As Panel
    Public WithEvents btnSearchBaru As Button
    Public WithEvents btnSave As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents teSearchBaru As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblKaryawan As Label
    Friend WithEvents teSearchLama As DevExpress.XtraEditors.TextEdit
    Public WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label8 As Label
End Class
