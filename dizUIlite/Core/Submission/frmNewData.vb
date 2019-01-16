Public Class frmNewData

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

    Private Sub frmNewData_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        aktif(True, False, False, False)
    End Sub

    Private Sub btnPengguna_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPengguna.Click
        Dim newuser As New frmNewProfile(True)
        If newuser.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            aktif(False, True, False, False)
        End If
    End Sub

    Private Sub btnCompany_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompany.Click
        Dim newcomp As New frmNewCompany
        If newcomp.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            aktif(False, False, True, False)
        End If
    End Sub

    Private Sub btnProduk_Click(sender As Object, e As EventArgs) Handles btnProduk.Click
        Dim newprod As New frmNewProduct
        If newprod.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            aktif(False, False, False, True)
        End If
    End Sub

    Private Sub btnPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayment.Click
        Dim newpay As New frmNewPayment()
        If newpay.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim sqli As New SQLi(dblite)
            Dim mystring As String = ""
            sqli.DMLQuery("select databasename || '|' || ipserver || '|' || port || '|' || username || '|' || password as dbstring from dbconn where dbtype='SQLS' and dblocation='DOMAIN'", "getdbstring")
            If sqli.getDataSet("getdbstring") > 0 Then
                mystring = sqli.getDataSet("getdbstring", 0, "dbstring")
            End If
            Dim mys As New MYs(mystring)
            mys.DMLQuery("select convert(varchar,getdate(),105) as tanggal,convert(varchar,getdate(),108) as waktu", "lasttime")
            If mys.getDataSet("lasttime") > 0 Then
                Dim tmptgl As String = mys.getDataSet("lasttime", 0, "tanggal")
                Dim tmpwaktu As String = mys.getDataSet("lasttime", 0, "waktu")
                tmpnowTime = New Date(tmptgl.Split("-")(2), tmptgl.Split("-")(1), tmptgl.Split("-")(0), tmpwaktu.Split(":")(0), tmpwaktu.Split(":")(1), tmpwaktu.Split(":")(2))
            Else
                tmpnowTime = Now
            End If

            Dim datavalid As Boolean = True
            Dim dizEngine As New dizEngine.engine
            sqli.DMLQuery("select value from appsetting where variable='QuotaAmount'", "getquotaamount")
            If sqli.getDataSet("getquotaamount", 0, "value") = " " Then
                datavalid = False
            Else
                sqli.DMLQuery("select value from appsetting where variable='QuotaAmountCode'", "getquotaamountcode")
                Dim quotaamountcode As String = dizEngine.processE(sqli.getDataSet("getquotaamount", 0, "value"))
                If quotaamountcode = sqli.getDataSet("getquotaamountcode", 0, "value") Then
                    datavalid = True
                Else
                    datavalid = False
                End If
            End If
            sqli.DMLQuery("select value from appsetting where variable='CompanyID'", "getcompanyid")
            If sqli.getDataSet("getcompanyid", 0, "value") = " " Then
                datavalid = False
            Else
                mys.DMLQuery("select companycode as value from company where idcompany=" & sqli.getDataSet("getcompanyid", 0, "value"), "getcompanycode")
                sqli.DMLQuery("select value from appsetting where variable='CompanyCode'", "getcompanycode")
                If mys.getDataSet("getcompanycode") > 0 Then
                    If mys.getDataSet("getcompanycode", 0, "value") = sqli.getDataSet("getcompanycode", 0, "value") Then
                        datavalid = True
                    Else
                        datavalid = False
                    End If
                Else
                    datavalid = False
                End If
            End If
            sqli.DMLQuery("select value from appsetting where variable='ProductID'", "getproductid")
            If sqli.getDataSet("getproductid", 0, "value") = " " Then
                datavalid = False
            Else
                mys.DMLQuery("select productcode as value from product where idproduct=" & sqli.getDataSet("getproductid", 0, "value"), "getproductcode")
                sqli.DMLQuery("select value from appsetting where variable='ProductCode'", "getproductcode")
                If mys.getDataSet("getproductcode") > 0 Then
                    If mys.getDataSet("getproductcode", 0, "value") = sqli.getDataSet("getproductcode", 0, "value") Then
                        datavalid = True
                    Else
                        datavalid = False
                    End If
                Else
                    datavalid = False
                End If
            End If
            sqli.DMLQuery("select value from appsetting where variable='HardwareID'", "gethardwareid")
            If sqli.getDataSet("gethardwareid", 0, "value") = " " Then
                datavalid = False
            Else
                mys.DMLQuery("select hardwarecode as value from hardware where idhardware=" & sqli.getDataSet("gethardwareid", 0, "value"), "gethardwarecode")
                sqli.DMLQuery("select value from appsetting where variable='HardwareCode'", "gethardwarecode")
                If mys.getDataSet("gethardwarecode") > 0 Then
                    If mys.getDataSet("gethardwarecode", 0, "value") = sqli.getDataSet("gethardwarecode", 0, "value") Then
                        datavalid = True
                    Else
                        datavalid = False
                    End If
                Else
                    datavalid = False
                End If
            End If
            If datavalid = True Then
                Dim StartActivated As String = Format(tmpnowTime, "dd-MM-yyyy")
                Dim StartActivatedCode As String = dizEngine.processE(StartActivated)
                sqli.DMLQuery("update appsetting set value='" & StartActivated & "' where variable='StartActivated'", False)
                sqli.DMLQuery("update appsetting set value='" & StartActivatedCode & "' where variable='StartActivatedCode'", False)
            End If
            aktif(False, False, False, False)
        End If
    End Sub

    Private Sub pExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pExit.Click
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

    Private Sub aktif(ByVal usr As Boolean, ByVal comp As Boolean, produk As Boolean, ByVal payment As Boolean)
        btnPengguna.Enabled = usr
        btnCompany.Enabled = comp
        btnproduk.enabled = produk
        btnPayment.Enabled = payment
    End Sub

End Class