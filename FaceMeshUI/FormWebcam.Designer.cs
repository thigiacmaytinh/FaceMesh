namespace FaceMeshUI
{
    partial class FormWebcam
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timerClear = new System.Windows.Forms.Timer(this.components);
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btn_start = new TGMTcontrols.DefaultButton();
            this.cb_resolution = new System.Windows.Forms.ComboBox();
            this.btn_save = new TGMTcontrols.DefaultButton();
            this.circle1 = new TGMTcontrols.ProcessingControl();
            this.lbl_result = new System.Windows.Forms.Label();
            this.cb_webcam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picWebcam = new System.Windows.Forms.PictureBox();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWebcam)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(100, 100);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // timerClear
            // 
            this.timerClear.Interval = 2000;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.panelLogo.Controls.Add(this.btn_start);
            this.panelLogo.Controls.Add(this.cb_resolution);
            this.panelLogo.Controls.Add(this.btn_save);
            this.panelLogo.Controls.Add(this.circle1);
            this.panelLogo.Controls.Add(this.lbl_result);
            this.panelLogo.Controls.Add(this.cb_webcam);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(982, 58);
            this.panelLogo.TabIndex = 21;
            // 
            // btn_start
            // 
            this.btn_start.Active1 = System.Drawing.Color.DodgerBlue;
            this.btn_start.Active2 = System.Drawing.Color.DeepSkyBlue;
            this.btn_start.BackColor = System.Drawing.Color.Transparent;
            this.btn_start.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_start.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_start.ForeColor = System.Drawing.Color.White;
            this.btn_start.Inactive1 = System.Drawing.Color.DeepSkyBlue;
            this.btn_start.Inactive2 = System.Drawing.Color.DodgerBlue;
            this.btn_start.Location = new System.Drawing.Point(527, 17);
            this.btn_start.Name = "btn_start";
            this.btn_start.Radius = 6;
            this.btn_start.Size = new System.Drawing.Size(110, 30);
            this.btn_start.Stroke = false;
            this.btn_start.StrokeColor = System.Drawing.Color.Gray;
            this.btn_start.TabIndex = 10;
            this.btn_start.Text = "Start";
            this.btn_start.Transparency = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // cb_resolution
            // 
            this.cb_resolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_resolution.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_resolution.FormattingEnabled = true;
            this.cb_resolution.Location = new System.Drawing.Point(372, 19);
            this.cb_resolution.Name = "cb_resolution";
            this.cb_resolution.Size = new System.Drawing.Size(149, 25);
            this.cb_resolution.TabIndex = 9;
            this.cb_resolution.SelectedIndexChanged += new System.EventHandler(this.cb_resolution_SelectedIndexChanged);
            // 
            // btn_save
            // 
            this.btn_save.Active1 = System.Drawing.Color.DodgerBlue;
            this.btn_save.Active2 = System.Drawing.Color.DeepSkyBlue;
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Inactive1 = System.Drawing.Color.DeepSkyBlue;
            this.btn_save.Inactive2 = System.Drawing.Color.DodgerBlue;
            this.btn_save.Location = new System.Drawing.Point(656, 17);
            this.btn_save.Name = "btn_save";
            this.btn_save.Radius = 6;
            this.btn_save.Size = new System.Drawing.Size(110, 30);
            this.btn_save.Stroke = false;
            this.btn_save.StrokeColor = System.Drawing.Color.Gray;
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Save frame";
            this.btn_save.Transparency = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // circle1
            // 
            this.circle1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.circle1.BackColor = System.Drawing.Color.Transparent;
            this.circle1.IndexColor = System.Drawing.Color.DeepSkyBlue;
            this.circle1.Interval = 50;
            this.circle1.Location = new System.Drawing.Point(932, 4);
            this.circle1.Name = "circle1";
            this.circle1.NCircle = 8;
            this.circle1.Others = System.Drawing.Color.LightGray;
            this.circle1.Radius = 4;
            this.circle1.Size = new System.Drawing.Size(38, 41);
            this.circle1.TabIndex = 7;
            this.circle1.Text = "processingControl1";
            this.circle1.Visible = false;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.lbl_result.Location = new System.Drawing.Point(772, 24);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(57, 21);
            this.lbl_result.TabIndex = 6;
            this.lbl_result.Text = "Result";
            // 
            // cb_webcam
            // 
            this.cb_webcam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_webcam.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_webcam.FormattingEnabled = true;
            this.cb_webcam.Location = new System.Drawing.Point(102, 19);
            this.cb_webcam.Name = "cb_webcam";
            this.cb_webcam.Size = new System.Drawing.Size(264, 25);
            this.cb_webcam.TabIndex = 3;
            this.cb_webcam.SelectedIndexChanged += new System.EventHandler(this.cb_webcam_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Webcam";
            // 
            // picWebcam
            // 
            this.picWebcam.BackColor = System.Drawing.Color.White;
            this.picWebcam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picWebcam.Location = new System.Drawing.Point(0, 58);
            this.picWebcam.Name = "picWebcam";
            this.picWebcam.Size = new System.Drawing.Size(982, 420);
            this.picWebcam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWebcam.TabIndex = 25;
            this.picWebcam.TabStop = false;
            // 
            // FormWebcam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 478);
            this.Controls.Add(this.picWebcam);
            this.Controls.Add(this.panelLogo);
            this.Name = "FormWebcam";
            this.Text = "Facemesh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormWebcam_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormWebcam_FormClosed);
            this.Load += new System.EventHandler(this.FormWebcam_Load);
            this.SizeChanged += new System.EventHandler(this.FormWebcam_SizeChanged);
            this.VisibleChanged += new System.EventHandler(this.FormWebcam_VisibleChanged);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWebcam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timerClear;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_webcam;
        private System.Windows.Forms.PictureBox picWebcam;
        private System.Windows.Forms.Label lbl_result;
        private TGMTcontrols.ProcessingControl circle1;
        private TGMTcontrols.DefaultButton btn_save;
        private System.Windows.Forms.ComboBox cb_resolution;
        private TGMTcontrols.DefaultButton btn_start;
    }
}

