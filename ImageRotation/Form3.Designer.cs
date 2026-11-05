namespace ImageRotation
{
    partial class Form3
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
            menuStrip1 = new MenuStrip();
            nEXTToolStripMenuItem = new ToolStripMenuItem();
            nEXTToolStripMenuItem1 = new ToolStripMenuItem();
            pREVToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { nEXTToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // nEXTToolStripMenuItem
            // 
            nEXTToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nEXTToolStripMenuItem1, pREVToolStripMenuItem });
            nEXTToolStripMenuItem.Name = "nEXTToolStripMenuItem";
            nEXTToolStripMenuItem.Size = new Size(46, 24);
            nEXTToolStripMenuItem.Text = "File";
            // 
            // nEXTToolStripMenuItem1
            // 
            nEXTToolStripMenuItem1.Name = "nEXTToolStripMenuItem1";
            nEXTToolStripMenuItem1.Size = new Size(224, 26);
            nEXTToolStripMenuItem1.Text = "NEXT";
            nEXTToolStripMenuItem1.Click += nEXTToolStripMenuItem1_Click;
            // 
            // pREVToolStripMenuItem
            // 
            pREVToolStripMenuItem.Name = "pREVToolStripMenuItem";
            pREVToolStripMenuItem.Size = new Size(224, 26);
            pREVToolStripMenuItem.Text = "PREV";
            pREVToolStripMenuItem.Click += pREVToolStripMenuItem_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem nEXTToolStripMenuItem;
        private ToolStripMenuItem nEXTToolStripMenuItem1;
        private ToolStripMenuItem pREVToolStripMenuItem;
    }
}