
using System;
using System.Windows.Forms;
using System.Drawing;


    public class ReverseForm : Form
    {
        private TextBox txtInput;
        private TextBox txtResult;
        private Button btnReverse;
        private Label lblInput;
        private Label lblResult;

        public ReverseForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Reverse String/Number";
            this.Size = new Size(400, 200);

            // Input Label
            lblInput = new Label();
            lblInput.Text = "Enter Text or Number:";
            lblInput.Location = new Point(20, 20);
            lblInput.AutoSize = true;

            // Input TextBox
            txtInput = new TextBox();
            txtInput.Location = new Point(20, 40);
            txtInput.Size = new Size(200, 20);

            // Result Label
            lblResult = new Label();
            lblResult.Text = "Reversed Result:";
            lblResult.Location = new Point(20, 70);
            lblResult.AutoSize = true;

            // Result TextBox
            txtResult = new TextBox();
            txtResult.Location = new Point(20, 90);
            txtResult.Size = new Size(200, 20);
            txtResult.ReadOnly = true;

            // Reverse Button
            btnReverse = new Button();
            btnReverse.Text = "Reverse";
            btnReverse.Location = new Point(20, 120);
            btnReverse.Click += new EventHandler(btnReverse_Click);

            // Add controls to form
            this.Controls.AddRange(new Control[] {
                lblInput, txtInput, lblResult, txtResult, btnReverse
            });
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text))
            {
                MessageBox.Show("Please enter some text or number");
                return;
            }

            char[] charArray = txtInput.Text.ToCharArray();
            Array.Reverse(charArray);
            txtResult.Text = new string(charArray);
        }
    }

    internal static class Program1
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ReverseForm());
        }
    }
