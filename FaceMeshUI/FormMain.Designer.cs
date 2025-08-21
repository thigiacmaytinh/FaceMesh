namespace FaceMeshUI
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.sw_draw = new TGMTcontrols.SwitchButton();
            this.circle1 = new TGMTcontrols.ProcessingControl();
            this.btn_loadModel = new TGMTcontrols.DefaultButton();
            this.txt_modelPath = new TGMTcontrols.BrowseFile();
            this.label1 = new System.Windows.Forms.Label();
            this.workerLoadModel = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_message = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(103)))), ((int)(((byte)(161)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.sw_draw);
            this.panel1.Controls.Add(this.circle1);
            this.panel1.Controls.Add(this.btn_loadModel);
            this.panel1.Controls.Add(this.txt_modelPath);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 66);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(986, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Draw";
            // 
            // sw_draw
            // 
            this.sw_draw.BorderColor = System.Drawing.Color.LightGray;
            this.sw_draw.Checked = true;
            this.sw_draw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sw_draw.Location = new System.Drawing.Point(920, 19);
            this.sw_draw.Name = "sw_draw";
            this.sw_draw.Size = new System.Drawing.Size(60, 35);
            this.sw_draw.TabIndex = 17;
            this.sw_draw.Text = "Draw";
            this.sw_draw.TextEnabled = true;
            this.sw_draw.Click += new System.EventHandler(this.sw_draw_Click);
            // 
            // circle1
            // 
            this.circle1.BackColor = System.Drawing.Color.Transparent;
            this.circle1.IndexColor = System.Drawing.Color.Turquoise;
            this.circle1.Interval = 50;
            this.circle1.Location = new System.Drawing.Point(875, 19);
            this.circle1.Name = "circle1";
            this.circle1.NCircle = 8;
            this.circle1.Others = System.Drawing.Color.LightGray;
            this.circle1.Radius = 4;
            this.circle1.Size = new System.Drawing.Size(39, 34);
            this.circle1.TabIndex = 16;
            this.circle1.Text = "processingControl1";
            this.circle1.Visible = false;
            // 
            // btn_loadModel
            // 
            this.btn_loadModel.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.btn_loadModel.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.btn_loadModel.BackColor = System.Drawing.Color.Transparent;
            this.btn_loadModel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_loadModel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_loadModel.ForeColor = System.Drawing.Color.White;
            this.btn_loadModel.Icon = null;
            this.btn_loadModel.ImageLocation = new System.Drawing.Point(0, 0);
            this.btn_loadModel.ImageSize = new System.Drawing.Size(0, 0);
            this.btn_loadModel.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(188)))), ((int)(((byte)(210)))));
            this.btn_loadModel.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(167)))), ((int)(((byte)(188)))));
            this.btn_loadModel.Location = new System.Drawing.Point(736, 18);
            this.btn_loadModel.Name = "btn_loadModel";
            this.btn_loadModel.Radius = 6;
            this.btn_loadModel.Size = new System.Drawing.Size(137, 38);
            this.btn_loadModel.Stroke = false;
            this.btn_loadModel.StrokeColor = System.Drawing.Color.Gray;
            this.btn_loadModel.TabIndex = 4;
            this.btn_loadModel.Text = "Load model";
            this.btn_loadModel.Transparency = false;
            this.btn_loadModel.Click += new System.EventHandler(this.btn_loadModel_Click);
            // 
            // txt_modelPath
            // 
            this.txt_modelPath.BackColor = System.Drawing.Color.Transparent;
            this.txt_modelPath.BackgroundColor = System.Drawing.Color.White;
            this.txt_modelPath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(133)))), ((int)(((byte)(200)))));
            this.txt_modelPath.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_modelPath.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_modelPath.Location = new System.Drawing.Point(175, 18);
            this.txt_modelPath.Name = "txt_modelPath";
            this.txt_modelPath.Padding = new System.Windows.Forms.Padding(5);
            this.txt_modelPath.Pattern = "";
            this.txt_modelPath.Size = new System.Drawing.Size(541, 30);
            this.txt_modelPath.TabIndex = 2;
            this.txt_modelPath.TextChanged += new System.EventHandler(this.txt_weightPath_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Face angle model";
            // 
            // workerLoadModel
            // 
            this.workerLoadModel.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerLoadModel_DoWork);
            this.workerLoadModel.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerLoadModel_RunWorkerCompleted);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_message,
            this.lblMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 654);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1041, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_message
            // 
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(0, 17);
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl1.Location = new System.Drawing.Point(0, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1041, 588);
            this.tabControl1.TabIndex = 18;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1033, 558);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Image";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1033, 558);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Webcam";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 676);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.Text = "Face angle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private TGMTcontrols.BrowseFile txt_modelPath;
        private TGMTcontrols.DefaultButton btn_loadModel;
        private System.ComponentModel.BackgroundWorker workerLoadModel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_message;
        private TGMTcontrols.ProcessingControl circle1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStripStatusLabel lblMessage;
        private System.Windows.Forms.Label label2;
        private TGMTcontrols.SwitchButton sw_draw;
    }
}

