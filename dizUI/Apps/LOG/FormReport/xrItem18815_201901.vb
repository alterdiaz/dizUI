Imports System.Drawing.Printing

Public Class xrItem18815_201901
    Private Sub xrItem18815_201901_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        xrp1QR.Text = p1ID.Value
        xrp2QR.Text = p2ID.Value
        xrp3QR.Text = p3ID.Value
        xrp4QR.Text = p4ID.Value
        xrp5QR.Text = p5ID.Value

        xrp6QR.Text = p6ID.Value
        xrp7QR.Text = p7ID.Value
        xrp8QR.Text = p8ID.Value
        xrp9QR.Text = p9ID.Value
        xrp10QR.Text = p10ID.Value

        If p1ID.Value = "" Then xrp1QR.Visible = False
        If p2ID.Value = "" Then xrp2QR.Visible = False
        If p3ID.Value = "" Then xrp3QR.Visible = False
        If p4ID.Value = "" Then xrp4QR.Visible = False
        If p5ID.Value = "" Then xrp5QR.Visible = False

        If p6ID.Value = "" Then xrp6QR.Visible = False
        If p7ID.Value = "" Then xrp7QR.Visible = False
        If p8ID.Value = "" Then xrp8QR.Visible = False
        If p9ID.Value = "" Then xrp9QR.Visible = False
        If p10ID.Value = "" Then xrp10QR.Visible = False

        xrp1BC.Text = p1UPC.Value
        xrp2BC.Text = p2UPC.Value
        xrp3BC.Text = p3UPC.Value
        xrp4BC.Text = p4UPC.Value
        xrp5BC.Text = p5UPC.Value

        xrp6BC.Text = p6UPC.Value
        xrp7BC.Text = p7UPC.Value
        xrp8BC.Text = p8UPC.Value
        xrp9BC.Text = p9UPC.Value
        xrp10BC.Text = p10UPC.Value

        If p1UPC.Value = "" Then xrp1BC.Visible = False
        If p2UPC.Value = "" Then xrp2BC.Visible = False
        If p3UPC.Value = "" Then xrp3BC.Visible = False
        If p4UPC.Value = "" Then xrp4BC.Visible = False
        If p5UPC.Value = "" Then xrp5BC.Visible = False

        If p6UPC.Value = "" Then xrp6BC.Visible = False
        If p7UPC.Value = "" Then xrp7BC.Visible = False
        If p8UPC.Value = "" Then xrp8BC.Visible = False
        If p9UPC.Value = "" Then xrp9BC.Visible = False
        If p10UPC.Value = "" Then xrp10BC.Visible = False
    End Sub

End Class