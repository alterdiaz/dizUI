<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class xrJurnal
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
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.tanggaljurnal = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel41 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.tanggalcetak = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.username = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel39 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.SpJurnal1 = New dizUI.spJurnal()
        Me.SpRepJurnalTableAdapter = New dizUI.spJurnalTableAdapters.spRepJurnalTableAdapter()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        CType(Me.SpJurnal1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel12, Me.XrLabel11, Me.XrLabel10, Me.XrLabel9, Me.XrLabel8, Me.XrLabel7, Me.XrLine1})
        Me.Detail.Dpi = 254.0!
        Me.Detail.HeightF = 100.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel12
        '
        Me.XrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "spRepJurnal.kredit")})
        Me.XrLabel12.Dpi = 254.0!
        Me.XrLabel12.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(1299.75!, 20.0!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel12.Scripts.OnTextChanged = "XrLabel12_TextChanged"
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(350.0!, 80.0!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "XrLabel12"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel11
        '
        Me.XrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "spRepJurnal.debet")})
        Me.XrLabel11.Dpi = 254.0!
        Me.XrLabel11.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(1650.0!, 20.0!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(350.0!, 80.0!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "XrLabel11"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel10
        '
        Me.XrLabel10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "spRepJurnal.keterangan")})
        Me.XrLabel10.Dpi = 254.0!
        Me.XrLabel10.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(254.0!, 60.0!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(1045.0!, 40.0!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "XrLabel10"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "spRepJurnal.rekening")})
        Me.XrLabel9.Dpi = 254.0!
        Me.XrLabel9.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(254.0!, 19.99998!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(1045.0!, 40.0!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "XrLabel9"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "spRepJurnal.coa")})
        Me.XrLabel8.Dpi = 254.0!
        Me.XrLabel8.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(0!, 59.99996!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(254.0!, 40.0!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "XrLabel8"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "spRepJurnal.tanggaljurnal")})
        Me.XrLabel7.Dpi = 254.0!
        Me.XrLabel7.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(0!, 20.0!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(254.0!, 40.0!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "XrLabel7"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine1
        '
        Me.XrLine1.Dpi = 254.0!
        Me.XrLine1.LineWidth = 3
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(2000.0!, 20.0!)
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
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine3, Me.XrLabel16, Me.XrLabel15, Me.XrLabel14, Me.XrLabel3, Me.XrLabel2, Me.XrLabel1, Me.XrLabel6})
        Me.PageHeader.Dpi = 254.0!
        Me.PageHeader.HeightF = 180.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel16
        '
        Me.XrLabel16.Dpi = 254.0!
        Me.XrLabel16.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(0!, 140.0!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(1299.0!, 40.0!)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "KETERANGAN"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel15
        '
        Me.XrLabel15.Dpi = 254.0!
        Me.XrLabel15.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(1649.25!, 140.0!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(350.0!, 40.0!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "KREDIT"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel14
        '
        Me.XrLabel14.Dpi = 254.0!
        Me.XrLabel14.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(1299.0!, 140.0!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(350.0!, 40.0!)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "DEBET"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.tanggaljurnal, "Text", "")})
        Me.XrLabel3.Dpi = 254.0!
        Me.XrLabel3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(190.4999!, 63.50002!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(529.0!, 40.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "XrLabel3"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'tanggaljurnal
        '
        Me.tanggaljurnal.Description = "tanggaljurnal"
        Me.tanggaljurnal.Name = "tanggaljurnal"
        Me.tanggaljurnal.Visible = False
        '
        'XrLabel2
        '
        Me.XrLabel2.Dpi = 254.0!
        Me.XrLabel2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(158.75!, 63.5!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(31.0!, 40.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = ":"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 63.5!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(158.0!, 40.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Tanggal"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.Dpi = 254.0!
        Me.XrLabel6.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(1143.0!, 63.5!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "JURNAL"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel41, Me.XrLabel5, Me.XrLabel4, Me.XrLabel39, Me.XrLine2})
        Me.ReportFooter.Dpi = 254.0!
        Me.ReportFooter.HeightF = 60.00003!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrLabel41
        '
        Me.XrLabel41.Dpi = 254.0!
        Me.XrLabel41.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.XrLabel41.LocationFloat = New DevExpress.Utils.PointFloat(999.0!, 20.0!)
        Me.XrLabel41.Name = "XrLabel41"
        Me.XrLabel41.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel41.SizeF = New System.Drawing.SizeF(240.0!, 40.0!)
        Me.XrLabel41.StylePriority.UseBorders = False
        Me.XrLabel41.StylePriority.UseFont = False
        Me.XrLabel41.StylePriority.UsePadding = False
        Me.XrLabel41.StylePriority.UseTextAlignment = False
        Me.XrLabel41.Text = "Pada tanggal:"
        Me.XrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.tanggalcetak, "Text", "")})
        Me.XrLabel5.Dpi = 254.0!
        Me.XrLabel5.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(1239.75!, 20.0!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(410.0!, 40.0!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "XrLabel5"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'tanggalcetak
        '
        Me.tanggalcetak.Description = "tanggalcetak"
        Me.tanggalcetak.Name = "tanggalcetak"
        Me.tanggalcetak.Visible = False
        '
        'XrLabel4
        '
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.username, "Text", "")})
        Me.XrLabel4.Dpi = 254.0!
        Me.XrLabel4.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(489.0!, 20.0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(510.0!, 40.0!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "XrLabel4"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
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
        Me.XrLabel39.LocationFloat = New DevExpress.Utils.PointFloat(266.75!, 20.0!)
        Me.XrLabel39.Name = "XrLabel39"
        Me.XrLabel39.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel39.SizeF = New System.Drawing.SizeF(200.0!, 40.0!)
        Me.XrLabel39.StylePriority.UseBorders = False
        Me.XrLabel39.StylePriority.UseFont = False
        Me.XrLabel39.StylePriority.UsePadding = False
        Me.XrLabel39.StylePriority.UseTextAlignment = False
        Me.XrLabel39.Text = "Dicetak oleh:"
        Me.XrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine2
        '
        Me.XrLine2.Dpi = 254.0!
        Me.XrLine2.LineWidth = 3
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(2000.0!, 20.0!)
        '
        'SpJurnal1
        '
        Me.SpJurnal1.DataSetName = "spJurnal"
        Me.SpJurnal1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpRepJurnalTableAdapter
        '
        Me.SpRepJurnalTableAdapter.ClearBeforeFill = True
        '
        'XrLine3
        '
        Me.XrLine3.Dpi = 254.0!
        Me.XrLine3.LineWidth = 3
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 120.0!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(2000.0!, 20.0!)
        '
        'xrJurnal
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader, Me.ReportFooter})
        Me.DataAdapter = Me.SpRepJurnalTableAdapter
        Me.DataMember = "spRepJurnal"
        Me.DataSource = Me.SpJurnal1
        Me.Dpi = 254.0!
        Me.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Margins = New System.Drawing.Printing.Margins(50, 50, 40, 40)
        Me.PageHeight = 2970
        Me.PageWidth = 2100
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.tanggaljurnal, Me.username, Me.tanggalcetak})
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.ScriptsSource = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.SnapGridSize = 10.0!
        Me.SnappingMode = CType((DevExpress.XtraReports.UI.SnappingMode.SnapLines Or DevExpress.XtraReports.UI.SnappingMode.SnapToGrid), DevExpress.XtraReports.UI.SnappingMode)
        Me.Version = "17.2"
        CType(Me.SpJurnal1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents tanggaljurnal As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLabel39 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents username As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel41 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents tanggalcetak As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SpJurnal1 As dizUI.spJurnal
    Friend WithEvents SpRepJurnalTableAdapter As dizUI.spJurnalTableAdapters.spRepJurnalTableAdapter
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
End Class
