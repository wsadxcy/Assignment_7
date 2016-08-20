using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_7
{
    /* Author : Chenyuan Xie
 * Date : Aug 19th, 2016
 * Date Modified: Aug 19th, 2016
 * Description : Assignment 7
 * Version : 1.0 - 
 *                  Added Documentary
 *                  Initial release
 */
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
            Application.Run(new Splash_Screen());
        }
    }
}
