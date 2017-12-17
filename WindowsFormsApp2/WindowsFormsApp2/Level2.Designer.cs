namespace WindowsFormsApp2
{
    partial class Level2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Finish = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Finish
            // 
            this.Finish.AutoSize = true;
            this.Finish.Location = new System.Drawing.Point(347, 216);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(34, 13);
            this.Finish.TabIndex = 0;
            this.Finish.Text = "Finish";
            this.Finish.MouseEnter += new System.EventHandler(this.FinishEnter);
            // 
            // Level2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 353);
            this.Controls.Add(this.Finish);
            this.Name = "Level2";
            this.Text = "Level2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosing1);
            this.MouseLeave += new System.EventHandler(this.Mouse_leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Finish;
    }
}