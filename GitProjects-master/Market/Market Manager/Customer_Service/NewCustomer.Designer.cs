namespace Market_Manager.Admission
{
    partial class NewCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCustomer));
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnCamera = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbState = new Security.ValidateComboBox();
            this.txtZipcode = new Security.ValidateTextBox();
            this.txtCity = new Security.ValidateTextBox();
            this.txtApt = new Security.ValidateTextBox();
            this.txtStreet = new Security.ValidateTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ptPicture = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new Security.ValidateTextBox();
            this.txtPhone = new Security.ValidateTextBox();
            this.txtLastname = new Security.ValidateTextBox();
            this.txtName = new Security.ValidateTextBox();
            this.txtDLN = new Security.ValidateTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(300, 422);
            this.btnCancel.Size = new System.Drawing.Size(129, 40);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(87, 422);
            this.btnAccept.Size = new System.Drawing.Size(129, 40);
            // 
            // btnUpload
            // 
            this.btnUpload.BackgroundImage = global::Market_Manager.Properties.Resources.Camera;
            this.btnUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpload.Location = new System.Drawing.Point(435, 226);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(40, 35);
            this.btnUpload.TabIndex = 43;
            this.btnUpload.UseVisualStyleBackColor = true;
            // 
            // btnCamera
            // 
            this.btnCamera.BackgroundImage = global::Market_Manager.Properties.Resources.upload;
            this.btnCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCamera.Location = new System.Drawing.Point(365, 226);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(40, 35);
            this.btnCamera.TabIndex = 42;
            this.btnCamera.UseVisualStyleBackColor = true;
            this.btnCamera.Click += new System.EventHandler(this.btnCamera_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbState);
            this.groupBox1.Controls.Add(this.txtZipcode);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.txtApt);
            this.groupBox1.Controls.Add(this.txtStreet);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 124);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address";
            // 
            // cmbState
            // 
            this.cmbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(84, 90);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(138, 26);
            this.cmbState.TabIndex = 51;
            this.cmbState.Validate = true;
            // 
            // txtZipcode
            // 
            this.txtZipcode.Email = false;
            this.txtZipcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZipcode.Letters = false;
            this.txtZipcode.Location = new System.Drawing.Point(350, 90);
            this.txtZipcode.MaxLength = 5;
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.Numbers = true;
            this.txtZipcode.Password = false;
            this.txtZipcode.Size = new System.Drawing.Size(84, 24);
            this.txtZipcode.TabIndex = 50;
            this.txtZipcode.Validate = true;
            // 
            // txtCity
            // 
            this.txtCity.Email = false;
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Letters = true;
            this.txtCity.Location = new System.Drawing.Point(274, 58);
            this.txtCity.Name = "txtCity";
            this.txtCity.Numbers = false;
            this.txtCity.Password = false;
            this.txtCity.Size = new System.Drawing.Size(160, 24);
            this.txtCity.TabIndex = 49;
            this.txtCity.Validate = true;
            // 
            // txtApt
            // 
            this.txtApt.Email = false;
            this.txtApt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApt.Letters = false;
            this.txtApt.Location = new System.Drawing.Point(123, 58);
            this.txtApt.Name = "txtApt";
            this.txtApt.Numbers = false;
            this.txtApt.Password = false;
            this.txtApt.Size = new System.Drawing.Size(99, 24);
            this.txtApt.TabIndex = 48;
            this.txtApt.Validate = false;
            // 
            // txtStreet
            // 
            this.txtStreet.Email = false;
            this.txtStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet.Letters = false;
            this.txtStreet.Location = new System.Drawing.Point(84, 23);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Numbers = false;
            this.txtStreet.Password = false;
            this.txtStreet.Size = new System.Drawing.Size(350, 24);
            this.txtStreet.TabIndex = 47;
            this.txtStreet.Validate = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "State:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(270, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Zipcode:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(235, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "City:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Apt (Optional):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Street:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(36, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Email:";
            // 
            // ptPicture
            // 
            this.ptPicture.BackgroundImage = global::Market_Manager.Properties.Resources.user_person;
            this.ptPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptPicture.Location = new System.Drawing.Point(345, 46);
            this.ptPicture.Name = "ptPicture";
            this.ptPicture.Size = new System.Drawing.Size(146, 171);
            this.ptPicture.TabIndex = 32;
            this.ptPicture.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(37, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(31, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(15, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Lastname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(43, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "DLN:";
            // 
            // txtEmail
            // 
            this.txtEmail.Email = true;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Letters = false;
            this.txtEmail.Location = new System.Drawing.Point(87, 227);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Numbers = false;
            this.txtEmail.Password = false;
            this.txtEmail.Size = new System.Drawing.Size(203, 24);
            this.txtEmail.TabIndex = 50;
            this.txtEmail.Validate = true;
            // 
            // txtPhone
            // 
            this.txtPhone.Email = false;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Letters = false;
            this.txtPhone.Location = new System.Drawing.Point(87, 182);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Numbers = true;
            this.txtPhone.Password = false;
            this.txtPhone.Size = new System.Drawing.Size(203, 24);
            this.txtPhone.TabIndex = 49;
            this.txtPhone.Validate = true;
            // 
            // txtLastname
            // 
            this.txtLastname.Email = false;
            this.txtLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.Letters = true;
            this.txtLastname.Location = new System.Drawing.Point(87, 134);
            this.txtLastname.Multiline = true;
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Numbers = false;
            this.txtLastname.Password = false;
            this.txtLastname.Size = new System.Drawing.Size(203, 24);
            this.txtLastname.TabIndex = 48;
            this.txtLastname.Validate = true;
            this.txtLastname.TextChanged += new System.EventHandler(this.txtLastname_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Email = false;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Letters = true;
            this.txtName.Location = new System.Drawing.Point(87, 89);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Numbers = false;
            this.txtName.Password = false;
            this.txtName.Size = new System.Drawing.Size(203, 24);
            this.txtName.TabIndex = 47;
            this.txtName.Validate = true;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtDLN
            // 
            this.txtDLN.Email = false;
            this.txtDLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDLN.Letters = false;
            this.txtDLN.Location = new System.Drawing.Point(87, 42);
            this.txtDLN.MaxLength = 8;
            this.txtDLN.Multiline = true;
            this.txtDLN.Name = "txtDLN";
            this.txtDLN.Numbers = false;
            this.txtDLN.Password = false;
            this.txtDLN.Size = new System.Drawing.Size(203, 24);
            this.txtDLN.TabIndex = 46;
            this.txtDLN.Validate = true;
            // 
            // NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 490);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDLN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnCamera);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptPicture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(544, 529);
            this.MinimumSize = new System.Drawing.Size(544, 529);
            this.Name = "NewCustomer";
            this.Text = "New Customer";
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.ptPicture, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnCamera, 0);
            this.Controls.SetChildIndex(this.btnUpload, 0);
            this.Controls.SetChildIndex(this.btnAccept, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtDLN, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.txtLastname, 0);
            this.Controls.SetChildIndex(this.txtPhone, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnCamera;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptPicture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Security.ValidateTextBox txtDLN;
        private Security.ValidateTextBox txtName;
        private Security.ValidateTextBox txtLastname;
        private Security.ValidateTextBox txtPhone;
        private Security.ValidateTextBox txtEmail;
        private Security.ValidateTextBox txtStreet;
        private Security.ValidateTextBox txtZipcode;
        private Security.ValidateTextBox txtCity;
        private Security.ValidateTextBox txtApt;
        private Security.ValidateComboBox cmbState;
    }
}