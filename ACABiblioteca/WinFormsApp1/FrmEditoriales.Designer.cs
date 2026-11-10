namespace AcaBibliteca
{
    partial class FrmEditoriales
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
            txtNombre = new TextBox();
            lblNombre = new Label();
            BtnCancelar = new FontAwesome.Sharp.IconButton();
            BtnEliminar = new FontAwesome.Sharp.IconButton();
            BtnEditar = new FontAwesome.Sharp.IconButton();
            BtnGuardar = new FontAwesome.Sharp.IconButton();
            BtnNuevo = new FontAwesome.Sharp.IconButton();
            dgvEditoriales = new DataGridView();
            pnlTitulo.SuspendLayout();
            pnlContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEditoriales).BeginInit();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = SystemColors.ActiveCaption;
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1371, 95);
            pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(466, 36);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(413, 45);
            lblTitulo.TabIndex = 10;
            lblTitulo.Text = "GESTIÓN DE EDITORIALES";
            // 
            // pnlContenido
            // 
            pnlContenido.Controls.Add(txtNombre);
            pnlContenido.Controls.Add(lblNombre);
            pnlContenido.Controls.Add(BtnCancelar);
            pnlContenido.Controls.Add(BtnEliminar);
            pnlContenido.Controls.Add(BtnEditar);
            pnlContenido.Controls.Add(BtnGuardar);
            pnlContenido.Controls.Add(BtnNuevo);
            pnlContenido.Location = new Point(0, 97);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(1371, 265);
            pnlContenido.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(608, 64);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(247, 23);
            txtNombre.TabIndex = 12;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(466, 57);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(100, 30);
            lblNombre.TabIndex = 11;
            lblNombre.Text = "Nombre:";
            // 
            // BtnCancelar
            // 
            BtnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            BtnCancelar.IconColor = Color.Black;
            BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCancelar.IconSize = 25;
            BtnCancelar.Location = new Point(869, 198);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(100, 30);
            BtnCancelar.TabIndex = 9;
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
            BtnEliminar.Location = new Point(745, 198);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(100, 30);
            BtnEliminar.TabIndex = 8;
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
            BtnEditar.Location = new Point(618, 198);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(100, 30);
            BtnEditar.TabIndex = 7;
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
            BtnGuardar.Location = new Point(485, 198);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(100, 30);
            BtnGuardar.TabIndex = 6;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // BtnNuevo
            // 
            BtnNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnNuevo.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            BtnNuevo.IconColor = Color.Black;
            BtnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnNuevo.IconSize = 25;
            BtnNuevo.Location = new Point(361, 198);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(100, 30);
            BtnNuevo.TabIndex = 5;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvEditoriales
            // 
            dgvEditoriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEditoriales.Location = new Point(141, 410);
            dgvEditoriales.Name = "dgvEditoriales";
            dgvEditoriales.Size = new Size(1100, 260);
            dgvEditoriales.TabIndex = 2;
            // 
            // FrmEditoriales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 729);
            Controls.Add(dgvEditoriales);
            Controls.Add(pnlContenido);
            Controls.Add(pnlTitulo);
            Name = "FrmEditoriales";
            Text = "FrmEditoriales";
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlContenido.ResumeLayout(false);
            pnlContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEditoriales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Panel pnlContenido;
        private DataGridView dgvEditoriales;
        private Label lblTitulo;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnEditar;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private FontAwesome.Sharp.IconButton BtnNuevo;
        private TextBox txtNombre;
        private Label lblNombre;
    }
}