using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TGMT;

namespace FaceMeshUI
{
    static class Program
    {
        public static FaceMeshMgr faceMeshMgr;
        public static bool inited = false;
        public static bool isDraw;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(FormMain.GetInstance());
        }
    }
}
