using System.Collections.Generic;
using System.Threading;

namespace RestauranteProductorConsumidor
{
    public class ClsZonaDePlatos<T>
    {
        private int capacidadMaxima;
        private Queue<T> zona = new Queue<T>();
        private readonly object lockObject = new object();

        public ClsZonaDePlatos(int capacidad)
        {
            capacidadMaxima = capacidad;
        }

        public void Agregar(T item)
        {
            lock (lockObject)
            {
                while (zona.Count >= capacidadMaxima)
                {
                    Monitor.Wait(lockObject);
                }
                zona.Enqueue(item);
                Monitor.Pulse(lockObject);
            }
        }

        public T Extraer()
        {
            lock (lockObject)
            {
                while (zona.Count == 0)
                {
                    Monitor.Wait(lockObject);
                }
                T item = zona.Dequeue();
                Monitor.Pulse(lockObject);
                return item;
            }
        }
    }
}