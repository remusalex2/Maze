using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Level3 : Form
    {
        private Stopwatch watch;
        public Int64 elapsedMs;

        public Level3()
        {
            InitializeComponent();
            watch = Stopwatch.StartNew();
        }

        private void Level3_FormClosing(object sender, FormClosingEventArgs e)
        {
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
