namespace PulXırdalama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(!string.IsNullOrEmpty(maskedTextBox1.Text)){
                errorProvider1.Clear();
                int a=Convert.ToInt32(maskedTextBox1.Text);
                int p1 = a / 500;
                int q1 = a % 500;

                int p2 = q1 / 200;
                int q2 = q1 % 200;

                int p3 = q2 / 100;
                int q3 = q2 % 100;

                int p4= q3 / 50;
                int q4 = q3 % 50;

                int p5 = q4 / 20;
                int q5 = q4 % 20;

                int p6 = q5 / 10;
                int q6 = q5 % 10;

                int p7 = q6 / 5;
                int q7 = q6 % 5;

                int p8 = q7 / 1;

                label2.Text = p8.ToString();
                label3.Text = p7.ToString();
                label4.Text = p6.ToString();
                label5.Text = p5.ToString();
                label6.Text = p4.ToString();
                label7.Text = p3.ToString();
                label8.Text = p1.ToString();
                label9.Text = p2.ToString();

                //if(p8 == 0)
                //{
                //    pictureBox1.Visible=false;
                //}

            }
            else
            {
                errorProvider1.SetError(maskedTextBox1, "Xana boşdur");
            }
        }
    }
}
