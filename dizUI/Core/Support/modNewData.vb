Module modNewData
    Public tmpUserID As String = -1
    Public tmpUsername As String
    Public tmpUserFromOnline As Boolean = False

    Public tmpidtoken As String = "E82EC129-868C-4FEB-9AEB-0ADB46428F1E"
    Public tmptokenkey1 As String = "ABF"
    Public tmptokenkey2 As String = "123"

    Public tmpnowTime As DateTime = Now
    Public tmpCompanyFromOnline As Boolean = False

    Public tmpidcompany As String = "-1"
    Public tmpcompanyname As String = ""
    Public tmpcompanycode As String = ""

    Public tmpidproduct As String = "-1"
    Public tmpproductname As String = ""
    Public tmpproductcode As String = ""
    Public tmpidproducttype As New List(Of String)

    Public tmpidhardware As String = ""
    Public tmphardwareid As String = ""
    Public tmphardwarecode As String = ""

    Public tmpidcompanyrefferal As String = "-1"
    'Public tmpidcompanyproduct As String = "-1"

End Module
