using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bar
{
    public partial class ingreseNombreCliente : Form
    {
        public string response = "";
        public ingreseNombreCliente()
        {
            InitializeComponent();
        }

        private void ingreseNombreCliente_Load(object sender, EventArgs e)
        {
            txtCantidad.Focus();

        }

        private void ingreseNombreCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            response = txtCantidad.Text;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            response = txtCantidad.Text;
            this.Hide();
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAccept_Click(sender, new EventArgs());
            }
        }
    }
}
