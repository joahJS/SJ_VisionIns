using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using static ComnFunc;
using static GridFunc;
using System.IO;


namespace VisionIns
{
    public partial class MT001F01 : XtraForm
    {
        public delegate void SendDataHandler(string sVal);
        public event SendDataHandler DataRowSendEvent;

        private string _inspNo = "";
        private DataRow _row;

        public MT001F01()
        {
            InitializeComponent();
        }

        public MT001F01(string inspNo)
        {
            InitializeComponent();

            _inspNo = inspNo;
        }

        public MT001F01(DataRow row)
        {
            InitializeComponent();

            _row = row;
        }

        private void LoadInspectionDetail(string inspNo)
        {
            // 여기서 검사번호 기준으로 DB 조회

        }



        private void MT001F01_Load(object sender, EventArgs e)
        {
            // 전달받은 검사번호로 상세정보 조회
            //if (!string.IsNullOrEmpty(_inspNo))
            //{
            //    LoadInspectionDetail(_inspNo);
            //}

            if (_row != null)
            {
                SetDetailData(_row);
            }
        }

        //
        private void SetDetailData(DataRow row)
        {
            BasicInfoItem1Text.Text = row["SLINO"].ToString();
            BasicInfoItem2Text.Text = row["IDATE"].ToString();
            BasicInfoItem3Text.Text = row["ITIME"].ToString();
            BasicInfoItem4Text.Text = row["ITCOD"].ToString();
            BasicInfoItem5Text.Text = row["WKNM"].ToString();
            BasicInfoItem6Text.Text = row["RSLT"].ToString();

            // 판정 색상
            if (row["RSLT"].ToString() == "OK")
            {
                BasicInfoItem6Text.ForeColor = ColorTranslator.FromHtml("#5ED845");
                lblSumSignal.BackColor = ColorTranslator.FromHtml("#5ED845");
            }
            else
            {
                BasicInfoItem6Text.ForeColor = ColorTranslator.FromHtml("#FF4D45");
                lblSumSignal.BackColor = ColorTranslator.FromHtml("#FF4D45");
            }

            lblSumSignal.Text = row["RSLT"].ToString();

            //검사항목 구분(IITEM1~IITEM5 OK/NG 개수 계산)
            int okCount = 0;
            int ngCount = 0;

            string[] inspColumns = { "IITEM1", "IITEM2", "IITEM3", "IITEM4", "IITEM5" };

            foreach (string col in inspColumns)
            {
                string value = row[col]?.ToString().Trim().ToUpper();

                if (value == "OK")
                {
                    okCount++;
                }
                else if (value == "NG")
                {
                    ngCount++;
                }
            }

            // 화면 표시
            lblSumValue1.Text = ngCount.ToString();
            lblSumValue2.Text = okCount.ToString();

            // 검사항목 표시
            lblResultText1.Text = row["IITEM1"].ToString();
            lblResultText2.Text = row["IITEM2"].ToString();
            lblResultText3.Text = row["IITEM3"].ToString();
            lblResultText4.Text = row["IITEM4"].ToString();
            lblResultText5.Text = row["IITEM5"].ToString();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
