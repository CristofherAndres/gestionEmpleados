using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestionEmpleados.Empleados;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace gestionEmpleados
{
    public partial class Form1 : Form
    {
        //Definir una lista global
        List<Empleado> Empleados = new List<Empleado>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("FUNCIONA......");
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            string email = txtEmail.Text;



            if (nombre.Length > 0 && direccion.Length > 0 && email.Length > 0)
            {

                //limpiar txtNombre,txtDireccion, txtEmail
                txtNombre.Text = "";
                txtDireccion.Text = "";
                txtEmail.Text = "";

                //Crear un empleado temporal
                Empleado empTemp = new Empleado(nombre, direccion, email);

                //Agregamos el empleado a la lista Empleados
                Empleados.Add(empTemp);

                //Mostrar un mensaje que el empleado se añadio
                MessageBox.Show("Se añadio correctamente");

            }
            else
            {
                MessageBox.Show("Debes completar todos los datos");
            }

        }

        private void btnMostrarEmp_Click(object sender, EventArgs e)
        {
            foreach (var item in Empleados)
            {
                //Crear un empleado temporal
                Empleado empTemp = item;
                Console.WriteLine("El nombre del empleado es: " + empTemp.Nombre);
                empTemp.mostrarDatosEmpleado();
            }
        }
    }
}
