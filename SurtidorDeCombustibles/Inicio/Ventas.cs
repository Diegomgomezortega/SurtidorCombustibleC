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
        //Se crean la tabla de Ventas, el objeto liquido y se da valor a variables de uso comun
        DataTable tabladeventas = new DataTable();
        Combustible Liquido = new Combustible();
        decimal PrecioSuper = 65.00m;
        decimal PrecioPremium = 75.00m;
        decimal PrecioDiesel = 60.00m;
        decimal PrecioEuro = 70.00m;
        bool GuardarVentas=true;
        public decimal[] LitrosVendidos = new decimal[4];//Arreglo de litros de cada producto: 0=Premium;1=Super;2=Euro;3=Diesel
        public decimal[] MontoVendido = new decimal[4];//Arreglo de Monto de cada producto: 0=Premium;1=Super;2=Euro;3=Diesel
        int indice = new int();
        decimal litros = 0;
        decimal Monto = 0;
        decimal Total = 0;







        public Ventas()
        {
            InitializeComponent();
            //Se da formato a algunos controles del formulario Ventas
            lblSuper.Text = System.Convert.ToString(PrecioSuper);
            lblDiesel.Text = System.Convert.ToString(PrecioDiesel);
            lblEuro.Text = System.Convert.ToString(PrecioEuro);
            lblPremium.Text = System.Convert.ToString(PrecioPremium);
            btnPremium.Checked = true;
            //Se da formato inicial a la tabla Ventas
            tabladeventas.TableName = "TOTAL DE VENTAS";
            tabladeventas.Columns.Add("PRODUCTO", typeof(string));
            tabladeventas.Columns.Add("LITROS", typeof(decimal));
            tabladeventas.Columns.Add("TOTAL $", typeof(decimal));
            tabladeventas.Rows.Add("Premium");
            tabladeventas.Rows.Add("Super");
            tabladeventas.Rows.Add("Euro");
            tabladeventas.Rows.Add("Diesel");
            tabladeventas.Rows.Add("TOTAL");
            dataGridView1.DataSource = tabladeventas;
            dataGridView1.Visible = false;

        }//Formulario display de Ventas


        private void btn1_Click(object sender, EventArgs e)
        {
            txtVisorVenta.Text = txtVisorVenta.Text + btn1.Text;

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
            if (txtVisorVenta.Text == "")
            {

            }
            else
                txtVisorVenta.Text = txtVisorVenta.Text + btn0.Text;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (GuardarVentas == false)
            {
                MessageBox.Show("Por favor, guarde el turno antes de salir.");
            }

            if (GuardarVentas == true) 
            {
                this.Hide();
                frmInicio Formulario = new frmInicio();
                Formulario.Show();
            }
                
        }


        
        
        public void btnOK_Click(object sender, EventArgs e)

        {
            try
            {
                if (btnSuper.Checked)

                {
                    

                    txtProducto.Text = btnSuper.Text;
                    Liquido.Precio = PrecioSuper;
                    indice = 1;
                    Monto = System.Convert.ToDecimal(txtVisorVenta.Text);

                    Venta();//este metodo se encuentra en este formulario
                    CargaDatosTabla();//este metodo se encuenta en este formulario

                }
                if (btnPremium.Checked)

                {
                    txtProducto.Text = btnPremium.Text;
                    Liquido.Precio = PrecioPremium;
                    indice = 0;
                    Monto = System.Convert.ToDecimal(txtVisorVenta.Text);
                    Venta();//este metodo se encuentra en este formulario
                    CargaDatosTabla();//este metodo se encuenta en este formulario
                }

                if (btnDiesel.Checked)
                {
                    txtProducto.Text = btnDiesel.Text;
                    Liquido.Precio = PrecioDiesel;
                    indice = 3;
                    Monto = System.Convert.ToDecimal(txtVisorVenta.Text);
                    Venta();//este metodo se encuentra en este formulario
                    CargaDatosTabla();//este metodo se encuenta en este formulario
                }

                if (btnEuro.Checked)
                {
                    txtProducto.Text = btnEuro.Text;
                    Liquido.Precio = PrecioSuper;
                    indice = 2;
                    Monto = System.Convert.ToDecimal(txtVisorVenta.Text);

                    Venta();//este metodo se encuentra en este formulario
                    CargaDatosTabla();//este metodo se encuenta en este formulario
                }

            }
            catch
            {
                MessageBox.Show("Por favor, ingrese el monto a cargar");
            }
            Total = Total + Monto;
            tabladeventas.Rows[4]["TOTAL $"]=Total;

            GuardarVentas = false;

        }//Dentro de este botón, se realiza la carga y cálculos de las diferentes variables

        private void CargaDatosTabla()
        {
            
            tabladeventas.Rows[indice]["LITROS"] = LitrosVendidos[indice];
            MontoVendido[indice] = MontoVendido[indice] + Monto;
            tabladeventas.Rows[indice]["TOTAL $"] = MontoVendido[indice];
        }

        private decimal Venta()
        {
            
            Liquido.MontodeVenta = System.Convert.ToDecimal(txtVisorVenta.Text);
            litros = Liquido.LitrosVenta(litros);//Este metodo se encuentra en Productos.cs

            txtCantidadLitros.Text = System.Convert.ToString(litros);
            txtMonto.Text = "$" + txtVisorVenta.Text;
            txtVisorVenta.Text = "";
            LitrosVendidos[indice] = LitrosVendidos[indice] + litros;
            return LitrosVendidos[indice];
            
        }
              
        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtVisorVenta.Text = "";
        }

        private void totalDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Visible == true)
            {
                dataGridView1.Visible = false;
            }
            else
            {
                dataGridView1.Visible = true;
            }
        }

        private void cerrarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabladeventas.WriteXml("@Turno");
            dataGridView1.DataSource = tabladeventas;
            GuardarVentas = true;
            MessageBox.Show("Se ha guardado el turno");
            this.Hide();
            Ventas frm = new Ventas();

            frm.Show();
        }

        private void cargarTotalVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabladeventas.ReadXml("@Turno");
            dataGridView1.DataSource = tabladeventas;
            MessageBox.Show("Ya es visible el total de Ventas");
        }

        private void verUltimoTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentaTurnoAnterior ventaTurnoAnterior = new VentaTurnoAnterior();
            ventaTurnoAnterior.ShowDialog();

        }
    }
}







    


    

