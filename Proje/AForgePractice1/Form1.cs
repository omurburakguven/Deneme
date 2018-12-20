using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge;
using AForge.Imaging.Filters;
using AForge.Imaging;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;
using Point = System.Drawing.Point;
using System.IO.Ports;
namespace AForgePractice1
{
    public partial class Form1 : Form
    {
        int red, green, blue;
        private FilterInfoCollection VideoCapTureDevices;
        private VideoCaptureDevice CurrentDevices;


        private string CurrentCaptureDevice { get; set; }

        public Form1()
        {
            InitializeComponent();
            LoadCaptureDevices();
        }

        private void LoadCaptureDevices()
        {

            comboBox1.DataSource = SerialPort.GetPortNames();
            VideoCapTureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoCaptureDevice in VideoCapTureDevices)
            {
                cbCaptureDevices.Items.Add(VideoCaptureDevice.Name);
            }
            cbCaptureDevices.SelectedIndex = 0;
        }

        private void LoadDeviceResolutions()
        {
            foreach (var item in CurrentDevices.VideoCapabilities)
            {
                cbVideoResolutions.Items.Add(item.FrameSize + " " + item.AverageFrameRate);
            }
        }

        private void btnSelectCaptureDevice_Click(object sender, EventArgs e)
        {
            CurrentDevices = new VideoCaptureDevice(VideoCapTureDevices[cbCaptureDevices.SelectedIndex].MonikerString);
            LoadDeviceResolutions();
            cbVideoResolutions.Enabled = true;
            btnSelectVideoResolution.Enabled = true;
        }

        private void btnSelectVideoResolution_Click(object sender, EventArgs e)
        {
            CurrentDevices.VideoResolution = CurrentDevices.VideoCapabilities[cbVideoResolutions.SelectedIndex];
            CurrentDevices.NewFrame += new NewFrameEventHandler(CurrentDevices_NewFrame);
            CurrentDevices.Start();
        }


        private void CurrentDevices_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap image = (Bitmap)eventArgs.Frame.Clone();
            Bitmap image1 = (Bitmap)eventArgs.Frame.Clone();
            Mirror filter1 = new Mirror(false, true);
            filter1.ApplyInPlace(image);
            filter1.ApplyInPlace(image1);
            pbOrjinalimage.Image = image;



            if (true)
            {
                EuclideanColorFiltering filter = new EuclideanColorFiltering();
                filter.CenterColor = new RGB(Color.FromArgb(red, green, blue));
                filter.Radius = 100;
                filter.ApplyInPlace(image1);
                nesnebul(image1);

            }
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            CurrentDevices.Stop();
            base.OnClosing(e);
        }

        private void pbOrjinalimage_Click(object sender, EventArgs e)
        {

        }

        private void pbCloneimage_Click(object sender, EventArgs e)
        {

        }

        public void nesnebul(Bitmap image)
        {

            BlobCounter blobCounter = new BlobCounter();
            blobCounter.MinWidth = 5;
            blobCounter.MinHeight = 5;
            blobCounter.FilterBlobs = true;
            blobCounter.ObjectsOrder = ObjectsOrder.Size;
            BitmapData objectsData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadOnly, image.PixelFormat);
            Grayscale grayscaleFilter = new Grayscale(0.2125, 0.7154, 0.0721);
            UnmanagedImage grayImage = grayscaleFilter.Apply(new UnmanagedImage(objectsData));
            image.UnlockBits(objectsData);


            blobCounter.ProcessImage(image);
            Rectangle[] rects = blobCounter.GetObjectsRectangles();
            Blob[] blobs = blobCounter.GetObjectsInformation();
            pbCloneimage.Image = image;

            foreach (Rectangle recs in rects)
            {
                if (rects.Length > 0)
                {
                    Rectangle objectRect = rects[0];
                    Graphics g = pbCloneimage.CreateGraphics();
                    using (Pen pen = new Pen(Color.FromArgb(red, green, blue), 2))
                    {
                        g.DrawRectangle(pen, objectRect);
                    }

                    g.Dispose();

                    if (rects.Length > 0)
                    {

                        Rectangle nesne = rects[0];

                        int nesneX = nesne.X + (nesne.Width / 2);
                        int nesneY = nesne.Y + (nesne.Height / 2);


                        if (nesneX > 0 && nesneX < 214 && nesneY > 0 && nesneY < 160)
                        {
                            Console.WriteLine("nesne sol üst kösede kor:" + nesneX + "," + nesneY);
                            serialPort2.Write("1");
                        }
                        if (nesneX > 214 && nesneX < 424 && nesneY > 0 && nesneY < 160)
                        {
                            Console.WriteLine("nesne orta üstte kor:" + nesneX + "," + nesneY);
                            serialPort2.Write("2");
                        }
                        if (nesneX > 427 && nesneX < 640 && nesneY < 160 && nesneY > 0)
                        {
                            Console.WriteLine("nesne sag üst kösede kor:" + nesneX + "," + nesneY);
                            serialPort2.Write("3");
                        }


                        if (nesneX > 0 && nesneX < 214 && nesneY > 160 && nesneY < 320)
                        {
                            Console.WriteLine("nesne sol ortada kor:" + nesneX + "," + nesneY);
                            serialPort2.Write("4");
                        }
                        if (nesneX > 214 && nesneX < 427 && nesneY > 160 && nesneY < 320)
                        {
                            Console.WriteLine("nesne ortada kor:" + nesneX + "," + nesneY);
                            serialPort2.Write("5");
                        }
                        if (nesneX > 427 && nesneX < 640 && nesneY > 160 && nesneY < 320)
                        {
                            Console.WriteLine("nesne orta sağda kor:" + nesneX + "," + nesneY);
                            serialPort2.Write("6");
                        }

                        if (nesneX > 0 && nesneX < 214 && nesneY > 320 && nesneY < 480)
                        {
                            Console.WriteLine("nesne sol alt köşede kor:" + nesneX + "," + nesneY);
                            serialPort2.Write("7");
                        }
                        if (nesneX > 214 && nesneX < 427 && nesneY > 320 && nesneY < 480)
                        {
                            Console.WriteLine("nesne orta altta kor:" + nesneX + "," + nesneY);
                            serialPort2.Write("8");
                        }
                        if (nesneX > 427 && nesneX < 640 && nesneY > 230 && nesneY < 480)
                        {
                            Console.WriteLine("nesne sağ alt köşede kor:" + nesneX + "," + nesneY);
                            serialPort2.Write("9");
                        }

                    }

                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            serialPort2.BaudRate = 9600;
            serialPort2.PortName = comboBox1.SelectedItem.ToString();
            serialPort2.Open();

            if (serialPort2.IsOpen)
            {
                MessageBox.Show("Port Acıldı");
            }
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            blue = (int)trackBar3.Value;
            textBox3.Text = blue.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            green = (int)trackBar2.Value;
            textBox2.Text = green.ToString();
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            red = (int)trackBar1.Value;
            textBox1.Text = red.ToString();
        }

       

        
    }
}