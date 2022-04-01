using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace openCVSharpTest
{
    public partial class Form1 : Form
    {
        Mat image;
        public Form1()
        {
            InitializeComponent();
            image = new Mat();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            string imgPath = ShowFileOpenDialog();
            if (imgPath == "")
            {
                return;
            }
            image = Cv2.ImRead(imgPath, ImreadModes.Grayscale);

            if(image == null)
            {
                return;
            }

            Cv2.Threshold(image, image, 180, 255, ThresholdTypes.Binary);
            pictureBox_view.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(image);
        }

        public string ShowFileOpenDialog()
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "그림 파일 (*.bmp) | *.bmp; | 모든 파일 (*.*) | *.*";

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

        private void pictureBox_view_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender.GetType() == pictureBox_view.GetType())
            {
                PictureBox pic = (PictureBox)sender;
                System.Drawing.Point pos = GetMousePos(pic);

                label_xy.Text = pos.X.ToString() + ", " + pos.Y.ToString();
            }
        }

        private System.Drawing.Point GetMousePos(PictureBox pic)
        {
            int x = Control.MousePosition.X;
            int y = Control.MousePosition.Y;

            System.Drawing.Point mousePos = new System.Drawing.Point(x, y);
            System.Drawing.Point mousePosPtoClient = pic.PointToClient(mousePos);
            //System.Drawing.Point mousePosPtoScreen = pic.PointToScreen(mousePos);

            return mousePosPtoClient;
        }

        private void pictureBox_view_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                contextMenuPicture.Show(this, e.Location);
            }
        }
    }
}