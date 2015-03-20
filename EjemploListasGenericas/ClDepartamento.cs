using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploListasGenericas
{
    public class ClDepartamento
    {
        public string Nombre { get; set; }

        private List<ClMunicipio> _listaMunicipio;
        public List<ClMunicipio> ListaMunicipio
        {
            get
            {
                return _listaMunicipio;
            }
            set
            {
                _listaMunicipio = value;
            }
        }

        private ClMunicipio _capitalDepar;
        public ClMunicipio CapitalDepar
        {
            get
            {
                return _capitalDepar;
            }
            set
            {
                _capitalDepar = value;
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
