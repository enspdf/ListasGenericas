using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploListasGenericas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ClAlumno Alumno_AnaMAria = new ClAlumno();
            List<ClMateria> listaMaterias = new List<ClMateria>();
            Alumno_AnaMAria.MateriasAlumno = listaMaterias;
            ClUniversidad miuni = new ClUniversidad();
            Alumno_AnaMAria.Universidad = miuni;
            Alumno_AnaMAria.Edad = 20;
            Alumno_AnaMAria.Nombre = "Ana Maria";
            Alumno_AnaMAria.NroIdentificacion = "2783562";

            ClDepartamento Departameno = new ClDepartamento();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
