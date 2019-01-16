<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class xrPPP
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
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.SetPPP1 = New dizUI.setPPP()
        Me.XrPPPTableAdapter = New dizUI.setPPPTableAdapters.xrPPPTableAdapter()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.intsaldosebelum = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.strtanggalsebelum = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.strtanggal = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.namahari = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.namabank = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel()
        Me.tanggalcetak = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.username = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel39 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.namadiketahui = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.namapemohon = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.namadisetujui = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.intsaldosesudah = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel41 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.SetPPP1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.XrLabel1})
        Me.Detail.Dpi = 254.0!
        Me.Detail.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Detail.HeightF = 80.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("posisidk", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("tanggalpemohon", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.Detail.StylePriority.UseFont = False
        Me.Detail.StylePriority.UseTextAlignment = False
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel4
        '
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "xrPPP.nodokumen")})
        Me.XrLabel4.Dpi = 254.0!
        Me.XrLabel4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(260.0!, 0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(1326.0!, 39.99998!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "XrLabel4"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "xrPPP.keperluan")})
        Me.XrLabel3.Dpi = 254.0!
        Me.XrLabel3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(260.0!, 39.99998!)
        Me.XrLabel3.Multiline = True
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(1326.0!, 39.99998!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "XrLabel3"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "xrPPP.nomorurut")})
        Me.XrLabel2.Dpi = 254.0!
        Me.XrLabel2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(260.0!, 39.99998!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "XrLabel2"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "xrPPP.jumlahuang", "{0:#,#.00}")})
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(1586.0!, 0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(412.0!, 40.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "XrLabel1"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 254.0!
        Me.TopMargin.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.TopMargin.HeightF = 40.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.TopMargin.StylePriority.UseFont = False
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 254.0!
        Me.BottomMargin.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.BottomMargin.HeightF = 40.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.BottomMargin.StylePriority.UseFont = False
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'SetPPP1
        '
        Me.SetPPP1.DataSetName = "setPPP"
        Me.SetPPP1.EnforceConstraints = False
        Me.SetPPP1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'XrPPPTableAdapter
        '
        Me.XrPPPTableAdapter.ClearBeforeFill = True
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine2, Me.XrLabel5})
        Me.GroupHeader1.Dpi = 254.0!
        Me.GroupHeader1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("posisidk", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.HeightF = 60.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.StylePriority.UseFont = False
        '
        'XrLine2
        '
        Me.XrLine2.Dpi = 254.0!
        Me.XrLine2.LineWidth = 3
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(2000.0!, 20.0!)
        '
        'XrLabel5
        '
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "xrPPP.posisidk")})
        Me.XrLabel5.Dpi = 254.0!
        Me.XrLabel5.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(0!, 20.0!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(889.0!, 40.0!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "XrLabel5"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel18, Me.XrLabel17, Me.XrLabel16, Me.XrLabel15, Me.XrLabel14, Me.XrLabel13, Me.XrLabel12, Me.XrLabel11, Me.XrLabel10, Me.XrLabel9, Me.XrLabel8, Me.XrLabel7, Me.XrLabel6})
        Me.PageHeader.Dpi = 254.0!
        Me.PageHeader.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.PageHeader.HeightF = 242.5!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.StylePriority.UseFont = False
        '
        'XrLabel18
        '
        Me.XrLabel18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.intsaldosebelum, "Text", "{0:#,#.00}")})
        Me.XrLabel18.Dpi = 254.0!
        Me.XrLabel18.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(1586.0!, 200.0!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(412.0!, 40.0!)
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "XrLabel18"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'intsaldosebelum
        '
        Me.intsaldosebelum.Description = "intsaldosebelum"
        Me.intsaldosebelum.Name = "intsaldosebelum"
        Me.intsaldosebelum.Type = GetType(Decimal)
        Me.intsaldosebelum.ValueInfo = "0"
        Me.intsaldosebelum.Visible = False
        '
        'XrLabel17
        '
        Me.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.strtanggalsebelum, "Text", "")})
        Me.XrLabel17.Dpi = 254.0!
        Me.XrLabel17.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(855.75!, 200.0!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(730.0!, 40.0!)
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "XrLabel17"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'strtanggalsebelum
        '
        Me.strtanggalsebelum.Description = "strtanggalsebelum"
        Me.strtanggalsebelum.Name = "strtanggalsebelum"
        Me.strtanggalsebelum.Visible = False
        '
        'XrLabel16
        '
        Me.XrLabel16.Dpi = 254.0!
        Me.XrLabel16.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(570.0!, 200.0!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(285.0!, 40.0!)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "Saldo per tanggal "
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel15
        '
        Me.XrLabel15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.strtanggal, "Text", "")})
        Me.XrLabel15.Dpi = 254.0!
        Me.XrLabel15.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(180.0!, 140.0!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(698.5001!, 39.99997!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "XrLabel15"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'strtanggal
        '
        Me.strtanggal.Description = "strtanggal"
        Me.strtanggal.Name = "strtanggal"
        Me.strtanggal.Visible = False
        '
        'XrLabel14
        '
        Me.XrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.namahari, "Text", "")})
        Me.XrLabel14.Dpi = 254.0!
        Me.XrLabel14.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(180.0!, 100.0!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(698.4999!, 39.99998!)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "XrLabel14"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'namahari
        '
        Me.namahari.Description = "namahari"
        Me.namahari.Name = "namahari"
        Me.namahari.Visible = False
        '
        'XrLabel13
        '
        Me.XrLabel13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.namabank, "Text", "")})
        Me.XrLabel13.Dpi = 254.0!
        Me.XrLabel13.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(180.0!, 60.0!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(698.4999!, 39.99998!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "XrLabel13"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'namabank
        '
        Me.namabank.Description = "namabank"
        Me.namabank.Name = "namabank"
        Me.namabank.Visible = False
        '
        'XrLabel12
        '
        Me.XrLabel12.Dpi = 254.0!
        Me.XrLabel12.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(160.0!, 140.0!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(20.00003!, 39.99997!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = ":"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel11
        '
        Me.XrLabel11.Dpi = 254.0!
        Me.XrLabel11.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(160.0!, 99.99998!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(20.00003!, 39.99998!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = ":"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel10
        '
        Me.XrLabel10.Dpi = 254.0!
        Me.XrLabel10.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(160.0!, 60.0!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(20.00003!, 40.00001!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = ":"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel9
        '
        Me.XrLabel9.Dpi = 254.0!
        Me.XrLabel9.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(0!, 140.0!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(160.0!, 40.00005!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Tanggal"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.Dpi = 254.0!
        Me.XrLabel8.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(0!, 99.99998!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(160.0!, 39.99998!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "Hari"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.Dpi = 254.0!
        Me.XrLabel7.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(0!, 60.0!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(160.0!, 39.99998!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Bank"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.Dpi = 254.0!
        Me.XrLabel6.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(1143.0!, 39.99998!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "PENGAJUAN PENERIMAAN & PENGELUARAN UANG BANK"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine3, Me.XrLabel28, Me.XrLabel27, Me.XrLabel39, Me.XrLine1, Me.XrLabel26, Me.XrLabel25, Me.XrLabel24, Me.XrLabel23, Me.XrLabel22, Me.XrLabel33, Me.XrLabel21, Me.XrLabel20, Me.XrLabel19, Me.XrLabel41})
        Me.ReportFooter.Dpi = 254.0!
        Me.ReportFooter.HeightF = 630.0!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrLine3
        '
        Me.XrLine3.Dpi = 254.0!
        Me.XrLine3.LineWidth = 3
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(2000.0!, 20.0!)
        '
        'XrLabel28
        '
        Me.XrLabel28.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.tanggalcetak, "Text", "")})
        Me.XrLabel28.Dpi = 254.0!
        Me.XrLabel28.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.XrLabel28.LocationFloat = New DevExpress.Utils.PointFloat(1270.0!, 590.0!)
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel28.SizeF = New System.Drawing.SizeF(420.0!, 39.99994!)
        Me.XrLabel28.StylePriority.UseFont = False
        Me.XrLabel28.StylePriority.UseTextAlignment = False
        Me.XrLabel28.Text = "XrLabel28"
        Me.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'tanggalcetak
        '
        Me.tanggalcetak.Description = "tanggalcetak"
        Me.tanggalcetak.Name = "tanggalcetak"
        Me.tanggalcetak.Visible = False
        '
        'XrLabel27
        '
        Me.XrLabel27.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.username, "Text", "")})
        Me.XrLabel27.Dpi = 254.0!
        Me.XrLabel27.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(530.0!, 590.0!)
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(460.0001!, 39.99994!)
        Me.XrLabel27.StylePriority.UseFont = False
        Me.XrLabel27.StylePriority.UseTextAlignment = False
        Me.XrLabel27.Text = "XrLabel27"
        Me.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'username
        '
        Me.username.Description = "username"
        Me.username.Name = "username"
        Me.username.Visible = False
        '
        'XrLabel39
        '
        Me.XrLabel39.Dpi = 254.0!
        Me.XrLabel39.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.XrLabel39.LocationFloat = New DevExpress.Utils.PointFloat(308.75!, 590.0!)
        Me.XrLabel39.Name = "XrLabel39"
        Me.XrLabel39.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel39.SizeF = New System.Drawing.SizeF(221.0!, 40.0!)
        Me.XrLabel39.StylePriority.UseBorders = False
        Me.XrLabel39.StylePriority.UseFont = False
        Me.XrLabel39.StylePriority.UsePadding = False
        Me.XrLabel39.StylePriority.UseTextAlignment = False
        Me.XrLabel39.Text = "Dicetak oleh:"
        Me.XrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine1
        '
        Me.XrLine1.Dpi = 254.0!
        Me.XrLine1.LineWidth = 3
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 569.9998!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(2000.0!, 20.0!)
        '
        'XrLabel26
        '
        Me.XrLabel26.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.namadiketahui, "Text", "")})
        Me.XrLabel26.Dpi = 254.0!
        Me.XrLabel26.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel26.LocationFloat = New DevExpress.Utils.PointFloat(793.75!, 521.5001!)
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel26.SizeF = New System.Drawing.SizeF(444.5!, 48.49994!)
        Me.XrLabel26.StylePriority.UseFont = False
        Me.XrLabel26.StylePriority.UseTextAlignment = False
        Me.XrLabel26.Text = "XrLabel26"
        Me.XrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'namadiketahui
        '
        Me.namadiketahui.Description = "namadiketahui"
        Me.namadiketahui.Name = "namadiketahui"
        Me.namadiketahui.Visible = False
        '
        'XrLabel25
        '
        Me.XrLabel25.Dpi = 254.0!
        Me.XrLabel25.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(793.75!, 330.0!)
        Me.XrLabel25.Multiline = True
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.SizeF = New System.Drawing.SizeF(444.5!, 40.00006!)
        Me.XrLabel25.StylePriority.UseBorders = False
        Me.XrLabel25.StylePriority.UseFont = False
        Me.XrLabel25.StylePriority.UseTextAlignment = False
        Me.XrLabel25.Text = "Diketahui oleh,"
        Me.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel24
        '
        Me.XrLabel24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.namapemohon, "Text", "")})
        Me.XrLabel24.Dpi = 254.0!
        Me.XrLabel24.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(1397.0!, 270.0!)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(444.5!, 39.99997!)
        Me.XrLabel24.StylePriority.UseFont = False
        Me.XrLabel24.StylePriority.UseTextAlignment = False
        Me.XrLabel24.Text = "XrLabel24"
        Me.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'namapemohon
        '
        Me.namapemohon.Description = "namapemohon"
        Me.namapemohon.Name = "namapemohon"
        Me.namapemohon.Visible = False
        '
        'XrLabel23
        '
        Me.XrLabel23.Dpi = 254.0!
        Me.XrLabel23.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(1397.0!, 90.0!)
        Me.XrLabel23.Multiline = True
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(444.5!, 39.99998!)
        Me.XrLabel23.StylePriority.UseBorders = False
        Me.XrLabel23.StylePriority.UseFont = False
        Me.XrLabel23.StylePriority.UseTextAlignment = False
        Me.XrLabel23.Text = "Pemohon,"
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel22
        '
        Me.XrLabel22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.namadisetujui, "Text", "")})
        Me.XrLabel22.Dpi = 254.0!
        Me.XrLabel22.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(158.75!, 270.0!)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(444.5!, 39.99997!)
        Me.XrLabel22.StylePriority.UseFont = False
        Me.XrLabel22.StylePriority.UseTextAlignment = False
        Me.XrLabel22.Text = "XrLabel22"
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'namadisetujui
        '
        Me.namadisetujui.Description = "namadisetujui"
        Me.namadisetujui.Name = "namadisetujui"
        Me.namadisetujui.Visible = False
        '
        'XrLabel33
        '
        Me.XrLabel33.Dpi = 254.0!
        Me.XrLabel33.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(158.75!, 90.0!)
        Me.XrLabel33.Multiline = True
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.SizeF = New System.Drawing.SizeF(444.5!, 39.99998!)
        Me.XrLabel33.StylePriority.UseBorders = False
        Me.XrLabel33.StylePriority.UseFont = False
        Me.XrLabel33.StylePriority.UseTextAlignment = False
        Me.XrLabel33.Text = "Disetujui oleh,"
        Me.XrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel21
        '
        Me.XrLabel21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.intsaldosesudah, "Text", "{0:#,#.00}")})
        Me.XrLabel21.Dpi = 254.0!
        Me.XrLabel21.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(1586.0!, 20.00002!)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(412.0!, 40.0!)
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        Me.XrLabel21.Text = "XrLabel21"
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'intsaldosesudah
        '
        Me.intsaldosesudah.Description = "intsaldosesudah"
        Me.intsaldosesudah.Name = "intsaldosesudah"
        Me.intsaldosesudah.Type = GetType(Decimal)
        Me.intsaldosesudah.ValueInfo = "0"
        Me.intsaldosesudah.Visible = False
        '
        'XrLabel20
        '
        Me.XrLabel20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.strtanggal, "Text", "")})
        Me.XrLabel20.Dpi = 254.0!
        Me.XrLabel20.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(950.0!, 20.00002!)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(635.0001!, 39.99998!)
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.Text = "XrLabel20"
        '
        'XrLabel19
        '
        Me.XrLabel19.Dpi = 254.0!
        Me.XrLabel19.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(570.0001!, 20.0!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(380.0!, 40.00004!)
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.Text = "Saldo Akhir per tanggal "
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel41
        '
        Me.XrLabel41.Dpi = 254.0!
        Me.XrLabel41.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.XrLabel41.LocationFloat = New DevExpress.Utils.PointFloat(1030.0!, 590.0!)
        Me.XrLabel41.Name = "XrLabel41"
        Me.XrLabel41.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel41.SizeF = New System.Drawing.SizeF(240.0001!, 39.99994!)
        Me.XrLabel41.StylePriority.UseBorders = False
        Me.XrLabel41.StylePriority.UseFont = False
        Me.XrLabel41.StylePriority.UsePadding = False
        Me.XrLabel41.StylePriority.UseTextAlignment = False
        Me.XrLabel41.Text = "Pada tanggal:"
        Me.XrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrPPP
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader1, Me.PageHeader, Me.ReportFooter})
        Me.DataAdapter = Me.XrPPPTableAdapter
        Me.DataMember = "xrPPP"
        Me.DataSource = Me.SetPPP1
        Me.Dpi = 254.0!
        Me.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Margins = New System.Drawing.Printing.Margins(50, 50, 40, 40)
        Me.PageHeight = 2970
        Me.PageWidth = 2100
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.namabank, Me.namahari, Me.strtanggal, Me.strtanggalsebelum, Me.intsaldosebelum, Me.intsaldosesudah, Me.namadisetujui, Me.namapemohon, Me.namadiketahui, Me.username, Me.tanggalcetak})
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.SnapGridSize = 10.0!
        Me.SnappingMode = CType((DevExpress.XtraReports.UI.SnappingMode.SnapLines Or DevExpress.XtraReports.UI.SnappingMode.SnapToGrid), DevExpress.XtraReports.UI.SnappingMode)
        Me.Version = "17.2"
        CType(Me.SetPPP1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents SetPPP1 As dizUI.setPPP
    Friend WithEvents XrPPPTableAdapter As dizUI.setPPPTableAdapters.xrPPPTableAdapter
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents namabank As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents namahari As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents strtanggal As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents intsaldosebelum As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents strtanggalsebelum As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents intsaldosesudah As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents namadiketahui As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents namapemohon As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents namadisetujui As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel39 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents username As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel41 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents tanggalcetak As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
End Class
