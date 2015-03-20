using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploListasGenericas
{
    class ClAlumno
    {
        public string Nombre { get; set; }
        public int Edad { set; get; }
        public string NroIdentificacion { get; set; }

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

        private List<ClMateria> _listaMaterias;
        public List<ClMateria> MateriasAlumno
        {
            get
            {
                return _listaMaterias;
            }
            set
            {
                _listaMaterias = value;
            }
        }

    }
}
