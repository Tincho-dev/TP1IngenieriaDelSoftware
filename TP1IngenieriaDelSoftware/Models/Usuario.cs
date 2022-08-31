using System.Security.Cryptography;
using System.Text;
using TP1IngenieriaDelSoftware.Models;

namespace API_TFI.Model
{
    public class Usuario
    {
        public string _Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Permisos { get; set; }

        public Usuario(string usuario, string contraseña, string permisos)
        {
            this._Usuario = usuario;
            this.Contraseña = GetSHA256(contraseña);
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

        /*public Empleado ObtenerEmpleado()
        {
            return new Empleado();//TODO
        }
        */
    }
}
