using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using System.Threading;

namespace principal
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
           Application.EnableVisualStyles();
           Application.SetCompatibleTextRenderingDefault(false);
           new Escuela_Main().Run(args);
        }
    }

    public class Escuela_Main : WindowsFormsApplicationBase
    {
        int loadingTime = 3500;
        protected override void OnCreateSplashScreen()
        {
            this.SplashScreen = new SplashScreen(loadingTime);
        }
        protected override void OnCreateMainForm()
        {
            System.Threading.Thread.Sleep(loadingTime);
            this.MainForm = new Inicial();
        }
    }
}
