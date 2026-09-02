namespace NA_Assignment_Maximllian_Yang
{
    public partial class frmNA : Form
    {
        public frmNA()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Visible = true;
            lblName.Visible = true;
            lblFood.Visible = true;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {

            lblHelloWorld.Visible = false;
            lblName.Visible = false;
            lblFood.Visible = false;
        }
    }
}
