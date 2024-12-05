namespace DemoPatronProductorConsumidor
{
    public partial class Form1 : Form
    {
        //Variable para simular el identificador que sea de manera automatica.
        private int contadorId = 1;

        //Lo va a compartir el productor y consumidor.
        private Cola<Usuario> colaUsuarios;

        private Productor productor;

        //
        private Consumidor consumidor;
        public Form1()
        {
            InitializeComponent();
            //Vamo a definir la cola de usuarios
            colaUsuarios = new Cola<Usuario>(10);

            //Iniciar el productor y consumidor
            productor = new Productor(colaUsuarios);

            consumidor = new Consumidor(colaUsuarios);
        }
        //Boton registrar
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            //Primero debemos capturar los datos.
            Usuario nuevoUsuario = new Usuario
                (
                contadorId++,
                TxtNombres.Text,
                TxtCorreoElectronico.Text
                );

            ThreadPool.QueueUserWorkItem
               (
                 state =>
                 {
                     colaUsuarios.Agregar(nuevoUsuario);
                 }
               );
            TxtNombres.Clear();
            TxtCorreoElectronico.Clear();
        }
        //Boton procesar
        private void BtnProcesar_Click(object sender, EventArgs e)
        {
            Thread hiloConsumidor = new Thread(ProcesarUsuario);
                hiloConsumidor.Start();
        }

        //Metodo procesar
        private void ProcesarUsuario()
        {
            Usuario usuario = colaUsuarios.Extraer();
            AgregarUsuarioADataGrid(usuario);
        }
        //Metodo para agregar
        private void AgregarUsuarioADataGrid(Usuario usuario)
        {
            if (dgvUsuarios.InvokeRequired)
            {
                dgvUsuarios.Invoke(new Action(()=>
                {
                  dgvUsuarios.Rows.Add
                  (
                      //Agregamos los atributos que deseamos agregar
                   usuario.Id,
                   usuario.Nombre,
                   usuario.CorreoElectronico,
                   usuario.FechaCreacion
                   );
                } )
                );
            }
            else

            {

                dgvUsuarios.Rows.Add(
                         usuario.Id,
                         usuario, Nombre,
                         usuario.CorreoElectronico,
                         usuario.FechaCreacion
                         );
            }
        }
    }
}
