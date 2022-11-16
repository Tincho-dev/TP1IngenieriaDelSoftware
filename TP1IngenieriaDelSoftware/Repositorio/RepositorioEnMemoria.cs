using TP1IngenieriaDelSoftware.Models;

namespace TP1IngenieriaDelSoftware.Repositorio
{
    public class RepositorioEnMemoria : IRepositorio
    {

        private List<Usuario> Usuarios = new List<Usuario>();
        private List<OrdenDeProduccion> OrdenesDeProduccion = new List<OrdenDeProduccion>();
        private List<Color> Colores = new List<Color>();
        private List<Modelo> Modelos = new List<Modelo>();

        public RepositorioEnMemoria()
        {
        }

        public void SetData()
        {
            this.Usuarios.Add(new Usuario("Tincho","1234"));
            this.Usuarios.Add(new Usuario("Sergio", "5678"));
            this.Usuarios.Add(new Usuario("Felix", "abcd"));
            this.Usuarios.Add(new Usuario("Agustin", "efgh"));
            this.Usuarios.Add(new Usuario("Augusto", "ijkl"));

            this.Modelos.Add(new Modelo("ABC123","Fila Runner 2020",1,2,2,3));
            this.Modelos.Add(new Modelo("DEF567", "Nike Pegasus 2022",1,2,3,4));
        }

        public Usuario BuscarUsuario(Usuario usuario)
        {
            return this.Usuarios.FirstOrDefault(usuario);
        }

        public IEnumerable<Usuario> GetUsuarios()
        {
            return Usuarios.ToList();
        }

        public void AddUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario); 
        }

        private IEnumerable<OrdenDeProduccion> GetOrdenesDeProduccion()
        {
            return OrdenesDeProduccion.ToList();
        }

        IEnumerable<OrdenDeProduccion> IRepositorio.GetOrdenesDeProduccion()
        {
            return OrdenesDeProduccion.ToList();
        }

        public void AddOrdenesDeProduccion(OrdenDeProduccion op)
        {
            OrdenesDeProduccion.Add(op);
        }

        public IEnumerable<Color> GetColores()
        {
            return Colores.ToList();
        }

        public void AddColor(Color color)
        {
            Colores.Add(color);
        }

        public IEnumerable<Modelo> GetModelos()
        {
            return Modelos.ToList();
        }

        public void AddModelo(Modelo modelo)
        {
            Modelos.Add(modelo);
        }

        public Usuario SupervisorLibre()
        {
            throw new NotImplementedException();
        }

        public void Validar(string contraseña)
        {
            throw new NotImplementedException();
        }
    }
}
