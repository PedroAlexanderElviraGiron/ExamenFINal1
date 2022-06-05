using ProyectoFinal.Clases.entidades;
using ProyectoFinal.Clases.Servicio;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        ServicioVideojuego srvVideojuego = new();
        MdJuegos oJuegos = new();
        public Form1()
        {
            InitializeComponent();
        }
        private void DesplegarGrid()
        {
            var respuesta = srvVideojuego.ConsultaSQL("select * from tbgames");
            dataGridView1.DataSource = respuesta;
        }

        private void buttonObtenerDatos_Click(object sender, EventArgs e)
        {
            DesplegarGrid();
        }
        private void MapaoDatosFormulario(MdJuegos _games)
        {
            textBoxNumeroSerie.Text = _games.Numero_Serie;
            textBoxNombre.Text = _games.Nombre;
            textBoxFecha.Text = _games.Fecha_Estreno;
            textBoxPrecio.Text = _games.Precio;
            textBoxPlataformas.Text = _games.Plataformas;
            textBoxEdad.Text = _games.Edad;
        }
        private void LimpiarDatos()
        {
            oJuegos = new();
            MapaoDatosFormulario(oJuegos);
        }
        private void buscaAlumno(string Numero_Serie)
        {
            oJuegos = null;
            oJuegos = srvVideojuego.ObtenerJuegos(Numero_Serie);
            if (oJuegos == null)
            {
                MessageBox.Show("no existe este alumno");
                LimpiarDatos();
            }
            else
            {
                MapaoDatosFormulario(oJuegos);
            }
        }

        private void buttoncnsulta_Click(object sender, EventArgs e)
        {
            string Numero_Serie = textBoxNumeroSerie.Text;
            buscaAlumno(Numero_Serie);
        }
        private MdJuegos DatosFormulario()
        {
            MdJuegos games = new();
            games.Numero_Serie = textBoxNumeroSerie.Text.Trim();
            games.Nombre = textBoxNombre.Text.Trim();
            games.Fecha_Estreno = textBoxFecha.Text.Trim();
            games.Precio = textBoxPrecio.Text.Trim();
            games.Plataformas = textBoxPlataformas.Text.Trim();
            games.Edad = textBoxEdad.Text.Trim();
            return games;

        }

        private void buttonagregar_Click(object sender, EventArgs e)
        {
            oJuegos = DatosFormulario();
            if (textBoxNombre.Text == "")
            {
                MessageBox.Show("Lo siento la casilla nombre no debe quedar vacia o en blanco");
                LimpiarDatos();
            }
            else
            {
                int respuesta = srvVideojuego.CrearJuego(oJuegos);

                if (respuesta > 0)
                {
                    MessageBox.Show("Se creo con exito el Juego");
                    LimpiarDatos();
                    DesplegarGrid();
                }
                else
                {
                    MessageBox.Show("Perdon hay un problema con la Grabacion o el NUMERO DE SERIE DUPLICADO está duplicado");
                }
            }
        }

        private void buttonactualizar_Click(object sender, EventArgs e)
        {
            oJuegos = DatosFormulario();
            if (textBoxNombre.Text == "")
            {
                MessageBox.Show("Lo siento la casilla nombre no debe quedar vacia o en blanco");
                LimpiarDatos();
            }
            else
            {
                int respuesta = srvVideojuego.actualizarJuego(oJuegos);

                if (respuesta > 0)
                {
                    MessageBox.Show("Se qctualizo la inforrmacion del juego");
                    LimpiarDatos();
                    DesplegarGrid();
                }
                else
                {
                    MessageBox.Show("Perdon hay un problema con la Grabacion");
                }
            }
        }

        private void buttonimportat_Click(object sender, EventArgs e)
        {
            string archivo = @"C:\Users\alumno\Desktop\examen\Videojuegos.txt";
            ClsImportExport im = new();
            MessageBox.Show(im.importar(archivo));
        }

        private void buttoneexportar_Click(object sender, EventArgs e)
        {
            string archivo = @"C:\Users\alumno\Desktop\examen\salidagames.csv";
            ClsImportExport im = new();
            MessageBox.Show(im.exportar("select * from tbgames", archivo));
        }

        private void buttoneliminar_Click(object sender, EventArgs e)
        {
            oJuegos = DatosFormulario();
            DialogResult ev = MessageBox.Show("Seguro que desea eliminar el juego?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ev == DialogResult.Yes)
            {
                int respuesta = srvVideojuego.eliminarJuego(oJuegos);
                if (respuesta > 0)
                {
                    MessageBox.Show("Se elmino el juego");
                    LimpiarDatos();
                    DesplegarGrid();
                }
                else
                {
                    MessageBox.Show("Hay un problema al eliminar el juego");
                }
            }
            else if (ev == DialogResult.No)
            {
                DesplegarGrid();
            }
        }
    }
    }
