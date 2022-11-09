using TP1IngenieriaDelSoftware.Model;

namespace TP1IngenieriaDelSoftware.Repositorio
{
    public interface IRepositorio
    {
        public IEnumerable<Usuario> GetUsuarios();
        public void AddUsuario(Usuario usuario);
        //public IEnumerable<Usuario> SetUsuarios();
        public IEnumerable<OrdenDeProduccion> GetOrdenesDeProduccion();
        public void AddOrdenesDeProduccion(OrdenDeProduccion op);
        //public IEnumerable<OrdenDeProduccion> SetOrdenesDeProduccion();
        public IEnumerable<Color> GetColores();
        public void AddColor(Color color);
        //public IEnumerable<Color> SetColores();
        public IEnumerable<Modelo> GetModelos();
        public void AddModelo(Modelo modelo);
        //public IEnumerable<Modelo> SetModelos();


        public Usuario BuscarUsuario(Usuario usuario);

        public Usuario SupervisorLibre();

        public void Validar(string contraseña);//verificacion de usuario


    }
}
