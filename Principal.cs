using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertidorU
{
    class Principal
    {
        //Instacie las clases globalmente para utilizarla en cada uno de los metodos
        RepoC kl = new RepoC();
        Operaciones S = new Operaciones();

        public void Bienvenida()
        {
            Console.WriteLine("======BIENVENIDO A MI CONVERTIDOR DE UNIDADES======");
            Console.WriteLine("Presione cualquier tecla para iniciar");
            Console.ReadKey();
            Console.Clear();
        }
        public void Menu()
        {
            Console.WriteLine("Elije un número para empezar a convertir");
            Console.WriteLine("   1- De CM a M");
            Console.WriteLine("   2- De M a IN ");
            Console.WriteLine("   3- De Lt a MC");
            Console.WriteLine("   4- Salir");
            int M = Convert.ToInt32(Console.ReadLine());
            //Utilize un switch para que el usuario elija alguna de las opciones presentadas
            switch (M)
            {
                case 1:
                    //Mando a llamar los metodos correspondientes segun la información requerida
                    cmM();
                   
                    break;
                case 2:
                    MAP();

                    break;
                case 3:
                    LTMC();
                    break;
                case 4:
                    //Metodo que da la opcion para salir del usuario
                    Salir();
                    break;
                default:
                    //En dado caso que el usuario pida una opcion distinta se le avisara que no es valido
                    Console.WriteLine("NO VALIDO");
                    Console.WriteLine("Intente con otro número");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
               



            }
            
        }
        //Cree cada metodo para que el usuario al elegir la operación solo pidiera los datos ya correspondientes
        public void cmM()
        {
            Console.WriteLine("====Ingresa valor en Cm=====");
            kl.cm = Convert.ToDouble(Console.ReadLine());
            Console.ReadKey();
            //Una ves que el usuario ingresa el valor;se mandan los datos ingresados al metodo que hara los procedimientos 
            //Correspondientes.
            S.GetDatos(kl.cm, out double TR);
            Console.WriteLine("Resultado en Metros es:" + TR);
            Console.ReadKey();
            Console.Clear();
            Menu();
        }
        public void MAP()
        {
            Console.WriteLine("====Ingresa valor en m====");
            kl.Me = Convert.ToDouble(Console.ReadLine());
            //Una ves que el usuario ingresa el valor;se mandan los datos ingresados al metodo que hara los procedimientos 
            //Correspondientes.
            S.GetDatos(kl.Me, out double MP, out double IN);
            Console.WriteLine("Resultado en pulgadas es:" + MP);
            Console.ReadKey();
            Console.Clear();
            Menu();
        }
        public void LTMC()
        {
            Console.WriteLine("====Ingresa valor en lt====");
            kl.lt = Convert.ToDouble(Console.ReadLine());
            //Una ves que el usuario ingresa el valor;se mandan los datos ingresados al metodo que hara los procedimientos 
            //Correspondientes.
            S.GetDatos(kl.lt, out double MC, out double L, out double K);
            Console.WriteLine("Resultado en Metros cubicos es:" + MC);
            Console.ReadKey();
            Console.Clear();
            Menu();
        }
        public void Salir()
        {
            Environment.Exit(0);
        }
    }
    
}
