Public Class frmChangeHardware
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

    Private statData As statusData = statusData.Baru
    Private idData As Long = -1

    Private mystring As String = ""
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        getRegex(dbstring)

        If tmpUserID = -1 Then
            texUsername.Text = ""
            texPassword.Text = ""
            btnUserCheck.Enabled = True
            panelLogin.Visible = True
            panelLogin.BringToFront()
            tlpEntry.Visible = False
            btnSave.Enabled = False
            tlpEntry.SendToBack()
        End If

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
        teNamaResmiProduk.EditValue = Nothing
        teNamaProduk.EditValue = Nothing
        teNamaProduk.Tag = ""
        teJenisProduk.EditValue = Nothing
        tePerusahaanPIN.EditValue = Nothing
        teNamaPerusahaan.EditValue = Nothing
        teNamaPerusahaan.Tag = ""
        teKodeHardware.EditValue = Nothing

        tmphardwareid = getBoardID()

        Dim idhw As Long = -1
        sqls.DMLQuery("select idhardware,idtoken,tokenkey1,tokenkey2 from hardware where hardwareid='" & tmphardwareid & "'", "idhw")
        If sqls.getDataSet("idhw") > 0 Then
            idhw = sqls.getDataSet("idhw", 0, "idhardware")

            tmpidtoken = sqls.getDataSet("idhw", 0, "idtoken")
            tmptokenkey1 = sqls.getDataSet("idhw", 0, "tokenkey1")
            tmptokenkey2 = sqls.getDataSet("idhw", 0, "tokenkey2")
        End If

        tmphardwarecode = getHardwareCode(tmphardwareid, tokenkey1, tokenkey2)
        teKodeHardware.Tag = tmphardwareid
        teKodeHardware.EditValue = tmphardwarecode
    End Sub

    Private Sub btnExistProduk_Click(sender As Object, e As EventArgs) Handles btnExistProduk.Click
        Dim sqlss As New SQLs(mystring)
        sqlss.DMLQuery("select p.idproduct,p.idproducttype,p.productname,p.productofficialname,t.producttype from product p left join producttype t on p.idproducttype=t.idproducttype where p.productcode='" & teProductPIN.Text & "'", "getproduct")

        If sqlss.getDataSet("getproduct") > 0 Then
            teNamaProduk.Tag = sqlss.getDataSet("getproduct", 0, "idproduct")
            teNamaProduk.EditValue = sqlss.getDataSet("getproduct", 0, "productname")
            teNamaResmiProduk.EditValue = sqlss.getDataSet("getproduct", 0, "productofficialname")
            teJenisProduk.EditValue = sqlss.getDataSet("getproduct", 0, "producttype")
        Else
            dizMsgbox("Produk tidak ditemukan", dizMsgboxStyle.Peringatan)
            teNamaProduk.Tag = ""
            teNamaProduk.EditValue = Nothing
            teNamaResmiProduk.EditValue = Nothing
            teJenisProduk.EditValue = Nothing
        End If
    End Sub

    Private Sub btnExistCompany_Click(sender As Object, e As EventArgs) Handles btnExistCompany.Click
        Dim sqlss As New SQLs(mystring)
        sqlss.DMLQuery("select idcompany,companyofficialname from company where companycode='" & tePerusahaanPIN.Text & "'", "getperusahaan")

        If sqlss.getDataSet("getperusahaan") > 0 Then
            teNamaPerusahaan.Tag = sqlss.getDataSet("getperusahaan", 0, "idcompany")
            teNamaPerusahaan.EditValue = sqlss.getDataSet("getperusahaan", 0, "companyofficialname")
        Else
            dizMsgbox("Perusahaan tidak ditemukan", dizMsgboxStyle.Peringatan)
            teNamaPerusahaan.Tag = ""
            teNamaPerusahaan.EditValue = Nothing
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim bcek As Boolean = True
        If IsNumeric(teNamaProduk.Tag) = False Then
            If teNamaProduk.Tag = "" Then
                bcek = False
            End If
        End If
        If IsNumeric(teNamaPerusahaan.Tag) = False Then
            If teNamaPerusahaan.Tag = "" Then
                bcek = False
            End If
        End If
        If bcek = False Then
            dizMsgbox("Produk / Perusahaan tidak ditemukan", dizMsgboxStyle.Peringatan)
            Exit Sub
        End If

        Dim sqls As New SQLs(mystring)
        sqls.DMLQuery("select idcompanyproduct from companyproduct where idcompany=" & teNamaPerusahaan.Tag & " and idproduct=" & teNamaProduk.Tag, "getcp")
        Dim idcp As Long = -1
        If sqls.getDataSet("getcp") > 0 Then
            idcp = sqls.getDataSet("getcp", 0, "idcompanyproduct")
        Else
            dizMsgbox("Produk / Perusahaan tidak ditemukan", dizMsgboxStyle.Peringatan)
            Exit Sub
        End If

        Dim idhw As Long = -1
        sqls.DMLQuery("select idhardware,idtoken,tokenkey1,tokenkey2 from hardware where hardwareid='" & tmphardwareid & "'", "idhw")
        If sqls.getDataSet("idhw") > 0 Then
            idhw = sqls.getDataSet("idhw", 0, "idhardware")
        End If

        If idhw = -1 Then
            Dim lite As New SQLi(dblite)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            Dim sqlset As New dtsetSQLS(mystring)
            field.AddRange(New String() {"idhardware", "hardwareid", "idtoken", "tokenkey1", "tokenkey2", "hardwarecode", "createdby", "createddate"})
            value.AddRange(New Object() {idhw, tmphardwareid, tmpidtoken, tmptokenkey1, tmptokenkey2, tmphardwarecode, tmpUserID, nowTime})
            sqlset.datasetSave("hardware", -1, field, value, False)

            sqls.DMLQuery("select idhardware,idtoken,tokenkey1,tokenkey2 from hardware where hardwareid='" & tmphardwareid & "'", "idhw1")
            idhw = sqls.getDataSet("idhw1", 0, "idhardware")
            tmpidtoken = sqls.getDataSet("idhw1", 0, "idtoken")
            tmptokenkey1 = sqls.getDataSet("idhw1", 0, "tokenkey1")
            tmptokenkey2 = sqls.getDataSet("idhw1", 0, "tokenkey2")

            lite.DMLQuery("update appsetting set value='" & idhw & "' where variable='HardwareID'", False)
            tmphardwareid = getBoardID()
            tmphardwarecode = getHardwareCode(tmphardwareid, tmptokenkey1, tmptokenkey2)
            teKodeHardware.Tag = tmphardwareid
            teKodeHardware.EditValue = tmphardwarecode
            lite.DMLQuery("update appsetting set value='" & tmphardwarecode & "' where variable='HardwareCode'", False)
            dizMsgbox("Data Hardware telah tersimpan", dizMsgboxStyle.Info, Me)
            Me.Dispose()
        End If
    End Sub

    Private Sub btnUserCheck_Click(sender As Object, e As EventArgs) Handles btnUserCheck.Click
        Me.Cursor = Cursors.WaitCursor
        Dim sqls As New SQLs(mystring)

        sqls.DMLQuery("select iduser,idtoken,tokenkey1,tokenkey2,password from [user] where username='" & texUsername.Text & "'", "user")
        If sqls.getDataSet("user") > 0 Then
            tmpidtoken = sqls.getDataSet("user", 0, "idtoken")
            tmptokenkey1 = sqls.getDataSet("user", 0, "tokenkey1")
            tmptokenkey2 = sqls.getDataSet("user", 0, "tokenkey2")
            Dim tmppassword As String = sqls.getDataSet("user", 0, "password")
            Dim strpassword As String = GeneratePass(texPassword.Text, tmptokenkey1, tmptokenkey2, 8000)
            If tmppassword = strpassword Then

                sqls.DMLQuery("select iduser,namalengkap,personalno,idcardtype,address,zipcode,email,handphone,hint,recoveryquestion,recoveryanswer,username,password from [user] where username='" & texUsername.Text & "'", "useronline")
                tmpUserID = sqls.getDataSet("useronline", 0, "iduser")
                tmpUserFromOnline = True
                Me.Cursor = Cursors.Default

                texUsername.Text = ""
                texPassword.Text = ""
                btnUserCheck.Enabled = False
                panelLogin.Visible = False
                panelLogin.SendToBack()
                tlpEntry.Visible = True

                btnSave.Enabled = True
                tlpEntry.BringToFront()
            Else
                tmpUserFromOnline = False
                dizMsgbox("Password tidak valid", dizMsgboxStyle.Info, Me)
                texPassword.Focus()
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
        Else
            tmpUserFromOnline = False
            dizMsgbox("Pengguna tidak ditemukan", dizMsgboxStyle.Info, Me)
            texUsername.Focus()
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
    End Sub

End Class