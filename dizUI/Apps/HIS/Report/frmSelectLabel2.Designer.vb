<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSelectLabel2
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
        Me.ceTanggalLahir = New DevExpress.XtraEditors.CheckEdit()
        Me.ceJenisKelamin = New DevExpress.XtraEditors.CheckEdit()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnSelect2 = New System.Windows.Forms.Button()
        Me.btnSelect1 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tlpForm.SuspendLayout()
        Me.pContent.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ceTanggalLahir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceJenisKelamin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tlpForm.Size = New System.Drawing.Size(388, 260)
        Me.tlpForm.TabIndex = 0
        '
        'pContent
        '
        Me.pContent.BackColor = System.Drawing.Color.Transparent
        Me.pContent.BackgroundImage = Global.dizUI.My.Resources.Resources.canvas_body
        Me.pContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pContent.Controls.Add(Me.Panel1)
        Me.pContent.Controls.Add(Me.btnExit)
        Me.pContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pContent.Location = New System.Drawing.Point(2, 2)
        Me.pContent.Margin = New System.Windows.Forms.Padding(0)
        Me.pContent.Name = "pContent"
        Me.pContent.Size = New System.Drawing.Size(384, 256)
        Me.pContent.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.ceTanggalLahir)
        Me.Panel1.Controls.Add(Me.ceJenisKelamin)
        Me.Panel1.Controls.Add(Me.btnOK)
        Me.Panel1.Controls.Add(Me.btnSelect2)
        Me.Panel1.Controls.Add(Me.btnSelect1)
        Me.Panel1.Location = New System.Drawing.Point(18, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(313, 233)
        Me.Panel1.TabIndex = 1
        '
        'ceTanggalLahir
        '
        Me.ceTanggalLahir.Location = New System.Drawing.Point(28, 193)
        Me.ceTanggalLahir.Name = "ceTanggalLahir"
        Me.ceTanggalLahir.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.ceTanggalLahir.Properties.Appearance.Options.UseFont = True
        Me.ceTanggalLahir.Properties.AutoWidth = True
        Me.ceTanggalLahir.Properties.Caption = "Dengan Tanggal Lahir"
        Me.ceTanggalLahir.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.ceTanggalLahir.Size = New System.Drawing.Size(150, 22)
        Me.ceTanggalLahir.TabIndex = 23
        '
        'ceJenisKelamin
        '
        Me.ceJenisKelamin.Location = New System.Drawing.Point(28, 172)
        Me.ceJenisKelamin.Name = "ceJenisKelamin"
        Me.ceJenisKelamin.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.ceJenisKelamin.Properties.Appearance.Options.UseFont = True
        Me.ceJenisKelamin.Properties.AutoWidth = True
        Me.ceJenisKelamin.Properties.Caption = "Dengan Jenis Kelamin dan Umur"
        Me.ceJenisKelamin.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.ceJenisKelamin.Size = New System.Drawing.Size(209, 22)
        Me.ceJenisKelamin.TabIndex = 22
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.green
        Me.btnOK.FlatAppearance.BorderSize = 0
        Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Image = Global.dizUI.My.Resources.Resources.ok
        Me.btnOK.Location = New System.Drawing.Point(271, 175)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(40, 40)
        Me.btnOK.TabIndex = 12
        Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btnSelect2
        '
        Me.btnSelect2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelect2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSelect2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnSelect2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.btnSelect2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSelect2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnSelect2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelect2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnSelect2.ForeColor = System.Drawing.Color.White
        Me.btnSelect2.Location = New System.Drawing.Point(28, 97)
        Me.btnSelect2.Name = "btnSelect2"
        Me.btnSelect2.Size = New System.Drawing.Size(230, 60)
        Me.btnSelect2.TabIndex = 7
        Me.btnSelect2.Tag = "2"
        Me.btnSelect2.Text = "2"
        Me.btnSelect2.UseVisualStyleBackColor = False
        '
        'btnSelect1
        '
        Me.btnSelect1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelect1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSelect1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnSelect1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.btnSelect1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSelect1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnSelect1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelect1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnSelect1.ForeColor = System.Drawing.Color.White
        Me.btnSelect1.Location = New System.Drawing.Point(28, 31)
        Me.btnSelect1.Name = "btnSelect1"
        Me.btnSelect1.Size = New System.Drawing.Size(230, 60)
        Me.btnSelect1.TabIndex = 6
        Me.btnSelect1.Tag = "1"
        Me.btnSelect1.Text = "1"
        Me.btnSelect1.UseMnemonic = False
        Me.btnSelect1.UseVisualStyleBackColor = False
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
        Me.btnExit.Location = New System.Drawing.Point(342, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(40, 40)
        Me.btnExit.TabIndex = 14
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmSelectLabel2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(388, 260)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSelectLabel2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export"
        Me.tlpForm.ResumeLayout(False)
        Me.pContent.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ceTanggalLahir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceJenisKelamin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pContent As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSelect1 As System.Windows.Forms.Button
    Friend WithEvents btnSelect2 As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents ceTanggalLahir As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ceJenisKelamin As DevExpress.XtraEditors.CheckEdit
End Class
