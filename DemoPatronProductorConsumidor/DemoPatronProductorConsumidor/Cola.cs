namespace DemoPatronProductorConsumidor
{
    public class Cola<T>//Sirve para colocar un elemento generico.Cdada vez que veamos una T va ser generico.
    {
        private int CapacidadMaxima;
        private Queue<T> cola = new Queue<T>();
        private object lockObjeto = new object();

        public Cola(int capacidad)
        {
            CapacidadMaxima = capacidad;
        }
        public void Agregar(T item)
        {
            lock (lockObjeto)//Codigo para bloquear
            {
                while (cola.Count >= CapacidadMaxima)
                {
                    Monitor.Wait(lockObjeto);
                }
                cola.Enqueue(item);//Añade elemento a la cola.
                Monitor.Pulse(lockObjeto);
            } 
        }
        public T Extraer()
        {
            lock (lockObjeto)
            {
                //Debo extraer solo cuando ay elementos en la cola o sino debe esperar
                while(cola.Count==0)
                {
                    Monitor.Wait(lockObjeto);
                }
                //Este codigo sirve para extraer cualquier elemento

                T item = cola.Dequeue();//Va a extraer un elemento de la cola y lo va a retirar
                Monitor.Pulse(lockObjeto);
                return item;
            }
        }
    }
}