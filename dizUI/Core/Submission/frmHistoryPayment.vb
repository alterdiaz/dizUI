Public Class frmHistoryPayment

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

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.Cursor = Cursors.WaitCursor

        Dim json_result As String = ""
        Dim table As DataTable = Nothing
        Dim mparam As New List(Of String)
        Dim mvalue As New List(Of String)
        mparam.AddRange(New String() {"param", "tkey1", "tkey2", "idcompanyproduct"})
        mvalue.AddRange(New String() {"cekhistory", tmptokenkey1, tmptokenkey2, idcompanyproduct})
        json_result = modCore.HttpPOSTRequestselect(mysite & "payment", mparam, mvalue)
        table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)

        'Dim sqls As New SQLs(mystring)
        'sqls.DMLQuery("select p.paymentno,convert(varchar,p.createddate,105) as tanggalbayar,b.bank +' ('+bo.nomorrekening+')' as akunbank,p.nominalbayar,p.nominaldata,p.bankpengirim,p.norekpengirim,p.atasnamapengirim,p.remarks,case when p.isvalid=0 then 'Tidak Valid' else 'Valid' end as isvalid from payment p left join bankoption bo on p.idbankoption=bo.idbankoption left join bank b on bo.idbank=b.idbank where idcompanyproduct='" & idcp & "' order by p.createddate desc", "hp")

        gcHistory.DataSource = table
        gvHistory.BestFitColumns()
        Me.Cursor = Cursors.Default

        dataUsage()
    End Sub

    Private Sub dataUsage()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("SELECT o.name, i.rowcnt as rowtotal FROM sysindexes AS i INNER JOIN sysobjects AS o ON i.id = o.id WHERE i.rowcnt > 0 AND i.indid < 2 AND OBJECTPROPERTY(o.id, 'IsMSShipped') = 0 and o.name in (select tb.table_name from information_schema.tables tb where tb.table_type='BASE TABLE' and tb.table_name not like 'sys_%') order by o.name asc ", "rowdetailcount")
        gcUsage.DataSource = sqls.dataTable("rowdetailcount")
        gvUsage.BestFitColumns()
    End Sub

    Private idcp As String = -1
    Public Sub New(idcomprod As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        idcp = idcomprod
    End Sub

    'Private mystring As String = ""
    Private mysite As String = ""
    Private Sub frmHistoryPayment_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim lite As New SQLi(dblite)
        'lite.DMLQuery("select databasename || '|' || ipserver || '|' || port || '|' || username || '|' || password as dbstring from dbconn where dbtype='SQLS' and dblocation='DOMAIN'", "getdbstring")
        'If lite.getDataSet("getdbstring") > 0 Then
        '    mystring = lite.getDataSet("getdbstring", 0, "dbstring")
        'End If
        lite.DMLQuery("select siteurl from siteconn where active=1 order by idsiteconn desc", "getdbstring")
        If lite.getDataSet("getdbstring") > 0 Then
            'mystring = lite.getDataSet("getdbstring", 0, "dbstring")
            mysite = lite.getDataSet("getdbstring", 0, "siteurl")
            mysite = CheckAndRepairValidURL(mysite)
        End If

        xtcData.SelectedTabPage = xtpHistory
        btnRefresh_Click(btnRefresh, Nothing)
    End Sub

End Class