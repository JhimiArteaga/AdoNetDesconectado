using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDesconectado
{
    public partial class frmTipoClienteEdit : Form
    {
        DataRow fila;
        public frmTipoClienteEdit(DataRow filaEditar)
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void aceptarCambios(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("DEBE INGRESAR UN NOMBRE VALIDO ","Sistemas"),
                    MessageBoxButtons.OK , MessageBoxIcon.Error);
                return;
            }
        }
    }
}
