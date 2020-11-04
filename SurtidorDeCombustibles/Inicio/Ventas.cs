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


        
        decimal PrecioSuper = 65.00m;
        decimal PrecioPremium = 75.00m;
        decimal PrecioDiesel = 60.00m;
        decimal PrecioEuro = 70.00m;
        
        








        public Ventas()
        {
            InitializeComponent();
            lblSuper.Text = System.Convert.ToString(PrecioSuper);
            lblDiesel.Text = System.Convert.ToString(PrecioDiesel);
            lblEuro.Text = System.Convert.ToString(PrecioEuro);
            lblPremium.Text = System.Convert.ToString(PrecioPremium);
            btnPremium.Checked = true;
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
            if (txtVisorVenta.Text=="")
            {
                
            }
            else
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
            
            if (btnSuper.Checked)

            {
                Combustible Liquido = new Combustible();
                
                Liquido.Indice = 1;
                Liquido.Nombre[Liquido.Indice] = "Super";
                Liquido.PrecioCombustible[Liquido.Indice] = PrecioSuper;
                Liquido.MontodeVenta = System.Convert.ToDecimal(txtVisorVenta.Text);

                Liquido.VentaCombustible();
                txtProducto.Text = Liquido.Nombre[Liquido.Indice];
                txtCantidadLitros.Text = System.Convert.ToString(Liquido.LitrosVendidos[Liquido.Indice]);
            }
            //if (btnPremium.Checked)

            //{
            //    Combustible Liquido = new Combustible();

            //    Liquido.Indice = 0;
            //    Liquido.Precio = PrecioPremium;
            //    Liquido.MontodeVenta = System.Convert.ToDouble(txtVisorVenta.Text);
            //    int ini=0;
            //    Liquido.VentaCombustible();
            //    txtProducto.Text = btnPremium.Text;
            //    for (ini=0; ini ==System.Convert.ToInt32(txtVisorVenta.Text);ini++);
            //    {
            //        txtMonto.Text = System.Convert.ToString(ini);
            //        this.Refresh();
            //    }
            //    //txtCantidadLitros.Text = System.Convert.ToString(Liquido.LitrosVendidos[Liquido.Indice]);
            //}

            //if (btnDiesel.Checked)

            //{
            //    Combustible Liquido = new Combustible();

            //    Liquido.Indice = 2;
            //    Liquido.Precio = PrecioDiesel;
            //    Liquido.MontodeVenta = System.Convert.ToDouble(txtVisorVenta.Text);

            //    Liquido.VentaCombustible();
            //    txtProducto.Text = btnDiesel.Text;
            //    txtCantidadLitros.Text = System.Convert.ToString(Liquido.LitrosVendidos[Liquido.Indice]);
            //}

            //if (btnEuro.Checked)

            //{
            //    Combustible Liquido = new Combustible();

            //    Liquido.Indice = 3;
            //    Liquido.Precio = PrecioEuro;
            //    Liquido.MontodeVenta = System.Convert.ToDouble(txtVisorVenta.Text);

            //    Liquido.VentaCombustible();
            //    txtProducto.Text = btnEuro.Text;
            //    txtCantidadLitros.Text = System.Convert.ToString(Liquido.LitrosVendidos[Liquido.Indice]);
            //}

            txtMonto.Text = "$" + txtVisorVenta.Text;
            txtVisorVenta.Text = "";







        }

        private void Ventas_Load(object sender, EventArgs e)
        {
           // lblSuper.Text = 65;
        }

        private void txtPrecioPremium_TextChanged(object sender, EventArgs e)
        {
            //txtPrecioPremium.Text = System.Convert.ToString(PrecioPremium);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtVisorVenta.Text = "";
        }
    }







    


    
}
