using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrograWeb16
{
    public partial class Form2 : Form
    {

        int I = 1;

        
        //UNIDAD_2 AQUI UNA CONSULTA DE LOS ALUMNOS




        public Form2()
        {
            InitializeComponent();
        }

        private void Btnconsultar_Click(object sender, EventArgs e)
        {
            if (txtNoControl.Text =="")
            {
            }
            else
            {
                dgvAgregar.Rows.Add(I, txtNoControl.Text, txtNombre.Text, txtApePaterno.Text, txtApeMaterno.Text, dtpFecha.Value, cboDiasdelasemana.Text.ToString(),
                    cboMesdelaño.Text.ToString());
                I = I + 1;
                txtNoControl.Text = "";
                txtNombre.Text = "";
                txtApePaterno.Text = "";
                txtApeMaterno.Text = "";
                dtpFecha.Value = System.DateTime.Today;
                txtNoControl.Focus();

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dgvAgregar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
