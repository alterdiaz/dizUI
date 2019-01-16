<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDizSplash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDizSplash))
        Me.pbSync = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pbSync, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbSync
        '
        Me.pbSync.BackColor = System.Drawing.Color.Transparent
        Me.pbSync.Image = Global.dizUI.My.Resources.Resources.loading2
        Me.pbSync.Location = New System.Drawing.Point(6, 126)
        Me.pbSync.Margin = New System.Windows.Forms.Padding(0)
        Me.pbSync.Name = "pbSync"
        Me.pbSync.Size = New System.Drawing.Size(30, 30)
        Me.pbSync.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbSync.TabIndex = 30
        Me.pbSync.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'frmDizSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.dizUI.My.Resources.Resources.canvas_splash
        Me.ClientSize = New System.Drawing.Size(464, 162)
        Me.ControlBox = False
        Me.Controls.Add(Me.pbSync)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDizSplash"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Diznet Indo Zahira 2015"
        CType(Me.pbSync, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbSync As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
