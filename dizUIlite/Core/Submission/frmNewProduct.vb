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

    Private mystring As String = ""
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        getRegex(dbstring)
        idData = -1
        Dim lite As New SQLi(dblite)
        lite.DMLQuery("select databasename || '|' || ipserver || '|' || port || '|' || username || '|' || password as dbstring from dbconn where dbtype='SQLS' and dblocation='DOMAIN'", "getdbstring")
        If lite.getDataSet("getdbstring") > 0 Then
            mystring = lite.getDataSet("getdbstring", 0, "dbstring")
        End If

        Dim sqls As New SQLs(mystring)
        sqls.DMLQuery("select convert(varchar,getdate(),105) as tanggal,convert(varchar,getdate(),108) as waktu", "content")
        If sqls.getDataSet("content") > 0 Then
            Dim tmptgl As String = sqls.getDataSet("content", 0, "tanggal")
            Dim tmpwaktu As String = sqls.getDataSet("content", 0, "waktu")
            tmpnowTime = New Date(tmptgl.Split("-")(2), tmptgl.Split("-")(1), tmptgl.Split("-")(0), tmpwaktu.Split(":")(0), tmpwaktu.Split(":")(1), tmpwaktu.Split(":")(2))
        Else
            tmpnowTime = Now
        End If

        sqls = New SQLs(mystring)
        sqls.DMLQuery("select top 1 idtoken,tokenkey1,tokenkey2 from token order by createddate desc", "content")
        If sqls.getDataSet("content") > 0 Then
            tmpidtoken = sqls.getDataSet("content", 0, "idtoken")
            tmptokenkey1 = sqls.getDataSet("content", 0, "tokenkey1") 
            tmptokenkey2 = sqls.getDataSet("content", 0, "tokenkey2") 
        Else
            tmpidtoken = 1
            tmptokenkey1 = "ABF"
            tmptokenkey2 = "123"
        End If
        idtoken = tmpidtoken
        tokenkey1 = tmptokenkey1
        tokenkey2 = tmptokenkey2

        teProductPIN.EditValue = Nothing
        teKodeProduk.EditValue = Nothing
        lueProdukType.EditValue = Nothing
        teNamaProduk.EditValue = Nothing
        teNamaProdukResmi.EditValue = Nothing
        teRemarksProduk.EditValue = Nothing

        Dim colname As New List(Of String)
        Dim colcaption As New List(Of String)
        Dim coltype As New List(Of Type)
        Dim dsproducttype As DataSet

        sqls = New SQLs(mystring)
        sqls.DMLQuery("SELECT idproducttype as id,producttype as content,remarks FROM producttype where isnull(isdeleted,0)=0 order by producttype asc", "content")

        dsproducttype = New DataSet
        colname.Clear()
        colcaption.Clear()
        coltype.Clear()
        colname.AddRange(New String() {"id", "content", "remarks"})
        colcaption.AddRange(New String() {"ID", "Content", "Remarks"})
        coltype.AddRange(New Type() {GetType(Long), GetType(String)})
        dsproducttype = sqls.dataSet

        lueProdukType.Properties.DataSource = dsproducttype.Tables("content")
        lueProdukType.Properties.DisplayMember = "content"
        lueProdukType.Properties.ValueMember = "id"
        lueProdukType.EditValue = Nothing
        lueProdukType.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueProdukType.Properties.BestFit()
    End Sub

    Private Sub teNamaProduk_TextChanged(sender As Object, e As EventArgs) Handles teNamaProduk.TextChanged
        If teNamaProduk.EditValue Is Nothing Then
            teKodeProduk.EditValue = Nothing
        Else
            If teNamaProduk.Text.Length >= 6 Then
                teKodeProduk.Text = getGenerateCode(teNamaProduk.Text, tmptokenkey1, tmptokenkey2, 20, getFrom.depan)
            Else
                teKodeProduk.Text = ""
            End If
        End If
    End Sub

    Private Function cekIsian() As Boolean
        Dim retval As Boolean = True
        If lueProdukType.EditValue Is Nothing Then
            retval = False
        End If
        If teKodeProduk.Text = "" Then
            retval = False
        End If
        If teNamaProduk.Text = "" Then
            retval = False
        End If
        If teNamaProdukResmi.Text = "" Then
            retval = False
        End If
        If teRemarksProduk.Text = "" Then
            retval = False
        End If
        If teKodeProduk.EditValue Is Nothing Then
            retval = False
        End If
        If teNamaProduk.EditValue Is Nothing Then
            retval = False
        End If
        If teNamaProdukResmi.EditValue Is Nothing Then
            retval = False
        End If
        If teRemarksProduk.EditValue Is Nothing Then
            retval = False
        End If
        Return retval
    End Function

    Private Function getidproduct(prodname As String) As Integer
        Dim retval As Integer = -1

        Dim sqls As New SQLs(mystring)
        sqls.DMLQuery("select idproduct from product where productname='" & prodname & "'", "content")
        If sqls.getDataSet("content") > 0 Then
            retval = sqls.getDataSet("content", 0, "idproduct")
        End If

        Return retval
    End Function

    Private Function cekproduct(prodname As String) As Boolean
        Dim retval As Boolean = True

        Dim sqls As New SQLs(mystring)
        sqls.DMLQuery("select idproduct from product where productname='" & prodname & "'", "content")
        If sqls.getDataSet("content") > 0 Then
            retval = False
        End If

        Return retval
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Cursor = Cursors.WaitCursor
        If cekIsian() = False Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        If tmpCompanyFromOnline = False Then
            If cekproduct(teNamaProduk.Text) = False Then
                dizMsgbox("Produk ini sudah terdaftar", dizMsgboxStyle.Kesalahan, Me)
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
        End If

        Dim sqls As New SQLs(mystring)
        If tmpCompanyFromOnline = False Then
            sqls.DMLQuery("select top 1 idtoken,tokenkey1,tokenkey2 from token order by createddate desc", "token")
            If sqls.getDataSet("token") > 0 Then
                tmpidtoken = sqls.getDataSet("token", 0, "idtoken")
                tmptokenkey1 = sqls.getDataSet("token", 0, "tokenkey1")
                tmptokenkey2 = sqls.getDataSet("token", 0, "tokenkey2")
            Else
                tmpidtoken = 1
                tmptokenkey1 = "ABF"
                tmptokenkey2 = "123"
            End If
        End If
        sqls.DMLQuery("select convert(varchar,getdate(),105) as tanggal,convert(varchar,getdate(),108) as waktu", "lasttime")
        If sqls.getDataSet("lasttime") > 0 Then
            Dim tmptgl As String = sqls.getDataSet("lasttime", 0, "tanggal")
            Dim tmpwaktu As String = sqls.getDataSet("lasttime", 0, "waktu")
            tmpnowTime = New Date(tmptgl.Split("-")(2), tmptgl.Split("-")(1), tmptgl.Split("-")(0), tmpwaktu.Split(":")(0), tmpwaktu.Split(":")(1), tmpwaktu.Split(":")(2))
        Else
            tmpnowTime = Now
        End If
        teKodeProduk.Text = getGenerateCode(teNamaProduk.Text, tmptokenkey1, tmptokenkey2, 20, getFrom.depan)

        Dim dtmys As New dtsetSQLS(mystring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        If idData = -1 Then
            field.AddRange(New String() {"idproduct", "idproducttype", "productcode", "productname", "productofficialname", "remarks", "databasetype", "isdeleted", "deletereason", "idtoken", "tokenkey1", "tokenkey2", "createdby", "createddate"})
        Else
            field.AddRange(New String() {"idproduct", "idproducttype", "productcode", "productname", "productofficialname", "remarks", "databasetype", "isdeleted", "deletereason", "idtoken", "tokenkey1", "tokenkey2", "updatedby", "updateddate"})
        End If

        value.AddRange(New Object() {idData, lueProdukType.EditValue, teKodeProduk.Text, teNamaProduk.Text, teNamaProdukResmi.Text, teRemarksProduk.Text, 1, 0, "-", tmpidtoken, tmptokenkey1, tmptokenkey2, tmpUserID, tmpnowTime})

        Me.Cursor = Cursors.Default
        If dtmys.datasetSave("product", idData, field, value, False) = True Then
            Dim idproduct As Integer = getidproduct(teNamaProduk.Text)
            Dim lite As New SQLi(dblite)

            modCore.idproduct = idproduct
            modCore.productcode = teKodeProduk.Text
            modCore.productname = teNamaProduk.Text
            modCore.idproducttype = lueProdukType.EditValue

            lite.DMLQuery("update appsetting set value='" & modCore.idproduct & "' where variable='ProductID'", False)
            lite.DMLQuery("update appsetting set value='" & modCore.productname & "' where variable='ProductName'", False)
            lite.DMLQuery("update appsetting set value='" & modCore.productcode & "' where variable='ProductCode'", False)
            lite.DMLQuery("update appsetting set value='" & modCore.idproducttype & "' where variable='ProductTypeID'", False)
            lite.DMLQuery("update appsetting set value='" & teRemarksProduk.Text & "' where variable='ProductDescription'", False)

            Dim sqlss As New SQLs(dbstring)
            sqlss.DMLQuery("update sys_appsetting set value='" & modCore.idproduct & "' where variable='ProductID'", False)
            sqlss.DMLQuery("update sys_appsetting set value='" & modCore.productname & "' where variable='ProductName'", False)
            sqlss.DMLQuery("update sys_appsetting set value='" & modCore.productcode & "' where variable='ProductCode'", False)
            sqlss.DMLQuery("update sys_appsetting set value='" & modCore.idproducttype & "' where variable='ProductTypeID'", False)

            If idData = -1 Then
                dizMsgbox("Data Produk tersimpan", dizMsgboxStyle.Info, Me)
            Else
                dizMsgbox("Data Produk diperbarui", dizMsgboxStyle.Info, Me)
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Dispose()
        End If
    End Sub

    Private statData As statusData = statusData.Baru
    Private idData As Long = -1

    Private Sub btnExistCheck_Click(sender As Object, e As EventArgs) Handles btnExistCheck.Click
        Me.Cursor = Cursors.WaitCursor
        Dim sqls As New SQLs(mystring)
        sqls.DMLQuery("select idproduct,idproducttype,productcode,productname,productofficialname,remarks from product where productcode='" & teProductPIN.Text & "'", "getvalue")
        If sqls.getDataSet("getvalue") > 0 Then
            idData = sqls.getDataSet("getvalue", 0, "idproduct")

            lueProdukType.EditValue = sqls.getDataSet("getvalue", 0, "idproducttype")
            teKodeProduk.Text = sqls.getDataSet("getvalue", 0, "productcode")
            teNamaProduk.Text = sqls.getDataSet("getvalue", 0, "productname")
            teNamaProdukResmi.Text = sqls.getDataSet("getvalue", 0, "productofficialname")
            teRemarksProduk.Text = sqls.getDataSet("getvalue", 0, "remarks")

            tmpCompanyFromOnline = True
            Me.Cursor = Cursors.Default
        Else
            dizMsgbox("Data Produk tidak ditemukan atau tidak aktif", dizMsgboxStyle.Peringatan, Me)

            lueProdukType.EditValue = sqls.getDataSet("getvalue", 0, "idproducttype")
            teKodeProduk.Text = sqls.getDataSet("getvalue", 0, "productcode")
            teNamaProduk.Text = sqls.getDataSet("getvalue", 0, "productname")
            teNamaProdukResmi.Text = sqls.getDataSet("getvalue", 0, "productofficialname")
            teRemarksProduk.Text = sqls.getDataSet("getvalue", 0, "remarks")

            tmpCompanyFromOnline = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

End Class