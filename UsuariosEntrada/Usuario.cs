namespace UsuariosEntrada
{
    public class Usuario
    {

        #region Atributos
        private string nombreUsuario;
        private string password;       
        #endregion

        #region Propiedades
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Password { get => password; set => password = value; }
        #endregion
        #region Constructor

        /// <summary>
        /// Constructor para asignar a usuario Nombre y contraseña
        /// </summary>
        /// <param name="nombreUsuario">Nombre del usuario</param>
        /// <param name="password">Contraseña del usuario</param>
        public Usuario(string nombreUsuario, string password)
        {
            NombreUsuario = nombreUsuario;
            Password = password;
        }
        #endregion



    }
}
