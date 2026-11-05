using System.Drawing.Imaging;

namespace ImageRotation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rotateBtn_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Image != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);   //Bitmap is c# class ,bmp-variable
                bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);     //method,enum contains diff rotation options,no flip rotate 90
                pictureBox1.Image = bmp;

            }
            else
            {

                MessageBox.Show("No Image");

            }







        }

        private void flipBtn_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);          //Bitmap is c# class ,bmp-variable
                bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);    //method,enum contains diff rotation options,no flip rotate 90
                pictureBox1.Image = bmp;

            }
            else
            {

                MessageBox.Show("No Image");

            }




        }

        private void cloneBtn_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                Rectangle rect = new Rectangle(0, 0, 32, 32);          //Rectangle -constructor,accepted 4 values,Starting X position (left edge),Starting Y position (top edge),Width,height: 32 pixels

                //MessageBox.Show( $"Image: {bmp.Width} x {bmp.Height}\n" +$"Rectangle: {rect.Width} x {rect.Height}");
                Bitmap cloneImage = bmp.Clone(rect, System.Drawing.Imaging.PixelFormat.DontCare);      //PixelFormat.DontCare indicates that you do not require a specific pixel format for the cloned image.



                pictureBox1.Image = cloneImage;


            }
            else
            {

                MessageBox.Show("No Image");

            }



        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox2.Image);
            int x, y;
            for (x = 0; x < bmp.Width; x++)
            {

                for (y = 0; y < bmp.Height; y++)
                {
                    Color oldPixelColor = bmp.GetPixel(x, y);   //retrieves the color of the pixel at those coordinates.
                    Color newPixelColor = Color.FromArgb(oldPixelColor.R, 0, 0); // set to red, ARGB-transparent,red,green,blue
                    bmp.SetPixel(x, y, newPixelColor);












                }

            }
            pictureBox2.Image = bmp;










        }

        private void invertClick_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox2.Image);
            int x, y;
            for (x = 0; x < bmp.Width; x++)
            {

                for (y = 0; y < bmp.Height; y++)
                {
                    Color oldPixelColor = bmp.GetPixel(x, y);
                    Color newPixelColor = Color.FromArgb(255 - oldPixelColor.R, 255 - oldPixelColor.G, 255 - oldPixelColor.B); //make it opposite colour white>black,red>cyan

                    bmp.SetPixel(x, y, newPixelColor);

                }
            }
            pictureBox2.Image = bmp;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {


            saveFD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);  //InitialDirectory-folder first open

            saveFD.FileName = "Save Image";
            saveFD.Filter = "JPEG|*.jpeg";

            if (saveFD.ShowDialog() != DialogResult.Cancel)
            {
                String savePath = saveFD.FileName;   //saveFD.FileName contains the path and file name selected by the user.

                Bitmap bmp = new Bitmap(pictureBox2.Image);
                bmp.Save(savePath, ImageFormat.Jpeg);
                MessageBox.Show("Image Saved ");



            }


        }

        private void openPrjct2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd f2 = new ofd();
            f2.Show();
            this.Hide();
        }
    }

}
