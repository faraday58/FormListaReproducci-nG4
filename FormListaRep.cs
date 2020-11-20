using System;
using System.Collections;
using System.Windows.Forms;

namespace FormListaReproduccionG4
{
    public partial class FormListaRep : Form
    {
        private Musica musica;
        private ArrayList canciones;

        private Form formPadre;

        /// <summary>
        /// Constructor de la clase FormListRep, requiere que el parámetro formPadre indicque el objeto
        /// de la clase FormRegistro
        /// </summary>
        /// <param name="formPadre">Parámetro de de tip form</param>

        public FormListaRep(Form formPadre  )
        {
            this.formPadre = formPadre;
            InitializeComponent();
            musica = new Musica("", "", "");
            lstReproducción.Items.Add(musica.Cancion);
            canciones = new ArrayList();
            canciones.Add(musica);
        }

        private void listaCanciones()
        {
            
            canciones.Add(new Musica("Noviembre sin ti","Reik","Reik"));
            canciones.Add(new Musica("Torero","Chayane","Grandes Éxitos"));
            canciones.Add(new Musica("Umbrella","Rihanna", "Good Girl Gone Bad: Reloaded"));
            canciones.Add(new Musica("Back in Black", "AC/DC", "Back in Black"));

        }
        private void lstReproducción_SelectedIndexChanged(object sender, EventArgs e)
        {
            musica = (Musica)canciones[lstReproducción.SelectedIndex];

            lbCancion.Text = musica.Cancion;
            lbArtista.Text = musica.Artista;
            lbAlbum.Text = musica.Album;         
        }

        private void cargarCancionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstReproducción.Items.Clear();
            listaCanciones();
            foreach(Musica musica in canciones)
            {
                lstReproducción.Items.Add(musica.Cancion);
            }

        }

        private void FormListaRep_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPadre.Show();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregar formAgregar = new FormAgregar();
            formAgregar.EnviarCancion += RecibirCancion;
            formAgregar.ShowDialog();
        }

        private void RecibirCancion(Musica musica)
        {
            canciones.Add(musica);
            lstReproducción.Items.Add(musica.Cancion);
        
        }
    }
}
