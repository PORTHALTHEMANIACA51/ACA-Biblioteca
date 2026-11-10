namespace AcaBibliteca
{
    partial class FrmAutores
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
            panel1 = new Panel();
            BtnCancelar = new FontAwesome.Sharp.IconButton();
            txtApellido = new TextBox();
            BtnEliminar = new FontAwesome.Sharp.IconButton();
            txtNombre = new TextBox();
            BtnEditar = new FontAwesome.Sharp.IconButton();
            lblApellido = new Label();
            BtnGuardar = new FontAwesome.Sharp.IconButton();
            lblNombre = new Label();
            BtnNuevo = new FontAwesome.Sharp.IconButton();
            dgvAutores = new DataGridView();
            pnlTitulo.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAutores).BeginInit();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = SystemColors.ActiveCaption;
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1371, 79);
            pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(619, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(358, 45);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "GESTIÓN DE AUTORES";
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnCancelar);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(BtnEliminar);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(BtnEditar);
            panel1.Controls.Add(lblApellido);
            panel1.Controls.Add(BtnGuardar);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(BtnNuevo);
            panel1.Location = new Point(0, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(1371, 217);
            panel1.TabIndex = 1;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            BtnCancelar.IconColor = Color.Black;
            BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCancelar.IconSize = 25;
            BtnCancelar.Location = new Point(992, 172);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(100, 30);
            BtnCancelar.TabIndex = 9;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(743, 117);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(250, 23);
            txtApellido.TabIndex = 3;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            BtnEliminar.IconColor = Color.Black;
            BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnEliminar.IconSize = 25;
            BtnEliminar.Location = new Point(868, 172);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(100, 30);
            BtnEliminar.TabIndex = 8;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(743, 66);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 23);
            txtNombre.TabIndex = 2;
            // 
            // BtnEditar
            // 
            BtnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            BtnEditar.IconColor = Color.Black;
            BtnEditar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            BtnEditar.IconSize = 25;
            BtnEditar.Location = new Point(741, 172);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(100, 30);
            BtnEditar.TabIndex = 7;
            BtnEditar.Text = "Editar";
            BtnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnEditar.UseVisualStyleBackColor = true;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(579, 117);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(102, 30);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido:";
            // 
            // BtnGuardar
            // 
            BtnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            BtnGuardar.IconColor = Color.Black;
            BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            BtnGuardar.IconSize = 25;
            BtnGuardar.Location = new Point(608, 172);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(100, 30);
            BtnGuardar.TabIndex = 6;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(579, 59);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(100, 30);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // BtnNuevo
            // 
            BtnNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnNuevo.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            BtnNuevo.IconColor = Color.Black;
            BtnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnNuevo.IconSize = 25;
            BtnNuevo.Location = new Point(484, 172);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(100, 30);
            BtnNuevo.TabIndex = 5;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvAutores
            // 
            dgvAutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAutores.Location = new Point(195, 340);
            dgvAutores.Name = "dgvAutores";
            dgvAutores.Size = new Size(1100, 260);
            dgvAutores.TabIndex = 2;
            // 
            // FrmAutores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 729);
            Controls.Add(dgvAutores);
            Controls.Add(panel1);
            Controls.Add(pnlTitulo);
            Name = "FrmAutores";
            Text = "FrmAutores";
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAutores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Panel panel1;
        private DataGridView dgvAutores;
        private Label lblTitulo;
        private Label lblApellido;
        private Label lblNombre;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnEditar;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private FontAwesome.Sharp.IconButton BtnNuevo;
    }
}