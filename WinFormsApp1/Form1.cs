namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue; // Chnge form color
            label1.Text = "blue";
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            // MessageBox.Show("Mouse passed from button1");
        }

        private void button_hello_Click(object sender, EventArgs e)
        {
            label_hello.Text = "Hello " + textBox1.Text;
            textBox1.Focus(); // Moves cursor to textBox1
            textBox1.Clear();
        }

        // Press enter to submit text in textBox1
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Convert.ToInt32(e.KeyChar) == 13) // 13 is the ASCII value of Enter
            {
                label_hello.Text = "Hello " + textBox1.Text;
                textBox1.Focus();
                textBox1.Clear();
            }
        }
    }
}
