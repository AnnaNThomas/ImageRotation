namespace ImageRotation
{
    partial class Form5
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
            drawBtn = new Button();
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            prevPageToolStripMenuItem1 = new ToolStripMenuItem();
            nexrPageToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            TextBtn = new Button();
            polygonBtn = new Button();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // drawBtn
            // 
            drawBtn.BackColor = Color.DarkGray;
            drawBtn.Location = new Point(180, 362);
            drawBtn.Name = "drawBtn";
            drawBtn.Size = new Size(165, 56);
            drawBtn.TabIndex = 0;
            drawBtn.Text = "Draw";
            drawBtn.UseVisualStyleBackColor = false;
            drawBtn.Click += drawBtn_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 28);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 28);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { prevPageToolStripMenuItem1, nexrPageToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // prevPageToolStripMenuItem1
            // 
            prevPageToolStripMenuItem1.Name = "prevPageToolStripMenuItem1";
            prevPageToolStripMenuItem1.Size = new Size(159, 26);
            prevPageToolStripMenuItem1.Text = "Prev page";
            prevPageToolStripMenuItem1.Click += prevPageToolStripMenuItem1_Click;
            // 
            // nexrPageToolStripMenuItem
            // 
            nexrPageToolStripMenuItem.Name = "nexrPageToolStripMenuItem";
            nexrPageToolStripMenuItem.Size = new Size(159, 26);
            nexrPageToolStripMenuItem.Text = "Nexr Page";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Location = new Point(393, 362);
            button1.Name = "button1";
            button1.Size = new Size(105, 58);
            button1.TabIndex = 3;
            button1.Text = "Draw Ellipse";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TextBtn
            // 
            TextBtn.BackColor = SystemColors.ControlLight;
            TextBtn.Location = new Point(49, 360);
            TextBtn.Name = "TextBtn";
            TextBtn.Size = new Size(105, 58);
            TextBtn.TabIndex = 4;
            TextBtn.Text = "Draw Text";
            TextBtn.UseVisualStyleBackColor = false;
            TextBtn.Click += TextBtn_Click;
            // 
            // polygonBtn
            // 
            polygonBtn.BackColor = SystemColors.ControlLight;
            polygonBtn.Location = new Point(544, 362);
            polygonBtn.Name = "polygonBtn";
            polygonBtn.Size = new Size(105, 58);
            polygonBtn.TabIndex = 5;
            polygonBtn.Text = "Draw Polygon";
            polygonBtn.UseVisualStyleBackColor = false;
            polygonBtn.Click += polygonBtn_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(polygonBtn);
            Controls.Add(TextBtn);
            Controls.Add(button1);
            Controls.Add(drawBtn);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            Paint += Form5_Paint;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button drawBtn;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem prevPageToolStripMenuItem1;
        private ToolStripMenuItem nexrPageToolStripMenuItem;
        private Button button1;
        private Button TextBtn;
        private Button polygonBtn;
    }
}