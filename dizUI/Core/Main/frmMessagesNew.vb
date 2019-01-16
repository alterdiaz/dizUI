Public Class frmMessagesNew

    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1

    'API functions   
    <System.Runtime.InteropServices.DllImport("user32.dll", CharSet:=System.Runtime.InteropServices.CharSet.Auto, SetLastError:=True, ExactSpelling:=True)> _
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    Private Sub lblTitle_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitle.MouseDown
        'This code can be used in the MouseDown event of any control(s) you want to be able to move your form with   
        'If Me.WindowState = FormWindowState.Normal Then
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0&)
        'End If
    End Sub

    Private Sub pExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pExit.Click
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

    Private Sub loadLOV()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select iduser as id,username as content from sys_user where isuseronline=0 order by username asc", "getuser")
        lueUsername.Properties.DataSource = sqls.dataTable("getuser")
        lueUsername.Properties.ValueMember = "id"
        lueUsername.Properties.DisplayMember = "content"
        lueUsername.EditValue = Nothing
    End Sub

    Private Sub frmMessagesNew_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadLOV()
        meMessage.Text = ""
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim iskosong As Boolean = False
        If lueUsername.EditValue Is Nothing Then
            iskosong = True
        End If
        If meMessage.Text = "" Then
            iskosong = True
        End If
        If iskosong = True Then
            dizMsgbox("Isian belum benar", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        Dim dtsqls As New dtsetSQLS(dbstring)
        Dim sqls As New SQLs(dbstring)
        Dim idhd As String = GenerateGUID()
        field.AddRange(New String() {"idusermessageshd", "idsender", "idreceiver", "messagetitle", "remarks", "isgroupmessage", "isdeleted", "lastby", "lastdate", "lastmessage", "ismessagenew", "createdby", "createddate"})
        value.AddRange(New Object() {idhd, userid, lueUsername.EditValue, teTitle.Text, "-", 2, 0, userid, nowTime, meMessage.Text, 1, userid, nowTime})
        dtsqls.datasetSave("sys_usermessageshd", idhd, field, value, False)

        Dim idtmp As String = GenerateGUID()
        field.Clear()
        value.Clear()
        field = New List(Of String)
        value = New List(Of Object)
        dtsqls = New dtsetSQLS(dbstring)

        field.AddRange(New String() {"idusermessagesdt", "idusermessageshd", "idsender", "idreceiver", "message", "messagestatus", "messagedate", "isdeleted", "createdby", "createddate"})
        value.AddRange(New Object() {idtmp, idhd, userid, lueUsername.EditValue, meMessage.Text, 1, nowTime, 0, userid, nowTime})
        dtsqls.datasetSave("sys_usermessagesdt", idtmp, field, value, False)

        dizMsgbox("Obrolan baru sudah terkirim", dizMsgboxStyle.Info, Me)
        Me.Dispose()
    End Sub

End Class