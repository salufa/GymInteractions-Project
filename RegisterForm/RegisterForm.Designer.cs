namespace RegisterForm
{
    partial class RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTxtText = new System.Windows.Forms.Label();
            this.GenderTxtText = new System.Windows.Forms.Label();
            this.nametxtBox = new System.Windows.Forms.TextBox();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.GenderTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register To Our Gym";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // passwordTxtText
            // 
            this.passwordTxtText.AutoSize = true;
            this.passwordTxtText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtText.Location = new System.Drawing.Point(11, 113);
            this.passwordTxtText.Name = "passwordTxtText";
            this.passwordTxtText.Size = new System.Drawing.Size(92, 24);
            this.passwordTxtText.TabIndex = 2;
            this.passwordTxtText.Text = "Password";
            // 
            // GenderTxtText
            // 
            this.GenderTxtText.AutoSize = true;
            this.GenderTxtText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderTxtText.Location = new System.Drawing.Point(11, 179);
            this.GenderTxtText.Name = "GenderTxtText";
            this.GenderTxtText.Size = new System.Drawing.Size(74, 24);
            this.GenderTxtText.TabIndex = 3;
            this.GenderTxtText.Text = "Gender";
            // 
            // nametxtBox
            // 
            this.nametxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxtBox.Location = new System.Drawing.Point(78, 48);
            this.nametxtBox.Name = "nametxtBox";
            this.nametxtBox.Size = new System.Drawing.Size(221, 29);
            this.nametxtBox.TabIndex = 4;
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtBox.Location = new System.Drawing.Point(109, 113);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(190, 29);
            this.passwordTxtBox.TabIndex = 5;
            // 
            // GenderTxtBox
            // 
            this.GenderTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderTxtBox.Location = new System.Drawing.Point(86, 179);
            this.GenderTxtBox.Name = "GenderTxtBox";
            this.GenderTxtBox.Size = new System.Drawing.Size(213, 29);
            this.GenderTxtBox.TabIndex = 6;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 286);
            this.Controls.Add(this.GenderTxtBox);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.nametxtBox);
            this.Controls.Add(this.GenderTxtText);
            this.Controls.Add(this.passwordTxtText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label passwordTxtText;
        private System.Windows.Forms.Label GenderTxtText;
        private System.Windows.Forms.TextBox nametxtBox;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.TextBox GenderTxtBox;
    }
}