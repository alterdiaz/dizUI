<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewProduct
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
        Me.pExist = New System.Windows.Forms.Panel()
        Me.btnExistCheck = New System.Windows.Forms.Button()
        Me.teProductPIN = New DevExpress.XtraEditors.TextEdit()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.tlpPengguna = New System.Windows.Forms.TableLayoutPanel()
        Me.teNamaProdukResmi = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lueProdukType = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.teNamaProduk = New DevExpress.XtraEditors.TextEdit()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.teRemarksProduk = New DevExpress.XtraEditors.TextEdit()
        Me.teKodeProduk = New DevExpress.XtraEditors.TextEdit()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.pbSync = New System.Windows.Forms.PictureBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.pTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.tlpForm.SuspendLayout()
        Me.pBody.SuspendLayout()
        Me.tlpEntry.SuspendLayout()
        Me.pExist.SuspendLayout()
        CType(Me.teProductPIN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpPengguna.SuspendLayout()
        CType(Me.teNamaProdukResmi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueProdukType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNamaProduk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teRemarksProduk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teKodeProduk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeader.SuspendLayout()
        CType(Me.pbSync, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pTitle.SuspendLayout()
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
        Me.tlpForm.Size = New System.Drawing.Size(460, 330)
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
        Me.pBody.Size = New System.Drawing.Size(456, 298)
        Me.pBody.TabIndex = 7
        '
        'tlpEntry
        '
        Me.tlpEntry.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.tlpEntry.ColumnCount = 3
        Me.tlpEntry.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpEntry.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400.0!))
        Me.tlpEntry.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpEntry.Controls.Add(Me.pExist, 1, 1)
        Me.tlpEntry.Controls.Add(Me.lblInfo, 1, 4)
        Me.tlpEntry.Controls.Add(Me.tlpPengguna, 1, 3)
        Me.tlpEntry.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpEntry.Location = New System.Drawing.Point(0, 30)
        Me.tlpEntry.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEntry.Name = "tlpEntry"
        Me.tlpEntry.RowCount = 6
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpEntry.Size = New System.Drawing.Size(456, 268)
        Me.tlpEntry.TabIndex = 112
        '
        'pExist
        '
        Me.pExist.Controls.Add(Me.btnExistCheck)
        Me.pExist.Controls.Add(Me.teProductPIN)
        Me.pExist.Controls.Add(Me.Label16)
        Me.pExist.Controls.Add(Me.Label9)
        Me.pExist.Location = New System.Drawing.Point(28, 2)
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
        Me.btnExistCheck.Location = New System.Drawing.Point(170, 49)
        Me.btnExistCheck.Name = "btnExistCheck"
        Me.btnExistCheck.Size = New System.Drawing.Size(100, 26)
        Me.btnExistCheck.TabIndex = 4
        Me.btnExistCheck.Text = "CHECK"
        Me.btnExistCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExistCheck.UseVisualStyleBackColor = False
        '
        'teProductPIN
        '
        Me.teProductPIN.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teProductPIN.Location = New System.Drawing.Point(170, 25)
        Me.teProductPIN.Margin = New System.Windows.Forms.Padding(0)
        Me.teProductPIN.Name = "teProductPIN"
        Me.teProductPIN.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teProductPIN.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teProductPIN.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teProductPIN.Properties.Appearance.Options.UseBackColor = True
        Me.teProductPIN.Properties.Appearance.Options.UseFont = True
        Me.teProductPIN.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teProductPIN.Properties.MaxLength = 50
        Me.teProductPIN.Properties.NullText = "[Kosong]"
        Me.teProductPIN.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teProductPIN.Properties.Tag = "namalengkap"
        Me.teProductPIN.Properties.UseSystemPasswordChar = True
        Me.teProductPIN.Size = New System.Drawing.Size(187, 20)
        Me.teProductPIN.TabIndex = 3
        Me.teProductPIN.Tag = ""
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(90, 28)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 14)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Kode Produk"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(5, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(164, 14)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Sudah pernah entry produk?"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblInfo
        '
        Me.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.Black
        Me.lblInfo.Location = New System.Drawing.Point(184, 232)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(87, 14)
        Me.lblInfo.TabIndex = 18
        Me.lblInfo.Text = "Nama Lengkap"
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblInfo.Visible = False
        '
        'tlpPengguna
        '
        Me.tlpPengguna.AutoSize = True
        Me.tlpPengguna.ColumnCount = 4
        Me.tlpPengguna.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPengguna.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.tlpPengguna.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220.0!))
        Me.tlpPengguna.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPengguna.Controls.Add(Me.teNamaProdukResmi, 2, 3)
        Me.tlpPengguna.Controls.Add(Me.Label6, 1, 0)
        Me.tlpPengguna.Controls.Add(Me.lueProdukType, 2, 0)
        Me.tlpPengguna.Controls.Add(Me.Label4, 1, 3)
        Me.tlpPengguna.Controls.Add(Me.teNamaProduk, 2, 2)
        Me.tlpPengguna.Controls.Add(Me.lblNama, 1, 4)
        Me.tlpPengguna.Controls.Add(Me.Label1, 1, 1)
        Me.tlpPengguna.Controls.Add(Me.Label2, 1, 2)
        Me.tlpPengguna.Controls.Add(Me.teRemarksProduk, 2, 4)
        Me.tlpPengguna.Controls.Add(Me.teKodeProduk, 2, 1)
        Me.tlpPengguna.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPengguna.Location = New System.Drawing.Point(28, 90)
        Me.tlpPengguna.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpPengguna.Name = "tlpPengguna"
        Me.tlpPengguna.RowCount = 5
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpPengguna.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpPengguna.Size = New System.Drawing.Size(400, 120)
        Me.tlpPengguna.TabIndex = 114
        '
        'teNamaProdukResmi
        '
        Me.teNamaProdukResmi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNamaProdukResmi.Location = New System.Drawing.Point(170, 74)
        Me.teNamaProdukResmi.Margin = New System.Windows.Forms.Padding(0)
        Me.teNamaProdukResmi.Name = "teNamaProdukResmi"
        Me.teNamaProdukResmi.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teNamaProdukResmi.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNamaProdukResmi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNamaProdukResmi.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teNamaProdukResmi.Properties.Appearance.Options.UseBackColor = True
        Me.teNamaProdukResmi.Properties.Appearance.Options.UseFont = True
        Me.teNamaProdukResmi.Properties.Appearance.Options.UseForeColor = True
        Me.teNamaProdukResmi.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNamaProdukResmi.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNamaProdukResmi.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teNamaProdukResmi.Properties.AppearanceDisabled.Options.UseFont = True
        Me.teNamaProdukResmi.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNamaProdukResmi.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNamaProdukResmi.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teNamaProdukResmi.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.teNamaProdukResmi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNamaProdukResmi.Properties.MaxLength = 300
        Me.teNamaProdukResmi.Properties.NullText = "[Kosong]"
        Me.teNamaProdukResmi.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNamaProdukResmi.Properties.Tag = "namalengkap"
        Me.teNamaProdukResmi.Size = New System.Drawing.Size(218, 20)
        Me.teNamaProdukResmi.TabIndex = 29
        Me.teNamaProdukResmi.Tag = ""
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(92, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 14)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Jenis Produk"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueProdukType
        '
        Me.lueProdukType.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueProdukType.Location = New System.Drawing.Point(170, 2)
        Me.lueProdukType.Margin = New System.Windows.Forms.Padding(0)
        Me.lueProdukType.Name = "lueProdukType"
        Me.lueProdukType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueProdukType.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueProdukType.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lueProdukType.Properties.Appearance.Options.UseBackColor = True
        Me.lueProdukType.Properties.Appearance.Options.UseFont = True
        Me.lueProdukType.Properties.Appearance.Options.UseForeColor = True
        Me.lueProdukType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueProdukType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueProdukType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("remarks", "Remarks")})
        Me.lueProdukType.Properties.NullText = "[Isian belum dipilih]"
        Me.lueProdukType.Size = New System.Drawing.Size(218, 20)
        Me.lueProdukType.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(53, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 14)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Nama Resmi Produk"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teNamaProduk
        '
        Me.teNamaProduk.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teNamaProduk.Location = New System.Drawing.Point(170, 50)
        Me.teNamaProduk.Margin = New System.Windows.Forms.Padding(0)
        Me.teNamaProduk.Name = "teNamaProduk"
        Me.teNamaProduk.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teNamaProduk.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNamaProduk.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNamaProduk.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teNamaProduk.Properties.Appearance.Options.UseBackColor = True
        Me.teNamaProduk.Properties.Appearance.Options.UseFont = True
        Me.teNamaProduk.Properties.Appearance.Options.UseForeColor = True
        Me.teNamaProduk.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNamaProduk.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNamaProduk.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teNamaProduk.Properties.AppearanceDisabled.Options.UseFont = True
        Me.teNamaProduk.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teNamaProduk.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teNamaProduk.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teNamaProduk.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.teNamaProduk.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teNamaProduk.Properties.MaxLength = 300
        Me.teNamaProduk.Properties.NullText = "[Kosong]"
        Me.teNamaProduk.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teNamaProduk.Properties.Tag = "namalengkap"
        Me.teNamaProduk.Size = New System.Drawing.Size(218, 20)
        Me.teNamaProduk.TabIndex = 6
        Me.teNamaProduk.Tag = ""
        '
        'lblNama
        '
        Me.lblNama.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.Location = New System.Drawing.Point(97, 101)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(70, 14)
        Me.lblNama.TabIndex = 3
        Me.lblNama.Text = "Keterangan"
        Me.lblNama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 14)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Kode Produk"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(88, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 14)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Nama Produk"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teRemarksProduk
        '
        Me.teRemarksProduk.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teRemarksProduk.Location = New System.Drawing.Point(170, 98)
        Me.teRemarksProduk.Margin = New System.Windows.Forms.Padding(0)
        Me.teRemarksProduk.Name = "teRemarksProduk"
        Me.teRemarksProduk.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teRemarksProduk.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teRemarksProduk.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teRemarksProduk.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teRemarksProduk.Properties.Appearance.Options.UseBackColor = True
        Me.teRemarksProduk.Properties.Appearance.Options.UseFont = True
        Me.teRemarksProduk.Properties.Appearance.Options.UseForeColor = True
        Me.teRemarksProduk.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teRemarksProduk.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teRemarksProduk.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teRemarksProduk.Properties.AppearanceDisabled.Options.UseFont = True
        Me.teRemarksProduk.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teRemarksProduk.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teRemarksProduk.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teRemarksProduk.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.teRemarksProduk.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teRemarksProduk.Properties.MaxLength = 2000
        Me.teRemarksProduk.Properties.NullText = "[Kosong]"
        Me.teRemarksProduk.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teRemarksProduk.Properties.Tag = "namalengkap"
        Me.teRemarksProduk.Size = New System.Drawing.Size(218, 20)
        Me.teRemarksProduk.TabIndex = 5
        '
        'teKodeProduk
        '
        Me.teKodeProduk.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teKodeProduk.Location = New System.Drawing.Point(170, 26)
        Me.teKodeProduk.Margin = New System.Windows.Forms.Padding(0)
        Me.teKodeProduk.Name = "teKodeProduk"
        Me.teKodeProduk.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teKodeProduk.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teKodeProduk.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teKodeProduk.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.teKodeProduk.Properties.Appearance.Options.UseBackColor = True
        Me.teKodeProduk.Properties.Appearance.Options.UseFont = True
        Me.teKodeProduk.Properties.Appearance.Options.UseForeColor = True
        Me.teKodeProduk.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teKodeProduk.Properties.MaxLength = 500
        Me.teKodeProduk.Properties.NullText = "[Kosong]"
        Me.teKodeProduk.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teKodeProduk.Properties.ReadOnly = True
        Me.teKodeProduk.Properties.Tag = "namalengkap"
        Me.teKodeProduk.Size = New System.Drawing.Size(218, 20)
        Me.teKodeProduk.TabIndex = 7
        Me.teKodeProduk.Tag = ""
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
        Me.pbSync.Image = Global.dizUIlite.My.Resources.Resources.loading
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
        Me.lblTitle.Text = "Produk Baru"
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
        'frmNewProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.ClientSize = New System.Drawing.Size(460, 330)
        Me.ControlBox = False
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmNewProduct"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produk Baru"
        Me.tlpForm.ResumeLayout(False)
        Me.pBody.ResumeLayout(False)
        Me.tlpEntry.ResumeLayout(False)
        Me.tlpEntry.PerformLayout()
        Me.pExist.ResumeLayout(False)
        Me.pExist.PerformLayout()
        CType(Me.teProductPIN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpPengguna.ResumeLayout(False)
        Me.tlpPengguna.PerformLayout()
        CType(Me.teNamaProdukResmi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueProdukType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNamaProduk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teRemarksProduk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teKodeProduk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        CType(Me.pbSync, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pTitle.ResumeLayout(False)
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pBody As System.Windows.Forms.Panel
    Friend WithEvents pHeader As System.Windows.Forms.Panel
    Public WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents teRemarksProduk As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tlpPengguna As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpEntry As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents teNamaProduk As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lueProdukType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Friend WithEvents teKodeProduk As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pbSync As System.Windows.Forms.PictureBox
    Friend WithEvents teNamaProdukResmi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pExist As System.Windows.Forms.Panel
    Public WithEvents btnExistCheck As System.Windows.Forms.Button
    Friend WithEvents teProductPIN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
