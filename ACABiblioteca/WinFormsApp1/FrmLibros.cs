using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using AcaBibliteca.Datos;
using System.Windows.Media.Effects;

namespace AcaBibliteca
{
    public partial class FrmLibros : Form
    {
        // Declaras tu variable correctamente dentro de la clase
        private bool modoEdicion = false;


        public FrmLibros()
        {
            InitializeComponent();
            CargarLibros();
            CargarAutores();
            CargarEditoriales();
        }

        private void CargarLibros()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT * FROM Libros";

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        dgvLibros.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los libros:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarAutores()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT IdAutor, Nombre, Apellido FROM Autores ORDER BY Nombre, Apellido";

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        tabla.Columns.Add("NombreCompleto", typeof(string));

                        foreach (DataRow fila in tabla.Rows)
                        {
                            fila["NombreCompleto"] = fila["Nombre"].ToString() + "" + fila["Apellido"].ToString();
                        }
                        CmbAutores.DataSource = tabla;
                        CmbAutores.DisplayMember = "NombreCompleto";
                        CmbAutores.ValueMember = "IdAutor";

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los autores:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarEditoriales()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT * FROM Editoriales";

                    using (SqlDataAdapter adaptador =
                           new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        CmbEditoriales.DataSource = tabla;
                        CmbEditoriales.DisplayMember = "Nombre";

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar las editoriales:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtBuscarISBN.Text))
                {
                    MessageBox.Show(
                        "Por favor, Ingrese un ISBN para buscar.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();
                    string consulta = "SELECT * FROM Libros WHERE ISBN = @ISBN";
                    using (SqlCommand cmd = new SqlCommand(consulta, cn))
                    {
                        cmd.Parameters.AddWithValue("@ISBN", TxtBuscarISBN.Text);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                TxtISBN1.Text = reader["ISBN"].ToString();
                                TxtTitulo.Text = reader["Titulo"].ToString();
                                TxtCategoria.Text = reader["categoria"].ToString();
                                TxtAño.Text = reader["Anio"].ToString();
                                TxtExistencia.Text = reader["Existencias"].ToString();
                                modoEdicion = true;

                                MessageBox.Show(
                                    "Libro encontrado y cargado en los campos de texto.",
                                    "Biblioteca",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                            }
                            else
                            {
                                MessageBox.Show(
                                    "No se encontro ningun libro con el ISBN proporcionado.",
                                    "Bibioteca",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar el libro:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtISBN1.Clear();
            TxtTitulo.Clear();
            CmbAutores.SelectedIndex = -1;
            CmbEditoriales.SelectedIndex = -1;
            TxtCategoria.Clear();
            TxtAño.Clear();
            TxtExistencia.Clear();
            TxtISBN1.Focus();

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
           try
            {
                if (string.IsNullOrWhiteSpace(TxtBuscarISBN.Text) ||
                    string.IsNullOrWhiteSpace(TxtTitulo.Text) ||
                    CmbAutores.SelectedIndex == -1 ||
                    CmbEditoriales.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(TxtCategoria.Text) ||
                    string.IsNullOrWhiteSpace(TxtAño.Text) ||
                    string.IsNullOrWhiteSpace(TxtExistencia.Text))
                {
                    MessageBox.Show(
                        "Por fevor, complete todos los campos antes de guardar.",
                         "Biblioteca",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Warning);
                    return;
                    
                }

                int anio;
                int existencias;

                if (!int.TryParse(TxtAño.Text, out anio))
                {
                    MessageBox.Show(
                        "El año debe ser un número entero.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (!int.TryParse(TxtExistencia.Text, out existencias))
                {
                    MessageBox.Show(
                        "Las existencias deben ser un número entero.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = @"INSERT INTO Libros
                                (ISBN, Titulo, IdAutor, IdEditorial, Categoria, Anio, Existencias)
                                VALUES
                                (@ISBN, @Titulo, @IdAutor, @IdEditorial, @Categoria, @Anio, @Existencias)";

                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue("@ISBN", TxtISBN1.Text.Trim());
                        comando.Parameters.AddWithValue("@Titulo", TxtTitulo.Text.Trim());
                        comando.Parameters.AddWithValue("@IdAutor", Convert.ToInt32(CmbAutores.SelectedValue));
                        comando.Parameters.AddWithValue("@IdEditorial", Convert.ToInt32(CmbEditoriales.SelectedValue));
                        comando.Parameters.AddWithValue("@Categoria", TxtCategoria.Text.Trim());
                        comando.Parameters.AddWithValue("@Anio", anio);
                        comando.Parameters.AddWithValue("@Existencias", existencias);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Libro guardado correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarLibros();

                BtnNuevo_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar el libro:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvLibros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            TxtISBN1.Text = dgvLibros.Rows[e.RowIndex].Cells["ISBN"].Value.ToString();
            TxtTitulo.Text = dgvLibros.Rows[e.RowIndex].Cells["Titulo"].Value.ToString();

            CmbAutores.SelectedValue = Convert.ToInt32(
                dgvLibros.Rows[e.RowIndex].Cells["IdAutor"].Value
            );

            CmbEditoriales.SelectedValue = Convert.ToInt32(
                dgvLibros.Rows[e.RowIndex].Cells["IdEditorial"].Value
            );

            TxtCategoria.Text = dgvLibros.Rows[e.RowIndex].Cells["Categoria"].Value.ToString();
            TxtAño.Text = dgvLibros.Rows[e.RowIndex].Cells["Anio"].Value.ToString();
            TxtExistencia.Text = dgvLibros.Rows[e.RowIndex].Cells["Existencias"].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtISBN1.Text) ||
                    string.IsNullOrWhiteSpace(TxtTitulo.Text) ||
                    CmbAutores.SelectedIndex == -1 ||
                    CmbEditoriales.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(TxtCategoria.Text) ||
                    string.IsNullOrWhiteSpace(TxtAño.Text) ||
                    string.IsNullOrWhiteSpace(TxtExistencia.Text))
                {
                    MessageBox.Show(
                        "Complete todos los campos antes de editar.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                int anio;
                int existencias;

                if (!int.TryParse(TxtAño.Text, out anio))
                {
                    MessageBox.Show(
                        "El año debe ser un número entero.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (!int.TryParse(TxtExistencia.Text, out existencias))
                {
                    MessageBox.Show(
                        "Las existencias deben ser un número entero.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = @"UPDATE Libros
                                SET Titulo = @Titulo,
                                    IdAutor = @IdAutor,
                                    IdEditorial = @IdEditorial,
                                    Categoria = @Categoria,
                                    Anio = @Anio,
                                    Existencias = @Existencias
                                WHERE ISBN = @ISBN";

                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue("@ISBN", TxtISBN1.Text.Trim());
                        comando.Parameters.AddWithValue("@Titulo", TxtTitulo.Text.Trim());
                        comando.Parameters.AddWithValue("@IdAutor", Convert.ToInt32(CmbAutores.SelectedValue));
                        comando.Parameters.AddWithValue("@IdEditorial", Convert.ToInt32(CmbEditoriales.SelectedValue));
                        comando.Parameters.AddWithValue("@Categoria", TxtCategoria.Text.Trim());
                        comando.Parameters.AddWithValue("@Anio", anio);
                        comando.Parameters.AddWithValue("@Existencias", existencias);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Libro actualizado correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarLibros();
                btnCancelar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al actualizar el libro:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            TxtISBN1.Clear();
            TxtTitulo.Clear();
            TxtCategoria.Clear();
            TxtAño.Clear();
            TxtExistencia.Clear();

            CmbAutores.SelectedIndex = -1;
            CmbEditoriales.SelectedIndex = -1;

            modoEdicion = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLibros.CurrentRow == null)
                {
                    MessageBox.Show(
                        "Seleccione un libro para eliminar.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                string isbn = dgvLibros.CurrentRow.Cells["ISBN"].Value.ToString();

                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de eliminar este libro?",
                    "Biblioteca",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.No)
                {
                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "DELETE FROM Libros WHERE ISBN = @ISBN";

                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue("@ISBN", isbn);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Libro eliminado correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                modoEdicion = false;
                TxtISBN1.Enabled = true;

                CargarLibros();

                BtnNuevo_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar el libro:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
            
