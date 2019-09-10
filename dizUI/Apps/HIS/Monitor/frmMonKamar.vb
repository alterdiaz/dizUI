Public Class frmMonKamar
    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1

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

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim sqls As New SQLs(dbstring)
        sqls.CallSP("spMonKamar", "monkamar")

        gcData.DataSource = sqls.dataTable("monkamar")
        GridColumn22.GroupIndex = 1
        gvData.ExpandAllGroups()
        gvData.BestFitColumns()
        gvData.ViewCaption = "Monitoring Kamar - " & nowTime.Day & " " & NamaBulan(nowTime.Month) & " " & nowTime.Year

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub frmMonKamar_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnRefresh_Click(btnRefresh, Nothing)
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If gvData.RowCount > 0 Then
            Dim exp As New frmExport(gvData)
            tambahChild(exp)
            exp.ShowDialog()
        Else
            dizMsgbox("Data tidak ditemukan", dizMsgboxStyle.Peringatan, Me)
        End If
    End Sub

    Private Sub btnCleaning_Click(sender As Object, e As EventArgs) Handles btnCleaning.Click
        If gvData.FocusedRowHandle > 0 Then
            Dim dr As DataRow = gvData.GetDataRow(gvData.FocusedRowHandle)
            Dim idkamar As String = dr("idkamar")
            Dim statusbed As String = dr("statusbed")
            Dim idlokasi As String = dr("id")

            If statusbed = "5" Then
                dizMsgbox("Kamar belum kosong", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If

            Dim idcomp As String = ""
            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            idcomp = sqlscomp.getDataSet("CompID", 0, "value")

            If idkamar = "0" Then
                Dim dtsqls As New dtsetSQLS(dbstring)
                Dim field As New List(Of String)
                Dim value As New List(Of Object)

                idkamar = GenerateGUID()
                field.AddRange(New String() {"idkamar", "idlokasi", "idregistrasi", "priority", "checkin", "checkout", "statusbed", "isdeleted", "createdby", "createddate", "idcompany"})
                value.AddRange(New Object() {idkamar, idlokasi, "0", 0, DBNull.Value, DBNull.Value, 2, 0, userid, nowTime, idcomp})
                dtsqls.datasetSave("kamar", idkamar, field, value, False)
            Else
                Dim dtsqls As New dtsetSQLS(dbstring)
                Dim field As New List(Of String)
                Dim value As New List(Of Object)

                field.AddRange(New String() {"idkamar", "idlokasi", "idregistrasi", "priority", "checkin", "checkout", "statusbed", "isdeleted", "updatedby", "updateddate", "idcompany"})
                value.AddRange(New Object() {idkamar, idlokasi, "0", 0, DBNull.Value, DBNull.Value, 2, 0, userid, nowTime, idcomp})
                dtsqls.datasetSave("kamar", idkamar, field, value, False)
            End If

            btnRefresh_Click(btnRefresh, Nothing)
        Else
            dizMsgbox("Belum memilih kamar", dizMsgboxStyle.Info, Me)
        End If
    End Sub

    Private Sub btnService_Click(sender As Object, e As EventArgs) Handles btnService.Click
        If gvData.FocusedRowHandle > 0 Then
            Dim dr As DataRow = gvData.GetDataRow(gvData.FocusedRowHandle)
            Dim idkamar As String = dr("idkamar")
            Dim statusbed As String = dr("statusbed")
            Dim idlokasi As String = dr("id")

            If statusbed = "5" Then
                dizMsgbox("Kamar belum kosong", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If

            Dim idcomp As String = ""
            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            idcomp = sqlscomp.getDataSet("CompID", 0, "value")

            If idkamar = "0" Then
                Dim dtsqls As New dtsetSQLS(dbstring)
                Dim field As New List(Of String)
                Dim value As New List(Of Object)

                idkamar = GenerateGUID()
                field.AddRange(New String() {"idkamar", "idlokasi", "idregistrasi", "priority", "checkin", "checkout", "statusbed", "isdeleted", "createdby", "createddate", "idcompany"})
                value.AddRange(New Object() {idkamar, idlokasi, "0", 0, DBNull.Value, DBNull.Value, 4, 0, userid, nowTime, idcomp})
                dtsqls.datasetSave("kamar", idkamar, field, value, False)
            Else
                Dim dtsqls As New dtsetSQLS(dbstring)
                Dim field As New List(Of String)
                Dim value As New List(Of Object)

                field.AddRange(New String() {"idkamar", "idlokasi", "idregistrasi", "priority", "checkin", "checkout", "statusbed", "isdeleted", "updatedby", "updateddate", "idcompany"})
                value.AddRange(New Object() {idkamar, idlokasi, "0", 0, DBNull.Value, DBNull.Value, 4, 0, userid, nowTime, idcomp})
                dtsqls.datasetSave("kamar", idkamar, field, value, False)
            End If

            btnRefresh_Click(btnRefresh, Nothing)
        Else
            dizMsgbox("Belum memilih kamar", dizMsgboxStyle.Info, Me)
        End If
    End Sub

    Private Sub btnReady_Click(sender As Object, e As EventArgs) Handles btnReady.Click
        If gvData.FocusedRowHandle >= 0 Then
            Dim dr As DataRow = gvData.GetDataRow(gvData.FocusedRowHandle)
            Dim idkamar As String = dr("idkamar")
            Dim statusbed As String = dr("statusbed")
            Dim idlokasi As String = dr("id")

            If statusbed = "5" Then
                dizMsgbox("Kamar belum kosong", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If

            Dim idcomp As String = ""
            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            idcomp = sqlscomp.getDataSet("CompID", 0, "value")

            If idkamar = "0" Then
                Dim dtsqls As New dtsetSQLS(dbstring)
                Dim field As New List(Of String)
                Dim value As New List(Of Object)

                idkamar = GenerateGUID()
                field.AddRange(New String() {"idkamar", "idlokasi", "idregistrasi", "priority", "checkin", "checkout", "statusbed", "isdeleted", "createdby", "createddate", "idcompany"})
                value.AddRange(New Object() {idkamar, idlokasi, "0", 0, DBNull.Value, DBNull.Value, 1, 0, userid, nowTime, idcomp})
                dtsqls.datasetSave("kamar", idkamar, field, value, False)
            Else
                Dim dtsqls As New dtsetSQLS(dbstring)
                Dim field As New List(Of String)
                Dim value As New List(Of Object)

                field.AddRange(New String() {"idkamar", "idlokasi", "idregistrasi", "priority", "checkin", "checkout", "statusbed", "isdeleted", "updatedby", "updateddate", "idcompany"})
                value.AddRange(New Object() {idkamar, idlokasi, "0", 0, DBNull.Value, DBNull.Value, 1, 0, userid, nowTime, idcomp})
                dtsqls.datasetSave("kamar", idkamar, field, value, False)
            End If

            btnRefresh_Click(btnRefresh, Nothing)
        Else
            dizMsgbox("Belum memilih kamar", dizMsgboxStyle.Info, Me)
        End If
    End Sub

End Class