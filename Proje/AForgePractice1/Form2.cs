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
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging;
using AForge.Imaging.Filters;
using System.Drawing.Imaging;
using System.IO.Ports;

namespace AForgePractice1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            LoadCaptureDevices();
        }
        int red, green, blue;
        private FilterInfoCollection VideoCapTureDevices;
        private VideoCaptureDevice CurrentDevices;


        private string CurrentCaptureDevice { get; set; }

       

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

                        int nesneX = nesne.X + (nesne.Width );
                        int nesneY = nesne.Y + (nesne.Height);
                        if(nesneX>80 && nesneX<600)
                        {
                            if(nesneX>0 && nesneX<214)
                            {
                                Console.WriteLine("sola dönücek");
                                serialPort2.Write("3");
                            }
                             if(nesneX>214 && nesneX<427)
                            {
                                Console.WriteLine("haraketsiz dur");
                                serialPort2.Write("2");
                            }

                             if(nesneX>427 && nesneX<640)
                            {
                                Console.WriteLine("sağa sönücek");
                                serialPort2.Write("1");
                            }

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

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            red = (int)trackBar1.Value;
            textBox1.Text = red.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            green = (int)trackBar2.Value;
            textBox2.Text = green.ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            blue = (int)trackBar3.Value;
            textBox3.Text = blue.ToString();
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
    }
}
