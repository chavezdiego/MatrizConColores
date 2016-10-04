using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz_con_colores
{
    abstract class Plataforma
    {
        protected Punto pos = new Punto();

        protected static Random rnd = new Random();

        protected int w, h;

        protected ConsoleColor color;

        public Plataforma()
        {
        }



        public Plataforma(int posY, int WP, int XP)
        {
            pos.y = posY;
            w = WP;
            pos.x = XP;
        }
        public Plataforma(int posY, int WP, int XP, ConsoleColor clr)
        {
            pos.y = posY;
            w = WP;
            h = 2;
            pos.x = XP;
            color = clr;
        }

        public int obtenerY()
        {
            return (int)pos.y;
        }

        public int obtenerX()
        {
            return pos.x;
        }

        public int obtenerW()
        {
            return w;
        }

        public int obtenerH()
        {
            return h;
        }
        abstract public void Dibujar();

        virtual public void Explotar(Plataforma Plat)
        {

        }

        virtual public bool Eliminar()
        {
            return true;
        }

        virtual public void Borrar()
        {

        }

        public bool intersecta(int e, int i)
        {
            return (e >= pos.x && e < (pos.x + w) && i >= pos.y && i < (pos.y + h));
        }
    }
}
