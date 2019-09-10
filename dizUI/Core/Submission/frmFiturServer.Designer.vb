<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFiturServer
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
        Me.components = New System.ComponentModel.Container()
        Me.tlpForm = New System.Windows.Forms.TableLayoutPanel()
        Me.pBody = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnChangeHardware = New System.Windows.Forms.Button()
        Me.lblQuota = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.btnComputerList = New System.Windows.Forms.Button()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.tmrWaktu = New System.Windows.Forms.Timer(Me.components)
        Me.btnProduk = New System.Windows.Forms.Button()
        Me.tlpForm.SuspendLayout()
        Me.pBody.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.pHeader.SuspendLayout()
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
        Me.tlpForm.Controls.Add(Me.pHeader, 1, 0)
        Me.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpForm.Location = New System.Drawing.Point(0, 0)
        Me.tlpForm.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpForm.Name = "tlpForm"
        Me.tlpForm.RowCount = 3
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.Size = New System.Drawing.Size(720, 540)
        Me.tlpForm.TabIndex = 8
        '
        'pBody
        '
        Me.pBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pBody.BackgroundImage = Global.dizUI.My.Resources.Resources.tiles01
        Me.pBody.Controls.Add(Me.btnProduk)
        Me.pBody.Controls.Add(Me.PictureBox1)
        Me.pBody.Controls.Add(Me.btnChangeHardware)
        Me.pBody.Controls.Add(Me.lblQuota)
        Me.pBody.Controls.Add(Me.Label2)
        Me.pBody.Controls.Add(Me.btnPayment)
        Me.pBody.Controls.Add(Me.Label1)
        Me.pBody.Controls.Add(Me.PanelControl1)
        Me.pBody.Controls.Add(Me.btnComputerList)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(716, 508)
        Me.pBody.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.dizUI.My.Resources.Resources.Sidebar02
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(317, 508)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 116
        Me.PictureBox1.TabStop = False
        '
        'btnChangeHardware
        '
        Me.btnChangeHardware.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChangeHardware.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnChangeHardware.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnChangeHardware.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.btnChangeHardware.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnChangeHardware.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnChangeHardware.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangeHardware.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnChangeHardware.ForeColor = System.Drawing.Color.White
        Me.btnChangeHardware.Location = New System.Drawing.Point(468, 150)
        Me.btnChangeHardware.Margin = New System.Windows.Forms.Padding(4)
        Me.btnChangeHardware.Name = "btnChangeHardware"
        Me.btnChangeHardware.Padding = New System.Windows.Forms.Padding(8)
        Me.btnChangeHardware.Size = New System.Drawing.Size(210, 40)
        Me.btnChangeHardware.TabIndex = 14
        Me.btnChangeHardware.Tag = ""
        Me.btnChangeHardware.Text = "Update Data Hardware"
        Me.btnChangeHardware.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChangeHardware.UseVisualStyleBackColor = False
        '
        'lblQuota
        '
        Me.lblQuota.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblQuota.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuota.ForeColor = System.Drawing.Color.White
        Me.lblQuota.Location = New System.Drawing.Point(0, 0)
        Me.lblQuota.Name = "lblQuota"
        Me.lblQuota.Padding = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQuota.Size = New System.Drawing.Size(260, 24)
        Me.lblQuota.TabIndex = 13
        Me.lblQuota.Text = "Kuota Tersisa : 0"
        Me.lblQuota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblQuota.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(353, 410)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(363, 46)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Entry data pembayaran membutuhkan koneksi internet" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Kami tidak mengambil data pri" &
    "badi apapun dari komputer anda" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Data yang telah anda entry, bersifat rahasia"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Visible = False
        '
        'btnPayment
        '
        Me.btnPayment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPayment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnPayment.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.btnPayment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPayment.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnPayment.ForeColor = System.Drawing.Color.White
        Me.btnPayment.Location = New System.Drawing.Point(468, 12)
        Me.btnPayment.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Padding = New System.Windows.Forms.Padding(8)
        Me.btnPayment.Size = New System.Drawing.Size(210, 54)
        Me.btnPayment.TabIndex = 7
        Me.btnPayment.Tag = ""
        Me.btnPayment.Text = "Konfirmasi Pembayaran" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Entry Kode Voucher"
        Me.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPayment.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(551, 469)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 0, 8, 0)
        Me.Label1.Size = New System.Drawing.Size(165, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Diznet Indo Zahira 2016"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.PanelControl1.Controls.Add(Me.lblNama)
        Me.PanelControl1.Location = New System.Drawing.Point(402, 318)
        Me.PanelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Padding = New System.Windows.Forms.Padding(8)
        Me.PanelControl1.Size = New System.Drawing.Size(245, 67)
        Me.PanelControl1.TabIndex = 5
        Me.PanelControl1.Visible = False
        '
        'lblNama
        '
        Me.lblNama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNama.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.ForeColor = System.Drawing.Color.White
        Me.lblNama.Location = New System.Drawing.Point(11, 11)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(223, 45)
        Me.lblNama.TabIndex = 4
        Me.lblNama.Text = "Pastikan kuota data anda mencukupi untuk melakukan operasional aplikasi ini."
        Me.lblNama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnComputerList
        '
        Me.btnComputerList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnComputerList.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnComputerList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnComputerList.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.btnComputerList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnComputerList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnComputerList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComputerList.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnComputerList.ForeColor = System.Drawing.Color.White
        Me.btnComputerList.Location = New System.Drawing.Point(468, 88)
        Me.btnComputerList.Margin = New System.Windows.Forms.Padding(4)
        Me.btnComputerList.Name = "btnComputerList"
        Me.btnComputerList.Padding = New System.Windows.Forms.Padding(8)
        Me.btnComputerList.Size = New System.Drawing.Size(210, 40)
        Me.btnComputerList.TabIndex = 12
        Me.btnComputerList.Tag = ""
        Me.btnComputerList.Text = "Daftar Komputer Klien"
        Me.btnComputerList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnComputerList.UseVisualStyleBackColor = False
        '
        'pHeader
        '
        Me.pHeader.Controls.Add(Me.lblTitle)
        Me.pHeader.Controls.Add(Me.pExit)
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pHeader.Location = New System.Drawing.Point(2, 0)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(716, 30)
        Me.pHeader.TabIndex = 8
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
        Me.lblTitle.Size = New System.Drawing.Size(686, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Manajemen Data"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pExit
        '
        Me.pExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.pExit.Image = Global.dizUI.My.Resources.Resources.exit_w
        Me.pExit.Location = New System.Drawing.Point(686, 0)
        Me.pExit.Margin = New System.Windows.Forms.Padding(0)
        Me.pExit.Name = "pExit"
        Me.pExit.Size = New System.Drawing.Size(30, 30)
        Me.pExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pExit.TabIndex = 10
        Me.pExit.TabStop = False
        '
        'tmrWaktu
        '
        Me.tmrWaktu.Interval = 1000
        '
        'btnProduk
        '
        Me.btnProduk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProduk.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnProduk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnProduk.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.btnProduk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnProduk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProduk.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnProduk.ForeColor = System.Drawing.Color.White
        Me.btnProduk.Location = New System.Drawing.Point(468, 212)
        Me.btnProduk.Margin = New System.Windows.Forms.Padding(4)
        Me.btnProduk.Name = "btnProduk"
        Me.btnProduk.Padding = New System.Windows.Forms.Padding(8)
        Me.btnProduk.Size = New System.Drawing.Size(210, 40)
        Me.btnProduk.TabIndex = 117
        Me.btnProduk.Tag = ""
        Me.btnProduk.Text = "Jenis Produk"
        Me.btnProduk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProduk.UseVisualStyleBackColor = False
        '
        'frmFiturServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(720, 540)
        Me.ControlBox = False
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFiturServer"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manajemen Data"
        Me.tlpForm.ResumeLayout(False)
        Me.pBody.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.pHeader.ResumeLayout(False)
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pBody As System.Windows.Forms.Panel
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnPayment As System.Windows.Forms.Button
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Friend WithEvents pHeader As System.Windows.Forms.Panel
    Friend WithEvents btnComputerList As System.Windows.Forms.Button
    Friend WithEvents lblQuota As System.Windows.Forms.Label
    Friend WithEvents tmrWaktu As System.Windows.Forms.Timer
    Friend WithEvents btnChangeHardware As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnProduk As Button
End Class
