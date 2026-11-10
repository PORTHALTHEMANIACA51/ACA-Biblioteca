using AcaBibliteca;
using AcaBibliteca.Datos;
using Microsoft.VisualBasic;
using System.Linq.Expressions;

namespace WinFormsApp1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            //Conexion conexion = new Conexion();

            //try
            //{
               // using (var conn = conexion.ObtenerConexion())
               // {
                 // La conexión se ha establecido correctamente
                //  MessageBox.Show("Conexion a la base de datos establecida correctamente.",
                  //"AcaBiblioteca",
                  // MessageBoxButtons.OK,
                  // MessageBoxIcon.Information);
              //  }
           // }
            //catch (Exception ex)
           // {
                //  MessageBox.Show("Error al conectar a la base de datos: " + ex.Message,
                 // "AcaBiblioteca",
                //  MessageBoxButtons.OK,
                //  MessageBoxIcon.Error);
          //  }


            AbrirFormulario(new FrmInicio());
        }

        private void AbrirFormulario(Form formulario)
        {
            PnlContenido.Controls.Clear();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            PnlContenido.Controls.Add(formulario);
            formulario.Show();

        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmInicio());
        }

        private void PnlContenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnLibros_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmLibros());
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmUsuarios());
        }

        private void BtnAutores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmAutores());
        }

        private void BtnEditoriales_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmEditoriales());
        }

        private void BtnPrestamos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmPrestamos());
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmReportes());
        }

        private void BtnSalida_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
