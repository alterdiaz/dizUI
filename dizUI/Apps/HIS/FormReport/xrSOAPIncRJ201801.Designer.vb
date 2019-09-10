<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class xrSOAPIncRJ201801
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
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine7 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.subAnatomi = New DevExpress.XtraReports.UI.XRSubreport()
        Me.XrLine19 = New DevExpress.XtraReports.UI.XRLine()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.SpAMIGD201801TableAdapter = New dizUI.spAMIGD201801TableAdapters.spAMIGD201801TableAdapter()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.pFooter = New DevExpress.XtraReports.Parameters.Parameter()
        Me.pNo = New DevExpress.XtraReports.Parameters.Parameter()
        Me.pID = New DevExpress.XtraReports.Parameters.Parameter()
        Me.SpCompanyLogoCaptionSquareTableAdapter = New dizUI.spAMIGD201801TableAdapters.spCompanyLogoCaptionSquareTableAdapter()
        Me.pUnit = New DevExpress.XtraReports.Parameters.Parameter()
        Me.pNotes = New DevExpress.XtraReports.Parameters.Parameter()
        Me.SpSN201801TableAdapter1 = New dizUI.spSN201801TableAdapters.spSN201801TableAdapter()
        Me.SpSN2018011 = New dizUI.spSN201801()
        Me.SpCompanyLogoCaptionSquareTableAdapter1 = New dizUI.spSN201801TableAdapters.spCompanyLogoCaptionSquareTableAdapter()
        CType(Me.SpSN2018011, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2, Me.XrLine7, Me.XrLabel20, Me.XrLabel19, Me.XrLabel18, Me.XrLabel17, Me.XrLine3, Me.XrLabel16, Me.XrLabel15, Me.XrLine1, Me.XrLabel14, Me.XrLabel1, Me.subAnatomi, Me.XrLine19})
        Me.Detail.Dpi = 254.0!
        Me.Detail.HeightF = 980.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.Dpi = 254.0!
        Me.XrLabel2.Font = New System.Drawing.Font("Tahoma", 6.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel2.Multiline = True
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(209.2!, 29.99999!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UsePadding = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "SOAPMRJ201801"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine7
        '
        Me.XrLine7.Dpi = 254.0!
        Me.XrLine7.LineWidth = 3
        Me.XrLine7.LocationFloat = New DevExpress.Utils.PointFloat(0!, 170.0!)
        Me.XrLine7.Name = "XrLine7"
        Me.XrLine7.SizeF = New System.Drawing.SizeF(889.9999!, 10.0!)
        '
        'XrLabel20
        '
        Me.XrLabel20.Dpi = 254.0!
        Me.XrLabel20.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[planning]")})
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(0!, 570.0!)
        Me.XrLabel20.Multiline = True
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(889.9999!, 50.0!)
        Me.XrLabel20.Text = "XrLabel20"
        '
        'XrLabel19
        '
        Me.XrLabel19.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel19.BorderWidth = 0!
        Me.XrLabel19.Dpi = 254.0!
        Me.XrLabel19.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(0!, 490.0!)
        Me.XrLabel19.Multiline = True
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 0, 0, 0, 254.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(889.9999!, 79.99988!)
        Me.XrLabel19.StylePriority.UseBorders = False
        Me.XrLabel19.StylePriority.UseBorderWidth = False
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UsePadding = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.Text = "PLANNING"
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel18
        '
        Me.XrLabel18.Dpi = 254.0!
        Me.XrLabel18.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[asesmen]")})
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(0!, 419.9999!)
        Me.XrLabel18.Multiline = True
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(889.9999!, 50.0!)
        Me.XrLabel18.Text = "XrLabel18"
        '
        'XrLabel17
        '
        Me.XrLabel17.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel17.BorderWidth = 0!
        Me.XrLabel17.Dpi = 254.0!
        Me.XrLabel17.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(0!, 340.0!)
        Me.XrLabel17.Multiline = True
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 0, 0, 0, 254.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(889.9999!, 79.99994!)
        Me.XrLabel17.StylePriority.UseBorders = False
        Me.XrLabel17.StylePriority.UseBorderWidth = False
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UsePadding = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "ASSESSMENT"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine3
        '
        Me.XrLine3.Dpi = 254.0!
        Me.XrLine3.LineWidth = 3
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 470.0!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(889.9999!, 9.999939!)
        '
        'XrLabel16
        '
        Me.XrLabel16.Dpi = 254.0!
        Me.XrLabel16.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[obyektif]")})
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(0!, 270.0!)
        Me.XrLabel16.Multiline = True
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(889.9999!, 50.0!)
        Me.XrLabel16.Text = "XrLabel16"
        '
        'XrLabel15
        '
        Me.XrLabel15.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel15.BorderWidth = 0!
        Me.XrLabel15.Dpi = 254.0!
        Me.XrLabel15.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(0!, 190.0!)
        Me.XrLabel15.Multiline = True
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 0, 0, 0, 254.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(889.9999!, 80.0!)
        Me.XrLabel15.StylePriority.UseBorders = False
        Me.XrLabel15.StylePriority.UseBorderWidth = False
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UsePadding = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "OBYEKTIF"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine1
        '
        Me.XrLine1.Dpi = 254.0!
        Me.XrLine1.LineWidth = 3
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 320.0!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(889.9999!, 10.0!)
        '
        'XrLabel14
        '
        Me.XrLabel14.Dpi = 254.0!
        Me.XrLabel14.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[subyektif]")})
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(0!, 109.9999!)
        Me.XrLabel14.Multiline = True
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(889.9999!, 60.0!)
        Me.XrLabel14.Text = "XrLabel14"
        '
        'XrLabel1
        '
        Me.XrLabel1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel1.BorderWidth = 0!
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 30.0!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 0, 0, 0, 254.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(889.9999!, 79.99988!)
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseBorderWidth = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UsePadding = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "SUBYEKTIF"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'subAnatomi
        '
        Me.subAnatomi.CanShrink = True
        Me.subAnatomi.Dpi = 254.0!
        Me.subAnatomi.LocationFloat = New DevExpress.Utils.PointFloat(900.0!, 0!)
        Me.subAnatomi.Name = "subAnatomi"
        Me.subAnatomi.SizeF = New System.Drawing.SizeF(940.0!, 980.0!)
        '
        'XrLine19
        '
        Me.XrLine19.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrLine19.Dpi = 254.0!
        Me.XrLine19.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine19.LineWidth = 3
        Me.XrLine19.LocationFloat = New DevExpress.Utils.PointFloat(890.0!, 0!)
        Me.XrLine19.Name = "XrLine19"
        Me.XrLine19.SizeF = New System.Drawing.SizeF(10.0!, 980.0!)
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
        'PageHeader
        '
        Me.PageHeader.Dpi = 254.0!
        Me.PageHeader.HeightF = 0!
        Me.PageHeader.Name = "PageHeader"
        '
        'SpAMIGD201801TableAdapter
        '
        Me.SpAMIGD201801TableAdapter.ClearBeforeFill = True
        '
        'PageFooter
        '
        Me.PageFooter.Dpi = 254.0!
        Me.PageFooter.HeightF = 0!
        Me.PageFooter.Name = "PageFooter"
        '
        'pFooter
        '
        Me.pFooter.Description = "pFooter"
        Me.pFooter.Name = "pFooter"
        Me.pFooter.Visible = False
        '
        'pNo
        '
        Me.pNo.Description = "pNo"
        Me.pNo.Name = "pNo"
        Me.pNo.Visible = False
        '
        'pID
        '
        Me.pID.Description = "pID"
        Me.pID.Name = "pID"
        Me.pID.Visible = False
        '
        'SpCompanyLogoCaptionSquareTableAdapter
        '
        Me.SpCompanyLogoCaptionSquareTableAdapter.ClearBeforeFill = True
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
        'SpSN201801TableAdapter1
        '
        Me.SpSN201801TableAdapter1.ClearBeforeFill = True
        '
        'SpSN2018011
        '
        Me.SpSN2018011.DataSetName = "spSN201801"
        Me.SpSN2018011.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpCompanyLogoCaptionSquareTableAdapter1
        '
        Me.SpCompanyLogoCaptionSquareTableAdapter1.ClearBeforeFill = True
        '
        'xrSOAPIncRJ201801
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader, Me.PageFooter})
        Me.BorderWidth = 0!
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SpSN2018011})
        Me.DataAdapter = Me.SpSN201801TableAdapter1
        Me.DataMember = "spSN201801"
        Me.DataSource = Me.SpSN2018011
        Me.Dpi = 254.0!
        Me.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
        Me.PageHeight = 2970
        Me.PageWidth = 1840
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.pFooter, Me.pNo, Me.pID, Me.pUnit, Me.pNotes})
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.SnapGridSize = 10.0!
        Me.SnappingMode = CType((DevExpress.XtraReports.UI.SnappingMode.SnapLines Or DevExpress.XtraReports.UI.SnappingMode.SnapToGrid), DevExpress.XtraReports.UI.SnappingMode)
        Me.Version = "17.2"
        CType(Me.SpSN2018011, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SpAMIGD201801TableAdapter As spAMIGD201801TableAdapters.spAMIGD201801TableAdapter
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents pFooter As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents pNo As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents pID As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents SpCompanyLogoCaptionSquareTableAdapter As spAMIGD201801TableAdapters.spCompanyLogoCaptionSquareTableAdapter
    Friend WithEvents pUnit As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents pNotes As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents SpSN201801TableAdapter1 As spSN201801TableAdapters.spSN201801TableAdapter
    Friend WithEvents SpSN2018011 As spSN201801
    Friend WithEvents SpCompanyLogoCaptionSquareTableAdapter1 As spSN201801TableAdapters.spCompanyLogoCaptionSquareTableAdapter
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine7 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents subAnatomi As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents XrLine19 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
End Class
