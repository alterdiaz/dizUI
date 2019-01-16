<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class btnSchedule
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 3
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Image = Global.dizUI.My.Resources.Resources.slot1
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(230, 50)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Appointment Schedule" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "06 September 2015"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "btnSchedule"
        Me.Size = New System.Drawing.Size(230, 50)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
