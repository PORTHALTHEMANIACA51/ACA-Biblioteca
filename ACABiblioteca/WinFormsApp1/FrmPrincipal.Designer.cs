namespace WinFormsApp1
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            PnlMenu = new Panel();
            BtnSalida = new FontAwesome.Sharp.IconButton();
            BtnReportes = new FontAwesome.Sharp.IconButton();
            BtnPrestamos = new FontAwesome.Sharp.IconButton();
            BtnEditoriales = new FontAwesome.Sharp.IconButton();
            BtnAutores = new FontAwesome.Sharp.IconButton();
            BtnUsuarios = new FontAwesome.Sharp.IconButton();
            BtnLibros = new FontAwesome.Sharp.IconButton();
            BtnInicio = new FontAwesome.Sharp.IconButton();
            PnlLogo = new Panel();
            PicLogo = new PictureBox();
            LblSubtitulo = new Label();
            LblTitulo = new Label();
            PnlSuperior = new Panel();
            PnlEstado = new Panel();
            PnlContenido = new Panel();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            PnlMenu.SuspendLayout();
            PnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicLogo).BeginInit();
            SuspendLayout();
            // 
            // PnlMenu
            // 
            PnlMenu.BackColor = SystemColors.InactiveCaption;
            PnlMenu.Controls.Add(BtnSalida);
            PnlMenu.Controls.Add(BtnReportes);
            PnlMenu.Controls.Add(BtnPrestamos);
            PnlMenu.Controls.Add(BtnEditoriales);
            PnlMenu.Controls.Add(BtnAutores);
            PnlMenu.Controls.Add(BtnUsuarios);
            PnlMenu.Controls.Add(BtnLibros);
            PnlMenu.Controls.Add(BtnInicio);
            PnlMenu.Controls.Add(PnlLogo);
            PnlMenu.Dock = DockStyle.Left;
            PnlMenu.Location = new Point(0, 0);
            PnlMenu.Name = "PnlMenu";
            PnlMenu.Size = new Size(220, 450);
            PnlMenu.TabIndex = 0;
            // 
            // BtnSalida
            // 
            BtnSalida.Dock = DockStyle.Top;
            BtnSalida.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSalida.IconChar = FontAwesome.Sharp.IconChar.Close;
            BtnSalida.IconColor = Color.Black;
            BtnSalida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnSalida.IconSize = 25;
            BtnSalida.Location = new Point(0, 395);
            BtnSalida.Name = "BtnSalida";
            BtnSalida.Size = new Size(220, 45);
            BtnSalida.TabIndex = 8;
            BtnSalida.Text = "Salir";
            BtnSalida.TextAlign = ContentAlignment.MiddleLeft;
            BtnSalida.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnSalida.UseVisualStyleBackColor = true;
            BtnSalida.Click += BtnSalida_Click;
            // 
            // BtnReportes
            // 
            BtnReportes.Dock = DockStyle.Top;
            BtnReportes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnReportes.IconChar = FontAwesome.Sharp.IconChar.Comment;
            BtnReportes.IconColor = Color.Black;
            BtnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnReportes.IconSize = 25;
            BtnReportes.Location = new Point(0, 350);
            BtnReportes.Name = "BtnReportes";
            BtnReportes.Size = new Size(220, 45);
            BtnReportes.TabIndex = 7;
            BtnReportes.Text = "Reportes";
            BtnReportes.TextAlign = ContentAlignment.MiddleLeft;
            BtnReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnReportes.UseVisualStyleBackColor = true;
            BtnReportes.Click += BtnReportes_Click;
            // 
            // BtnPrestamos
            // 
            BtnPrestamos.Dock = DockStyle.Top;
            BtnPrestamos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPrestamos.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            BtnPrestamos.IconColor = Color.Black;
            BtnPrestamos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnPrestamos.IconSize = 25;
            BtnPrestamos.Location = new Point(0, 305);
            BtnPrestamos.Name = "BtnPrestamos";
            BtnPrestamos.Size = new Size(220, 45);
            BtnPrestamos.TabIndex = 6;
            BtnPrestamos.Text = "Prestamos";
            BtnPrestamos.TextAlign = ContentAlignment.MiddleLeft;
            BtnPrestamos.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnPrestamos.UseVisualStyleBackColor = true;
            BtnPrestamos.Click += BtnPrestamos_Click;
            // 
            // BtnEditoriales
            // 
            BtnEditoriales.Dock = DockStyle.Top;
            BtnEditoriales.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEditoriales.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            BtnEditoriales.IconColor = Color.Black;
            BtnEditoriales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnEditoriales.IconSize = 25;
            BtnEditoriales.Location = new Point(0, 260);
            BtnEditoriales.Name = "BtnEditoriales";
            BtnEditoriales.Size = new Size(220, 45);
            BtnEditoriales.TabIndex = 5;
            BtnEditoriales.Text = "Editoriales";
            BtnEditoriales.TextAlign = ContentAlignment.MiddleLeft;
            BtnEditoriales.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnEditoriales.UseVisualStyleBackColor = true;
            BtnEditoriales.Click += BtnEditoriales_Click;
            // 
            // BtnAutores
            // 
            BtnAutores.Dock = DockStyle.Top;
            BtnAutores.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAutores.IconChar = FontAwesome.Sharp.IconChar.BookReader;
            BtnAutores.IconColor = Color.Black;
            BtnAutores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAutores.IconSize = 25;
            BtnAutores.Location = new Point(0, 215);
            BtnAutores.Name = "BtnAutores";
            BtnAutores.Size = new Size(220, 45);
            BtnAutores.TabIndex = 4;
            BtnAutores.Text = "Autores";
            BtnAutores.TextAlign = ContentAlignment.MiddleLeft;
            BtnAutores.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnAutores.UseVisualStyleBackColor = true;
            BtnAutores.Click += BtnAutores_Click;
            // 
            // BtnUsuarios
            // 
            BtnUsuarios.Dock = DockStyle.Top;
            BtnUsuarios.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnUsuarios.IconChar = FontAwesome.Sharp.IconChar.PersonShelter;
            BtnUsuarios.IconColor = Color.Black;
            BtnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnUsuarios.IconSize = 25;
            BtnUsuarios.Location = new Point(0, 170);
            BtnUsuarios.Name = "BtnUsuarios";
            BtnUsuarios.Size = new Size(220, 45);
            BtnUsuarios.TabIndex = 3;
            BtnUsuarios.Text = "Usuarios";
            BtnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            BtnUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnUsuarios.UseVisualStyleBackColor = true;
            BtnUsuarios.Click += BtnUsuarios_Click;
            // 
            // BtnLibros
            // 
            BtnLibros.Dock = DockStyle.Top;
            BtnLibros.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLibros.IconChar = FontAwesome.Sharp.IconChar.Book;
            BtnLibros.IconColor = Color.Black;
            BtnLibros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnLibros.IconSize = 25;
            BtnLibros.Location = new Point(0, 125);
            BtnLibros.Name = "BtnLibros";
            BtnLibros.Size = new Size(220, 45);
            BtnLibros.TabIndex = 2;
            BtnLibros.Text = "Libros";
            BtnLibros.TextAlign = ContentAlignment.MiddleLeft;
            BtnLibros.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnLibros.UseVisualStyleBackColor = true;
            BtnLibros.Click += BtnLibros_Click;
            // 
            // BtnInicio
            // 
            BtnInicio.Dock = DockStyle.Top;
            BtnInicio.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnInicio.IconChar = FontAwesome.Sharp.IconChar.House;
            BtnInicio.IconColor = Color.Black;
            BtnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnInicio.IconSize = 25;
            BtnInicio.Location = new Point(0, 80);
            BtnInicio.Name = "BtnInicio";
            BtnInicio.Size = new Size(220, 45);
            BtnInicio.TabIndex = 1;
            BtnInicio.Text = "Inicio";
            BtnInicio.TextAlign = ContentAlignment.MiddleLeft;
            BtnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnInicio.UseVisualStyleBackColor = true;
            BtnInicio.Click += BtnInicio_Click;
            // 
            // PnlLogo
            // 
            PnlLogo.BackColor = Color.MidnightBlue;
            PnlLogo.Controls.Add(PicLogo);
            PnlLogo.Controls.Add(LblSubtitulo);
            PnlLogo.Controls.Add(LblTitulo);
            PnlLogo.Dock = DockStyle.Top;
            PnlLogo.Location = new Point(0, 0);
            PnlLogo.Name = "PnlLogo";
            PnlLogo.Size = new Size(220, 80);
            PnlLogo.TabIndex = 0;
            // 
            // PicLogo
            // 
            PicLogo.BackColor = Color.Transparent;
            PicLogo.Image = (Image)resources.GetObject("PicLogo.Image");
            PicLogo.Location = new Point(0, 12);
            PicLogo.Name = "PicLogo";
            PicLogo.Size = new Size(88, 60);
            PicLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            PicLogo.TabIndex = 2;
            PicLogo.TabStop = false;
            // 
            // LblSubtitulo
            // 
            LblSubtitulo.AutoSize = true;
            LblSubtitulo.BackColor = Color.Transparent;
            LblSubtitulo.Font = new Font("Corbel", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblSubtitulo.ForeColor = Color.WhiteSmoke;
            LblSubtitulo.Location = new Point(100, 44);
            LblSubtitulo.Name = "LblSubtitulo";
            LblSubtitulo.Size = new Size(104, 14);
            LblSubtitulo.TabIndex = 1;
            LblSubtitulo.Text = "Sistema De Gestión";
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.BackColor = Color.Transparent;
            LblTitulo.Font = new Font("Corbel", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitulo.ForeColor = Color.Transparent;
            LblTitulo.Location = new Point(89, 18);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(125, 26);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "BIBLIOTECA";
            // 
            // PnlSuperior
            // 
            PnlSuperior.BackColor = SystemColors.ActiveCaption;
            PnlSuperior.Dock = DockStyle.Top;
            PnlSuperior.Location = new Point(220, 0);
            PnlSuperior.Name = "PnlSuperior";
            PnlSuperior.Size = new Size(580, 80);
            PnlSuperior.TabIndex = 1;
            // 
            // PnlEstado
            // 
            PnlEstado.BackColor = SystemColors.InactiveCaption;
            PnlEstado.Dock = DockStyle.Bottom;
            PnlEstado.Location = new Point(220, 410);
            PnlEstado.Name = "PnlEstado";
            PnlEstado.Size = new Size(580, 40);
            PnlEstado.TabIndex = 2;
            // 
            // PnlContenido
            // 
            PnlContenido.Dock = DockStyle.Fill;
            PnlContenido.Location = new Point(220, 80);
            PnlContenido.Name = "PnlContenido";
            PnlContenido.Size = new Size(580, 330);
            PnlContenido.TabIndex = 3;
            PnlContenido.Paint += PnlContenido_Paint;
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(32, 19);
            iconMenuItem1.Text = "iconMenuItem1";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(PnlContenido);
            Controls.Add(PnlEstado);
            Controls.Add(PnlSuperior);
            Controls.Add(PnlMenu);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema De gestion de biblioteca";
            PnlMenu.ResumeLayout(false);
            PnlLogo.ResumeLayout(false);
            PnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlMenu;
        private Panel PnlSuperior;
        private Panel PnlLogo;
        private Panel PnlEstado;
        private Panel PnlContenido;
        private Label LblTitulo;
        private Label LblSubtitulo;
        private PictureBox PicLogo;
        private FontAwesome.Sharp.IconButton BtnInicio;
        private FontAwesome.Sharp.IconButton BtnLibros;
        private FontAwesome.Sharp.IconButton BtnAutores;
        private FontAwesome.Sharp.IconButton BtnUsuarios;
        private FontAwesome.Sharp.IconButton BtnSalida;
        private FontAwesome.Sharp.IconButton BtnReportes;
        private FontAwesome.Sharp.IconButton BtnPrestamos;
        private FontAwesome.Sharp.IconButton BtnEditoriales;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
    }
}
