﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escape_Room
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GreetingsForm());
            //Application.Run(new Part1());
            //Application.Run(new Part2());
            //Application.Run(new Part3());
            //Application.Run(new Part4());
            //Application.Run(new TheEND());
        }
    }
}
