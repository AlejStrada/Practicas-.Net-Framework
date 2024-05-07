using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionWindows
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalculoFactura calculo = new CalculoFactura();
            calculo.kwhtTotal = double.Parse(txttotalkwh.Text);
            calculo.kwhDepartamento = double.Parse(txtConsumosBimestre.Text);           
            calculo.impuestos = double.Parse(txtImpuestos.Text);
            calculo.importeKwh = double.Parse(txtImporteKwh.Text);
            lblImporteaPagar.Text = "$ " + calculo.calculo().ToString("00.00");

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            btnCalcular.Enabled = false;    
        }

        private void txttotalkwh_TextChanged(object sender, EventArgs e)
        {
            if (txttotalkwh.Text == "" || txtImpuestos.Text == "" || txtImporteKwh.Text == "" || txtConsumosBimestre.Text == "")
                btnCalcular.Enabled = false;
            else btnCalcular.Enabled = true;
        }

        private void txtImporteKwh_TextChanged(object sender, EventArgs e)
        {
            if (txttotalkwh.Text == "" || txtImpuestos.Text == "" || txtImporteKwh.Text == "" || txtConsumosBimestre.Text == "")
                btnCalcular.Enabled = false;
            else btnCalcular.Enabled = true;
        }

        private void txtImpuestos_TextChanged(object sender, EventArgs e)
        {
            if (txttotalkwh.Text == "" || txtImpuestos.Text == "" || txtImporteKwh.Text == "" || txtConsumosBimestre.Text == "")
                btnCalcular.Enabled = false;
            else btnCalcular.Enabled = true;
        }

        private void txtConsumosBimestre_TextChanged(object sender, EventArgs e)
        {
            if (txttotalkwh.Text == "" || txtImpuestos.Text == "" || txtImporteKwh.Text == "" || txtConsumosBimestre.Text == "")
                btnCalcular.Enabled = false;
            else btnCalcular.Enabled = true;
        }
    }
}
