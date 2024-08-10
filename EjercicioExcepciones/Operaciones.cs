using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExcepciones
{
    public class Operaciones
    {
        public double N1 { get; set; }
        public double N2 { get; set; }

        public Operaciones() { }

        public double Suma()
        {
            return N1 + N2;
        }

        public double Resta()
        {
            return N1 - N2;
        }

        public double Multiplicacion()
        {
            return N1 * N2;
        }

        public double Division()
        {         
                return N1 / N2;                     
        }





    }
}
