<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRujukanSelect
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
        Me.lblIGD = New System.Windows.Forms.Label()
        Me.lblUmum = New System.Windows.Forms.Label()
        Me.lblRehabilitasi = New System.Windows.Forms.Label()
        Me.lblPemeriksaan = New System.Windows.Forms.Label()
        Me.lblKonsultasi = New System.Windows.Forms.Label()
        Me.btnUmum = New System.Windows.Forms.Button()
        Me.btnIGD = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnPemeriksaan = New System.Windows.Forms.Button()
        Me.btnKonsultasi = New System.Windows.Forms.Button()
        Me.btnRehabilitasi = New System.Windows.Forms.Button()
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
        Me.tlpForm.Size = New System.Drawing.Size(560, 253)
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
        Me.pContent.Size = New System.Drawing.Size(556, 249)
        Me.pContent.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.lblIGD)
        Me.Panel1.Controls.Add(Me.lblUmum)
        Me.Panel1.Controls.Add(Me.lblRehabilitasi)
        Me.Panel1.Controls.Add(Me.lblPemeriksaan)
        Me.Panel1.Controls.Add(Me.lblKonsultasi)
        Me.Panel1.Controls.Add(Me.btnUmum)
        Me.Panel1.Controls.Add(Me.btnIGD)
        Me.Panel1.Controls.Add(Me.btnOK)
        Me.Panel1.Controls.Add(Me.btnPemeriksaan)
        Me.Panel1.Controls.Add(Me.btnKonsultasi)
        Me.Panel1.Controls.Add(Me.btnRehabilitasi)
        Me.Panel1.Location = New System.Drawing.Point(11, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(497, 229)
        Me.Panel1.TabIndex = 1
        '
        'lblIGD
        '
        Me.lblIGD.AutoSize = True
        Me.lblIGD.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblIGD.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIGD.ForeColor = System.Drawing.Color.White
        Me.lblIGD.Location = New System.Drawing.Point(399, 135)
        Me.lblIGD.Margin = New System.Windows.Forms.Padding(0)
        Me.lblIGD.Name = "lblIGD"
        Me.lblIGD.Size = New System.Drawing.Size(86, 14)
        Me.lblIGD.TabIndex = 27
        Me.lblIGD.Text = "Tidak Tersedia"
        Me.lblIGD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUmum
        '
        Me.lblUmum.AutoSize = True
        Me.lblUmum.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblUmum.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUmum.ForeColor = System.Drawing.Color.White
        Me.lblUmum.Location = New System.Drawing.Point(399, 69)
        Me.lblUmum.Margin = New System.Windows.Forms.Padding(0)
        Me.lblUmum.Name = "lblUmum"
        Me.lblUmum.Size = New System.Drawing.Size(86, 14)
        Me.lblUmum.TabIndex = 26
        Me.lblUmum.Text = "Tidak Tersedia"
        Me.lblUmum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRehabilitasi
        '
        Me.lblRehabilitasi.AutoSize = True
        Me.lblRehabilitasi.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblRehabilitasi.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRehabilitasi.ForeColor = System.Drawing.Color.White
        Me.lblRehabilitasi.Location = New System.Drawing.Point(153, 201)
        Me.lblRehabilitasi.Margin = New System.Windows.Forms.Padding(0)
        Me.lblRehabilitasi.Name = "lblRehabilitasi"
        Me.lblRehabilitasi.Size = New System.Drawing.Size(86, 14)
        Me.lblRehabilitasi.TabIndex = 25
        Me.lblRehabilitasi.Text = "Tidak Tersedia"
        Me.lblRehabilitasi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPemeriksaan
        '
        Me.lblPemeriksaan.AutoSize = True
        Me.lblPemeriksaan.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPemeriksaan.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPemeriksaan.ForeColor = System.Drawing.Color.White
        Me.lblPemeriksaan.Location = New System.Drawing.Point(153, 135)
        Me.lblPemeriksaan.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPemeriksaan.Name = "lblPemeriksaan"
        Me.lblPemeriksaan.Size = New System.Drawing.Size(86, 14)
        Me.lblPemeriksaan.TabIndex = 23
        Me.lblPemeriksaan.Text = "Tidak Tersedia"
        Me.lblPemeriksaan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblKonsultasi
        '
        Me.lblKonsultasi.AutoSize = True
        Me.lblKonsultasi.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblKonsultasi.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKonsultasi.ForeColor = System.Drawing.Color.White
        Me.lblKonsultasi.Location = New System.Drawing.Point(153, 69)
        Me.lblKonsultasi.Margin = New System.Windows.Forms.Padding(0)
        Me.lblKonsultasi.Name = "lblKonsultasi"
        Me.lblKonsultasi.Size = New System.Drawing.Size(86, 14)
        Me.lblKonsultasi.TabIndex = 22
        Me.lblKonsultasi.Text = "Tidak Tersedia"
        Me.lblKonsultasi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnUmum
        '
        Me.btnUmum.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnUmum.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnUmum.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.btnUmum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnUmum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnUmum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUmum.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnUmum.ForeColor = System.Drawing.Color.White
        Me.btnUmum.Location = New System.Drawing.Point(249, 26)
        Me.btnUmum.Name = "btnUmum"
        Me.btnUmum.Size = New System.Drawing.Size(240, 60)
        Me.btnUmum.TabIndex = 16
        Me.btnUmum.Tag = "UMUM"
        Me.btnUmum.Text = "POLI UMUM"
        Me.btnUmum.UseMnemonic = False
        Me.btnUmum.UseVisualStyleBackColor = False
        '
        'btnIGD
        '
        Me.btnIGD.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnIGD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnIGD.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.btnIGD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIGD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnIGD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIGD.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnIGD.ForeColor = System.Drawing.Color.White
        Me.btnIGD.Location = New System.Drawing.Point(249, 92)
        Me.btnIGD.Name = "btnIGD"
        Me.btnIGD.Size = New System.Drawing.Size(240, 60)
        Me.btnIGD.TabIndex = 14
        Me.btnIGD.Tag = "IGD"
        Me.btnIGD.Text = "IGD"
        Me.btnIGD.UseVisualStyleBackColor = False
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
        Me.btnOK.Location = New System.Drawing.Point(458, 171)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(40, 40)
        Me.btnOK.TabIndex = 12
        Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnOK.UseVisualStyleBackColor = False
        Me.btnOK.Visible = False
        '
        'btnPemeriksaan
        '
        Me.btnPemeriksaan.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPemeriksaan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnPemeriksaan.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.btnPemeriksaan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPemeriksaan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnPemeriksaan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPemeriksaan.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnPemeriksaan.ForeColor = System.Drawing.Color.White
        Me.btnPemeriksaan.Location = New System.Drawing.Point(3, 92)
        Me.btnPemeriksaan.Name = "btnPemeriksaan"
        Me.btnPemeriksaan.Size = New System.Drawing.Size(240, 60)
        Me.btnPemeriksaan.TabIndex = 7
        Me.btnPemeriksaan.Tag = "PEMERIKSAAN"
        Me.btnPemeriksaan.Text = "PENUNJANG"
        Me.btnPemeriksaan.UseVisualStyleBackColor = False
        '
        'btnKonsultasi
        '
        Me.btnKonsultasi.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnKonsultasi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnKonsultasi.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.btnKonsultasi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnKonsultasi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnKonsultasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKonsultasi.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnKonsultasi.ForeColor = System.Drawing.Color.White
        Me.btnKonsultasi.Location = New System.Drawing.Point(3, 26)
        Me.btnKonsultasi.Name = "btnKonsultasi"
        Me.btnKonsultasi.Size = New System.Drawing.Size(240, 60)
        Me.btnKonsultasi.TabIndex = 6
        Me.btnKonsultasi.Tag = "KONSULTASI"
        Me.btnKonsultasi.Text = "POLI SPESIALIS"
        Me.btnKonsultasi.UseMnemonic = False
        Me.btnKonsultasi.UseVisualStyleBackColor = False
        '
        'btnRehabilitasi
        '
        Me.btnRehabilitasi.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRehabilitasi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnRehabilitasi.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.btnRehabilitasi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRehabilitasi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnRehabilitasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRehabilitasi.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnRehabilitasi.ForeColor = System.Drawing.Color.White
        Me.btnRehabilitasi.Location = New System.Drawing.Point(3, 158)
        Me.btnRehabilitasi.Name = "btnRehabilitasi"
        Me.btnRehabilitasi.Size = New System.Drawing.Size(240, 60)
        Me.btnRehabilitasi.TabIndex = 17
        Me.btnRehabilitasi.Tag = "REHABILITASI"
        Me.btnRehabilitasi.Text = "REHABILITASI MEDIK"
        Me.btnRehabilitasi.UseVisualStyleBackColor = False
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
        'frmRujukanSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(560, 253)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRujukanSelect"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pelayanan Select"
        Me.tlpForm.ResumeLayout(False)
        Me.pContent.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pContent As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnKonsultasi As System.Windows.Forms.Button
    Friend WithEvents btnPemeriksaan As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnIGD As System.Windows.Forms.Button
    Friend WithEvents btnUmum As System.Windows.Forms.Button
    Friend WithEvents btnRehabilitasi As Button
    Friend WithEvents lblIGD As Label
    Friend WithEvents lblUmum As Label
    Friend WithEvents lblRehabilitasi As Label
    Friend WithEvents lblPemeriksaan As Label
    Friend WithEvents lblKonsultasi As Label
End Class
