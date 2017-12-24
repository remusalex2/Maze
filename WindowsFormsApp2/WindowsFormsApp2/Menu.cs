using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using WindowsFormsApp2.Resources;

namespace WindowsFormsApp2
{
    public partial class Menu : Form
    {
        public string FirstName;
        public Int64 BestTime1 = Int64.MaxValue;
        public Int64 BestTime2 = Int64.MaxValue;
        public Int64 BestTime3 = Int64.MaxValue;
        public Int64 BestEver1 = Int64.MaxValue;
        public Int64 BestEver2 = Int64.MaxValue;
        public Int64 BestEver3 = Int64.MaxValue;

        public ClassPlayer Player { get; set; }

        public Menu()
        {
            InitializeComponent();
            LoadPlayer();
        }

        public void LoadPlayer()
        {
            try
            {
                Player = new ClassPlayer();

                var serializer = new XmlSerializer(typeof(ClassPlayer));
                using (var reader = XmlReader.Create(@"..\Resources\Players.xml"))
                {
                    Player = (ClassPlayer)serializer.Deserialize(reader);
                }

                textBox1.Text = Player.FirstName;
                BestEver1 = Player.BestEver1;
                BestEver2 = Player.BestEver2;
                BestEver3 = Player.BestEver3;
                if (BestEver1 != long.MaxValue)
                    label14.Text = (BestEver1 / 1000F).ToString();
                if (BestEver2 != long.MaxValue)
                    label15.Text = (BestEver2 / 1000F).ToString();
                if (BestEver3 != long.MaxValue)
                    label16.Text = (BestEver3 / 1000F).ToString();
            }
            catch { }
        }

        public void SavePlayer()
        {
            Player.FirstName = textBox1.Text;
            Player.BestEver1 = BestEver1;
            Player.BestEver2 = BestEver2;
            Player.BestEver3 = BestEver3;
            var serializer = new XmlSerializer(Player.GetType());
            using (var writer = XmlWriter.Create(@"..\Resources\Players.xml"))
            {
                serializer.Serialize(writer, Player);
            }
        }

        private void StartClick(object sender, EventArgs e)
        {
            if (numericUpDown2.Value == 1)
            {
                Level1 level1 = new Level1();
                level1.BestTime = BestTime1;
                level1.BestEver = BestEver1;
                level1.ShowDialog();
                if (level1.DialogResult == DialogResult.OK)
                {
                    label2.Text = "1: OK";
                    label2.BackColor = Color.Green;
                    label5.Text = (level1.elapsedMs / 1000F).ToString();
                    if (level1.elapsedMs < level1.BestTime)
                        BestTime1 = level1.elapsedMs;
                    label13.Text = (BestTime1 / 1000F).ToString();
                    if (level1.elapsedMs < level1.BestEver)
                        BestEver1 = level1.elapsedMs;
                    label14.Text = (BestEver1 / 1000F).ToString();
                }
                else
                {
                    label2.Text = "1: NOT OK";
                    label2.BackColor = Color.Red;
                }
            }
            if (numericUpDown2.Value == 2)
            {
                Level2 level2 = new Level2();
                level2.BestTime = BestTime2;
                level2.BestEver = BestEver2;
                level2.ShowDialog();
                if (level2.DialogResult == DialogResult.OK)
                {
                    label3.Text = "2: OK";
                    label3.BackColor = Color.Green;
                    label6.Text = (level2.elapsedMs / 1000F).ToString();
                    if (level2.elapsedMs < level2.BestTime)
                        BestTime2 = level2.elapsedMs;
                    label12.Text = (BestTime2 / 1000F).ToString();
                    if (level2.elapsedMs < level2.BestEver)
                        BestEver2 = level2.elapsedMs;
                    label15.Text = (BestEver2 / 1000F).ToString();
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
                level3.BestTime = BestTime3;
                level3.BestEver = BestEver3;
                level3.ShowDialog();
                if (level3.DialogResult == DialogResult.OK)
                {
                    label4.Text = "3: OK";
                    label4.BackColor = Color.Green;
                    label7.Text = (level3.elapsedMs / 1000F).ToString();
                    if (level3.elapsedMs < level3.BestTime)
                        BestTime3 = level3.elapsedMs;
                    label11.Text = (BestTime3 / 1000F).ToString();
                    if (level3.elapsedMs < level3.BestEver)
                        BestEver3 = level3.elapsedMs;
                    label16.Text = (BestEver3 / 1000F).ToString();
                }
                else
                {
                    label4.Text = "3: NOT OK";
                    label4.BackColor = Color.Red;
                }
            }
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            SavePlayer();
        }
    }
}
