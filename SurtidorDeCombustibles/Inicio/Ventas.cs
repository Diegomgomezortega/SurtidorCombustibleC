﻿using Productos;
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
        //Se crean la tabla de Ventas,  tabla de Venta anterior, el objeto liquido y se da valor a variables de uso comun
        DataTable dtVentas = new DataTable();
        DataTable dtVentaAnterior = new DataTable();
        Combustible Liquido = new Combustible();
        decimal PrecioSuper = 65.00m;
        decimal PrecioPremium = 75.00m;
        decimal PrecioDiesel = 60.00m;
        decimal PrecioEuro = 70.00m;
        bool GuardarVentas = true;
        public decimal[] LitrosVendidos = new decimal[4];//Arreglo de litros de cada producto: 0=Premium;1=Super;2=Euro;3=Diesel
        public decimal[] MontoVendido = new decimal[5];//Arreglo de Monto de cada producto: 0=Premium;1=Super;2=Euro;3=Diesel;4=TotalGeneralVentas
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
            dtVentas.TableName = "TOTAL DE VENTAS";
            dtVentas.Columns.Add("PRODUCTO", typeof(string));
            dtVentas.Columns.Add("LITROS", typeof(decimal));
            dtVentas.Columns.Add("TOTAL $", typeof(decimal));
            dtVentas.Rows.Add("Premium");
            dtVentas.Rows.Add("Super");
            dtVentas.Rows.Add("Euro");
            dtVentas.Rows.Add("Diesel");
            dtVentas.Rows.Add("TOTAL");
            dgvVentaActual.DataSource = dtVentas;
            dgvVentaActual.Visible = false;
            //Se da formato a la tabla Venta anterior
            dtVentaAnterior.TableName = "TOTAL DE VENTAS";
            dtVentaAnterior.Columns.Add("PRODUCTO", typeof(string));
            dtVentaAnterior.Columns.Add("LITROS", typeof(decimal));
            dtVentaAnterior.Columns.Add("TOTAL $", typeof(decimal));
            //Si tenemos un archivo de turno anterior, lo lee. Si no, sigue creando las filas de la dtVentaAnterior
            if (!System.IO.File.Exists("@TurnoAnterior"))
            {
                dtVentaAnterior.Rows.Add("Premium");
                dtVentaAnterior.Rows.Add("Super");
                dtVentaAnterior.Rows.Add("Euro");
                dtVentaAnterior.Rows.Add("Diesel");
                dtVentaAnterior.Rows.Add("TOTAL");
            }
            else
            {
                dtVentaAnterior.ReadXml("@TurnoAnterior");
            }
            
            dgvVentaAnterior.DataSource = dtVentaAnterior;
            dgvVentaAnterior.Visible = false;

            ////DataTable dtTotalVentasGeneral = new DataTable();
            //dtTotalVentasGeneral.TableName = "TOTAL DE VENTAS";
            //dtTotalVentasGeneral.Columns.Add("PRODUCTO", typeof(string));
            //dtTotalVentasGeneral.Columns.Add("LITROS", typeof(decimal));
            //dtTotalVentasGeneral.Columns.Add("TOTAL $", typeof(decimal));
            //if (!System.IO.File.Exists("@VentaGeneral"))
            //{
            //    dtTotalVentasGeneral.Rows.Add("Premium");
            //    dtTotalVentasGeneral.Rows.Add("Super");
            //    dtTotalVentasGeneral.Rows.Add("Euro");
            //    dtTotalVentasGeneral.Rows.Add("Diesel");
            //    dtTotalVentasGeneral.Rows.Add("TOTAL");
            //    dtTotalVentasGeneral.Rows[1]["LITROS"] = 0;
            //    dtTotalVentasGeneral.Rows[1]["TOTAL $"] = 0;
            //    dtTotalVentasGeneral.Rows[0]["LITROS"] = 0;
            //    dtTotalVentasGeneral.Rows[0]["TOTAL $"] = 0;
            //    dtTotalVentasGeneral.Rows[2]["LITROS"] = 0;
            //    dtTotalVentasGeneral.Rows[2]["TOTAL $"] = 0;
            //    dtTotalVentasGeneral.Rows[3]["LITROS"] = 0;
            //    dtTotalVentasGeneral.Rows[3]["TOTAL $"] = 0;
            //}
                        
            //dgvTotalVentas.DataSource = dtTotalVentasGeneral;
            //dgvTotalVentas.Visible = false;
        }//Constructor


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

        //Dentro de este botón, se realiza la carga y cálculos de las diferentes variables
        public void btnOK_Click(object sender, EventArgs e)

        {
            try//Evita que el usuario no coloque el monto antes de vender
            {
                //Se realiza una accion de acuerdo a qué producto esta seleccionado
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
                    Liquido.Precio = PrecioEuro;
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
            dtVentas.Rows[4]["TOTAL $"] = Total;

            GuardarVentas = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtVisorVenta.Text = "";
        }//Borra el contenido del Visor de ventas

        private void totalDeVentasToolStripMenuItem_Click(object sender, EventArgs e) //Muestra las ventas actuales
        {
            if (dgvVentaActual.Visible == true)
            {
                dgvVentaActual.Visible = false;
            }
            else
            {
                dgvVentaActual.Visible = true;
                dgvVentaAnterior.Visible = false;
            }
        }

        private void cerrarVentasToolStripMenuItem_Click(object sender, EventArgs e)//control que habilita guardar las ventas
        {
            if (GuardarVentas == true)//Si no hay ventas, no guarda
            {
                MessageBox.Show("No hay ventas para guardar");
            }
            if (GuardarVentas == false)//Si hay ventas, guarda y vuelve al Formulario de Inicio
            {

                dtVentas.WriteXml("@TurnoAnterior");
                //dtTotalVentasGeneral.WriteXml("@VentaGeneral");
                //dgvVentaActual.DataSource = tabladeventas;

                GuardarVentas = true;
                MessageBox.Show("Se ha guardado el turno");
                this.Hide();
                frmInicio frm = new frmInicio();
                frm.Show();
            }

        }

        

        private void verUltimoTurnoToolStripMenuItem_Click(object sender, EventArgs e)//Muestra el turno anterior
        {
            if (!System.IO.File.Exists("@TurnoAnterior"))
            
            {
                MessageBox.Show("No hay guardado algún turno");

            }
            else
            {
                if (dgvVentaAnterior.Visible == true)
                {
                    dgvVentaAnterior.Visible = false;
                }
                else
                {
                    dgvVentaAnterior.Visible = true;
                    //dgvTotalVentas.Visible = false;
                    dgvVentaActual.Visible = false;
                    ;
                }
            }
            
        }

        private void TotalDeVentasGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

           // if (!System.IO.File.Exists("@VentaGeneral"))
           // {
           //     MessageBox.Show("No hay ventas acumuladas para mostrar");
           // }
           // if(System.IO.File.Exists("@VentaGeneral"))
           // {
           //     //dtTotalVentasGeneral.ReadXml("@VentaGeneral");
           //     //dgvTotalVentas.DataSource = dtTotalVentasGeneral;
           //     if (dgvTotalVentas.Visible == true)
           //     {
           //         dgvTotalVentas.Visible = false;
           //     }
           //     else
           //     {
           //         dgvTotalVentas.Visible = true;
           //         dgvVentaActual.Visible = false;
           //         dgvVentaAnterior.Visible = false;
           //     }


           // }
            



           // //dtTotalVentasGeneral.TableName = "TOTAL DE VENTAS";
           // //dtTotalVentasGeneral.Columns.Add("PRODUCTO", typeof(string));
           // //dtTotalVentasGeneral.Columns.Add("LITROS", typeof(decimal));
           // //dtTotalVentasGeneral.Columns.Add("TOTAL $", typeof(decimal));
           // //dtTotalVentasGeneral.Rows.Add("Premium");
           // //dtTotalVentasGeneral.Rows.Add("Super");
           // //dtTotalVentasGeneral.Rows.Add("Euro");
           // //dtTotalVentasGeneral.Rows.Add("Diesel");
           // //dtTotalVentasGeneral.Rows.Add("TOTAL");

           
           ////litros= System.Convert.ToDecimal(dtVentas.Rows[1]["LITROS"]) + System.Convert.ToDecimal(dtVentaAnterior.Rows[1]["LITROS"]);
           //// dtTotalVentasGeneral.Rows[1]["LITROS"] = litros;
           //     //dtTotalVentasGeneral.Rows[indice]["LITROS"] = System.Convert.ToDecimal(dtVentas.Rows[indice]["LITROS"]) + System.Convert.ToDecimal(dtUltimoTurno.Rows[indice]["LITROS"]);
           //     //dtTotalVentasGeneral.Rows[indice]["LITROS"] = litros;
           //     //dtTotalVentasGeneral.Rows[indice]["TOTAL $"] = System.Convert.ToDecimal(dtVentas.Rows[indice]["TOTAL $"]) + System.Convert.ToDecimal(dtVentaAnterior.Rows[indice]["TOTAL $"]);
           //     //dtTotalVentasGeneral.Rows[indice]["TOTAL $"] = System.Convert.ToDecimal(dtVentas.Rows[indice]["TOTAL"]) + System.Convert.ToDecimal(dtUltimoTurno.Rows[indice]["TOTAL"]);
           //     //dtTotalVentasGeneral.Rows[indice]["TOTAL $"] = Monto;

           //     //dtVentas.Rows[indice]["LITROS"] = LitrosVendidos[indice];
           //     //MontoVendido[indice] = MontoVendido[indice] + Monto;
           //     //dtVentas.Rows[indice]["TOTAL $"] = MontoVendido[indice];

           
           // //dgvTotalVentas.DataSource = dtTotalVentasGeneral;

            
            
            
           // //dgvVentaAnterior.
           // //indice = 0;
           // //for (indice = 0, indice = 3, ++)
           // //{
           // //    dtTotalVentasGeneral.Rows[indice]["LITROS"] = LitrosVendidos[indice];
           // //    MontoVendido[] = MontoVendido[indice] + Monto;
           // //    tabladeventas.Rows[indice]["TOTAL $"] = MontoVendido[indice];

           // //}

            

        }
        private void CargaDatosTabla()//se carga en la tabla los datos de la venta
        {

            dtVentas.Rows[indice]["LITROS"] = LitrosVendidos[indice];
            MontoVendido[indice] = MontoVendido[indice] + Monto;
            dtVentas.Rows[indice]["TOTAL $"] = MontoVendido[indice];
            //dtTotalVentasGeneral.Rows[indice]["TOTAL $"] =System.Convert.ToDecimal(dtTotalVentasGeneral.Rows[indice]["TOTAL $"]) + Monto;
            //dtTotalVentasGeneral.Rows[indice]["LITROS"] = System.Convert.ToDecimal(dtTotalVentasGeneral.Rows[indice]["LITROS"]) + LitrosVendidos[indice];
        }

        private decimal Venta()//Se calcula y se colocan los datos en la imagen del surtidor
        {

            Liquido.MontodeVenta = System.Convert.ToDecimal(txtVisorVenta.Text);
            litros = Liquido.LitrosVenta(litros);//Este metodo se encuentra en Productos.cs

            txtCantidadLitros.Text = System.Convert.ToString(litros);
            txtMonto.Text = "$" + txtVisorVenta.Text;
            txtVisorVenta.Text = "";
            LitrosVendidos[indice] = LitrosVendidos[indice] + litros;
            return LitrosVendidos[indice];

        }

        
    }
}







    


    

