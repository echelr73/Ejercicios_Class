using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Class
{
    public partial class Form1 : Form
    {
        List<Rectangulo> listRectangulo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listRectangulo = new List<Rectangulo>();

        }
        private void mostrar()
        {
            lbRectangulo.Items.Clear();
            foreach (Rectangulo pieza in listRectangulo)
            {
                lbRectangulo.Items.Add("Base: " + pieza.getBase().ToString() + " Altura: " + pieza.getAltura().ToString() );
            }
        }

        private void bCrear_Click(object sender, EventArgs e)
        {
            if (tbBase.Text == "")
            {
                MessageBox.Show("Por favor agregar el valor de Base", "Rectangulo");
                tbBase.Focus();
            }
            else if (tbAltura.Text == "")
            {
                MessageBox.Show("Por favor agregar el valor de Altura", "Rectangulo");
                tbAltura.Focus();
            }
            else
            { Rectangulo nuevo;
                nuevo = new Rectangulo(Convert.ToDouble(tbBase.Text), Convert.ToDouble(tbAltura.Text));

                listRectangulo.Add(nuevo);
                mostrar();
                    
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bArea_Click(object sender, EventArgs e)
        {
            lbArea.Items.Clear();
            if (lbRectangulo.SelectedIndex == -1)
            {
                MessageBox.Show("No ha seleccionado ningun Rectangulo");
            }
            else
            {
                
                   lbArea.Items.Add(Convert.ToString(listRectangulo[lbRectangulo.SelectedIndex].Area())); 
            }
        }

        private void bPerimetro_Click(object sender, EventArgs e)
        {
            lbPerimetro.Items.Clear();
            if (lbRectangulo.SelectedIndex == -1)
            {
                MessageBox.Show("No ha seleccionado ningun Rectangulo");
            }
            else
            {

                lbPerimetro.Items.Add(Convert.ToString(listRectangulo[lbRectangulo.SelectedIndex].Perimetro()));
            }
        }
    }
}
