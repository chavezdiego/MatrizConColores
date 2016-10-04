using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz_con_colores
{
    class PlatQuieta : Plataforma
    {
        public PlatQuieta()
            : base()
        {

        }

        public PlatQuieta(int posY, int WP, int XP, ConsoleColor clr)
            : base(posY, WP, XP, clr)
        {
        }

        override public void Dibujar()
        {
            int TamañoChar = w * h;

            char[] img = new char[TamañoChar];

            for (int t = 0; t < TamañoChar; t++)
            {
                img[t] = '#';
            }
            Pantalla.CargarAMatriz(img, w, h, pos.x, (int)pos.y);

        }
    }
}
