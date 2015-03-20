using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploListasGenericas
{
    class ClUniversidad
    {
        public string Nombre { get; set; }
        public int Nit { get; set; }
        public string Direccion { get; set; }

        private ClUniversidad _universidad;
        public ClUniversidad Universidad
        {
            get
            {
                return _universidad;
            }
            set
            {
                _universidad = value;
            }
        }
    }
}
