Imports DevExpress.XtraReports.UI

Public Class xrAMRHB201801
    Private Sub xrAMRHB201801_DataSourceRowChanged(sender As Object, e As DataSourceRowEventArgs) Handles Me.DataSourceRowChanged
        xrbcIDRM.Text = "ASMRHB-" & pID.Value
    End Sub

End Class