Public Class frmMonBukuTarif

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

    Private Sub loadUnit()
        Dim sqls As New SQLs(dbstring)
        Dim str As String = ""
        sqls.DMLQuery("select u.idunit as id,u.unit as content from unit u where u.isdeleted=0 and u.idunit not in (select value from sys_appsetting where variable in ('IDSystemUnit','IDVendorUnit')) ", "getunit")

        lueUnit.Properties.DataSource = sqls.dataTable("getunit")
        lueUnit.Properties.ValueMember = "id"
        lueUnit.Properties.DisplayMember = "content"
        If sqls.getDataSet("getunit") = 1 Then
            lueUnit.EditValue = sqls.getDataSet("getunit", 0, "id")
        Else
            lueUnit.EditValue = Nothing
        End If
    End Sub

    Private dttbl As New DataTable
    Private Sub loadgrid(Optional ByVal param As String = "")
        dttbl = New DataTable
        Dim sqls As New SQLs(dbstring) 'iditem,itemtype,type,iditemgrup,itemgrup,kode,item
        sqls.DMLQuery("select distinct i.iditem,i.itemtype,gc.generalcode as type,i.kode,i.item,i.iditemgrup,ig.itemgrup" & param & " from itemharga ih left join item i on ih.iditem=i.iditem left join itemgrup ig on i.iditemgrup=ig.iditemgrup left join sys_generalcode gc on gc.idgeneral=i.itemtype and gc.gctype='ITEMTYPE' order by ig.itemgrup asc,i.item asc where 1=0", "getnull")
        dttbl = sqls.dataTable("getnull")
        gcData.DataSource = dttbl
    End Sub

    Private Sub loadgrid2(ByVal year As String, Optional ByVal param As String = "")
        dttbl = New DataTable
        Dim sqls As New SQLs(dbstring) 'iditem,itemtype,type,iditemgrup,itemgrup,kode,item
        sqls.DMLQuery("select distinct i.iditem,i.itemtype,gc.generalcode as type,i.kode,i.item,i.iditemgrup,ig.itemgrup" & param & " from itemharga ih left join item i on ih.iditem=i.iditem left join itemgrup ig on i.iditemgrup=ig.iditemgrup left join sys_generalcode gc on gc.idgeneral=i.itemtype and gc.gctype='ITEMTYPE' where year(ih.startdate)='" & year & "' order by ig.itemgrup asc,i.item asc", "getnull")
        dttbl = sqls.dataTable("getnull")
        gcData.DataSource = dttbl
    End Sub

    Private cnt As Integer = 1
    Private param As String = ""
    Private param2 As String = ""
    Private Sub frmMonBukuTarif_Load(sender As Object, e As EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If
        gvData.OptionsView.ColumnAutoWidth = False
        loadUnit()

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idkelas,kelas from kelas where isdeleted=0 order by priority asc", "kelas")

        For i As Integer = 0 To sqls.getDataSet("kelas") - 1
            Dim gcharga As New DevExpress.XtraGrid.Columns.GridColumn

            gcharga.AppearanceCell.BackColor = Nothing
            gcharga.AppearanceCell.Options.UseBackColor = True
            gcharga.AppearanceHeader.Options.UseTextOptions = True
            gcharga.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            gcharga.OptionsColumn.AllowEdit = False
            gcharga.OptionsColumn.ReadOnly = True
            gcharga.Width = 100
            gcharga.MaxWidth = 100
            gcharga.MinWidth = 100
            gcharga.Caption = sqls.getDataSet("kelas", i, "kelas")
            gcharga.ColumnEdit = Me.RepositoryItemSpinEdit1
            gcharga.FieldName = sqls.getDataSet("kelas", i, "idkelas")
            gcharga.Name = "gcHarga" & (i + 1)
            gcharga.Tag = sqls.getDataSet("kelas", i, "idkelas")
            gcharga.Visible = True
            gcharga.VisibleIndex = 10 + i

            gvData.Columns.Add(gcharga)
            param &= ",convert(decimal(20,2),0) as '" & sqls.getDataSet("kelas", i, "idkelas") & "'"
            param2 &= ",'" & sqls.getDataSet("kelas", i, "idkelas") & "'"
            cnt += 1
        Next
    End Sub

    Private Sub Reload()
        lueUnit.EditValue = Nothing
        deTanggal.EditValue = Nothing

        Dim kolname As String() = param2.Split(",")
        loadgrid(param)
    End Sub

    Private Sub lueUnit_EditValueChanged(sender As Object, e As EventArgs) Handles lueUnit.EditValueChanged, deTanggal.EditValueChanged
        If lueUnit.EditValue Is Nothing Then
            Exit Sub
        End If
        If deTanggal.EditValue Is Nothing Then
            Exit Sub
        End If

        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        loadgrid2(Format(CDate(deTanggal.EditValue), "yyyy"), param)

        param2 = param2.Replace("convert(decimal(20,2),0) as '", "")
        param2 = param2.Replace("')", "")
        param2 = param2.Replace("'", "")

        Dim kolname As String() = param2.Split(",")
        For i As Integer = 0 To gvData.RowCount - 1
            Dim dr As DataRow = gvData.GetDataRow(i)
            For a As Integer = 0 To kolname.Length - 1
                If kolname(a) <> "" Then
                    dr(kolname(a)) = 0
                    Dim sqlsa As New SQLs(dbstring)
                    sqlsa.DMLQuery("select harga from itemharga where year(startdate)='" & Format(CDate(deTanggal.EditValue), "yyyy") & "' and isdeleted=0 and isvalid=1 and idkelas='" & kolname(a) & "' and idunit='" & lueUnit.EditValue & "' and iditem='" & dr("iditem") & "'", "cekexistharga")
                    If sqlsa.getDataSet("cekexistharga") > 0 Then
                        dr(kolname(a)) = CDec(sqlsa.getDataSet("cekexistharga", 0, "harga"))
                    End If
                End If
            Next
        Next
        gcData.DataSource = dttbl
        gvData.BestFitColumns()
        gvData.ViewCaption = "Buku Tarif Periode " & Format(CDate(deTanggal.EditValue), "yyyy") & " - " & lueUnit.Text

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub btnExport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExport.Click
        If gvData.RowCount > 0 Then
            Dim exp As New frmExport(gvData)
            tambahChild(exp)
            exp.ShowDialog()
        Else
            dizMsgbox("Data tidak ditemukan", dizMsgboxStyle.Peringatan, Me)
        End If
    End Sub

End Class