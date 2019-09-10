Public Class frmNewProduct
    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1

    'API functions   
    <System.Runtime.InteropServices.DllImport("user32.dll", CharSet:=System.Runtime.InteropServices.CharSet.Auto, SetLastError:=True, ExactSpelling:=True)> _
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    Private Sub lblTitle_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitle.MouseDown
        'This code can be used in the MouseDown event of any control(s) you want to be able to move your form with   
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0&)
    End Sub

    Private Sub pExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pExit.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Dispose()
    End Sub

    Private Sub pbMMX_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pExit.MouseDown
        If sender Is pExit Then
            sender.backcolor = justRead
            sender.Image = My.Resources.exit_n
        End If
    End Sub

    Private Sub pbMMX_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pExit.MouseEnter
        If sender Is pExit Then
            sender.backcolor = Color.FromArgb(206, 0, 0)
            sender.Image = My.Resources.exit_n
        End If
    End Sub

    Private Sub pbMMX_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pExit.MouseLeave
        sender.backcolor = Color.Transparent
        If sender Is pExit Then
            sender.Image = My.Resources.exit_w
        End If
    End Sub

    Private Sub pbMMX_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pExit.MouseUp
        If sender Is pExit Then
            sender.backcolor = Color.FromArgb(206, 0, 0)
            sender.Image = My.Resources.exit_n
        End If
    End Sub

    'Private mystring As String = ""
    Private mysite As String = ""
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        getRegex(dbstring)
        idData = "-1"
        Dim lite As New SQLi(dblite)
        'lite.DMLQuery("select databasename || '|' || ipserver || '|' || port || '|' || username || '|' || password as dbstring from dbconn where dbtype='SQLS' and dblocation='DOMAIN'", "getdbstring")
        lite.DMLQuery("select siteurl from siteconn where active=1 order by idsiteconn desc", "getdbstring")
        If lite.getDataSet("getdbstring") > 0 Then
            'mystring = lite.getDataSet("getdbstring", 0, "dbstring")
            mysite = lite.getDataSet("getdbstring", 0, "siteurl")
            mysite = CheckAndRepairValidURL(mysite)
        End If

        'Dim sqls As New SQLs(mystring)
        'sqls.DMLQuery("select convert(varchar,getdate(),105) as tanggal,convert(varchar,getdate(),108) as waktu", "content")
        Dim json_result As String = ""
        Dim table As DataTable = Nothing
        Dim mparam As New List(Of String)
        Dim mvalue As New List(Of String)
        mparam.AddRange(New String() {"param", "tkey1", "tkey2"})
        mvalue.AddRange(New String() {"currentdatetime", tmptokenkey1, tmptokenkey2})
        json_result = modCore.HttpPOSTRequestSelect(mysite & "Core", mparam, mvalue)
        table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)
        If table.Rows.Count > 0 Then 'strvalue.Contains("ERROR") = False Then
            Dim tmptgl As String = table.Rows(0).Item("tanggal") 'strvalue.Split(" ")(0)
            Dim tmpwaktu As String = table.Rows(0).Item("waktu") 'strvalue.Split(" ")(1)
            tmpnowTime = Strdatetime2Datetime(tmptgl & " " & tmpwaktu)
        Else
            tmpnowTime = nowTime
        End If

        'sqls = New SQLs(mystring)
        'sqls.DMLQuery("select top 1 idtoken,tokenkey1,tokenkey2 from token order by createddate desc", "content")
        If table IsNot Nothing Then table.Clear()
        json_result = modCore.HttpPOSTRequestSelect(mysite & "CurrentToken")
        table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)
        If table Is Nothing Then
            tmpidtoken = "E82EC129-868C-4FEB-9AEB-0ADB46428F1E"
            tmptokenkey1 = "ABF"
            tmptokenkey2 = "123"
        Else
            If table.Rows.Count > 0 Then 'IsNumeric(strvalue) = False Then 'MYs.getDataSet("token") > 0 Then
                tmpidtoken = table.Rows(0).Item("idtoken")
                tmptokenkey1 = table.Rows(0).Item("tokenkey1")
                tmptokenkey2 = table.Rows(0).Item("tokenkey2")
                'MYs.getDataSet("token", 0, "idtoken")
                'MYs.getDataSet("token", 0, "tokenkey1")
                'MYs.getDataSet("token", 0, "tokenkey2")
            Else
                tmpidtoken = "E82EC129-868C-4FEB-9AEB-0ADB46428F1E"
                tmptokenkey1 = "ABF"
                tmptokenkey2 = "123"
            End If
        End If
        idtoken = tmpidtoken
        tokenkey1 = tmptokenkey1
        tokenkey2 = tmptokenkey2

        json_result = ""
        If table IsNot Nothing Then table.Clear()
        mparam.Clear()
        mvalue.Clear()
        mparam.AddRange(New String() {"param", "value", "tkey1", "tkey2"})
        mvalue.AddRange(New String() {"cekproducttype", "", tmptokenkey1, tmptokenkey2})
        json_result = modCore.HttpPOSTRequestSelect(mysite & "ProductType", mparam, mvalue)
        table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)

        lueJenis.Properties.DataSource = table
        lueJenis.Properties.ValueMember = "idproducttype"
        lueJenis.Properties.DisplayMember = "producttype"
        lueJenis.EditValue = Nothing

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idproducttype,producttype from sys_appproducttype where idcompany='" & modCore.idcompany & "'", "cekpt")
        gcData.DataSource = sqls.dataTable("cekpt")
        gvData.BestFitColumns()
        'SQLs = New SQLs(mystring)
        'SQLs.DMLQuery("SELECT idproducttype as id,producttype as content,remarks FROM producttype where isnull(isdeleted,0)=0 order by producttype asc", "content")
    End Sub

    Private Function cekIsian() As Boolean
        Dim retval As Boolean = False
        If lueJenis.EditValue IsNot Nothing Then
            retval = True
        End If
        'For i As Integer = 0 To gvData.RowCount - 1
        '    Dim dr As DataRow = gvData.GetRow(i)
        '    If dr("cek") = "1" Then
        '        retval = True
        '        Exit For
        '    End If
        'Next
        Return retval
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Cursor = Cursors.WaitCursor
        'If cekIsian() = False Then
        '    dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
        '    Me.Cursor = Cursors.Default
        '    Exit Sub
        'End If

        Dim json_result As String = ""
        Dim table As DataTable = Nothing
        Dim mparam As New List(Of String)
        Dim mvalue As New List(Of String)
        Dim cek As Boolean = False

        'If table IsNot Nothing Then table.Clear()
        'mparam.Clear()
        'mvalue.Clear()
        'json_result = ""
        'mparam.AddRange(New String() {"param", "value", "tkey1", "tkey2", "idcompany", "idproducttype"})
        'mvalue.AddRange(New String() {"cekcompprotype", "", tmptokenkey1, tmptokenkey2, modCore.idcompany, lueJenis.EditValue})
        'json_result = modCore.HttpPOSTRequestSelect(mysite & "CompanyProductType", mparam, mvalue)

        'If json_result.Length > 2 Then
        'table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)
        '    If table IsNot Nothing Then table.Clear()
        '    mparam.Clear()
        '    mvalue.Clear()
        '    json_result = ""
        '    mparam.AddRange(New String() {"param", "value", "tkey1", "tkey2", "idcompanyproduct", "idproducttype"})
        '    mvalue.AddRange(New String() {"hapuscompprotype", "", tmptokenkey1, tmptokenkey2, modCore.idcompanyproduct, lueJenis.EditValue})
        '    json_result = modCore.HttpPOSTRequestSelect(mysite & "CompanyProductType", mparam, mvalue)

        '    If json_result = "true" Then
        'If table IsNot Nothing Then table.Clear()
        '        mparam.Clear()
        '        mvalue.Clear()
        '        json_result = ""
        '        mparam.AddRange(New String() {"param", "value", "tkey1", "tkey2", "idcompanyproduct", "idproducttype"})
        '        mvalue.AddRange(New String() {"baru", GenerateGUID(), tmptokenkey1, tmptokenkey2, modCore.idcompanyproduct, lueJenis.EditValue})
        '        json_result = modCore.HttpPOSTRequestInsert(mysite & "CompanyProductType", mparam, mvalue)
        '        'table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)
        '        If json_result = "true" Then 'table.Rows.Count > 0 Then
        '            cek = True
        '        Else
        '            Exit Sub
        '        End If
        '    End If
        'End If

        cek = True
        Me.Cursor = Cursors.Default
        If cek = True Then
            Dim lite As New SQLi(dblite)
            lite.DMLQuery("delete from companyproducttype where idcompany='" & modCore.idcompany & "'", False)
            For i As Integer = 0 To gvData.RowCount - 1
                'If gvData.GetDataRow(i).Item("cek").ToString = "1" Then
                lite.DMLQuery("insert into companyproducttype(idcompanyproducttype,idcompanyproduct,idcompany,idproducttype,producttype) values('" & GenerateGUID() & "','0','" & modCore.idcompany & "','" & gvData.GetDataRow(i).Item("idproducttype").ToString & "','" & gvData.GetDataRow(i).Item("producttype").ToString & "')", False)
                'End If
            Next
            If lueJenis.EditValue IsNot Nothing Then
                lite.DMLQuery("insert into companyproducttype(idcompanyproducttype,idcompanyproduct,idcompany,idproducttype,producttype) values('" & GenerateGUID() & "','0','" & modCore.idcompany & "','" & lueJenis.EditValue & "','" & lueJenis.Text & "')", False)
            End If

            Dim sqlss As New SQLs(dbstring)
            sqlss.DMLQuery("delete from sys_appproducttype where idcompany='" & modCore.idcompany & "'", False)
            For i As Integer = 0 To gvData.RowCount - 1
                'If gvData.GetDataRow(i).Item("cek").ToString = "1" Then
                sqlss.DMLQuery("insert into sys_appproducttype(idappproducttype,idcompanyproduct,idcompany,idproducttype,producttype) values('" & GenerateGUID() & "','0','" & modCore.idcompany & "','" & gvData.GetDataRow(i).Item("idproducttype").ToString & "','" & gvData.GetDataRow(i).Item("producttype").ToString & "')", False)
                'End If
            Next
            If lueJenis.EditValue IsNot Nothing Then
                sqlss.DMLQuery("insert into sys_appproducttype(idappproducttype,idcompanyproduct,idcompany,idproducttype,producttype) values('" & GenerateGUID() & "','0','" & modCore.idcompany & "','" & lueJenis.EditValue & "','" & lueJenis.Text & "')", False)
            End If

            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select idproducttype,producttype from sys_appproducttype where idcompany='" & modCore.idcompany & "'", "cekpt")
            gcData.DataSource = sqls.dataTable("cekpt")
            gvData.BestFitColumns()

            dizMsgbox("Data Jenis Produk tersimpan", dizMsgboxStyle.Info, Me)
        End If
    End Sub

    Private statData As statusData = statusData.Baru
    Private idData As String = "-1"

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If gvData.FocusedRowHandle < 0 Then
            dizMsgbox("Jenis Produk belum dipilih", dizMsgboxStyle.Peringatan, me)
            Exit Sub
        End If

        Dim json_result As String = ""
        Dim table As DataTable = Nothing
        Dim mparam As New List(Of String)
        Dim mvalue As New List(Of String)

        'If table IsNot Nothing Then table.Clear()
        'mparam.Clear()
        'mvalue.Clear()
        'json_result = ""
        'mparam.AddRange(New String() {"param", "value", "tkey1", "tkey2", "idcompany", "idproducttype"})
        'mvalue.AddRange(New String() {"hapuscompprotype", "", tmptokenkey1, tmptokenkey2, modCore.idcompany, gvData.GetDataRow(gvData.FocusedRowHandle).Item("idproducttype").ToString})
        'json_result = modCore.HttpPOSTRequestSelect(mysite & "CompanyProductType", mparam, mvalue)
        'If json_result = "true" Then
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("delete from sys_appproducttype where idproducttype='" & gvData.GetDataRow(gvData.FocusedRowHandle).Item("idproducttype").ToString & "' and idcompanyproduct='" & modCore.idcompany & "'", False)

        Dim lite As New SQLi(dbstring)
        lite.DMLQuery("delete from companyproducttype where idproducttype='" & gvData.GetDataRow(gvData.FocusedRowHandle).Item("idproducttype").ToString & "' and idcompanyproduct='" & modCore.idcompany & "'", False)

        sqls.DMLQuery("select idproducttype,producttype from sys_appproducttype where idcompany='" & modCore.idcompany & "'", "cekpt")
        gcData.DataSource = sqls.dataTable("cekpt")
            gvData.BestFitColumns()

            dizMsgbox("Data Jenis Produk terhapus", dizMsgboxStyle.Info, Me)
        'End If
    End Sub

End Class