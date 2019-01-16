Public Class ucChatlist

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(idmessage As String, message As String, usrid As String, usrname As String, isnew As String, sendingdate As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If message.Length > 20 Then
            btnChat.Text = usrname & vbCrLf & sendingdate & vbCrLf & message.Substring(0, 20) & "..."
        Else
            btnChat.Text = usrname & vbCrLf & sendingdate & vbCrLf & message
        End If
        btnChat.Tag = idmessage & "|" & isnew & "|" & usrid
        If isnew Then
            btnChat.BackColor = Color.Orange
            btnChat.Enabled = True
            btnChat.Image = My.Resources.messagen
        Else
            btnChat.BackColor = Color.Tomato
            btnChat.Enabled = True
            btnChat.Image = My.Resources.message
        End If
    End Sub

End Class
