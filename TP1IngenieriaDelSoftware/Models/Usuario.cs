using System.Security.Cryptography;
using System.Text;

namespace TP1IngenieriaDelSoftware.Model
{
    public class Usuario
    {
        public string User { get; set; }
        public string Password { get; set; }
        public string Permisos { get; set; }

        public Usuario(string usuario, string contraseña, string permisos)
        {
            this.User = usuario;
            this.Password = GetSHA256(contraseña);
            Permisos = permisos;
        }

        //encriptacion
        public static string GetSHA256(string str)
        {
            SHA256 sha256 = SHA256.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[]? stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        internal bool ValidarContraseña(string contraseniaEncriptada)
        {
            return this.Contraseña == contraseniaEncriptada;
        }

        /*public Empleado ObtenerEmpleado()
        {
            return new Empleado();//TODO
        }
        */
    }
}
