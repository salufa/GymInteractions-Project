namespace Gym_Interactions
{
    partial class Reception
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reception));
            this.label1 = new System.Windows.Forms.Label();
            this.radioRegisterYes = new System.Windows.Forms.RadioButton();
            this.radioRegisterNo = new System.Windows.Forms.RadioButton();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnPool = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.helpbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(711, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you a registered user?";
            // 
            // radioRegisterYes
            // 
            this.radioRegisterYes.AutoSize = true;
            this.radioRegisterYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRegisterYes.Location = new System.Drawing.Point(715, 32);
            this.radioRegisterYes.Name = "radioRegisterYes";
            this.radioRegisterYes.Size = new System.Drawing.Size(55, 24);
            this.radioRegisterYes.TabIndex = 1;
            this.radioRegisterYes.Text = "Yes";
            this.radioRegisterYes.UseVisualStyleBackColor = true;
            this.radioRegisterYes.CheckedChanged += new System.EventHandler(this.radioRegisterYes_CheckedChanged);
            // 
            // radioRegisterNo
            // 
            this.radioRegisterNo.AutoSize = true;
            this.radioRegisterNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRegisterNo.Location = new System.Drawing.Point(821, 32);
            this.radioRegisterNo.Name = "radioRegisterNo";
            this.radioRegisterNo.Size = new System.Drawing.Size(47, 24);
            this.radioRegisterNo.TabIndex = 2;
            this.radioRegisterNo.Text = "No";
            this.radioRegisterNo.UseVisualStyleBackColor = true;
            this.radioRegisterNo.CheckedChanged += new System.EventHandler(this.radioRegisterNo_CheckedChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.Enabled = false;
            this.btnRegister.Location = new System.Drawing.Point(821, 71);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Enabled = false;
            this.btnLogIn.Location = new System.Drawing.Point(715, 70);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(75, 23);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnPool
            // 
            this.btnPool.Location = new System.Drawing.Point(645, 126);
            this.btnPool.Name = "btnPool";
            this.btnPool.Size = new System.Drawing.Size(63, 226);
            this.btnPool.TabIndex = 5;
            this.btnPool.Text = "to Pool";
            this.btnPool.UseVisualStyleBackColor = true;
            this.btnPool.Click += new System.EventHandler(this.btnPool_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 140);
            this.button2.TabIndex = 6;
            this.button2.Text = "to gym";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnGym_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(241, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 75);
            this.button3.TabIndex = 7;
            this.button3.Text = "to bar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnBar_CLick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(568, 126);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 202);
            this.button4.TabIndex = 8;
            this.button4.Text = "to locker room";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnLockers_Click);
            // 
            // helpbtn
            // 
            this.helpbtn.Location = new System.Drawing.Point(714, 99);
            this.helpbtn.Name = "helpbtn";
            this.helpbtn.Size = new System.Drawing.Size(75, 23);
            this.helpbtn.TabIndex = 9;
            this.helpbtn.Text = "onLine Help";
            this.helpbtn.UseVisualStyleBackColor = true;
            this.helpbtn.Click += new System.EventHandler(this.helpbtn_Click);
            // 
            // Reception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(909, 359);
            this.Controls.Add(this.helpbtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.radioRegisterNo);
            this.Controls.Add(this.radioRegisterYes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPool);
            this.Name = "Reception";
            this.Text = "Reception";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Reception_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioRegisterYes;
        private System.Windows.Forms.RadioButton radioRegisterNo;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnPool;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button helpbtn;
    }
}

