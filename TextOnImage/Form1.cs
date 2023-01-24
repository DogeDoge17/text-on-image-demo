using System.Runtime.CompilerServices;

namespace TextOnImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool openedImage;

        private Image image;
        private Image outImage;


        private void openBtn_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "png|*.png|jpg|*.jpg|jpeg|*.jpeg|bmp|*.bmp|webp|*.webp|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            selectedFileLbl.Text = filePath;

            if (filePath != "")
            {
                image = Image.FromFile(filePath);
                previewImage.Image = image;
                outImage = image;

                openedImage = true;
            }
        }

        private void processBtn_Click(object sender, EventArgs e)
        {
            if (!openedImage) { MessageBox.Show("No image selected", "Bruh", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            outImage = image;


            Font drawFont = new Font("Arial", 40);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            PointF drawPoint = new PointF(0, 0);

            using (Graphics g = Graphics.FromImage(outImage))
            {

                g.DrawString(inputRTB.Text, drawFont, drawBrush, drawPoint);
                outputImage.Image = outImage;
              //  outImage = g.;
            }

        }
    }
}