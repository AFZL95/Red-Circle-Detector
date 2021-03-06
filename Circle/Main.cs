﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Circle
{
    public partial class Detector : Form
    {
        Capture webcamCapture;
        Image<Bgr, Byte> mainImage;
        Image<Gray, Byte> processedImage;
        public Detector()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                webcamCapture = new Capture();
            }
            catch (Exception ex)
            {
                txtLog.Text += ex.Message;
            }

            Application.Idle += Application_Idle;
        }

        private void Application_Idle(object sender, EventArgs e)
        {
            mainImage = webcamCapture.QueryFrame().ToImage<Bgr, Byte>();
            if (mainImage == null) return;
            processedImage = mainImage.InRange(new Bgr(0 , 0 , 128), new Bgr(47 , 47 , 255));
            processedImage = processedImage.SmoothGaussian(9);
            CircleF[] circles = processedImage.HoughCircles(new Gray(100), new Gray(50), 2, processedImage.Height / 4, 10, 400).SelectMany(u => u.Select(s=> s)).ToArray();
            foreach(var c in circles)
            {
                if (txtLog.Text != "") txtLog.AppendText(Environment.NewLine);
                

                CvInvoke.Circle(mainImage, new Point((int)c.Center.X, (int)c.Center.Y), 3, new MCvScalar(0, 255, 0), -1, Emgu.CV.CvEnum.LineType.AntiAlias, 0);
                mainImage.Draw(c, new Bgr(Color.Red), 3);
            }
            imageBox1.Image = mainImage;
            imageBox2.Image = processedImage;
        }
    }
}
