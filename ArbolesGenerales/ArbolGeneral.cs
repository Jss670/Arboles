using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolesGenerales
{
    Public class ArbolGeneral
    {
        private readonly Nodo raiz;

        //public Nodo Raiz => raiz;

        public Nodo Raiz { get { return raiz } }

        public ArbolGeneral(string dato)
        {
            raiz = new Nodo(dato);
        }

        public Nodo InsertarHijo(Nodo padre, string dato)
        {
            if (string.IsNullOrWhiteSpace(dato)
            {
                throw new Exception("el dato esta vacio");

            }
            if (padre is null)
            {
                throw new Exception("el padre no puede ser nulo");
            }
            if (padre.Hijo is null)
            {
                padre.Hijo = new Nodo(dato);
                return padre.Hijo;

            }
        }
    }
}
