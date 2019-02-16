namespace Market_Manager.Administration
{
    partial class NewEmployer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewEmployer));
            this.txtEmail = new Security.ValidateTextBox();
            this.txtPhone = new Security.ValidateTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLastname = new Security.ValidateTextBox();
            this.txtName = new Security.ValidateTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnCamera = new System.Windows.Forms.Button();
            this.ptPicture = new System.Windows.Forms.PictureBox();
            this.cmbRole = new Security.ValidateComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbState = new Security.ValidateComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtZipcode = new Security.ValidateTextBox();
            this.txtCity = new Security.ValidateTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtApt = new Security.ValidateTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtStreet = new Security.ValidateTextBox();
            this.txtDLN = new Security.ValidateTextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptPicture)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(300, 422);
            this.btnCancel.Size = new System.Drawing.Size(129, 40);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(87, 422);
            this.btnAccept.Size = new System.Drawing.Size(129, 40);
            // 
            // txtEmail
            // 
            this.txtEmail.Email = true;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Letters = false;
            this.txtEmail.Location = new System.Drawing.Point(94, 207);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Numbers = false;
            this.txtEmail.Password = false;
            this.txtEmail.Size = new System.Drawing.Size(203, 24);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Validate = true;
            // 
            // txtPhone
            // 
            this.txtPhone.Email = false;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Letters = false;
            this.txtPhone.Location = new System.Drawing.Point(93, 164);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Numbers = true;
            this.txtPhone.Password = false;
            this.txtPhone.Size = new System.Drawing.Size(203, 24);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.Validate = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(37, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phone:";
            // 
            // txtLastname
            // 
            this.txtLastname.Email = false;
            this.txtLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.Letters = true;
            this.txtLastname.Location = new System.Drawing.Point(94, 117);
            this.txtLastname.Multiline = true;
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Numbers = false;
            this.txtLastname.Password = false;
            this.txtLastname.Size = new System.Drawing.Size(203, 24);
            this.txtLastname.TabIndex = 2;
            this.txtLastname.Validate = true;
            // 
            // txtName
            // 
            this.txtName.Email = false;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Letters = true;
            this.txtName.Location = new System.Drawing.Point(94, 71);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Numbers = false;
            this.txtName.Password = false;
            this.txtName.Size = new System.Drawing.Size(203, 24);
            this.txtName.TabIndex = 1;
            this.txtName.Validate = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(47, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Role:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(17, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Lastname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(40, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(42, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Email:";
            // 
            // btnUpload
            // 
            this.btnUpload.BackgroundImage = global::Market_Manager.Properties.Resources.Camera;
            this.btnUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpload.Location = new System.Drawing.Point(439, 216);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(40, 35);
            this.btnUpload.TabIndex = 27;
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click_1);
            // 
            // btnCamera
            // 
            this.btnCamera.BackgroundImage = global::Market_Manager.Properties.Resources.upload;
            this.btnCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCamera.Location = new System.Drawing.Point(373, 216);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(40, 35);
            this.btnCamera.TabIndex = 26;
            this.btnCamera.UseVisualStyleBackColor = true;
            // 
            // ptPicture
            // 
            this.ptPicture.BackgroundImage = global::Market_Manager.Properties.Resources.user_person;
            this.ptPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptPicture.Location = new System.Drawing.Point(350, 39);
            this.ptPicture.Name = "ptPicture";
            this.ptPicture.Size = new System.Drawing.Size(146, 171);
            this.ptPicture.TabIndex = 11;
            this.ptPicture.TabStop = false;
            // 
            // cmbRole
            // 
            this.cmbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(93, 251);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(96, 26);
            this.cmbRole.TabIndex = 5;
            this.cmbRole.Validate = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cmbState);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtZipcode);
            this.groupBox2.Controls.Add(this.txtCity);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtApt);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtStreet);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 132);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "State:";
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(71, 89);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(138, 26);
            this.cmbState.TabIndex = 9;
            this.cmbState.Validate = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(305, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 16);
            this.label12.TabIndex = 7;
            this.label12.Text = "Zipcode:";
            // 
            // txtZipcode
            // 
            this.txtZipcode.Email = false;
            this.txtZipcode.Letters = false;
            this.txtZipcode.Location = new System.Drawing.Point(372, 91);
            this.txtZipcode.MaxLength = 5;
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.Numbers = true;
            this.txtZipcode.Password = false;
            this.txtZipcode.Size = new System.Drawing.Size(75, 24);
            this.txtZipcode.TabIndex = 10;
            this.txtZipcode.Validate = true;
            // 
            // txtCity
            // 
            this.txtCity.Email = false;
            this.txtCity.Letters = true;
            this.txtCity.Location = new System.Drawing.Point(296, 56);
            this.txtCity.Name = "txtCity";
            this.txtCity.Numbers = false;
            this.txtCity.Password = false;
            this.txtCity.Size = new System.Drawing.Size(151, 24);
            this.txtCity.TabIndex = 8;
            this.txtCity.Validate = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(257, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 16);
            this.label13.TabIndex = 4;
            this.label13.Text = "City:";
            // 
            // txtApt
            // 
            this.txtApt.Email = false;
            this.txtApt.Letters = false;
            this.txtApt.Location = new System.Drawing.Point(117, 56);
            this.txtApt.Name = "txtApt";
            this.txtApt.Numbers = false;
            this.txtApt.Password = false;
            this.txtApt.Size = new System.Drawing.Size(92, 24);
            this.txtApt.TabIndex = 7;
            this.txtApt.Validate = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(19, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 16);
            this.label14.TabIndex = 2;
            this.label14.Text = "Apt (Optional):";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(19, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 16);
            this.label15.TabIndex = 1;
            this.label15.Text = "Street:";
            // 
            // txtStreet
            // 
            this.txtStreet.Email = false;
            this.txtStreet.Letters = false;
            this.txtStreet.Location = new System.Drawing.Point(71, 23);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Numbers = false;
            this.txtStreet.Password = false;
            this.txtStreet.Size = new System.Drawing.Size(376, 24);
            this.txtStreet.TabIndex = 6;
            this.txtStreet.Validate = true;
            // 
            // txtDLN
            // 
            this.txtDLN.Email = false;
            this.txtDLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDLN.Letters = false;
            this.txtDLN.Location = new System.Drawing.Point(94, 26);
            this.txtDLN.MaxLength = 8;
            this.txtDLN.Multiline = true;
            this.txtDLN.Name = "txtDLN";
            this.txtDLN.Numbers = false;
            this.txtDLN.Password = false;
            this.txtDLN.Size = new System.Drawing.Size(203, 24);
            this.txtDLN.TabIndex = 0;
            this.txtDLN.Validate = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(50, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 47;
            this.label6.Text = "DLN:";
            // 
            // NewEmployer
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(528, 490);
            this.Controls.Add(this.txtDLN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnCamera);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.ptPicture);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(544, 529);
            this.MinimumSize = new System.Drawing.Size(544, 529);
            this.Name = "NewEmployer";
            this.Text = "New Employer";
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.ptPicture, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtLastname, 0);
            this.Controls.SetChildIndex(this.txtPhone, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.btnCamera, 0);
            this.Controls.SetChildIndex(this.btnUpload, 0);
            this.Controls.SetChildIndex(this.cmbRole, 0);
            this.Controls.SetChildIndex(this.btnAccept, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtDLN, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ptPicture)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Security.ValidateTextBox txtEmail;
        private Security.ValidateTextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private Security.ValidateTextBox txtLastname;
        private Security.ValidateTextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ptPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCamera;
        private System.Windows.Forms.Button btnUpload;
        private Security.ValidateComboBox cmbRole;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private Security.ValidateComboBox cmbState;
        private System.Windows.Forms.Label label12;
        private Security.ValidateTextBox txtZipcode;
        private Security.ValidateTextBox txtCity;
        private System.Windows.Forms.Label label13;
        private Security.ValidateTextBox txtApt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private Security.ValidateTextBox txtStreet;
        private Security.ValidateTextBox txtDLN;
        private System.Windows.Forms.Label label6;

    }
}