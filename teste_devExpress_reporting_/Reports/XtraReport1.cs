using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace teste_devExpress_reporting_.Reports
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        private TopMarginBand topMarginBand1;
        private DetailBand detailBand1;
        private ReportHeaderBand ReportHeader;
        private ReportFooterBand ReportFooter;
        private TopMarginBand topMarginBand2;
        private DetailBand detailBand2;
        private BottomMarginBand bottomMarginBand2;
        private ReportHeaderBand reportHeaderBand1;
        private XRLabel xrLabel1;
        private ReportFooterBand reportFooterBand1;
        private BottomMarginBand bottomMarginBand1;

        public XtraReport1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.topMarginBand2 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.detailBand2 = new DevExpress.XtraReports.UI.DetailBand();
            this.bottomMarginBand2 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.reportFooterBand1 = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // topMarginBand2
            // 
            this.topMarginBand2.Name = "topMarginBand2";
            // 
            // detailBand2
            // 
            this.detailBand2.HeightF = 2.5F;
            this.detailBand2.Name = "detailBand2";
            // 
            // bottomMarginBand2
            // 
            this.bottomMarginBand2.Name = "bottomMarginBand2";
            // 
            // reportHeaderBand1
            // 
            this.reportHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
            this.reportHeaderBand1.Name = "reportHeaderBand1";
            // 
            // reportFooterBand1
            // 
            this.reportFooterBand1.HeightF = 0F;
            this.reportFooterBand1.Name = "reportFooterBand1";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Times New Roman", 50F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(650F, 73.33333F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Teste Report";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // XtraReport1
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand2,
            this.detailBand2,
            this.bottomMarginBand2,
            this.reportHeaderBand1,
            this.reportFooterBand1});
            this.Version = "24.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
    }
}
