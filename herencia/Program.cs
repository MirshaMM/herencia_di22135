using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace herencia
{
    /*programa de herencia 
        herencia es la característica de pasar atributos y metodos  a otros objetos o clases*/
    //clase mamá
    class Operacion
    {
        /*guarda los espacios de memoria de 3 variables (calores)*/
        //modificador        tipo de dato        nombre
        protected                 int             val1;
        protected                 int             val2;
        protected                 int           resultado;
    }
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
            Application.Run(new Form1());
        }
    }
}
