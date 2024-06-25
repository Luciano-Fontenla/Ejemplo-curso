using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtNombre.Text;
            lwElementos.Items.Add(elem);
        }

        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbColor.Items.Add("Rojo");
            cmbColor.Items.Add("Negro");
            cmbColor.Items.Add("Azul");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechadeNacimiento.Value;
            //operador ternario , if de una sola linea
            string chocolate = cbChocolate.Checked == true ? "Le gusta el chocolate" : "No le gusta el chocolate";
            string Tipo;
            if (rdbMuggle.Checked)
                Tipo = "Muggle";
            else if (rdbWilzard.Checked)
                Tipo = "Wilzard";
            else
                Tipo = "Squibs";

            string colorFavorito = cmbColor.SelectedItem.ToString();
            string numeroFavorito = numUpDown.Value.ToString();
            string mensaje = chocolate + " , es " + Tipo + ", su color es " + colorFavorito + ", su numero favorito es " + numeroFavorito;
            MessageBox.Show("Nombre: " + nombre + "Fecha: " + fecha + " , " + mensaje);

        }
    }
}
