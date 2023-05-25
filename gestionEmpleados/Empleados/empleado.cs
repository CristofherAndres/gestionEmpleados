using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionEmpleados.Empleados
{
    public class Empleado
    {
        private string nombre;
        private string direccion;
        private string email;
        
        //Constructor
        public Empleado(string nombre, string direccion, string email)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.email = email;
        }

        //GETTER y SETTER

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public void mostrarDatosEmpleado()
        {
            MessageBox.Show("El nombre es: " + nombre + "\nsu dirección es: " + direccion + "\nSu email es: " + email);
        }

    }


}
