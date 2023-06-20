using MediaTekDocuments.view;
using System;
using System.Windows.Forms;
<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaTekDocuments.controller;
=======
>>>>>>> 57669e51f2da208af589e215345a9afb8c3e8666

namespace MediaTekDocuments
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new FrmAuthentification());
=======
            Application.Run(new FrmMediatek());
>>>>>>> 57669e51f2da208af589e215345a9afb8c3e8666
        }
    }
}
