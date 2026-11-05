using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;



namespace ImageRotation
{
    public partial class ofd : Form
    {

        enum PropertyID
        {

            PropertyTagDateTime = 0x0132,
            PropertyTagExifDTOrig = 0x9003,
            PropertyTagEquipMake = 0x010F,
            PropertyTagEquipModel = 0x0110

        }
        public ofd()
        {
            InitializeComponent();
        }

        private void projcet3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();



        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            txtImageInfo.Clear();
            openFD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFD.Filter = "JPEGS|*.jpg|GIFs|*.gif|PNGs|*.png|TIF|*.tif";
            if (openFD.ShowDialog() != DialogResult.Cancel)
            {
                pbImage.Load(openFD.FileName);
                Image img = Image.FromFile(openFD.FileName);


                //                MessageBox.Show(
                //    "Pixel Format: " + img.PixelFormat +
                //    "\nPalette Entries: " + img.Palette.Entries.Length
                //);



                //foreach (PropertyItem item in img.PropertyItems)
                //{
                //    txtImageInfo.Text +=
                //        "Property ID: " + item.Id.ToString("X4") + "\r\n";
                //}
                string imageType = "";








                if (ImageFormat.Jpeg.Equals(img.RawFormat))
                {

                    imageType = "JPEG Image";
                    GetPropItems(
                        img,
                        "\r\n Date and Time Taken: ",
                        (int)PropertyID.PropertyTagExifDTOrig);

                    GetPropItems(
        img,
        "Camera Manufacturer: ",
        (int)PropertyID.PropertyTagEquipMake);

                    txtImageInfo.Text += "\r\n";









                }
                else if (ImageFormat.Gif.Equals(img.RawFormat))
                {

                    imageType = "\r\n GIF Image";

                }
                else if (ImageFormat.Tiff.Equals(img.RawFormat))
                {

                    imageType = "TIFF Image";

                }
                else if (ImageFormat.Png.Equals(img.RawFormat))
                {

                    imageType = "PNG Image";

                }

                string imageWidth = img.Width.ToString();
                string imageHeight = img.Height.ToString();
                string imageResolution = img.HorizontalResolution.ToString() + " dpi";
                string imagePixelDepth = Image.GetPixelFormatSize(img.PixelFormat).ToString();

                txtImageInfo.Text += imageType + "\r\n";
                txtImageInfo.Text += "Width = " + imageWidth + "\r\n";
                txtImageInfo.Text += "Height = " + imageHeight + "\r\n";
                txtImageInfo.Text += "Resolution = " + imageResolution + "\r\n";
                txtImageInfo.Text += "Pixel Depth = " + imagePixelDepth + "\r\n";



                //Colours Used
                int colorPaletteLength = img.Palette.Entries.Length;
                string[] colorsArray = new string[colorPaletteLength];

                // Colours Used: Read actual pixel colours

                Bitmap bmp = new Bitmap(img);

                HashSet<Color> uniqueColors = new HashSet<Color>();

                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        Color pixelColor = bmp.GetPixel(x, y);

                        uniqueColors.Add(Color.FromArgb(
                            pixelColor.R,
                            pixelColor.G,
                            pixelColor.B
                        ));
                    }
                }

                int hexCount = 0;

                foreach (Color pixelColor in uniqueColors)
                {
                    if (hexCount >= 256)
                        break;

                    ColorLabel(
                        "color" + hexCount.ToString(),
                        ColorTranslator.ToHtml(pixelColor)
                    );

                    hexCount++;
                }

                bmp.Dispose();


            }
        }



        private void ColorLabel(string labelName, String labelColor)
        {
            Control[] foundLabels = this.Controls.Find(labelName, true);

            if (foundLabels.Length > 0)
            {
                foundLabels[0].BackColor =
                    ColorTranslator.FromHtml(labelColor);

                foundLabels[0].Text = "";
            }
            else
            {
                MessageBox.Show("Label not found: " + labelName);
            }
        }

        //Image Detection
        private void GetPropItems(Image img, string message, int ID)
        {
            try
            {
                PropertyItem propItem = img.GetPropertyItem(ID);  //This is used for the metadata of an image
                if (propItem != null)
                {
                    ASCIIEncoding encod = new ASCIIEncoding(); //creates an object 'encod' that can convert bytes into ASCII text.
                    string asciiInfo = encod.GetString(propItem.Value, 0, propItem.Len);   //asciiInfo-The variable that stores the converted text.,Converts bytes into a string
                    txtImageInfo.Text += message + asciiInfo + "\r\n";





                }
            }
            catch (Exception ex)
            {
                txtImageInfo.Text += message + "Not Available\r\n";
                //txtImageInfo.Text += "Error: " + ex.Message + "\r\n";
                //txtImageInfo.Text += "ID checked: " + ID + "\r\n";
            }








        }



        private void coloursUsedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void coloursUsedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();

            this.Hide();

        }

        private void ofd_Load(object sender, EventArgs e)
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

        private void project3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();

            this.Hide();

        }
    }




}
    

