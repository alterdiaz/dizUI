<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewPayment
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
        Me.tePaymentNo = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tePaket = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.luePaket = New DevExpress.XtraEditors.LookUpEdit()
        Me.teHardwareCode = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.teNama = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.deTanggal = New DevExpress.XtraEditors.DateEdit()
        Me.meRemarks = New DevExpress.XtraEditors.MemoEdit()
        Me.teNamaProduk = New DevExpress.XtraEditors.TextEdit()
        Me.lueRekening = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblHint = New System.Windows.Forms.Label()
        Me.lblHandphone = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.teNamaPerusahaan = New DevExpress.XtraEditors.TextEdit()
        Me.teNorek = New DevExpress.XtraEditors.TextEdit()
        Me.teBank = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.pExist = New System.Windows.Forms.Panel()
        Me.btnExistCheck = New System.Windows.Forms.Button()
        Me.teVoucher = New DevExpress.XtraEditors.TextEdit()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnCheckQuota = New System.Windows.Forms.Button()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.pTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pbSync = New System.Windows.Forms.PictureBox()
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.tlpForm.SuspendLayout()
        Me.pBody.SuspendLayout()
        Me.tlpEntry.SuspendLayout()
        Me.tlpPengguna.SuspendLayout()
        CType(Me.tePaymentNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tePaket.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePaket.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teHardwareCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.meRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNamaProduk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueRekening.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNamaPerusahaan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNorek.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teBank.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pExist.SuspendLayout()
        CType(Me.teVoucher.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeader.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pbSync, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 322.0!))
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpEntry.Size = New System.Drawing.Size(456, 470)
        Me.tlpEntry.TabIndex = 112
        '
        'lblInfo
        '
        Me.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.Black
        Me.lblInfo.Location = New System.Drawing.Point(184, 429)
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
        Me.tlpPengguna.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.tlpPengguna.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220.0!))
        Me.tlpPengguna.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPengguna.Controls.Add(Me.tePaymentNo, 2, 1)
        Me.tlpPengguna.Controls.Add(Me.Label6, 1, 1)
        Me.tlpPengguna.Controls.Add(Me.tePaket, 2, 8)
        Me.tlpPengguna.Controls.Add(Me.Label5, 1, 8)
        Me.tlpPengguna.Controls.Add(Me.luePaket, 2, 7)
        Me.tlpPengguna.Controls.Add(Me.teHardwareCode, 2, 4)
        Me.tlpPengguna.Controls.Add(Me.Label4, 1, 4)
        Me.tlpPengguna.Controls.Add(Me.teNama, 2, 11)
        Me.tlpPengguna.Controls.Add(Me.Label3, 1, 11)
        Me.tlpPengguna.Controls.Add(Me.deTanggal, 2, 6)
        Me.tlpPengguna.Controls.Add(Me.meRemarks, 2, 12)
        Me.tlpPengguna.Controls.Add(Me.teNamaProduk, 2, 3)
        Me.tlpPengguna.Controls.Add(Me.lueRekening, 2, 5)
        Me.tlpPengguna.Controls.Add(Me.lblAnswer, 1, 12)
        Me.tlpPengguna.Controls.Add(Me.lblNama, 1, 5)
        Me.tlpPengguna.Controls.Add(Me.lblHint, 1, 9)
        Me.tlpPengguna.Controls.Add(Me.lblHandphone, 1, 7)
        Me.tlpPengguna.Controls.Add(Me.lblEmail, 1, 6)
        Me.tlpPengguna.Controls.Add(Me.teNamaPerusahaan, 2, 2)
        Me.tlpPengguna.Controls.Add(Me.teNorek, 2, 10)
        Me.tlpPengguna.Controls.Add(Me.teBank, 2, 9)
        Me.tlpPengguna.Controls.Add(Me.Label1, 1, 2)
        Me.tlpPengguna.Controls.Add(Me.Label2, 1, 3)
        Me.tlpPengguna.Controls.Add(Me.lblQuestion, 1, 10)
        Me.tlpPengguna.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPengguna.Location = New System.Drawing.Point(28, 85)
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
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPengguna.Size = New System.Drawing.Size(400, 322)
        Me.tlpPengguna.TabIndex = 114
        '
        'tePaymentNo
        '
        Me.tePaymentNo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tePaymentNo.Location = New System.Drawing.Point(170, 7)
        Me.tePaymentNo.Margin = New System.Windows.Forms.Padding(0)
        Me.tePaymentNo.Name = "tePaymentNo"
        Me.tePaymentNo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.tePaymentNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tePaymentNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tePaymentNo.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.tePaymentNo.Properties.Appearance.Options.UseBackColor = True
        Me.tePaymentNo.Properties.Appearance.Options.UseFont = True
        Me.tePaymentNo.Properties.Appearance.Options.UseForeColor = True
        Me.tePaymentNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tePaymentNo.Properties.MaxLength = 20
        Me.tePaymentNo.Properties.NullText = "[Kosong]"
        Me.tePaymentNo.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.tePaymentNo.Properties.ReadOnly = True
        Me.tePaymentNo.Properties.Tag = "namalengkap"
        Me.tePaymentNo.Size = New System.Drawing.Size(135, 20)
        Me.tePaymentNo.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(75, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 14)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "No Pembayaran"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tePaket
        '
        Me.tePaket.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tePaket.Location = New System.Drawing.Point(170, 175)
        Me.tePaket.Margin = New System.Windows.Forms.Padding(0)
        Me.tePaket.Name = "tePaket"
        Me.tePaket.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.tePaket.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tePaket.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tePaket.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.tePaket.Properties.Appearance.Options.UseBackColor = True
        Me.tePaket.Properties.Appearance.Options.UseFont = True
        Me.tePaket.Properties.Appearance.Options.UseForeColor = True
        Me.tePaket.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tePaket.Properties.MaxLength = 300
        Me.tePaket.Properties.NullText = "[Kosong]"
        Me.tePaket.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.tePaket.Properties.ReadOnly = True
        Me.tePaket.Properties.Tag = "namalengkap"
        Me.tePaket.Size = New System.Drawing.Size(187, 20)
        Me.tePaket.TabIndex = 11
        Me.tePaket.Tag = ""
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(99, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 14)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Kuota Data"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'luePaket
        '
        Me.luePaket.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.luePaket.Location = New System.Drawing.Point(170, 151)
        Me.luePaket.Margin = New System.Windows.Forms.Padding(0)
        Me.luePaket.Name = "luePaket"
        Me.luePaket.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.luePaket.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.luePaket.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.luePaket.Properties.Appearance.Options.UseBackColor = True
        Me.luePaket.Properties.Appearance.Options.UseFont = True
        Me.luePaket.Properties.Appearance.Options.UseForeColor = True
        Me.luePaket.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.luePaket.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePaket.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.luePaket.Properties.NullText = "[Isian belum dipilih]"
        Me.luePaket.Size = New System.Drawing.Size(187, 20)
        Me.luePaket.TabIndex = 10
        '
        'teHardwareCode
        '
        Me.teHardwareCode.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teHardwareCode.Location = New System.Drawing.Point(170, 79)
        Me.teHardwareCode.Margin = New System.Windows.Forms.Padding(0)
        Me.teHardwareCode.Name = "teHardwareCode"
        Me.teHardwareCode.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teHardwareCode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teHardwareCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teHardwareCode.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teHardwareCode.Properties.Appearance.Options.UseBackColor = True
        Me.teHardwareCode.Properties.Appearance.Options.UseFont = True
        Me.teHardwareCode.Properties.Appearance.Options.UseForeColor = True
        Me.teHardwareCode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teHardwareCode.Properties.MaxLength = 300
        Me.teHardwareCode.Properties.NullText = "[Kosong]"
        Me.teHardwareCode.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teHardwareCode.Properties.ReadOnly = True
        Me.teHardwareCode.Properties.Tag = "namalengkap"
        Me.teHardwareCode.Size = New System.Drawing.Size(218, 20)
        Me.teHardwareCode.TabIndex = 7
        Me.teHardwareCode.Tag = ""
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(76, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 14)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Kode Hardware"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teNama
        '
        Me.teNama.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNama.Location = New System.Drawing.Point(170, 247)
        Me.teNama.Margin = New System.Windows.Forms.Padding(0)
        Me.teNama.Name = "teNama"
        Me.teNama.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teNama.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNama.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNama.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teNama.Properties.Appearance.Options.UseBackColor = True
        Me.teNama.Properties.Appearance.Options.UseFont = True
        Me.teNama.Properties.Appearance.Options.UseForeColor = True
        Me.teNama.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNama.Properties.MaxLength = 300
        Me.teNama.Properties.NullText = "[Kosong]"
        Me.teNama.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNama.Properties.Tag = "recoveryquestion"
        Me.teNama.Size = New System.Drawing.Size(218, 20)
        Me.teNama.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 14)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Nama Rekening Pengirim"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'deTanggal
        '
        Me.deTanggal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.deTanggal.EditValue = Nothing
        Me.deTanggal.Location = New System.Drawing.Point(170, 127)
        Me.deTanggal.Margin = New System.Windows.Forms.Padding(0)
        Me.deTanggal.Name = "deTanggal"
        Me.deTanggal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deTanggal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.deTanggal.Properties.Appearance.Options.UseBackColor = True
        Me.deTanggal.Properties.Appearance.Options.UseFont = True
        Me.deTanggal.Properties.Appearance.Options.UseForeColor = True
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
        Me.deTanggal.Size = New System.Drawing.Size(135, 20)
        Me.deTanggal.TabIndex = 9
        '
        'meRemarks
        '
        Me.meRemarks.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.meRemarks.Location = New System.Drawing.Point(170, 269)
        Me.meRemarks.Margin = New System.Windows.Forms.Padding(0)
        Me.meRemarks.Name = "meRemarks"
        Me.meRemarks.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.meRemarks.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.meRemarks.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.meRemarks.Properties.Appearance.Options.UseBackColor = True
        Me.meRemarks.Properties.Appearance.Options.UseFont = True
        Me.meRemarks.Properties.Appearance.Options.UseForeColor = True
        Me.meRemarks.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.meRemarks.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.meRemarks.Properties.MaxLength = 500
        Me.meRemarks.Properties.NullText = "[BELUM DIISI]"
        Me.meRemarks.Properties.NullValuePrompt = "[BELUM DIISI]"
        Me.meRemarks.Properties.NullValuePromptShowForEmptyValue = True
        Me.meRemarks.Properties.WordWrap = False
        Me.meRemarks.Size = New System.Drawing.Size(218, 48)
        Me.meRemarks.TabIndex = 15
        Me.meRemarks.Tag = ""
        '
        'teNamaProduk
        '
        Me.teNamaProduk.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNamaProduk.Location = New System.Drawing.Point(170, 55)
        Me.teNamaProduk.Margin = New System.Windows.Forms.Padding(0)
        Me.teNamaProduk.Name = "teNamaProduk"
        Me.teNamaProduk.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teNamaProduk.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNamaProduk.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNamaProduk.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teNamaProduk.Properties.Appearance.Options.UseBackColor = True
        Me.teNamaProduk.Properties.Appearance.Options.UseFont = True
        Me.teNamaProduk.Properties.Appearance.Options.UseForeColor = True
        Me.teNamaProduk.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNamaProduk.Properties.MaxLength = 300
        Me.teNamaProduk.Properties.NullText = "[Kosong]"
        Me.teNamaProduk.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNamaProduk.Properties.ReadOnly = True
        Me.teNamaProduk.Properties.Tag = "namalengkap"
        Me.teNamaProduk.Size = New System.Drawing.Size(218, 20)
        Me.teNamaProduk.TabIndex = 6
        Me.teNamaProduk.Tag = ""
        '
        'lueRekening
        '
        Me.lueRekening.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueRekening.Location = New System.Drawing.Point(170, 103)
        Me.lueRekening.Margin = New System.Windows.Forms.Padding(0)
        Me.lueRekening.Name = "lueRekening"
        Me.lueRekening.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueRekening.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueRekening.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lueRekening.Properties.Appearance.Options.UseBackColor = True
        Me.lueRekening.Properties.Appearance.Options.UseFont = True
        Me.lueRekening.Properties.Appearance.Options.UseForeColor = True
        Me.lueRekening.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueRekening.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueRekening.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.lueRekening.Properties.NullText = "[Isian belum dipilih]"
        Me.lueRekening.Size = New System.Drawing.Size(218, 20)
        Me.lueRekening.TabIndex = 8
        '
        'lblAnswer
        '
        Me.lblAnswer.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(118, 286)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(49, 14)
        Me.lblAnswer.TabIndex = 8
        Me.lblAnswer.Text = "Catatan"
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNama
        '
        Me.lblNama.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.Location = New System.Drawing.Point(68, 106)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(99, 14)
        Me.lblNama.TabIndex = 3
        Me.lblNama.Text = "Rekening Tujuan"
        Me.lblNama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHint
        '
        Me.lblHint.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblHint.AutoSize = True
        Me.lblHint.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHint.Location = New System.Drawing.Point(50, 202)
        Me.lblHint.Name = "lblHint"
        Me.lblHint.Size = New System.Drawing.Size(117, 14)
        Me.lblHint.TabIndex = 6
        Me.lblHint.Text = "Nama Bank Pengirim"
        Me.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHandphone
        '
        Me.lblHandphone.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblHandphone.AutoSize = True
        Me.lblHandphone.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHandphone.Location = New System.Drawing.Point(100, 154)
        Me.lblHandphone.Name = "lblHandphone"
        Me.lblHandphone.Size = New System.Drawing.Size(67, 14)
        Me.lblHandphone.TabIndex = 5
        Me.lblHandphone.Text = "Paket Data"
        Me.lblHandphone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEmail
        '
        Me.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(47, 130)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(120, 14)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "Tanggal Pembayaran"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teNamaPerusahaan
        '
        Me.teNamaPerusahaan.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNamaPerusahaan.Location = New System.Drawing.Point(170, 31)
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
        Me.teNamaPerusahaan.Properties.MaxLength = 500
        Me.teNamaPerusahaan.Properties.NullText = "[Kosong]"
        Me.teNamaPerusahaan.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNamaPerusahaan.Properties.ReadOnly = True
        Me.teNamaPerusahaan.Properties.Tag = "namalengkap"
        Me.teNamaPerusahaan.Size = New System.Drawing.Size(218, 20)
        Me.teNamaPerusahaan.TabIndex = 5
        '
        'teNorek
        '
        Me.teNorek.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNorek.Location = New System.Drawing.Point(170, 223)
        Me.teNorek.Margin = New System.Windows.Forms.Padding(0)
        Me.teNorek.Name = "teNorek"
        Me.teNorek.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teNorek.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNorek.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNorek.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teNorek.Properties.Appearance.Options.UseBackColor = True
        Me.teNorek.Properties.Appearance.Options.UseFont = True
        Me.teNorek.Properties.Appearance.Options.UseForeColor = True
        Me.teNorek.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNorek.Properties.MaxLength = 50
        Me.teNorek.Properties.NullText = "[Kosong]"
        Me.teNorek.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNorek.Properties.Tag = "recoveryquestion"
        Me.teNorek.Size = New System.Drawing.Size(218, 20)
        Me.teNorek.TabIndex = 13
        '
        'teBank
        '
        Me.teBank.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teBank.Location = New System.Drawing.Point(170, 199)
        Me.teBank.Margin = New System.Windows.Forms.Padding(0)
        Me.teBank.Name = "teBank"
        Me.teBank.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teBank.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teBank.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teBank.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teBank.Properties.Appearance.Options.UseBackColor = True
        Me.teBank.Properties.Appearance.Options.UseFont = True
        Me.teBank.Properties.Appearance.Options.UseForeColor = True
        Me.teBank.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teBank.Properties.MaxLength = 200
        Me.teBank.Properties.NullText = "[Kosong]"
        Me.teBank.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teBank.Properties.Tag = "hint"
        Me.teBank.Size = New System.Drawing.Size(187, 20)
        Me.teBank.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 14)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Nama Perusahaan"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(88, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 14)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Nama Produk"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblQuestion
        '
        Me.lblQuestion.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(20, 226)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(147, 14)
        Me.lblQuestion.TabIndex = 7
        Me.lblQuestion.Text = "Nomor Rekening Pengirim"
        Me.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pExist
        '
        Me.pExist.Controls.Add(Me.btnExistCheck)
        Me.pExist.Controls.Add(Me.teVoucher)
        Me.pExist.Controls.Add(Me.Label15)
        Me.pExist.Controls.Add(Me.Label9)
        Me.pExist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pExist.Location = New System.Drawing.Point(28, 5)
        Me.pExist.Margin = New System.Windows.Forms.Padding(0)
        Me.pExist.Name = "pExist"
        Me.pExist.Size = New System.Drawing.Size(400, 80)
        Me.pExist.TabIndex = 113
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
        Me.btnExistCheck.Location = New System.Drawing.Point(170, 48)
        Me.btnExistCheck.Name = "btnExistCheck"
        Me.btnExistCheck.Size = New System.Drawing.Size(100, 26)
        Me.btnExistCheck.TabIndex = 3
        Me.btnExistCheck.Text = "CEK VOUCHER"
        Me.btnExistCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExistCheck.UseVisualStyleBackColor = False
        '
        'teVoucher
        '
        Me.teVoucher.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teVoucher.Location = New System.Drawing.Point(96, 25)
        Me.teVoucher.Margin = New System.Windows.Forms.Padding(0)
        Me.teVoucher.Name = "teVoucher"
        Me.teVoucher.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teVoucher.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teVoucher.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teVoucher.Properties.Appearance.Options.UseBackColor = True
        Me.teVoucher.Properties.Appearance.Options.UseFont = True
        Me.teVoucher.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teVoucher.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teVoucher.Properties.MaxLength = 50
        Me.teVoucher.Properties.NullText = "[Kosong]"
        Me.teVoucher.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teVoucher.Properties.Tag = "namalengkap"
        Me.teVoucher.Size = New System.Drawing.Size(292, 20)
        Me.teVoucher.TabIndex = 2
        Me.teVoucher.Tag = "companynickname"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 28)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 14)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Voucher Code"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(241, 14)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Jika memiliki kode voucher yang masih aktif"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Controls.Add(Me.btnCheckQuota)
        Me.pHeader.Controls.Add(Me.pbSync)
        Me.pHeader.Controls.Add(Me.btnHistory)
        Me.pHeader.Controls.Add(Me.btnSave)
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.ForeColor = System.Drawing.Color.White
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(456, 30)
        Me.pHeader.TabIndex = 111
        '
        'btnCheckQuota
        '
        Me.btnCheckQuota.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnCheckQuota.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCheckQuota.FlatAppearance.BorderSize = 0
        Me.btnCheckQuota.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnCheckQuota.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnCheckQuota.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckQuota.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckQuota.ForeColor = System.Drawing.Color.Black
        Me.btnCheckQuota.Location = New System.Drawing.Point(136, 0)
        Me.btnCheckQuota.Name = "btnCheckQuota"
        Me.btnCheckQuota.Size = New System.Drawing.Size(120, 30)
        Me.btnCheckQuota.TabIndex = 29
        Me.btnCheckQuota.Text = "CEK KUOTA"
        Me.btnCheckQuota.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCheckQuota.UseVisualStyleBackColor = False
        '
        'btnHistory
        '
        Me.btnHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnHistory.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnHistory.FlatAppearance.BorderSize = 0
        Me.btnHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistory.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistory.ForeColor = System.Drawing.Color.Black
        Me.btnHistory.Location = New System.Drawing.Point(256, 0)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(100, 30)
        Me.btnHistory.TabIndex = 16
        Me.btnHistory.Text = "HISTORY"
        Me.btnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHistory.UseVisualStyleBackColor = False
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
        Me.lblTitle.Text = "Konfirm Pembayaran"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'frmNewPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.ClientSize = New System.Drawing.Size(460, 532)
        Me.ControlBox = False
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmNewPayment"
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
        CType(Me.tePaymentNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tePaket.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePaket.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teHardwareCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.meRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNamaProduk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueRekening.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNamaPerusahaan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNorek.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teBank.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pExist.ResumeLayout(False)
        Me.pExist.PerformLayout()
        CType(Me.teVoucher.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pbSync, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents teNamaPerusahaan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teBank As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teNorek As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tlpPengguna As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpEntry As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents teNamaProduk As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lueRekening As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Friend WithEvents pExist As System.Windows.Forms.Panel
    Public WithEvents btnExistCheck As System.Windows.Forms.Button
    Friend WithEvents teVoucher As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents meRemarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents deTanggal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents teNama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents btnHistory As System.Windows.Forms.Button
    Friend WithEvents teHardwareCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents luePaket As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents tePaket As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tePaymentNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pbSync As System.Windows.Forms.PictureBox
    Public WithEvents btnCheckQuota As System.Windows.Forms.Button
End Class
