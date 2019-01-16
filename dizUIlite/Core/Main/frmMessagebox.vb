Public Class frmMessagebox

    Public Sub New(content As String, dizboxstyle As Integer, Optional autoclose As Boolean = False, Optional title As String = "", Optional additionalinfo As String = "")
        InitializeComponent()

        Dim strtitle As String = ""
        If dizboxstyle = 0 Then
            pbIcon.Image = My.Resources.ico_info
            lblTitle.ForeColor = Color.DarkGreen
            tlpForm.BackColor = Color.DarkGreen
            strtitle = IIf(title = "", "Informasi", title)
            btnCancel.Visible = False
            btnOK.Visible = True
        ElseIf dizboxstyle = 1 Then
            pbIcon.Image = My.Resources.ico_warning
            lblTitle.ForeColor = Color.OrangeRed
            tlpForm.BackColor = Color.OrangeRed
            strtitle = IIf(title = "", "Peringatan", title)
            btnCancel.Visible = False
            btnOK.Visible = True
        ElseIf dizboxstyle = 2 Then
            pbIcon.Image = My.Resources.ico_critical
            lblTitle.ForeColor = Color.Tomato
            tlpForm.BackColor = Color.Tomato
            strtitle = IIf(title = "", "Kesalahan", title)
            btnCancel.Visible = False
            btnOK.Visible = True
        ElseIf dizboxstyle = 3 Then
            pbIcon.Image = My.Resources.ico_question
            lblTitle.ForeColor = Color.Purple
            tlpForm.BackColor = Color.Purple
            strtitle = IIf(title = "", "Konfirmasi", title)
            btnCancel.Visible = True
            btnOK.Visible = True
        End If
        lblTitle.Text = strtitle
        lblContent.Text = content

        If additionalinfo = "" Then
            btnDetail.Visible = False
        Else
            btnDetail.Visible = True
        End If

        Dim halfheight As Integer = (Me.Size.Height / 2)
        Dim halfhform As Integer = (Screen.PrimaryScreen.WorkingArea.Height / 2)
        Dim halfwidth As Integer = (Me.Size.Width / 2)
        Dim halfwform As Integer = (Screen.PrimaryScreen.WorkingArea.Width / 2)
        Dim posx As Integer = (halfwform - halfwidth)
        Dim posy As Integer = (halfhform - halfheight)
        Me.Location = New Point(posx, posy)
    End Sub

    Public Sub New(content As String, dizboxstyle As Integer, containerform As Form, Optional autoclose As Boolean = False, Optional title As String = "", Optional additionalinfo As String = "")
        InitializeComponent()

        Dim strtitle As String = ""
        If dizboxstyle = 0 Then
            pbIcon.Image = My.Resources.ico_info
            lblTitle.ForeColor = Color.DarkGreen
            tlpForm.BackColor = Color.DarkGreen
            strtitle = IIf(title = "", "Informasi", title)
            btnCancel.Visible = False
            btnOK.Visible = True
        ElseIf dizboxstyle = 1 Then
            pbIcon.Image = My.Resources.ico_warning
            lblTitle.ForeColor = Color.OrangeRed
            tlpForm.BackColor = Color.OrangeRed
            strtitle = IIf(title = "", "Peringatan", title)
            btnCancel.Visible = False
            btnOK.Visible = True
        ElseIf dizboxstyle = 2 Then
            pbIcon.Image = My.Resources.ico_critical
            lblTitle.ForeColor = Color.Tomato
            tlpForm.BackColor = Color.Tomato
            strtitle = IIf(title = "", "Kesalahan", title)
            btnCancel.Visible = False
            btnOK.Visible = True
        ElseIf dizboxstyle = 3 Then
            pbIcon.Image = My.Resources.ico_question
            lblTitle.ForeColor = Color.Purple
            tlpForm.BackColor = Color.Purple
            strtitle = IIf(title = "", "Konfirmasi", title)
            btnCancel.Visible = True
            btnOK.Visible = True
        End If
        lblTitle.Text = strtitle
        lblContent.Text = content

        If additionalinfo = "" Then
            btnDetail.Visible = False
        Else
            btnDetail.Visible = True
        End If

        If frmMain.Size.Width > Me.Size.Width Then
            Me.Size = New Size(frmMain.Size.Width, Me.Size.Height)
            Dim halfheight As Integer = (Me.Size.Height / 2)
            Dim halfform As Integer = (frmMain.Size.Height / 2)
            Dim posxform As Integer = frmMain.Location.X
            Dim posyform As Integer = frmMain.Location.Y
            Dim posx As Integer = posxform
            Dim posy As Integer = posyform + (halfform - halfheight)
            Me.Location = New Point(posx, posy)
        Else
            Dim halfheight As Integer = (Me.Size.Height / 2)
            Dim halfhform As Integer = (Screen.PrimaryScreen.WorkingArea.Height / 2)
            Dim halfwidth As Integer = (Me.Size.Width / 2)
            Dim halfwform As Integer = (Screen.PrimaryScreen.WorkingArea.Width / 2)
            Dim posx As Integer = (halfwform - halfwidth)
            Dim posy As Integer = (halfhform - halfheight)
            Me.Location = New Point(posx, posy)
        End If
    End Sub

    Private bclose As Boolean = True
    Private Sub frmMessagebox_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = Me.bclose
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        bclose = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        bclose = False
    End Sub

    Private Sub frmMessagebox_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.AcceptButton = btnOK
        Me.CancelButton = btnCancel
        btnOK.DialogResult = Windows.Forms.DialogResult.OK
        btnCancel.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

End Class