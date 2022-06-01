using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public double FirstNumber;
        public double SecondNumber;
        public char Opperation;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            try
            {
                this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            TextBoxOperation.Text += button.Text;
        }

        private void OpperationTypes_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            FirstNumber = double.Parse(TextBoxOperation.Text);
            Opperation = Convert.ToChar(button.Text);
            TextBoxOperation.Text = "";
        }

        private void EqualOpperation_Click(object sender, EventArgs e)
        {
            SecondNumber = double.Parse(TextBoxOperation.Text);

            TextBoxOperation.Text = "";

            if (Opperation == '+')
                TextBoxOperation.Text = Convert.ToString(FirstNumber + SecondNumber);
            else if (Opperation == '-')
                TextBoxOperation.Text = Convert.ToString(FirstNumber - SecondNumber);
            else if (Opperation == '*')
                TextBoxOperation.Text = Convert.ToString(FirstNumber * SecondNumber);
            else if (Opperation == '/')
                TextBoxOperation.Text = Convert.ToString(FirstNumber / SecondNumber);

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            FirstNumber = 0;
            SecondNumber = 0;
            TextBoxOperation.Text = "";
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            if (!TextBoxOperation.Text.Contains("."))
                TextBoxOperation.Text += ".";
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string NewText = "";

            for (int i = 0; i < TextBoxOperation.Text.Length - 1; i++)
                NewText += TextBoxOperation.Text[i];

            TextBoxOperation.Text = NewText;
        }

    }
}
