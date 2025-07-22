using Dominio;
using System.Net.Http.Json;
using System.Threading.Tasks;
namespace ConsumiendoEscritorio
{
    public partial class CRUD_Alumno : Form
    {
        public CRUD_Alumno()
        {
            InitializeComponent();
        }

        private readonly HttpClient clienteHTTP = new HttpClient()
        {
            BaseAddress = new Uri("http://localhost:5158/")
        };

        private async Task ListarAlumnos()
        {

            IEnumerable<Alumno>? listaAlumnos = await clienteHTTP.GetFromJsonAsync<IEnumerable<Alumno>>("alumnos");
            tablaListaAlumnos.DataSource = listaAlumnos.ToList();


        }

        private async Task BuscarAlumo()
        {
            try
            {
                string legajo = txtLegajo.Text;
                Alumno? alu = await clienteHTTP.GetFromJsonAsync<Alumno>($"alumnos/{legajo}");
                List<Alumno> lista = new List<Alumno>();
                lista.Add(alu);
                tablaListaAlumnos.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(clienteHTTP.BaseAddress + "alumnos/{id}");
            }
        }

        private void LimpiarDatos()
        {
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtLegajo.Text = "";
            txtNombre.Text = "";
        }

        private async Task AgregarAlumno()
        {
            Alumno alu = new Alumno(
                Alumno.ObtenerProxId(),
                txtApellido.Text,
                txtNombre.Text,
                Convert.ToInt32(txtLegajo.Text),
                txtDireccion.Text
            );
            await clienteHTTP.PostAsJsonAsync("alumnos", alu);
            await ListarAlumnos();
            LimpiarDatos();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await ListarAlumnos();
            tablaListaAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablaListaAlumnos.MultiSelect = false;
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await BuscarAlumo();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            await AgregarAlumno();
        }

        private async void btnListar_Click(object sender, EventArgs e)
        {
            await ListarAlumnos();
        }

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }





        private void tablaListaAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = tablaListaAlumnos.CurrentRow;

            txtApellido.Text = filaSeleccionada.Cells[1].Value.ToString();
            txtNombre.Text = filaSeleccionada.Cells[2].Value.ToString();
            txtLegajo.Text = filaSeleccionada.Cells[3].Value.ToString();
            txtDireccion.Text = filaSeleccionada.Cells[4].Value.ToString();
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {

                int id = Convert.ToInt32(tablaListaAlumnos.CurrentRow.Cells[0].Value);
                int legajo = Convert.ToInt32(txtLegajo.Text);
                Alumno alu = new Alumno(
                    id,
                    txtApellido.Text,
                    txtNombre.Text,
                    legajo,
                    txtDireccion.Text
                    );
                await clienteHTTP.PutAsJsonAsync<Alumno>("alumnos", alu);
                await ListarAlumnos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tablaListaAlumnos.CurrentRow.Cells[0].Value);
            await clienteHTTP.DeleteAsync($"alumnos/{id}");
            await ListarAlumnos();
        }
    }
}
