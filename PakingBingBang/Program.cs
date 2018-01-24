using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace PakingBingBang
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var currentProcess = System.Diagnostics.Process.GetCurrentProcess().Id;
            foreach (var process in System.Diagnostics.Process.GetProcessesByName("PakingBingBang"))
            {
                if (process.Id != currentProcess)
                {
                    MessageBox.Show("YA TIENE UNA APLICACION ABIERTA");
                    Process p = Process.GetProcessById(currentProcess);
                        p.Kill();
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FRMprincipal());
        }
    }
}
