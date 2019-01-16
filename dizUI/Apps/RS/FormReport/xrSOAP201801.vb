Imports DevExpress.XtraReports.UI

Public Class xrSOAP201801
    Private Sub xrAMIGD201801_DataSourceRowChanged(sender As Object, e As DataSourceRowEventArgs) Handles Me.DataSourceRowChanged
        xrbcIDRM.Text = "SOAP-" & pNo.Value
    End Sub

End Class