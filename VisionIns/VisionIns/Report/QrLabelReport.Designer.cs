namespace VisionIns
{
    partial class QrLabelReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator1 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrQrCode = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrLbl_LOTNO_Cap = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLbl_LOTNO = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLbl_ITNAM_Cap = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLbl_ITNAM = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLbl_ISPEC_Cap = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLbl_ISPEC = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            //
            // TopMargin
            //
            this.TopMargin.Dpi = 254F;
            this.TopMargin.HeightF = 5F;
            this.TopMargin.Name = "TopMargin";
            //
            // BottomMargin
            //
            this.BottomMargin.Dpi = 254F;
            this.BottomMargin.HeightF = 5F;
            this.BottomMargin.Name = "BottomMargin";
            //
            // Detail
            //
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLbl_ISPEC,
            this.xrLbl_ISPEC_Cap,
            this.xrLbl_ITNAM,
            this.xrLbl_ITNAM_Cap,
            this.xrLbl_LOTNO,
            this.xrLbl_LOTNO_Cap,
            this.xrQrCode});
            this.Detail.Dpi = 254F;
            this.Detail.HeightF = 250F;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            //
            // xrQrCode
            //
            this.xrQrCode.AutoModule = true;
            this.xrQrCode.Dpi = 254F;
            this.xrQrCode.LocationFloat = new DevExpress.Utils.PointFloat(70F, 5F);
            this.xrQrCode.Name = "xrQrCode";
            this.xrQrCode.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.xrQrCode.ShowText = false;
            this.xrQrCode.SizeF = new System.Drawing.SizeF(150F, 150F);
            this.xrQrCode.Symbology = qrCodeGenerator1;
            this.xrQrCode.Text = "LOTNO";
            //
            // xrLbl_LOTNO_Cap
            //
            this.xrLbl_LOTNO_Cap.Dpi = 254F;
            this.xrLbl_LOTNO_Cap.Font = new System.Drawing.Font("맑은 고딕", 6F);
            this.xrLbl_LOTNO_Cap.LocationFloat = new DevExpress.Utils.PointFloat(5F, 165F);
            this.xrLbl_LOTNO_Cap.Name = "xrLbl_LOTNO_Cap";
            this.xrLbl_LOTNO_Cap.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 254F);
            this.xrLbl_LOTNO_Cap.SizeF = new System.Drawing.SizeF(65F, 26F);
            this.xrLbl_LOTNO_Cap.StylePriority.UseFont = false;
            this.xrLbl_LOTNO_Cap.StylePriority.UseTextAlignment = false;
            this.xrLbl_LOTNO_Cap.Text = "LOT";
            this.xrLbl_LOTNO_Cap.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            //
            // xrLbl_LOTNO
            //
            this.xrLbl_LOTNO.CanGrow = false;
            this.xrLbl_LOTNO.Dpi = 254F;
            this.xrLbl_LOTNO.Font = new System.Drawing.Font("굴림", 8F, System.Drawing.FontStyle.Bold);
            this.xrLbl_LOTNO.LocationFloat = new DevExpress.Utils.PointFloat(75F, 165F);
            this.xrLbl_LOTNO.Name = "xrLbl_LOTNO";
            this.xrLbl_LOTNO.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 254F);
            this.xrLbl_LOTNO.SizeF = new System.Drawing.SizeF(210F, 26F);
            this.xrLbl_LOTNO.StylePriority.UseFont = false;
            this.xrLbl_LOTNO.StylePriority.UseTextAlignment = false;
            this.xrLbl_LOTNO.Text = "P260101001";
            this.xrLbl_LOTNO.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLbl_LOTNO.TextFitMode = DevExpress.XtraReports.UI.TextFitMode.ShrinkOnly;
            this.xrLbl_LOTNO.WordWrap = false;
            //
            // xrLbl_ITNAM_Cap
            //
            this.xrLbl_ITNAM_Cap.Dpi = 254F;
            this.xrLbl_ITNAM_Cap.Font = new System.Drawing.Font("맑은 고딕", 6F);
            this.xrLbl_ITNAM_Cap.LocationFloat = new DevExpress.Utils.PointFloat(5F, 191F);
            this.xrLbl_ITNAM_Cap.Name = "xrLbl_ITNAM_Cap";
            this.xrLbl_ITNAM_Cap.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 254F);
            this.xrLbl_ITNAM_Cap.SizeF = new System.Drawing.SizeF(65F, 26F);
            this.xrLbl_ITNAM_Cap.StylePriority.UseFont = false;
            this.xrLbl_ITNAM_Cap.StylePriority.UseTextAlignment = false;
            this.xrLbl_ITNAM_Cap.Text = "품명";
            this.xrLbl_ITNAM_Cap.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            //
            // xrLbl_ITNAM
            //
            this.xrLbl_ITNAM.CanGrow = false;
            this.xrLbl_ITNAM.Dpi = 254F;
            this.xrLbl_ITNAM.Font = new System.Drawing.Font("굴림", 7F);
            this.xrLbl_ITNAM.LocationFloat = new DevExpress.Utils.PointFloat(75F, 191F);
            this.xrLbl_ITNAM.Name = "xrLbl_ITNAM";
            this.xrLbl_ITNAM.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 254F);
            this.xrLbl_ITNAM.SizeF = new System.Drawing.SizeF(210F, 26F);
            this.xrLbl_ITNAM.StylePriority.UseFont = false;
            this.xrLbl_ITNAM.StylePriority.UseTextAlignment = false;
            this.xrLbl_ITNAM.Text = "품명";
            this.xrLbl_ITNAM.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLbl_ITNAM.TextFitMode = DevExpress.XtraReports.UI.TextFitMode.ShrinkOnly;
            this.xrLbl_ITNAM.WordWrap = false;
            //
            // xrLbl_ISPEC_Cap
            //
            this.xrLbl_ISPEC_Cap.Dpi = 254F;
            this.xrLbl_ISPEC_Cap.Font = new System.Drawing.Font("맑은 고딕", 6F);
            this.xrLbl_ISPEC_Cap.LocationFloat = new DevExpress.Utils.PointFloat(5F, 217F);
            this.xrLbl_ISPEC_Cap.Name = "xrLbl_ISPEC_Cap";
            this.xrLbl_ISPEC_Cap.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 254F);
            this.xrLbl_ISPEC_Cap.SizeF = new System.Drawing.SizeF(65F, 26F);
            this.xrLbl_ISPEC_Cap.StylePriority.UseFont = false;
            this.xrLbl_ISPEC_Cap.StylePriority.UseTextAlignment = false;
            this.xrLbl_ISPEC_Cap.Text = "규격";
            this.xrLbl_ISPEC_Cap.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            //
            // xrLbl_ISPEC
            //
            this.xrLbl_ISPEC.CanGrow = false;
            this.xrLbl_ISPEC.Dpi = 254F;
            this.xrLbl_ISPEC.Font = new System.Drawing.Font("굴림", 7F);
            this.xrLbl_ISPEC.LocationFloat = new DevExpress.Utils.PointFloat(75F, 217F);
            this.xrLbl_ISPEC.Name = "xrLbl_ISPEC";
            this.xrLbl_ISPEC.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 254F);
            this.xrLbl_ISPEC.SizeF = new System.Drawing.SizeF(210F, 26F);
            this.xrLbl_ISPEC.StylePriority.UseFont = false;
            this.xrLbl_ISPEC.StylePriority.UseTextAlignment = false;
            this.xrLbl_ISPEC.Text = "10cm*3cm";
            this.xrLbl_ISPEC.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLbl_ISPEC.TextFitMode = DevExpress.XtraReports.UI.TextFitMode.ShrinkOnly;
            this.xrLbl_ISPEC.WordWrap = false;
            //
            // QrLabelReport
            //
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.Dpi = 254F;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(5, 5, 5, 5);
            this.PageHeight = 300;
            this.PageWidth = 300;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.ShowPrintMarginsWarning = false;
            this.SnapGridSize = 25F;
            this.Version = "18.2";
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.QrLabelReport_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRBarCode xrQrCode;
        private DevExpress.XtraReports.UI.XRLabel xrLbl_LOTNO_Cap;
        private DevExpress.XtraReports.UI.XRLabel xrLbl_LOTNO;
        private DevExpress.XtraReports.UI.XRLabel xrLbl_ITNAM_Cap;
        private DevExpress.XtraReports.UI.XRLabel xrLbl_ITNAM;
        private DevExpress.XtraReports.UI.XRLabel xrLbl_ISPEC_Cap;
        private DevExpress.XtraReports.UI.XRLabel xrLbl_ISPEC;
    }
}
