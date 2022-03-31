using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace openCVSharpTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            Mat image;
            string imgPath = ShowFileOpenDialog();
            image = Cv2.ImRead(imgPath, ImreadModes.Grayscale);

            pictureBox_view.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(image);
        }

        public string ShowFileOpenDialog()
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "���� ���� ����â";
            ofd.FileName = "test";
            ofd.Filter = "�׸� ���� (*.jpg, *.gif, *.bmp) | *.jpg; *.gif; *.bmp; | ��� ���� (*.*) | *.*";

            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                string fileName = ofd.SafeFileName;
                string fileFullName = ofd.FileName;
                string filePath = fileFullName.Replace(fileName, "");

                return fileFullName;
            }
            else if (dr == DialogResult.Cancel)
            {
                return "";
            }

            return "";
        }
    }
}