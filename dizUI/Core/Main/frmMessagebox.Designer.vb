<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMessagebox
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
        Me.tlpForm = New System.Windows.Forms.TableLayoutPanel()
        Me.pContent = New System.Windows.Forms.Panel()
        Me.pnlField = New System.Windows.Forms.Panel()
        Me.btnDetail = New System.Windows.Forms.Button()
        Me.pbIcon = New System.Windows.Forms.PictureBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblContent = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.tlpForm.SuspendLayout()
        Me.pContent.SuspendLayout()
        Me.pnlField.SuspendLayout()
        CType(Me.pbIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpForm
        '
        Me.tlpForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tlpForm.ColumnCount = 1
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpForm.Controls.Add(Me.pContent, 0, 1)
        Me.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpForm.Location = New System.Drawing.Point(0, 0)
        Me.tlpForm.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpForm.Name = "tlpForm"
        Me.tlpForm.RowCount = 3
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.Size = New System.Drawing.Size(725, 200)
        Me.tlpForm.TabIndex = 0
        '
        'pContent
        '
        Me.pContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.pContent.BackgroundImage = Global.dizUI.My.Resources.Resources.canvas_msgbox
        Me.pContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pContent.Controls.Add(Me.pnlField)
        Me.pContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pContent.Location = New System.Drawing.Point(0, 2)
        Me.pContent.Margin = New System.Windows.Forms.Padding(0)
        Me.pContent.Name = "pContent"
        Me.pContent.Size = New System.Drawing.Size(725, 196)
        Me.pContent.TabIndex = 0
        '
        'pnlField
        '
        Me.pnlField.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlField.BackColor = System.Drawing.Color.Transparent
        Me.pnlField.Controls.Add(Me.btnDetail)
        Me.pnlField.Controls.Add(Me.pbIcon)
        Me.pnlField.Controls.Add(Me.btnCancel)
        Me.pnlField.Controls.Add(Me.btnOK)
        Me.pnlField.Controls.Add(Me.lblContent)
        Me.pnlField.Controls.Add(Me.lblTitle)
        Me.pnlField.Location = New System.Drawing.Point(75, 6)
        Me.pnlField.Name = "pnlField"
        Me.pnlField.Size = New System.Drawing.Size(584, 183)
        Me.pnlField.TabIndex = 0
        '
        'btnDetail
        '
        Me.btnDetail.BackColor = System.Drawing.Color.Transparent
        Me.btnDetail.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed
        Me.btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDetail.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDetail.ForeColor = System.Drawing.Color.Black
        Me.btnDetail.Location = New System.Drawing.Point(19, 141)
        Me.btnDetail.Name = "btnDetail"
        Me.btnDetail.Size = New System.Drawing.Size(119, 28)
        Me.btnDetail.TabIndex = 23
        Me.btnDetail.Text = "Detail Pesan"
        Me.btnDetail.UseVisualStyleBackColor = False
        '
        'pbIcon
        '
        Me.pbIcon.Image = Global.dizUI.My.Resources.Resources.ico_warning
        Me.pbIcon.Location = New System.Drawing.Point(4, 3)
        Me.pbIcon.Margin = New System.Windows.Forms.Padding(4)
        Me.pbIcon.Name = "pbIcon"
        Me.pbIcon.Size = New System.Drawing.Size(40, 40)
        Me.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbIcon.TabIndex = 22
        Me.pbIcon.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BackgroundImage = Global.dizUI.My.Resources.Resources.exit_w
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(492, 135)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(40, 40)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.BackgroundImage = Global.dizUI.My.Resources.Resources.ok_w
        Me.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOK.FlatAppearance.BorderSize = 0
        Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(540, 135)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(40, 40)
        Me.btnOK.TabIndex = 20
        Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'lblContent
        '
        Me.lblContent.AutoEllipsis = True
        Me.lblContent.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContent.Location = New System.Drawing.Point(16, 51)
        Me.lblContent.Margin = New System.Windows.Forms.Padding(4)
        Me.lblContent.Name = "lblContent"
        Me.lblContent.Size = New System.Drawing.Size(516, 76)
        Me.lblContent.TabIndex = 0
        Me.lblContent.Text = "Content"
        '
        'lblTitle
        '
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New System.Windows.Forms.Padding(48, 8, 8, 8)
        Me.lblTitle.Size = New System.Drawing.Size(584, 44)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Title"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMessagebox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(725, 200)
        Me.ControlBox = False
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMessagebox"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Login"
        Me.tlpForm.ResumeLayout(False)
        Me.pContent.ResumeLayout(False)
        Me.pnlField.ResumeLayout(False)
        Me.pnlField.PerformLayout()
        CType(Me.pbIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pContent As System.Windows.Forms.Panel
    Friend WithEvents pnlField As System.Windows.Forms.Panel
    Friend WithEvents lblContent As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Public WithEvents btnCancel As System.Windows.Forms.Button
    Public WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents pbIcon As System.Windows.Forms.PictureBox
    Friend WithEvents btnDetail As System.Windows.Forms.Button
End Class
