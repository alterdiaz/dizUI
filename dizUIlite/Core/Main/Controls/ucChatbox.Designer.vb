<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucChatbox
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.lblMsg)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(5, 4)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel3.Size = New System.Drawing.Size(693, 22)
        Me.Panel3.TabIndex = 26
        '
        'lblMsg
        '
        Me.lblMsg.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblMsg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMsg.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.Location = New System.Drawing.Point(1, 1)
        Me.lblMsg.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.lblMsg.Size = New System.Drawing.Size(691, 20)
        Me.lblMsg.TabIndex = 23
        Me.lblMsg.Text = "Periode Bulan"
        Me.lblMsg.UseMnemonic = False
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.BackColor = System.Drawing.Color.Tomato
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(605, 26)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(93, 24)
        Me.btnDelete.TabIndex = 29
        Me.btnDelete.Text = "HAPUS"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSelect
        '
        Me.btnSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelect.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnSelect.FlatAppearance.BorderSize = 0
        Me.btnSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelect.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.btnSelect.ForeColor = System.Drawing.Color.White
        Me.btnSelect.Location = New System.Drawing.Point(505, 26)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(93, 24)
        Me.btnSelect.TabIndex = 30
        Me.btnSelect.Text = "PILIH"
        Me.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.lblStatus.ForeColor = System.Drawing.Color.Black
        Me.lblStatus.Location = New System.Drawing.Point(365, 26)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(134, 24)
        Me.lblStatus.TabIndex = 31
        Me.lblStatus.Text = "Terkirim 28-01-2017 08:00:00" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Dibaca 28-01-2017 11:20:00"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ucChatbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ucChatbox"
        Me.Padding = New System.Windows.Forms.Padding(5, 4, 5, 28)
        Me.Size = New System.Drawing.Size(703, 54)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Public WithEvents btnDelete As System.Windows.Forms.Button
    Public WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblMsg As System.Windows.Forms.Label

End Class
