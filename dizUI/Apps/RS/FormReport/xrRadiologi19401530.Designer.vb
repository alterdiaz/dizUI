<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class xrRadiologi19401530
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
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.SpRegistrasiSlipTableAdapter1 = New dizUI.spRegistrasiSlipTableAdapters.spRegistrasiSlipTableAdapter()
        Me.SpRegistrasiSlip1 = New dizUI.spRegistrasiSlip()
        Me.SpCompanyLogoCaptionSquareTableAdapter = New dizUI.spRegistrasiSlipTableAdapters.spCompanyLogoCaptionSquareTableAdapter()
        CType(Me.SpRegistrasiSlip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel5, Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.XrLabel1})
        Me.Detail.Dpi = 254.0!
        Me.Detail.HeightF = 500.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.Dpi = 254.0!
        Me.XrLabel5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[paramedisrujukan]")})
        Me.XrLabel5.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(10.00004!, 390.0!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(1410.0!, 99.99997!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "XrLabel5"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.Dpi = 254.0!
        Me.XrLabel4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[registrasidate]")})
        Me.XrLabel4.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(10.00004!, 260.0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(880.0!, 100.0!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UsePadding = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "XrLabel4"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.Dpi = 254.0!
        Me.XrLabel3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[umur]")})
        Me.XrLabel3.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(579.9999!, 130.0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(630.0001!, 99.99998!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UsePadding = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "XrLabel3"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.Dpi = 254.0!
        Me.XrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[tanggallahir]")})
        Me.XrLabel2.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(10.00004!, 130.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(550.0!, 99.99998!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UsePadding = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "XrLabel2"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[namapasien]")})
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00004!, 0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(1410.0!, 100.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UsePadding = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "XrLabel1"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
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
        'SpRegistrasiSlipTableAdapter1
        '
        Me.SpRegistrasiSlipTableAdapter1.ClearBeforeFill = True
        '
        'SpRegistrasiSlip1
        '
        Me.SpRegistrasiSlip1.DataSetName = "spRegistrasiSlip"
        Me.SpRegistrasiSlip1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpCompanyLogoCaptionSquareTableAdapter
        '
        Me.SpCompanyLogoCaptionSquareTableAdapter.ClearBeforeFill = True
        '
        'xrRadiologi19401530
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SpRegistrasiSlip1})
        Me.DataAdapter = Me.SpRegistrasiSlipTableAdapter1
        Me.DataMember = "spRegistrasiSlip"
        Me.DataSource = Me.SpRegistrasiSlip1
        Me.Dpi = 254.0!
        Me.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Margins = New System.Drawing.Printing.Margins(50, 50, 40, 40)
        Me.PageHeight = 1940
        Me.PageWidth = 1530
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.SnapGridSize = 10.0!
        Me.SnappingMode = CType((DevExpress.XtraReports.UI.SnappingMode.SnapLines Or DevExpress.XtraReports.UI.SnappingMode.SnapToGrid), DevExpress.XtraReports.UI.SnappingMode)
        Me.Version = "17.2"
        CType(Me.SpRegistrasiSlip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents SpRegistrasiSlipTableAdapter1 As spRegistrasiSlipTableAdapters.spRegistrasiSlipTableAdapter
    Friend WithEvents SpRegistrasiSlip1 As spRegistrasiSlip
    Friend WithEvents SpCompanyLogoCaptionSquareTableAdapter As spRegistrasiSlipTableAdapters.spCompanyLogoCaptionSquareTableAdapter
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
End Class
