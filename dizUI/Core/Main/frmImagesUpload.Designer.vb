<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImagesUpload
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.btnUpload = New System.Windows.Forms.Button
        Me.btnBrowse = New System.Windows.Forms.Button
        Me.lboFilenames = New System.Windows.Forms.ListBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(342, 209)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(12, 227)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(342, 20)
        Me.TextBox1.TabIndex = 1
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(279, 253)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(75, 23)
        Me.btnUpload.TabIndex = 2
        Me.btnUpload.Text = "Upload"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(198, 253)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 3
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'lboFilenames
        '
        Me.lboFilenames.FormattingEnabled = True
        Me.lboFilenames.Location = New System.Drawing.Point(12, 283)
        Me.lboFilenames.Name = "lboFilenames"
        Me.lboFilenames.Size = New System.Drawing.Size(342, 173)
        Me.lboFilenames.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(198, 462)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(279, 462)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Upload"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmImagesUpload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 493)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lboFilenames)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmImagesUpload"
        Me.Text = "frmImagesUpload"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents lboFilenames As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
