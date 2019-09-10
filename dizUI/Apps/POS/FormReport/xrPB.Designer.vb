<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class xrPB
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim QrCodeGenerator1 As DevExpress.XtraPrinting.BarCode.QRCodeGenerator = New DevExpress.XtraPrinting.BarCode.QRCodeGenerator()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrLabel37 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel36 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel35 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrbcQR = New DevExpress.XtraReports.UI.XRBarCode()
        Me.XrLabel34 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.pUnit = New DevExpress.XtraReports.Parameters.Parameter()
        Me.pNotes = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrCrossBandLine1 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrCrossBandLine4 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrCrossBandLine6 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrCrossBandBox1 = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.pID = New DevExpress.XtraReports.Parameters.Parameter()
        Me.pNo = New DevExpress.XtraReports.Parameters.Parameter()
        Me.pFooter = New DevExpress.XtraReports.Parameters.Parameter()
        Me.SpPOTableAdapter = New dizUI.spPOTableAdapters.spPOTableAdapter()
        Me.XrJurnalTableAdapter = New dizUI.setJurnalTableAdapters.xrJurnalTableAdapter()
        Me.SpPO1 = New dizUI.spPO()
        Me.XrCrossBandLine2 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrCrossBandLine3 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrCrossBandLine5 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrLabel38 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel39 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel40 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.SpPO1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel32, Me.XrLabel14, Me.XrLabel11, Me.XrLabel15, Me.XrLabel13, Me.XrLabel12, Me.XrLabel10})
        Me.Detail.Dpi = 254.0!
        Me.Detail.HeightF = 40.00003!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel32
        '
        Me.XrLabel32.BorderWidth = 0!
        Me.XrLabel32.Dpi = 254.0!
        Me.XrLabel32.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[kode]")})
        Me.XrLabel32.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel32.LocationFloat = New DevExpress.Utils.PointFloat(140.0!, 0!)
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel32.SizeF = New System.Drawing.SizeF(310.0!, 40.0!)
        Me.XrLabel32.StylePriority.UseBorderWidth = False
        Me.XrLabel32.StylePriority.UseFont = False
        Me.XrLabel32.StylePriority.UseTextAlignment = False
        Me.XrLabel32.Text = "No"
        Me.XrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel14
        '
        Me.XrLabel14.Dpi = 254.0!
        Me.XrLabel14.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[subtotaldisclainppn]")})
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(1430.0!, 0.00004485801!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(250.0!, 39.99998!)
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "XrLabel14"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel11
        '
        Me.XrLabel11.Dpi = 254.0!
        Me.XrLabel11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[discamount]")})
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(1260.0!, 0!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(150.0!, 40.0!)
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "XrLabel11"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel15
        '
        Me.XrLabel15.Dpi = 254.0!
        Me.XrLabel15.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[qtycharges]")})
        Me.XrLabel15.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(900.0001!, 0!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(119.9999!, 40.0!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "XrLabel15"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel13
        '
        Me.XrLabel13.Dpi = 254.0!
        Me.XrLabel13.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[harga]")})
        Me.XrLabel13.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(1040.0!, 0!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(200.0!, 40.0!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "XrLabel13"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel12
        '
        Me.XrLabel12.Dpi = 254.0!
        Me.XrLabel12.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[item]")})
        Me.XrLabel12.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(470.0!, 0!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(410.0!, 40.0!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "XrLabel12"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel10
        '
        Me.XrLabel10.Dpi = 254.0!
        Me.XrLabel10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[nomor]")})
        Me.XrLabel10.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(39.99997!, 0!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(85.0!, 40.0!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "XrLabel10"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 254.0!
        Me.TopMargin.HeightF = 40.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 254.0!
        Me.BottomMargin.HeightF = 40.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.CanGrow = False
        Me.XrLabel2.Dpi = 254.0!
        Me.XrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[spPO].[createddate]")})
        Me.XrLabel2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(1100.0!, 140.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(580.0!, 39.99998!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "XrLabel2"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.CanGrow = False
        Me.XrLabel3.Dpi = 254.0!
        Me.XrLabel3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[spPO].[transaksino]")})
        Me.XrLabel3.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(1100.0!, 99.99995!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(580.0!, 40.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "XrLabel3"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.Dpi = 254.0!
        Me.XrPictureBox1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Image", "[spCompanyLogoCaptionSquare].[images]")})
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(39.99998!, 0!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(180.0!, 180.0!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel22, Me.XrLabel18, Me.XrLabel16, Me.XrLine1, Me.XrLabel23, Me.XrLabel21, Me.XrLabel19, Me.XrLabel17, Me.XrLabel9, Me.XrLabel8, Me.XrLabel7, Me.XrLabel2, Me.XrLabel3, Me.XrLabel1, Me.XrLabel6, Me.XrLabel5, Me.XrLabel4, Me.XrPictureBox1})
        Me.PageHeader.Dpi = 254.0!
        Me.PageHeader.HeightF = 270.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel22
        '
        Me.XrLabel22.BorderWidth = 0!
        Me.XrLabel22.Dpi = 254.0!
        Me.XrLabel22.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(140.0!, 220.0!)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(310.0!, 39.99998!)
        Me.XrLabel22.StylePriority.UseBorderWidth = False
        Me.XrLabel22.StylePriority.UseFont = False
        Me.XrLabel22.StylePriority.UseTextAlignment = False
        Me.XrLabel22.Text = "Kode"
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel18
        '
        Me.XrLabel18.BorderWidth = 0!
        Me.XrLabel18.Dpi = 254.0!
        Me.XrLabel18.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(1430.0!, 220.0!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(250.0001!, 39.99998!)
        Me.XrLabel18.StylePriority.UseBorderWidth = False
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "Subtotal"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel16
        '
        Me.XrLabel16.BorderWidth = 0!
        Me.XrLabel16.Dpi = 254.0!
        Me.XrLabel16.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(1260.0!, 220.0!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(150.0!, 40.0!)
        Me.XrLabel16.StylePriority.UseBorderWidth = False
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "Diskon"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine1
        '
        Me.XrLine1.Dpi = 254.0!
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(35.29167!, 260.0!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(1649.417!, 9.999985!)
        '
        'XrLabel23
        '
        Me.XrLabel23.BorderWidth = 0!
        Me.XrLabel23.Dpi = 254.0!
        Me.XrLabel23.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(1040.0!, 220.0!)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(200.0!, 40.0!)
        Me.XrLabel23.StylePriority.UseBorderWidth = False
        Me.XrLabel23.StylePriority.UseFont = False
        Me.XrLabel23.StylePriority.UseTextAlignment = False
        Me.XrLabel23.Text = "Harga"
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel21
        '
        Me.XrLabel21.BorderWidth = 0!
        Me.XrLabel21.Dpi = 254.0!
        Me.XrLabel21.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(900.0001!, 220.0!)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(119.9999!, 40.0!)
        Me.XrLabel21.StylePriority.UseBorderWidth = False
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        Me.XrLabel21.Text = "Qty"
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel19
        '
        Me.XrLabel19.BorderWidth = 0!
        Me.XrLabel19.Dpi = 254.0!
        Me.XrLabel19.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(470.0!, 220.0!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(410.0!, 40.00003!)
        Me.XrLabel19.StylePriority.UseBorderWidth = False
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.Text = "Barang"
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel17
        '
        Me.XrLabel17.BorderWidth = 0!
        Me.XrLabel17.Dpi = 254.0!
        Me.XrLabel17.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(39.99997!, 220.0!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(85.0!, 40.0!)
        Me.XrLabel17.StylePriority.UseBorderWidth = False
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "No"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel9
        '
        Me.XrLabel9.BorderWidth = 0!
        Me.XrLabel9.Dpi = 254.0!
        Me.XrLabel9.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(940.0!, 140.0!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(160.0!, 39.99998!)
        Me.XrLabel9.StylePriority.UseBorderWidth = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Tanggal:"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel8
        '
        Me.XrLabel8.BorderWidth = 0!
        Me.XrLabel8.Dpi = 254.0!
        Me.XrLabel8.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(940.0!, 99.99995!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(160.0!, 40.0!)
        Me.XrLabel8.StylePriority.UseBorderWidth = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "Nomor:"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel7
        '
        Me.XrLabel7.BorderWidth = 0!
        Me.XrLabel7.Dpi = 254.0!
        Me.XrLabel7.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(940.0!, 60.00005!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(160.0!, 40.0!)
        Me.XrLabel7.StylePriority.UseBorderWidth = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Supplier:"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel1
        '
        Me.XrLabel1.CanGrow = False
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[spPO].[businesspartner]")})
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(1100.0!, 59.99997!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(580.0!, 40.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "XrLabel1"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.BorderWidth = 0!
        Me.XrLabel6.Dpi = 254.0!
        Me.XrLabel6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(939.9999!, 0!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(740.0002!, 60.0!)
        Me.XrLabel6.StylePriority.UseBorderWidth = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "PURCHASE ORDER"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel5
        '
        Me.XrLabel5.CanGrow = False
        Me.XrLabel5.Dpi = 254.0!
        Me.XrLabel5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[pUnit]")})
        Me.XrLabel5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(220.0!, 0!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(720.0!, 60.0!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "XrLabel5"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.CanGrow = False
        Me.XrLabel4.Dpi = 254.0!
        Me.XrLabel4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[pNotes]")})
        Me.XrLabel4.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(219.9999!, 59.99997!)
        Me.XrLabel4.Multiline = True
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(720.0001!, 120.0!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.Text = "XrLabel4"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel40, Me.XrLabel39, Me.XrLabel38, Me.XrLabel37, Me.XrLabel36, Me.XrLabel35, Me.XrLabel20, Me.XrLabel33, Me.xrbcQR, Me.XrLabel34, Me.XrLabel30, Me.XrLabel31, Me.XrLabel28, Me.XrLabel29, Me.XrLabel27, Me.XrLabel26, Me.XrLabel25, Me.XrLabel24})
        Me.PageFooter.Dpi = 254.0!
        Me.PageFooter.HeightF = 386.6346!
        Me.PageFooter.Name = "PageFooter"
        '
        'XrLabel37
        '
        Me.XrLabel37.BorderWidth = 0!
        Me.XrLabel37.Dpi = 254.0!
        Me.XrLabel37.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel37.LocationFloat = New DevExpress.Utils.PointFloat(1250.0!, 100.0!)
        Me.XrLabel37.Name = "XrLabel37"
        Me.XrLabel37.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel37.SizeF = New System.Drawing.SizeF(169.9999!, 39.99997!)
        Me.XrLabel37.StylePriority.UseBorderWidth = False
        Me.XrLabel37.StylePriority.UseFont = False
        Me.XrLabel37.StylePriority.UseTextAlignment = False
        Me.XrLabel37.Text = "PPN"
        Me.XrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel36
        '
        Me.XrLabel36.BorderWidth = 0!
        Me.XrLabel36.Dpi = 254.0!
        Me.XrLabel36.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[spPO].[subtotaldisc]")})
        Me.XrLabel36.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel36.LocationFloat = New DevExpress.Utils.PointFloat(1430.0!, 59.99997!)
        Me.XrLabel36.Name = "XrLabel36"
        Me.XrLabel36.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel36.SizeF = New System.Drawing.SizeF(250.0001!, 39.99997!)
        Me.XrLabel36.StylePriority.UseBorderWidth = False
        Me.XrLabel36.StylePriority.UseFont = False
        Me.XrLabel36.StylePriority.UseTextAlignment = False
        Me.XrLabel36.Text = "T.Diskon"
        Me.XrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel35
        '
        Me.XrLabel35.BorderWidth = 0!
        Me.XrLabel35.Dpi = 254.0!
        Me.XrLabel35.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel35.LocationFloat = New DevExpress.Utils.PointFloat(1250.0!, 59.99997!)
        Me.XrLabel35.Name = "XrLabel35"
        Me.XrLabel35.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel35.SizeF = New System.Drawing.SizeF(169.9999!, 39.99997!)
        Me.XrLabel35.StylePriority.UseBorderWidth = False
        Me.XrLabel35.StylePriority.UseFont = False
        Me.XrLabel35.StylePriority.UseTextAlignment = False
        Me.XrLabel35.Text = "T.Diskon"
        Me.XrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel20
        '
        Me.XrLabel20.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel20.Dpi = 254.0!
        Me.XrLabel20.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[spPO].[subtotal]")})
        Me.XrLabel20.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(1430.0!, 19.99999!)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(250.0!, 40.0!)
        Me.XrLabel20.StylePriority.UseBorders = False
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.StylePriority.UseTextAlignment = False
        Me.XrLabel20.Text = "XrLabel20"
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel33
        '
        Me.XrLabel33.BorderWidth = 0!
        Me.XrLabel33.Dpi = 254.0!
        Me.XrLabel33.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(1250.0!, 19.99999!)
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel33.SizeF = New System.Drawing.SizeF(169.9998!, 39.99998!)
        Me.XrLabel33.StylePriority.UseBorderWidth = False
        Me.XrLabel33.StylePriority.UseFont = False
        Me.XrLabel33.StylePriority.UseTextAlignment = False
        Me.XrLabel33.Text = "Subtotal"
        Me.XrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'xrbcQR
        '
        Me.xrbcQR.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
        Me.xrbcQR.AutoModule = True
        Me.xrbcQR.Dpi = 254.0!
        Me.xrbcQR.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.xrbcQR.LocationFloat = New DevExpress.Utils.PointFloat(1540.0!, 210.0!)
        Me.xrbcQR.Module = 5.08!
        Me.xrbcQR.Name = "xrbcQR"
        Me.xrbcQR.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.xrbcQR.ShowText = False
        Me.xrbcQR.SizeF = New System.Drawing.SizeF(140.0!, 140.0!)
        Me.xrbcQR.StylePriority.UseFont = False
        Me.xrbcQR.StylePriority.UsePadding = False
        Me.xrbcQR.StylePriority.UseTextAlignment = False
        QrCodeGenerator1.CompactionMode = DevExpress.XtraPrinting.BarCode.QRCodeCompactionMode.[Byte]
        Me.xrbcQR.Symbology = QrCodeGenerator1
        Me.xrbcQR.Text = "REG/LAB/20171220/0001"
        Me.xrbcQR.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel34
        '
        Me.XrLabel34.Dpi = 254.0!
        Me.XrLabel34.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[pFooter]")})
        Me.XrLabel34.Font = New System.Drawing.Font("Tahoma", 6.0!)
        Me.XrLabel34.LocationFloat = New DevExpress.Utils.PointFloat(39.99998!, 356.6346!)
        Me.XrLabel34.Name = "XrLabel34"
        Me.XrLabel34.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel34.SizeF = New System.Drawing.SizeF(1640.0!, 30.00003!)
        Me.XrLabel34.StylePriority.UseFont = False
        Me.XrLabel34.StylePriority.UseTextAlignment = False
        Me.XrLabel34.Text = "XrLabel34"
        Me.XrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel30
        '
        Me.XrLabel30.BorderWidth = 0!
        Me.XrLabel30.Dpi = 254.0!
        Me.XrLabel30.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(940.0!, 180.0!)
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel30.SizeF = New System.Drawing.SizeF(290.0!, 40.0!)
        Me.XrLabel30.StylePriority.UseBorderWidth = False
        Me.XrLabel30.StylePriority.UseFont = False
        Me.XrLabel30.StylePriority.UseTextAlignment = False
        Me.XrLabel30.Text = "menyetujui,"
        Me.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel31
        '
        Me.XrLabel31.BorderWidth = 0!
        Me.XrLabel31.Dpi = 254.0!
        Me.XrLabel31.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel31.LocationFloat = New DevExpress.Utils.PointFloat(939.9999!, 290.0!)
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel31.SizeF = New System.Drawing.SizeF(290.0001!, 60.0!)
        Me.XrLabel31.StylePriority.UseBorderWidth = False
        Me.XrLabel31.StylePriority.UseFont = False
        Me.XrLabel31.StylePriority.UseTextAlignment = False
        Me.XrLabel31.Text = "(                       )"
        Me.XrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel28
        '
        Me.XrLabel28.BorderWidth = 0!
        Me.XrLabel28.Dpi = 254.0!
        Me.XrLabel28.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel28.LocationFloat = New DevExpress.Utils.PointFloat(490.0!, 180.0!)
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel28.SizeF = New System.Drawing.SizeF(290.0!, 40.0!)
        Me.XrLabel28.StylePriority.UseBorderWidth = False
        Me.XrLabel28.StylePriority.UseFont = False
        Me.XrLabel28.StylePriority.UseTextAlignment = False
        Me.XrLabel28.Text = "mengetahui,"
        Me.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel29
        '
        Me.XrLabel29.BorderWidth = 0!
        Me.XrLabel29.Dpi = 254.0!
        Me.XrLabel29.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel29.LocationFloat = New DevExpress.Utils.PointFloat(490.0!, 290.0!)
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel29.SizeF = New System.Drawing.SizeF(290.0001!, 60.0!)
        Me.XrLabel29.StylePriority.UseBorderWidth = False
        Me.XrLabel29.StylePriority.UseFont = False
        Me.XrLabel29.StylePriority.UseTextAlignment = False
        Me.XrLabel29.Text = "(                       )"
        Me.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel27
        '
        Me.XrLabel27.BorderWidth = 0!
        Me.XrLabel27.CanGrow = False
        Me.XrLabel27.Dpi = 254.0!
        Me.XrLabel27.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[spPO].[namalengkap]")})
        Me.XrLabel27.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(39.99998!, 290.0!)
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(290.0001!, 60.0!)
        Me.XrLabel27.StylePriority.UseBorderWidth = False
        Me.XrLabel27.StylePriority.UseFont = False
        Me.XrLabel27.StylePriority.UseTextAlignment = False
        Me.XrLabel27.Text = "(                       )"
        Me.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel26
        '
        Me.XrLabel26.BorderWidth = 0!
        Me.XrLabel26.Dpi = 254.0!
        Me.XrLabel26.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel26.LocationFloat = New DevExpress.Utils.PointFloat(39.99998!, 180.0!)
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel26.SizeF = New System.Drawing.SizeF(290.0!, 40.0!)
        Me.XrLabel26.StylePriority.UseBorderWidth = False
        Me.XrLabel26.StylePriority.UseFont = False
        Me.XrLabel26.StylePriority.UseTextAlignment = False
        Me.XrLabel26.Text = "yang mengajukan,"
        Me.XrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel25
        '
        Me.XrLabel25.BorderWidth = 0!
        Me.XrLabel25.Dpi = 254.0!
        Me.XrLabel25.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(39.99998!, 20.00007!)
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel25.SizeF = New System.Drawing.SizeF(200.0!, 159.9999!)
        Me.XrLabel25.StylePriority.UseBorderWidth = False
        Me.XrLabel25.StylePriority.UseFont = False
        Me.XrLabel25.StylePriority.UseTextAlignment = False
        Me.XrLabel25.Text = "Keterangan:"
        Me.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel24
        '
        Me.XrLabel24.CanGrow = False
        Me.XrLabel24.Dpi = 254.0!
        Me.XrLabel24.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[spPO].[remarks]")})
        Me.XrLabel24.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(239.9999!, 20.00007!)
        Me.XrLabel24.Multiline = True
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(1000.0!, 159.9999!)
        Me.XrLabel24.StylePriority.UseFont = False
        Me.XrLabel24.StylePriority.UseTextAlignment = False
        Me.XrLabel24.Text = "XrLabel24"
        Me.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'pUnit
        '
        Me.pUnit.Description = "Unit"
        Me.pUnit.Name = "pUnit"
        Me.pUnit.Visible = False
        '
        'pNotes
        '
        Me.pNotes.Description = "Notes"
        Me.pNotes.Name = "pNotes"
        Me.pNotes.Visible = False
        '
        'XrCrossBandLine1
        '
        Me.XrCrossBandLine1.Dpi = 254.0!
        Me.XrCrossBandLine1.EndBand = Me.PageFooter
        Me.XrCrossBandLine1.EndPointFloat = New DevExpress.Utils.PointFloat(130.0!, 10.00017!)
        Me.XrCrossBandLine1.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.XrCrossBandLine1.LocationFloat = New DevExpress.Utils.PointFloat(130.0!, 210.0!)
        Me.XrCrossBandLine1.Name = "XrCrossBandLine1"
        Me.XrCrossBandLine1.StartBand = Me.PageHeader
        Me.XrCrossBandLine1.StartPointFloat = New DevExpress.Utils.PointFloat(130.0!, 210.0!)
        Me.XrCrossBandLine1.WidthF = 5.0!
        '
        'XrCrossBandLine4
        '
        Me.XrCrossBandLine4.Dpi = 254.0!
        Me.XrCrossBandLine4.EndBand = Me.PageFooter
        Me.XrCrossBandLine4.EndPointFloat = New DevExpress.Utils.PointFloat(890.0!, 10.00026!)
        Me.XrCrossBandLine4.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.XrCrossBandLine4.LocationFloat = New DevExpress.Utils.PointFloat(890.0!, 210.0!)
        Me.XrCrossBandLine4.Name = "XrCrossBandLine4"
        Me.XrCrossBandLine4.StartBand = Me.PageHeader
        Me.XrCrossBandLine4.StartPointFloat = New DevExpress.Utils.PointFloat(890.0!, 210.0!)
        Me.XrCrossBandLine4.WidthF = 5.0!
        '
        'XrCrossBandLine6
        '
        Me.XrCrossBandLine6.Dpi = 254.0!
        Me.XrCrossBandLine6.EndBand = Me.PageFooter
        Me.XrCrossBandLine6.EndPointFloat = New DevExpress.Utils.PointFloat(1030.0!, 10.00021!)
        Me.XrCrossBandLine6.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.XrCrossBandLine6.LocationFloat = New DevExpress.Utils.PointFloat(1030.0!, 210.0!)
        Me.XrCrossBandLine6.Name = "XrCrossBandLine6"
        Me.XrCrossBandLine6.StartBand = Me.PageHeader
        Me.XrCrossBandLine6.StartPointFloat = New DevExpress.Utils.PointFloat(1030.0!, 210.0!)
        Me.XrCrossBandLine6.WidthF = 5.0!
        '
        'XrCrossBandBox1
        '
        Me.XrCrossBandBox1.BorderWidth = 2.0!
        Me.XrCrossBandBox1.Dpi = 254.0!
        Me.XrCrossBandBox1.EndBand = Me.PageFooter
        Me.XrCrossBandBox1.EndPointFloat = New DevExpress.Utils.PointFloat(29.99993!, 10.00021!)
        Me.XrCrossBandBox1.LocationFloat = New DevExpress.Utils.PointFloat(29.99993!, 210.0!)
        Me.XrCrossBandBox1.Name = "XrCrossBandBox1"
        Me.XrCrossBandBox1.StartBand = Me.PageHeader
        Me.XrCrossBandBox1.StartPointFloat = New DevExpress.Utils.PointFloat(29.99993!, 210.0!)
        Me.XrCrossBandBox1.WidthF = 1660.0!
        '
        'pID
        '
        Me.pID.Description = "ID"
        Me.pID.Name = "pID"
        Me.pID.ValueInfo = "0"
        Me.pID.Visible = False
        '
        'pNo
        '
        Me.pNo.Description = "No"
        Me.pNo.Name = "pNo"
        Me.pNo.ValueInfo = "0"
        Me.pNo.Visible = False
        '
        'pFooter
        '
        Me.pFooter.Description = "Footer"
        Me.pFooter.Name = "pFooter"
        Me.pFooter.Visible = False
        '
        'SpPOTableAdapter
        '
        Me.SpPOTableAdapter.ClearBeforeFill = True
        '
        'XrJurnalTableAdapter
        '
        Me.XrJurnalTableAdapter.ClearBeforeFill = True
        '
        'SpPO1
        '
        Me.SpPO1.DataSetName = "spPO"
        Me.SpPO1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'XrCrossBandLine2
        '
        Me.XrCrossBandLine2.Dpi = 254.0!
        Me.XrCrossBandLine2.EndBand = Me.PageFooter
        Me.XrCrossBandLine2.EndPointFloat = New DevExpress.Utils.PointFloat(1250.0!, 9.999999!)
        Me.XrCrossBandLine2.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.XrCrossBandLine2.LocationFloat = New DevExpress.Utils.PointFloat(1250.0!, 211.331!)
        Me.XrCrossBandLine2.Name = "XrCrossBandLine2"
        Me.XrCrossBandLine2.StartBand = Me.PageHeader
        Me.XrCrossBandLine2.StartPointFloat = New DevExpress.Utils.PointFloat(1250.0!, 211.331!)
        Me.XrCrossBandLine2.WidthF = 5.0!
        '
        'XrCrossBandLine3
        '
        Me.XrCrossBandLine3.Dpi = 254.0!
        Me.XrCrossBandLine3.EndBand = Me.PageFooter
        Me.XrCrossBandLine3.EndPointFloat = New DevExpress.Utils.PointFloat(1420.0!, 7.974578!)
        Me.XrCrossBandLine3.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.XrCrossBandLine3.LocationFloat = New DevExpress.Utils.PointFloat(1420.0!, 211.331!)
        Me.XrCrossBandLine3.Name = "XrCrossBandLine3"
        Me.XrCrossBandLine3.StartBand = Me.PageHeader
        Me.XrCrossBandLine3.StartPointFloat = New DevExpress.Utils.PointFloat(1420.0!, 211.331!)
        Me.XrCrossBandLine3.WidthF = 4.999756!
        '
        'XrCrossBandLine5
        '
        Me.XrCrossBandLine5.Dpi = 254.0!
        Me.XrCrossBandLine5.EndBand = Me.PageFooter
        Me.XrCrossBandLine5.EndPointFloat = New DevExpress.Utils.PointFloat(460.0!, 7.974548!)
        Me.XrCrossBandLine5.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.XrCrossBandLine5.LocationFloat = New DevExpress.Utils.PointFloat(460.0!, 211.331!)
        Me.XrCrossBandLine5.Name = "XrCrossBandLine5"
        Me.XrCrossBandLine5.StartBand = Me.PageHeader
        Me.XrCrossBandLine5.StartPointFloat = New DevExpress.Utils.PointFloat(460.0!, 211.331!)
        Me.XrCrossBandLine5.WidthF = 5.0!
        '
        'XrLabel38
        '
        Me.XrLabel38.BorderWidth = 0!
        Me.XrLabel38.Dpi = 254.0!
        Me.XrLabel38.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[spPO].[subtotalppn]")})
        Me.XrLabel38.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel38.LocationFloat = New DevExpress.Utils.PointFloat(1430.0!, 99.99995!)
        Me.XrLabel38.Name = "XrLabel38"
        Me.XrLabel38.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel38.SizeF = New System.Drawing.SizeF(250.0001!, 39.99997!)
        Me.XrLabel38.StylePriority.UseBorderWidth = False
        Me.XrLabel38.StylePriority.UseFont = False
        Me.XrLabel38.StylePriority.UseTextAlignment = False
        Me.XrLabel38.Text = "T.Diskon"
        Me.XrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel39
        '
        Me.XrLabel39.BorderWidth = 0!
        Me.XrLabel39.Dpi = 254.0!
        Me.XrLabel39.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel39.LocationFloat = New DevExpress.Utils.PointFloat(1250.0!, 140.0!)
        Me.XrLabel39.Name = "XrLabel39"
        Me.XrLabel39.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel39.SizeF = New System.Drawing.SizeF(169.9999!, 39.99997!)
        Me.XrLabel39.StylePriority.UseBorderWidth = False
        Me.XrLabel39.StylePriority.UseFont = False
        Me.XrLabel39.StylePriority.UseTextAlignment = False
        Me.XrLabel39.Text = "Total"
        Me.XrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel40
        '
        Me.XrLabel40.BorderWidth = 0!
        Me.XrLabel40.Dpi = 254.0!
        Me.XrLabel40.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[spPO].[subtotaldisclainppn]")})
        Me.XrLabel40.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel40.LocationFloat = New DevExpress.Utils.PointFloat(1430.0!, 140.0!)
        Me.XrLabel40.Name = "XrLabel40"
        Me.XrLabel40.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel40.SizeF = New System.Drawing.SizeF(250.0001!, 39.99997!)
        Me.XrLabel40.StylePriority.UseBorderWidth = False
        Me.XrLabel40.StylePriority.UseFont = False
        Me.XrLabel40.StylePriority.UseTextAlignment = False
        Me.XrLabel40.Text = "T.Diskon"
        Me.XrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'xrPB
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader, Me.PageFooter})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SpPO1})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.XrCrossBandBox1, Me.XrCrossBandLine1, Me.XrCrossBandLine4, Me.XrCrossBandLine6, Me.XrCrossBandLine2, Me.XrCrossBandLine3, Me.XrCrossBandLine5})
        Me.DataAdapter = Me.SpPOTableAdapter
        Me.DataMember = "spPOcurrent"
        Me.DataSource = Me.SpPO1
        Me.Dpi = 254.0!
        Me.Margins = New System.Drawing.Printing.Margins(50, 50, 40, 40)
        Me.PageHeight = 1175
        Me.PageWidth = 1826
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.pUnit, Me.pNotes, Me.pID, Me.pNo, Me.pFooter})
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.SnapGridSize = 10.0!
        Me.SnappingMode = CType((DevExpress.XtraReports.UI.SnappingMode.SnapLines Or DevExpress.XtraReports.UI.SnappingMode.SnapToGrid), DevExpress.XtraReports.UI.SnappingMode)
        Me.Version = "17.2"
        CType(Me.SpPO1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents pUnit As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents pNotes As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrCrossBandLine1 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrCrossBandLine4 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrCrossBandLine6 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrCrossBandBox1 As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents pID As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents pNo As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel34 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pFooter As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents xrbcQR As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents SpPOTableAdapter As spPOTableAdapters.spPOTableAdapter
    Friend WithEvents XrJurnalTableAdapter As setJurnalTableAdapters.xrJurnalTableAdapter
    Friend WithEvents SpPO1 As spPO
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrCrossBandLine2 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrCrossBandLine3 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrCrossBandLine5 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrLabel35 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel37 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel36 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel40 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel39 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel38 As DevExpress.XtraReports.UI.XRLabel
End Class
