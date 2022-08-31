using System.ComponentModel.DataAnnotations;

namespace TP1IngenieriaDelSoftware.Models
{
    public class Empleado
    {
        public int Legajo { get; set; } 
        public string Apellido_y_Nombre { get; set; }    
        public string Dni { get; set; }//string? o int?
        public EmailAddressAttribute Email { get; set; }// o string segun el DC

        public Empleado(int legajo, string apellido_y_Nombre, string dni, EmailAddressAttribute email)
        {
            Legajo = legajo;
            Apellido_y_Nombre = apellido_y_Nombre;
            Dni = dni;
            Email = email;
        }
    }
}
