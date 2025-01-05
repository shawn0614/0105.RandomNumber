namespace _0105.大樂透
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            int[] Numbers = new int[100];
            int a;
            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = i + 1;
            }
            Random crandom = new Random();
            for (int i = 0; i < 5; i++)
            {
                a = crandom.Next(1, Numbers.Length);
                if (a < 10)
                {
                    textBox1.Text += 0;
                }
                textBox1.Text += a.ToString() + Environment.NewLine;
                int[] NewNumbers = new int[Numbers.Length];
                for(int j = 0; j < Numbers.Length; j++)
                {
                    if (j == a)
                    {
                        continue;
                    }
                    NewNumbers[j] = Numbers[j];
                }
                for (int j = 0; j < Numbers.Length; j++)
                {
                    Numbers[j] = NewNumbers[j];
                }
            }
        }
    }
}
