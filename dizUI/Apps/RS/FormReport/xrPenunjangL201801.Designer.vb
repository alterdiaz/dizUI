<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class xrPenunjangL201801
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
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.SpPenunjangLABTableAdapter1 = New dizUI.spPenunjangLABTableAdapters.spPenunjangLABTableAdapter()
        Me.SpPenunjangLAB1 = New dizUI.spPenunjangLAB()
        CType(Me.SpPenunjangLAB1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1})
        Me.Detail.Dpi = 254.0!
        Me.Detail.HeightF = 50.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[hasilpemeriksaan]")})
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(20.0!, 0!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.NullValueText = "-"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(1800.0!, 50.0!)
        Me.XrLabel1.StylePriority.UsePadding = False
        Me.XrLabel1.Text = "XrLabel1"
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
        'SpPenunjangLABTableAdapter1
        '
        Me.SpPenunjangLABTableAdapter1.ClearBeforeFill = True
        '
        'SpPenunjangLAB1
        '
        Me.SpPenunjangLAB1.DataSetName = "spPenunjangLAB"
        Me.SpPenunjangLAB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'xrPenunjangL201801
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SpPenunjangLAB1})
        Me.DataAdapter = Me.SpPenunjangLABTableAdapter1
        Me.DataMember = "spPenunjangLAB"
        Me.DataSource = Me.SpPenunjangLAB1
        Me.Dpi = 254.0!
        Me.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
        Me.PageHeight = 2970
        Me.PageWidth = 1840
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.SnapGridSize = 10.0!
        Me.Version = "17.2"
        CType(Me.SpPenunjangLAB1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents SpPenunjangLABTableAdapter1 As spPenunjangLABTableAdapters.spPenunjangLABTableAdapter
    Friend WithEvents SpPenunjangLAB1 As spPenunjangLAB
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
End Class
