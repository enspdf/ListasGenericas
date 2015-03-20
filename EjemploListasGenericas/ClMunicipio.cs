using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploListasGenericas
{
    public class ClMunicipio
    {
        public string Nombre { get; set; }

        private ClPais _pais;
        public ClPais Pais
        {
            get
            {
                return _pais;
            }
            set
            {
                _pais = value;
            }
        }
    }
}
