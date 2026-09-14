using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace VisionIns
{
    public partial class CM004F00 : DevExpress.XtraEditors.XtraForm
    {
        public string PROCEDURE_ID = "DP_CM004F00";

        public CM004F00()
        {
            InitializeComponent();
        }

        private void CM004F00_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            ComnEtcFunc.gp_SetColorFocused(layoutControl1);
            ComnEtcFunc.InitControllerRule(layoutControl1);
            ComnGridFunc.GridStyleForSelect(GridViewRetr);

            Dt_YearMonth.EditValue = DateTime.Today;

            BtnRetr.PerformClick();
        }

        #region [조회]
        private void BtnRetr_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dicParams = new Dictionary<string, string>();
            dicParams.Clear();
            dicParams.Add("CMD", "LIST");
            dicParams.Add("YEARMONTH", Convert.ToDateTime(Dt_YearMonth.EditValue).ToString("yyyy-MM"));
            dicParams.Add("FIND_WORD", Tx_Word.EditValue?.ToString());

            DataTable dt = DBConn.GetDataTable(DBConn.dbCon, this.PROCEDURE_ID, dicParams);

            if (dt != null)
            {
                GridRetr.DataSource = dt;
            }
        }
        #endregion

        #region [조회년월 이동]
        private void BtnPrevYM_Click(object sender, EventArgs e)
        {
            Dt_YearMonth.EditValue = Convert.ToDateTime(Dt_YearMonth.EditValue).AddMonths(-1);
            BtnRetr.PerformClick();
        }

        private void BtnNextYM_Click(object sender, EventArgs e)
        {
            Dt_YearMonth.EditValue = Convert.ToDateTime(Dt_YearMonth.EditValue).AddMonths(1);
            BtnRetr.PerformClick();
        }

        private void BtnInit_Click(object sender, EventArgs e)
        {
            Dt_YearMonth.EditValue = DateTime.Today;
            Tx_Word.EditValue = string.Empty;
            BtnRetr.PerformClick();
        }
        #endregion

        #region [라벨출력]
        private const int LABEL_COPIES = 6;

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            int[] iSelected = GridViewRetr.GetSelectedRows();
            if (iSelected.Length == 0)
            {
                XtraMessageBox.Show("라벨출력할 항목이 선택되지 않았습니다.");
                return;
            }

            DataTable dt = GridRetr.DataSource as DataTable;
            DataTable dtClone = dt.Clone();

            // 선택된 항목마다 라벨 1개(1장)씩, 총 LABEL_COPIES(6)장이 한번에 출력되도록
            // 순번(0001~0006)을 매긴 사본 행을 만든다.
            for (int i = 0; i < iSelected.Length; i++)
            {
                DataRow srcRow = GridViewRetr.GetDataRow(iSelected[i]);

                for (int copy = 1; copy <= LABEL_COPIES; copy++)
                {
                    DataRow newRow = dtClone.NewRow();
                    newRow.ItemArray = srcRow.ItemArray;
                    newRow["SEQNO"] = copy.ToString("0000");
                    dtClone.Rows.Add(newRow);
                }
            }

            using (QrLabelReport report = new QrLabelReport())
            {
                report._dt = dtClone;
                report.CreateDocument();
                report.ShowPreviewDialog();
            }
        }
        #endregion

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            ComnEtcFunc.ExportExcelFile("바코드출력_", GridRetr, this.Name, this.Text);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CM004F00_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                BtnRetr.PerformClick();
            else if (e.KeyCode == Keys.F6)
                BtnPrint.PerformClick();
            else if (e.KeyCode == Keys.F8)
                BtnExcel.PerformClick();
            else if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void Tx_Word_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnRetr.PerformClick();
        }
    }
}
