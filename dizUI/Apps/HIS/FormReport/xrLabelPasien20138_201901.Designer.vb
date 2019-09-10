<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class xrLabelPasien20138_201901
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
        Me.XrPanel2 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.p1Sex = New DevExpress.XtraReports.Parameters.Parameter()
        Me.p1Nama = New DevExpress.XtraReports.Parameters.Parameter()
        Me.p1TglLahir = New DevExpress.XtraReports.Parameters.Parameter()
        Me.p1Umur = New DevExpress.XtraReports.Parameters.Parameter()
        Me.p1TglReg = New DevExpress.XtraReports.Parameters.Parameter()
        Me.p1Paramedis = New DevExpress.XtraReports.Parameters.Parameter()
        Me.p2Sex = New DevExpress.XtraReports.Parameters.Parameter()
        Me.p2Nama = New DevExpress.XtraReports.Parameters.Parameter()
        Me.p2TglLahir = New DevExpress.XtraReports.Parameters.Parameter()
        Me.p2Umur = New DevExpress.XtraReports.Parameters.Parameter()
        Me.p2TglReg = New DevExpress.XtraReports.Parameters.Parameter()
        Me.p2Paramedis = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPanel2, Me.XrPanel1})
        Me.Detail.Dpi = 254.0!
        Me.Detail.HeightF = 1770.0!
        Me.Detail.MultiColumn.ColumnSpacing = 15.746!
        Me.Detail.MultiColumn.ColumnWidth = 1000.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPanel2
        '
        Me.XrPanel2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrPanel2.CanGrow = False
        Me.XrPanel2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2, Me.XrLabel3, Me.XrLabel6, Me.XrLabel7, Me.XrLabel9})
        Me.XrPanel2.Dpi = 254.0!
        Me.XrPanel2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 995.0!)
        Me.XrPanel2.Name = "XrPanel2"
        Me.XrPanel2.SizeF = New System.Drawing.SizeF(1175.0!, 775.0!)
        Me.XrPanel2.StylePriority.UseBorders = False
        '
        'XrLabel2
        '
        Me.XrLabel2.Dpi = 254.0!
        Me.XrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[p2TglReg]")})
        Me.XrLabel2.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(59.99988!, 445.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(1060.0!, 100.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "XrLabel1"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel3.Dpi = 254.0!
        Me.XrLabel3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[p2Paramedis]")})
        Me.XrLabel3.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(59.99979!, 554.9999!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(1060.0!, 100.0!)
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UsePadding = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "XrLabel8"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel6.Dpi = 254.0!
        Me.XrLabel6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[p2Sex]")})
        Me.XrLabel6.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(814.7294!, 125.0!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(305.2706!, 70.0!)
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UsePadding = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "XrLabel5"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel7
        '
        Me.XrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel7.CanGrow = False
        Me.XrLabel7.Dpi = 254.0!
        Me.XrLabel7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[p2Nama]")})
        Me.XrLabel7.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(59.99979!, 201.0!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(1060.0!, 120.0!)
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UsePadding = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "XrLabel4"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel9.Dpi = 254.0!
        Me.XrLabel9.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[p2TglLahir]")})
        Me.XrLabel9.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(59.99988!, 335.0!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(1060.0!, 100.0!)
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "XrLabel6"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPanel1
        '
        Me.XrPanel1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrPanel1.CanGrow = False
        Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.XrLabel8, Me.XrLabel5, Me.XrLabel4, Me.XrLabel19})
        Me.XrPanel1.Dpi = 254.0!
        Me.XrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrPanel1.Name = "XrPanel1"
        Me.XrPanel1.SizeF = New System.Drawing.SizeF(1175.0!, 775.0!)
        Me.XrPanel1.StylePriority.UseBorders = False
        '
        'XrLabel1
        '
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[p1TglReg]")})
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(60.0!, 450.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(1060.0!, 100.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "XrLabel1"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel8.Dpi = 254.0!
        Me.XrLabel8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[p1Paramedis]")})
        Me.XrLabel8.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(59.99991!, 559.9999!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(1060.0!, 100.0!)
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UsePadding = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "XrLabel8"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel5.Dpi = 254.0!
        Me.XrLabel5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[p1Sex]")})
        Me.XrLabel5.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(814.7294!, 130.0!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(305.2706!, 70.0!)
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UsePadding = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "XrLabel5"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel4
        '
        Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel4.CanGrow = False
        Me.XrLabel4.Dpi = 254.0!
        Me.XrLabel4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[p1Nama]")})
        Me.XrLabel4.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(59.99991!, 206.0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(1060.0!, 120.0!)
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UsePadding = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "XrLabel4"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel19
        '
        Me.XrLabel19.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel19.Dpi = 254.0!
        Me.XrLabel19.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[p1TglLahir]")})
        Me.XrLabel19.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(60.0!, 340.0!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(1060.0!, 100.0!)
        Me.XrLabel19.StylePriority.UseBorders = False
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.Text = "XrLabel6"
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 254.0!
        Me.TopMargin.HeightF = 110.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 254.0!
        Me.BottomMargin.HeightF = 110.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'p1Sex
        '
        Me.p1Sex.Description = "p1Sex"
        Me.p1Sex.Name = "p1Sex"
        Me.p1Sex.Visible = False
        '
        'p1Nama
        '
        Me.p1Nama.Description = "p1Nama"
        Me.p1Nama.Name = "p1Nama"
        Me.p1Nama.Visible = False
        '
        'p1TglLahir
        '
        Me.p1TglLahir.Description = "p1TglLahir"
        Me.p1TglLahir.Name = "p1TglLahir"
        Me.p1TglLahir.Visible = False
        '
        'p1Umur
        '
        Me.p1Umur.Description = "p1Umur"
        Me.p1Umur.Name = "p1Umur"
        Me.p1Umur.Visible = False
        '
        'p1TglReg
        '
        Me.p1TglReg.Description = "p1TglReg"
        Me.p1TglReg.Name = "p1TglReg"
        Me.p1TglReg.Visible = False
        '
        'p1Paramedis
        '
        Me.p1Paramedis.Description = "p1Paramedis"
        Me.p1Paramedis.Name = "p1Paramedis"
        Me.p1Paramedis.Visible = False
        '
        'p2Sex
        '
        Me.p2Sex.Description = "p2Sex"
        Me.p2Sex.Name = "p2Sex"
        Me.p2Sex.Visible = False
        '
        'p2Nama
        '
        Me.p2Nama.Description = "p2Nama"
        Me.p2Nama.Name = "p2Nama"
        Me.p2Nama.Visible = False
        '
        'p2TglLahir
        '
        Me.p2TglLahir.Description = "p2TglLahir"
        Me.p2TglLahir.Name = "p2TglLahir"
        Me.p2TglLahir.Visible = False
        '
        'p2Umur
        '
        Me.p2Umur.Description = "p2Umur"
        Me.p2Umur.Name = "p2Umur"
        Me.p2Umur.Visible = False
        '
        'p2TglReg
        '
        Me.p2TglReg.Description = "p2TglReg"
        Me.p2TglReg.Name = "p2TglReg"
        Me.p2TglReg.Visible = False
        '
        'p2Paramedis
        '
        Me.p2Paramedis.Description = "p2Paramedis"
        Me.p2Paramedis.Name = "p2Paramedis"
        Me.p2Paramedis.Visible = False
        '
        'xrLabelPasien20138_201901
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.Dpi = 254.0!
        Me.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Margins = New System.Drawing.Printing.Margins(100, 100, 110, 110)
        Me.PageHeight = 2970
        Me.PageWidth = 1380
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.p1Sex, Me.p1Nama, Me.p1TglLahir, Me.p1Umur, Me.p1TglReg, Me.p1Paramedis, Me.p2Sex, Me.p2Nama, Me.p2TglLahir, Me.p2Umur, Me.p2TglReg, Me.p2Paramedis})
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.SnapGridSize = 10.0!
        Me.SnappingMode = CType((DevExpress.XtraReports.UI.SnappingMode.SnapLines Or DevExpress.XtraReports.UI.SnappingMode.SnapToGrid), DevExpress.XtraReports.UI.SnappingMode)
        Me.Version = "17.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents p1Sex As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents p1Nama As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents p1TglLahir As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents p1Umur As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents p1TglReg As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents p1Paramedis As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents p2Sex As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents p2Nama As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents p2TglLahir As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents p2Umur As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents p2TglReg As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents p2Paramedis As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrPanel2 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
End Class
