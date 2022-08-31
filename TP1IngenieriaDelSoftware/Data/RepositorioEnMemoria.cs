using API_TFI.Model;

namespace TP1IngenieriaDelSoftware.Data
{
    public class RepositorioEnMemoria
    {

        public List<Usuario> Usuarios = new();
        public List<OrdenProduccion> OrdenesDeProduccion = new();
        public List<Color> Colores = new();
        public List<Modelo> Modelos = new();

        public RepositorioEnMemoria()
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
        }

        public Usuario BuscarUsuario(Usuario usuario)
        {
            return Usuarios.FirstOrDefault(usuario);
        }



    }
}
