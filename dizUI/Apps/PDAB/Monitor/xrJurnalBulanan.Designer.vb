<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class xrJurnalBulanan
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
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.bulantahunstr = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.tanggalcetak = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.username = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel41 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel39 = New DevExpress.XtraReports.UI.XRLabel()
        Me.SpJurnalBulanan1 = New dizUI.spJurnalBulanan()
        Me.SpRepJurnalBulananTableAdapter = New dizUI.spJurnalBulananTableAdapters.spRepJurnalBulananTableAdapter()
        CType(Me.SpJurnalBulanan1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1, Me.XrLabel7, Me.XrLabel6, Me.XrLabel5, Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.XrLabel1})
        Me.Detail.Dpi = 254.0!
        Me.Detail.HeightF = 218.9858!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine1
        '
        Me.XrLine1.Dpi = 254.0!
        Me.XrLine1.LineWidth = 3
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(1841.5!, 31.75!)
        '
        'XrLabel7
        '
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "spRepJurnalBulanan.kredit")})
        Me.XrLabel7.Dpi = 254.0!
        Me.XrLabel7.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(1492.25!, 31.75!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(347.7914!, 127.0!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "XrLabel7"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel6
        '
        Me.XrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "spRepJurnalBulanan.debet")})
        Me.XrLabel6.Dpi = 254.0!
        Me.XrLabel6.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(1143.0!, 31.75!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(349.25!, 127.0!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "XrLabel6"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel5
        '
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "spRepJurnalBulanan.keterangan")})
        Me.XrLabel5.Dpi = 254.0!
        Me.XrLabel5.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(0!, 158.75!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(1841.5!, 57.59!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "XrLabel5"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "spRepJurnalBulanan.rekening")})
        Me.XrLabel4.Dpi = 254.0!
        Me.XrLabel4.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(254.0!, 31.75!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(889.0!, 58.41997!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "XrLabel4"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "spRepJurnalBulanan.coa")})
        Me.XrLabel3.Dpi = 254.0!
        Me.XrLabel3.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(254.0!, 95.25!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(889.0!, 58.41997!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "XrLabel3"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "spRepJurnalBulanan.nobukti")})
        Me.XrLabel2.Dpi = 254.0!
        Me.XrLabel2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 95.25!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(254.0!, 58.42!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "XrLabel2"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "spRepJurnalBulanan.tanggaljurnal")})
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 31.75!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(254.0!, 58.42!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "XrLabel1"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 254.0!
        Me.TopMargin.HeightF = 24.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 254.0!
        Me.BottomMargin.HeightF = 130.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel16, Me.XrLabel15, Me.XrLabel14, Me.XrLabel13, Me.XrLabel10, Me.XrLabel9, Me.XrLabel8})
        Me.PageHeader.Dpi = 254.0!
        Me.PageHeader.HeightF = 222.25!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel16
        '
        Me.XrLabel16.Dpi = 254.0!
        Me.XrLabel16.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(0!, 158.75!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(1143.0!, 63.5!)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "KETERANGAN"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel15
        '
        Me.XrLabel15.Dpi = 254.0!
        Me.XrLabel15.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(1492.25!, 158.75!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(349.25!, 63.5!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "KREDIT"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel14
        '
        Me.XrLabel14.Dpi = 254.0!
        Me.XrLabel14.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(1143.0!, 158.75!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(349.25!, 63.5!)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "DEBET"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel13
        '
        Me.XrLabel13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.bulantahunstr, "Text", "")})
        Me.XrLabel13.Dpi = 254.0!
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(190.5!, 63.5!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(595.3125!, 63.5!)
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "XrLabel13"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'bulantahunstr
        '
        Me.bulantahunstr.Description = "bulantahunstr"
        Me.bulantahunstr.Name = "bulantahunstr"
        Me.bulantahunstr.Visible = False
        '
        'XrLabel10
        '
        Me.XrLabel10.Dpi = 254.0!
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(158.75!, 63.5!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(31.75!, 63.5!)
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = ":"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel9
        '
        Me.XrLabel9.Dpi = 254.0!
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(0!, 63.5!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(158.75!, 63.5!)
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Bulan"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.Dpi = 254.0!
        Me.XrLabel8.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(1143.0!, 63.5!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "JURNAL"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel12, Me.XrLabel11, Me.XrLabel41, Me.XrLine2, Me.XrLabel39})
        Me.ReportFooter.Dpi = 254.0!
        Me.ReportFooter.HeightF = 95.25!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrLabel12
        '
        Me.XrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.tanggalcetak, "Text", "")})
        Me.XrLabel12.Dpi = 254.0!
        Me.XrLabel12.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(1238.25!, 31.75!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(412.75!, 63.5!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "XrLabel12"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'tanggalcetak
        '
        Me.tanggalcetak.Description = "tanggalcetak"
        Me.tanggalcetak.Name = "tanggalcetak"
        Me.tanggalcetak.Visible = False
        '
        'XrLabel11
        '
        Me.XrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.username, "Text", "")})
        Me.XrLabel11.Dpi = 254.0!
        Me.XrLabel11.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(489.125!, 31.75!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(507.9999!, 63.5!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "XrLabel11"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'username
        '
        Me.username.Description = "username"
        Me.username.Name = "username"
        Me.username.Visible = False
        '
        'XrLabel41
        '
        Me.XrLabel41.Dpi = 254.0!
        Me.XrLabel41.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.XrLabel41.LocationFloat = New DevExpress.Utils.PointFloat(997.125!, 31.75!)
        Me.XrLabel41.Name = "XrLabel41"
        Me.XrLabel41.SizeF = New System.Drawing.SizeF(241.125!, 63.5!)
        Me.XrLabel41.StylePriority.UseBorders = False
        Me.XrLabel41.StylePriority.UseFont = False
        Me.XrLabel41.StylePriority.UseTextAlignment = False
        Me.XrLabel41.Text = "Pada tanggal:"
        Me.XrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine2
        '
        Me.XrLine2.Dpi = 254.0!
        Me.XrLine2.LineWidth = 3
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(1841.5!, 31.75!)
        '
        'XrLabel39
        '
        Me.XrLabel39.Dpi = 254.0!
        Me.XrLabel39.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.XrLabel39.LocationFloat = New DevExpress.Utils.PointFloat(266.875!, 31.75!)
        Me.XrLabel39.Name = "XrLabel39"
        Me.XrLabel39.SizeF = New System.Drawing.SizeF(222.25!, 63.5!)
        Me.XrLabel39.StylePriority.UseBorders = False
        Me.XrLabel39.StylePriority.UseFont = False
        Me.XrLabel39.StylePriority.UseTextAlignment = False
        Me.XrLabel39.Text = "Dicetak oleh:"
        Me.XrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'SpJurnalBulanan1
        '
        Me.SpJurnalBulanan1.DataSetName = "spJurnalBulanan"
        Me.SpJurnalBulanan1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpRepJurnalBulananTableAdapter
        '
        Me.SpRepJurnalBulananTableAdapter.ClearBeforeFill = True
        '
        'xrJurnalBulanan
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader, Me.ReportFooter})
        Me.DataAdapter = Me.SpRepJurnalBulananTableAdapter
        Me.DataMember = "spRepJurnalBulanan"
        Me.DataSource = Me.SpJurnalBulanan1
        Me.Dpi = 254.0!
        Me.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Margins = New System.Drawing.Printing.Margins(127, 130, 24, 130)
        Me.PageHeight = 2970
        Me.PageWidth = 2100
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.username, Me.tanggalcetak, Me.bulantahunstr})
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.SnapGridSize = 31.75!
        Me.SnappingMode = DevExpress.XtraReports.UI.SnappingMode.SnapToGrid
        Me.Version = "17.2"
        CType(Me.SpJurnalBulanan1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLabel41 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel39 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents username As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents tanggalcetak As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents bulantahunstr As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SpJurnalBulanan1 As dizUI.spJurnalBulanan
    Friend WithEvents SpRepJurnalBulananTableAdapter As dizUI.spJurnalBulananTableAdapters.spRepJurnalBulananTableAdapter
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
End Class
