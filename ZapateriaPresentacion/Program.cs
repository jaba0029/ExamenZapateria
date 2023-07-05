using Splat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZapateriaPresentacion.Services.Implement;
using ZapateriaPresentacion.Services.Interface;

namespace ZapateriaPresentacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Locator.CurrentMutable.Register(() => new StoreService(), typeof(IStoreService));
            Application.Run(new frmFrontEnd());
        }
    }
}
