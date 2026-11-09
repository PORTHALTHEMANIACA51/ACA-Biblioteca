namespace AcaBibliteca
{
    partial class FrmLibros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PnlTitulo = new Panel();
            LblTitulo = new Label();
            Pnlbusqueda = new Panel();
            BtnBuscar = new Button();
            TxtBuscarISBN = new TextBox();
            LblBuscar = new Label();
            PnlDatos = new Panel();
            CmbEditoriales = new ComboBox();
            CmbAutores = new ComboBox();
            TxtExistencia = new TextBox();
            TxtAño = new TextBox();
            TxtCategoria = new TextBox();
            TxtTitulo = new TextBox();
            TxtISBN1 = new TextBox();
            LblExistencia = new Label();
            LblAño = new Label();
            LblCategoria = new Label();
            LblEditorial = new Label();
            LblAutor = new Label();
            LblLibros = new Label();
            LblIsbn = new Label();
            PnlBotones = new Panel();
            BtnCancelar = new FontAwesome.Sharp.IconButton();
            BtnEliminar = new FontAwesome.Sharp.IconButton();
            BtnEditar = new FontAwesome.Sharp.IconButton();
            BtnGuardar = new FontAwesome.Sharp.IconButton();
            BtnNuevo = new FontAwesome.Sharp.IconButton();
            dgvLibros = new DataGridView();
            PnlTitulo.SuspendLayout();
            Pnlbusqueda.SuspendLayout();
            PnlDatos.SuspendLayout();
            PnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // PnlTitulo
            // 
            PnlTitulo.BackColor = SystemColors.ActiveCaption;
            PnlTitulo.Controls.Add(LblTitulo);
            PnlTitulo.Dock = DockStyle.Top;
            PnlTitulo.Location = new Point(0, 0);
            PnlTitulo.Name = "PnlTitulo";
            PnlTitulo.Size = new Size(1371, 80);
            PnlTitulo.TabIndex = 0;
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.BackColor = Color.Transparent;
            LblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitulo.ForeColor = Color.White;
            LblTitulo.Location = new Point(577, 9);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(334, 45);
            LblTitulo.TabIndex = 1;
            LblTitulo.Text = "GESTIÓN DE LIBROS ";
            // 
            // Pnlbusqueda
            // 
            Pnlbusqueda.BackColor = Color.Gainsboro;
            Pnlbusqueda.Controls.Add(BtnBuscar);
            Pnlbusqueda.Controls.Add(TxtBuscarISBN);
            Pnlbusqueda.Controls.Add(LblBuscar);
            Pnlbusqueda.Dock = DockStyle.Top;
            Pnlbusqueda.Location = new Point(0, 80);
            Pnlbusqueda.Name = "Pnlbusqueda";
            Pnlbusqueda.Size = new Size(1371, 60);
            Pnlbusqueda.TabIndex = 1;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(895, 20);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(75, 23);
            BtnBuscar.TabIndex = 2;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click_1;
            // 
            // TxtBuscarISBN
            // 
            TxtBuscarISBN.Location = new Point(662, 17);
            TxtBuscarISBN.Name = "TxtBuscarISBN";
            TxtBuscarISBN.Size = new Size(188, 23);
            TxtBuscarISBN.TabIndex = 1;
            // 
            // LblBuscar
            // 
            LblBuscar.AutoSize = true;
            LblBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblBuscar.ForeColor = Color.Black;
            LblBuscar.Location = new Point(577, 20);
            LblBuscar.Name = "LblBuscar";
            LblBuscar.Size = new Size(35, 15);
            LblBuscar.TabIndex = 0;
            LblBuscar.Text = "ISBN";
            // 
            // PnlDatos
            // 
            PnlDatos.BackColor = SystemColors.ActiveCaption;
            PnlDatos.Controls.Add(CmbEditoriales);
            PnlDatos.Controls.Add(CmbAutores);
            PnlDatos.Controls.Add(TxtExistencia);
            PnlDatos.Controls.Add(TxtAño);
            PnlDatos.Controls.Add(TxtCategoria);
            PnlDatos.Controls.Add(TxtTitulo);
            PnlDatos.Controls.Add(TxtISBN1);
            PnlDatos.Controls.Add(LblExistencia);
            PnlDatos.Controls.Add(LblAño);
            PnlDatos.Controls.Add(LblCategoria);
            PnlDatos.Controls.Add(LblEditorial);
            PnlDatos.Controls.Add(LblAutor);
            PnlDatos.Controls.Add(LblLibros);
            PnlDatos.Controls.Add(LblIsbn);
            PnlDatos.Dock = DockStyle.Top;
            PnlDatos.Location = new Point(0, 140);
            PnlDatos.Name = "PnlDatos";
            PnlDatos.Size = new Size(1371, 280);
            PnlDatos.TabIndex = 2;
            // 
            // CmbEditoriales
            // 
            CmbEditoriales.FormattingEnabled = true;
            CmbEditoriales.Location = new Point(662, 134);
            CmbEditoriales.Name = "CmbEditoriales";
            CmbEditoriales.Size = new Size(188, 23);
            CmbEditoriales.TabIndex = 13;
            // 
            // CmbAutores
            // 
            CmbAutores.FormattingEnabled = true;
            CmbAutores.Location = new Point(662, 97);
            CmbAutores.Name = "CmbAutores";
            CmbAutores.Size = new Size(188, 23);
            CmbAutores.TabIndex = 12;
            // 
            // TxtExistencia
            // 
            TxtExistencia.Location = new Point(662, 240);
            TxtExistencia.Name = "TxtExistencia";
            TxtExistencia.Size = new Size(188, 23);
            TxtExistencia.TabIndex = 11;
            // 
            // TxtAño
            // 
            TxtAño.Location = new Point(662, 206);
            TxtAño.Name = "TxtAño";
            TxtAño.Size = new Size(188, 23);
            TxtAño.TabIndex = 10;
            // 
            // TxtCategoria
            // 
            TxtCategoria.Location = new Point(662, 169);
            TxtCategoria.Name = "TxtCategoria";
            TxtCategoria.Size = new Size(188, 23);
            TxtCategoria.TabIndex = 9;
            // 
            // TxtTitulo
            // 
            TxtTitulo.Location = new Point(662, 58);
            TxtTitulo.Name = "TxtTitulo";
            TxtTitulo.Size = new Size(188, 23);
            TxtTitulo.TabIndex = 7;
            // 
            // TxtISBN1
            // 
            TxtISBN1.Location = new Point(662, 15);
            TxtISBN1.Name = "TxtISBN1";
            TxtISBN1.Size = new Size(188, 23);
            TxtISBN1.TabIndex = 3;
            // 
            // LblExistencia
            // 
            LblExistencia.AutoSize = true;
            LblExistencia.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblExistencia.Location = new Point(577, 243);
            LblExistencia.Name = "LblExistencia";
            LblExistencia.Size = new Size(70, 15);
            LblExistencia.TabIndex = 6;
            LblExistencia.Text = "Existencias:";
            // 
            // LblAño
            // 
            LblAño.AutoSize = true;
            LblAño.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblAño.Location = new Point(577, 206);
            LblAño.Name = "LblAño";
            LblAño.Size = new Size(32, 15);
            LblAño.TabIndex = 5;
            LblAño.Text = "Año:";
            // 
            // LblCategoria
            // 
            LblCategoria.AutoSize = true;
            LblCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCategoria.Location = new Point(574, 172);
            LblCategoria.Name = "LblCategoria";
            LblCategoria.Size = new Size(63, 15);
            LblCategoria.TabIndex = 4;
            LblCategoria.Text = "Categoria:";
            // 
            // LblEditorial
            // 
            LblEditorial.AutoSize = true;
            LblEditorial.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblEditorial.Location = new Point(574, 134);
            LblEditorial.Name = "LblEditorial";
            LblEditorial.Size = new Size(55, 15);
            LblEditorial.TabIndex = 3;
            LblEditorial.Text = "Editorial:";
            // 
            // LblAutor
            // 
            LblAutor.AutoSize = true;
            LblAutor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblAutor.Location = new Point(574, 105);
            LblAutor.Name = "LblAutor";
            LblAutor.Size = new Size(42, 15);
            LblAutor.TabIndex = 2;
            LblAutor.Text = "Autor:";
            // 
            // LblLibros
            // 
            LblLibros.AutoSize = true;
            LblLibros.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblLibros.Location = new Point(574, 66);
            LblLibros.Name = "LblLibros";
            LblLibros.Size = new Size(42, 15);
            LblLibros.TabIndex = 1;
            LblLibros.Text = "Titulo:";
            // 
            // LblIsbn
            // 
            LblIsbn.AutoSize = true;
            LblIsbn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblIsbn.Location = new Point(574, 18);
            LblIsbn.Name = "LblIsbn";
            LblIsbn.Size = new Size(38, 15);
            LblIsbn.TabIndex = 0;
            LblIsbn.Text = "ISBN:";
            // 
            // PnlBotones
            // 
            PnlBotones.Controls.Add(BtnCancelar);
            PnlBotones.Controls.Add(BtnEliminar);
            PnlBotones.Controls.Add(BtnEditar);
            PnlBotones.Controls.Add(BtnGuardar);
            PnlBotones.Controls.Add(BtnNuevo);
            PnlBotones.Location = new Point(0, 421);
            PnlBotones.Name = "PnlBotones";
            PnlBotones.Size = new Size(1350, 56);
            PnlBotones.TabIndex = 3;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            BtnCancelar.IconColor = Color.Black;
            BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            BtnCancelar.IconSize = 25;
            BtnCancelar.Location = new Point(969, 14);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(100, 30);
            BtnCancelar.TabIndex = 4;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            BtnEliminar.IconColor = Color.Black;
            BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            BtnEliminar.IconSize = 25;
            BtnEliminar.Location = new Point(845, 14);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(100, 30);
            BtnEliminar.TabIndex = 3;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            BtnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            BtnEditar.IconColor = Color.Black;
            BtnEditar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            BtnEditar.IconSize = 25;
            BtnEditar.Location = new Point(718, 14);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(100, 30);
            BtnEditar.TabIndex = 2;
            BtnEditar.Text = "Editar";
            BtnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            BtnGuardar.IconColor = Color.Black;
            BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            BtnGuardar.IconSize = 25;
            BtnGuardar.Location = new Point(585, 14);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(100, 30);
            BtnGuardar.TabIndex = 1;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnNuevo
            // 
            BtnNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnNuevo.IconChar = FontAwesome.Sharp.IconChar.Mosquito;
            BtnNuevo.IconColor = Color.Black;
            BtnNuevo.IconFont = FontAwesome.Sharp.IconFont.Regular;
            BtnNuevo.IconSize = 25;
            BtnNuevo.Location = new Point(461, 14);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(100, 30);
            BtnNuevo.TabIndex = 0;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnNuevo.UseVisualStyleBackColor = true;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // dgvLibros
            // 
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(247, 475);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.Size = new Size(1100, 260);
            dgvLibros.TabIndex = 4;
            // 
            // FrmLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 747);
            Controls.Add(dgvLibros);
            Controls.Add(PnlBotones);
            Controls.Add(PnlDatos);
            Controls.Add(Pnlbusqueda);
            Controls.Add(PnlTitulo);
            Name = "FrmLibros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLibros";
            PnlTitulo.ResumeLayout(false);
            PnlTitulo.PerformLayout();
            Pnlbusqueda.ResumeLayout(false);
            Pnlbusqueda.PerformLayout();
            PnlDatos.ResumeLayout(false);
            PnlDatos.PerformLayout();
            PnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlTitulo;
        private Label LblTitulo;
        private Panel Pnlbusqueda;
        private Label LblBuscar;
        private Panel PnlDatos;
        private Button BtnBuscar;
        private TextBox TxtBuscarISBN;
        private Label LblIsbn;
        private Label LblCategoria;
        private Label LblEditorial;
        private Label LblAutor;
        private Label LblLibros;
        private TextBox TxtTitulo;
        private TextBox TxtISBN1;
        private Label LblExistencia;
        private Label LblAño;
        private TextBox TxtExistencia;
        private TextBox TxtAño;
        private TextBox TxtCategoria;
        private ComboBox CmbEditoriales;
        private ComboBox CmbAutores;
        private Panel PnlBotones;
        private FontAwesome.Sharp.IconButton BtnNuevo;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnEditar;
        private DataGridView dgvLibros;
    }
}