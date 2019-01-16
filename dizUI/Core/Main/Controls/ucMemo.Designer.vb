<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucMemo
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnMemo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMemo
        '
        Me.btnMemo.AutoEllipsis = True
        Me.btnMemo.BackColor = System.Drawing.Color.GreenYellow
        Me.btnMemo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMemo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OliveDrab
        Me.btnMemo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen
        Me.btnMemo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMemo.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnMemo.Image = Global.dizUI.My.Resources.Resources.memo
        Me.btnMemo.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnMemo.Location = New System.Drawing.Point(4, 4)
        Me.btnMemo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMemo.Name = "btnMemo"
        Me.btnMemo.Size = New System.Drawing.Size(242, 62)
        Me.btnMemo.TabIndex = 0
        Me.btnMemo.Text = "Button1"
        Me.btnMemo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMemo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMemo.UseVisualStyleBackColor = False
        '
        'ucMemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.Controls.Add(Me.btnMemo)
        Me.Name = "ucMemo"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.Size = New System.Drawing.Size(250, 70)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMemo As System.Windows.Forms.Button

End Class
