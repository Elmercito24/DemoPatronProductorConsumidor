using System.Windows.Forms.Design;

namespace DemoPatronProductorConsumidor
{
    public class Consumidor
    {
        private Cola<Usuario> _cola;
        public Consumidor (Cola<Usuario>cola)
        {
            _cola = cola;
        }
        public Usuario Consumir()
        {
            Usuario usuario =_cola.Extraer();//Me da a devolver un usuario
            Thread.Sleep(5000);
            return usuario;//Que retorne el usuario que sacamos de la cola.
        }
    }
}
