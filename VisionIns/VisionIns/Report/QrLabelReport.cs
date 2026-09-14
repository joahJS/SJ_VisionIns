using System.Data;

namespace VisionIns
{
    public partial class QrLabelReport : DevExpress.XtraReports.UI.XtraReport
    {
        public DataTable _dt { get; set; }

        public QrLabelReport()
        {
            InitializeComponent();
        }

        private void QrLabelReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.DataSource = _dt;

            xrQrCode.DataBindings.Add("Text", _dt, "LOTNO");
            xrLbl_LOTNO.DataBindings.Add("Text", _dt, "LOTNO");
            xrLbl_ITNAM.DataBindings.Add("Text", _dt, "ITNAM");
            xrLbl_ISPEC.DataBindings.Add("Text", _dt, "ISPEC");
            xrLbl_TDATE.DataBindings.Add("Text", _dt, "TDATE");
        }
    }
}
