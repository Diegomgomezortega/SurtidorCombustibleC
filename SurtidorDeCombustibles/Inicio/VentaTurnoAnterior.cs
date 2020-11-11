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
    public partial class VentaTurnoAnterior : Form
    {
        public VentaTurnoAnterior()
        {
            InitializeComponent();
            DataTable dtUltimoTurno = new DataTable();
            dtUltimoTurno.TableName = "TOTAL DE VENTAS";
            dtUltimoTurno.Columns.Add("PRODUCTO", typeof(string));
            dtUltimoTurno.Columns.Add("LITROS", typeof(decimal));
            dtUltimoTurno.Columns.Add("TOTAL $", typeof(decimal));
            
            dtUltimoTurno.ReadXml("@Turno");
            dgvTurnoAnterior.DataSource = dtUltimoTurno;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
