Public Class frmCOA_generator

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text.Length = 0 Then
            dizMsgbox("Isian Kosong", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()

        Dim listTxt As String()
        listTxt = TextBox1.Lines
        ListBox1.Items.AddRange(listTxt)

        For Each str As String In ListBox1.Items
            If str.Split(vbTab).Length = 2 Then
                ListBox2.Items.Add(str.Split(vbTab)(0))
                ListBox3.Items.Add(str.Split(vbTab)(1))
            End If
        Next

        Panel1.Visible = False
        Panel2.Visible = True
        Panel3.Visible = False
        Panel4.Visible = False
        Panel1.Dock = DockStyle.None
        Panel2.Dock = DockStyle.Fill
        Panel3.Dock = DockStyle.None
        Panel4.Dock = DockStyle.None
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        ListBox3.SelectedIndex = ListBox2.SelectedIndex
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox2.Text.Replace(" ", "").Length = 0 Then
            dizMsgbox("Isian Kosong", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor
        Dim kode As String = ListBox2.SelectedItem.ToString
        Dim cnt As Integer = 1
        For i As Integer = TextBox2.Lines.Length To 1 Step -1
            If ComboBox1.SelectedIndex = 0 Then
                ListBox2.Items.Insert(ListBox2.SelectedIndex + 1, kode & Format(i, "0#"))
            ElseIf ComboBox1.SelectedIndex = 1 Then
                ListBox2.Items.Insert(ListBox2.SelectedIndex + 1, kode & Format(i, "0##"))
            End If
            ListBox3.Items.Insert(ListBox2.SelectedIndex + 1, TextBox2.Lines(i - 1))
        Next
        For i As Integer = 0 To ListBox2.Items.Count - 1
            Dim str As String = ""
            str = ListBox2.Items(i).ToString & vbTab & ListBox3.Items(i).ToString
            TextBox3.Text &= str
            If i <> ListBox2.Items.Count - 1 Then
                TextBox3.Text &= vbCrLf
            End If
        Next
        Me.Cursor = Cursors.Default

        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = True
        Panel1.Dock = DockStyle.None
        Panel2.Dock = DockStyle.None
        Panel3.Dock = DockStyle.None
        Panel4.Dock = DockStyle.Fill
    End Sub

    Private Sub frmCOA_generator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
        Panel1.Visible = True
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Panel1.Dock = DockStyle.Fill
        Panel2.Dock = DockStyle.None
        Panel3.Dock = DockStyle.None
        Panel4.Dock = DockStyle.None

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Clipboard.SetText(TextBox3.Text)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If ListBox2.SelectedIndex < 0 Then
            dizMsgbox("Belum memilih kode rekening", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If

        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = True
        Panel4.Visible = False
        Panel1.Dock = DockStyle.None
        Panel2.Dock = DockStyle.None
        Panel3.Dock = DockStyle.Fill
        Panel4.Dock = DockStyle.None
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox1.Text = Clipboard.GetText
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Panel1.Visible = True
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Panel1.Dock = DockStyle.Fill
        Panel2.Dock = DockStyle.None
        Panel3.Dock = DockStyle.None
        Panel4.Dock = DockStyle.None
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Panel1.Visible = False
        Panel2.Visible = True
        Panel3.Visible = False
        Panel4.Visible = False
        Panel1.Dock = DockStyle.None
        Panel2.Dock = DockStyle.Fill
        Panel3.Dock = DockStyle.None
        Panel4.Dock = DockStyle.None
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        frmCOA_generator_Load(Me, Nothing)
    End Sub

End Class