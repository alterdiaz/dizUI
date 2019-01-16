<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMessages
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMessages))
        Me.tlpForm = New System.Windows.Forms.TableLayoutPanel()
        Me.pBody = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tlpEntry = New System.Windows.Forms.TableLayoutPanel()
        Me.pMessage = New System.Windows.Forms.Panel()
        Me.pListChat = New System.Windows.Forms.Panel()
        Me.tlpListChat = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnSemua = New System.Windows.Forms.Button()
        Me.btnDeleteSelected = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.meMessage = New DevExpress.XtraEditors.MemoEdit()
        Me.ceSendType = New DevExpress.XtraEditors.CheckEdit()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pChatList = New System.Windows.Forms.Panel()
        Me.pList = New System.Windows.Forms.Panel()
        Me.tlpList = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnDeleteChat = New System.Windows.Forms.Button()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.panelMsg = New System.Windows.Forms.Panel()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.tlpForm.SuspendLayout()
        Me.pBody.SuspendLayout()
        Me.tlpEntry.SuspendLayout()
        Me.pMessage.SuspendLayout()
        Me.pListChat.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.meMessage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceSendType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pChatList.SuspendLayout()
        Me.pList.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.pHeader.SuspendLayout()
        Me.panelMsg.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tlpForm.Controls.Add(Me.Panel2, 1, 0)
        Me.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpForm.Location = New System.Drawing.Point(0, 0)
        Me.tlpForm.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpForm.Name = "tlpForm"
        Me.tlpForm.RowCount = 3
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.Size = New System.Drawing.Size(1024, 600)
        Me.tlpForm.TabIndex = 1
        '
        'pBody
        '
        Me.pBody.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.pBody.Controls.Add(Me.Panel1)
        Me.pBody.Controls.Add(Me.tlpEntry)
        Me.pBody.Controls.Add(Me.TableLayoutPanel1)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(1020, 568)
        Me.pBody.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(280, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2, 538)
        Me.Panel1.TabIndex = 21
        '
        'tlpEntry
        '
        Me.tlpEntry.ColumnCount = 3
        Me.tlpEntry.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpEntry.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEntry.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpEntry.Controls.Add(Me.pMessage, 1, 1)
        Me.tlpEntry.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpEntry.Location = New System.Drawing.Point(280, 30)
        Me.tlpEntry.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEntry.Name = "tlpEntry"
        Me.tlpEntry.RowCount = 3
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEntry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpEntry.Size = New System.Drawing.Size(740, 538)
        Me.tlpEntry.TabIndex = 17
        '
        'pMessage
        '
        Me.pMessage.Controls.Add(Me.pListChat)
        Me.pMessage.Controls.Add(Me.Panel5)
        Me.pMessage.Controls.Add(Me.Panel3)
        Me.pMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pMessage.Location = New System.Drawing.Point(20, 20)
        Me.pMessage.Margin = New System.Windows.Forms.Padding(0)
        Me.pMessage.Name = "pMessage"
        Me.pMessage.Size = New System.Drawing.Size(700, 498)
        Me.pMessage.TabIndex = 19
        '
        'pListChat
        '
        Me.pListChat.AutoScroll = True
        Me.pListChat.Controls.Add(Me.tlpListChat)
        Me.pListChat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pListChat.Location = New System.Drawing.Point(0, 30)
        Me.pListChat.Name = "pListChat"
        Me.pListChat.Size = New System.Drawing.Size(700, 412)
        Me.pListChat.TabIndex = 50
        '
        'tlpListChat
        '
        Me.tlpListChat.ColumnCount = 1
        Me.tlpListChat.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListChat.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpListChat.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpListChat.Location = New System.Drawing.Point(0, 0)
        Me.tlpListChat.Name = "tlpListChat"
        Me.tlpListChat.RowCount = 1
        Me.tlpListChat.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpListChat.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.tlpListChat.Size = New System.Drawing.Size(700, 70)
        Me.tlpListChat.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel5.Controls.Add(Me.btnSemua)
        Me.Panel5.Controls.Add(Me.btnDeleteSelected)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(700, 30)
        Me.Panel5.TabIndex = 49
        '
        'btnSemua
        '
        Me.btnSemua.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnSemua.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSemua.FlatAppearance.BorderSize = 0
        Me.btnSemua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnSemua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnSemua.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSemua.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSemua.ForeColor = System.Drawing.Color.White
        Me.btnSemua.Location = New System.Drawing.Point(410, 0)
        Me.btnSemua.Name = "btnSemua"
        Me.btnSemua.Size = New System.Drawing.Size(140, 30)
        Me.btnSemua.TabIndex = 26
        Me.btnSemua.Text = "BATAL PILIH SEMUA"
        Me.btnSemua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSemua.UseVisualStyleBackColor = False
        '
        'btnDeleteSelected
        '
        Me.btnDeleteSelected.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnDeleteSelected.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDeleteSelected.FlatAppearance.BorderSize = 0
        Me.btnDeleteSelected.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnDeleteSelected.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnDeleteSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteSelected.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteSelected.ForeColor = System.Drawing.Color.White
        Me.btnDeleteSelected.Location = New System.Drawing.Point(550, 0)
        Me.btnDeleteSelected.Name = "btnDeleteSelected"
        Me.btnDeleteSelected.Size = New System.Drawing.Size(150, 30)
        Me.btnDeleteSelected.TabIndex = 25
        Me.btnDeleteSelected.Text = "HAPUS PESAN TERPILIH"
        Me.btnDeleteSelected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeleteSelected.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.meMessage)
        Me.Panel3.Controls.Add(Me.ceSendType)
        Me.Panel3.Controls.Add(Me.btnSend)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 442)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(700, 56)
        Me.Panel3.TabIndex = 48
        '
        'meMessage
        '
        Me.meMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.meMessage.EditValue = ""
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
        Me.meMessage.Properties.MaxLength = 2000
        Me.meMessage.Properties.NullText = "[BELUM DIISI]"
        Me.meMessage.Properties.NullValuePrompt = "[BELUM DIISI]"
        Me.meMessage.Properties.NullValuePromptShowForEmptyValue = True
        Me.meMessage.Properties.WordWrap = False
        Me.meMessage.Size = New System.Drawing.Size(600, 38)
        Me.meMessage.TabIndex = 46
        Me.meMessage.Tag = ""
        '
        'ceSendType
        '
        Me.ceSendType.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ceSendType.Location = New System.Drawing.Point(0, 38)
        Me.ceSendType.Margin = New System.Windows.Forms.Padding(0)
        Me.ceSendType.Name = "ceSendType"
        Me.ceSendType.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ceSendType.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.ceSendType.Properties.Appearance.Options.UseFont = True
        Me.ceSendType.Properties.Appearance.Options.UseForeColor = True
        Me.ceSendType.Properties.Caption = "tekan 'Enter' untuk mengirim pesan"
        Me.ceSendType.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.ceSendType.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.ceSendType.Size = New System.Drawing.Size(600, 18)
        Me.ceSendType.TabIndex = 48
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
        Me.btnSend.Size = New System.Drawing.Size(100, 56)
        Me.btnSend.TabIndex = 47
        Me.btnSend.Text = "KIRIM"
        Me.btnSend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.pChatList, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 30)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(280, 538)
        Me.TableLayoutPanel1.TabIndex = 19
        '
        'pChatList
        '
        Me.pChatList.Controls.Add(Me.pList)
        Me.pChatList.Controls.Add(Me.Panel4)
        Me.pChatList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pChatList.Location = New System.Drawing.Point(20, 20)
        Me.pChatList.Margin = New System.Windows.Forms.Padding(0)
        Me.pChatList.Name = "pChatList"
        Me.pChatList.Size = New System.Drawing.Size(240, 498)
        Me.pChatList.TabIndex = 0
        '
        'pList
        '
        Me.pList.AutoScroll = True
        Me.pList.Controls.Add(Me.tlpList)
        Me.pList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pList.Location = New System.Drawing.Point(0, 30)
        Me.pList.Name = "pList"
        Me.pList.Size = New System.Drawing.Size(240, 468)
        Me.pList.TabIndex = 21
        '
        'tlpList
        '
        Me.tlpList.ColumnCount = 1
        Me.tlpList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpList.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpList.Location = New System.Drawing.Point(0, 0)
        Me.tlpList.Name = "tlpList"
        Me.tlpList.RowCount = 1
        Me.tlpList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.tlpList.Size = New System.Drawing.Size(240, 70)
        Me.tlpList.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel4.Controls.Add(Me.btnNew)
        Me.Panel4.Controls.Add(Me.btnDeleteChat)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(240, 30)
        Me.Panel4.TabIndex = 20
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnNew.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnNew.FlatAppearance.BorderSize = 0
        Me.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Location = New System.Drawing.Point(60, 0)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(60, 30)
        Me.btnNew.TabIndex = 26
        Me.btnNew.Text = "BARU"
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnDeleteChat
        '
        Me.btnDeleteChat.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnDeleteChat.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDeleteChat.FlatAppearance.BorderSize = 0
        Me.btnDeleteChat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnDeleteChat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnDeleteChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteChat.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteChat.ForeColor = System.Drawing.Color.White
        Me.btnDeleteChat.Location = New System.Drawing.Point(120, 0)
        Me.btnDeleteChat.Name = "btnDeleteChat"
        Me.btnDeleteChat.Size = New System.Drawing.Size(120, 30)
        Me.btnDeleteChat.TabIndex = 25
        Me.btnDeleteChat.Text = "HAPUS OBROLAN"
        Me.btnDeleteChat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeleteChat.UseVisualStyleBackColor = False
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Controls.Add(Me.panelMsg)
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.ForeColor = System.Drawing.Color.White
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(1020, 30)
        Me.pHeader.TabIndex = 20
        '
        'panelMsg
        '
        Me.panelMsg.Controls.Add(Me.lblMsg)
        Me.panelMsg.Location = New System.Drawing.Point(38, 6)
        Me.panelMsg.Margin = New System.Windows.Forms.Padding(0)
        Me.panelMsg.Name = "panelMsg"
        Me.panelMsg.Size = New System.Drawing.Size(691, 1000)
        Me.panelMsg.TabIndex = 34
        Me.panelMsg.Visible = False
        '
        'lblMsg
        '
        Me.lblMsg.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lblMsg.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblMsg.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblMsg.Location = New System.Drawing.Point(0, 0)
        Me.lblMsg.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.lblMsg.Size = New System.Drawing.Size(691, 52)
        Me.lblMsg.TabIndex = 33
        Me.lblMsg.Text = resources.GetString("lblMsg.Text")
        Me.lblMsg.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblTitle)
        Me.Panel2.Controls.Add(Me.pExit)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(2, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1020, 30)
        Me.Panel2.TabIndex = 8
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
        Me.lblTitle.Size = New System.Drawing.Size(990, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Obrolan"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pExit
        '
        Me.pExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.pExit.Image = Global.dizUI.My.Resources.Resources.exit_w
        Me.pExit.Location = New System.Drawing.Point(990, 0)
        Me.pExit.Margin = New System.Windows.Forms.Padding(0)
        Me.pExit.Name = "pExit"
        Me.pExit.Size = New System.Drawing.Size(30, 30)
        Me.pExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pExit.TabIndex = 11
        Me.pExit.TabStop = False
        '
        'frmMessages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.ClientSize = New System.Drawing.Size(1024, 600)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMessages"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Obrolan"
        Me.tlpForm.ResumeLayout(False)
        Me.pBody.ResumeLayout(False)
        Me.tlpEntry.ResumeLayout(False)
        Me.pMessage.ResumeLayout(False)
        Me.pListChat.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.meMessage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceSendType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.pChatList.ResumeLayout(False)
        Me.pList.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.pHeader.ResumeLayout(False)
        Me.panelMsg.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pBody As System.Windows.Forms.Panel
    Friend WithEvents tlpEntry As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pMessage As System.Windows.Forms.Panel
    Friend WithEvents pChatList As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Friend WithEvents pHeader As System.Windows.Forms.Panel
    Public WithEvents btnDeleteChat As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents meMessage As DevExpress.XtraEditors.MemoEdit
    Public WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Public WithEvents btnDeleteSelected As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Public WithEvents btnNew As System.Windows.Forms.Button
    Public WithEvents btnSemua As System.Windows.Forms.Button
    Friend WithEvents pListChat As System.Windows.Forms.Panel
    Friend WithEvents tlpListChat As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pList As System.Windows.Forms.Panel
    Friend WithEvents tlpList As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents panelMsg As System.Windows.Forms.Panel
    Friend WithEvents ceSendType As DevExpress.XtraEditors.CheckEdit

End Class
