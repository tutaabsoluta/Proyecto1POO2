using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSergio
{
    public partial class frmLlamada : Form
    {
        public frmLlamada()
        {
        }

        public frmLlamada(string cellValue)
        {
            InitializeComponent();

        }


        private void frmLlamada_Load(object sender, EventArgs e)
        {

        }

        //Inicio del metodo del boton que permite finalizar la llamada
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea finalizar la llamada?", "Llamando...",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }//Fin del metodo del boton finalizar llamada

    }//Fin de la clase frmLlamada

}//Fin del namespace
