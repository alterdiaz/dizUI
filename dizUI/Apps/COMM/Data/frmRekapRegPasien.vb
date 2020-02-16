Public Class frmRekapRegPasien
    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    'API functions   
    <System.Runtime.InteropServices.DllImport("user32.dll", CharSet:=System.Runtime.InteropServices.CharSet.Auto, SetLastError:=True, ExactSpelling:=True)>
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
        splashClosed = True
        Me.Dispose()
    End Sub

    Private Sub pMaximize_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pMaximize.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        ElseIf Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub pMinimize_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pMinimize.Click
        Me.WindowState = FormWindowState.Minimized
        Me.Visible = False
        Me.Hide()
    End Sub

    Private Sub pbMMX_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pMinimize.MouseDown, pMaximize.MouseDown, pExit.MouseDown
        If sender Is pExit Then
            sender.backcolor = justRead
            sender.Image = My.Resources.exit_n
        ElseIf sender Is pMaximize Then
            sender.backcolor = canWrite
            sender.Image = My.Resources.max_n
        ElseIf sender Is pMinimize Then
            sender.backcolor = canWrite
            sender.Image = My.Resources.min_n
        End If
    End Sub

    Private Sub pbMMX_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pMinimize.MouseEnter, pMaximize.MouseEnter, pExit.MouseEnter
        If sender Is pExit Then
            sender.backcolor = Color.FromArgb(206, 0, 0)
            sender.Image = My.Resources.exit_n
        ElseIf sender Is pMaximize Then
            sender.backcolor = Color.Lime
            sender.Image = My.Resources.max_n
        ElseIf sender Is pMinimize Then
            sender.backcolor = Color.Lime
            sender.Image = My.Resources.min_n
        End If
    End Sub

    Private Sub pbMMX_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pMinimize.MouseLeave, pMaximize.MouseLeave, pExit.MouseLeave
        sender.backcolor = Color.Transparent
        If sender Is pExit Then
            sender.Image = My.Resources.exit_w
        ElseIf sender Is pMaximize Then
            sender.Image = My.Resources.max_w
        ElseIf sender Is pMinimize Then
            sender.Image = My.Resources.min_w
        End If
    End Sub

    Private Sub pbMMX_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pMinimize.MouseUp, pMaximize.MouseUp, pExit.MouseUp
        If sender Is pExit Then
            sender.backcolor = Color.FromArgb(206, 0, 0)
            sender.Image = My.Resources.exit_n
        ElseIf sender Is pMaximize Then
            sender.backcolor = Color.Lime
            sender.Image = My.Resources.max_n
        ElseIf sender Is pMinimize Then
            sender.backcolor = Color.Lime
            sender.Image = My.Resources.min_n
        End If
    End Sub

    Private Sub frmRekapRegPasien_Load(sender As Object, e As EventArgs) Handles Me.Load
        getRegex(dbstring)
        pMinimize.Visible = False
        pMaximize.Visible = False
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        deTanggal.EditValue = Nothing
    End Sub

    Private Sub deTanggal_EditValueChanged(sender As Object, e As EventArgs) Handles deTanggal.EditValueChanged
        If deTanggal.EditValue Is Nothing Then
            meRemarks.EditValue = ""
            Exit Sub
        End If
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select distinct d.department from registrasi r left join department d on r.iddepartment=d.iddepartment where convert(varchar,r.registrasidate,105)='" & Format(CDate(deTanggal.EditValue), "dd-MM-yyyy") & "' order by d.department", "dept")

        sqls.DMLQuery("select r.department,r.spesialis+' '+r.paramedis+' '+convert(varchar,r.counter)+'px' as remarks from (select d.department,case when isnull(s.nama,'-')='-' and r.ismcu=0 then isnull(s.nama,'Umum') when isnull(s.nama,'-')='-' and r.ismcu=1 then isnull(s.nama,'Umum MCU') else s.nama end as spesialis,p.nama as paramedis,r.ismcu,count(r.idregistrasi) as counter from registrasi r left join department d on r.iddepartment=d.iddepartment left join paramedis p on r.iddokterruangan=p.idparamedis left join spesialis s on r.idspesialisruangan=s.idspesialis where r.isdeleted=0 and convert(varchar,r.registrasidate,105)='" & Format(CDate(deTanggal.EditValue), "dd-MM-yyyy") & "' group by d.department,s.nama,p.nama,r.ismcu) r order by r.department,r.spesialis,r.paramedis", "getdata")
        Dim remarks As String = ""

        Dim dept As String = ""
        For i As Integer = 0 To sqls.getDataSet("getdata") - 1
            If dept <> sqls.getDataSet("getdata", i, "department") Then
                remarks &= sqls.getDataSet("getdata", i, "department")
                remarks &= vbCrLf

                dept = sqls.getDataSet("getdata", i, "department")
            End If
            remarks &= sqls.getDataSet("getdata", i, "remarks")

            If i <> sqls.getDataSet("getdata") - 1 Then
                remarks &= vbCrLf
            End If
        Next
        If sqls.getDataSet("getdata") = 0 Then
            meRemarks.EditValue = ""
        Else
            meRemarks.EditValue = remarks
        End If
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        If meRemarks.EditValue = "" Then
            Exit Sub
        End If
        Clipboard.SetText(meRemarks.EditValue)
        dizMsgbox("Data telah disalin", dizMsgboxStyle.Info, Me)
    End Sub

    Dim GripDrag As Boolean
    Dim InitialSizeX As Integer
    Dim InitialSizeY As Integer

    Private Sub presize_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pResize.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then 'If the control is being left-clicked
            GripDrag = True 'Confirms the grip is ready to be dragged
            InitialSizeX = Me.Width 'Sets the initial width
            InitialSizeY = Me.Height 'Sets the initial height
        End If
    End Sub

    Private Sub presize_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pResize.MouseMove
        If GripDrag = True Then
            'Me.Width = InitialSizeX + (Windows.Forms.Cursor.Position.X - (Me.Width + Me.Location.X)) 'Increases the width of the form by the amount the grip has been dragged towards the right
            Me.Height = InitialSizeY + (Windows.Forms.Cursor.Position.Y - (Me.Height + Me.Location.Y)) 'Increases the height of the form by the amount the grip has been dragged downward

            InitialSizeX = Me.Width 'Resets the value to the form's current width
            InitialSizeY = Me.Height 'Resets the value to the form's current height

            Me.Refresh()
            Application.DoEvents()
        End If
    End Sub

    Private Sub presize_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pResize.MouseUp
        GripDrag = False 'Confirms the grip is no longer being dragged
    End Sub

End Class