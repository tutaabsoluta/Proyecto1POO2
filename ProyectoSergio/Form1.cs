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

namespace ProyectoSergio
{
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();

        }
        
        //Inicio del metodo del boton guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Se crea un StreamWriter que guardara la info en un archivo txt
            StreamWriter guardar = new StreamWriter("datos.txt", true);

            //Ponerle los nombres de los controles que se desean guadar
            guardar.WriteLine(txtNombre.Text + "\n" + 
                txtApellido.Text + "\n" +
                dpFecha.Text + "\n" +
                txtCorreo.Text + "\n" +
                txtTelefono1.Text + "\n" +
                txtTelefono2.Text + "\n" +
                txtDirecionCasa.Text + "\n" +
                txtDireccionTrabajo.Text);
            guardar.Flush();
            guardar.Close();
            //Se muestra una ventana con un mensaje de que se guardo la informacion
            MessageBox.Show("Informacion almacenada con exito!");

        //Se asignan comillas a cada control para dejarlos vacios
                txtNombre.Text = "";
                txtApellido.Text = "";
                dpFecha.Text = "";
                txtCorreo.Text = "";
                txtTelefono1.Text = "";
                txtTelefono2.Text = "";
                txtDirecionCasa.Text = "";
                txtDireccionTrabajo.Text = ""; ;
        }//Fin del metodo del boton Guardar


        //El boton permite acceder a la segunda ventana del programa
        private void btnAgenda_Click(object sender, EventArgs e)
        {

            frmVentana ventana = new frmVentana();
            ventana.Show();
            this.Hide();
        }//Fin del metodo del boton que muestra la ventana 2

    }//Fin de la clase FrmAgenda

}//Fin del namespace
