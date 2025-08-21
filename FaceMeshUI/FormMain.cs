using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TGMT;
using TGMTcs;

namespace FaceMeshUI
{
    public partial class FormMain : Form
    {
        static FormMain m_instance;

        public FormMain()
        {
            InitializeComponent();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static FormMain GetInstance()
        {
            if (m_instance == null)
                m_instance = new FormMain();
            return m_instance;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FormMain_Load(object sender, EventArgs e)
        {
            txt_modelPath.Pattern = "Xml file|*.xml";

            TGMTregistry.GetInstance().Init("FaceMesh");
            txt_modelPath.Text = TGMTregistry.GetInstance().ReadString("txt_modelPath");
            sw_draw.Checked = TGMTregistry.GetInstance().ReadBool("draw");
            Program.isDraw = sw_draw.Checked;


#if DEBUG
            this.Text += " (Debug)";
#endif

            AddFormToTab();

            LoadModel();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormImage.GetInstance().Close();
            FormWebcam.GetInstance().Close();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btn_loadModel_Click(object sender, EventArgs e)
        {
            if (!File.Exists(txt_modelPath.Text))
            {
                PrintError("Model file does not exist");
                return;
            }

            LoadModel();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void txt_weightPath_TextChanged(object sender, EventArgs e)
        {
            TGMTregistry.GetInstance().SaveValue("txt_modelPath", txt_modelPath.Text);  
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void sw_draw_Click(object sender, EventArgs e)
        {
            TGMTregistry.GetInstance().SaveValue("draw", sw_draw.Checked);
            Program.isDraw = sw_draw.Checked;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        void LoadModel()
        {
            circle1.Visible = true;
            workerLoadModel.RunWorkerAsync();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void workerLoadModel_DoWork(object sender, DoWorkEventArgs e)
        {
            Program.faceMeshMgr = new FaceMeshMgr();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void workerLoadModel_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            circle1.Visible = false;
            Program.inited = true;
            tabControl1.Enabled = true;
            btn_loadModel.Enabled = true;
            

            PrintSuccess("Load model success");

            FormImage.GetInstance().Enabled = true;
            FormWebcam.GetInstance().Enabled = true;
            //FormExtract.GetInstance().Enabled = true;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void PrintError(string message)
        {
            lblMessage.ForeColor = Color.Red;
            if (message == "")
                lblMessage.Text = "";
            else
                lblMessage.Text = DateTime.Now.ToString("(hh:mm:ss)") + message;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void PrintSuccess(string message)
        {
            lblMessage.ForeColor = Color.Green;
            if (message == "")
                lblMessage.Text = "";
            else
                lblMessage.Text = DateTime.Now.ToString("(hh:mm:ss)") + message;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void PrintMessage(string message)
        {
            lblMessage.ForeColor = Color.Black;
            if (message == "")
                lblMessage.Text = "";
            else
                lblMessage.Text = DateTime.Now.ToString("(hh:mm:ss)") + message;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        void AddFormToTab()
        {
            tabPage1.Controls.Add(FormImage.GetInstance());
            FormImage.GetInstance().Show();
            FormImage.GetInstance().Enabled = false;


            tabPage3.Controls.Add(FormWebcam.GetInstance());
            FormWebcam.GetInstance().Show();
            FormWebcam.GetInstance().Enabled = false;

            tabControl1.SelectedIndex = TGMTregistry.GetInstance().ReadInt("selected_tab_index", 0);
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            switch (e.Index)
            {
                case 0:
                    e.Graphics.FillRectangle(new SolidBrush(Color.Red), e.Bounds);
                    break;
                case 1:
                    e.Graphics.FillRectangle(new SolidBrush(Color.Blue), e.Bounds);
                    break;
                default:
                    break;
            }

            // Then draw the current tab button text 
            Rectangle paddedBounds = e.Bounds;
            paddedBounds.Inflate(-2, -2);
            e.Graphics.DrawString(tabControl1.TabPages[e.Index].Text, this.Font, SystemBrushes.HighlightText, paddedBounds);
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TGMTregistry.GetInstance().SaveValue("selected_tab_index", tabControl1.SelectedIndex);
        }

        
    }
}
