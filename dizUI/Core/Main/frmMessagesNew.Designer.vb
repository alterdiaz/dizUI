<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMessagesNew
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
        Me.pBody = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.meMessage = New DevExpress.XtraEditors.MemoEdit()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lueUsername = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.pTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.teTitle = New DevExpress.XtraEditors.TextEdit()
        Me.tlpForm.SuspendLayout()
        Me.pBody.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.meMessage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.lueUsername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pTitle.SuspendLayout()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpForm
        '
        Me.tlpForm.BackColor = System.Drawing.Color.Maroon
        Me.tlpForm.ColumnCount = 3
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.Controls.Add(Me.pBody, 1, 1)
        Me.tlpForm.Controls.Add(Me.pTitle, 1, 0)
        Me.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpForm.Location = New System.Drawing.Point(0, 0)
        Me.tlpForm.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpForm.Name = "tlpForm"
        Me.tlpForm.RowCount = 3
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.Size = New System.Drawing.Size(746, 178)
        Me.tlpForm.TabIndex = 1
        '
        'pBody
        '
        Me.pBody.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.pBody.Controls.Add(Me.TableLayoutPanel1)
        Me.pBody.Controls.Add(Me.Label1)
        Me.pBody.Controls.Add(Me.Panel1)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(742, 146)
        Me.pBody.TabIndex = 7
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 30)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(740, 116)
        Me.TableLayoutPanel1.TabIndex = 25
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.meMessage)
        Me.Panel4.Controls.Add(Me.btnSend)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(20, 44)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(700, 52)
        Me.Panel4.TabIndex = 49
        '
        'meMessage
        '
        Me.meMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.meMessage.EditValue = "[Kosong]"
        Me.meMessage.Location = New System.Drawing.Point(0, 0)
        Me.meMessage.Margin = New System.Windows.Forms.Padding(0)
        Me.meMessage.Name = "meMessage"
        Me.meMessage.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.meMessage.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.meMessage.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.meMessage.Properties.Appearance.Options.UseBackColor = True
        Me.meMessage.Properties.Appearance.Options.UseFont = True
        Me.meMessage.Properties.Appearance.Options.UseForeColor = True
        Me.meMessage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.meMessage.Properties.MaxLength = 10
        Me.meMessage.Properties.NullText = "[BELUM DIISI]"
        Me.meMessage.Properties.NullValuePrompt = "[BELUM DIISI]"
        Me.meMessage.Properties.NullValuePromptShowForEmptyValue = True
        Me.meMessage.Properties.WordWrap = False
        Me.meMessage.Size = New System.Drawing.Size(600, 52)
        Me.meMessage.TabIndex = 46
        Me.meMessage.Tag = "lastmessage"
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnSend.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSend.FlatAppearance.BorderSize = 0
        Me.btnSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSend.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.ForeColor = System.Drawing.Color.White
        Me.btnSend.Location = New System.Drawing.Point(600, 0)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(100, 52)
        Me.btnSend.TabIndex = 47
        Me.btnSend.Text = "KIRIM"
        Me.btnSend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.teTitle)
        Me.Panel2.Controls.Add(Me.lueUsername)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(20, 20)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(700, 24)
        Me.Panel2.TabIndex = 0
        '
        'lueUsername
        '
        Me.lueUsername.Location = New System.Drawing.Point(125, 2)
        Me.lueUsername.Margin = New System.Windows.Forms.Padding(0)
        Me.lueUsername.Name = "lueUsername"
        Me.lueUsername.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueUsername.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueUsername.Properties.Appearance.Options.UseBackColor = True
        Me.lueUsername.Properties.Appearance.Options.UseFont = True
        Me.lueUsername.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueUsername.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueUsername.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueUsername.Properties.NullText = "[Isian belum dipilih]"
        Me.lueUsername.Size = New System.Drawing.Size(171, 20)
        Me.lueUsername.TabIndex = 41
        Me.lueUsername.Tag = "idreceiver"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 24)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Obrolan dengan"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(157, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 24)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Judul Catatan"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2, 116)
        Me.Panel1.TabIndex = 19
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.ForeColor = System.Drawing.Color.White
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(742, 30)
        Me.pHeader.TabIndex = 4
        '
        'pTitle
        '
        Me.pTitle.Controls.Add(Me.lblTitle)
        Me.pTitle.Controls.Add(Me.pExit)
        Me.pTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pTitle.Location = New System.Drawing.Point(2, 0)
        Me.pTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.pTitle.Name = "pTitle"
        Me.pTitle.Size = New System.Drawing.Size(742, 30)
        Me.pTitle.TabIndex = 8
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Maroon
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(712, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Obrolan Baru"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pExit
        '
        Me.pExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.pExit.Image = Global.dizUI.My.Resources.Resources.exit_w
        Me.pExit.Location = New System.Drawing.Point(712, 0)
        Me.pExit.Margin = New System.Windows.Forms.Padding(0)
        Me.pExit.Name = "pExit"
        Me.pExit.Size = New System.Drawing.Size(30, 30)
        Me.pExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pExit.TabIndex = 10
        Me.pExit.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(311, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 24)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Judul"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'teTitle
        '
        Me.teTitle.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teTitle.Location = New System.Drawing.Point(374, 2)
        Me.teTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.teTitle.Name = "teTitle"
        Me.teTitle.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teTitle.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teTitle.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teTitle.Properties.Appearance.Options.UseBackColor = True
        Me.teTitle.Properties.Appearance.Options.UseFont = True
        Me.teTitle.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teTitle.Properties.MaxLength = 300
        Me.teTitle.Properties.NullText = "[Belum Diisi]"
        Me.teTitle.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teTitle.Size = New System.Drawing.Size(197, 20)
        Me.teTitle.TabIndex = 25
        Me.teTitle.Tag = "messagetitle"
        '
        'frmMessagesNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.ClientSize = New System.Drawing.Size(746, 178)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMessagesNew"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Obrolan Baru"
        Me.tlpForm.ResumeLayout(False)
        Me.pBody.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.meMessage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.lueUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pTitle.ResumeLayout(False)
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pBody As System.Windows.Forms.Panel
    Friend WithEvents pHeader As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lueUsername As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents meMessage As DevExpress.XtraEditors.MemoEdit
    Public WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents teTitle As DevExpress.XtraEditors.TextEdit
End Class
