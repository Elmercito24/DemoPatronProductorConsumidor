namespace DemoPatronProductorConsumidor
{

    //Metodo donde hacemos inyeccion de dependencias es en el constructor (Ctor)
    public class Productor
    {
        private Cola<Usuario> _cola;

        //Constructor
        public Productor(Cola<Usuario> cola)
        {
            _cola = cola;
        }

        
       //Metodo para producir la produccion
        public void Producir (Usuario item)
        {
            _cola.Agregar (item);
            Thread.Sleep (2000);//Para que duerma 2 segundos
        }
    }
}
