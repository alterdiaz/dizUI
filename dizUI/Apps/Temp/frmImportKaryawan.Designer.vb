<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportKaryawan
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
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnImport = New System.Windows.Forms.Button
        Me.tboFilename = New System.Windows.Forms.TextBox
        Me.btnBrowse = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.BackColor = System.Drawing.Color.White
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 49)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(501, 316)
        Me.ListBox1.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(453, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(60, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(387, 12)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(60, 23)
        Me.btnImport.TabIndex = 2
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'tboFilename
        '
        Me.tboFilename.BackColor = System.Drawing.Color.White
        Me.tboFilename.Location = New System.Drawing.Point(12, 13)
        Me.tboFilename.Name = "tboFilename"
        Me.tboFilename.ReadOnly = True
        Me.tboFilename.Size = New System.Drawing.Size(303, 20)
        Me.tboFilename.TabIndex = 3
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(321, 12)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(60, 23)
        Me.btnBrowse.TabIndex = 4
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'frmImportKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 380)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.tboFilename)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "frmImportKaryawan"
        Me.Text = "frmImportKaryawan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents tboFilename As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
End Class
