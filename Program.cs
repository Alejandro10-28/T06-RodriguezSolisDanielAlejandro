using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertidorU
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se instancia la bienvenida y el menú 
            Principal M = new Principal();
            M.Bienvenida();
            M.Menu();
        }
    }
}
