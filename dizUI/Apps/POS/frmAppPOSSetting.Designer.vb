<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAppPOSSetting
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
        Me.lueOngkosKirim = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lueJualK = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSuperUser = New System.Windows.Forms.Label()
        Me.lblUserData = New System.Windows.Forms.Label()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.lueBankKas = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueSystem = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lueBeliCashD = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueBeliCashK = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueBeliKreditD = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueBeliKreditK = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueJualD = New DevExpress.XtraEditors.LookUpEdit()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.tlpForm.SuspendLayout()
        Me.pBody.SuspendLayout()
        Me.tlpTop.SuspendLayout()
        CType(Me.lueOngkosKirim.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueJualK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueBankKas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueSystem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueBeliCashD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueBeliCashK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueBeliKreditD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueBeliKreditK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueJualD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTop.Controls.Add(Me.lueOngkosKirim, 2, 9)
        Me.tlpTop.Controls.Add(Me.Label6, 1, 9)
        Me.tlpTop.Controls.Add(Me.lueJualK, 2, 8)
        Me.tlpTop.Controls.Add(Me.Label5, 1, 8)
        Me.tlpTop.Controls.Add(Me.lblSuperUser, 1, 3)
        Me.tlpTop.Controls.Add(Me.lblUserData, 1, 2)
        Me.tlpTop.Controls.Add(Me.lblLevel, 1, 1)
        Me.tlpTop.Controls.Add(Me.lueBankKas, 2, 1)
        Me.tlpTop.Controls.Add(Me.lueSystem, 2, 2)
        Me.tlpTop.Controls.Add(Me.Label1, 1, 4)
        Me.tlpTop.Controls.Add(Me.Label2, 1, 5)
        Me.tlpTop.Controls.Add(Me.Label3, 1, 6)
        Me.tlpTop.Controls.Add(Me.Label4, 1, 7)
        Me.tlpTop.Controls.Add(Me.lueBeliCashD, 2, 3)
        Me.tlpTop.Controls.Add(Me.lueBeliCashK, 2, 4)
        Me.tlpTop.Controls.Add(Me.lueBeliKreditD, 2, 5)
        Me.tlpTop.Controls.Add(Me.lueBeliKreditK, 2, 6)
        Me.tlpTop.Controls.Add(Me.lueJualD, 2, 7)
        Me.tlpTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTop.Location = New System.Drawing.Point(0, 30)
        Me.tlpTop.Name = "tlpTop"
        Me.tlpTop.RowCount = 11
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
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
        'lueOngkosKirim
        '
        Me.lueOngkosKirim.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueOngkosKirim.Location = New System.Drawing.Point(181, 201)
        Me.lueOngkosKirim.Margin = New System.Windows.Forms.Padding(0)
        Me.lueOngkosKirim.Name = "lueOngkosKirim"
        Me.lueOngkosKirim.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueOngkosKirim.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueOngkosKirim.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueOngkosKirim.Properties.Appearance.Options.UseBackColor = True
        Me.lueOngkosKirim.Properties.Appearance.Options.UseFont = True
        Me.lueOngkosKirim.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueOngkosKirim.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueOngkosKirim.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueOngkosKirim.Properties.NullText = "[Isian belum dipilih]"
        Me.lueOngkosKirim.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueOngkosKirim.Size = New System.Drawing.Size(291, 20)
        Me.lueOngkosKirim.TabIndex = 59
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(101, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 14)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Ongkos Kirim"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueJualK
        '
        Me.lueJualK.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueJualK.Location = New System.Drawing.Point(181, 177)
        Me.lueJualK.Margin = New System.Windows.Forms.Padding(0)
        Me.lueJualK.Name = "lueJualK"
        Me.lueJualK.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueJualK.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueJualK.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueJualK.Properties.Appearance.Options.UseBackColor = True
        Me.lueJualK.Properties.Appearance.Options.UseFont = True
        Me.lueJualK.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueJualK.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueJualK.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueJualK.Properties.NullText = "[Isian belum dipilih]"
        Me.lueJualK.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueJualK.Size = New System.Drawing.Size(291, 20)
        Me.lueJualK.TabIndex = 58
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(73, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 14)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Penjualan (Kredit)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSuperUser
        '
        Me.lblSuperUser.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblSuperUser.AutoSize = True
        Me.lblSuperUser.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuperUser.Location = New System.Drawing.Point(39, 60)
        Me.lblSuperUser.Name = "lblSuperUser"
        Me.lblSuperUser.Size = New System.Drawing.Size(139, 14)
        Me.lblSuperUser.TabIndex = 32
        Me.lblSuperUser.Text = "Pembelian Cash (Debet)"
        Me.lblSuperUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUserData
        '
        Me.lblUserData.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblUserData.AutoSize = True
        Me.lblUserData.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserData.Location = New System.Drawing.Point(75, 36)
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
        Me.lblLevel.Location = New System.Drawing.Point(123, 12)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(55, 14)
        Me.lblLevel.TabIndex = 32
        Me.lblLevel.Text = "Bank Kas"
        Me.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueBankKas
        '
        Me.lueBankKas.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueBankKas.Location = New System.Drawing.Point(181, 9)
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
        Me.lueSystem.Location = New System.Drawing.Point(181, 33)
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
        Me.Label1.Location = New System.Drawing.Point(41, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 14)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Pembelian Cash (Kredit)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 14)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Pembelian Kredit (Debet)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 14)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Pembelian Kredit (Kredit)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(71, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 14)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Penjualan (Debet)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueBeliCashD
        '
        Me.lueBeliCashD.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueBeliCashD.Location = New System.Drawing.Point(181, 57)
        Me.lueBeliCashD.Margin = New System.Windows.Forms.Padding(0)
        Me.lueBeliCashD.Name = "lueBeliCashD"
        Me.lueBeliCashD.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueBeliCashD.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueBeliCashD.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueBeliCashD.Properties.Appearance.Options.UseBackColor = True
        Me.lueBeliCashD.Properties.Appearance.Options.UseFont = True
        Me.lueBeliCashD.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueBeliCashD.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueBeliCashD.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueBeliCashD.Properties.NullText = "[Isian belum dipilih]"
        Me.lueBeliCashD.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueBeliCashD.Size = New System.Drawing.Size(291, 20)
        Me.lueBeliCashD.TabIndex = 53
        '
        'lueBeliCashK
        '
        Me.lueBeliCashK.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueBeliCashK.Location = New System.Drawing.Point(181, 81)
        Me.lueBeliCashK.Margin = New System.Windows.Forms.Padding(0)
        Me.lueBeliCashK.Name = "lueBeliCashK"
        Me.lueBeliCashK.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueBeliCashK.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueBeliCashK.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueBeliCashK.Properties.Appearance.Options.UseBackColor = True
        Me.lueBeliCashK.Properties.Appearance.Options.UseFont = True
        Me.lueBeliCashK.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueBeliCashK.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueBeliCashK.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueBeliCashK.Properties.NullText = "[Isian belum dipilih]"
        Me.lueBeliCashK.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueBeliCashK.Size = New System.Drawing.Size(291, 20)
        Me.lueBeliCashK.TabIndex = 54
        '
        'lueBeliKreditD
        '
        Me.lueBeliKreditD.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueBeliKreditD.Location = New System.Drawing.Point(181, 105)
        Me.lueBeliKreditD.Margin = New System.Windows.Forms.Padding(0)
        Me.lueBeliKreditD.Name = "lueBeliKreditD"
        Me.lueBeliKreditD.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueBeliKreditD.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueBeliKreditD.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueBeliKreditD.Properties.Appearance.Options.UseBackColor = True
        Me.lueBeliKreditD.Properties.Appearance.Options.UseFont = True
        Me.lueBeliKreditD.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueBeliKreditD.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueBeliKreditD.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueBeliKreditD.Properties.NullText = "[Isian belum dipilih]"
        Me.lueBeliKreditD.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueBeliKreditD.Size = New System.Drawing.Size(291, 20)
        Me.lueBeliKreditD.TabIndex = 55
        '
        'lueBeliKreditK
        '
        Me.lueBeliKreditK.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueBeliKreditK.Location = New System.Drawing.Point(181, 129)
        Me.lueBeliKreditK.Margin = New System.Windows.Forms.Padding(0)
        Me.lueBeliKreditK.Name = "lueBeliKreditK"
        Me.lueBeliKreditK.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueBeliKreditK.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueBeliKreditK.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueBeliKreditK.Properties.Appearance.Options.UseBackColor = True
        Me.lueBeliKreditK.Properties.Appearance.Options.UseFont = True
        Me.lueBeliKreditK.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueBeliKreditK.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueBeliKreditK.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueBeliKreditK.Properties.NullText = "[Isian belum dipilih]"
        Me.lueBeliKreditK.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueBeliKreditK.Size = New System.Drawing.Size(291, 20)
        Me.lueBeliKreditK.TabIndex = 56
        '
        'lueJualD
        '
        Me.lueJualD.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueJualD.Location = New System.Drawing.Point(181, 153)
        Me.lueJualD.Margin = New System.Windows.Forms.Padding(0)
        Me.lueJualD.Name = "lueJualD"
        Me.lueJualD.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueJualD.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueJualD.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueJualD.Properties.Appearance.Options.UseBackColor = True
        Me.lueJualD.Properties.Appearance.Options.UseFont = True
        Me.lueJualD.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueJualD.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueJualD.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueJualD.Properties.NullText = "[Isian belum dipilih]"
        Me.lueJualD.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueJualD.Size = New System.Drawing.Size(291, 20)
        Me.lueJualD.TabIndex = 57
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
        Me.btnSave.Location = New System.Drawing.Point(423, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "SIMPAN"
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
        'frmAppPOSSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.ClientSize = New System.Drawing.Size(507, 293)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAppPOSSetting"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "App Setting"
        Me.tlpForm.ResumeLayout(False)
        Me.pBody.ResumeLayout(False)
        Me.tlpTop.ResumeLayout(False)
        Me.tlpTop.PerformLayout()
        CType(Me.lueOngkosKirim.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueJualK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueBankKas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueSystem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueBeliCashD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueBeliCashK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueBeliKreditD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueBeliKreditK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueJualD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lueBeliCashD As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueBeliCashK As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueBeliKreditD As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueBeliKreditK As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueJualD As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lueOngkosKirim As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lueJualK As DevExpress.XtraEditors.LookUpEdit
End Class
