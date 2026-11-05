namespace ImageRotation
{
    partial class ofd
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
            project3ToolStripMenuItem = new ToolStripMenuItem();
            projcet3ToolStripMenuItem = new ToolStripMenuItem();
            project3ToolStripMenuItem1 = new ToolStripMenuItem();
            coloursUsedToolStripMenuItem = new ToolStripMenuItem();
            coloursUsedToolStripMenuItem1 = new ToolStripMenuItem();
            BtnLoad = new Button();
            txtImageInfo = new TextBox();
            pbImage = new PictureBox();
            openFD = new OpenFileDialog();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { project3ToolStripMenuItem, coloursUsedToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1274, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // project3ToolStripMenuItem
            // 
            project3ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { projcet3ToolStripMenuItem, project3ToolStripMenuItem1 });
            project3ToolStripMenuItem.Name = "project3ToolStripMenuItem";
            project3ToolStripMenuItem.Size = new Size(73, 24);
            project3ToolStripMenuItem.Text = "Project ";
            // 
            // projcet3ToolStripMenuItem
            // 
            projcet3ToolStripMenuItem.Name = "projcet3ToolStripMenuItem";
            projcet3ToolStripMenuItem.Size = new Size(224, 26);
            projcet3ToolStripMenuItem.Text = "Projcet 1 ";
            projcet3ToolStripMenuItem.Click += projcet3ToolStripMenuItem_Click;
            // 
            // project3ToolStripMenuItem1
            // 
            project3ToolStripMenuItem1.Name = "project3ToolStripMenuItem1";
            project3ToolStripMenuItem1.Size = new Size(224, 26);
            project3ToolStripMenuItem1.Text = "Project  3";
            project3ToolStripMenuItem1.Click += project3ToolStripMenuItem1_Click;
            // 
            // coloursUsedToolStripMenuItem
            // 
            coloursUsedToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { coloursUsedToolStripMenuItem1 });
            coloursUsedToolStripMenuItem.Name = "coloursUsedToolStripMenuItem";
            coloursUsedToolStripMenuItem.Size = new Size(114, 24);
            coloursUsedToolStripMenuItem.Text = "Colours Used ";
            coloursUsedToolStripMenuItem.Click += coloursUsedToolStripMenuItem_Click;
            // 
            // coloursUsedToolStripMenuItem1
            // 
            coloursUsedToolStripMenuItem1.Name = "coloursUsedToolStripMenuItem1";
            coloursUsedToolStripMenuItem1.Size = new Size(177, 26);
            coloursUsedToolStripMenuItem1.Text = "Colours used";
            coloursUsedToolStripMenuItem1.Click += coloursUsedToolStripMenuItem1_Click;
            // 
            // BtnLoad
            // 
            BtnLoad.BackColor = SystemColors.ControlLight;
            BtnLoad.Location = new Point(312, 364);
            BtnLoad.Name = "BtnLoad";
            BtnLoad.Size = new Size(119, 54);
            BtnLoad.TabIndex = 1;
            BtnLoad.Text = "Load Image";
            BtnLoad.UseVisualStyleBackColor = false;
            BtnLoad.Click += BtnLoad_Click;
            // 
            // txtImageInfo
            // 
            txtImageInfo.Location = new Point(529, 48);
            txtImageInfo.Multiline = true;
            txtImageInfo.Name = "txtImageInfo";
            txtImageInfo.Size = new Size(245, 292);
            txtImageInfo.TabIndex = 2;
            // 
            // pbImage
            // 
            pbImage.Location = new Point(12, 48);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(511, 292);
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImage.TabIndex = 3;
            pbImage.TabStop = false;
            // 
            // openFD
            // 
            openFD.FileName = "openFileDialog1";
            openFD.Title = "Load Image";
            // 
            // ofd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 663);
            Controls.Add(pbImage);
            Controls.Add(txtImageInfo);
            Controls.Add(BtnLoad);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ofd";
            Text = "Load Image";
            Load += ofd_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem project3ToolStripMenuItem;
        private ToolStripMenuItem projcet3ToolStripMenuItem;
        private ToolStripMenuItem project3ToolStripMenuItem1;
        private Button BtnLoad;
        private TextBox txtImageInfo;
        private PictureBox pbImage;
        private OpenFileDialog openFD;
        private ToolStripMenuItem coloursUsedToolStripMenuItem;
        private ToolStripMenuItem coloursUsedToolStripMenuItem1;
    }
}