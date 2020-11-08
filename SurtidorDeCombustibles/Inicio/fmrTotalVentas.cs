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
    public partial class fmrTotalVentas : Form
    {
        public fmrTotalVentas()
        {
            InitializeComponent();
            //Combustible Liquido = new Combustible();
            string[] vs = new string[4];
            

            

            DataTable TablaVentas = new DataTable();
            
            TablaVentas.Columns.Add("PRODUCTO", typeof(string));
            TablaVentas.Columns.Add("CANTIDAD", typeof(decimal));
            TablaVentas.Columns.Add("MONTO", typeof(decimal));
            TablaVentas.Rows.Add();
            //TablaVentas.Rows[0]["Productos"]= Productos.
            //TablaVentas.Rows[0]["Productos"]= 
            dgvVentaTotal.DataSource = TablaVentas;
        }
    }
}
