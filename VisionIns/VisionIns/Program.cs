using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisionIns
{
    static class Program
    {
        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //디스플레이 배율(DPI) 확대 시 Windows가 화면을 비트맵으로 늘려 그려서
            //테두리/선이 흐릿하고 삐뚤게 보이는 현상 방지
            SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont = new System.Drawing.Font("맑은 고딕", 10F);
            Application.Run(new MN001F00());
        }
    }
}
