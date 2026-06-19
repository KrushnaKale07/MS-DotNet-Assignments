namespace MyWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            sum = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);

            MessageBox.Show("Sum is : "+ sum);
        }
    }
}
