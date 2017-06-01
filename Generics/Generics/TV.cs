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

        /// <summary>
        /// retorna una cadena de string con todos los datos de la clase.
        /// </summary>
        /// <returns></returns>
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Marca: " + this.marca);
            sb.AppendLine("Pulgadas: " + this.pulgadas);
            sb.AppendLine("resolución: " + this.resolucion);

            return sb.ToString();
        }

        /// <summary>
        /// Sobrecarga del método ToString().
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}
