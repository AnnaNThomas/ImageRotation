namespace ImageRotation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            rotateBtn = new Button();
            flipBtn = new Button();
            cloneBtn = new Button();
            pictureBox2 = new PictureBox();
            filterBtn = new Button();
            invertClick = new Button();
            saveFD = new SaveFileDialog();
            saveBtn = new Button();
            menuStrip1 = new MenuStrip();
            project2ToolStripMenuItem = new ToolStripMenuItem();
            openPrjct2ToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_arrow_64;
            pictureBox1.Location = new Point(203, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 88);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // rotateBtn
            // 
            rotateBtn.BackColor = Color.DarkSeaGreen;
            rotateBtn.Location = new Point(87, 185);
            rotateBtn.Name = "rotateBtn";
            rotateBtn.Size = new Size(94, 46);
            rotateBtn.TabIndex = 1;
            rotateBtn.Text = "Rotate";
            rotateBtn.UseVisualStyleBackColor = false;
            rotateBtn.Click += rotateBtn_Click;
            // 
            // flipBtn
            // 
            flipBtn.BackColor = Color.DarkSeaGreen;
            flipBtn.Location = new Point(203, 185);
            flipBtn.Name = "flipBtn";
            flipBtn.Size = new Size(94, 46);
            flipBtn.TabIndex = 2;
            flipBtn.Text = "Flip";
            flipBtn.UseVisualStyleBackColor = false;
            flipBtn.Click += flipBtn_Click;
            // 
            // cloneBtn
            // 
            cloneBtn.BackColor = Color.DarkSeaGreen;
            cloneBtn.Location = new Point(303, 185);
            cloneBtn.Name = "cloneBtn";
            cloneBtn.Size = new Size(94, 46);
            cloneBtn.TabIndex = 3;
            cloneBtn.Text = "Clone";
            cloneBtn.UseVisualStyleBackColor = false;
            cloneBtn.Click += cloneBtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.shasna;
            pictureBox2.Location = new Point(499, 40);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(190, 248);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // filterBtn
            // 
            filterBtn.BackColor = Color.DarkGray;
            filterBtn.Location = new Point(542, 303);
            filterBtn.Name = "filterBtn";
            filterBtn.Size = new Size(94, 40);
            filterBtn.TabIndex = 5;
            filterBtn.Text = "Filter";
            filterBtn.UseVisualStyleBackColor = false;
            filterBtn.Click += filterBtn_Click;
            // 
            // invertClick
            // 
            invertClick.BackColor = Color.DarkGray;
            invertClick.Location = new Point(542, 349);
            invertClick.Name = "invertClick";
            invertClick.Size = new Size(94, 40);
            invertClick.TabIndex = 6;
            invertClick.Text = "Invert";
            invertClick.UseVisualStyleBackColor = false;
            invertClick.Click += invertClick_Click;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.DodgerBlue;
            saveBtn.Location = new Point(542, 395);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(94, 40);
            saveBtn.TabIndex = 7;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { project2ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // project2ToolStripMenuItem
            // 
            project2ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openPrjct2ToolStripMenuItem });
            project2ToolStripMenuItem.Name = "project2ToolStripMenuItem";
            project2ToolStripMenuItem.Size = new Size(81, 24);
            project2ToolStripMenuItem.Text = "Project 2";
            // 
            // openPrjct2ToolStripMenuItem
            // 
            openPrjct2ToolStripMenuItem.Name = "openPrjct2ToolStripMenuItem";
            openPrjct2ToolStripMenuItem.Size = new Size(224, 26);
            openPrjct2ToolStripMenuItem.Text = "Open Prjct2";
            openPrjct2ToolStripMenuItem.Click += openPrjct2ToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(saveBtn);
            Controls.Add(invertClick);
            Controls.Add(filterBtn);
            Controls.Add(pictureBox2);
            Controls.Add(cloneBtn);
            Controls.Add(flipBtn);
            Controls.Add(rotateBtn);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button rotateBtn;
        private Button flipBtn;
        private Button cloneBtn;
        private PictureBox pictureBox2;
        private Button filterBtn;
        private Button invertClick;
        private SaveFileDialog saveFD;
        private Button saveBtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem project2ToolStripMenuItem;
        private ToolStripMenuItem openPrjct2ToolStripMenuItem;
    }
}
