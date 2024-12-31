
using System;
using System.Windows.Forms;
using System.Drawing;

    public class CheckZeroForm : Form
    {
        private TextBox txtNumber;
        private Button btnCheck;
        private Label lblInstruction;

        public CheckZeroForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Check Zero";
            this.Size = new Size(300, 200);

            lblInstruction = new Label();
            lblInstruction.Text = "Enter a number:";
            lblInstruction.Location = new Point(20, 20);
            lblInstruction.AutoSize = true;

           
            txtNumber = new TextBox();
            txtNumber.Location = new Point(20, 50);
            txtNumber.Size = new Size(100, 20);

            btnCheck = new Button();
            btnCheck.Text = "Check";
            btnCheck.Location = new Point(20, 80);
            btnCheck.Click += new EventHandler(btnCheck_Click);

        
            this.Controls.AddRange(new Control[] {
                lblInstruction, txtNumber, btnCheck
            });
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumber.Text))
            {
                MessageBox.Show("Please enter a number");
                return;
            }

            if (double.TryParse(txtNumber.Text, out double number))
            {
                string message = number == 0 ? "The number is Zero" : "The number is Not Zero";
                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("Please enter a valid number");
            }
        }
    }

    static class Program3
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CheckZeroForm());
        }
    }
