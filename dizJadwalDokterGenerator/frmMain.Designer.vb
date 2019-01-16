<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tmrMain = New System.Windows.Forms.Timer(Me.components)
        Me.niMain = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cmsNotifyIcon = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.rtsmRestore = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.rtsmKeluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsMain = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mtsmMinimize = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mtsmKeluar = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsNotifyIcon.SuspendLayout()
        Me.cmsMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.dizJadwalDokterGenerator.My.Resources.Resources.hourglass
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'tmrMain
        '
        Me.tmrMain.Enabled = True
        Me.tmrMain.Interval = 1000
        '
        'niMain
        '
        Me.niMain.ContextMenuStrip = Me.cmsNotifyIcon
        Me.niMain.Icon = CType(resources.GetObject("niMain.Icon"), System.Drawing.Icon)
        Me.niMain.Text = "Jadwal Dokter Generator"
        Me.niMain.Visible = True
        '
        'cmsNotifyIcon
        '
        Me.cmsNotifyIcon.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.rtsmRestore, Me.ToolStripSeparator2, Me.rtsmKeluar})
        Me.cmsNotifyIcon.Name = "cmsNotifyIcon"
        Me.cmsNotifyIcon.Size = New System.Drawing.Size(114, 54)
        '
        'rtsmRestore
        '
        Me.rtsmRestore.Name = "rtsmRestore"
        Me.rtsmRestore.Size = New System.Drawing.Size(113, 22)
        Me.rtsmRestore.Text = "Restore"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(110, 6)
        '
        'rtsmKeluar
        '
        Me.rtsmKeluar.Name = "rtsmKeluar"
        Me.rtsmKeluar.Size = New System.Drawing.Size(113, 22)
        Me.rtsmKeluar.Text = "Keluar"
        '
        'cmsMain
        '
        Me.cmsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mtsmMinimize, Me.ToolStripSeparator1, Me.mtsmKeluar})
        Me.cmsMain.Name = "cmsMain"
        Me.cmsMain.Size = New System.Drawing.Size(124, 54)
        '
        'mtsmMinimize
        '
        Me.mtsmMinimize.Name = "mtsmMinimize"
        Me.mtsmMinimize.Size = New System.Drawing.Size(123, 22)
        Me.mtsmMinimize.Text = "Minimize"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(120, 6)
        '
        'mtsmKeluar
        '
        Me.mtsmKeluar.Name = "mtsmKeluar"
        Me.mtsmKeluar.Size = New System.Drawing.Size(123, 22)
        Me.mtsmKeluar.Text = "Keluar"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.dizJadwalDokterGenerator.My.Resources.Resources.SingleLogoDiznet250
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(48, 48)
        Me.ContextMenuStrip = Me.cmsMain
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Jadwal Dokter Generator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsNotifyIcon.ResumeLayout(False)
        Me.cmsMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrMain As System.Windows.Forms.Timer
    Friend WithEvents niMain As System.Windows.Forms.NotifyIcon
    Friend WithEvents cmsMain As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mtsmMinimize As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mtsmKeluar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsNotifyIcon As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents rtsmRestore As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents rtsmKeluar As System.Windows.Forms.ToolStripMenuItem

End Class
