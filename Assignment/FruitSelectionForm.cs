// FruitSelectionForm.cs
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Text;


public class FruitSelectionForm : Form
{
    private CheckBox chkApple;
    private CheckBox chkBanana;
    private CheckBox chkOrange;
    private CheckBox chkMango;
    private Button btnDisplay;

    public FruitSelectionForm()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        chkApple = new CheckBox();
        chkBanana = new CheckBox();
        chkOrange = new CheckBox();
        chkMango = new CheckBox();
        btnDisplay = new Button();
        SuspendLayout();
        // 
        // chkApple
        // 
        chkApple.AutoSize = true;
        chkApple.Location = new Point(20, 20);
        chkApple.Name = "chkApple";
        chkApple.Size = new Size(71, 24);
        chkApple.TabIndex = 0;
        chkApple.Text = "Apple";
        
        // 
        // chkBanana
        // 
        chkBanana.AutoSize = true;
        chkBanana.Location = new Point(20, 50);
        chkBanana.Name = "chkBanana";
        chkBanana.Size = new Size(80, 24);
        chkBanana.TabIndex = 1;
        chkBanana.Text = "Banana";
       
        // 
        // chkOrange
        // 
        chkOrange.AutoSize = true;
        chkOrange.Location = new Point(20, 80);
        chkOrange.Name = "chkOrange";
        chkOrange.Size = new Size(80, 24);
        chkOrange.TabIndex = 2;
        chkOrange.Text = "Orange";
        // 
        // chkMango
        // 
        chkMango.AutoSize = true;
        chkMango.Location = new Point(20, 110);
        chkMango.Name = "chkMango";
        chkMango.Size = new Size(78, 24);
        chkMango.TabIndex = 3;
        chkMango.Text = "Mango";
        // 
        // btnDisplay
        // 
        btnDisplay.AutoSize = true;
        btnDisplay.Location = new Point(20, 150);
        btnDisplay.Name = "btnDisplay";
        btnDisplay.Size = new Size(155, 30);
        btnDisplay.TabIndex = 4;
        btnDisplay.Text = "Show Selected Fruits";
        btnDisplay.Click += btnDisplay_Click;
        // 
        // FruitSelectionForm
        // 
        ClientSize = new Size(282, 203);
        Controls.Add(chkApple);
        Controls.Add(chkBanana);
        Controls.Add(chkOrange);
        Controls.Add(chkMango);
        Controls.Add(btnDisplay);
        Name = "FruitSelectionForm";
        Text = "Fruit Selection";
        ResumeLayout(false);
        PerformLayout();
    }

    private void btnDisplay_Click(object sender, EventArgs e)
    {
        StringBuilder selectedFruits = new StringBuilder("Selected fruits:\n");
        bool anySelected = false;

        if (chkApple.Checked)
        {
            selectedFruits.AppendLine("- Apple");
            anySelected = true;
        }
        if (chkBanana.Checked)
        {
            selectedFruits.AppendLine("- Banana");
            anySelected = true;
        }
        if (chkOrange.Checked)
        {
            selectedFruits.AppendLine("- Orange");
            anySelected = true;
        }
        if (chkMango.Checked)
        {
            selectedFruits.AppendLine("- Mango");
            anySelected = true;
        }

        if (!anySelected)
        {
            MessageBox.Show("No fruits selected!");
        }
        else
        {
            MessageBox.Show(selectedFruits.ToString());
        }
    }

    
}

static class Program4
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FruitSelectionForm());
        }
    }
