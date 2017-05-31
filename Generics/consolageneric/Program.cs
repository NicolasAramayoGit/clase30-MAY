using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generics;

namespace consolageneric
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Autos unauto = new Autos("toyota",123asda,"azul");

            Muebles unmueble = new Muebles(4, "pino", 50);
            Container<Muebles> uncontainer = new Container<Muebles>(4);

            bool dato = uncontainer + unmueble;

            TV untv =new TV("asasas",21,21);
            Container<TV> mcount = new Container<TV>(4);

            foreach (TV item in mcount)
	        {
                item.ToString();
	        }
        }
    }
}
