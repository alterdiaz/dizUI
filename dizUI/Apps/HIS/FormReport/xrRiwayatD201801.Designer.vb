<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class xrRiwayatD201801
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
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.SpRiwayatD201801TableAdapter1 = New dizUI.spRiwayatD201801TableAdapters.spRiwayatD201801TableAdapter()
        Me.SpRiwayatD2018011 = New dizUI.spRiwayatD201801()
        Me.CalculatedField1 = New DevExpress.XtraReports.UI.CalculatedField()
        CType(Me.SpRiwayatD2018011, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.XrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[riwayat]")})
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
        'SpRiwayatD201801TableAdapter1
        '
        Me.SpRiwayatD201801TableAdapter1.ClearBeforeFill = True
        '
        'SpRiwayatD2018011
        '
        Me.SpRiwayatD2018011.DataSetName = "spRiwayatD201801"
        Me.SpRiwayatD2018011.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CalculatedField1
        '
        Me.CalculatedField1.DataMember = "spRiwayatD201801"
        Me.CalculatedField1.DisplayName = "Type"
        Me.CalculatedField1.Expression = "Upper([riwayattype])"
        Me.CalculatedField1.FieldType = DevExpress.XtraReports.UI.FieldType.[String]
        Me.CalculatedField1.Name = "CalculatedField1"
        '
        'xrRiwayatD201801
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.CalculatedField1})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SpRiwayatD2018011})
        Me.DataAdapter = Me.SpRiwayatD201801TableAdapter1
        Me.DataMember = "spRiwayatD201801"
        Me.DataSource = Me.SpRiwayatD2018011
        Me.Dpi = 254.0!
        Me.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
        Me.PageHeight = 2970
        Me.PageWidth = 1840
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.SnapGridSize = 10.0!
        Me.SnappingMode = CType((DevExpress.XtraReports.UI.SnappingMode.SnapLines Or DevExpress.XtraReports.UI.SnappingMode.SnapToGrid), DevExpress.XtraReports.UI.SnappingMode)
        Me.Version = "17.2"
        CType(Me.SpRiwayatD2018011, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents SpRiwayatD201801TableAdapter1 As spRiwayatD201801TableAdapters.spRiwayatD201801TableAdapter
    Friend WithEvents SpRiwayatD2018011 As spRiwayatD201801
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CalculatedField1 As DevExpress.XtraReports.UI.CalculatedField
End Class
