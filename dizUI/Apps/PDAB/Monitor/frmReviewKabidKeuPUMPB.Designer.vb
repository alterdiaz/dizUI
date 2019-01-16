<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReviewKabidKeuPUMPB
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
        Me.tlpMengetahui = New System.Windows.Forms.TableLayoutPanel()
        Me.lblAtasan = New System.Windows.Forms.Label()
        Me.lblJabatanAtasan = New System.Windows.Forms.Label()
        Me.teJabatanAtasan = New DevExpress.XtraEditors.TextEdit()
        Me.lblKabid = New System.Windows.Forms.Label()
        Me.lblDirektur = New System.Windows.Forms.Label()
        Me.teNamaAtasan = New DevExpress.XtraEditors.TextEdit()
        Me.teNamaAdmin = New DevExpress.XtraEditors.TextEdit()
        Me.teNamaDirektur = New DevExpress.XtraEditors.TextEdit()
        Me.tlpUntuk = New System.Windows.Forms.TableLayoutPanel()
        Me.meUntuk = New DevExpress.XtraEditors.MemoEdit()
        Me.teAlasan = New DevExpress.XtraEditors.TextEdit()
        Me.ceReject = New DevExpress.XtraEditors.CheckEdit()
        Me.ceCheck = New DevExpress.XtraEditors.CheckEdit()
        Me.lblUntuk = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tlpPemohon = New System.Windows.Forms.TableLayoutPanel()
        Me.lblPemohon = New System.Windows.Forms.Label()
        Me.lblJabatanPemohon = New System.Windows.Forms.Label()
        Me.teJabatanPemohon = New DevExpress.XtraEditors.TextEdit()
        Me.teNamaPemohon = New DevExpress.XtraEditors.TextEdit()
        Me.tlpHuruf = New System.Windows.Forms.TableLayoutPanel()
        Me.teHurufUang = New DevExpress.XtraEditors.TextEdit()
        Me.lblHurufUang = New System.Windows.Forms.Label()
        Me.tlpField = New System.Windows.Forms.TableLayoutPanel()
        Me.lblJumlahUang = New System.Windows.Forms.Label()
        Me.lblPengajuanNo = New System.Windows.Forms.Label()
        Me.tePengajuanNo = New DevExpress.XtraEditors.TextEdit()
        Me.deTanggal = New DevExpress.XtraEditors.DateEdit()
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.nudJumlahUang = New DevExpress.XtraEditors.SpinEdit()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblSep5 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBody.SuspendLayout()
        Me.tlpMengetahui.SuspendLayout()
        CType(Me.teJabatanAtasan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNamaAtasan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNamaAdmin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNamaDirektur.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpUntuk.SuspendLayout()
        CType(Me.meUntuk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teAlasan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceReject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpPemohon.SuspendLayout()
        CType(Me.teJabatanPemohon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNamaPemohon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpHuruf.SuspendLayout()
        CType(Me.teHurufUang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpField.SuspendLayout()
        CType(Me.tePengajuanNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudJumlahUang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpForm
        '
        Me.tlpForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
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
        Me.tlpForm.Size = New System.Drawing.Size(790, 500)
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
        Me.lblTitle.Size = New System.Drawing.Size(696, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Review Pengajuan Uang Muka, Pembelian, Biaya (Keuangan)"
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
        Me.pBody.Controls.Add(Me.tlpMengetahui)
        Me.pBody.Controls.Add(Me.tlpUntuk)
        Me.pBody.Controls.Add(Me.tlpPemohon)
        Me.pBody.Controls.Add(Me.tlpHuruf)
        Me.pBody.Controls.Add(Me.tlpField)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(786, 470)
        Me.pBody.TabIndex = 7
        '
        'tlpMengetahui
        '
        Me.tlpMengetahui.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.tlpMengetahui.ColumnCount = 6
        Me.tlpMengetahui.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMengetahui.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.tlpMengetahui.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170.0!))
        Me.tlpMengetahui.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpMengetahui.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpMengetahui.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMengetahui.Controls.Add(Me.lblAtasan, 1, 1)
        Me.tlpMengetahui.Controls.Add(Me.lblJabatanAtasan, 3, 1)
        Me.tlpMengetahui.Controls.Add(Me.teJabatanAtasan, 4, 1)
        Me.tlpMengetahui.Controls.Add(Me.lblKabid, 1, 2)
        Me.tlpMengetahui.Controls.Add(Me.lblDirektur, 3, 2)
        Me.tlpMengetahui.Controls.Add(Me.teNamaAtasan, 2, 1)
        Me.tlpMengetahui.Controls.Add(Me.teNamaAdmin, 2, 2)
        Me.tlpMengetahui.Controls.Add(Me.teNamaDirektur, 4, 2)
        Me.tlpMengetahui.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMengetahui.Location = New System.Drawing.Point(0, 350)
        Me.tlpMengetahui.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpMengetahui.Name = "tlpMengetahui"
        Me.tlpMengetahui.RowCount = 6
        Me.tlpMengetahui.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpMengetahui.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpMengetahui.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpMengetahui.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpMengetahui.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpMengetahui.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMengetahui.Size = New System.Drawing.Size(786, 120)
        Me.tlpMengetahui.TabIndex = 11
        '
        'lblAtasan
        '
        Me.lblAtasan.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblAtasan.AutoSize = True
        Me.lblAtasan.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtasan.Location = New System.Drawing.Point(145, 10)
        Me.lblAtasan.Name = "lblAtasan"
        Me.lblAtasan.Size = New System.Drawing.Size(100, 14)
        Me.lblAtasan.TabIndex = 28
        Me.lblAtasan.Text = "Atasan Langsung"
        Me.lblAtasan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblJabatanAtasan
        '
        Me.lblJabatanAtasan.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblJabatanAtasan.AutoSize = True
        Me.lblJabatanAtasan.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJabatanAtasan.Location = New System.Drawing.Point(455, 10)
        Me.lblJabatanAtasan.Name = "lblJabatanAtasan"
        Me.lblJabatanAtasan.Size = New System.Drawing.Size(90, 14)
        Me.lblJabatanAtasan.TabIndex = 36
        Me.lblJabatanAtasan.Text = "Jabatan Atasan"
        Me.lblJabatanAtasan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teJabatanAtasan
        '
        Me.teJabatanAtasan.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teJabatanAtasan.Location = New System.Drawing.Point(548, 7)
        Me.teJabatanAtasan.Margin = New System.Windows.Forms.Padding(0)
        Me.teJabatanAtasan.Name = "teJabatanAtasan"
        Me.teJabatanAtasan.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.teJabatanAtasan.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teJabatanAtasan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teJabatanAtasan.Properties.Appearance.Options.UseBackColor = True
        Me.teJabatanAtasan.Properties.Appearance.Options.UseFont = True
        Me.teJabatanAtasan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teJabatanAtasan.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teJabatanAtasan.Properties.MaxLength = 10
        Me.teJabatanAtasan.Properties.NullText = "[Belum Diisi]"
        Me.teJabatanAtasan.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teJabatanAtasan.Properties.ReadOnly = True
        Me.teJabatanAtasan.Size = New System.Drawing.Size(150, 20)
        Me.teJabatanAtasan.TabIndex = 40
        Me.teJabatanAtasan.Tag = "jabatanreview"
        '
        'lblKabid
        '
        Me.lblKabid.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblKabid.AutoSize = True
        Me.lblKabid.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKabid.Location = New System.Drawing.Point(91, 34)
        Me.lblKabid.Name = "lblKabid"
        Me.lblKabid.Size = New System.Drawing.Size(154, 14)
        Me.lblKabid.TabIndex = 41
        Me.lblKabid.Text = "Kabid Adm/Keu dan Umum"
        Me.lblKabid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDirektur
        '
        Me.lblDirektur.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblDirektur.AutoSize = True
        Me.lblDirektur.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirektur.Location = New System.Drawing.Point(495, 34)
        Me.lblDirektur.Name = "lblDirektur"
        Me.lblDirektur.Size = New System.Drawing.Size(50, 14)
        Me.lblDirektur.TabIndex = 45
        Me.lblDirektur.Text = "Direktur"
        Me.lblDirektur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teNamaAtasan
        '
        Me.teNamaAtasan.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNamaAtasan.Location = New System.Drawing.Point(248, 7)
        Me.teNamaAtasan.Margin = New System.Windows.Forms.Padding(0)
        Me.teNamaAtasan.Name = "teNamaAtasan"
        Me.teNamaAtasan.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.teNamaAtasan.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNamaAtasan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNamaAtasan.Properties.Appearance.Options.UseBackColor = True
        Me.teNamaAtasan.Properties.Appearance.Options.UseFont = True
        Me.teNamaAtasan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNamaAtasan.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teNamaAtasan.Properties.MaxLength = 10
        Me.teNamaAtasan.Properties.NullText = "[Belum Diisi]"
        Me.teNamaAtasan.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNamaAtasan.Properties.ReadOnly = True
        Me.teNamaAtasan.Size = New System.Drawing.Size(150, 20)
        Me.teNamaAtasan.TabIndex = 47
        Me.teNamaAtasan.Tag = "namareview"
        '
        'teNamaAdmin
        '
        Me.teNamaAdmin.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNamaAdmin.Location = New System.Drawing.Point(248, 31)
        Me.teNamaAdmin.Margin = New System.Windows.Forms.Padding(0)
        Me.teNamaAdmin.Name = "teNamaAdmin"
        Me.teNamaAdmin.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.teNamaAdmin.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNamaAdmin.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNamaAdmin.Properties.Appearance.Options.UseBackColor = True
        Me.teNamaAdmin.Properties.Appearance.Options.UseFont = True
        Me.teNamaAdmin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNamaAdmin.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teNamaAdmin.Properties.MaxLength = 10
        Me.teNamaAdmin.Properties.NullText = "[Belum Diisi]"
        Me.teNamaAdmin.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNamaAdmin.Properties.ReadOnly = True
        Me.teNamaAdmin.Size = New System.Drawing.Size(150, 20)
        Me.teNamaAdmin.TabIndex = 48
        Me.teNamaAdmin.Tag = "namakabid"
        '
        'teNamaDirektur
        '
        Me.teNamaDirektur.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNamaDirektur.Location = New System.Drawing.Point(548, 31)
        Me.teNamaDirektur.Margin = New System.Windows.Forms.Padding(0)
        Me.teNamaDirektur.Name = "teNamaDirektur"
        Me.teNamaDirektur.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.teNamaDirektur.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNamaDirektur.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNamaDirektur.Properties.Appearance.Options.UseBackColor = True
        Me.teNamaDirektur.Properties.Appearance.Options.UseFont = True
        Me.teNamaDirektur.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNamaDirektur.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teNamaDirektur.Properties.MaxLength = 10
        Me.teNamaDirektur.Properties.NullText = "[Belum Diisi]"
        Me.teNamaDirektur.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNamaDirektur.Properties.ReadOnly = True
        Me.teNamaDirektur.Size = New System.Drawing.Size(150, 20)
        Me.teNamaDirektur.TabIndex = 49
        Me.teNamaDirektur.Tag = "namadirektur"
        '
        'tlpUntuk
        '
        Me.tlpUntuk.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.tlpUntuk.ColumnCount = 4
        Me.tlpUntuk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpUntuk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpUntuk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 480.0!))
        Me.tlpUntuk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpUntuk.Controls.Add(Me.meUntuk, 2, 1)
        Me.tlpUntuk.Controls.Add(Me.teAlasan, 2, 4)
        Me.tlpUntuk.Controls.Add(Me.ceReject, 2, 3)
        Me.tlpUntuk.Controls.Add(Me.ceCheck, 2, 2)
        Me.tlpUntuk.Controls.Add(Me.lblUntuk, 1, 1)
        Me.tlpUntuk.Controls.Add(Me.Label1, 1, 4)
        Me.tlpUntuk.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpUntuk.Location = New System.Drawing.Point(0, 190)
        Me.tlpUntuk.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpUntuk.Name = "tlpUntuk"
        Me.tlpUntuk.RowCount = 6
        Me.tlpUntuk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpUntuk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tlpUntuk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpUntuk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpUntuk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpUntuk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpUntuk.Size = New System.Drawing.Size(786, 160)
        Me.tlpUntuk.TabIndex = 10
        '
        'meUntuk
        '
        Me.meUntuk.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.meUntuk.Location = New System.Drawing.Point(218, 8)
        Me.meUntuk.Margin = New System.Windows.Forms.Padding(0)
        Me.meUntuk.Name = "meUntuk"
        Me.meUntuk.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.meUntuk.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.meUntuk.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.meUntuk.Properties.Appearance.Options.UseBackColor = True
        Me.meUntuk.Properties.Appearance.Options.UseFont = True
        Me.meUntuk.Properties.Appearance.Options.UseForeColor = True
        Me.meUntuk.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.meUntuk.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.meUntuk.Properties.MaxLength = 10
        Me.meUntuk.Properties.NullText = "[BELUM DIISI]"
        Me.meUntuk.Properties.NullValuePrompt = "[BELUM DIISI]"
        Me.meUntuk.Properties.NullValuePromptShowForEmptyValue = True
        Me.meUntuk.Properties.ReadOnly = True
        Me.meUntuk.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.meUntuk.Properties.WordWrap = False
        Me.meUntuk.Size = New System.Drawing.Size(480, 72)
        Me.meUntuk.TabIndex = 47
        Me.meUntuk.Tag = "keperluan"
        '
        'teAlasan
        '
        Me.teAlasan.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teAlasan.Location = New System.Drawing.Point(218, 134)
        Me.teAlasan.Margin = New System.Windows.Forms.Padding(0)
        Me.teAlasan.Name = "teAlasan"
        Me.teAlasan.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.teAlasan.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teAlasan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teAlasan.Properties.Appearance.Options.UseBackColor = True
        Me.teAlasan.Properties.Appearance.Options.UseFont = True
        Me.teAlasan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teAlasan.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teAlasan.Properties.MaxLength = 500
        Me.teAlasan.Properties.NullText = "[Belum Diisi]"
        Me.teAlasan.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teAlasan.Properties.ReadOnly = True
        Me.teAlasan.Size = New System.Drawing.Size(480, 20)
        Me.teAlasan.TabIndex = 45
        Me.teAlasan.Tag = "PengajuanNo"
        '
        'ceReject
        '
        Me.ceReject.Location = New System.Drawing.Point(221, 111)
        Me.ceReject.Name = "ceReject"
        Me.ceReject.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ceReject.Properties.Appearance.Options.UseFont = True
        Me.ceReject.Properties.AutoHeight = False
        Me.ceReject.Properties.Caption = "Saya menolak pengajuan ini."
        Me.ceReject.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.ceReject.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.ceReject.Size = New System.Drawing.Size(474, 18)
        Me.ceReject.TabIndex = 44
        '
        'ceCheck
        '
        Me.ceCheck.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ceCheck.Location = New System.Drawing.Point(221, 87)
        Me.ceCheck.Name = "ceCheck"
        Me.ceCheck.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ceCheck.Properties.Appearance.Options.UseFont = True
        Me.ceCheck.Properties.AutoHeight = False
        Me.ceCheck.Properties.Caption = "Saya telah melakukan pengecekan data dengan berkas terkait."
        Me.ceCheck.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.ceCheck.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.ceCheck.Size = New System.Drawing.Size(474, 18)
        Me.ceCheck.TabIndex = 43
        '
        'lblUntuk
        '
        Me.lblUntuk.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblUntuk.AutoSize = True
        Me.lblUntuk.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUntuk.Location = New System.Drawing.Point(175, 37)
        Me.lblUntuk.Name = "lblUntuk"
        Me.lblUntuk.Size = New System.Drawing.Size(40, 14)
        Me.lblUntuk.TabIndex = 41
        Me.lblUntuk.Text = "Untuk"
        Me.lblUntuk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(115, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 14)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Alasan Penolakan"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpPemohon
        '
        Me.tlpPemohon.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.tlpPemohon.ColumnCount = 6
        Me.tlpPemohon.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPemohon.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpPemohon.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpPemohon.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpPemohon.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpPemohon.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPemohon.Controls.Add(Me.lblPemohon, 1, 1)
        Me.tlpPemohon.Controls.Add(Me.lblJabatanPemohon, 3, 1)
        Me.tlpPemohon.Controls.Add(Me.teJabatanPemohon, 4, 1)
        Me.tlpPemohon.Controls.Add(Me.teNamaPemohon, 2, 1)
        Me.tlpPemohon.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpPemohon.Location = New System.Drawing.Point(0, 155)
        Me.tlpPemohon.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpPemohon.Name = "tlpPemohon"
        Me.tlpPemohon.RowCount = 3
        Me.tlpPemohon.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPemohon.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPemohon.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPemohon.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpPemohon.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpPemohon.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpPemohon.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpPemohon.Size = New System.Drawing.Size(786, 35)
        Me.tlpPemohon.TabIndex = 9
        '
        'lblPemohon
        '
        Me.lblPemohon.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblPemohon.AutoSize = True
        Me.lblPemohon.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPemohon.Location = New System.Drawing.Point(156, 10)
        Me.lblPemohon.Name = "lblPemohon"
        Me.lblPemohon.Size = New System.Drawing.Size(59, 14)
        Me.lblPemohon.TabIndex = 28
        Me.lblPemohon.Text = "Pemohon"
        Me.lblPemohon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblJabatanPemohon
        '
        Me.lblJabatanPemohon.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblJabatanPemohon.AutoSize = True
        Me.lblJabatanPemohon.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJabatanPemohon.Location = New System.Drawing.Point(440, 10)
        Me.lblJabatanPemohon.Name = "lblJabatanPemohon"
        Me.lblJabatanPemohon.Size = New System.Drawing.Size(105, 14)
        Me.lblJabatanPemohon.TabIndex = 36
        Me.lblJabatanPemohon.Text = "Jabatan Pemohon"
        Me.lblJabatanPemohon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teJabatanPemohon
        '
        Me.teJabatanPemohon.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teJabatanPemohon.Location = New System.Drawing.Point(548, 7)
        Me.teJabatanPemohon.Margin = New System.Windows.Forms.Padding(0)
        Me.teJabatanPemohon.Name = "teJabatanPemohon"
        Me.teJabatanPemohon.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.teJabatanPemohon.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teJabatanPemohon.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teJabatanPemohon.Properties.Appearance.Options.UseBackColor = True
        Me.teJabatanPemohon.Properties.Appearance.Options.UseFont = True
        Me.teJabatanPemohon.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teJabatanPemohon.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teJabatanPemohon.Properties.MaxLength = 10
        Me.teJabatanPemohon.Properties.NullText = "[Belum Diisi]"
        Me.teJabatanPemohon.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teJabatanPemohon.Properties.ReadOnly = True
        Me.teJabatanPemohon.Size = New System.Drawing.Size(150, 20)
        Me.teJabatanPemohon.TabIndex = 40
        Me.teJabatanPemohon.Tag = "PengajuanNo"
        '
        'teNamaPemohon
        '
        Me.teNamaPemohon.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNamaPemohon.Location = New System.Drawing.Point(218, 7)
        Me.teNamaPemohon.Margin = New System.Windows.Forms.Padding(0)
        Me.teNamaPemohon.Name = "teNamaPemohon"
        Me.teNamaPemohon.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.teNamaPemohon.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNamaPemohon.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNamaPemohon.Properties.Appearance.Options.UseBackColor = True
        Me.teNamaPemohon.Properties.Appearance.Options.UseFont = True
        Me.teNamaPemohon.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNamaPemohon.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teNamaPemohon.Properties.MaxLength = 10
        Me.teNamaPemohon.Properties.NullText = "[Belum Diisi]"
        Me.teNamaPemohon.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNamaPemohon.Properties.ReadOnly = True
        Me.teNamaPemohon.Size = New System.Drawing.Size(150, 20)
        Me.teNamaPemohon.TabIndex = 41
        Me.teNamaPemohon.Tag = "PengajuanNo"
        '
        'tlpHuruf
        '
        Me.tlpHuruf.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.tlpHuruf.ColumnCount = 4
        Me.tlpHuruf.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpHuruf.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpHuruf.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 480.0!))
        Me.tlpHuruf.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpHuruf.Controls.Add(Me.teHurufUang, 2, 1)
        Me.tlpHuruf.Controls.Add(Me.lblHurufUang, 1, 1)
        Me.tlpHuruf.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpHuruf.Location = New System.Drawing.Point(0, 94)
        Me.tlpHuruf.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpHuruf.Name = "tlpHuruf"
        Me.tlpHuruf.RowCount = 3
        Me.tlpHuruf.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpHuruf.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpHuruf.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpHuruf.Size = New System.Drawing.Size(786, 61)
        Me.tlpHuruf.TabIndex = 8
        '
        'teHurufUang
        '
        Me.teHurufUang.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teHurufUang.Location = New System.Drawing.Point(218, 9)
        Me.teHurufUang.Margin = New System.Windows.Forms.Padding(0)
        Me.teHurufUang.Name = "teHurufUang"
        Me.teHurufUang.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.teHurufUang.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teHurufUang.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teHurufUang.Properties.Appearance.Options.UseBackColor = True
        Me.teHurufUang.Properties.Appearance.Options.UseFont = True
        Me.teHurufUang.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teHurufUang.Properties.AppearanceDisabled.Options.UseFont = True
        Me.teHurufUang.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teHurufUang.Properties.AppearanceFocused.Options.UseFont = True
        Me.teHurufUang.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teHurufUang.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.teHurufUang.Properties.AutoHeight = False
        Me.teHurufUang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teHurufUang.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teHurufUang.Properties.MaxLength = 10
        Me.teHurufUang.Properties.NullText = "[Belum Diisi]"
        Me.teHurufUang.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teHurufUang.Properties.ReadOnly = True
        Me.teHurufUang.Size = New System.Drawing.Size(480, 42)
        Me.teHurufUang.TabIndex = 26
        Me.teHurufUang.Tag = "Alamat"
        '
        'lblHurufUang
        '
        Me.lblHurufUang.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblHurufUang.AutoSize = True
        Me.lblHurufUang.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHurufUang.Location = New System.Drawing.Point(132, 23)
        Me.lblHurufUang.Name = "lblHurufUang"
        Me.lblHurufUang.Size = New System.Drawing.Size(83, 14)
        Me.lblHurufUang.TabIndex = 27
        Me.lblHurufUang.Text = "Dengan Huruf"
        Me.lblHurufUang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpField
        '
        Me.tlpField.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.tlpField.ColumnCount = 6
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.Controls.Add(Me.lblJumlahUang, 1, 2)
        Me.tlpField.Controls.Add(Me.lblPengajuanNo, 1, 1)
        Me.tlpField.Controls.Add(Me.tePengajuanNo, 2, 1)
        Me.tlpField.Controls.Add(Me.deTanggal, 4, 1)
        Me.tlpField.Controls.Add(Me.lblTanggal, 3, 1)
        Me.tlpField.Controls.Add(Me.nudJumlahUang, 2, 2)
        Me.tlpField.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpField.Location = New System.Drawing.Point(0, 30)
        Me.tlpField.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpField.Name = "tlpField"
        Me.tlpField.RowCount = 4
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpField.Size = New System.Drawing.Size(786, 64)
        Me.tlpField.TabIndex = 7
        '
        'lblJumlahUang
        '
        Me.lblJumlahUang.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblJumlahUang.AutoSize = True
        Me.lblJumlahUang.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahUang.Location = New System.Drawing.Point(139, 37)
        Me.lblJumlahUang.Name = "lblJumlahUang"
        Me.lblJumlahUang.Size = New System.Drawing.Size(76, 14)
        Me.lblJumlahUang.TabIndex = 9
        Me.lblJumlahUang.Text = "Jumlah Uang"
        Me.lblJumlahUang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPengajuanNo
        '
        Me.lblPengajuanNo.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblPengajuanNo.AutoSize = True
        Me.lblPengajuanNo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPengajuanNo.Location = New System.Drawing.Point(111, 13)
        Me.lblPengajuanNo.Name = "lblPengajuanNo"
        Me.lblPengajuanNo.Size = New System.Drawing.Size(104, 14)
        Me.lblPengajuanNo.TabIndex = 22
        Me.lblPengajuanNo.Text = "Nomor Pengajuan"
        Me.lblPengajuanNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tePengajuanNo
        '
        Me.tePengajuanNo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tePengajuanNo.Location = New System.Drawing.Point(218, 10)
        Me.tePengajuanNo.Margin = New System.Windows.Forms.Padding(0)
        Me.tePengajuanNo.Name = "tePengajuanNo"
        Me.tePengajuanNo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tePengajuanNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tePengajuanNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tePengajuanNo.Properties.Appearance.Options.UseBackColor = True
        Me.tePengajuanNo.Properties.Appearance.Options.UseFont = True
        Me.tePengajuanNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tePengajuanNo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tePengajuanNo.Properties.MaxLength = 10
        Me.tePengajuanNo.Properties.NullText = "[Belum Diisi]"
        Me.tePengajuanNo.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.tePengajuanNo.Properties.ReadOnly = True
        Me.tePengajuanNo.Size = New System.Drawing.Size(150, 20)
        Me.tePengajuanNo.TabIndex = 25
        Me.tePengajuanNo.Tag = ""
        '
        'deTanggal
        '
        Me.deTanggal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.deTanggal.EditValue = Nothing
        Me.deTanggal.Location = New System.Drawing.Point(548, 10)
        Me.deTanggal.Margin = New System.Windows.Forms.Padding(0)
        Me.deTanggal.Name = "deTanggal"
        Me.deTanggal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deTanggal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.Appearance.Options.UseBackColor = True
        Me.deTanggal.Properties.Appearance.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceDisabled.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceDropDown.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceDropDownHeaderHighlight.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceDropDownHeaderHighlight.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceDropDownHighlight.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceDropDownHighlight.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceFocused.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceWeekNumber.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceWeekNumber.Options.UseFont = True
        Me.deTanggal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.deTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.deTanggal.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.deTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTanggal.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.deTanggal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTanggal.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.deTanggal.Properties.ReadOnly = True
        Me.deTanggal.Size = New System.Drawing.Size(135, 20)
        Me.deTanggal.TabIndex = 31
        '
        'lblTanggal
        '
        Me.lblTanggal.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTanggal.AutoSize = True
        Me.lblTanggal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTanggal.Location = New System.Drawing.Point(434, 13)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(111, 14)
        Me.lblTanggal.TabIndex = 29
        Me.lblTanggal.Text = "Tanggal Pengajuan"
        Me.lblTanggal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudJumlahUang
        '
        Me.nudJumlahUang.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.nudJumlahUang.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.nudJumlahUang.Location = New System.Drawing.Point(218, 34)
        Me.nudJumlahUang.Margin = New System.Windows.Forms.Padding(0)
        Me.nudJumlahUang.Name = "nudJumlahUang"
        Me.nudJumlahUang.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.nudJumlahUang.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.nudJumlahUang.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.nudJumlahUang.Properties.Appearance.Options.UseBackColor = True
        Me.nudJumlahUang.Properties.Appearance.Options.UseFont = True
        Me.nudJumlahUang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.nudJumlahUang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.nudJumlahUang.Properties.DisplayFormat.FormatString = "n2"
        Me.nudJumlahUang.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.nudJumlahUang.Properties.EditFormat.FormatString = "n2"
        Me.nudJumlahUang.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.nudJumlahUang.Properties.MaxLength = 10
        Me.nudJumlahUang.Properties.MaxValue = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.nudJumlahUang.Properties.ReadOnly = True
        Me.nudJumlahUang.Size = New System.Drawing.Size(150, 20)
        Me.nudJumlahUang.TabIndex = 39
        Me.nudJumlahUang.Tag = "hdasar"
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Controls.Add(Me.btnSearch)
        Me.pHeader.Controls.Add(Me.btnSave)
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.ForeColor = System.Drawing.Color.White
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(786, 30)
        Me.pHeader.TabIndex = 4
        '
        'btnSearch
        '
        Me.btnSearch.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(626, 0)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(80, 30)
        Me.btnSearch.TabIndex = 17
        Me.btnSearch.Text = "CARI"
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearch.UseVisualStyleBackColor = True
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
        Me.btnSave.Location = New System.Drawing.Point(706, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "SIMPAN"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
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
        Me.btnPrint.Location = New System.Drawing.Point(-26, 0)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(100, 1)
        Me.btnPrint.TabIndex = 0
        Me.btnPrint.Text = "PRINT"
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'frmReviewKabidKeuPUMPB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.ClientSize = New System.Drawing.Size(790, 500)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReviewKabidKeuPUMPB"
        Me.ShowInTaskbar = False
        Me.Text = "Review Pengajuan Uang Muka, Pembelian, Biaya (Keuangan)"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        Me.tlpMengetahui.ResumeLayout(False)
        Me.tlpMengetahui.PerformLayout()
        CType(Me.teJabatanAtasan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNamaAtasan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNamaAdmin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNamaDirektur.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpUntuk.ResumeLayout(False)
        Me.tlpUntuk.PerformLayout()
        CType(Me.meUntuk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teAlasan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceReject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpPemohon.ResumeLayout(False)
        Me.tlpPemohon.PerformLayout()
        CType(Me.teJabatanPemohon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNamaPemohon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpHuruf.ResumeLayout(False)
        Me.tlpHuruf.PerformLayout()
        CType(Me.teHurufUang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpField.ResumeLayout(False)
        Me.tlpField.PerformLayout()
        CType(Me.tePengajuanNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudJumlahUang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents lblSep5 As System.Windows.Forms.Label
    Public WithEvents pHeader As System.Windows.Forms.Panel
    Public WithEvents btnSearch As System.Windows.Forms.Button
    Public WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents pBody As System.Windows.Forms.Panel
    Public WithEvents tlpField As System.Windows.Forms.TableLayoutPanel
    Public WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblJumlahUang As System.Windows.Forms.Label
    Friend WithEvents lblPengajuanNo As System.Windows.Forms.Label
    Friend WithEvents tePengajuanNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teHurufUang As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblHurufUang As System.Windows.Forms.Label
    Friend WithEvents lblPemohon As System.Windows.Forms.Label
    Friend WithEvents lblTanggal As System.Windows.Forms.Label
    Friend WithEvents deTanggal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents nudJumlahUang As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lblUntuk As System.Windows.Forms.Label
    Public WithEvents tlpMengetahui As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblJabatanAtasan As System.Windows.Forms.Label
    Friend WithEvents teJabatanAtasan As DevExpress.XtraEditors.TextEdit
    Public WithEvents tlpUntuk As System.Windows.Forms.TableLayoutPanel
    Public WithEvents tlpPemohon As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblJabatanPemohon As System.Windows.Forms.Label
    Friend WithEvents teJabatanPemohon As DevExpress.XtraEditors.TextEdit
    Public WithEvents tlpHuruf As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblAtasan As System.Windows.Forms.Label
    Friend WithEvents lblKabid As System.Windows.Forms.Label
    Friend WithEvents lblDirektur As System.Windows.Forms.Label
    Friend WithEvents teNamaAtasan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teNamaAdmin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teNamaPemohon As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teNamaDirektur As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ceCheck As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ceReject As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents teAlasan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Friend WithEvents meUntuk As DevExpress.XtraEditors.MemoEdit
End Class
