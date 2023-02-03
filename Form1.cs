namespace PracticaCrud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inicioControlPersonalizado1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            estudianteControlPersonalizado1.BringToFront();
        }

        private void estudianteControlPersonalizado1_Load(object sender, EventArgs e)
        {

        }
    }
}