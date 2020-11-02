using Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio
{



    public partial class Ventas : Form
    {
        
         

        



        public Ventas()
        {
            InitializeComponent();
        }
    
        private void btn1_Click(object sender, EventArgs e)
        {txtVisorVenta.Text = txtVisorVenta.Text+ btn1.Text;

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtVisorVenta.Text = txtVisorVenta.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtVisorVenta.Text = txtVisorVenta.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtVisorVenta.Text = txtVisorVenta.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtVisorVenta.Text = txtVisorVenta.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtVisorVenta.Text = txtVisorVenta.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtVisorVenta.Text = txtVisorVenta.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtVisorVenta.Text = txtVisorVenta.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtVisorVenta.Text = txtVisorVenta.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtVisorVenta.Text = txtVisorVenta.Text + btn0.Text;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicio Formulario = new frmInicio();
            Formulario.Show();
        }

        private void btnOK_Click(object sender, EventArgs e)

        {
            //Combustible Liquido = new Combustible();
            //Liquido.Precio[0] = 75;
            //Liquido.Precio[1] = 68;
            //Liquido.Precio[2] = 70;
            //Liquido.Precio[3] = 65;


            if (btnSuper.Checked)

            {
                int Indice = 1;
                Liquido.LitrosVendidos[Indice] = System.Convert.ToDouble(txtVisorVenta.Text) / Liquido.Precio[Indice];
                txtCantidadYMonto.Text = System.Convert.ToString(System.Convert.ToDouble(txtVisorVenta.Text) / Liquido.Precio[Indice]);


                //double[] Precio = new double[4];
                //double[] VentaDeProductos = new double[4];
                //double[] LitrosVendidos = new double[4];



            }
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
           // lblSuper.Text = 65;
        }
    }







    


    
}
