using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hook;

namespace UMacro
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            if (MouseHook.getHookHandle() != 0)
                MouseHook.StopHook();
            if (KeyboardHook.getHookHandle() != 0)
                KeyboardHook.StopHook();
        }
    }
}
