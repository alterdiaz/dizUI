<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucNotes
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.btnNotes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNotes
        '
        Me.btnNotes.BackColor = System.Drawing.Color.GreenYellow
        Me.btnNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnNotes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OliveDrab
        Me.btnNotes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen
        Me.btnNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotes.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnNotes.Image = Global.dizUI.My.Resources.Resources.notes
        Me.btnNotes.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnNotes.Location = New System.Drawing.Point(4, 4)
        Me.btnNotes.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNotes.Name = "btnNotes"
        Me.btnNotes.Size = New System.Drawing.Size(242, 62)
        Me.btnNotes.TabIndex = 0
        Me.btnNotes.Text = "Button1"
        Me.btnNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNotes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNotes.UseVisualStyleBackColor = False
        '
        'ucNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.Controls.Add(Me.btnNotes)
        Me.Name = "ucNotes"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.Size = New System.Drawing.Size(250, 70)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnNotes As System.Windows.Forms.Button

End Class
