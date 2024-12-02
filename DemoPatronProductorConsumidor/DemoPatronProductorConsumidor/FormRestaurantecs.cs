using RestauranteProductorConsumidor;

namespace DemoPatronProductorConsumidor
{
    public partial class FormRestaurantecs : Form
    {
        private int contadorPlatos = 1; // Contador para asignar IDs únicos a los platos
        private ClsZonaDePlatos<ClsPlato> zonaDePlatos; // Zona de platos listos (buffer)
        private ClsCocinero cocinero; // Productor
        private ClsMesero mesero; // Consumidor
        public FormRestaurantecs()
        {
            InitializeComponent();

            // Inicializar la zona de platos con capacidad de 10
            zonaDePlatos = new ClsZonaDePlatos<ClsPlato>(10);

            // Inicializar cocinero y mesero
            cocinero = new ClsCocinero(zonaDePlatos);
            mesero = new ClsMesero(zonaDePlatos);
        }

        private void btnPreparar_Click(object sender, EventArgs e)
        {
            ClsPlato nuevoPlato = new ClsPlato(
                contadorPlatos++,
                TxtNombrePlato.Text
            );

            // Simular preparación en un hilo
            ThreadPool.QueueUserWorkItem(state =>
            {
                zonaDePlatos.Agregar(nuevoPlato);
            });

            TxtNombrePlato.Clear();
        }
        private void ServirPlato()
        {
            ClsPlato plato = zonaDePlatos.Extraer();
            AgregarPlatoAGrid(plato);
        }

        //
        private void AgregarPlatoAGrid(ClsPlato plato)
        {
            if (dgvPlatos.InvokeRequired)
            {
                dgvPlatos.Invoke(new Action(() =>
                {
                    dgvPlatos.Rows.Add(
                        plato.Id,
                        plato.Nombre,
                        plato.HoraPreparacion
                    );
                }));
            }
            else
            {
                dgvPlatos.Rows.Add(
                    plato.Id,
                    plato.Nombre,
                    plato.HoraPreparacion
                );
            }
        }
        //Boton de servir
        private void btnServir_Click_1(object sender, EventArgs e)
        {
            Thread hiloMesero = new Thread(ServirPlato);
            hiloMesero.Start();
        }

        //Boton para salir cuando ya no querramos agregar más datos
        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}

