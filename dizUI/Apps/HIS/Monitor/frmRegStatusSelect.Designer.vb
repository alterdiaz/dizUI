<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegStatusSelect
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.tlpForm = New System.Windows.Forms.TableLayoutPanel()
        Me.pContent = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnKRSAPS = New System.Windows.Forms.Button()
        Me.btnKabur = New System.Windows.Forms.Button()
        Me.btnMRS = New System.Windows.Forms.Button()
        Me.btnMeninggal = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnKRSclosing = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnRujuk = New System.Windows.Forms.Button()
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
        Me.tlpForm.Size = New System.Drawing.Size(560, 317)
        Me.tlpForm.TabIndex = 0
        '
        'pContent
        '
        Me.pContent.BackColor = System.Drawing.Color.Transparent
        Me.pContent.BackgroundImage = Global.dizUI.My.Resources.Resources.canvas_services
        Me.pContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pContent.Controls.Add(Me.Panel1)
        Me.pContent.Controls.Add(Me.btnExit)
        Me.pContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pContent.Location = New System.Drawing.Point(2, 2)
        Me.pContent.Margin = New System.Windows.Forms.Padding(0)
        Me.pContent.Name = "pContent"
        Me.pContent.Size = New System.Drawing.Size(556, 313)
        Me.pContent.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnKRSAPS)
        Me.Panel1.Controls.Add(Me.btnKabur)
        Me.Panel1.Controls.Add(Me.btnMRS)
        Me.Panel1.Controls.Add(Me.btnMeninggal)
        Me.Panel1.Controls.Add(Me.btnOK)
        Me.Panel1.Controls.Add(Me.btnKRSclosing)
        Me.Panel1.Controls.Add(Me.btnBatal)
        Me.Panel1.Controls.Add(Me.btnRujuk)
        Me.Panel1.Location = New System.Drawing.Point(11, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(497, 293)
        Me.Panel1.TabIndex = 1
        '
        'btnKRSAPS
        '
        Me.btnKRSAPS.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnKRSAPS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnKRSAPS.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.btnKRSAPS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnKRSAPS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnKRSAPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKRSAPS.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnKRSAPS.ForeColor = System.Drawing.Color.White
        Me.btnKRSAPS.Location = New System.Drawing.Point(249, 92)
        Me.btnKRSAPS.Name = "btnKRSAPS"
        Me.btnKRSAPS.Size = New System.Drawing.Size(240, 60)
        Me.btnKRSAPS.TabIndex = 33
        Me.btnKRSAPS.Tag = "4"
        Me.btnKRSAPS.Text = "KRS APS"
        Me.btnKRSAPS.UseMnemonic = False
        Me.btnKRSAPS.UseVisualStyleBackColor = False
        '
        'btnKabur
        '
        Me.btnKabur.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnKabur.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnKabur.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.btnKabur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnKabur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnKabur.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKabur.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnKabur.ForeColor = System.Drawing.Color.White
        Me.btnKabur.Location = New System.Drawing.Point(249, 26)
        Me.btnKabur.Name = "btnKabur"
        Me.btnKabur.Size = New System.Drawing.Size(240, 60)
        Me.btnKabur.TabIndex = 16
        Me.btnKabur.Tag = "5"
        Me.btnKabur.Text = "KABUR"
        Me.btnKabur.UseMnemonic = False
        Me.btnKabur.UseVisualStyleBackColor = False
        '
        'btnMRS
        '
        Me.btnMRS.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMRS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnMRS.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.btnMRS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMRS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnMRS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMRS.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnMRS.ForeColor = System.Drawing.Color.White
        Me.btnMRS.Location = New System.Drawing.Point(249, 158)
        Me.btnMRS.Name = "btnMRS"
        Me.btnMRS.Size = New System.Drawing.Size(240, 60)
        Me.btnMRS.TabIndex = 14
        Me.btnMRS.Tag = "1"
        Me.btnMRS.Text = "MRS"
        Me.btnMRS.UseVisualStyleBackColor = False
        '
        'btnMeninggal
        '
        Me.btnMeninggal.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMeninggal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnMeninggal.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.btnMeninggal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMeninggal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnMeninggal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMeninggal.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnMeninggal.ForeColor = System.Drawing.Color.White
        Me.btnMeninggal.Location = New System.Drawing.Point(3, 158)
        Me.btnMeninggal.Name = "btnMeninggal"
        Me.btnMeninggal.Size = New System.Drawing.Size(240, 60)
        Me.btnMeninggal.TabIndex = 13
        Me.btnMeninggal.Tag = "6"
        Me.btnMeninggal.Text = "MENINGGAL"
        Me.btnMeninggal.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnOK.FlatAppearance.BorderSize = 0
        Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Image = Global.dizUI.My.Resources.Resources.ok_w
        Me.btnOK.Location = New System.Drawing.Point(458, 235)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(40, 40)
        Me.btnOK.TabIndex = 12
        Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnOK.UseVisualStyleBackColor = False
        Me.btnOK.Visible = False
        '
        'btnKRSclosing
        '
        Me.btnKRSclosing.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnKRSclosing.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnKRSclosing.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.btnKRSclosing.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnKRSclosing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnKRSclosing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKRSclosing.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnKRSclosing.ForeColor = System.Drawing.Color.White
        Me.btnKRSclosing.Location = New System.Drawing.Point(3, 92)
        Me.btnKRSclosing.Name = "btnKRSclosing"
        Me.btnKRSclosing.Size = New System.Drawing.Size(240, 60)
        Me.btnKRSclosing.TabIndex = 7
        Me.btnKRSclosing.Tag = "7"
        Me.btnKRSclosing.Text = "KRS / CLOSING"
        Me.btnKRSclosing.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBatal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnBatal.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.btnBatal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBatal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnBatal.ForeColor = System.Drawing.Color.White
        Me.btnBatal.Location = New System.Drawing.Point(3, 26)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(240, 60)
        Me.btnBatal.TabIndex = 6
        Me.btnBatal.Tag = "2"
        Me.btnBatal.Text = "BATAL"
        Me.btnBatal.UseMnemonic = False
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnRujuk
        '
        Me.btnRujuk.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRujuk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnRujuk.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.btnRujuk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRujuk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnRujuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRujuk.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnRujuk.ForeColor = System.Drawing.Color.White
        Me.btnRujuk.Location = New System.Drawing.Point(3, 224)
        Me.btnRujuk.Name = "btnRujuk"
        Me.btnRujuk.Size = New System.Drawing.Size(240, 60)
        Me.btnRujuk.TabIndex = 17
        Me.btnRujuk.Tag = "3"
        Me.btnRujuk.Text = "RUJUK"
        Me.btnRujuk.UseVisualStyleBackColor = False
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
        Me.btnExit.Location = New System.Drawing.Point(516, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(40, 40)
        Me.btnExit.TabIndex = 14
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmRegStatusSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(560, 317)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegStatusSelect"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrasi Status Select"
        Me.tlpForm.ResumeLayout(False)
        Me.pContent.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pContent As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnKRSclosing As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnMeninggal As System.Windows.Forms.Button
    Friend WithEvents btnMRS As System.Windows.Forms.Button
    Friend WithEvents btnKabur As System.Windows.Forms.Button
    Friend WithEvents btnRujuk As Button
    Friend WithEvents btnKRSAPS As Button
End Class
