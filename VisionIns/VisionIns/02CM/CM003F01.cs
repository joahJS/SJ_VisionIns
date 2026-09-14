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
using System.IO;

namespace VisionIns
{
    public partial class CM003F01 : DevExpress.XtraEditors.XtraForm
    {
        private string PROCEDURE_ID = "DP_CM003F01";
        
        public string _SLINO;
        public delegate void SendDataHandler(string sVal);
        public event SendDataHandler DataRowSendEvent;

        public CM003F01()
        {
            InitializeComponent();
        }

        private void CM003F01_Load(object sender, EventArgs e)
        {
            ComnEtcFunc.gp_SetColorFocused(layoutControl1);
            if (_SLINO != null)
                SetValue();
            else
                Init();
        }

        private void Init()
        {
            ComnEtcFunc.gp_SetColorFocused(layoutControl1);

            Tx_Slino.EditValue = "";
            Dt_IDate.EditValue = DateTime.Now.ToString("yyyy-MM-dd");
            Te_ITime.EditValue = DateTime.Now;
            Be_Itnam.EditValue = "";
            Tx_Itcod.EditValue = "";
            Tx_Plnnm.EditValue = "";
            Tx_Plncd.EditValue = LoginUser.USRCD;
            Rg_Rslt.EditValue = "";
            Cb_Iitem1.EditValue = "";
            Cb_Iitem2.EditValue = "";
            Cb_Iitem3.EditValue = "";
            Cb_Iitem4.EditValue = "";
            Cb_Iitem5.EditValue = "";
            Me_Rk.EditValue = "";
            Pic_Iimg.EditValue = null;
            Pic_Iimg_Cam2.EditValue = null;

            Bt_SaveMul.Enabled = true;
        }

        private void SetValue()
        {
            // CAM1/CAM2로 나뉘어 저장된 두 행을 검사 1건으로 합쳐 보여줘야 하므로,
            // 단건조회(DP_CM003F01)가 아니라 DP_CM003F00의 PAIR_DETAIL(신규)을 사용한다.
            // _SLINO로 CAM1/CAM2 중 어느 쪽 ID를 넘겨도 그 짝까지 함께 찾아서 반환된다.
            Dictionary<string, string> dicParams = new Dictionary<string, string>();
            dicParams.Clear();
            dicParams.Add("CMD", "PAIR_DETAIL");
            dicParams.Add("ID", _SLINO);
            DataTable dt = DBConn.GetDataTable(DBConn.dbCon, "DP_CM003F00", dicParams);

            Tx_Slino.EditValue = dt.Rows[0]["DISP_ID"]?.ToString();

            DateTime ts;
            if (DateTime.TryParse(dt.Rows[0]["DISP_TIMESTAMP"]?.ToString(), out ts))
            {
                Dt_IDate.EditValue = ts.ToString("yyyy-MM-dd");
                Te_ITime.EditValue = ts;
            }

            // 카메라 구분은 화면에서 없앴으므로 비워둠
            Tx_Itcod.EditValue = "";

            string rslt1 = dt.Rows[0]["CAM1_RSLT"]?.ToString();
            string rslt2 = dt.Rows[0]["CAM2_RSLT"]?.ToString();
            Rg_Rslt.EditValue = (rslt1 == "NG" || rslt2 == "NG") ? "NG"
                : (!string.IsNullOrEmpty(rslt1) || !string.IsNullOrEmpty(rslt2) ? "OK" : "");

            //검사항목1~5는 고정 5항목 개념이 없어 사용하지 않음(부품/캡 단위 결과는 아래 비고 참고)
            Cb_Iitem1.EditValue = "";
            Cb_Iitem2.EditValue = "";
            Cb_Iitem3.EditValue = "";
            Cb_Iitem4.EditValue = "";
            Cb_Iitem5.EditValue = "";

            Tx_Plnnm.EditValue = "";
            Tx_Plncd.EditValue = "";

            Be_Itnam.EditValue = dt.Rows[0]["PART_TYPE"]?.ToString();

            Me_Rk.EditValue = string.Format(
                "[CAM1] 결과 {0} / 부품 {1} / 캡 {2} / 불량 {3}\r\n[CAM2] 결과 {4} / 부품 {5} / 캡 {6} / 불량 {7}",
                rslt1, dt.Rows[0]["CAM1_PART_COUNT"], dt.Rows[0]["CAM1_TOTAL_CAPS"], dt.Rows[0]["CAM1_TOTAL_DEFECTS"],
                rslt2, dt.Rows[0]["CAM2_PART_COUNT"], dt.Rows[0]["CAM2_TOTAL_CAPS"], dt.Rows[0]["CAM2_TOTAL_DEFECTS"]);

            byte[] uploadedImg1 = Convert.IsDBNull(dt.Rows[0]["CAM1_UPLOADED_IMAGE"]) ? null : (byte[])dt.Rows[0]["CAM1_UPLOADED_IMAGE"];
            Pic_Iimg.Image = byteArrayToImage(uploadedImg1);

            byte[] debugImg1 = Convert.IsDBNull(dt.Rows[0]["CAM1_DEBUG_IMAGE"]) ? null : (byte[])dt.Rows[0]["CAM1_DEBUG_IMAGE"];
            Pic_DebugImg.Image = byteArrayToImage(debugImg1);

            byte[] uploadedImg2 = Convert.IsDBNull(dt.Rows[0]["CAM2_UPLOADED_IMAGE"]) ? null : (byte[])dt.Rows[0]["CAM2_UPLOADED_IMAGE"];
            Pic_Iimg_Cam2.Image = byteArrayToImage(uploadedImg2);

            byte[] debugImg2 = Convert.IsDBNull(dt.Rows[0]["CAM2_DEBUG_IMAGE"]) ? null : (byte[])dt.Rows[0]["CAM2_DEBUG_IMAGE"];
            Pic_DebugImg_Cam2.Image = byteArrayToImage(debugImg2);
        }

        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            Image returnImage = null;
            try
            {
                MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
                ms.Write(byteArrayIn, 0, byteArrayIn.Length);
                returnImage = Image.FromStream(ms, true);
            }
            catch
            {

            }
            return returnImage;
        }

        private void Save(String YN)
        {
            string sSlino = string.Empty;
            if (string.IsNullOrEmpty(_SLINO))
                sSlino = ComnEtcFunc.NextSlipNoLong(DateTime.Today.ToString("yyMMdd"), "SLINO", "INSP_HIST");
            else
                sSlino = Tx_Slino.EditValue?.ToString();
            
            string sIDate = Dt_IDate.EditValue?.ToString();
            string sITime = Te_ITime.Time.ToString("HH:mm:ss");
            string sItcod = Tx_Itcod.EditValue?.ToString();
            string sPlncd = Tx_Plncd.EditValue?.ToString();
            string sWknm = Tx_Plnnm.EditValue?.ToString();
            string sRslt = Rg_Rslt.EditValue?.ToString();
            string sIitem1 = Cb_Iitem1.SelectedItem?.ToString();
            string sIitem2 = Cb_Iitem2.SelectedItem?.ToString();
            string sIitem3 = Cb_Iitem3.SelectedItem?.ToString();
            string sIitem4 = Cb_Iitem4.SelectedItem?.ToString();
            string sIitem5 = Cb_Iitem5.SelectedItem?.ToString();
            string sRk = Me_Rk.EditValue?.ToString();

            byte[] upImage = null;
            if (Pic_Iimg.Image != null)
                upImage = ComnEtcFunc.ImageToByteArray(Pic_Iimg.Image);
            
            try
            {
                Dictionary<string, object> dicParams = new Dictionary<string, object>();
                dicParams.Clear();
                dicParams.Add("CMD", "SAVE");
                dicParams.Add("SLINO", sSlino);
                dicParams.Add("IDATE", sIDate);
                dicParams.Add("ITIME", sITime);
                dicParams.Add("ITCOD", sItcod);
                dicParams.Add("PLNCD", sPlncd);
                dicParams.Add("WKNM", sWknm);
                dicParams.Add("RSLT", sRslt);
                dicParams.Add("IITEM1", sIitem1);
                dicParams.Add("IITEM2", sIitem2);
                dicParams.Add("IITEM3", sIitem3);
                dicParams.Add("IITEM4", sIitem4);
                dicParams.Add("IITEM5", sIitem5);
                dicParams.Add("RK", sRk);
                dicParams.Add("IIMG", upImage);
                dicParams.Add("CUSER", LoginUser.USRCD);

                DataTable dtResult = DBConn.GetDataTable(DBConn.dbCon, PROCEDURE_ID, dicParams);

                if (dtResult != null)
                {
                    if (dtResult.Rows.Count > 0)
                    {
                        string msg = dtResult.Rows[0]["MSG"]?.ToString();
                        XtraMessageBox.Show(msg);
                    }
                }
                DataRowSendEvent(sSlino);
                if (YN.Equals("N"))
                {
                    Close();
                }
                else if (YN.Equals("Y"))
                {
                    ComnEtcFunc.ClearAllForm(this);
                    Init();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        #region[버튼클릭이벤트]
        private void Bt_Reset_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void Bt_SaveMul_Click(object sender, EventArgs e)
        {
            Save("Y");
        }

        private void Bt_Save_Click(object sender, EventArgs e)
        {
            Save("N");
        }

        private void Bt_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private void layoutControlGroup3_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Tag.Equals("ADD"))
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Images Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)| *.jpg; *.jpeg; *.gif; *.bmp; *.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // new Bitmap(path)로 바로 로드하면 파일이 계속 잠긴 상태로 남고,
                        // 일부 파일에서 로드 실패가 조용히 무시되는 경우가 있어
                        // 스트림으로 읽은 뒤 복제해서 원본 파일 핸들을 즉시 해제한다.
                        using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read))
                        using (Image loaded = Image.FromStream(fs))
                        {
                            Pic_Iimg.Image = new Bitmap(loaded);
                        }
                        Pic_Iimg.Tag = ofd.FileName;
                        Pic_Iimg.Refresh();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("이미지를 불러오지 못했습니다.\r\n" + ex.Message, "이미지 첨부 실패");
                    }
                }
            }
            else if (e.Button.Properties.Tag.Equals("DEL"))
                Pic_Iimg.EditValue = null;
        }

        private void Be_Itnam_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Be_Itnam.Focus();
            ButtonEdit btnEdit = (ButtonEdit)sender;
            string sVal = btnEdit.EditValue?.ToString().Trim();
            ProductSelect frm = new ProductSelect();
            frm.Owner = this;
            frm.DataRowSendEvent += new ProductSelect.SendDataHandler(SetProductInfo);
            frm.FindWord = sVal;
            frm.ShowDialog();
        }

        private void SetProductInfo(DataRow row)
        {
            Tx_Itcod.EditValue = row["ITCOD"];
            Be_Itnam.EditValue = row["ITNAM"];
            
        }
    }
}