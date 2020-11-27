using System;
using System.Collections;
using System.Drawing;
using EntradaUsuarios;
using System.Windows.Forms;
using FormListaReproduccionG4;
namespace FormRegistroG4
{
    public partial class FormReg : Form
    {
        //ejemplo
        #region Atributos
        ArrayList usuarios;
        bool correcto = false;
        #endregion
        public FormReg()
        {
            InitializeComponent();
            usuarios = new ArrayList();
            usuarios.Add(new Usuario("123","Armando"));
            usuarios.Add(new Usuario("567", "Jorge"));

        }


        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(ValidaUsuario())
            {

                FormListaRep formListaRep = new FormListaRep(this);
                this.Hide();
                formListaRep.Show();

            }else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public bool ValidaUsuario()
        {
            
            foreach (Usuario usuario in usuarios)
            {
                if (txtbUsuario.Text == usuario.NombreUsuario && txtbContraseña.Text == usuario.Password)
                {

                    correcto = true;
                    break;
                }
                else
                {
                    correcto= false;
                }

            }

            return correcto;
        }

        private void txtbContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar == (char)Keys.Enter   )
            {

                ValidaUsuario();

            }
        }

        private void btnEntrar_MouseHover(object sender, EventArgs e)
        {
            btnEntrar.BackColor = Color.DarkKhaki;
        }
    }
}
