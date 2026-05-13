namespace Snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gra rozpoczyna siê!","Uwaga!",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            Snake form = new Snake();
            form.Show();
            this.Hide();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
            button1.ForeColor = Color.Transparent;
            button1.Text = " ";

            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button2.ForeColor = Color.Transparent;
            button2.Text = " ";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nastêpuje wyjœcie z aplikacji...","Uwaga!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            Application.Exit();
        }
    }
}
