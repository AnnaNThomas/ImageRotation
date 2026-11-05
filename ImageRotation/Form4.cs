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
    public partial class Form4 : Form
    {
        int drawOptions = 0;

        public Form4()
        {
            InitializeComponent();
        }

        private void drawBtn_Click(object sender, EventArgs e)
        {
            drawOptions = 1;
            MessageBox.Show("Button clicked. drawOptions = " + drawOptions);
            this.Refresh();
        }

        private void Form4_Paint(object sender, PaintEventArgs e)
        {
            if (drawOptions == 1)
            {
                using (Pen pen1 = new Pen(Color.Black, 5))
                {
                    e.Graphics.DrawLine(pen1, 150, 150, 350, 150);
                }
            }
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();

            this.Hide();

        }

        private void drawBtn_Paint(object sender, PaintEventArgs e)
        {

            

        }
    }
}
