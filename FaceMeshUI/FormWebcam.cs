using System;
using System.Collections.Generic;
using System.Threading;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Forms;
using TGMT;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Diagnostics;
using TGMTcs;
using System.Timers;

namespace FaceMeshUI
{
    public partial class FormWebcam : Form
    {
        static FormWebcam m_instance;
        VideoCaptureDevice m_videoSource;
        Bitmap m_bmp;

        private static Random random = new Random();
        Stopwatch m_watch;

        private readonly object m_locker1 = new object();
        private readonly object _boundingLock = new object();

        bool m_formClosed = false;

        float m_aspect = -1.0f;
        bool m_isBusy = false;

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public FormWebcam()
        {
            InitializeComponent();

            this.AutoScaleMode = AutoScaleMode.None;
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static FormWebcam GetInstance()
        {
            if (m_instance == null)
                m_instance = new FormWebcam();
            return m_instance;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FormWebcam_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory("input");
            Directory.CreateDirectory("unknown");
            LoadWebcam();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btn_start_Click(object sender, EventArgs e)
        {
            if(btn_start.Text == "Start")
            {
                StartWebcam();
                btn_start.Text = "Stop";
            }
            else
            {
                StopWebcam();
                circle1.Enabled = false;
                btn_start.Text = "Start";
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (m_bmp == null)
                return;

            string filePath = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".jpg";
            m_bmp.Save(filePath, ImageFormat.Jpeg);

            FormMain.GetInstance().PrintSuccess(filePath);
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        void LoadWebcam()
        {
            cb_webcam.Items.Clear();

            FilterInfoCollection videosources = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videosources.Count == 0)
            {
                FormMain.GetInstance().PrintError("Can not find camera");
                return;
            }


            for (int i = 0; i < videosources.Count; i++)
            {
                cb_webcam.Items.Add(videosources[i].Name);
            }
            cb_webcam.Enabled = true;

            int webcamIndex = TGMTregistry.GetInstance().ReadInt("cb_webcam", -1);
            if(webcamIndex >-1 && webcamIndex < cb_webcam.Items.Count)
            {
                cb_webcam.SelectedIndex = webcamIndex;
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void cb_webcam_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadWebcamResolution();

            TGMTregistry.GetInstance().SaveValue("cb_webcam", cb_webcam.SelectedIndex);
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void cb_resolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            TGMTregistry.GetInstance().SaveValue("cb_resolution", cb_resolution.SelectedIndex);
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        void StartWebcam()
        {
            if (cb_webcam.Items.Count == 0 || cb_webcam.SelectedIndex == -1)
                return;
            if (m_videoSource != null)
            {
                m_videoSource.Stop();
                m_videoSource = null;
            }
            
            
            FilterInfoCollection videosources = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            m_videoSource = new VideoCaptureDevice(videosources[cb_webcam.SelectedIndex].MonikerString);

            if(cb_resolution.SelectedIndex > -1 && cb_resolution.SelectedIndex < m_videoSource.VideoCapabilities.Length)
            {
                m_videoSource.VideoResolution = m_videoSource.VideoCapabilities[cb_resolution.SelectedIndex];
            }
            
            m_videoSource.NewFrame += new NewFrameEventHandler(OnCameraFrame);
            m_videoSource.Start();

            circle1.Visible = true;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        void OnCameraFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (m_formClosed)
                return;

            if (m_bmp != null)
                m_bmp.Dispose();


            m_bmp = (Bitmap)eventArgs.Frame.Clone();

            if (m_aspect == -1)
            {
                m_aspect = (float)m_bmp.Width / m_bmp.Height;

                float pictureBoxAspect = (float)picWebcam.Width / picWebcam.Height;

                if(pictureBoxAspect > m_aspect)
                {
                    int newWidth = (int)(m_bmp.Height * m_aspect);
                    this.Invoke(new Action(() =>
                    {
                        picWebcam.Width = newWidth;
                    }));
                }
                else
                {
                    int newHeight = (int)(m_bmp.Width / m_aspect);
                    this.Invoke(new Action(() =>
                    {
                        picWebcam.Height = newHeight;
                    }));
                }
                
            }


            Bitmap bmp = TGMTimage.CloneBitmap(eventArgs.Frame);
            FaceMesh faceMesh;
            
            if (Program.isDraw)
            {
                faceMesh = Program.faceMeshMgr.DetectAndDrawFaceMesh(bmp);
            }
            else
            {
                faceMesh = Program.faceMeshMgr.DetectFaceMesh(bmp);
            }
            
            picWebcam.Image = faceMesh.bitmapDraw;

            this.BeginInvoke(new Action(() => lbl_result.Text = faceMesh.faceAngle.ToString()));

            if(faceMesh.faceAngle.ToString() == "Unknown")
            {
                string filePath = "unknown\\" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".jpg";
                m_bmp.Save(filePath, ImageFormat.Jpeg);

                FormMain.GetInstance().PrintSuccess(filePath);
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FormWebcam_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                //if(cbCamera.Items.Count == 1)
                //{
                //    cbCamera.SelectedIndex = 0;
                //}
            }
            else
            {
                
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void StopWebcam()
        {
            if (m_videoSource != null)
                m_videoSource.Stop();

            picWebcam.Image = null;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FormWebcam_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_formClosed = true;
            StopWebcam();           
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FormWebcam_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_formClosed = true;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FormWebcam_SizeChanged(object sender, EventArgs e)
        {
            picWebcam.Width = (this.Width - 20) / 2;
            picWebcam.Width = (this.Width - 20) / 2;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        void LoadWebcamResolution()
        {
            if (cb_webcam.Items.Count == 0)
                return;

            FilterInfoCollection videosources = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            VideoCaptureDevice videoSource = new VideoCaptureDevice(videosources[cb_webcam.SelectedIndex].MonikerString);

            cb_resolution.Items.Clear();
            foreach (var cap in videoSource.VideoCapabilities)
            {
                cb_resolution.Items.Add(cap.FrameSize.Width + "x" + cap.FrameSize.Height + " (" + cap.MaximumFrameRate + " FPS)");
            }


            int resolutionIndex = TGMTregistry.GetInstance().ReadInt("cb_resolution", 0);
            if (resolutionIndex > -1 && resolutionIndex < cb_resolution.Items.Count)
            {
                cb_resolution.SelectedIndex = resolutionIndex;
            }
        }
    }
}
