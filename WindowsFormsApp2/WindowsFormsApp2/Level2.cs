﻿using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Level2 : Form
    {
        bool finish = false;
        private Stopwatch watch;
        public Int64 elapsedMs;
        public Int64 BestTime;
        public Int64 BestEver;

        public Level2()
        {
            InitializeComponent();
            watch = Stopwatch.StartNew();
        }

        private void FormClosing1(object sender, FormClosingEventArgs e)
        {
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            if (finish == true)
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.Cancel;
        }

        private void FinishEnter(object sender, EventArgs e)
        {
            //MessageBox.Show("Bravo!");
            finish = true;
            Close();
        }

        private void Mouse_leave(object sender, EventArgs e)
        {
            bool mouse_on_control = false;
            foreach (Control c in Controls)
                mouse_on_control |= c.RectangleToScreen(c.ClientRectangle).Contains(Cursor.Position);
            if (!mouse_on_control)
                Close();
        }
    }
}