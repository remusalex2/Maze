﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Level1 : Form
    {
        bool finish = false;
        private Stopwatch watch;
        public Int64 elapsedMs;
        public Int64 BestTime;
        public Int64 BestEver;

        public Level1()
        {
            InitializeComponent();
            MoveToStart();
            Enter -= wall_MouseEnter;
            watch = Stopwatch.StartNew();
        }

        private void Level1_FormClosing(object sender, FormClosingEventArgs e)
        {
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            if (finish == true)
            {
                this.DialogResult = DialogResult.OK;
                
            }
            else
                this.DialogResult = DialogResult.Cancel;
        }

        private void MoveToStart()
        {
            Point startingPoint = panel1.Location;
            startingPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startingPoint);
        }

        private void wall_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
            label51.Visible = true;
            label51.MouseEnter += wall_MouseEnter;
            label52.Visible = true;
            label52.MouseEnter += wall_MouseEnter;
        }

        private void LabelClick(object sender, EventArgs e)
        {
            label51.MouseEnter -= wall_MouseEnter;
            label51.Visible = false;
        }

        private void LabelClick2(object sender, EventArgs e)
        {
            label52.MouseEnter -= wall_MouseEnter;
            label52.Visible = false;
        }

        private void LabelClick3(object sender, EventArgs e)
        {
            label51.MouseEnter -= wall_MouseEnter;
            label51.Visible = false;
            label52.MouseEnter -= wall_MouseEnter;
            label52.Visible = false;
        }

        private void finishLabel_MouseEnter(object sender, EventArgs e)
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
