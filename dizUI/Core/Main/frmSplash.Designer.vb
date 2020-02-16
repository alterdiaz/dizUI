<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
    Inherits DevExpress.XtraSplashScreen.SplashScreen

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplash))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pbSync = New System.Windows.Forms.PictureBox()
        Me.lnkTG = New System.Windows.Forms.LinkLabel()
        CType(Me.pbSync, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'pbSync
        '
        Me.pbSync.BackColor = System.Drawing.Color.Transparent
        Me.pbSync.Image = Global.dizUI.My.Resources.Resources.loading2
        Me.pbSync.Location = New System.Drawing.Point(428, 126)
        Me.pbSync.Margin = New System.Windows.Forms.Padding(4)
        Me.pbSync.Name = "pbSync"
        Me.pbSync.Size = New System.Drawing.Size(30, 30)
        Me.pbSync.TabIndex = 29
        Me.pbSync.TabStop = False
        '
        'lnkTG
        '
        Me.lnkTG.AutoSize = True
        Me.lnkTG.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.lnkTG.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkTG.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lnkTG.LinkColor = System.Drawing.Color.Purple
        Me.lnkTG.Location = New System.Drawing.Point(273, 7)
        Me.lnkTG.Margin = New System.Windows.Forms.Padding(2)
        Me.lnkTG.Name = "lnkTG"
        Me.lnkTG.Size = New System.Drawing.Size(184, 15)
        Me.lnkTG.TabIndex = 30
        Me.lnkTG.TabStop = True
        Me.lnkTG.Text = "https://t.me/datacube_enterprise"
        '
        'frmSplash
        '
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(620, 300)
        Me.Controls.Add(Me.lnkTG)
        Me.Controls.Add(Me.pbSync)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSplash"
        Me.ShowIcon = False
        Me.ShowMode = DevExpress.XtraSplashScreen.ShowMode.Image
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.SplashImage = Global.dizUI.My.Resources.Resources.canvas_splash4
        Me.Text = "Diznet Indo Zahira 2015"
        Me.TopMost = True
        CType(Me.pbSync, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrClose As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pbSync As System.Windows.Forms.PictureBox
    Friend WithEvents lnkTG As LinkLabel
End Class
