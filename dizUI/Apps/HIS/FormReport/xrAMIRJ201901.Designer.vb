﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class xrAMIRJ201901
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
        Me.subSOAP = New DevExpress.XtraReports.UI.XRSubreport()
        Me.SubBand1 = New DevExpress.XtraReports.UI.SubBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel41 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel40 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel39 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel38 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrCheckBox8 = New DevExpress.XtraReports.UI.XRCheckBox()
        Me.XrCheckBox9 = New DevExpress.XtraReports.UI.XRCheckBox()
        Me.XrCheckBox10 = New DevExpress.XtraReports.UI.XRCheckBox()
        Me.XrLabel37 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrCheckBox7 = New DevExpress.XtraReports.UI.XRCheckBox()
        Me.XrCheckBox5 = New DevExpress.XtraReports.UI.XRCheckBox()
        Me.XrCheckBox6 = New DevExpress.XtraReports.UI.XRCheckBox()
        Me.XrCheckBox3 = New DevExpress.XtraReports.UI.XRCheckBox()
        Me.XrCheckBox4 = New DevExpress.XtraReports.UI.XRCheckBox()
        Me.XrCheckBox2 = New DevExpress.XtraReports.UI.XRCheckBox()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrCheckBox1 = New DevExpress.XtraReports.UI.XRCheckBox()
        Me.XrLine12 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel36 = New DevExpress.XtraReports.UI.XRLabel()
        Me.pID = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrbcIDRM = New DevExpress.XtraReports.UI.XRBarCode()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel67 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel66 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.SpAMIGD201801TableAdapter = New dizUI.spAMIGD201801TableAdapters.spAMIGD201801TableAdapter()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel86 = New DevExpress.XtraReports.UI.XRLabel()
        Me.pFooter = New DevExpress.XtraReports.Parameters.Parameter()
        Me.pNo = New DevExpress.XtraReports.Parameters.Parameter()
        Me.SpCompanyLogoCaptionSquareTableAdapter = New dizUI.spAMIGD201801TableAdapters.spCompanyLogoCaptionSquareTableAdapter()
        Me.pUnit = New DevExpress.XtraReports.Parameters.Parameter()
        Me.pNotes = New DevExpress.XtraReports.Parameters.Parameter()
        Me.SpCompanyLogoCaptionSquareTableAdapter1 = New dizUI.spCompanyLogoCaptionSquareTableAdapters.spCompanyLogoCaptionSquareTableAdapter()
        Me.spAMIRJ2018011 = New dizUI.spAMIRJ201801()
        Me.spAMIRJ201801TableAdapter = New dizUI.spAMIRJ201801TableAdapters.spAMIRJ201801TableAdapter()
        Me.SpSN201801TableAdapter = New dizUI.spSN201801TableAdapters.spSN201801TableAdapter()
        CType(Me.spAMIRJ2018011, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.subSOAP})
        Me.Detail.Dpi = 254.0!
        Me.Detail.HeightF = 90.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.Detail.SubBands.AddRange(New DevExpress.XtraReports.UI.SubBand() {Me.SubBand1})
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'subSOAP
        '
        Me.subSOAP.Dpi = 254.0!
        Me.subSOAP.LocationFloat = New DevExpress.Utils.PointFloat(79.19994!, 0!)
        Me.subSOAP.Name = "subSOAP"
        Me.subSOAP.SizeF = New System.Drawing.SizeF(1840.0!, 90.0!)
        '
        'SubBand1
        '
        Me.SubBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.XrLine3, Me.XrLabel41, Me.XrLabel40, Me.XrLabel39, Me.XrLine2, Me.XrLabel38, Me.XrCheckBox8, Me.XrCheckBox9, Me.XrCheckBox10, Me.XrLabel37, Me.XrCheckBox7, Me.XrCheckBox5, Me.XrCheckBox6, Me.XrCheckBox3, Me.XrCheckBox4, Me.XrCheckBox2, Me.XrLine1, Me.XrCheckBox1, Me.XrLine12, Me.XrLabel36})
        Me.SubBand1.Dpi = 254.0!
        Me.SubBand1.HeightF = 870.0!
        Me.SubBand1.Name = "SubBand1"
        '
        'XrLabel1
        '
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[dokterruangan]")})
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(80.80022!, 770.0!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(879.9998!, 100.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "XrLabel1"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine3
        '
        Me.XrLine3.Dpi = 254.0!
        Me.XrLine3.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine3.LineWidth = 3
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(990.8003!, 500.0!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(10.0!, 370.0!)
        '
        'XrLabel41
        '
        Me.XrLabel41.Dpi = 254.0!
        Me.XrLabel41.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel41.LocationFloat = New DevExpress.Utils.PointFloat(80.80014!, 510.0001!)
        Me.XrLabel41.Multiline = True
        Me.XrLabel41.Name = "XrLabel41"
        Me.XrLabel41.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel41.SizeF = New System.Drawing.SizeF(879.9999!, 49.99988!)
        Me.XrLabel41.StylePriority.UseFont = False
        Me.XrLabel41.StylePriority.UsePadding = False
        Me.XrLabel41.StylePriority.UseTextAlignment = False
        Me.XrLabel41.Text = "Nama dan Tanda Tangan Dokter"
        Me.XrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel40
        '
        Me.XrLabel40.Dpi = 254.0!
        Me.XrLabel40.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel40.LocationFloat = New DevExpress.Utils.PointFloat(1020.8!, 770.0!)
        Me.XrLabel40.Multiline = True
        Me.XrLabel40.Name = "XrLabel40"
        Me.XrLabel40.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel40.SizeF = New System.Drawing.SizeF(900.0!, 100.0!)
        Me.XrLabel40.StylePriority.UseFont = False
        Me.XrLabel40.StylePriority.UsePadding = False
        Me.XrLabel40.StylePriority.UseTextAlignment = False
        Me.XrLabel40.Text = "Nama dan Tanda Tangan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pasien / Keluarga"
        Me.XrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel39
        '
        Me.XrLabel39.Dpi = 254.0!
        Me.XrLabel39.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel39.LocationFloat = New DevExpress.Utils.PointFloat(1020.8!, 510.0001!)
        Me.XrLabel39.Multiline = True
        Me.XrLabel39.Name = "XrLabel39"
        Me.XrLabel39.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel39.SizeF = New System.Drawing.SizeF(900.0001!, 50.0!)
        Me.XrLabel39.StylePriority.UseFont = False
        Me.XrLabel39.StylePriority.UsePadding = False
        Me.XrLabel39.StylePriority.UseTextAlignment = False
        Me.XrLabel39.Text = "Tanggal, Jam"
        Me.XrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine2
        '
        Me.XrLine2.Dpi = 254.0!
        Me.XrLine2.LineWidth = 3
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(80.80014!, 490.0!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(1850.0!, 10.0!)
        '
        'XrLabel38
        '
        Me.XrLabel38.Dpi = 254.0!
        Me.XrLabel38.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel38.LocationFloat = New DevExpress.Utils.PointFloat(1060.8!, 170.0!)
        Me.XrLabel38.Multiline = True
        Me.XrLabel38.Name = "XrLabel38"
        Me.XrLabel38.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel38.SizeF = New System.Drawing.SizeF(860.0001!, 50.0!)
        Me.XrLabel38.StylePriority.UseFont = False
        Me.XrLabel38.StylePriority.UsePadding = False
        Me.XrLabel38.StylePriority.UseTextAlignment = False
        Me.XrLabel38.Text = "Beri penjelasan ulang"
        Me.XrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrCheckBox8
        '
        Me.XrCheckBox8.Dpi = 254.0!
        Me.XrCheckBox8.LocationFloat = New DevExpress.Utils.PointFloat(1020.8!, 70.0!)
        Me.XrCheckBox8.Name = "XrCheckBox8"
        Me.XrCheckBox8.SizeF = New System.Drawing.SizeF(900.0001!, 50.0!)
        Me.XrCheckBox8.Text = "Sudah memahami"
        '
        'XrCheckBox9
        '
        Me.XrCheckBox9.Dpi = 254.0!
        Me.XrCheckBox9.LocationFloat = New DevExpress.Utils.PointFloat(1020.8!, 120.0!)
        Me.XrCheckBox9.Name = "XrCheckBox9"
        Me.XrCheckBox9.SizeF = New System.Drawing.SizeF(900.0001!, 50.0!)
        Me.XrCheckBox9.Text = "Belum memahami"
        '
        'XrCheckBox10
        '
        Me.XrCheckBox10.Dpi = 254.0!
        Me.XrCheckBox10.LocationFloat = New DevExpress.Utils.PointFloat(1060.8!, 220.0001!)
        Me.XrCheckBox10.Name = "XrCheckBox10"
        Me.XrCheckBox10.SizeF = New System.Drawing.SizeF(860.0001!, 50.0!)
        Me.XrCheckBox10.Text = "Rencana Pengobatan"
        '
        'XrLabel37
        '
        Me.XrLabel37.Dpi = 254.0!
        Me.XrLabel37.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel37.LocationFloat = New DevExpress.Utils.PointFloat(1020.8!, 19.99998!)
        Me.XrLabel37.Multiline = True
        Me.XrLabel37.Name = "XrLabel37"
        Me.XrLabel37.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel37.SizeF = New System.Drawing.SizeF(900.0001!, 50.0!)
        Me.XrLabel37.StylePriority.UseFont = False
        Me.XrLabel37.StylePriority.UsePadding = False
        Me.XrLabel37.StylePriority.UseTextAlignment = False
        Me.XrLabel37.Text = "Verifikasi"
        Me.XrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrCheckBox7
        '
        Me.XrCheckBox7.Dpi = 254.0!
        Me.XrCheckBox7.LocationFloat = New DevExpress.Utils.PointFloat(80.80014!, 429.9998!)
        Me.XrCheckBox7.Name = "XrCheckBox7"
        Me.XrCheckBox7.SizeF = New System.Drawing.SizeF(880.0001!, 50.0!)
        Me.XrCheckBox7.Text = "Leaflet"
        '
        'XrCheckBox5
        '
        Me.XrCheckBox5.Dpi = 254.0!
        Me.XrCheckBox5.LocationFloat = New DevExpress.Utils.PointFloat(80.80014!, 269.9999!)
        Me.XrCheckBox5.Name = "XrCheckBox5"
        Me.XrCheckBox5.SizeF = New System.Drawing.SizeF(880.0001!, 50.0!)
        Me.XrCheckBox5.Text = "Penanganan Nyeri"
        '
        'XrCheckBox6
        '
        Me.XrCheckBox6.Dpi = 254.0!
        Me.XrCheckBox6.LocationFloat = New DevExpress.Utils.PointFloat(80.80014!, 320.0001!)
        Me.XrCheckBox6.Name = "XrCheckBox6"
        Me.XrCheckBox6.SizeF = New System.Drawing.SizeF(880.0001!, 50.0!)
        Me.XrCheckBox6.Text = "Lain - lain ........................................................."
        '
        'XrCheckBox3
        '
        Me.XrCheckBox3.Dpi = 254.0!
        Me.XrCheckBox3.LocationFloat = New DevExpress.Utils.PointFloat(80.80014!, 170.0!)
        Me.XrCheckBox3.Name = "XrCheckBox3"
        Me.XrCheckBox3.SizeF = New System.Drawing.SizeF(880.0001!, 50.0!)
        Me.XrCheckBox3.Text = "Rencana Pengobatan"
        '
        'XrCheckBox4
        '
        Me.XrCheckBox4.Dpi = 254.0!
        Me.XrCheckBox4.LocationFloat = New DevExpress.Utils.PointFloat(80.80014!, 220.0001!)
        Me.XrCheckBox4.Name = "XrCheckBox4"
        Me.XrCheckBox4.SizeF = New System.Drawing.SizeF(880.0001!, 50.0!)
        Me.XrCheckBox4.Text = "Perawatan Luka"
        '
        'XrCheckBox2
        '
        Me.XrCheckBox2.Dpi = 254.0!
        Me.XrCheckBox2.LocationFloat = New DevExpress.Utils.PointFloat(80.80014!, 120.0!)
        Me.XrCheckBox2.Name = "XrCheckBox2"
        Me.XrCheckBox2.SizeF = New System.Drawing.SizeF(880.0001!, 50.0!)
        Me.XrCheckBox2.Text = "Rencana Tindakan / Terapi"
        '
        'XrLine1
        '
        Me.XrLine1.Dpi = 254.0!
        Me.XrLine1.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine1.LineWidth = 3
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(990.8002!, 19.99991!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(10.0!, 470.0001!)
        '
        'XrCheckBox1
        '
        Me.XrCheckBox1.Dpi = 254.0!
        Me.XrCheckBox1.LocationFloat = New DevExpress.Utils.PointFloat(80.80014!, 70.0!)
        Me.XrCheckBox1.Name = "XrCheckBox1"
        Me.XrCheckBox1.SizeF = New System.Drawing.SizeF(880.0001!, 50.0!)
        Me.XrCheckBox1.Text = "Diagnosa Penyakit"
        '
        'XrLine12
        '
        Me.XrLine12.Dpi = 254.0!
        Me.XrLine12.LineWidth = 3
        Me.XrLine12.LocationFloat = New DevExpress.Utils.PointFloat(80.80022!, 0!)
        Me.XrLine12.Name = "XrLine12"
        Me.XrLine12.SizeF = New System.Drawing.SizeF(1839.2!, 20.0!)
        '
        'XrLabel36
        '
        Me.XrLabel36.Dpi = 254.0!
        Me.XrLabel36.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel36.LocationFloat = New DevExpress.Utils.PointFloat(80.80014!, 19.99998!)
        Me.XrLabel36.Multiline = True
        Me.XrLabel36.Name = "XrLabel36"
        Me.XrLabel36.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel36.SizeF = New System.Drawing.SizeF(880.0001!, 50.0!)
        Me.XrLabel36.StylePriority.UseFont = False
        Me.XrLabel36.StylePriority.UsePadding = False
        Me.XrLabel36.StylePriority.UseTextAlignment = False
        Me.XrLabel36.Text = "Informasi / Edukasi yang diberikan:"
        Me.XrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'pID
        '
        Me.pID.Description = "pID"
        Me.pID.Name = "pID"
        Me.pID.Visible = False
        '
        'XrLabel28
        '
        Me.XrLabel28.Dpi = 254.0!
        Me.XrLabel28.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel28.LocationFloat = New DevExpress.Utils.PointFloat(950.0001!, 380.0001!)
        Me.XrLabel28.Multiline = True
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 254.0!)
        Me.XrLabel28.SizeF = New System.Drawing.SizeF(280.0!, 50.0!)
        Me.XrLabel28.StylePriority.UseFont = False
        Me.XrLabel28.StylePriority.UsePadding = False
        Me.XrLabel28.StylePriority.UseTextAlignment = False
        Me.XrLabel28.Text = "No. Asesmen:"
        Me.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel22
        '
        Me.XrLabel22.Dpi = 254.0!
        Me.XrLabel22.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[assessmentno]")})
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(1230.0!, 380.0001!)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 254.0!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(520.0!, 50.0!)
        Me.XrLabel22.StylePriority.UsePadding = False
        Me.XrLabel22.StylePriority.UseTextAlignment = False
        Me.XrLabel22.Text = "XrLabel22"
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel21
        '
        Me.XrLabel21.Dpi = 254.0!
        Me.XrLabel21.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[assessmentdate]")})
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(360.0!, 380.0001!)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 254.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(520.0!, 50.0!)
        Me.XrLabel21.StylePriority.UsePadding = False
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        Me.XrLabel21.Text = "XrLabel21"
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel27
        '
        Me.XrLabel27.Dpi = 254.0!
        Me.XrLabel27.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(79.99996!, 380.0001!)
        Me.XrLabel27.Multiline = True
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 254.0!)
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(280.0!, 50.0!)
        Me.XrLabel27.StylePriority.UseFont = False
        Me.XrLabel27.StylePriority.UsePadding = False
        Me.XrLabel27.StylePriority.UseTextAlignment = False
        Me.XrLabel27.Text = "Tgl. Asesmen:"
        Me.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrbcIDRM
        '
        Me.xrbcIDRM.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
        Me.xrbcIDRM.AutoModule = True
        Me.xrbcIDRM.Dpi = 254.0!
        Me.xrbcIDRM.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.xrbcIDRM.LocationFloat = New DevExpress.Utils.PointFloat(1760.0!, 270.0!)
        Me.xrbcIDRM.Module = 5.08!
        Me.xrbcIDRM.Name = "xrbcIDRM"
        Me.xrbcIDRM.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 254.0!)
        Me.xrbcIDRM.ShowText = False
        Me.xrbcIDRM.SizeF = New System.Drawing.SizeF(160.0!, 160.0!)
        Me.xrbcIDRM.StylePriority.UseFont = False
        Me.xrbcIDRM.StylePriority.UsePadding = False
        Me.xrbcIDRM.StylePriority.UseTextAlignment = False
        QrCodeGenerator1.CompactionMode = DevExpress.XtraPrinting.BarCode.QRCodeCompactionMode.[Byte]
        Me.xrbcIDRM.Symbology = QrCodeGenerator1
        Me.xrbcIDRM.Text = "REG/LAB/20171220/0001"
        Me.xrbcIDRM.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
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
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel11, Me.XrLabel10, Me.xrbcIDRM, Me.XrLabel22, Me.XrLabel28, Me.XrLabel21, Me.XrLabel27, Me.XrLabel13, Me.XrLabel12, Me.XrLabel67, Me.XrLabel66, Me.XrLabel9, Me.XrLabel8, Me.XrLabel7, Me.XrLabel6, Me.XrLabel5, Me.XrLabel4, Me.XrLabel3, Me.XrPictureBox1, Me.XrLabel2})
        Me.PageHeader.Dpi = 254.0!
        Me.PageHeader.HeightF = 430.0001!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel11
        '
        Me.XrLabel11.Dpi = 254.0!
        Me.XrLabel11.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(1220.0!, 230.0!)
        Me.XrLabel11.Multiline = True
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 254.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(160.0!, 40.0!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UsePadding = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "Tgl. Reg"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel10
        '
        Me.XrLabel10.Dpi = 254.0!
        Me.XrLabel10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[registrasidate]")})
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(1380.0!, 230.0!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 254.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(540.0!, 40.0!)
        Me.XrLabel10.StylePriority.UsePadding = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "XrLabel10"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel13
        '
        Me.XrLabel13.Dpi = 254.0!
        Me.XrLabel13.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[pUnit]")})
        Me.XrLabel13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(330.0!, 0!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(870.0001!, 60.0!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "XrLabel13"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel12
        '
        Me.XrLabel12.Dpi = 254.0!
        Me.XrLabel12.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[pNotes]")})
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(330.0!, 70.00001!)
        Me.XrLabel12.Multiline = True
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(870.0002!, 200.0!)
        Me.XrLabel12.Text = "XrLabel12"
        Me.XrLabel12.WordWrap = False
        '
        'XrLabel67
        '
        Me.XrLabel67.Dpi = 254.0!
        Me.XrLabel67.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[registrasino]")})
        Me.XrLabel67.LocationFloat = New DevExpress.Utils.PointFloat(1380.0!, 190.0!)
        Me.XrLabel67.Name = "XrLabel67"
        Me.XrLabel67.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 254.0!)
        Me.XrLabel67.SizeF = New System.Drawing.SizeF(540.0!, 40.0!)
        Me.XrLabel67.StylePriority.UsePadding = False
        Me.XrLabel67.StylePriority.UseTextAlignment = False
        Me.XrLabel67.Text = "XrLabel67"
        Me.XrLabel67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel66
        '
        Me.XrLabel66.Dpi = 254.0!
        Me.XrLabel66.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel66.LocationFloat = New DevExpress.Utils.PointFloat(1220.0!, 190.0!)
        Me.XrLabel66.Multiline = True
        Me.XrLabel66.Name = "XrLabel66"
        Me.XrLabel66.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 254.0!)
        Me.XrLabel66.SizeF = New System.Drawing.SizeF(160.0!, 40.0!)
        Me.XrLabel66.StylePriority.UseFont = False
        Me.XrLabel66.StylePriority.UsePadding = False
        Me.XrLabel66.StylePriority.UseTextAlignment = False
        Me.XrLabel66.Text = "No. Reg"
        Me.XrLabel66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel9.BorderWidth = 0!
        Me.XrLabel9.Dpi = 254.0!
        Me.XrLabel9.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(79.99996!, 300.0!)
        Me.XrLabel9.Multiline = True
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(1670.0!, 79.99988!)
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseBorderWidth = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UsePadding = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "ASESMEN MEDIS INSTALASI RAWAT JALAN (IRJ)"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel8
        '
        Me.XrLabel8.Dpi = 254.0!
        Me.XrLabel8.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(1220.0!, 50.0!)
        Me.XrLabel8.Multiline = True
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 254.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(160.0!, 40.0!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UsePadding = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "No. RM"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.Dpi = 254.0!
        Me.XrLabel7.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(1220.0!, 140.0!)
        Me.XrLabel7.Multiline = True
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 254.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(160.0!, 50.0!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UsePadding = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Tgl. Lahir"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.Dpi = 254.0!
        Me.XrLabel6.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(1220.0!, 90.00002!)
        Me.XrLabel6.Multiline = True
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 254.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(160.0!, 50.0!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UsePadding = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "Nama"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.Dpi = 254.0!
        Me.XrLabel5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[nama]")})
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(1380.0!, 90.00002!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 254.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(540.0!, 50.0!)
        Me.XrLabel5.StylePriority.UsePadding = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "XrLabel5"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.Dpi = 254.0!
        Me.XrLabel4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[tanggallahir]")})
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(1380.0!, 140.0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 254.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(540.0!, 50.0!)
        Me.XrLabel4.StylePriority.UsePadding = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "XrLabel4"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.Dpi = 254.0!
        Me.XrLabel3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[norm]")})
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(1380.0!, 50.0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 254.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(540.0!, 40.0!)
        Me.XrLabel3.StylePriority.UsePadding = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "XrLabel3"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.Dpi = 254.0!
        Me.XrPictureBox1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Image", "[spCompanyLogoCaptionSquare].[images]")})
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(79.99996!, 0!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(240.0!, 270.0!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'XrLabel2
        '
        Me.XrLabel2.Dpi = 254.0!
        Me.XrLabel2.Font = New System.Drawing.Font("Tahoma", 6.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(1710.0!, 0!)
        Me.XrLabel2.Multiline = True
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(210.0!, 50.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UsePadding = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "ASMIRJ201901"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'SpAMIGD201801TableAdapter
        '
        Me.SpAMIGD201801TableAdapter.ClearBeforeFill = True
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1, Me.XrLabel86})
        Me.PageFooter.Dpi = 254.0!
        Me.PageFooter.HeightF = 50.00002!
        Me.PageFooter.Name = "PageFooter"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Dpi = 254.0!
        Me.XrPageInfo1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(1790.0!, 0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(140.0!, 50.0!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UsePadding = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrPageInfo1.TextFormatString = "{0} / {1}"
        '
        'XrLabel86
        '
        Me.XrLabel86.Dpi = 254.0!
        Me.XrLabel86.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[pFooter]")})
        Me.XrLabel86.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.XrLabel86.LocationFloat = New DevExpress.Utils.PointFloat(79.99996!, 0!)
        Me.XrLabel86.Name = "XrLabel86"
        Me.XrLabel86.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel86.SizeF = New System.Drawing.SizeF(1710.0!, 50.00002!)
        Me.XrLabel86.StylePriority.UseFont = False
        Me.XrLabel86.StylePriority.UseTextAlignment = False
        Me.XrLabel86.Text = "XrLabel86"
        Me.XrLabel86.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
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
        'SpCompanyLogoCaptionSquareTableAdapter1
        '
        Me.SpCompanyLogoCaptionSquareTableAdapter1.ClearBeforeFill = True
        '
        'spAMIRJ2018011
        '
        Me.spAMIRJ2018011.DataSetName = "spAMIRJ201801"
        Me.spAMIRJ2018011.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'spAMIRJ201801TableAdapter
        '
        Me.spAMIRJ201801TableAdapter.ClearBeforeFill = True
        '
        'SpSN201801TableAdapter
        '
        Me.SpSN201801TableAdapter.ClearBeforeFill = True
        '
        'xrAMIRJ201901
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader, Me.PageFooter})
        Me.BorderWidth = 0!
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.spAMIRJ2018011})
        Me.DataAdapter = Me.spAMIRJ201801TableAdapter
        Me.DataMember = "spAMIRJ201801"
        Me.DataSource = Me.spAMIRJ2018011
        Me.Dpi = 254.0!
        Me.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Margins = New System.Drawing.Printing.Margins(50, 50, 40, 40)
        Me.PageHeight = 2970
        Me.PageWidth = 2100
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.pFooter, Me.pNo, Me.pID, Me.pUnit, Me.pNotes})
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.SnapGridSize = 10.0!
        Me.SnappingMode = CType((DevExpress.XtraReports.UI.SnappingMode.SnapLines Or DevExpress.XtraReports.UI.SnappingMode.SnapToGrid), DevExpress.XtraReports.UI.SnappingMode)
        Me.Version = "17.2"
        CType(Me.spAMIRJ2018011, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents SpAMIGD201801TableAdapter As spAMIGD201801TableAdapters.spAMIGD201801TableAdapter
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel67 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel66 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents pFooter As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel86 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrbcIDRM As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents pNo As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents pID As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents SpCompanyLogoCaptionSquareTableAdapter As spAMIGD201801TableAdapters.spCompanyLogoCaptionSquareTableAdapter
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pUnit As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents pNotes As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SpCompanyLogoCaptionSquareTableAdapter1 As spCompanyLogoCaptionSquareTableAdapters.spCompanyLogoCaptionSquareTableAdapter
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents spAMIRJ2018011 As spAMIRJ201801
    Friend WithEvents spAMIRJ201801TableAdapter As spAMIRJ201801TableAdapters.spAMIRJ201801TableAdapter
    Friend WithEvents XrLabel41 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel40 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel39 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel38 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrCheckBox8 As DevExpress.XtraReports.UI.XRCheckBox
    Friend WithEvents XrCheckBox9 As DevExpress.XtraReports.UI.XRCheckBox
    Friend WithEvents XrCheckBox10 As DevExpress.XtraReports.UI.XRCheckBox
    Friend WithEvents XrLabel37 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrCheckBox7 As DevExpress.XtraReports.UI.XRCheckBox
    Friend WithEvents XrCheckBox5 As DevExpress.XtraReports.UI.XRCheckBox
    Friend WithEvents XrCheckBox6 As DevExpress.XtraReports.UI.XRCheckBox
    Friend WithEvents XrCheckBox3 As DevExpress.XtraReports.UI.XRCheckBox
    Friend WithEvents XrCheckBox4 As DevExpress.XtraReports.UI.XRCheckBox
    Friend WithEvents XrCheckBox2 As DevExpress.XtraReports.UI.XRCheckBox
    Friend WithEvents XrLabel36 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrCheckBox1 As DevExpress.XtraReports.UI.XRCheckBox
    Friend WithEvents XrLine12 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents SpSN201801TableAdapter As spSN201801TableAdapters.spSN201801TableAdapter
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents subSOAP As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents SubBand1 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
End Class
