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
using static ProyectoSergio.frmAgenda;

namespace ProyectoSergio
{
    public partial class frmVentana : Form
    {
        public frmVentana()
        {
            InitializeComponent();
            //Apenas cambia a la segunda ventana el lee la informacion con StreamReader
            StreamReader archivo = new StreamReader("datos.txt");
            //Con un ciclo While le decimos que vaya leyendo linea por
            //linea y que vaya llenando el DGV
            while (!archivo.EndOfStream)
            {
                String Nombre = archivo.ReadLine();
                String Apellido = archivo.ReadLine();
                String Correo = archivo.ReadLine();
                String Fecha = archivo.ReadLine();
                String DirreccionCasa = archivo.ReadLine();
                String DireccionTrabajo = archivo.ReadLine();
                String Telefono1 = archivo.ReadLine();
                String Telefono2 = archivo.ReadLine();
                dgv1.Rows.Add(Nombre, Apellido, Correo, Fecha, DirreccionCasa,
                    DireccionTrabajo, Telefono1, Telefono2);
            }
            archivo.Close();

        }//Fin del metodo frmVentana


        //Boton regresar a la primera ventana
        private void button1_Click(object sender, EventArgs e)
        {
            frmAgenda agenda = new frmAgenda();
            agenda.Show();
            this.Hide();
        }//Fin del metodo del boton que regresa a la ventana inicial

        private void lblInicio_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Inicio del metodo del boton que elimina la informacion de la fila seleccionada y del archivo txt
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Primero se elimina la informacion de la fila seleccionada
            //Este codigo solo elimina la informacion del DGV, no del txt del StreamWriter
            DataGridViewRow filaSeleccionada = dgv1.CurrentRow;

            if (filaSeleccionada != null)
            {
                dgv1.Rows.Remove(filaSeleccionada);
            }

            //El siguiente codigo elimina la informacion de todo el archivo txt, no pude lograr que solo 
            //borrara la informacion de la fila seleccionada 
            StreamWriter writer = new StreamWriter("datos.txt");
            writer.Flush();
            writer.Close();

        }//Fin del metodo del boton Eliminar

        /*
         Inicio del metodo clickCelda o CellClick, este metodo permite que cuando se da click a una celda
         con un numero telefonico de la columna Telefono1 o Telefono2, se muestra un messagebox que dice llamando
         al numero seleccionado y seguidamente lo envia a la ventana Form3, simulando la llamada, dentro de esta
         ventana se encuentra un boton con un metodo que finaliza la llamada. Tambien contiene un bloque de codigo
         que al seleccionar una celda de la columna Correo se muestra un messagebox que dice enviando correo a la 
         persona seleccionada y lo dirige al Form4 que simula un correo electronico con destinatario, asunto
         y mensaje.
         */
        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Bloque if para llamar al numero de telefono 1
            //Si se selecciona cualquier indice mayor a 0 de la columna Telefono1 se ejecuta el codigo
            if (e.ColumnIndex == Telefono1.Index && e.RowIndex >= 0)
            {
                //Se guarda en la variable numeroTelefono el valor en string de la celda de la columna seleccionada
                string numeroTelefono = dgv1.Rows[e.RowIndex].Cells[Telefono1.Index].Value.ToString();

                //Se muestra un messagebox que se esta llamando al numero seleccionado
                MessageBox.Show($"Llamando al número {numeroTelefono}...");

                //Se muestra la ventana que contiene los elementos de la llamada
                var formularioLlamada = new frmLlamada(numeroTelefono);
                formularioLlamada.Show();
            }//Fin del if Telefono1

            //Bloque if para llamar al numero de telefono 2
            //Si se selecciona cualquier indice mayor a 0 de la columna Telefono2 se ejecuta el codigo
            if (e.ColumnIndex == Telefono2.Index && e.RowIndex >= 0)
            {
                //Se guarda en la variable numeroTelefono2 el valor en string de la celda de la columna seleccionada
                string numeroTelefono2 = dgv1.Rows[e.RowIndex].Cells[Telefono2.Index].Value.ToString();

                //Se muestra un messagebox que se esta llamando al numero seleccionado
                MessageBox.Show($"Llamando al número {numeroTelefono2}...");

                //Se muestra la ventana que contiene los elementos de la llamada
                var formularioLlamada = new frmLlamada(numeroTelefono2);
                formularioLlamada.Show();
            }//Fin del if Telefono2

            //Bloque if que permite abrir el formulario del email al seleccionar cualquier celda de la columna correos del Form2
            //Si se selecciona cualquier indice mayor a 0 de la columna Correo se ejecuta el codigo
            if (e.ColumnIndex == Correo.Index && e.RowIndex >= 0)
            {
                //Se crean variables que guardan el valor en formato string de la celda de la columna clickeada
                string correo = dgv1.Rows[e.RowIndex].Cells[Telefono1.Index].Value.ToString();
                string nombre = dgv1.Rows[e.RowIndex].Cells[Nombre.Index].Value.ToString();
                string apellido = dgv1.Rows[e.RowIndex].Cells[Apellido.Index].Value.ToString();

                //Se muestra una ventana con un mensaje que dice nuevo email y el nombre de la persona
                MessageBox.Show($"Nuevo correo electronico a {nombre + " " + apellido}...");

                //Se crea una variable para poder usar el keyword Show para mostrar el formulario del email
                var formularioCorreo = new frmCorreo(correo);
                formularioCorreo.Show();

            }//Fin del if Correo

        }//Fin del metodo clickCelda

    }//Fin de la clase frmVentana 

}//Fin del namespace


