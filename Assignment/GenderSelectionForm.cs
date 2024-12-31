
using System;
using System.Windows.Forms;
using System.Drawing;

namespace Assignment
{
    public class GenderSelectionForm : Form
    {
        private TextBox txtName;
        private RadioButton rdMale;
        private RadioButton rdFemale;
        private Button btnSubmit;

        public GenderSelectionForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            txtName = new TextBox();
            rdMale = new RadioButton();
            rdFemale = new RadioButton();
            btnSubmit = new Button();
            SuspendLayout();
            
            txtName.Location = new Point(20, 20);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 27);
            txtName.TabIndex = 0;
            txtName.TextChanged += txtName_TextChanged;
            
            rdMale.Location = new Point(20, 50);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(104, 24);
            rdMale.TabIndex = 1;
            rdMale.Text = "Male";
            
            rdFemale.Location = new Point(100, 50);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(104, 24);
            rdFemale.TabIndex = 2;
            rdFemale.Text = "Female";
            
            btnSubmit.Location = new Point(20, 80);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.Click += btnSubmit_Click;
            
            ClientSize = new Size(282, 153);
            Controls.Add(txtName);
            Controls.Add(rdMale);
            Controls.Add(rdFemale);
            Controls.Add(btnSubmit);
            Name = "GenderSelectionForm";
            Text = "Gender Selection";
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please enter a name");
                return;
            }

            string gender = rdMale.Checked ? "Male" : rdFemale.Checked ? "Female" : "Not Selected";
            MessageBox.Show($"Name: {txtName.Text}\nGender: {gender}");
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GenderSelectionForm());
        }
    }
}