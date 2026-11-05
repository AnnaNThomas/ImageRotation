using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageRotation
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pREVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd f2 = new ofd();
            f2.Show();
            this.Hide();


        }

        private void nEXTToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int offsetX = 0;
            int offsetY = 0;
            int labelWidth = 30;
            int labelHeight = 30;
            for (int i = 0; i < 256; i++)
            {
                if (offsetX + labelWidth > 700)
                {

                    offsetX = 0;
                    offsetY += labelHeight;


                }

                Controls.Add(new Label
                {
                    Name = "color" + (i).ToString(),
                    Size = new Size(labelWidth, labelHeight),
                    Location = new Point(offsetX, 400 + offsetY),                    
                    BackColor = SystemColors.ControlDark,
                    Text = (i).ToString()
                });
                offsetX += 30;





            }

        }
    }
}
