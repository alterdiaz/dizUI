Imports DevExpress.XtraReports.UI

Public Class xrSPP
    Private Sub xrSPP_DataSourceRowChanged(sender As Object, e As DataSourceRowEventArgs) Handles Me.DataSourceRowChanged
        xrbcQR.Text = pID.Value
    End Sub

End Class