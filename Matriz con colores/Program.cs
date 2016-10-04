using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz_con_colores
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Plataforma> LPlat = new List<Plataforma>();

            List<Plataforma> LPlat2 = new List<Plataforma>();


            Console.SetBufferSize(101, 46);

            Console.SetWindowSize(100, 45);


            LPlat.Add(new PlatQuieta(25, 30, 1, ConsoleColor.Red));  // Y, W, X

            LPlat.Add(new PlatQuieta(40, 30, 1, ConsoleColor.Red));

            LPlat.Add(new PlatQuieta(35, 45, 1, ConsoleColor.Red));

            LPlat2.Add(new PlatQuieta(30, 30, 1, ConsoleColor.Red));

            LPlat2.Add(new PlatQuieta(15, 30, 1, ConsoleColor.Red));

            LPlat2.Add(new PlatQuieta(5, 45, 1, ConsoleColor.Red));

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                foreach (Plataforma lp in LPlat)
                {
                    lp.Dibujar();
                }

                Pantalla.Dibujar();

                Pantalla.BorrarMatriz();

                foreach (Plataforma lp in LPlat2)
                {
                    lp.Dibujar();
                }

                Console.ForegroundColor = ConsoleColor.Blue;

                Pantalla.Dibujar();

                Pantalla.BorrarMatriz();
            }

        }
    }
}
