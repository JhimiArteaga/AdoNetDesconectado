using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdoNetDesconectado
{
    public partial class Form1 : Form
    {
        string cadenaConexion = @"Server=localhost\SQLEXPRESS; DataBase=SQLConectado; Integrated Security = true";
        SqlDataAdapter adaptador;
        SqlConnection conexion;
        DataSet datos;

        public Form1()
        {
            InitializeComponent();
            conexion = new SqlConnection(cadenaConexion);

            adaptador = new SqlDataAdapter();

            datos = new DataSet();

            adaptador.SelectCommand = new SqlCommand("SELECT * FROM TipoCliente", conexion);

        }

        private void cargarFormulario(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        private void mostrarDatos()
        {
            adaptador.Fill(datos, "TipoCliente");

            dgvDatos.DataSource = datos.Tables["TipoCliente"];
        }

        private void nuevoRegistro(object sender, EventArgs e)
        {
            var frm = new frmTipoClienteEdit();
            if (frm.ShowDialog() == DialogResult.OK) ;
            
        }

        private void editarRegistro(object sender, EventArgs e)
        {

        }
    }
}
