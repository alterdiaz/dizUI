Public Class ucNotes

    Public Sub New(id As String, title As String, createddate As String, isdeleted As String, isnote As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        btnNotes.Text = createddate & vbCrLf & title
        If isnote = 0 Then
            btnNotes.Image = My.Resources.notes
        ElseIf isnote = 1 Then
            btnNotes.Image = My.Resources.notesu
        ElseIf isnote = 2 Then
            btnNotes.Image = My.Resources.notess
        End If

        btnNotes.Tag = id

        If isdeleted = 1 Then
            btnNotes.BackColor = Color.Gray
            btnNotes.Enabled = False
        Else
            If isnote = 0 Then
                btnNotes.BackColor = Color.GreenYellow
                btnNotes.Enabled = True
            ElseIf isnote = 1 Then
                btnNotes.BackColor = Color.Tomato
                btnNotes.Enabled = True
            ElseIf isnote = 2 Then
                btnNotes.BackColor = Color.Orange
                btnNotes.Enabled = True
            End If
        End If
    End Sub

End Class
