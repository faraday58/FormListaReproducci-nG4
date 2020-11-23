using System;
namespace FormListaReproduccionG4
{
    public class Musica
    {
        #region Atributos
        private string cancion;
        private string artista;
        private string album;
        private int duracion;
        #endregion

        #region Constructor
        public Musica(string cancion, string artista, string album)
        {
            Cancion = cancion;
            Artista = artista;
            Album = album;
        }
        #endregion


        #region Propiedades
        public string Cancion { 
            get => cancion;
            set
            {
                if(value == "")
                {
                    cancion = "Zombie";
                }
                else
                {
                    cancion = value;
                }
                
            }
        }
        public string Artista
        {
            get => artista;
            set
            {
                if (value == "")
                {
                    artista = "Yulien";
                }
                else
                {
                    artista = value;
                }
            }
        }
        public string Album { get => album;

            set
            {
                if(value== "")
                {
                    album = "Welcome to Metropolis";
                }
                else
                {
                    album = value;
                }
                
            } 
        }

        public int Duracion {
            get
            {
                Random aleatorio = new Random();
                duracion = aleatorio.Next(4,11);
                return   duracion;
            }
            set => duracion = value; 
        }
        #endregion


    }
}
