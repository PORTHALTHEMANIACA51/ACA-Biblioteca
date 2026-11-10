namespace AcaBibliteca
{
    partial class FrmUsuarios
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
            pnlTitulo = new Panel();
            lblTitulo = new Label();
            pnlContenido = new Panel();
            BtnCancelar = new FontAwesome.Sharp.IconButton();
            BtnEliminar = new FontAwesome.Sharp.IconButton();
            BtnEditar = new FontAwesome.Sharp.IconButton();
            BtnGuardar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            lblCorreo = new Label();
            lblTelefono = new Label();
            lblDocumento = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            txtCorreo = new TextBox();
            txtDocumento = new TextBox();
            txtTelefono = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            dgvUsuarios = new DataGridView();
            pnlTitulo.SuspendLayout();
            pnlContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = SystemColors.ActiveCaption;
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1371, 72);
            pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(547, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(374, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTIÓN DE USUARIOS";
            // 
            // pnlContenido
            // 
            pnlContenido.Controls.Add(BtnCancelar);
            pnlContenido.Controls.Add(BtnEliminar);
            pnlContenido.Controls.Add(BtnEditar);
            pnlContenido.Controls.Add(BtnGuardar);
            pnlContenido.Controls.Add(btnNuevo);
            pnlContenido.Controls.Add(lblCorreo);
            pnlContenido.Controls.Add(lblTelefono);
            pnlContenido.Controls.Add(lblDocumento);
            pnlContenido.Controls.Add(lblApellido);
            pnlContenido.Controls.Add(lblNombre);
            pnlContenido.Controls.Add(txtCorreo);
            pnlContenido.Controls.Add(txtDocumento);
            pnlContenido.Controls.Add(txtTelefono);
            pnlContenido.Controls.Add(txtApellido);
            pnlContenido.Controls.Add(txtNombre);
            pnlContenido.Location = new Point(0, 75);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(1371, 298);
            pnlContenido.TabIndex = 1;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            BtnCancelar.IconColor = Color.Black;
            BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCancelar.IconSize = 25;
            BtnCancelar.Location = new Point(924, 245);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(100, 30);
            BtnCancelar.TabIndex = 14;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            BtnEliminar.IconColor = Color.Black;
            BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnEliminar.IconSize = 25;
            BtnEliminar.Location = new Point(800, 245);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(100, 30);
            BtnEliminar.TabIndex = 13;
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
            BtnEditar.Location = new Point(673, 245);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(100, 30);
            BtnEditar.TabIndex = 12;
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
            BtnGuardar.Location = new Point(540, 245);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(100, 30);
            BtnGuardar.TabIndex = 11;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevo.IconSize = 25;
            btnNuevo.Location = new Point(416, 245);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(100, 30);
            btnNuevo.TabIndex = 10;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(556, 199);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(46, 15);
            lblCorreo.TabIndex = 9;
            lblCorreo.Text = "Correo:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(556, 155);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(56, 15);
            lblTelefono.TabIndex = 8;
            lblTelefono.Text = "Telefono:";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(556, 112);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(73, 15);
            lblDocumento.TabIndex = 7;
            lblDocumento.Text = "Documento:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(556, 68);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 6;
            lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(556, 25);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(710, 196);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(156, 23);
            txtCorreo.TabIndex = 4;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(710, 109);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(156, 23);
            txtDocumento.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(710, 152);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(156, 23);
            txtTelefono.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(710, 65);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(156, 23);
            txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(710, 22);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(156, 23);
            txtNombre.TabIndex = 0;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(224, 397);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(1100, 260);
            dgvUsuarios.TabIndex = 2;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 729);
            Controls.Add(dgvUsuarios);
            Controls.Add(pnlContenido);
            Controls.Add(pnlTitulo);
            Name = "FrmUsuarios";
            Text = "FrmUsuarios";
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlContenido.ResumeLayout(false);
            pnlContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Panel pnlContenido;
        private DataGridView dgvUsuarios;
        private Label lblTitulo;
        private Label lblNombre;
        private TextBox txtCorreo;
        private TextBox txtDocumento;
        private TextBox txtTelefono;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label lblCorreo;
        private Label lblTelefono;
        private Label lblDocumento;
        private Label lblApellido;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnEditar;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private FontAwesome.Sharp.IconButton btnNuevo;
    }
}