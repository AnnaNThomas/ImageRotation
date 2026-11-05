using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;






namespace ImageRotation
{
    public partial class Form5 : Form
    {

        Point[] polygonPoints = new Point[5];


        int drawOptions = 0;

        String TextToDraw;
        Font chosenFont;
        SolidBrush solidBrush;
        StringFormat stringFormat;
        HatchBrush hatchBrush;






        public Form5()
        {
            InitializeComponent();
        }

        private void drawBtn_Click(object sender, EventArgs e)
        {
            Rectangle rectangle1;



            Pen pen1;
            rectangle1 = new Rectangle(10, 10, 100, 300);



            pen1 = new Pen(Color.Blue, 2);


            drawOptions = 2;
            Invalidate();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void polygonBtn_Click(object sender, EventArgs e)
        {
            polygonPoints[0] = new Point(20, 65);
            polygonPoints[1] = new Point(100, 10);
            polygonPoints[2] = new Point(175, 65);
            polygonPoints[3] = new Point(150, 150);
            polygonPoints[4] = new Point(50, 150);
            hatchBrush = new HatchBrush(
                   HatchStyle.BackwardDiagonal,
                   Color.DarkCyan,
                   Color.Aqua
               );


            drawOptions = 4;
            Invalidate();







        }


        private void Form5_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen1 = new Pen(Color.Blue, 2))
            {
                Rectangle rectangle1 = new Rectangle(10, 10, 100, 300);
                Rectangle rectangle2 = new Rectangle(10, 10, 150, 100);

                switch (drawOptions)
                {
                    case 1:
                        e.Graphics.DrawLine(pen1, 10, 10, 100, 10);
                        break;

                    case 2:
                        e.Graphics.DrawRectangle(pen1, rectangle1);
                        e.Graphics.FillRectangle(Brushes.Blue, rectangle1);
                        break;


                    case 3:
                        e.Graphics.SmoothingMode =
                            System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                        e.Graphics.DrawEllipse(pen1, rectangle2);
                        break;
                    case 4:

                        e.Graphics.DrawPolygon(Pens.Black, polygonPoints);
                        e.Graphics.FillPolygon(hatchBrush, polygonPoints);


                        break;
                    case 5:

                        e.Graphics.DrawString(TextToDraw, chosenFont, solidBrush, 100, 10, stringFormat);
                        break;


                    default:
                        break;
                }
            }
        }


        private void prevPageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();

            this.Hide();



        }


        private void button1_Click(object sender, EventArgs e)
        {
            drawOptions = 3;
            Invalidate();
        }

        private void TextBtn_Click(object sender, EventArgs e)
        {


            TextToDraw = "Home and Learn";
            chosenFont = new Font("Arial", 20, FontStyle.Bold);
            solidBrush = new SolidBrush(Color.Black);
            stringFormat = new StringFormat(StringFormatFlags.DirectionVertical);
            drawOptions = 5;
            Invalidate();










        }

       
    }
}

