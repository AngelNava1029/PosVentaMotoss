namespace PosVentaMotos
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            txtNombre = new TextBox();
            lblTitulo = new Label();
            lblHoraYFecha = new Label();
            lblPictureBoxLogo = new PictureBox();
            dataGridMotos = new DataGridView();
            timer = new System.Windows.Forms.Timer(components);
            lblDesarrollador = new Label();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)lblPictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridMotos).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(27, 81);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(111, 23);
            txtNombre.TabIndex = 0;
            txtNombre.KeyPress += txtNombre_KeyPress;
            txtNombre.PreviewKeyDown += txtNombre_PreviewKeyDown;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTitulo.Location = new Point(142, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(170, 15);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "PUNTO DE VENTA DE MOTOS";
            // 
            // lblHoraYFecha
            // 
            lblHoraYFecha.AutoSize = true;
            lblHoraYFecha.Location = new Point(190, 84);
            lblHoraYFecha.Name = "lblHoraYFecha";
            lblHoraYFecha.Size = new Size(77, 15);
            lblHoraYFecha.TabIndex = 2;
            lblHoraYFecha.Text = "Hora Y Fecha";
            // 
            // lblPictureBoxLogo
            // 
            lblPictureBoxLogo.BackgroundImage = Properties.Resources._61a7a2b87b13b388458f84fb971c67dc1;
            lblPictureBoxLogo.Location = new Point(375, 8);
            lblPictureBoxLogo.Name = "lblPictureBoxLogo";
            lblPictureBoxLogo.Size = new Size(112, 39);
            lblPictureBoxLogo.TabIndex = 4;
            lblPictureBoxLogo.TabStop = false;
            // 
            // dataGridMotos
            // 
            dataGridMotos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMotos.Location = new Point(121, 160);
            dataGridMotos.Name = "dataGridMotos";
            dataGridMotos.RowTemplate.Height = 25;
            dataGridMotos.Size = new Size(343, 150);
            dataGridMotos.TabIndex = 5;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tag = "";
            timer.Tick += timer_Tick;
            // 
            // lblDesarrollador
            // 
            lblDesarrollador.AutoSize = true;
            lblDesarrollador.Location = new Point(190, 42);
            lblDesarrollador.Name = "lblDesarrollador";
            lblDesarrollador.Size = new Size(80, 15);
            lblDesarrollador.TabIndex = 6;
            lblDesarrollador.Text = "Desarrollador:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(491, 332);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(47, 15);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "TOTAL=";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(597, 490);
            Controls.Add(lblTotal);
            Controls.Add(lblDesarrollador);
            Controls.Add(dataGridMotos);
            Controls.Add(lblPictureBoxLogo);
            Controls.Add(lblHoraYFecha);
            Controls.Add(lblTitulo);
            Controls.Add(txtNombre);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)lblPictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridMotos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label lblTitulo;
        private Label lblHoraYFecha;
        private PictureBox lblPictureBoxLogo;
        private DataGridView dataGridMotos;
        private System.Windows.Forms.Timer timer;
        private Label lblDesarrollador;
        private Label lblTotal;
    }
}