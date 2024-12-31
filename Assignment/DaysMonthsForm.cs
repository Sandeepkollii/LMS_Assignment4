
using System;
using System.Windows.Forms;
using System.Drawing;



    public class DaysMonthsForm : Form
    {
        private ComboBox cmbSelection;
        private ListBox lstDisplay;

        public DaysMonthsForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Days and Months Display";
            this.Size = new Size(400, 500);

          
            cmbSelection = new ComboBox();
            cmbSelection.Location = new Point(20, 20);
            cmbSelection.Size = new Size(200, 20);
            cmbSelection.Items.AddRange(new string[] { "Days", "Months" });
            cmbSelection.SelectedIndexChanged += new EventHandler(cmbSelection_SelectedIndexChanged);

           
            lstDisplay = new ListBox();
            lstDisplay.Location = new Point(20, 50);
            lstDisplay.Size = new Size(200, 300);

            this.Controls.AddRange(new Control[] {
                cmbSelection, lstDisplay
            });
        }

        private void cmbSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstDisplay.Items.Clear();

            if (cmbSelection.SelectedItem.ToString() == "Days")
            {
                string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday",
                                "Friday", "Saturday", "Sunday" };
                lstDisplay.Items.AddRange(days);
            }
            else if (cmbSelection.SelectedItem.ToString() == "Months")
            {
                string[] months = { "January", "February", "March", "April", "May",
                                  "June", "July", "August", "September", "October",
                                  "November", "December" };
                lstDisplay.Items.AddRange(months);
            }
        }
    }

    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DaysMonthsForm());
        }
    }
