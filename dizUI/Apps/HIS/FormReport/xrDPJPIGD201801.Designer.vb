<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class xrDPJPIGD201801
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.SpRegDPJP1 = New dizUI.spRegDPJP()
        Me.SpREGDPJPTableAdapter = New dizUI.spRegDPJPTableAdapters.spREGDPJPTableAdapter()
        Me.SpCompanyLogoCaptionSquareTableAdapter = New dizUI.spAMIGD201801TableAdapters.spCompanyLogoCaptionSquareTableAdapter()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        CType(Me.SpRegDPJP1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine2, Me.XrLabel1})
        Me.Detail.Dpi = 254.0!
        Me.Detail.HeightF = 60.0!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine2
        '
        Me.XrLine2.Dpi = 254.0!
        Me.XrLine2.LineWidth = 3
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(20.0!, 0!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(1800.0!, 10.0!)
        '
        'XrLabel1
        '
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[note]")})
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel1.KeepTogether = True
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(20.0!, 10.0!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.NullValueText = "-"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(1800.0!, 50.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = "XrLabel1"
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel2.BorderWidth = 0!
        Me.XrLabel2.Dpi = 254.0!
        Me.XrLabel2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.KeepTogether = True
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(19.99999!, 0!)
        Me.XrLabel2.Multiline = True
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 0, 0, 0, 254.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(1800.0!, 80.0!)
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseBorderWidth = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UsePadding = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "DPJP DAN KONSULAN"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 254.0!
        Me.TopMargin.HeightF = 0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 254.0!
        Me.BottomMargin.HeightF = 0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'SpRegDPJP1
        '
        Me.SpRegDPJP1.DataSetName = "spRegDPJP"
        Me.SpRegDPJP1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpREGDPJPTableAdapter
        '
        Me.SpREGDPJPTableAdapter.ClearBeforeFill = True
        '
        'SpCompanyLogoCaptionSquareTableAdapter
        '
        Me.SpCompanyLogoCaptionSquareTableAdapter.ClearBeforeFill = True
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2})
        Me.ReportHeader.Dpi = 254.0!
        Me.ReportHeader.HeightF = 80.0!
        Me.ReportHeader.KeepTogether = True
        Me.ReportHeader.Name = "ReportHeader"
        '
        'xrDPJPIGD201801
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SpRegDPJP1})
        Me.DataAdapter = Me.SpREGDPJPTableAdapter
        Me.DataMember = "spREGDPJP"
        Me.DataSource = Me.SpRegDPJP1
        Me.Dpi = 254.0!
        Me.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
        Me.PageHeight = 254
        Me.PageWidth = 1840
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.SnapGridSize = 10.0!
        Me.SnappingMode = DevExpress.XtraReports.UI.SnappingMode.SnapToGrid
        Me.Version = "17.2"
        CType(Me.SpRegDPJP1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SpRegDPJP1 As spRegDPJP
    Friend WithEvents SpREGDPJPTableAdapter As spRegDPJPTableAdapters.spREGDPJPTableAdapter
    Friend WithEvents SpCompanyLogoCaptionSquareTableAdapter As spAMIGD201801TableAdapters.spCompanyLogoCaptionSquareTableAdapter
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
End Class
