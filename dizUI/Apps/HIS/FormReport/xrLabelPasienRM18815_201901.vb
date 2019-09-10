Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class xrLabelPasienRM18815_201901

    Private Sub xrLabelPasienRM18815_201901_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        xrp1BC.Text = p1ID.Value
        xrp2BC.Text = p2ID.Value
        xrp3BC.Text = p3ID.Value
        xrp4BC.Text = p4ID.Value
        xrp5BC.Text = p5ID.Value

        xrp6BC.Text = p6ID.Value
        xrp7BC.Text = p7ID.Value
        xrp8BC.Text = p8ID.Value
        xrp9BC.Text = p9ID.Value
        xrp10BC.Text = p10ID.Value

        If p1ID.Value = "" Then xrp1BC.Visible = False
        If p2ID.Value = "" Then xrp2BC.Visible = False
        If p3ID.Value = "" Then xrp3BC.Visible = False
        If p4ID.Value = "" Then xrp4BC.Visible = False
        If p5ID.Value = "" Then xrp5BC.Visible = False

        If p6ID.Value = "" Then xrp6BC.Visible = False
        If p7ID.Value = "" Then xrp7BC.Visible = False
        If p8ID.Value = "" Then xrp8BC.Visible = False
        If p9ID.Value = "" Then xrp9BC.Visible = False
        If p10ID.Value = "" Then xrp10BC.Visible = False
    End Sub

End Class