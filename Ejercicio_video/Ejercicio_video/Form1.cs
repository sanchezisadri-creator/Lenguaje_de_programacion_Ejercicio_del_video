using Ejercicio_video.controladores;
using Ejercicio_video.entidades;

namespace Ejercicio_video
{
    public partial class Form1 : Form
    {
        private Alumno_controladores_ alumnoControladores = new Alumno_controladores_();
        public Form1()
        {
            InitializeComponent();
        }
        // mostrar 
        private void MostrarAlumnos(Alumno[] alumnos)
        {
            dgAlumnos.DataSource = null;
            dgAlumnos.DataSource = alumnos;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // validar campos de entradas
            if (tbCodigo.Text == "" || tbNombre.Text == "" || tbPromedio.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            // Crear un nuevo alumno
            Alumno alumno = new Alumno
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text,
                Promedio = double.Parse(tbPromedio.Text)
            };
            // Registrar el alumno
            alumnoControladores.Resgistrar(alumno);

            // Mostrar la lista actualizada de alumnos
            MostrarAlumnos(alumnoControladores.ListarTodo());

            LimpiarCampos();

        }

        public void LimpiarCampos()
        {
            tbCodigo.Clear();
            tbNombre.Clear();
            tbPromedio.Clear();
            tbBuscar.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgAlumnos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un alumno para eliminar.");
                return;
            }
            // Obtener el código del alumno seleccionado
            String codigo = dgAlumnos.SelectedRows[0].Cells["Codigo"].Value.ToString();
            // Eliminar fila seleccionada
            alumnoControladores.EliminarAlumno(codigo);

            // Mostrar la lista actualizada de alumnos
            MostrarAlumnos(alumnoControladores.ListarTodo());


        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            MostrarAlumnos(alumnoControladores.Ordenar());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Validar campo de búsqueda
            if (tbBuscar.Text == "")
            {
                MessageBox.Show("Por favor, ingrese un código para buscar.");
                return;
            }
            string codigo = tbBuscar.Text;

            // mostrar los alumnos de la busqueda
            MostrarAlumnos(alumnoControladores.BuscarPorCodigo(codigo));



        }
    }
}
