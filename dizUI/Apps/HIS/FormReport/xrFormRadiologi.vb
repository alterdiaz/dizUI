Imports DevExpress.XtraReports.UI

Public Class xrFormRadiologi
    Private Sub xrFormRadiologi_DataSourceRowChanged(sender As Object, e As DataSourceRowEventArgs) Handles Me.DataSourceRowChanged
        xrbcIDRM.Text = "FORMRAD-" & pID.Value
    End Sub

End Class