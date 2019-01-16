<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucChatlist
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
        Me.btnChat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnChat
        '
        Me.btnChat.BackColor = System.Drawing.Color.White
        Me.btnChat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChat.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnChat.Image = Global.dizUIlite.My.Resources.Resources.message
        Me.btnChat.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnChat.Location = New System.Drawing.Point(4, 4)
        Me.btnChat.Name = "btnChat"
        Me.btnChat.Size = New System.Drawing.Size(242, 62)
        Me.btnChat.TabIndex = 0
        Me.btnChat.Text = "Button1"
        Me.btnChat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnChat.UseVisualStyleBackColor = False
        '
        'ucChatlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.Controls.Add(Me.btnChat)
        Me.Name = "ucChatlist"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.Size = New System.Drawing.Size(250, 70)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnChat As System.Windows.Forms.Button

End Class
