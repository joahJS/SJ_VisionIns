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

namespace VisionIns
{
    public partial class CM003F00 : DevExpress.XtraEditors.XtraForm
    {
        public string PROCEDURE_ID = "DP_CM003F00";

        public CM003F00()
        {
            InitializeComponent();
        }

        private void CM003F00_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            ComnEtcFunc.gp_SetColorFocused(layoutControl1);
            ComnEtcFunc.InitControllerRule(layoutControl1);
            ComnGridFunc.GridStyleBasicSetting(GridViewRetr);
            ComnEtcFunc.SetBoundLookUp(Lk_Rslt, "REFFPF", "RSLT", "");
            Lk_Rslt.Properties.PopulateColumns();
            Lk_Rslt.Properties.Columns["CD"].Visible = false;

            // AI 비전검사 결과(T_0001H)는 1건당 UPLOADED_IMAGE/DEBUG_IMAGE 이미지가 함께 저장되어
            // 데이터량이 매우 큼. "이번달 1일"을 기본값으로 하면 최초 진입만으로 대량의 이미지를
            // 한번에 조회하게 되어 OutOfMemoryException이 발생할 수 있어, 기본 조회범위를 오늘 하루로 축소.
            Dt_DateF.EditValue = DateTime.Today.ToString("yyyy-MM-dd");
            Dt_DateT.EditValue = DateTime.Today;

            BtnRetr.PerformClick();
        }

        private void BtnRetr_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dicParams = new Dictionary<string, string>();
            dicParams.Clear();
            dicParams.Add("CMD", "LIST");
            dicParams.Add("DATE_F", Dt_DateF.EditValue?.ToString());
            dicParams.Add("DATE_T", Dt_DateT.EditValue?.ToString());
            dicParams.Add("RSLT", Lk_Rslt.EditValue?.ToString());
            dicParams.Add("FIND_IDX", Cb_Idx.SelectedIndex.ToString());
            dicParams.Add("FIND_WORD", Tx_Word.EditValue?.ToString());

            DataTable dt = DBConn.GetDataTable(DBConn.dbCon, this.PROCEDURE_ID, dicParams);

            if (dt != null)
            {
                // CAM1/CAM2 병합 및 PART_TYPE 추출은 DP_CM003F00(LIST)에서 처리됨
                GridRetr.DataSource = dt;
            }
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            ComnEtcFunc.ExportExcelFile("검사결과이력_", GridRetr, this.Name, this.Text);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CM003F00_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                BtnRetr.PerformClick();
            else if (e.KeyCode == Keys.F8)
                BtnExcel.PerformClick();
            else if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void Lk_Rslt_EditValueChanged(object sender, EventArgs e)
        {
            BtnRetr.PerformClick();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            CM003F01 frm = new CM003F01();
            frm.Owner = this;
            frm.DataRowSendEvent += new CM003F01.SendDataHandler(GetDataRow);
            frm.Show();
        }

        public void GetDataRow(string row)
        {
            BtnRetr.PerformClick();
            int i = GridViewRetr.LocateByDisplayText(0, GridColSlino, row + "");
            GridViewRetr.FocusedRowHandle = i;
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            string sSlino = GridViewRetr.GetFocusedRowCellValue("ID")?.ToString();

            int i = GridViewRetr.GetFocusedDataSourceRowIndex();

            if (XtraMessageBox.Show("검사번호 : " + sSlino +
                  " \r\n선택된 항목을 삭제하시겠습니까? (CAM1/CAM2 이미지가 함께 삭제됩니다) \r\n", "검사이력 삭제여부", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            try
            {
                Dictionary<string, string> dicParams = new Dictionary<string, string>();
                dicParams.Add("CMD", "DEL");
                dicParams.Add("ID", sSlino);

                DataTable dtResult = ComnEtcFunc.GetInfo(dicParams, this.PROCEDURE_ID);
                if (dtResult.Rows.Count > 0)
                {
                    string sErrorGb = dtResult.Rows[0]["RESULT"]?.ToString();
                    string sMsg = dtResult.Rows[0]["MSG"]?.ToString();
                    if (sErrorGb.Equals("1"))
                    {
                        XtraMessageBox.Show(sMsg, "검사이력 삭제 완료");
                        //ComnEtcFunc.SetLogInfo(Name, Text, ComnEtcFunc.CONNECT_TYPE.조회);
                        BtnRetr.PerformClick();
                        if (i > 0)
                        {
                            GridViewRetr.MoveBy(i - 1);
                        }
                        else
                        {
                            GridViewRetr.MoveBy(0);
                        }
                        return;
                    }
                    else if (sErrorGb.Equals("0"))
                    {
                        XtraMessageBox.Show(sMsg, "검사이력 삭제 실패");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
                return;
            }
        }

        private void GridViewRetr_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Clicks == 2)
            {
                CM003F01 frm = new CM003F01();
                frm.Owner = this;
                frm._SLINO = GridViewRetr.GetFocusedRowCellValue("ID")?.ToString();
                frm.DataRowSendEvent += new CM003F01.SendDataHandler(GetDataRow);
                frm.Show();
            }
        }
    }
}