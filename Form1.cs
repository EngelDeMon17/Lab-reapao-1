using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_reapao__1
{
    public partial class Form1 : Form
    {
        //cargar empleados
        List<Empleado> empleados = new List<Empleado>();
        List<Asistencia> asistencias = new List<Asistencia>();
        List<Sueldo> sueldos = new List<Sueldo>();
        public Form1()
        {
            InitializeComponent();
        }

        public void CargarEmpleados()
        {
            //Leer el archivo y cargarlo a la lista
            //no se cargha al Datagridview por las operaciones que debemos realizar
            string fileName = "Empleados.txt";

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                //leer los datos del empleado
                Empleado empleado = new Empleado();
                empleado.NoEmpleado = Convert.ToInt16(reader.ReadLine());
                empleado.Nombre = reader.ReadLine();
                empleado.SueldoHora = Convert.ToDecimal(reader.ReadLine());

                //guardar el empleado en la lista de empleados
                empleados.Add(empleado);
            }
            reader.Close();

        }
        public void MostrarEmpleados()
        {

            //Mostrar la lista de empleados en el gridview
            dataGridViewEmpleados.DataSource = null;
            dataGridViewEmpleados.DataSource = empleados;
            dataGridViewEmpleados.Refresh();

        }

        public void CargarAsistencia()
        {
            //Leer el archivo y cargarlo a la lista
            //no se cargha al Datagridview por las operaciones que debemos realizar
            string fileName = "Asistencia.txt";

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                //leer los datos del empleado
                Asistencia asistencia = new Asistencia();
                asistencia.NoEmpleado = Convert.ToInt16(reader.ReadLine());
                asistencia.HorasMes = Convert.ToInt16(reader.ReadLine());
                asistencia.Mes = Convert.ToInt16(reader.ReadLine());
              
                asistencias.Add(asistencia);
            }
            reader.Close();

        }
        public void MostrarAsistencia()
        {

            //Mostrar la lista de empleados en el gridview
            dataGridViewAsistencia.DataSource = null;
            dataGridViewAsistencia.DataSource = asistencias;
            dataGridViewAsistencia.Refresh();

        }
        public void MostrarSueldo()
        {
            dataGridViewSueldos.DataSource = null;
            dataGridViewSueldos.DataSource = sueldos;
            dataGridViewSueldos.Refresh();

        }
        private void buttonCalcularSueldo_Click(object sender, EventArgs e)
        {
            
            //para recorrer otra lista
            //                            toma esta variable
            //         y la copia aqui          /
            foreach (Empleado empleado in empleados)
            {
                // int noEmpleado = empleado.NoEmpleado;
                foreach (Asistencia asistencia in asistencias)
                {
                    if (empleado.NoEmpleado == asistencia.NoEmpleado)
                    {
                        Sueldo sueldo = new Sueldo();
                        sueldo.NombreEmpleado = empleado.Nombre;
                        sueldo.Mes = asistencia.Mes;
                        sueldo.SueldoMensual = empleado.SueldoHora * asistencia.HorasMes;

                        sueldos.Add(sueldo);
                    }
                }
            }
            MostrarSueldo();
        }

        

        private void buttonCargarDatos_Click(object sender, EventArgs e)
        {
            CargarEmpleados();
            MostrarEmpleados();

            CargarAsistencia();
            MostrarAsistencia();

            
        }

       
    }
}
