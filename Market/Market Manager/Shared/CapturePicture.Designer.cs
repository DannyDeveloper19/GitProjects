namespace Market_Manager.Shared
{
    partial class CapturePicture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CapturePicture));
            this.cameraControl1 = new Security.CameraControl();
            this.btnDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cameraControl1
            // 
            this.cameraControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cameraControl1.Location = new System.Drawing.Point(0, 0);
            this.cameraControl1.Name = "cameraControl1";
            this.cameraControl1.Size = new System.Drawing.Size(707, 409);
            this.cameraControl1.TabIndex = 0;
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.Green;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDone.Location = new System.Drawing.Point(228, 357);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(86, 40);
            this.btnDone.TabIndex = 1;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // CapturePicture
            // 
            this.AcceptButton = this.btnDone;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 409);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.cameraControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(723, 448);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(723, 448);
            this.Name = "CapturePicture";
            this.Text = "Capture Picture";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CapturePicture_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Security.CameraControl cameraControl1;
        private System.Windows.Forms.Button btnDone;
    }
}