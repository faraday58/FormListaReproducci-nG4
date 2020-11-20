using System;
using System.Windows.Forms;

namespace FormListaReproduccionG4
{
    public partial class FormAgregar : Form
    {
        public delegate void DelegadoEnviarCancion(Musica musica);
        public event DelegadoEnviarCancion EnviarCancion;
        public FormAgregar()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Agrega una canción al formualrio lista reproducción
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {            
            EnviarCancion(new Musica(txtbCancion.Text,txtbArtista.Text,txtbAlbum.Text));
        }
    }
}
