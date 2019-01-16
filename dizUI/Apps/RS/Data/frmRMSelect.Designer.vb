<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRMSelect
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnTanpaNoRM = New System.Windows.Forms.Button()
        Me.btnDenganNoRM = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tlpForm.SuspendLayout()
        Me.pContent.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpForm
        '
        Me.tlpForm.BackColor = System.Drawing.Color.Transparent
        Me.tlpForm.ColumnCount = 3
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.Controls.Add(Me.pContent, 1, 1)
        Me.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpForm.Location = New System.Drawing.Point(0, 0)
        Me.tlpForm.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpForm.Name = "tlpForm"
        Me.tlpForm.RowCount = 3
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.Size = New System.Drawing.Size(375, 195)
        Me.tlpForm.TabIndex = 0
        '
        'pContent
        '
        Me.pContent.BackColor = System.Drawing.Color.Transparent
        Me.pContent.BackgroundImage = Global.dizUI.My.Resources.Resources.canvas_export
        Me.pContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pContent.Controls.Add(Me.Panel1)
        Me.pContent.Controls.Add(Me.btnExit)
        Me.pContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pContent.Location = New System.Drawing.Point(2, 2)
        Me.pContent.Margin = New System.Windows.Forms.Padding(0)
        Me.pContent.Name = "pContent"
        Me.pContent.Size = New System.Drawing.Size(371, 191)
        Me.pContent.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnOK)
        Me.Panel1.Controls.Add(Me.btnTanpaNoRM)
        Me.Panel1.Controls.Add(Me.btnDenganNoRM)
        Me.Panel1.Location = New System.Drawing.Point(23, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(307, 171)
        Me.Panel1.TabIndex = 1
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOK.FlatAppearance.BorderSize = 0
        Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Image = Global.dizUI.My.Resources.Resources.ok_w
        Me.btnOK.Location = New System.Drawing.Point(268, 113)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(40, 40)
        Me.btnOK.TabIndex = 12
        Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnOK.UseVisualStyleBackColor = False
        Me.btnOK.Visible = False
        '
        'btnTanpaNoRM
        '
        Me.btnTanpaNoRM.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnTanpaNoRM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnTanpaNoRM.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.btnTanpaNoRM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnTanpaNoRM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnTanpaNoRM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTanpaNoRM.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnTanpaNoRM.ForeColor = System.Drawing.Color.White
        Me.btnTanpaNoRM.Location = New System.Drawing.Point(18, 91)
        Me.btnTanpaNoRM.Name = "btnTanpaNoRM"
        Me.btnTanpaNoRM.Size = New System.Drawing.Size(240, 60)
        Me.btnTanpaNoRM.TabIndex = 7
        Me.btnTanpaNoRM.Tag = "Tanpa NoRM"
        Me.btnTanpaNoRM.Text = "Tanpa Nomor RM"
        Me.btnTanpaNoRM.UseVisualStyleBackColor = False
        '
        'btnDenganNoRM
        '
        Me.btnDenganNoRM.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDenganNoRM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnDenganNoRM.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.btnDenganNoRM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDenganNoRM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnDenganNoRM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDenganNoRM.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnDenganNoRM.ForeColor = System.Drawing.Color.White
        Me.btnDenganNoRM.Location = New System.Drawing.Point(18, 25)
        Me.btnDenganNoRM.Name = "btnDenganNoRM"
        Me.btnDenganNoRM.Size = New System.Drawing.Size(240, 60)
        Me.btnDenganNoRM.TabIndex = 6
        Me.btnDenganNoRM.Tag = "Dengan NoRM"
        Me.btnDenganNoRM.Text = "Dengan Nomor RM"
        Me.btnDenganNoRM.UseMnemonic = False
        Me.btnDenganNoRM.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Image = Global.dizUI.My.Resources.Resources.exit_n
        Me.btnExit.Location = New System.Drawing.Point(331, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(40, 40)
        Me.btnExit.TabIndex = 14
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmRMSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(375, 195)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRMSelect"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export"
        Me.tlpForm.ResumeLayout(False)
        Me.pContent.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pContent As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnDenganNoRM As System.Windows.Forms.Button
    Friend WithEvents btnTanpaNoRM As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
