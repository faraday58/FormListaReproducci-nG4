
namespace EntradaUsuarios
{
    public class Usuario
    {
        #region Atributos
        private string nombreUsuario;
        private string password;

        #endregion

        #region Propiedades       
        public string Password { get => password; set => password = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor de Usuario
        /// </summary>
        /// <param name="password">Contraseña del usuario</param>
        /// <param name="nombreUsuario">Nombre del usuario a ingresar</param>
        public Usuario(string password, string nombreUsuario)
        {
            Password = password;
            NombreUsuario = nombreUsuario;
        }
        #endregion



    }

}
