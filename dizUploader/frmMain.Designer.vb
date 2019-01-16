<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.lbFilenames = New System.Windows.Forms.ListBox()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.tboPath = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.pbAppIcon = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pbAppIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(472, 29)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "dizUploader"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnKeluar
        '
        Me.btnKeluar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnKeluar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnKeluar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnKeluar.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btnKeluar.FlatAppearance.BorderSize = 2
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeluar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.Location = New System.Drawing.Point(422, 0)
        Me.btnKeluar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(50, 29)
        Me.btnKeluar.TabIndex = 14
        Me.btnKeluar.Text = "Exit"
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'lbFilenames
        '
        Me.lbFilenames.BackColor = System.Drawing.Color.White
        Me.lbFilenames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbFilenames.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbFilenames.ForeColor = System.Drawing.Color.Black
        Me.lbFilenames.FormattingEnabled = True
        Me.lbFilenames.ItemHeight = 15
        Me.lbFilenames.Location = New System.Drawing.Point(8, 37)
        Me.lbFilenames.Margin = New System.Windows.Forms.Padding(8)
        Me.lbFilenames.Name = "lbFilenames"
        Me.lbFilenames.Size = New System.Drawing.Size(456, 347)
        Me.lbFilenames.TabIndex = 18
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnUpload.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnUpload.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btnUpload.FlatAppearance.BorderSize = 2
        Me.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpload.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.Location = New System.Drawing.Point(392, 428)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(72, 30)
        Me.btnUpload.TabIndex = 30
        Me.btnUpload.Text = "Upload"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(476, 470)
        Me.TableLayoutPanel1.TabIndex = 33
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblVersion)
        Me.Panel1.Controls.Add(Me.tboPath)
        Me.Panel1.Controls.Add(Me.btnBrowse)
        Me.Panel1.Controls.Add(Me.lbFilenames)
        Me.Panel1.Controls.Add(Me.btnMinimize)
        Me.Panel1.Controls.Add(Me.btnKeluar)
        Me.Panel1.Controls.Add(Me.pbAppIcon)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Controls.Add(Me.btnUpload)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(2, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(472, 468)
        Me.Panel1.TabIndex = 0
        '
        'lblVersion
        '
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblVersion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.Color.White
        Me.lblVersion.Location = New System.Drawing.Point(5, 428)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(381, 30)
        Me.lblVersion.TabIndex = 37
        Me.lblVersion.Text = "No File found"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tboPath
        '
        Me.tboPath.BackColor = System.Drawing.Color.White
        Me.tboPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboPath.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboPath.ForeColor = System.Drawing.Color.Black
        Me.tboPath.Location = New System.Drawing.Point(8, 396)
        Me.tboPath.Name = "tboPath"
        Me.tboPath.ReadOnly = True
        Me.tboPath.Size = New System.Drawing.Size(378, 23)
        Me.tboPath.TabIndex = 35
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.Khaki
        Me.btnBrowse.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btnBrowse.FlatAppearance.BorderSize = 2
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.Location = New System.Drawing.Point(392, 392)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(72, 30)
        Me.btnBrowse.TabIndex = 34
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.Khaki
        Me.btnMinimize.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btnMinimize.FlatAppearance.BorderSize = 2
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.Location = New System.Drawing.Point(372, 0)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(50, 29)
        Me.btnMinimize.TabIndex = 33
        Me.btnMinimize.Text = "Min"
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'pbAppIcon
        '
        Me.pbAppIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.pbAppIcon.Image = Global.dizUploader.My.Resources.Resources.dizUploader
        Me.pbAppIcon.Location = New System.Drawing.Point(0, 0)
        Me.pbAppIcon.Margin = New System.Windows.Forms.Padding(0)
        Me.pbAppIcon.Name = "pbAppIcon"
        Me.pbAppIcon.Size = New System.Drawing.Size(29, 29)
        Me.pbAppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbAppIcon.TabIndex = 9
        Me.pbAppIcon.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.CancelButton = Me.btnKeluar
        Me.ClientSize = New System.Drawing.Size(476, 470)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Application for Uploader"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbAppIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pbAppIcon As System.Windows.Forms.PictureBox
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents lbFilenames As System.Windows.Forms.ListBox
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnMinimize As System.Windows.Forms.Button
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents tboPath As System.Windows.Forms.TextBox
    Friend WithEvents lblVersion As System.Windows.Forms.Label

End Class
