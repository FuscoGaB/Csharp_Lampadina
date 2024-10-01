namespace Lampadina
{
    public partial class Form1 : Form
    {

        private int spostamentopixel = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            accesa.Visible = true;
            spenta.Visible = false;
            //prova git
        }

        private void button2_Click(object sender, EventArgs e)
        {
            accesa.Visible = false;
            spenta.Visible = true;
        }

        private void spenta_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void su_Click(object sender, EventArgs e)
        {
            contapixel.Top -= 2;
            label1.Top -= 2;
            accesa.Top -= 2;
            spenta.Top -= 2;

            spostamentopixel += 2;
            contapixel.Text = $"Spostato di {spostamentopixel} pixel verso l alto";
        }

        private void giu_Click(object sender, EventArgs e)
        {
            contapixel.Top += 2;
            label1.Top += 2;
            accesa.Top += 2;
            spenta.Top += 2;

            spostamentopixel -= 2;
            contapixel.Text = $"Spostato di {spostamentopixel} pixel verso il basso";
        }

        private void contapixel_TextChanged(object sender, EventArgs e)
        {
            contapixel.ReadOnly = true;
        }
    }
}
