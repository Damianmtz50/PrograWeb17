using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrograWeb16;

namespace PrograWeb16
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CargaGrid();
            //Form3();
            CargaComboCarreras();
            CargaComboMaterias();
           
        }



        private void Limpiatextos()
        {
            txtNoControl.Text = "";
            txtNombre.Text = "";
            txtApePaterno.Text = "";
            txtApeMaterno.Text = "";
            CmbCarreras.SelectedIndex = 0;
            CmbMaterias.SelectedIndex = 0;
        }

        //UNIDAD 3 LAS CARRERAS  5 DE MAYO 2020 
        //UNIDAD 3_VERSION_6
        private void CargaComboCarreras()
        {
          string xCadenaConexion = "Data Source=192.168.201.1\\LABSQL;Initial " + "Catalog=PrograWeb16;user id=PrograWeb16;password=PrograWeb16";
            // string xCadenaConexion = "Data Source=DESKTOP-KN12MFT/SQLEXPRESS//LABSQL;Initial" + " PrograWeb16;user id=PrograWeb16  ;password=PrograWeb16" ;
        
        //abrir base de datos();
        SqlConnection conexionBD = new SqlConnection(xCadenaConexion);
        SqlCommand comandoSQL = new SqlCommand();

            comandoSQL.Connection = conexionBD;
            comandoSQL.CommandText = "Sp_Carreras_Prl";
            comandoSQL.CommandType = CommandType.StoredProcedure;

            comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", 'T'));
            System.Data.SqlClient.SqlDataAdapter adaptador = new SqlDataAdapter(comandoSQL);

            DataTable resultado = new DataTable();
            adaptador.Fill(resultado);
            CmbCarreras.DisplayMember = "Nom_Carrera";
            CmbCarreras.ValueMember = "Id_Carrera";
            CmbCarreras.DataSource = resultado;

            //txtDireccion.txt ="";
        }



        //METODO PARA LA CARGA DE MATERIAS

        private void CargaComboMaterias()
        {
            string xCadenaConexion = "Data Source=192.168.201.1\\LABSQL;Initial " + "Catalog=PrograWeb16;user id=PrograWeb16;password=PrograWeb16";
            // string xCadenaConexion = "Data Source=DESKTOP-KN12MFT/SQLEXPRESS//LABSQL;Initial" + " PrograWeb16;user id=PrograWeb16  ;password=PrograWeb16" ;

            //abrir base de datos();
         SqlConnection conexionBD = new SqlConnection(xCadenaConexion);
            SqlCommand comandoSQL = new SqlCommand();

            comandoSQL.Connection = conexionBD;
            comandoSQL.CommandText = "Sp_Materias_Prl";
            comandoSQL.CommandType = CommandType.StoredProcedure;

            comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", 'T'));
            System.Data.SqlClient.SqlDataAdapter adaptador = new SqlDataAdapter(comandoSQL);

            DataTable resultado = new DataTable();
            adaptador.Fill(resultado);
            CmbMaterias.DisplayMember = "Nom_Materia";
            CmbMaterias.ValueMember = "Id_Materia";
            CmbMaterias.DataSource = resultado;

            //txtDireccion.txt ="";
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {

        }

        private void CmbCarreras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    



        private void btnAltas_Click(object sender, EventArgs e)
        {
            try
            { 
                string xCadenaConexion = "Data Source=192.168.201.1\\LABSQL;Initial " + "Catalog=PrograWeb16;user id=PrograWeb16;password=PrograWeb16";
            // string xCadenaConexion = "Data Source=DESKTOP-KN12MFT/SQLEXPRESS//LABSQL;Initial" + " PrograWeb16;user id=PrograWeb16  ;password=PrograWeb16" ;
       SqlConnection conexionBD = new SqlConnection(xCadenaConexion);
       SqlCommand comandoSQL = new SqlCommand();

            comandoSQL.Connection = conexionBD;
            comandoSQL.CommandText = "Sp_Alumnos_Prl";
            comandoSQL.CommandType = CommandType.StoredProcedure;
            comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", 'I'));


            comandoSQL.Parameters.Add(new SqlParameter(@"Id_Control", Convert.ToInt64(txtNoControl.Text)));

            comandoSQL.Parameters.Add(new SqlParameter("@Nombre", txtNombre.Text));
            comandoSQL.Parameters.Add(new SqlParameter("@Ape_Paterno", txtApePaterno.Text));
            comandoSQL.Parameters.Add(new SqlParameter("@Ape_Materno", txtApeMaterno.Text));
            //comandoSql.Parameters.Add(new SqlParameter("@Fecha_ing", Convert.ToDateTime
            comandoSQL.Parameters.Add(new SqlParameter("Id_Carrera", Convert.ToInt64(CmbCarreras.SelectedValue.ToString())));
            comandoSQL.Parameters.Add(new SqlParameter("Id_materia", Convert.ToInt64(CmbCarreras.SelectedValue.ToString())));

            conexionBD.Open();
            comandoSQL.ExecuteNonQuery();
            conexionBD.Close();
            //       CargaGrid();

            MessageBox.Show("Alta Efectuada");
            //this.close();
            Limpiatextos();

            }
            catch 
            {
                MessageBox.Show("Alta ya existe");
            }

            }

        private void CargaGrid()
        {

            string xCadenaConexion = "Data Source= 192.168.201.1\\LABSQL; Initial " +
               "Catalog=PrograWeb16;user id=PrograWeb16;password=PrograWeb16";

            //Abrir_base_datos();
           SqlConnection conexionDB = new SqlConnection(xCadenaConexion);
           SqlCommand comandoSQL = new SqlCommand();

            comandoSQL.Connection = conexionDB;
            comandoSQL.CommandText = "Sp_Alumnos_Prl";
            comandoSQL.CommandType = CommandType.StoredProcedure;


            comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", 'T'));

            System.Data.SqlClient.SqlDataAdapter adaptador = new SqlDataAdapter(comandoSQL);

            DataTable resultado = new DataTable();
            adaptador.Fill(resultado);

            dgVDatosAl.DataSource = resultado;





        }

      

        private void dgVDatosAl_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNoControl.Text = dgVDatosAl.CurrentRow.Cells["Id_Control"].Value.ToString();
            txtNombre.Text = dgVDatosAl.CurrentRow.Cells["Nombre"].Value.ToString();
            txtApePaterno.Text = dgVDatosAl.CurrentRow.Cells["Ape_Paterno"].Value.ToString();
            txtApeMaterno.Text = dgVDatosAl.CurrentRow.Cells["Ape_Materno"].Value.ToString();

            CmbCarreras.SelectedValue = Convert.ToInt16(dgVDatosAl.CurrentRow.Cells["Id_Carrera"].Value.ToString());
            CmbMaterias.SelectedValue = Convert.ToInt16(dgVDatosAl.CurrentRow.Cells["Id_Materia"].Value.ToString());

        }

        private void btnBajas_Click(object sender, EventArgs e)
        {
            string xCadenaConexion = "Data Source= 192.168.201.1\\LABSQL; Initial " +
               "Catalog=PrograWeb16;user id=PrograWeb16;password=PrograWeb16";
            Int32 piNoControl = Int32.Parse(txtNoControl.Text);

            try
            {
                SqlConnection conexionBD = new SqlConnection(xCadenaConexion);
                SqlCommand comandoSQL = new SqlCommand();


                comandoSQL.Connection = conexionBD;
                comandoSQL.CommandText = "Sp_Alumnos_Prl";
                comandoSQL.CommandType = CommandType.StoredProcedure;
                comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", 'D'));

                comandoSQL.Parameters.Add(new SqlParameter("@Id_Control", piNoControl));

                conexionBD.Open();
                comandoSQL.ExecuteNonQuery();
                conexionBD.Close();
                CargaGrid();
                Limpiatextos();
                MessageBox.Show("baja efectuada");
            }
            catch  { 
            }
        }

        private void txtNoControl_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void txtNoControl_Leave(object sender, EventArgs e)
        {
            if(this.txtNoControl.Text == "")
            {
            }

            else
            {
                string xCadenaConexion = "Data Source=192.168.201.1\\LABSQL;Initial " + "Catalog=PrograWeb16;user id=PrograWeb16;password=PrograWeb16";
                // string xCadenaConexion = "Data Source=DESKTOP-KN12MFT/SQLEXPRESS//LABSQL;Initial" + " PrograWeb16;user id=PrograWeb16  ;password=PrograWeb16" ;
                SqlConnection conexionBD = new SqlConnection(xCadenaConexion);
                SqlCommand comandoSQL = new SqlCommand();


                comandoSQL.Connection = conexionBD;
                comandoSQL.CommandText = "Sp_Alumnos_Prl";
                comandoSQL.CommandType = CommandType.StoredProcedure;
                comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", 'L'));

                comandoSQL.Parameters.Add(new SqlParameter("@Id_Control",
                Convert.ToInt32(this.txtNoControl.Text)));
                System.Data.SqlClient.SqlDataAdapter adaptador = new SqlDataAdapter(comandoSQL);

                DataTable resultado = new DataTable();
                adaptador.Fill(resultado);
                if (resultado.Rows.Count == 0)
                {
                }
                else
                {
                    this.txtNombre.Text =resultado.Rows[0]["Nombre"].ToString();
                    this.txtApePaterno.Text = resultado.Rows[0]["Ape_Paterno"].ToString();
                    this.txtApeMaterno.Text = resultado.Rows[0]["Ape_Materno"].ToString();

                    CmbCarreras.SelectedValue = Convert.ToInt16(dgVDatosAl.CurrentRow.Cells["Id_Carrera"].Value.ToString());
                    CmbMaterias.SelectedValue = Convert.ToInt16(dgVDatosAl.CurrentRow.Cells["Id_Materia"].Value.ToString());

                }
            }
        }

        private void btnCambios_Click(object sender, EventArgs e)
        {
            try
            {
                string xCadenaConexion = "Data Source=192.168.201.1\\LABSQL;Initial " + "Catalog=PrograWeb16;user id=PrograWeb16;password=PrograWeb16";
                // string xCadenaConexion = "Data Source=DESKTOP-KN12MFT/SQLEXPRESS//LABSQL;Initial" + " PrograWeb16;user id=PrograWeb16  ;password=PrograWeb16" ;
                SqlConnection conexionBD = new SqlConnection(xCadenaConexion);
                SqlCommand comandoSQL = new SqlCommand();

                comandoSQL.Connection = conexionBD;
                comandoSQL.CommandText = "Sp_Alumnos_Prl";
                comandoSQL.CommandType = CommandType.StoredProcedure;
                comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", 'C'));


                comandoSQL.Parameters.Add(new SqlParameter(@"Id_Control", Convert.ToInt64(txtNoControl.Text)));

                comandoSQL.Parameters.Add(new SqlParameter("@Nombre", txtNombre.Text));
                comandoSQL.Parameters.Add(new SqlParameter("@Ape_Paterno", txtApePaterno.Text));
                comandoSQL.Parameters.Add(new SqlParameter("@Ape_Materno", txtApeMaterno.Text));
                //comandoSql.Parameters.Add(new SqlParameter("@Fecha_ing", Convert.ToDateTime
                comandoSQL.Parameters.Add(new SqlParameter("Id_Carrera", Convert.ToInt64(CmbCarreras.SelectedValue.ToString())));
                comandoSQL.Parameters.Add(new SqlParameter("Id_materia", Convert.ToInt64(CmbCarreras.SelectedValue.ToString())));

                conexionBD.Open();
                comandoSQL.ExecuteNonQuery();
                conexionBD.Close();
                //       CargaGrid();

                MessageBox.Show("Cambio efectuado");
                //this.close();
                Limpiatextos();

            }
            catch 
            {
                MessageBox.Show("cambio ya existente");
            }

        }

    }

}