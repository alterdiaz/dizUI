<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPerformance
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
        Me.tlpEntry = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lblDownload = New System.Windows.Forms.Label()
        Me.lblUpload = New System.Windows.Forms.Label()
        Me.lblHostname = New System.Windows.Forms.Label()
        Me.lblServer = New System.Windows.Forms.Label()
        Me.lblRuntime = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.lblConnection = New System.Windows.Forms.Label()
        Me.pTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tlpForm.SuspendLayout()
        Me.pBody.SuspendLayout()
        Me.tlpEntry.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tlpForm.Margin = New System.Windows.Forms.Padding(4, 0, 4, 4)
        Me.tlpForm.Name = "tlpForm"
        Me.tlpForm.RowCount = 3
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.Size = New System.Drawing.Size(392, 295)
        Me.tlpForm.TabIndex = 1
        '
        'pBody
        '
        Me.pBody.BackColor = System.Drawing.Color.Transparent
        Me.pBody.Controls.Add(Me.tlpEntry)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(388, 263)
        Me.pBody.TabIndex = 7
        '
        'tlpEntry
        '
        Me.tlpEntry.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.tlpEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.tlpEntry.ColumnCount = 4
        Me.tlpEntry.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpEntry.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.tlpEntry.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.tlpEntry.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpEntry.Controls.Add(Me.PictureBox1, 1, 1)
        Me.tlpEntry.Controls.Add(Me.PictureBox2, 1, 2)
        Me.tlpEntry.Controls.Add(Me.PictureBox3, 1, 3)
        Me.tlpEntry.Controls.Add(Me.PictureBox4, 1, 4)
        Me.tlpEntry.Controls.Add(Me.PictureBox5, 1, 5)
        Me.tlpEntry.Controls.Add(Me.lblDownload, 2, 1)
        Me.tlpEntry.Controls.Add(Me.lblUpload, 2, 2)
        Me.tlpEntry.Controls.Add(Me.lblHostname, 2, 3)
        Me.tlpEntry.Controls.Add(Me.lblServer, 2, 4)
        Me.tlpEntry.Controls.Add(Me.lblRuntime, 2, 5)
        Me.tlpEntry.Controls.Add(Me.PictureBox6, 1, 6)
        Me.tlpEntry.Controls.Add(Me.lblConnection, 2, 6)
        Me.tlpEntry.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpEntry.Location = New System.Drawing.Point(0, 0)
        Me.tlpEntry.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEntry.Name = "tlpEntry"
        Me.tlpEntry.RowCount = 8
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpEntry.Size = New System.Drawing.Size(388, 263)
        Me.tlpEntry.TabIndex = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.dizUI.My.Resources.Resources.download
        Me.PictureBox1.Location = New System.Drawing.Point(28, 35)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.dizUI.My.Resources.Resources.upload
        Me.PictureBox2.Location = New System.Drawing.Point(28, 67)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.dizUI.My.Resources.Resources.client
        Me.PictureBox3.Location = New System.Drawing.Point(28, 99)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.dizUI.My.Resources.Resources.server
        Me.PictureBox4.Location = New System.Drawing.Point(28, 131)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = Global.dizUI.My.Resources.Resources.runtime
        Me.PictureBox5.Location = New System.Drawing.Point(28, 163)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'lblDownload
        '
        Me.lblDownload.AutoSize = True
        Me.lblDownload.BackColor = System.Drawing.Color.Transparent
        Me.lblDownload.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDownload.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblDownload.Location = New System.Drawing.Point(63, 35)
        Me.lblDownload.Name = "lblDownload"
        Me.lblDownload.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.lblDownload.Size = New System.Drawing.Size(294, 32)
        Me.lblDownload.TabIndex = 5
        Me.lblDownload.Text = "Download:"
        Me.lblDownload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUpload
        '
        Me.lblUpload.AutoSize = True
        Me.lblUpload.BackColor = System.Drawing.Color.Transparent
        Me.lblUpload.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblUpload.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblUpload.Location = New System.Drawing.Point(63, 67)
        Me.lblUpload.Name = "lblUpload"
        Me.lblUpload.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.lblUpload.Size = New System.Drawing.Size(294, 32)
        Me.lblUpload.TabIndex = 6
        Me.lblUpload.Text = "Upload:"
        Me.lblUpload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHostname
        '
        Me.lblHostname.AutoSize = True
        Me.lblHostname.BackColor = System.Drawing.Color.Transparent
        Me.lblHostname.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHostname.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblHostname.Location = New System.Drawing.Point(63, 99)
        Me.lblHostname.Name = "lblHostname"
        Me.lblHostname.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.lblHostname.Size = New System.Drawing.Size(294, 32)
        Me.lblHostname.TabIndex = 7
        Me.lblHostname.Text = "Hostname: "
        Me.lblHostname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblServer
        '
        Me.lblServer.AutoSize = True
        Me.lblServer.BackColor = System.Drawing.Color.Transparent
        Me.lblServer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblServer.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblServer.Location = New System.Drawing.Point(63, 131)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.lblServer.Size = New System.Drawing.Size(294, 32)
        Me.lblServer.TabIndex = 8
        Me.lblServer.Text = "Server:"
        Me.lblServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRuntime
        '
        Me.lblRuntime.AutoSize = True
        Me.lblRuntime.BackColor = System.Drawing.Color.Transparent
        Me.lblRuntime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRuntime.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblRuntime.Location = New System.Drawing.Point(63, 163)
        Me.lblRuntime.Name = "lblRuntime"
        Me.lblRuntime.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.lblRuntime.Size = New System.Drawing.Size(294, 32)
        Me.lblRuntime.TabIndex = 9
        Me.lblRuntime.Text = "Runtime:"
        Me.lblRuntime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = Global.dizUI.My.Resources.Resources.connection
        Me.PictureBox6.Location = New System.Drawing.Point(28, 195)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 10
        Me.PictureBox6.TabStop = False
        '
        'lblConnection
        '
        Me.lblConnection.AutoSize = True
        Me.lblConnection.BackColor = System.Drawing.Color.Transparent
        Me.lblConnection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblConnection.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblConnection.Location = New System.Drawing.Point(63, 195)
        Me.lblConnection.Name = "lblConnection"
        Me.lblConnection.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.lblConnection.Size = New System.Drawing.Size(294, 32)
        Me.lblConnection.TabIndex = 11
        Me.lblConnection.Text = "Connection Status:"
        Me.lblConnection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pTitle
        '
        Me.pTitle.BackColor = System.Drawing.Color.Transparent
        Me.pTitle.Controls.Add(Me.lblTitle)
        Me.pTitle.Controls.Add(Me.pExit)
        Me.pTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pTitle.Location = New System.Drawing.Point(2, 0)
        Me.pTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.pTitle.Name = "pTitle"
        Me.pTitle.Size = New System.Drawing.Size(388, 30)
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
        Me.lblTitle.Size = New System.Drawing.Size(358, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Performance Status"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pExit
        '
        Me.pExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.pExit.Image = Global.dizUI.My.Resources.Resources.exit_w
        Me.pExit.Location = New System.Drawing.Point(358, 0)
        Me.pExit.Margin = New System.Windows.Forms.Padding(0)
        Me.pExit.Name = "pExit"
        Me.pExit.Size = New System.Drawing.Size(30, 30)
        Me.pExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pExit.TabIndex = 11
        Me.pExit.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'frmPerformance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(392, 295)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPerformance"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Performance Status"
        Me.tlpForm.ResumeLayout(False)
        Me.pBody.ResumeLayout(False)
        Me.tlpEntry.ResumeLayout(False)
        Me.tlpEntry.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pTitle.ResumeLayout(False)
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pBody As System.Windows.Forms.Panel
    Friend WithEvents tlpEntry As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents lblDownload As System.Windows.Forms.Label
    Friend WithEvents lblUpload As System.Windows.Forms.Label
    Friend WithEvents lblHostname As System.Windows.Forms.Label
    Friend WithEvents lblServer As System.Windows.Forms.Label
    Friend WithEvents lblRuntime As System.Windows.Forms.Label
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents lblConnection As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
End Class
