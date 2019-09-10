Public Class frmMessages
    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1

    'API functions   
    <System.Runtime.InteropServices.DllImport("user32.dll", CharSet:=System.Runtime.InteropServices.CharSet.Auto, SetLastError:=True, ExactSpelling:=True)> _
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    Private Sub lblTitle_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitle.MouseDown
        'This code can be used in the MouseDown event of any control(s) you want to be able to move your form with   
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0&)
    End Sub

    Private Sub pExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pExit.Click
        bClose = False
        Me.Dispose()
    End Sub

    Private Sub pbMMX_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pExit.MouseDown
        If sender Is pExit Then
            sender.backcolor = justRead
            sender.Image = My.Resources.exit_n
        End If
    End Sub

    Private Sub pbMMX_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pExit.MouseEnter
        If sender Is pExit Then
            sender.backcolor = Color.FromArgb(206, 0, 0)
            sender.Image = My.Resources.exit_n
        End If
    End Sub

    Private Sub pbMMX_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pExit.MouseLeave
        sender.backcolor = Color.Transparent
        If sender Is pExit Then
            sender.Image = My.Resources.exit_w
        End If
    End Sub

    Private Sub pbMMX_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pExit.MouseUp
        If sender Is pExit Then
            sender.backcolor = Color.FromArgb(206, 0, 0)
            sender.Image = My.Resources.exit_n
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim newchat As New frmMessagesNew
        newchat.ShowDialog()
        loadLIST()
    End Sub

    Private Sub loadLIST()
        Me.Cursor = Cursors.WaitCursor
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@iduser"})
        value.AddRange(New Object() {userid})
        sqls.CallSP("spMessagesHD", "inbox", field, value)

        Me.pList.SuspendLayout()
        Me.tlpList.Visible = False
        Me.tlpList.RowCount = 0
        Me.tlpList.RowStyles.Clear()
        Me.tlpList.Controls.Clear()

        Me.tlpList.RowCount = 0
        Me.tlpList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0.0!))
        Dim counter As Integer = 0

        For i As Integer = 0 To sqls.getDataSet("inbox") - 1
            Dim idhd As String = sqls.getDataSet("inbox", i, "idusermessageshd")
            Dim idreceiver As String = sqls.getDataSet("inbox", i, "idreceiver")
            Dim idsender As String = sqls.getDataSet("inbox", i, "idsender")
            Dim receiver As String = sqls.getDataSet("inbox", i, "receiver")
            Dim sender As String = sqls.getDataSet("inbox", i, "sender")
            Dim lastmessage As String = sqls.getDataSet("inbox", i, "lastmessage")
            Dim lastdate As String = sqls.getDataSet("inbox", i, "lastdate")
            Dim isnew As Long = sqls.getDataSet("inbox", i, "ismessagenew")

            Dim btnobj As New ucChatlist()
            If idsender <> userid Then
                If isnew = 0 Then
                    isnew = 1
                End If
                btnobj = New ucChatlist(idhd, lastmessage, idsender, sender, isnew, lastdate)
            ElseIf idsender = userid Then
                btnobj = New ucChatlist(idhd, lastmessage, idreceiver, receiver, isnew, lastdate)
            End If
            btnobj.Name = idhd
            btnobj.Dock = DockStyle.None
            btnobj.Anchor = AnchorStyles.None
            AddHandler btnobj.btnChat.Click, AddressOf inboxClick

            Me.tlpList.RowCount = counter + 1
            Me.tlpList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
            Me.tlpList.Controls.Add(btnobj, 1, counter + 1)
            counter += 1
        Next

        Me.tlpList.RowCount = counter
        Me.tlpList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0.0!))
        Me.tlpList.Size = New System.Drawing.Size(260, (counter * 70) + 0)
        Me.tlpList.Visible = True
        Me.pList.ResumeLayout()
        Me.Cursor = Cursors.Default
    End Sub

    Private idreceiver As String = 0
    Private btnMsg As ucChatlist = Nothing
    Private idmsghd As String = 0
    Private Sub inboxClick(ByVal sender As Object, ByVal e As System.EventArgs)
        idmsghd = CStr(CType(sender, System.Windows.Forms.Button).Tag.ToString.Split("|")(0))
        Me.Cursor = Cursors.WaitCursor
        Me.pList.SuspendLayout()
        Me.tlpList.Visible = False

        btnSemua.Text = "PILIH SEMUA"
        For Each ctrl As Control In tlpList.Controls
            For Each ctrl1 As Control In ctrl.Controls
                If TypeOf (ctrl1) Is System.Windows.Forms.Button Then
                    If CType(ctrl1, System.Windows.Forms.Button).Tag <> "" Then
                        If CType(ctrl1, System.Windows.Forms.Button).Tag.ToString.Split("|")(1) = 1 Then
                            CType(ctrl1, System.Windows.Forms.Button).BackColor = Color.Orange
                        Else
                            CType(ctrl1, System.Windows.Forms.Button).BackColor = Color.Tomato
                        End If
                    End If
                End If
            Next
        Next
        Me.tlpList.Visible = True
        Me.pList.ResumeLayout()

        Panel3.Visible = True

        Me.pListChat.SuspendLayout()
        Me.tlpListChat.Visible = False
        Me.tlpListChat.RowCount = 0
        Me.tlpListChat.RowStyles.Clear()
        Me.tlpListChat.Controls.Clear()

        Me.tlpListChat.RowCount = 0
        Me.tlpListChat.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0.0!))
        Dim counter As Integer = 0
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        idreceiver = CType(sender, System.Windows.Forms.Button).Tag.ToString.Split("|")(2)

        Dim usqls As New SQLs(dbstring)
        usqls.DMLQuery("update sys_usermessageshd set ismessagenew=2 where idreceiver='" & userid & "' and idusermessageshd='" & sender.name & "'", False)

        field.AddRange(New String() {"@idhd"})
        value.AddRange(New Object() {idmsghd})
        sqls.CallSP("spMessagesList", "chat", field, value)

        Dim ctrheight As Integer = 0
        For i As Integer = 0 To sqls.getDataSet("chat") - 1
            Dim id As String = sqls.getDataSet("chat", i, "idusermessagesdt")
            Dim usrsender As String = sqls.getDataSet("chat", i, "sender")
            Dim usrreceiver As String = sqls.getDataSet("chat", i, "receiver")
            Dim tmpidsender As String = sqls.getDataSet("chat", i, "idsender")
            Dim tmpidreceiver As String = sqls.getDataSet("chat", i, "idreceiver")
            Dim msg As String = sqls.getDataSet("chat", i, "message")
            Dim sd As String = sqls.getDataSet("chat", i, "messagedate")
            Dim statusmsg As String = sqls.getDataSet("chat", i, "gcmessagestatus")

            Dim g As Graphics = lblMsg.CreateGraphics()
            lblMsg.Height = CInt(g.MeasureString(msg, lblMsg.Font).Height)
            Dim btnobj As New ucChatbox(id, userid, tmpidreceiver, msg, sd, statusmsg, CInt(g.MeasureString(msg, lblMsg.Font).Height) + 4)
            btnobj.Name = "btnChat" & i
            btnobj.Dock = DockStyle.Fill
            btnobj.Anchor = AnchorStyles.None
            AddHandler btnobj.btnDelete.Click, AddressOf delChatClick
            AddHandler btnobj.btnSelect.Click, AddressOf selChatClick

            Me.tlpListChat.RowCount = counter + 1
            Me.tlpListChat.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, CInt(g.MeasureString(msg, lblMsg.Font).Height) + 4 + 50))
            Me.tlpListChat.Controls.Add(btnobj, 1, counter + 1)
            ctrheight += CInt(g.MeasureString(msg, lblMsg.Font).Height) + 4 + 50
            counter += 1
        Next

        CType(sender, System.Windows.Forms.Button).BackColor = Color.White
        CType(sender, System.Windows.Forms.Button).Image = My.Resources.message
        btnMsg = CType(sender, Control).Parent
        Me.tlpListChat.RowCount = counter
        Me.tlpListChat.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tlpListChat.Size = New System.Drawing.Size(700, ctrheight + 4)
        Me.tlpListChat.Visible = True
        Me.pListChat.ResumeLayout()
        Me.pListChat.AutoScrollPosition = New Point(0, Me.tlpListChat.Height)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub delChatClick(ByVal sender As Object, ByVal e As System.EventArgs)
        If dizMsgbox("Menghapus obrolan ini?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.OK Then
            Dim idmsg As String = sender.name
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("update sys_usermessageshd set isdeleted=1 where idusermessageshd='" & idmsg & "'", False)

            loadLIST()
            inboxClick(btnMsg.btnChat, Nothing)
            For Each ctrl As Control In tlpList.Controls
                If ctrl.Name = btnMsg.Name Then
                    CType(ctrl, ucChatlist).btnChat.BackColor = Color.White
                End If
            Next
        End If
    End Sub

    Private Sub selChatClick(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmMessages_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.DoubleBuffered = True
        Me.tlpListChat.RowCount = 0
        Me.tlpListChat.RowStyles.Clear()
        Me.tlpListChat.Controls.Clear()
        Me.ceSendType.Checked = False

        loadLIST()
        Panel3.Visible = False
        meMessage.EditValue = Nothing
    End Sub

    Private Sub btnSemua_Click(sender As Object, e As EventArgs) Handles btnSemua.Click
        If btnSemua.Text = "PILIH SEMUA" Then
            For Each ctrl As Control In tlpListChat.Controls
                If TypeOf (ctrl) Is ucChatbox Then
                    CType(ctrl, ucChatbox).setSelect() = True
                End If
            Next
            btnSemua.Text = "BATAL PILIH SEMUA"
        ElseIf btnSemua.Text = "BATAL PILIH SEMUA" Then
            For Each ctrl As Control In tlpListChat.Controls
                If TypeOf (ctrl) Is ucChatbox Then
                    CType(ctrl, ucChatbox).setSelect() = False
                End If
            Next
            btnSemua.Text = "PILIH SEMUA"
        End If
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If meMessage.EditValue Is Nothing Then
            dizMsgbox("Pesan kosong", dizMsgboxStyle.Kesalahan, me)
            Exit Sub
        End If
        If meMessage.Text.Length = 0 Then
            dizMsgbox("Pesan kosong", dizMsgboxStyle.Kesalahan, me)
            Exit Sub
        End If

        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        Dim dtsql As New dtsetSQLS(dbstring)

        field.AddRange(New String() {"idusermessageshd", "idsender", "idreceiver", "lastby", "lastdate", "lastmessage", "ismessagenew", "createdby", "createddate"})
        value.AddRange(New Object() {idmsghd, userid, idreceiver, userid, nowTime, meMessage.Text, CLng(1), userid, nowTime})
        dtsql.datasetSave("sys_usermessageshd", idmsghd, field, value, False)

        field.Clear()
        value.Clear()
        field = New List(Of String)
        value = New List(Of Object)
        dtsql = New dtsetSQLS(dbstring)
        Dim idtmp As String = GenerateGUID()

        field.AddRange(New String() {"idusermessagesdt", "idusermessageshd", "idsender", "idreceiver", "message", "messagestatus", "messagedate", "isdeleted", "createdby", "createddate"})
        value.AddRange(New Object() {idtmp, idmsghd, userid, idreceiver, meMessage.Text, CLng(1), nowTime, CLng(0), userid, nowTime})
        dtsql.datasetSave("sys_usermessagesdt", idtmp, field, value, False)


        meMessage.EditValue = Nothing
        loadLIST()
        inboxClick(btnMsg.btnChat, Nothing)
        For Each ctrl As Control In tlpList.Controls
            If ctrl.Name = btnMsg.Name Then
                CType(ctrl, ucChatlist).btnChat.BackColor = Color.White
            End If
        Next
    End Sub

    Private Sub meMessage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles meMessage.KeyPress
        If ceSendType.Checked = True Then
            If Asc(e.KeyChar) = 13 Then
                btnSend_Click(btnSend, Nothing)
            End If
        End If
    End Sub

    Private Sub ceSendType_CheckedChanged(sender As Object, e As EventArgs) Handles ceSendType.CheckedChanged
        If ceSendType.Checked Then
            meMessage.Properties.AcceptsReturn = False
        Else
            meMessage.Properties.AcceptsReturn = True
        End If
    End Sub

    Private Sub btnDeleteSelected_Click(sender As Object, e As EventArgs) Handles btnDeleteSelected.Click
        If dizMsgbox("Menghapus obrolan ini?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.OK Then
            For Each ctrl As Control In tlpListChat.Controls
                If TypeOf (ctrl) Is ucChatbox Then
                    If CType(ctrl, ucChatbox).setSelect = True Then
                        Dim idmsg As String = CType(ctrl, ucChatbox).btnDelete.Tag
                        Dim sqls As New SQLs(dbstring)
                        sqls.DMLQuery("update sys_usermessagesdt set isdeleted=1 where idusermessagesdt='" & idmsg & "'", False)
                    End If
                End If
            Next

            loadLIST()
            inboxClick(btnMsg.btnChat, Nothing)
            For Each ctrl As Control In tlpList.Controls
                If ctrl.Name = btnMsg.Name Then
                    CType(ctrl, ucChatlist).btnChat.BackColor = Color.White
                End If
            Next
        End If
    End Sub

    Private Sub btnDeleteChat_Click(sender As Object, e As EventArgs) Handles btnDeleteChat.Click
        If dizMsgbox("Menghapus obrolan ini?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.OK Then
            For Each ctrl As Control In tlpList.Controls
                If ctrl.Name = btnMsg.Name Then
                    If CType(ctrl, ucChatlist).btnChat.BackColor = Color.White Then
                        Dim idrcv As String = CType(ctrl, ucChatlist).btnChat.Tag.ToString.Split("|")(2)
                        Dim sqls As New SQLs(dbstring)
                        sqls.DMLQuery("update sys_usermessages set isdelet4ed=1 where (idsender='" & userid & "' and idreceiver='" & idrcv & "') or (idreceiver='" & userid & "' and idsender='" & idrcv & "')", False)
                    End If
                End If
            Next
            loadLIST()
        End If
    End Sub

End Class