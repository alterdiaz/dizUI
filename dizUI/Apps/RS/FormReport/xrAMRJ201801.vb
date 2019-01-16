Imports DevExpress.XtraReports.UI
Public Class xrAMRJ201801

    Private Sub xrAMIGD201801_DataSourceRowChanged(sender As Object, e As DataSourceRowEventArgs) Handles Me.DataSourceRowChanged
        xrbcIDRM.Text = "ASMRJ-" & pID.Value
    End Sub

End Class