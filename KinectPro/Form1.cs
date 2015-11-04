using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coding4Fun.Kinect.WinForm;
using Microsoft.Kinect;



namespace KinectPro
{
    public partial class Main : Form
    {

        private KinectSensor sensor;


        public Main()
        {
            InitializeComponent();
          
       

        }

     

        private void btnStream_Click(object sender, EventArgs e)
        {
            if (btnStream.Text == "Stream")
            {
                
                if (KinectSensor.KinectSensors.Count > 0)
                {
                    sensor = KinectSensor.KinectSensors[0];
                    btnStream.Text = "Stop";
                    KinectSensor.KinectSensors.StatusChanged += KinectSensors_StatusChanged;
                    sensor.Start();
                    lblConID.Text = sensor.DeviceConnectionId;
                    sensor.ColorStream.Enable(ColorImageFormat.RgbResolution640x480Fps30);
                    sensor.ColorFrameReady += Sensor_ColorFrameReady;
                    sensor.ElevationAngle = 0;
                    sliderValue.Text = sliderAngle.Value.ToString();
                    sliderAngle.Value = 0;
                }

            }
            else
            {
                if (sensor != null && sensor.IsRunning)
                {
                    sensor.Stop();
                    btnStream.Text = "Stream";
                    pb.Image = null;
                    
                }


            }
           
        }

        private void Sensor_ColorFrameReady(object sender, ColorImageFrameReadyEventArgs e)
        {
            using (var frame = e.OpenColorImageFrame())
            {
                if (frame != null)
                pb.Image = CreateBitmapFromSensor(frame);
            }

        }

        private void KinectSensors_StatusChanged(object sender, StatusChangedEventArgs e)
        {
            statlbl.Text = sensor.Status.ToString();
            

         }

        private Bitmap CreateBitmapFromSensor(ColorImageFrame frame)
        {
            var pixelData = new byte[frame.PixelDataLength];
            frame.CopyPixelDataTo(pixelData);

            return pixelData.ToBitmap(frame.Width, frame.Height);


        }

        private void sliderAngle_Scroll(object sender, EventArgs e)
        {
            sliderValue.Text = sliderAngle.Value.ToString();

        }

        private void sliderAngle_ValueChanged(object sender, EventArgs e)
        {
            sliderValue.Text = sliderAngle.Value.ToString();

        }

        private void btnAdjust_Click(object sender, EventArgs e)
        {
            if(sensor != null&&sensor.IsRunning) 
            sensor.ElevationAngle = (int)sliderAngle.Value;

            else
            {
                MessageBox.Show("Kinect Sensor Not Runnig","Error !!!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (sensor != null && sensor.IsRunning && sensor.ElevationAngle != 0)
            {
                sensor.ElevationAngle = 0;
                sliderValue.Text = "0";
                sliderAngle.Value = 0;

            }
        }
    } //-------------------------------------------------------------------------------------
}
