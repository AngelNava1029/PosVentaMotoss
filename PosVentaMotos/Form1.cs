namespace PosVentaMotos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblHoraYFecha.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
            lblTitulo.Location = new Point((this.Width / 2) - (lblTitulo.Width / 2), 0);
            lblDesarrollador.Location = new Point((this.Width / 2) - (lblDesarrollador.Width / 2), lblTitulo.Height);
            lblHoraYFecha.Location = new Point((this.Width / 2) - (lblHoraYFecha.Width / 2), (lblTitulo.Height + lblDesarrollador.Height));
            dataGridMotos.Location = new Point((10), (lblTitulo.Height + lblDesarrollador.Height + lblHoraYFecha.Height));
            dataGridMotos.Width = this.Width - 20;
            dataGridMotos.Height = (this.Height / 4) * 3;
            lblPictureBoxLogo.Location = new Point((this.Width - lblPictureBoxLogo.Width), 0);
            txtNombre.Location = new Point((10), this.Height - txtNombre.Height);
            txtNombre.Width = this.Width - 20;


            dataGridMotos.Columns.Add("NOMBRE", "NOMBRE");
            dataGridMotos.Columns[0].HeaderCell.Style.Font = new Font("Arial", 25F);
            dataGridMotos.Columns[0].Width = (dataGridMotos.Width * 12) / 100;
            dataGridMotos.Columns.Add("PRECIO", "PRECIO");
            dataGridMotos.Columns[1].HeaderCell.Style.Font = new Font("Arial", 25F);
            dataGridMotos.Columns[1].Width = (dataGridMotos.Width * 50) / 100;
            dataGridMotos.Columns.Add("NUMERO DE SERIE", "NUMERO DE SERIE");
            dataGridMotos.Columns[2].HeaderCell.Style.Font = new Font("Arial", 25F);
            dataGridMotos.Columns[2].Width = (dataGridMotos.Width * 20) / 80;
            dataGridMotos.Columns.Add("$ TOTAL", "$ TOTAL");
            dataGridMotos.Columns[3].HeaderCell.Style.Font = new Font("Arial", 25F);
            dataGridMotos.Columns[3].Width = (dataGridMotos.Width * 21) / 80;
            dataGridMotos.ReadOnly = true;

            Font fuente = new Font("Arial", 25);
            lblTotal.Font = fuente;

            int posicion = (this.Height - (lblTitulo.Height + lblDesarrollador.Height + lblHoraYFecha.Height + dataGridMotos.Height + txtNombre.Height));
            lblTotal.Location = new Point(10 + dataGridMotos.Columns[0].Width + dataGridMotos.Columns[1].Width + dataGridMotos.Columns[2].Width,
                (lblTitulo.Height + lblDesarrollador.Height + lblHoraYFecha.Height + dataGridMotos.Height) + posicion / 4);

            txtNombre.TabIndex = 0;



        }
        private void timer_Tick(object sender, EventArgs e)
        {
            lblHoraYFecha.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
        }

        private void txtNombre_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.IsInputKey = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                MessageBox.Show("SELECT * FROM motos WHERE nombre=" + "'" + txtNombre.Text + "'");
                    txtNombre.Clear();
            }
        }
    }
}