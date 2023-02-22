namespace CouchSurfing
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.hOSTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gUESTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOUCHSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOSTToolStripMenuItem,
            this.gUESTSToolStripMenuItem,
            this.cOUCHSToolStripMenuItem,
            this.rEPORTToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(962, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // hOSTToolStripMenuItem
            // 
            this.hOSTToolStripMenuItem.Name = "hOSTToolStripMenuItem";
            this.hOSTToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.hOSTToolStripMenuItem.Text = "HOSTS";
            this.hOSTToolStripMenuItem.Click += new System.EventHandler(this.hOSTToolStripMenuItem_Click);
            // 
            // gUESTSToolStripMenuItem
            // 
            this.gUESTSToolStripMenuItem.Name = "gUESTSToolStripMenuItem";
            this.gUESTSToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.gUESTSToolStripMenuItem.Text = "GUESTS";
            this.gUESTSToolStripMenuItem.Click += new System.EventHandler(this.gUESTSToolStripMenuItem_Click);
            // 
            // cOUCHSToolStripMenuItem
            // 
            this.cOUCHSToolStripMenuItem.Name = "cOUCHSToolStripMenuItem";
            this.cOUCHSToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.cOUCHSToolStripMenuItem.Text = "COUCHS";
            this.cOUCHSToolStripMenuItem.Click += new System.EventHandler(this.cOUCHSToolStripMenuItem_Click);
            // 
            // rEPORTToolStripMenuItem
            // 
            this.rEPORTToolStripMenuItem.Name = "rEPORTToolStripMenuItem";
            this.rEPORTToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.rEPORTToolStripMenuItem.Text = "REPORT";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.Location = new System.Drawing.Point(12, 489);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 32);
            this.button2.TabIndex = 11;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 583);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem hOSTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gUESTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOUCHSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTToolStripMenuItem;
        private System.Windows.Forms.Button button2;
    }
}