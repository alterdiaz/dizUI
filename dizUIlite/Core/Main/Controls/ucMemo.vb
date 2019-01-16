Public Class ucMemo
    Private _id As Long = -1
    Private _str As String = ""
    Private _jenis As Long = 1
    Private _isdeleted As Long = 0

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Public Sub buildObj()
        If _jenis = 1 Then
            btnMemo.Image = My.Resources.memo
        ElseIf _jenis = 2 Then
            btnMemo.Image = My.Resources.recent
        End If
        btnMemo.Text = _str
        btnMemo.Tag = _id

        If _isdeleted = 1 Then
            btnMemo.BackColor = Color.Gray
            btnMemo.Enabled = False
        End If
    End Sub

    Public Property isdeleted As Long
        Get
            Return _isdeleted
        End Get
        Set(value As Long)
            _isdeleted = value
        End Set
    End Property

    Public Property id As Long
        Get
            Return _id
        End Get
        Set(value As Long)
            _id = value
        End Set
    End Property

    Public Property str As String
        Get
            Return _str
        End Get
        Set(value As String)
            _str = value
        End Set
    End Property

    Public Property jenis As Long
        Get
            Return _jenis
        End Get
        Set(value As Long)
            _jenis = value
        End Set
    End Property

End Class
