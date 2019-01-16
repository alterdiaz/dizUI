<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExport
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
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnHTML = New System.Windows.Forms.Button()
        Me.btnXLSX = New System.Windows.Forms.Button()
        Me.btnXLS = New System.Windows.Forms.Button()
        Me.btnPDF = New System.Windows.Forms.Button()
        Me.btnTXT = New System.Windows.Forms.Button()
        Me.tboFilename = New System.Windows.Forms.TextBox()
        Me.lblFilename = New System.Windows.Forms.Label()
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
        Me.tlpForm.Size = New System.Drawing.Size(375, 375)
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
        Me.pContent.Size = New System.Drawing.Size(371, 371)
        Me.pContent.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnBrowse)
        Me.Panel1.Controls.Add(Me.btnOK)
        Me.Panel1.Controls.Add(Me.btnHTML)
        Me.Panel1.Controls.Add(Me.btnXLSX)
        Me.Panel1.Controls.Add(Me.btnXLS)
        Me.Panel1.Controls.Add(Me.btnPDF)
        Me.Panel1.Controls.Add(Me.btnTXT)
        Me.Panel1.Controls.Add(Me.tboFilename)
        Me.Panel1.Controls.Add(Me.lblFilename)
        Me.Panel1.Location = New System.Drawing.Point(23, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(307, 351)
        Me.Panel1.TabIndex = 1
        '
        'btnBrowse
        '
        Me.btnBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowse.BackColor = System.Drawing.Color.Transparent
        Me.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBrowse.FlatAppearance.BorderSize = 0
        Me.btnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Image = Global.dizUI.My.Resources.Resources.browse_w
        Me.btnBrowse.Location = New System.Drawing.Point(220, 303)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(40, 40)
        Me.btnBrowse.TabIndex = 13
        Me.btnBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnBrowse.UseVisualStyleBackColor = False
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
        Me.btnOK.Location = New System.Drawing.Point(266, 303)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(40, 40)
        Me.btnOK.TabIndex = 12
        Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btnHTML
        '
        Me.btnHTML.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnHTML.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnHTML.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.btnHTML.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnHTML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnHTML.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHTML.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnHTML.ForeColor = System.Drawing.Color.White
        Me.btnHTML.Location = New System.Drawing.Point(18, 213)
        Me.btnHTML.Name = "btnHTML"
        Me.btnHTML.Size = New System.Drawing.Size(197, 41)
        Me.btnHTML.TabIndex = 10
        Me.btnHTML.Tag = "HTML"
        Me.btnHTML.Text = "Export to HTML"
        Me.btnHTML.UseVisualStyleBackColor = False
        '
        'btnXLSX
        '
        Me.btnXLSX.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnXLSX.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnXLSX.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.btnXLSX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnXLSX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnXLSX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnXLSX.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnXLSX.ForeColor = System.Drawing.Color.White
        Me.btnXLSX.Location = New System.Drawing.Point(18, 166)
        Me.btnXLSX.Name = "btnXLSX"
        Me.btnXLSX.Size = New System.Drawing.Size(197, 41)
        Me.btnXLSX.TabIndex = 9
        Me.btnXLSX.Tag = "XLSX"
        Me.btnXLSX.Text = "Export to XLSX"
        Me.btnXLSX.UseVisualStyleBackColor = False
        '
        'btnXLS
        '
        Me.btnXLS.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnXLS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnXLS.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.btnXLS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnXLS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnXLS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnXLS.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnXLS.ForeColor = System.Drawing.Color.White
        Me.btnXLS.Location = New System.Drawing.Point(18, 119)
        Me.btnXLS.Name = "btnXLS"
        Me.btnXLS.Size = New System.Drawing.Size(197, 41)
        Me.btnXLS.TabIndex = 8
        Me.btnXLS.Tag = "XLS"
        Me.btnXLS.Text = "Export to XLS"
        Me.btnXLS.UseVisualStyleBackColor = False
        '
        'btnPDF
        '
        Me.btnPDF.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPDF.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnPDF.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.btnPDF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPDF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPDF.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnPDF.ForeColor = System.Drawing.Color.White
        Me.btnPDF.Location = New System.Drawing.Point(18, 72)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(197, 41)
        Me.btnPDF.TabIndex = 7
        Me.btnPDF.Tag = "PDF"
        Me.btnPDF.Text = "Export to PDF"
        Me.btnPDF.UseVisualStyleBackColor = False
        '
        'btnTXT
        '
        Me.btnTXT.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnTXT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnTXT.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.btnTXT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnTXT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnTXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTXT.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnTXT.ForeColor = System.Drawing.Color.White
        Me.btnTXT.Location = New System.Drawing.Point(18, 25)
        Me.btnTXT.Name = "btnTXT"
        Me.btnTXT.Size = New System.Drawing.Size(197, 41)
        Me.btnTXT.TabIndex = 6
        Me.btnTXT.Tag = "TXT"
        Me.btnTXT.Text = "Export to TXT"
        Me.btnTXT.UseVisualStyleBackColor = False
        '
        'tboFilename
        '
        Me.tboFilename.BackColor = System.Drawing.Color.White
        Me.tboFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboFilename.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tboFilename.Location = New System.Drawing.Point(76, 274)
        Me.tboFilename.MaxLength = 10
        Me.tboFilename.Name = "tboFilename"
        Me.tboFilename.ReadOnly = True
        Me.tboFilename.Size = New System.Drawing.Size(216, 22)
        Me.tboFilename.TabIndex = 3
        '
        'lblFilename
        '
        Me.lblFilename.AutoSize = True
        Me.lblFilename.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblFilename.Location = New System.Drawing.Point(15, 276)
        Me.lblFilename.Name = "lblFilename"
        Me.lblFilename.Size = New System.Drawing.Size(54, 14)
        Me.lblFilename.TabIndex = 1
        Me.lblFilename.Text = "Filename"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.IndianRed
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
        'frmExport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(375, 375)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmExport"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export"
        Me.tlpForm.ResumeLayout(False)
        Me.pContent.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pContent As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tboFilename As System.Windows.Forms.TextBox
    Friend WithEvents lblFilename As System.Windows.Forms.Label
    Friend WithEvents btnTXT As System.Windows.Forms.Button
    Friend WithEvents btnPDF As System.Windows.Forms.Button
    Friend WithEvents btnXLS As System.Windows.Forms.Button
    Friend WithEvents btnXLSX As System.Windows.Forms.Button
    Friend WithEvents btnHTML As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
End Class
