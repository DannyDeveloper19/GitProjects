namespace Security
{
    partial class CameraControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.trbBrightness = new System.Windows.Forms.TrackBar();
            this.trbContrast = new System.Windows.Forms.TrackBar();
            this.trbGamma = new System.Windows.Forms.TrackBar();
            this.ckbBrightness = new System.Windows.Forms.CheckBox();
            this.ckbContrast = new System.Windows.Forms.CheckBox();
            this.ckbGamma = new System.Windows.Forms.CheckBox();
            this.cmbDevices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBrightness = new System.Windows.Forms.Label();
            this.lblContrast = new System.Windows.Forms.Label();
            this.lblGamma = new System.Windows.Forms.Label();
            this.btnCapture = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trbBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // trbBrightness
            // 
            this.trbBrightness.Location = new System.Drawing.Point(480, 28);
            this.trbBrightness.Maximum = 255;
            this.trbBrightness.Minimum = -255;
            this.trbBrightness.Name = "trbBrightness";
            this.trbBrightness.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trbBrightness.Size = new System.Drawing.Size(45, 317);
            this.trbBrightness.TabIndex = 1;
            this.trbBrightness.Scroll += new System.EventHandler(this.trbBrightness_Scroll);
            // 
            // trbContrast
            // 
            this.trbContrast.Location = new System.Drawing.Point(555, 28);
            this.trbContrast.Maximum = 127;
            this.trbContrast.Minimum = -127;
            this.trbContrast.Name = "trbContrast";
            this.trbContrast.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trbContrast.Size = new System.Drawing.Size(45, 317);
            this.trbContrast.TabIndex = 2;
            this.trbContrast.Scroll += new System.EventHandler(this.trbContrast_Scroll);
            // 
            // trbGamma
            // 
            this.trbGamma.Location = new System.Drawing.Point(638, 28);
            this.trbGamma.Maximum = 5;
            this.trbGamma.Name = "trbGamma";
            this.trbGamma.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trbGamma.Size = new System.Drawing.Size(45, 317);
            this.trbGamma.TabIndex = 3;
            this.trbGamma.Scroll += new System.EventHandler(this.trbGamma_Scroll);
            // 
            // ckbBrightness
            // 
            this.ckbBrightness.AutoSize = true;
            this.ckbBrightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbBrightness.Location = new System.Drawing.Point(13, 107);
            this.ckbBrightness.Name = "ckbBrightness";
            this.ckbBrightness.Size = new System.Drawing.Size(94, 19);
            this.ckbBrightness.TabIndex = 4;
            this.ckbBrightness.Text = "Brightness";
            this.ckbBrightness.UseVisualStyleBackColor = true;
            // 
            // ckbContrast
            // 
            this.ckbContrast.AutoSize = true;
            this.ckbContrast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbContrast.Location = new System.Drawing.Point(13, 163);
            this.ckbContrast.Name = "ckbContrast";
            this.ckbContrast.Size = new System.Drawing.Size(79, 19);
            this.ckbContrast.TabIndex = 5;
            this.ckbContrast.Text = "Contrast";
            this.ckbContrast.UseVisualStyleBackColor = true;
            // 
            // ckbGamma
            // 
            this.ckbGamma.AutoSize = true;
            this.ckbGamma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbGamma.Location = new System.Drawing.Point(13, 220);
            this.ckbGamma.Name = "ckbGamma";
            this.ckbGamma.Size = new System.Drawing.Size(76, 19);
            this.ckbGamma.TabIndex = 6;
            this.ckbGamma.Text = "Gamma";
            this.ckbGamma.UseVisualStyleBackColor = true;
            // 
            // cmbDevices
            // 
            this.cmbDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDevices.FormattingEnabled = true;
            this.cmbDevices.Location = new System.Drawing.Point(205, 28);
            this.cmbDevices.Name = "cmbDevices";
            this.cmbDevices.Size = new System.Drawing.Size(207, 24);
            this.cmbDevices.TabIndex = 8;
            this.cmbDevices.SelectedIndexChanged += new System.EventHandler(this.cmbDevices_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Devices:";
            // 
            // lblBrightness
            // 
            this.lblBrightness.AutoSize = true;
            this.lblBrightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrightness.Location = new System.Drawing.Point(488, 348);
            this.lblBrightness.Name = "lblBrightness";
            this.lblBrightness.Size = new System.Drawing.Size(15, 16);
            this.lblBrightness.TabIndex = 13;
            this.lblBrightness.Text = "0";
            // 
            // lblContrast
            // 
            this.lblContrast.AutoSize = true;
            this.lblContrast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrast.Location = new System.Drawing.Point(564, 348);
            this.lblContrast.Name = "lblContrast";
            this.lblContrast.Size = new System.Drawing.Size(15, 16);
            this.lblContrast.TabIndex = 14;
            this.lblContrast.Text = "0";
            // 
            // lblGamma
            // 
            this.lblGamma.AutoSize = true;
            this.lblGamma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamma.Location = new System.Drawing.Point(647, 348);
            this.lblGamma.Name = "lblGamma";
            this.lblGamma.Size = new System.Drawing.Size(15, 16);
            this.lblGamma.TabIndex = 15;
            this.lblGamma.Text = "0";
            // 
            // btnCapture
            // 
            this.btnCapture.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapture.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCapture.Location = new System.Drawing.Point(283, 304);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(129, 40);
            this.btnCapture.TabIndex = 7;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = false;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRefresh.Location = new System.Drawing.Point(133, 304);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(129, 40);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Security.Properties.Resources.Gama;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(648, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 15);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Security.Properties.Resources.contrast;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(567, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Security.Properties.Resources.brightness;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(487, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ptbImage
            // 
            this.ptbImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ptbImage.Location = new System.Drawing.Point(113, 58);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(320, 240);
            this.ptbImage.TabIndex = 0;
            this.ptbImage.TabStop = false;
            // 
            // CameraControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblGamma);
            this.Controls.Add(this.lblContrast);
            this.Controls.Add(this.lblBrightness);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDevices);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.ckbGamma);
            this.Controls.Add(this.ckbContrast);
            this.Controls.Add(this.ckbBrightness);
            this.Controls.Add(this.trbGamma);
            this.Controls.Add(this.trbContrast);
            this.Controls.Add(this.trbBrightness);
            this.Controls.Add(this.ptbImage);
            this.Name = "CameraControl";
            this.Size = new System.Drawing.Size(707, 383);
            this.Load += new System.EventHandler(this.CameraControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbImage;
        private System.Windows.Forms.TrackBar trbBrightness;
        private System.Windows.Forms.TrackBar trbContrast;
        private System.Windows.Forms.TrackBar trbGamma;
        private System.Windows.Forms.CheckBox ckbBrightness;
        private System.Windows.Forms.CheckBox ckbContrast;
        private System.Windows.Forms.CheckBox ckbGamma;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.ComboBox cmbDevices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblBrightness;
        private System.Windows.Forms.Label lblContrast;
        private System.Windows.Forms.Label lblGamma;
        private System.Windows.Forms.Button btnRefresh;
    }
}
