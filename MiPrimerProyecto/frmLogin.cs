using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerProyecto
{
    public partial class frmLogin : Form
    {
        private string user = "administrador21" ;
        private string pass = "1234";


        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {
             
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Text = "Logeo!!";
        }

        private void btnIngresar_Click(object sender, EventArgs e)

        {
            if (this.txtUsuario.Text == "")
            {
                MessageBox.Show("Debe ingresar un usuario");
                this.txtUsuario.Focus();
                return;

            }
            if (this.txtClave.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar una contrasena");
                this.txtClave.Focus();
                return;
            }
            if (this.txtUsuario.Text == this.user && this.txtClave.Text == this.pass)
            {
                MessageBox.Show("Login OK", "Ingreso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Usuario y/o contrasena incorrectos", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsuario.Text = " ";
                this.txtClave.Text = " ";
                this.txtUsuario.Focus();

            }
        }
    }
}
