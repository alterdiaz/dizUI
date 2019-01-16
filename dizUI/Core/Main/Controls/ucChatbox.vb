Public Class ucChatbox

    Public Sub New(id As String, iduser As String, idreceiver As String, messages As String, senddate As String, statusmsg As String, height As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        btnDelete.Tag = id
        btnSelect.Tag = id

        If idreceiver = iduser Then
            Panel3.BackColor = Color.FromArgb(0, 143, 215)
            Me.Padding = New Padding(40, 4, 4, 42)
            Panel3.Padding = New Padding(1, 1, 8, 1)
        Else
            Panel3.BackColor = Color.FromArgb(64, 0, 64)
            Me.Padding = New Padding(4, 4, 40, 42)
            Panel3.Padding = New Padding(8, 1, 1, 1)
        End If
        Me.Size = New Size(703, height + 4 + 52)
        lblMsg.Text = messages
        lblStatus.Text = statusmsg & " " & senddate
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        If btnSelect.BackColor = Color.White Then
            btnSelect.BackColor = Color.FromArgb(156, 207, 49)
            btnSelect.ForeColor = Color.White
        Else
            btnSelect.BackColor = Color.White
            btnSelect.ForeColor = Color.DimGray
        End If
    End Sub

    Public Property setSelect()
        Get
            Dim retval As Boolean = False
            If btnSelect.BackColor = Color.White Then
                retval = True
            Else
                retval = False
            End If
            Return retval
        End Get
        Set(selCtrl)
            If selCtrl = False Then
                btnSelect.BackColor = Color.FromArgb(156, 207, 49)
                btnSelect.ForeColor = Color.White
            Else
                btnSelect.BackColor = Color.White
                btnSelect.ForeColor = Color.DimGray
            End If
        End Set
    End Property

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim idmsg As String = btnDelete.Tag
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("update sys_usermessagesdt set isdeleted=1 where idusermessagesdt='" & idmsg & "'", False)
    End Sub

End Class
