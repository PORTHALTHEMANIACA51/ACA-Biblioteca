namespace AcaBibliteca
{
    partial class FrmInicio
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
            panelContenido = new Panel();
            panel1 = new Panel();
            lblLinea3 = new Label();
            lblLine2 = new Label();
            lblLinea1 = new Label();
            lblBienvenida = new Label();
            panelContenido.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenido
            // 
            panelContenido.BackColor = SystemColors.ActiveCaption;
            panelContenido.Controls.Add(panel1);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(0, 0);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(1371, 747);
            panelContenido.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(lblLinea3);
            panel1.Controls.Add(lblLine2);
            panel1.Controls.Add(lblLinea1);
            panel1.Controls.Add(lblBienvenida);
            panel1.Location = new Point(470, 249);
            panel1.Name = "panel1";
            panel1.Size = new Size(692, 283);
            panel1.TabIndex = 0;
            // 
            // lblLinea3
            // 
            lblLinea3.AutoSize = true;
            lblLinea3.BackColor = Color.Transparent;
            lblLinea3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLinea3.Location = new Point(126, 182);
            lblLinea3.Name = "lblLinea3";
            lblLinea3.Size = new Size(429, 17);
            lblLinea3.TabIndex = 3;
            lblLinea3.Text = "los títulos de la colección, sus autores y el estado de las existencias.";
            lblLinea3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLine2
            // 
            lblLine2.AutoSize = true;
            lblLine2.BackColor = Color.Transparent;
            lblLine2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLine2.Location = new Point(126, 149);
            lblLine2.Name = "lblLine2";
            lblLine2.Size = new Size(414, 17);
            lblLine2.TabIndex = 2;
            lblLine2.Text = "Aquí podrás gestionar fácilmente todos los datos de los usuarios,";
            lblLine2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLinea1
            // 
            lblLinea1.AutoSize = true;
            lblLinea1.BackColor = Color.Transparent;
            lblLinea1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLinea1.Location = new Point(126, 117);
            lblLinea1.Name = "lblLinea1";
            lblLinea1.Size = new Size(420, 17);
            lblLinea1.TabIndex = 1;
            lblLinea1.Text = "Te damos la bienvenida al sistema de administración bibliotecaria.";
            lblLinea1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.BackColor = Color.Transparent;
            lblBienvenida.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.Location = new Point(193, 56);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(281, 47);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "¡Hola de nuevo!";
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 747);
            Controls.Add(panelContenido);
            Name = "FrmInicio";
            Text = "FrmInicio";
            panelContenido.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenido;
        private Panel panel1;
        private Label lblBienvenida;
        private Label lblLinea3;
        private Label lblLine2;
        private Label lblLinea1;
    }
}