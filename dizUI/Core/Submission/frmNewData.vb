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

    Private mysite As String = ""
    Private Sub btnPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayment.Click
        Dim newpay As New frmNewPayment()
        If newpay.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim lite As New SQLi(dblite)
            'Dim mystring As String = ""
            'sqli.DMLQuery("select databasename || '|' || ipserver || '|' || port || '|' || username || '|' || password as dbstring from dbconn where dbtype='SQLS' and dblocation='DOMAIN'", "getdbstring")
            'If sqli.getDataSet("getdbstring") > 0 Then
            '    mystring = sqli.getDataSet("getdbstring", 0, "dbstring")
            'End If
            lite.DMLQuery("select siteurl from siteconn where active=1 order by idsiteconn desc", "getdbstring")
            If lite.getDataSet("getdbstring") > 0 Then
                'mystring = lite.getDataSet("getdbstring", 0, "dbstring")
                mysite = lite.getDataSet("getdbstring", 0, "siteurl")
                mysite = CheckAndRepairValidURL(mysite)
            End If

            'Dim mys As New MYs(mystring)
            'mys.DMLQuery("select convert(varchar,getdate(),105) as tanggal,convert(varchar,getdate(),108) as waktu", "lasttime")
            'If mys.getDataSet("lasttime") > 0 Then
            '    Dim tmptgl As String = mys.getDataSet("lasttime", 0, "tanggal")
            '    Dim tmpwaktu As String = mys.getDataSet("lasttime", 0, "waktu")
            '    tmpnowTime = Strdatetime2Datetime(tmptgl & " " & tmpwaktu)
            'Else
            '    tmpnowTime = Now
            'End If

            Dim json_result As String = ""
            Dim table As DataTable = Nothing
            Dim mparam As New List(Of String)
            Dim mvalue As New List(Of String)
            mparam.Clear()
            mvalue.Clear()
            mparam.AddRange(New String() {"param", "tkey1", "tkey2"})
            mvalue.AddRange(New String() {"currentdatetime", tmptokenkey1, tmptokenkey2})
            json_result = modCore.HttpPOSTRequestselect(mysite & "Core", mparam, mvalue)
            If json_result.Length > 2 Then 'table.Rows.Count > 0 Then 'strvalue.Contains("ERROR") = False Then
                table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)
                Dim tmptgl As String = table.Rows(0).Item("tanggal") 'strvalue.Split(" ")(0)
                Dim tmpwaktu As String = table.Rows(0).Item("waktu") 'strvalue.Split(" ")(1)
                tmpnowTime = Strdatetime2Datetime(tmptgl & " " & tmpwaktu)
            Else
                tmpnowTime = nowTime
            End If

            Dim datavalid As Boolean = True
            Dim dizEngine As New dizEngine.engine
            lite.DMLQuery("select value from appsetting where variable='QuotaAmount'", "getquotaamount")
            If lite.getDataSet("getquotaamount", 0, "value") = " " Then
                datavalid = False
            Else
                lite.DMLQuery("select value from appsetting where variable='QuotaAmountCode'", "getquotaamountcode")
                Dim quotaamountcode As String = dizEngine.processE(lite.getDataSet("getquotaamount", 0, "value"))
                If quotaamountcode = lite.getDataSet("getquotaamountcode", 0, "value") Then
                    datavalid = True
                Else
                    datavalid = False
                End If
            End If
            lite.DMLQuery("select value from appsetting where variable='CompanyID'", "getcompanyid")
            If lite.getDataSet("getcompanyid", 0, "value") = " " Then
                datavalid = False
            Else
                If table IsNot Nothing Then table.Clear()
                mparam.Clear()
                mvalue.Clear()
                mparam.AddRange(New String() {"param", "value", "tkey1", "tkey2"})
                mvalue.AddRange(New String() {"cekid", lite.getDataSet("getcompanyid", 0, "value"), tmptokenkey1, tmptokenkey2})
                json_result = modCore.HttpPOSTRequestSelect(mysite & "Company", mparam, mvalue)
                If json_result.Length > 2 Then
                    table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)
                End If

                'MYs.DMLQuery("select companycode as value from company where idcompany='" & lite.getDataSet("getcompanyid", 0, "value") & "'", "getcompanycode")
                lite.DMLQuery("select value from appsetting where variable='CompanyCode'", "getcompanycode")
                If table.Rows.Count > 0 Then 'mys.getDataSet("getcompanycode") > 0 Then '.getDataSet("getcompanycode", 0, "value") 
                    If table.Rows(0).Item("companycode") = lite.getDataSet("getcompanycode", 0, "value") Then
                        datavalid = True
                    Else
                        datavalid = False
                    End If
                Else
                    datavalid = False
                End If
            End If

            lite.DMLQuery("select value from appsetting where variable='HardwareID'", "gethardwareid")
            If lite.getDataSet("gethardwareid", 0, "value") = " " Then
                datavalid = False
            Else
                lite.DMLQuery("select value from appsetting where variable='HardwareCode'", "gethardwarecode")

                If table IsNot Nothing Then table.Clear()
                mparam.Clear()
                mvalue.Clear()
                mparam.AddRange(New String() {"param", "value", "hardwareid", "tkey1", "tkey2"})
                mvalue.AddRange(New String() {"cekhwid", "", lite.getDataSet("gethardwareid", 0, "value"), tmptokenkey1, tmptokenkey2})
                json_result = modCore.HttpPOSTRequestselect(mysite & "Hardware", mparam, mvalue)
                If json_result.Length > 2 Then
                    table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)

                    If table.Rows(0).Item("hardwarecode") = lite.getDataSet("gethardwarecode", 0, "value") Then 'MYs.getDataSet("gethardwarecode", 0, "value") = lite.getDataSet("gethardwarecode", 0, "value") Then
                        datavalid = True
                    Else
                        datavalid = False
                    End If

                    'MYs.DMLQuery("select hardwarecode as value from hardware where idhardware='" & sqli.getDataSet("gethardwareid", 0, "value") & "'", "gethardwarecode")
                Else
                    datavalid = False
                End If
            End If
            If datavalid = True Then
                Dim StartActivated As String = Format(tmpnowTime, "dd-MM-yyyy")
                Dim StartActivatedCode As String = dizEngine.processE(StartActivated)
                lite.DMLQuery("update appsetting set value='" & StartActivated & "' where variable='StartActivated'", False)
                lite.DMLQuery("update appsetting set value='" & StartActivatedCode & "' where variable='StartActivatedCode'", False)
            Else
                Dim StartActivated As String = Format(tmpnowTime, "dd-MM-yyyy")
                Dim StartActivatedCode As String = dizEngine.processE(StartActivated)
                lite.DMLQuery("update appsetting set value='" & StartActivated & "' where variable='StartActivated'", False)
                lite.DMLQuery("update appsetting set value='" & StartActivatedCode & "' where variable='StartActivatedCode'", False)
            End If

            aktif(False, False, False, True)
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

    Private Sub aktif(ByVal usr As Boolean, ByVal comp As Boolean, ByVal payment As Boolean, produk As Boolean)
        btnPengguna.Enabled = usr
        btnCompany.Enabled = comp
        btnProduk.Enabled = produk
        btnPayment.Enabled = payment
    End Sub

End Class