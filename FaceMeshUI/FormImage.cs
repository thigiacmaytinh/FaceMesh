using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TGMT;
using TGMTcs;

namespace FaceMeshUI
{
    public partial class FormImage : Form
    {
        static FormImage m_instance;

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        public FormImage()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FormImage_Load(object sender, EventArgs e)
        {
            txt_imagePath.Text = TGMTregistry.GetInstance().ReadString("txt_imagePath");
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        public static FormImage GetInstance()
        {
            if (m_instance == null)
                m_instance = new FormImage();
            return m_instance;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void txt_imagePath_TextChanged(object sender, EventArgs e)
        {
            TGMTregistry.GetInstance().SaveValue("txt_imagePath", txt_imagePath.Text);
            Predict();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btn_predict_Click(object sender, EventArgs e)
        {
            Predict();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        void Predict()
        {
            if (Program.faceMeshMgr == null)
                return;
            if (!File.Exists(txt_imagePath.Text))
                return;

            circle1.Visible = true;

            pictureBox1.ImageLocation = txt_imagePath.Text;
            listView1.Items.Clear();
            workderPredict.RunWorkerAsync();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void workerDetect_DoWork(object sender, DoWorkEventArgs e)
        {
            FaceMesh result = Program.faceMeshMgr.DetectFaceMesh(txt_imagePath.Text);
            e.Result = result;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void workerDetect_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FaceMesh result = (FaceMesh)e.Result;

            string angle = "";
            if (result.faceAngle == FaceMesh.FaceAngle.Straight)
                angle = "Straight";
            else if (result.faceAngle == FaceMesh.FaceAngle.Up)
                angle = "Up";
            else if (result.faceAngle == FaceMesh.FaceAngle.Down)
                angle = "Down";
            else if (result.faceAngle == FaceMesh.FaceAngle.Left)
                angle = "Left";
            else if (result.faceAngle == FaceMesh.FaceAngle.Right)
                angle = "Right";
            else if (result.faceAngle == FaceMesh.FaceAngle.OpenMouth)
                angle = "Open mouth";

            ListViewItem item = new ListViewItem("1");
            item.SubItems.Add(angle);
            item.SubItems.Add(result.faceAngle.ToString());
            

            listView1.Items.Add(item);
            

            circle1.Visible = false;
            FormMain.GetInstance().PrintSuccess("Predict success");
        }        
    }
}
