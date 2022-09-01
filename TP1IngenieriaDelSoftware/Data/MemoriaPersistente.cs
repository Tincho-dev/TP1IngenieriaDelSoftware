using NodaTime;
using System.Data;
using TP1IngenieriaDelSoftware.Model;

namespace TP1IngenieriaDelSoftware.Data
{
    public class MemoriaPersistente
    {

        public List<Usuario> Usuarios = new();
        public List<OrdenProduccion> OrdenesDeProduccion = new();
        public List<Color> Colores = new();
        public List<Modelo> Modelos = new();
        public List<Turno> Turnos = new();
        public List<Linea> Lineas = new();

        public MemoriaPersistente()
        {
            SetData();
        }

        public void SetData()
        {
            Usuarios.Add(new Usuario("Agustina", "1234", ""));
            Usuarios.Add(new Usuario("Agostina", "5678", ""));
            Usuarios.Add(new Usuario("Vicente", "abcd", ""));
            Usuarios.Add(new Usuario("Cintya", "efgh", ""));
            Usuarios.Add(new Usuario("Augusto", "ijkl", ""));

            Modelos.Add(new Modelo("ABC123", "Fila Runner 2020", 1, 2, 3, 4));
            Modelos.Add(new Modelo("DEF567", "Nike Pegasus 2022", 1, 2, 3, 4));

            Colores.Add(new Color("MARINO", "Azul Marino"));

            Turnos.Add(new Turno(1,new NodaTime.LocalTime(6,0), new NodaTime.LocalTime(14, 0)));
            Turnos.Add(new Turno(2, new NodaTime.LocalTime(14, 0), new NodaTime.LocalTime(22, 0)));
            Turnos.Add(new Turno(3, new NodaTime.LocalTime(22, 0), new NodaTime.LocalTime(6, 0)));

            Lineas.Add(new Linea(1));
            Lineas.Add(new Linea(2));
            Lineas.Add(new Linea(3));
            Lineas.Add(new Linea(4));
            Lineas.Add(new Linea(5));
        }

        public List<Linea> BuscarLinea(int linea)
        {
            bool libre = false;
            foreach (OrdenProduccion op in OrdenesDeProduccion)
            {
                if (op.Linea.Numero == linea)
                {
                    libre = true;
                }
            }
            return null;
        }

        public Turno BuscarTurno(LocalTime hora)
        {
            foreach(Turno turno in Turnos)
            {
                if(turno.HoraDeFin < hora && turno.HoraDeInicio > hora)
                    return turno;
            }
            return null;
        }

        public Usuario BuscarUsuario(Usuario usuario)
        {
            return Usuarios.FirstOrDefault(usuario);
        }



    }
}
