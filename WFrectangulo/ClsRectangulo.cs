using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WFrectangulo
{
    class ClsLinea
    {
        private int x;
        private int y;
        private int x2;
        private int y2;

        private static int contar = 0;

        public ClsLinea()
        {
            x = 0;
            y = 0;
            x2 = 0;
            y2 = 0;
        }
        public ClsLinea(int x, int y, int x2, int y2)
        {
            this.x = x;
            this.y = y;
            this.x2 = x2;
            this.y2 = y2;
        }
        public ClsLinea(double x, double y, double x2, double y2)
        {
            this.x = (int)x;
            this.y = (int)y;
            this.x2 = (int)x2;
            this.y2 = (int)y2;
        }
        public int obtenX()
        {
            return x;
        }
        public int obtenX2()
        {
            return x2;
        }
        public int obtenY() 
        {
            return y;
        }
        public int obtenY2()
        {
            return y2;
        }
        public int cambiarX()
        {
            return this.x;
        }
        public int cambiarX2()
        {
            return this.x2;
        }
        public int cambiarY()
        {
            return this.y;
        }
        public int cambiarY2()
        {
            return this.y2;
        }
        public static int obtengCuenta()
        {
            contar += 1;
            return contar;
        }
    }
}
