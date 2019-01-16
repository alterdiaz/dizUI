Imports DevExpress.XtraReports.UI

Public Class xrSPBLMA
    Private Sub xrSPBLMA_DataSourceRowChanged(sender As Object, e As DataSourceRowEventArgs) Handles Me.DataSourceRowChanged
        xrbcQR.Text = "Transaksi-" & pID.Value
    End Sub

End Class