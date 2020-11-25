using System;
using System.Collections;
using System.Windows.Forms;

namespace FormListaReproduccionG4
{
    public partial class FormListaRep : Form
    {
        #region Atributos
        private Musica musica;
        private ArrayList canciones;
        private int contador;
        private Form formPadre;
        private int duracion;
        #endregion
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

            canciones.Add(new Musica("Noviembre sin ti", "Reik", "Reik"));
            canciones.Add(new Musica("Torero", "Chayane", "Grandes Éxitos"));
            canciones.Add(new Musica("Umbrella", "Rihanna", "Good Girl Gone Bad: Reloaded"));
            canciones.Add(new Musica("Back in Black", "AC/DC", "Back in Black"));

        }


        #region Manejadores de Eventos

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

        private void timerTiempoCancion_Tick(object sender, EventArgs e)
        {
            if (contador <= 100)
            {
                int x = 100 / duracion;
                int segundos = contador / x;
                lbTiempoTrans.Text = segundos + " [s]";
                pgbDuracion.Value = contador;
                contador += x;                            
            }
            else
            {
                contador = 0;
                pgbDuracion.Value = contador;
                timerTiempoCancion.Stop();

            }

        }
        #endregion

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if( lstReproducción.SelectedIndex  != -1  )
            {
                musica = (Musica)canciones[lstReproducción.SelectedIndex];
                duracion =musica.Duracion;
                lbTiempoTotal.Text = duracion + " [s]";
                timerTiempoCancion.Start();
            }
            
        }

        private void siguienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(lstReproducción.SelectedIndex == lstReproducción.Items.Count-1  )
            {
                lstReproducción.SelectedIndex = 0;
            }
            else
            {
                lstReproducción.SelectedIndex += 1;
            }            
            musica = (Musica)canciones[lstReproducción.SelectedIndex];
            duracion = musica.Duracion;
            lbTiempoTotal.Text = duracion + " [s]";
            contador = 0;
        }

        private void pausarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerTiempoCancion.Stop();
        }

        private void anteriorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (lstReproducción.SelectedIndex == 0)
            {
                lstReproducción.SelectedIndex = lstReproducción.Items.Count-1;
            }
            else
            {
                lstReproducción.SelectedIndex -= 1;
            }
            musica = (Musica)canciones[lstReproducción.SelectedIndex];
            duracion = musica.Duracion;
            lbTiempoTotal.Text = duracion + " [s]";
            contador = 0;
        }
    }
}
