using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploListasGenericas
{
    public class ClPais
    {
        public string Nombre { get; set; }

        private ClMunicipio _capital;
        public ClMunicipio Capital
        {
            get
            {
                return _capital;
            }
            set
            {
                _capital = value;
            }
        }

        private List<ClDepartamento> _listaDepar;
        public List<ClDepartamento> ListaDepar
        {
            get
            {
                return _listaDepar;
            }
            set
            {
                _listaDepar = value;
            }
        }
    }
}
