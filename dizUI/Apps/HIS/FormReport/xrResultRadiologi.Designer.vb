<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class xrResultRadiologi
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
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.xrbcIDRM = New DevExpress.XtraReports.UI.XRBarCode()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel66 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.SpTransaksiPenunjangTableAdapter1 = New dizUI.spTransaksiPenunjangTableAdapters.spTransaksiPenunjangTableAdapter()
        Me.SpCompanyLogoCaptionSquareTableAdapter = New dizUI.spTransaksiPenunjangTableAdapters.spCompanyLogoCaptionSquareTableAdapter()
        Me.pUnit = New DevExpress.XtraReports.Parameters.Parameter()
        Me.pNotes = New DevExpress.XtraReports.Parameters.Parameter()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.pFooter = New DevExpress.XtraReports.Parameters.Parameter()
        Me.pID = New DevExpress.XtraReports.Parameters.Parameter()
        Me.pNo = New DevExpress.XtraReports.Parameters.Parameter()
        Me.SpResultPenunjangTableAdapter1 = New dizUI.spResultPenunjangTableAdapters.spResultPenunjangTableAdapter()
        Me.SpResultPenunjang1 = New dizUI.spResultPenunjang()
        Me.SpCompanyLogoCaptionSquareTableAdapter1 = New dizUI.spResultPenunjangTableAdapters.spCompanyLogoCaptionSquareTableAdapter()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.SpResultPenunjang1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel19, Me.XrLabel18, Me.XrLabel15, Me.XrLine2, Me.XrLabel14})
        Me.Detail.Dpi = 254.0!
        Me.Detail.HeightF = 60.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine2
        '
        Me.XrLine2.Dpi = 254.0!
        Me.XrLine2.LineWidth = 3
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(9.999878!, 40.0!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(1360.0!, 8.898804!)
        '
        'XrLabel14
        '
        Me.XrLabel14.Dpi = 254.0!
        Me.XrLabel14.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[item]")})
        Me.XrLabel14.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(10.00004!, 0!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(989.9999!, 40.0!)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UsePadding = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "XrLabel14"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
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
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel21, Me.XrLabel20, Me.xrbcIDRM, Me.XrLine1, Me.XrLabel16, Me.XrLabel13, Me.XrLabel12, Me.XrLabel10, Me.XrLabel9, Me.XrLabel6, Me.XrLabel7, Me.XrLabel8, Me.XrLabel66, Me.XrLabel11, Me.XrLabel5, Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.XrLabel1})
        Me.PageHeader.Dpi = 254.0!
        Me.PageHeader.HeightF = 338.8988!
        Me.PageHeader.Name = "PageHeader"
        '
        'xrbcIDRM
        '
        Me.xrbcIDRM.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
        Me.xrbcIDRM.AutoModule = True
        Me.xrbcIDRM.Dpi = 254.0!
        Me.xrbcIDRM.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.xrbcIDRM.LocationFloat = New DevExpress.Utils.PointFloat(1158.2!, 50.00002!)
        Me.xrbcIDRM.Module = 5.08!
        Me.xrbcIDRM.Name = "xrbcIDRM"
        Me.xrbcIDRM.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 254.0!)
        Me.xrbcIDRM.ShowText = False
        Me.xrbcIDRM.SizeF = New System.Drawing.SizeF(220.0!, 220.0!)
        Me.xrbcIDRM.StylePriority.UseFont = False
        Me.xrbcIDRM.StylePriority.UsePadding = False
        Me.xrbcIDRM.StylePriority.UseTextAlignment = False
        QrCodeGenerator1.CompactionMode = DevExpress.XtraPrinting.BarCode.QRCodeCompactionMode.[Byte]
        Me.xrbcIDRM.Symbology = QrCodeGenerator1
        Me.xrbcIDRM.Text = "REG/LAB/20171220/0001"
        Me.xrbcIDRM.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine1
        '
        Me.XrLine1.Dpi = 254.0!
        Me.XrLine1.LineWidth = 3
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(10.00005!, 330.0!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(1360.0!, 8.898804!)
        '
        'XrLabel16
        '
        Me.XrLabel16.Dpi = 254.0!
        Me.XrLabel16.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(1010.0!, 290.0!)
        Me.XrLabel16.Multiline = True
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(118.0!, 40.0!)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UsePadding = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "Value1"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel13
        '
        Me.XrLabel13.Dpi = 254.0!
        Me.XrLabel13.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(10.00004!, 290.0!)
        Me.XrLabel13.Multiline = True
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(989.9999!, 40.0!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UsePadding = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "Item Pelayanan"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel12
        '
        Me.XrLabel12.Dpi = 254.0!
        Me.XrLabel12.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[pNotes]")})
        Me.XrLabel12.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 70.0!)
        Me.XrLabel12.Multiline = True
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(420.0!, 200.0!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UsePadding = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "XrLabel12"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel10
        '
        Me.XrLabel10.Dpi = 254.0!
        Me.XrLabel10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[pUnit]")})
        Me.XrLabel10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 0!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(420.0!, 60.0!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UsePadding = False
        Me.XrLabel10.Text = "XrLabel10"
        '
        'XrLabel9
        '
        Me.XrLabel9.Dpi = 254.0!
        Me.XrLabel9.Font = New System.Drawing.Font("Tahoma", 6.0!)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(1168.2!, 0!)
        Me.XrLabel9.Multiline = True
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(210.0!, 50.0!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UsePadding = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "RSLTPNNJG201901"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel6
        '
        Me.XrLabel6.Dpi = 254.0!
        Me.XrLabel6.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(440.0001!, 90.0!)
        Me.XrLabel6.Multiline = True
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(160.0!, 50.0!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UsePadding = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "Nama"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.Dpi = 254.0!
        Me.XrLabel7.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(440.0001!, 140.8!)
        Me.XrLabel7.Multiline = True
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(160.0!, 50.0!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UsePadding = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Tgl. Lahir"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.Dpi = 254.0!
        Me.XrLabel8.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(440.0001!, 50.0!)
        Me.XrLabel8.Multiline = True
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(160.0!, 40.0!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UsePadding = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "No. RM"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel66
        '
        Me.XrLabel66.Dpi = 254.0!
        Me.XrLabel66.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel66.LocationFloat = New DevExpress.Utils.PointFloat(440.0001!, 191.6!)
        Me.XrLabel66.Multiline = True
        Me.XrLabel66.Name = "XrLabel66"
        Me.XrLabel66.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel66.SizeF = New System.Drawing.SizeF(160.0!, 40.0!)
        Me.XrLabel66.StylePriority.UseFont = False
        Me.XrLabel66.StylePriority.UsePadding = False
        Me.XrLabel66.StylePriority.UseTextAlignment = False
        Me.XrLabel66.Text = "No. Reg"
        Me.XrLabel66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel11
        '
        Me.XrLabel11.Dpi = 254.0!
        Me.XrLabel11.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(440.0001!, 231.6!)
        Me.XrLabel11.Multiline = True
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(160.0!, 40.0!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UsePadding = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "Tgl. Reg"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.Dpi = 254.0!
        Me.XrLabel5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[registrasidate]")})
        Me.XrLabel5.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(600.0!, 231.6!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(540.0!, 40.0!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UsePadding = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "XrLabel5"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.Dpi = 254.0!
        Me.XrLabel4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[registrasino]")})
        Me.XrLabel4.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(600.0!, 190.8!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(540.0!, 40.0!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UsePadding = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "XrLabel4"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.Dpi = 254.0!
        Me.XrLabel3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[tanggallahir]")})
        Me.XrLabel3.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(599.9999!, 140.8!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(540.0!, 50.00002!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UsePadding = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "XrLabel3"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.Dpi = 254.0!
        Me.XrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[norm]")})
        Me.XrLabel2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(600.0!, 50.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(540.0!, 40.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UsePadding = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "XrLabel2"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[nama]")})
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(600.0!, 90.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(540.0!, 50.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UsePadding = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "XrLabel1"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'SpTransaksiPenunjangTableAdapter1
        '
        Me.SpTransaksiPenunjangTableAdapter1.ClearBeforeFill = True
        '
        'SpCompanyLogoCaptionSquareTableAdapter
        '
        Me.SpCompanyLogoCaptionSquareTableAdapter.ClearBeforeFill = True
        '
        'pUnit
        '
        Me.pUnit.Description = "pUnit"
        Me.pUnit.Name = "pUnit"
        Me.pUnit.Visible = False
        '
        'pNotes
        '
        Me.pNotes.Description = "pNotes"
        Me.pNotes.Name = "pNotes"
        Me.pNotes.Visible = False
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1, Me.XrLabel17})
        Me.PageFooter.Dpi = 254.0!
        Me.PageFooter.HeightF = 50.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Dpi = 254.0!
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(1238.2!, 0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(140.0!, 50.0!)
        Me.XrPageInfo1.StylePriority.UsePadding = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrPageInfo1.TextFormatString = "{0} / {1}"
        '
        'XrLabel17
        '
        Me.XrLabel17.Dpi = 254.0!
        Me.XrLabel17.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[pFooter]")})
        Me.XrLabel17.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(1230.0!, 50.0!)
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UsePadding = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "XrLabel17"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'ReportFooter
        '
        Me.ReportFooter.Dpi = 254.0!
        Me.ReportFooter.HeightF = 0!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'pFooter
        '
        Me.pFooter.Description = "pFooter"
        Me.pFooter.Name = "pFooter"
        Me.pFooter.Visible = False
        '
        'pID
        '
        Me.pID.Description = "pID"
        Me.pID.Name = "pID"
        Me.pID.Visible = False
        '
        'pNo
        '
        Me.pNo.Description = "pNo"
        Me.pNo.Name = "pNo"
        Me.pNo.Visible = False
        '
        'SpResultPenunjangTableAdapter1
        '
        Me.SpResultPenunjangTableAdapter1.ClearBeforeFill = True
        '
        'SpResultPenunjang1
        '
        Me.SpResultPenunjang1.DataSetName = "spResultPenunjang"
        Me.SpResultPenunjang1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpCompanyLogoCaptionSquareTableAdapter1
        '
        Me.SpCompanyLogoCaptionSquareTableAdapter1.ClearBeforeFill = True
        '
        'XrLabel15
        '
        Me.XrLabel15.Dpi = 254.0!
        Me.XrLabel15.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[valueint1]")})
        Me.XrLabel15.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(1010.0!, 0!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(118.0!, 40.0!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UsePadding = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "XrLabel15"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel18
        '
        Me.XrLabel18.Dpi = 254.0!
        Me.XrLabel18.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[valueint2]")})
        Me.XrLabel18.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(1130.0!, 0!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(118.0!, 40.0!)
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UsePadding = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "XrLabel18"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel19
        '
        Me.XrLabel19.Dpi = 254.0!
        Me.XrLabel19.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[valuedec1]")})
        Me.XrLabel19.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(1252.0!, 0!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(118.0!, 40.0!)
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UsePadding = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.Text = "XrLabel19"
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel20
        '
        Me.XrLabel20.Dpi = 254.0!
        Me.XrLabel20.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(1130.0!, 290.0!)
        Me.XrLabel20.Multiline = True
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(118.0!, 40.0!)
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.StylePriority.UsePadding = False
        Me.XrLabel20.StylePriority.UseTextAlignment = False
        Me.XrLabel20.Text = "Value2"
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel21
        '
        Me.XrLabel21.Dpi = 254.0!
        Me.XrLabel21.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(1252.0!, 290.0!)
        Me.XrLabel21.Multiline = True
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(118.0!, 40.0!)
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.StylePriority.UsePadding = False
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        Me.XrLabel21.Text = "Value3"
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'xrResultRadiologi
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader, Me.PageFooter, Me.ReportFooter})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SpResultPenunjang1})
        Me.DataAdapter = Me.SpResultPenunjangTableAdapter1
        Me.DataMember = "spResultPenunjang"
        Me.DataSource = Me.SpResultPenunjang1
        Me.Dpi = 254.0!
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(50, 50, 40, 40)
        Me.PageHeight = 2100
        Me.PageWidth = 2970
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.pUnit, Me.pNotes, Me.pFooter, Me.pID, Me.pNo})
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.SnapGridSize = 10.0!
        Me.SnappingMode = CType((DevExpress.XtraReports.UI.SnappingMode.SnapLines Or DevExpress.XtraReports.UI.SnappingMode.SnapToGrid), DevExpress.XtraReports.UI.SnappingMode)
        Me.Version = "17.2"
        CType(Me.SpResultPenunjang1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents SpTransaksiPenunjangTableAdapter1 As spTransaksiPenunjangTableAdapters.spTransaksiPenunjangTableAdapter
    Friend WithEvents SpCompanyLogoCaptionSquareTableAdapter As spTransaksiPenunjangTableAdapters.spCompanyLogoCaptionSquareTableAdapter
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel66 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pUnit As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pNotes As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pFooter As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents pID As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents pNo As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents xrbcIDRM As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents SpResultPenunjangTableAdapter1 As spResultPenunjangTableAdapters.spResultPenunjangTableAdapter
    Friend WithEvents SpResultPenunjang1 As spResultPenunjang
    Friend WithEvents SpCompanyLogoCaptionSquareTableAdapter1 As spResultPenunjangTableAdapters.spCompanyLogoCaptionSquareTableAdapter
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
End Class
