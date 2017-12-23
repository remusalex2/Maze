using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
        }

        private void StartClick(object sender, EventArgs e)
        {
            if (numericUpDown2.Value == 1)
            {
                Level1 level1 = new Level1();
                level1.ShowDialog();
                if (level1.DialogResult == DialogResult.OK)
                {
                    label2.Text = "2: OK";
                    label2.BackColor = Color.Green;
                }
                else
                {
                    label2.Text = "1: NOT OK";
                    label2.BackColor = Color.Red;
                }
                label5.Text = (level1.elapsedMs / 1000F).ToString() ;
            }
            if (numericUpDown2.Value == 2)
            {
                Level2 level2 = new Level2();
                level2.ShowDialog();
                if (level2.DialogResult == DialogResult.OK)
                {
                    label3.Text = "2: OK";
                    label3.BackColor = Color.Green;
                }
                else
                {
                    label3.Text = "2: NOT OK";
                    label3.BackColor = Color.Red;
                }
            }
            if (numericUpDown2.Value == 3)
            {
                Level3 level3 = new Level3();
                level3.ShowDialog();
                if (level3.DialogResult == DialogResult.OK)
                    label4.Text = "2: OK";
                else
                    label4.Text = "2: NOT OK";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
