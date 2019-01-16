<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoading
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
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pbSync = New System.Windows.Forms.PictureBox()
        Me.lblContent = New System.Windows.Forms.Label()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pbSync, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.AutoSize = True
        Me.tableLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro
        Me.tableLayoutPanel1.ColumnCount = 3
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.Panel1, 1, 1)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 3
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(250, 77)
        Me.tableLayoutPanel1.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblContent)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Controls.Add(Me.pbSync)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(4, 4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(242, 69)
        Me.Panel1.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(79, 19)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(112, 19)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Sedang Proses"
        '
        'pbSync
        '
        Me.pbSync.BackColor = System.Drawing.Color.Transparent
        Me.pbSync.Location = New System.Drawing.Point(43, 19)
        Me.pbSync.Name = "pbSync"
        Me.pbSync.Size = New System.Drawing.Size(30, 30)
        Me.pbSync.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbSync.TabIndex = 30
        Me.pbSync.TabStop = False
        '
        'lblContent
        '
        Me.lblContent.AutoSize = True
        Me.lblContent.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.lblContent.ForeColor = System.Drawing.Color.White
        Me.lblContent.Location = New System.Drawing.Point(80, 38)
        Me.lblContent.Name = "lblContent"
        Me.lblContent.Size = New System.Drawing.Size(92, 13)
        Me.lblContent.TabIndex = 31
        Me.lblContent.Text = "Mohon Menunggu"
        '
        'frmLoading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(250, 77)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.MinimumSize = New System.Drawing.Size(246, 0)
        Me.Name = "frmLoading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Loading"
        Me.TopMost = True
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbSync, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblContent As System.Windows.Forms.Label
    Friend WithEvents pbSync As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
End Class
