Public Class btnJadwalDokter

    Private id As String = ""
    Private note As String = ""
    Private tmpstr As String = ""

    Public Property tmpremarks As String
        Get
            Return tmpstr
        End Get
        Set(value As String)
            tmpstr = value
        End Set
    End Property

    Public Property remarks As String
        Get
            Return note
        End Get
        Set(value As String)
            note = value
        End Set
    End Property

    Public Property iddata As String
        Get
            Return id
        End Get
        Set(value As String)
            id = value
        End Set
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Public Sub buildObj()
        Button2.Text = note
        Button1.Tag = id
        Button2.Tag = id
        Button3.Tag = id

        Button2.Image = My.Resources.bookmarkOrange
        Button2.FlatAppearance.BorderColor = Color.FromArgb(246, 139, 31)
        Button1.Visible = True
        Button3.Visible = True

        If tmpstr = "" Then
            lblRemarks.Text = ""
            lblRemarks.Visible = False
        Else
            lblRemarks.Text = tmpstr
            lblRemarks.Visible = True
        End If
    End Sub

End Class
