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
        Me.pbSync.Image = Global.dizUIlite.My.Resources.Resources.loading2
        Me.pbSync.Location = New System.Drawing.Point(2, 126)
        Me.pbSync.Margin = New System.Windows.Forms.Padding(4)
        Me.pbSync.Name = "pbSync"
        Me.pbSync.Size = New System.Drawing.Size(30, 30)
        Me.pbSync.TabIndex = 29
        Me.pbSync.TabStop = False
        '
        'frmSplash
        '
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(464, 162)
        Me.Controls.Add(Me.pbSync)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSplash"
        Me.ShowIcon = False
        Me.ShowMode = DevExpress.XtraSplashScreen.ShowMode.Image
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.SplashImage = Global.dizUIlite.My.Resources.Resources.canvas_splash
        Me.Text = "Diznet Indo Zahira 2015"
        Me.TopMost = True
        CType(Me.pbSync, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrClose As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pbSync As System.Windows.Forms.PictureBox
End Class
