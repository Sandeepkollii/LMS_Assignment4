
using System;
using System.Windows.Forms;
using System.Drawing;

namespace SquareCalculatorApp
{
    public class SquareCalculatorForm : Form
    {
        private TextBox txtNumber;
        private TextBox txtResult;
        private Button btnCalculate;
        private Label lblNumber;
        private Label lblResult;

        public SquareCalculatorForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Text = "Square Calculator";
            Size = new Size(300, 200);
            // Number Label
            lblNumber = new Label();
            lblNumber.Text = "Enter a number:";
            lblNumber.Location = new Point(20, 20);
            lblNumber.AutoSize = true;
            // Number TextBox
            txtNumber = new TextBox();
            txtNumber.Location = new Point(20, 40);
            txtNumber.Size = new Size(100, 20);
            // Result Label
            lblResult = new Label();
            lblResult.Text = "Square:";
            lblResult.Location = new Point(20, 70);
            lblResult.AutoSize = true;
            // Result TextBox
            txtResult = new TextBox();
            txtResult.Location = new Point(20, 90);
            txtResult.Size = new Size(100, 20);
            txtResult.ReadOnly = true;
            // Calculate Button
            btnCalculate = new Button();
            btnCalculate.Text = "Calculate Square";
            btnCalculate.Location = new Point(20, 120);
            btnCalculate.AutoSize = true;
            btnCalculate.Click += btnCalculate_Click;
            // Add controls to form
            Controls.AddRange(new Control[] { lblNumber, txtNumber, lblResult, txtResult, btnCalculate });
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumber.Text))
            {
                MessageBox.Show("Please enter a number");
                return;
            }

            if (double.TryParse(txtNumber.Text, out double number))
            {
                double square = Math.Pow(number, 2);
                txtResult.Text = square.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a valid number");
            }
        }
    }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SquareCalculatorForm());
        }
    }
}