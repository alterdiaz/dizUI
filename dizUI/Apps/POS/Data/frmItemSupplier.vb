Public Class frmItemSupplier
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

    Private Sub loadGrid()
        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select i.kode,i.item,isu.disctype,dt.generalcode as disctypestr,isu.discpersen,isu.price,isu.discamount,isu.idsupplier,s.nama,isu.isdeleted,gc.generalcode as statdata from itemsupplier isu left join item i on isu.iditem=i.iditem left join businesspartner s on isu.idsupplier=s.idbusinesspartner and s.businesspartnertype=1 left join sys_generalcode dt on isu.disctype=dt.idgeneral and dt.gctype='DISCTYPE' left join sys_generalcode gc on isu.isdeleted=gc.idgeneral and gc.gctype='DELETE'", "data")
        gcData.DataSource = mysqls.dataTable("data")
        gvData.BestFitColumns()
    End Sub

    Private Sub loadLOV()
        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='DISCTYPE'", "type")
        lueType.Properties.DataSource = mysqls.dataTable("type")
        lueType.Properties.ValueMember = "id"
        lueType.Properties.DisplayMember = "content"

        mysqls.DMLQuery("select iditem as id,item as content from item where isdeleted=0 and itemtype<>3", "item")
        lueItem.Properties.DataSource = mysqls.dataTable("item")
        lueItem.Properties.ValueMember = "id"
        lueItem.Properties.DisplayMember = "content"

        mysqls.DMLQuery("select idbusinesspartner as id,nama as content from businesspartner where businesspartnertype=1 and isdeleted=0", "bp")
        lueSupplier.Properties.DataSource = mysqls.dataTable("bp")
        lueSupplier.Properties.ValueMember = "id"
        lueSupplier.Properties.DisplayMember = "content"
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        loadGrid()

        kosongkanIsian(tlpField)

        teKode.Properties.Appearance.BackColor = justRead
        teKode.Properties.ReadOnly = True
        lueSupplier.Properties.Appearance.BackColor = canWrite
        lueSupplier.Properties.ReadOnly = False

        seDiscPercent.Properties.ReadOnly = True
        seDiscPercent.Properties.Appearance.BackColor = justRead
        seDiscAmount.Properties.ReadOnly = True
        seDiscAmount.Properties.Appearance.BackColor = justRead

        btnNew.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnDelete.Text = "HAPUS"
        statData = statusData.Baru
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If checkEntry(tlpField) = False Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.peringatan, Me)
            Exit Sub
        End If
        If sePrice.Value = 0 Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.peringatan, Me)
            Exit Sub
        End If
        If lueType.EditValue = 1 And seDiscPercent.Value = 0 Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.peringatan, Me)
            Exit Sub
        End If
        If lueType.EditValue = 2 And seDiscAmount.Value = 0 Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.peringatan, Me)
            Exit Sub
        End If
        If statData = statusData.Baru Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select iditem from itemsupplier where idsupplier='" & lueSupplier.EditValue & "' and iditem='" & lueItem.EditValue & "' and isdeleted=0", "exist")
            If sqls.getDataSet("exist") = 0 Then
                idData = "-1"
            Else
                dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.info, Me)
                lueItem.Focus()
                Exit Sub
            End If
        ElseIf statData = statusData.Edit Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select iditem from itemsupplier where idsupplier='" & lueSupplier.EditValue & "' and iditem='" & lueItem.EditValue & "' and isdeleted=0 and iditemsupplier<>'" & idData & "'", "exist")
            If sqls.getDataSet("exist") > 0 Then
                dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.info, Me)
                lueItem.Focus()
                Exit Sub
            End If
        End If

        Dim dtSQL As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        If statData = statusData.Baru Then
            idData = GenerateGUID()
            field.AddRange(New String() {"iditemsupplier", "iditem", "idsupplier", "disctype", "discpersen", "discamount", "price", "isdeleted", "createdby", "createddate"})
            value.AddRange(New Object() {idData, lueItem.EditValue, lueSupplier.EditValue, lueType.EditValue, seDiscPercent.Value, seDiscAmount.Value, sePrice.Value, 0, userid, nowTime})
        Else
            field.AddRange(New String() {"iditemsupplier", "disctype", "discpersen", "discamount", "price", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, lueType.EditValue, seDiscPercent.Value, seDiscAmount.Value, sePrice.Value, userid, nowTime})
        End If

        If dtSQL.datasetSave("itemsupplier", idData, field, value, False) = True Then
            dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
            isiLog(userid, dbstring, field, value, "itemsupplier")

            btnNew_Click(Me, Nothing)
        Else
            dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Kesalahan, Me)
        End If
    End Sub

    Private statData As statusData = statusData.Baru
    Private idData As String = "-1"

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim retval As Boolean = False
        Dim sqls As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        If btnDelete.Text = "HAPUS" Then
            field.AddRange(New String() {"iditemsupplier", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, 1, userid, nowTime})
            retval = sqls.datasetSave("itemsupplier", idData, field, value, False)
            If retval Then
                btnDelete.Text = "AKTIF"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        Else
            field.AddRange(New String() {"iditemsupplier", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, 0, userid, nowTime})
            retval = sqls.datasetSave("itemsupplier", idData, field, value, False)
            If retval Then
                btnDelete.Text = "HAPUS"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        End If
        isiLog(userid, dbstring, field, value, "itemsupplier")
        btnNew_Click(Me, Nothing)
    End Sub

    Private isdeleted As String = ""
    Private Sub gvData_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged
        Try
            Dim dcol As DataRow = gvData.GetDataRow(e.FocusedRowHandle)
            lueSupplier.Properties.Appearance.BackColor = justRead
            lueSupplier.Properties.ReadOnly = True
            teKode.Properties.Appearance.BackColor = justRead
            teKode.Properties.ReadOnly = True

            teKode.Text = dcol("kode")
            lueItem.EditValue = dcol("iditem")
            lueType.EditValue = dcol("disctype")
            seDiscPercent.Value = dcol("discpersen")

            lueSupplier.EditValue = dcol("idsupplier")
            sePrice.Value = dcol("price")
            seDiscAmount.Value = dcol("discamount")

            idData = dcol("iditemsupplier")
            statData = statusData.Edit
            isdeleted = dcol("isdeleted")
            If isdeleted = 1 Then
                btnDelete.Text = "AKTIF"
            Else
                btnDelete.Text = "HAPUS"
            End If

            btnNew.Enabled = True
            btnSave.Enabled = True
            btnDelete.Enabled = True
        Catch ex As Exception
            btnNew_Click(Me, Nothing)
        End Try
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        loadLOV()

        checkFieldMaxLength(dbstring, tlpField, "itemsupplier")
        btnNew_Click(Me, Nothing)
    End Sub

    Private Sub lueItem_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueItem.EditValueChanged
        If lueItem.EditValue Is Nothing Then
            teKode.Text = "XXXXX-XXXX"
            Exit Sub
        End If

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select kode from item where iditem='" & lueItem.EditValue & "'", "getkode")
        teKode.Text = sqls.getDataSet("getkode", 0, "kode")
    End Sub

    Private Sub lueType_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueType.EditValueChanged
        If lueType.EditValue Is Nothing Then
            seDiscPercent.Properties.ReadOnly = True
            seDiscPercent.Properties.Appearance.BackColor = justRead
            seDiscAmount.Properties.ReadOnly = True
            seDiscAmount.Properties.Appearance.BackColor = justRead
            Exit Sub
        End If
        If lueType.EditValue = 1 Then
            seDiscPercent.Properties.ReadOnly = False
            seDiscPercent.Properties.Appearance.BackColor = canWrite
            seDiscAmount.Properties.ReadOnly = True
            seDiscAmount.Properties.Appearance.BackColor = justRead
        ElseIf lueType.EditValue = 2 Then
            seDiscPercent.Value = 0
            seDiscPercent.Properties.ReadOnly = True
            seDiscPercent.Properties.Appearance.BackColor = justRead
            seDiscAmount.Properties.ReadOnly = False
            seDiscAmount.Properties.Appearance.BackColor = canWrite
        End If
    End Sub

    Private Sub seDiscPercent_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seDiscPercent.ValueChanged
        If lueType.EditValue = 1 Then
            If seDiscPercent.Value > 0 Then
                seDiscAmount.Value = (seDiscPercent.Value / 100) * sePrice.Value
            Else
                seDiscAmount.Value = 0
            End If
        End If
    End Sub

    Private Sub sePrice_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sePrice.ValueChanged
        If lueType.EditValue = 1 Then
            If seDiscPercent.Value > 0 Then
                seDiscAmount.Value = (seDiscPercent.Value / 100) * sePrice.Value
            Else
                seDiscAmount.Value = 0
            End If
        End If
    End Sub

End Class