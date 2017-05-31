using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class TV
    {
        public string marca;
        public int pulgadas;
        public int resolucion;

        public TV(string marca, int pulg, int res)
        {
            this.marca = marca;
            this.pulgadas = pulg;
            this.resolucion = res;

        }

    }
}
