using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            SplashForm.ShowSplashScreen();
            Form1 mainForm = new Form1(); //this takes ages
            Thread.Sleep(2000);
            SplashForm.CloseForm();
            Application.Run(mainForm);
        }
    }
    }
