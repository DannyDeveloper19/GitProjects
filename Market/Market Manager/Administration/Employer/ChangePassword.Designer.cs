namespace Market_Manager.Administration.Employer
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new Security.ValidateTextBox();
            this.txtNewPassword = new Security.ValidateTextBox();
            this.txtCurentPassword = new Security.ValidateTextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Location = new System.Drawing.Point(200, 192);
            this.btnCancel.Size = new System.Drawing.Size(129, 38);
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAccept.Location = new System.Drawing.Point(43, 192);
            this.btnAccept.Size = new System.Drawing.Size(129, 38);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Current password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "New password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Confirm password:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Email = false;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Letters = false;
            this.txtConfirmPassword.Location = new System.Drawing.Point(132, 134);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Numbers = false;
            this.txtConfirmPassword.Password = true;
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(197, 24);
            this.txtConfirmPassword.TabIndex = 22;
            this.txtConfirmPassword.Validate = true;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Email = false;
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Letters = false;
            this.txtNewPassword.Location = new System.Drawing.Point(132, 86);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Numbers = false;
            this.txtNewPassword.Password = true;
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(197, 24);
            this.txtNewPassword.TabIndex = 21;
            this.txtNewPassword.Validate = true;
            // 
            // txtCurentPassword
            // 
            this.txtCurentPassword.Email = false;
            this.txtCurentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurentPassword.Letters = false;
            this.txtCurentPassword.Location = new System.Drawing.Point(132, 38);
            this.txtCurentPassword.Name = "txtCurentPassword";
            this.txtCurentPassword.Numbers = false;
            this.txtCurentPassword.Password = false;
            this.txtCurentPassword.PasswordChar = '*';
            this.txtCurentPassword.Size = new System.Drawing.Size(197, 24);
            this.txtCurentPassword.TabIndex = 20;
            this.txtCurentPassword.Validate = true;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(375, 276);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtCurentPassword);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePassword";
            this.Text = "Change Password";
            this.Controls.SetChildIndex(this.btnAccept, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.txtCurentPassword, 0);
            this.Controls.SetChildIndex(this.txtNewPassword, 0);
            this.Controls.SetChildIndex(this.txtConfirmPassword, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Security.ValidateTextBox txtCurentPassword;
        private Security.ValidateTextBox txtNewPassword;
        private Security.ValidateTextBox txtConfirmPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
