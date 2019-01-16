<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 25)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(363, 381)
        Me.ListBox1.TabIndex = 0
        Me.ListBox1.Visible = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(378, 25)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(80, 40)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "Refresh" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Lama"
        Me.btnRefresh.UseVisualStyleBackColor = True
        Me.btnRefresh.Visible = False
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(378, 366)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(80, 40)
        Me.btnImport.TabIndex = 2
        Me.btnImport.Text = "Import Baru"
        Me.btnImport.UseVisualStyleBackColor = True
        Me.btnImport.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(378, 320)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 40)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Update Kode Item"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 422)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.ListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnImport As Button
    Friend WithEvents Button1 As Button
End Class
