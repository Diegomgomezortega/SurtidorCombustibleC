using Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio
{



    public partial class Ventas : Form
    {

        Combustible Liquido = new Combustible();
        //decimal[] Precios = new decimal[4];
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
            //DataTable TablaVentas = new DataTable();

            //TablaVentas.TableName = "Historial";
            //TablaVentas.Columns.Add("PRODUCTO", typeof(string));
            //TablaVentas.Columns.Add("CANTIDAD", typeof(decimal));
            //TablaVentas.Columns.Add("MONTO", typeof(decimal));
           
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

        public void btnOK_Click(object sender, EventArgs e)

        {
            string[] NombreLiquidos = new string[4];
            NombreLiquidos[1] = "Super";
            NombreLiquidos[0] = "Premium";
            NombreLiquidos[2] = "Euro Diesel";
            NombreLiquidos[3] = "Diesel";
            
            if (btnSuper.Checked)

            {
                //TablaVentas.Rows.Add();
                //Combustible Liquido = new Combustible();

                Liquido.Indice = 1;
                Liquido.PrecioCombustible[Liquido.Indice] = PrecioSuper;

                Venta(NombreLiquidos, Liquido);
                Liquido.TotaldeVenta = Venta(Liquido.TotaldeVenta);

            }
            if (btnPremium.Checked)

            {
                Combustible Liquido = new Combustible();

                Liquido.Indice = 0;

                Liquido.PrecioCombustible[Liquido.Indice] = PrecioPremium;

                Venta(NombreLiquidos, Liquido);
            }

            if (btnDiesel.Checked)

            {
                Combustible Liquido = new Combustible();

                Liquido.Indice = 3;
                Venta(NombreLiquidos, Liquido);
            }

            if (btnEuro.Checked)

            {

                Combustible Liquido = new Combustible();

                Liquido.Indice = 2;
                Liquido.PrecioCombustible[Liquido.Indice] = PrecioEuro;

                Venta(NombreLiquidos, Liquido);
            }

            txtMonto.Text = "$" + txtVisorVenta.Text;
            txtVisorVenta.Text = "";
            
        }

        private decimal Venta(decimal VentaLitros, decimal TotaldeVenta)
        {
            //Liquido.Nombre[Liquido.Indice] = NombreLiquidos[Liquido.Indice];

            //Liquido.MontodeVenta = System.Convert.ToDecimal(txtVisorVenta.Text);

            //Liquido.VentaCombustible();
            VentaLitros= System.Convert.ToDecimal(txtMonto.Text) / Liquido.PrecioCombustible[Liquido.Indice];
            TotaldeVenta = TotaldeVenta+ MontodeVenta;
            txtProducto.Text = Liquido.Nombre[Liquido.Indice];
            txtCantidadLitros.Text = System.Convert.ToString(Liquido.LitrosVendidos[Liquido.Indice]);
        }


       
        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtVisorVenta.Text = "";
        }

        

        

        private void totalDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrTotalVentas fmr = new fmrTotalVentas();
            fmr.ShowDialog();

        }
    }







    


    
}
