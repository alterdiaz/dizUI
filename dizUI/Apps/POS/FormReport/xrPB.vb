Imports DevExpress.XtraReports.UI

Public Class xrPB
    Private Sub xrPB_DataSourceRowChanged(sender As Object, e As DataSourceRowEventArgs) Handles Me.DataSourceRowChanged
        xrbcQR.Text = pID.Value
    End Sub

End Class