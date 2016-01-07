namespace Gym_Interactions
{
    partial class Gym
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gym));
            this.btnBike = new System.Windows.Forms.Button();
            this.btnTreadMill = new System.Windows.Forms.Button();
            this.btnSkata = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBike
            // 
            this.btnBike.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnBike.ForeColor = System.Drawing.Color.Blue;
            this.btnBike.Location = new System.Drawing.Point(207, 194);
            this.btnBike.Name = "btnBike";
            this.btnBike.Size = new System.Drawing.Size(162, 250);
            this.btnBike.TabIndex = 0;
            this.btnBike.Text = "BICYCLE";
            this.btnBike.UseVisualStyleBackColor = true;
            this.btnBike.Click += new System.EventHandler(this.btnBicycle_Click);
            // 
            // btnTreadMill
            // 
            this.btnTreadMill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnTreadMill.ForeColor = System.Drawing.Color.Blue;
            this.btnTreadMill.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTreadMill.Location = new System.Drawing.Point(478, 240);
            this.btnTreadMill.Name = "btnTreadMill";
            this.btnTreadMill.Size = new System.Drawing.Size(208, 152);
            this.btnTreadMill.TabIndex = 1;
            this.btnTreadMill.Text = "TREADMILL";
            this.btnTreadMill.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTreadMill.UseVisualStyleBackColor = true;
            // 
            // btnSkata
            // 
            this.btnSkata.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnSkata.ForeColor = System.Drawing.Color.Blue;
            this.btnSkata.Location = new System.Drawing.Point(927, 44);
            this.btnSkata.Name = "btnSkata";
            this.btnSkata.Size = new System.Drawing.Size(166, 371);
            this.btnSkata.TabIndex = 2;
            this.btnSkata.Text = "MACHINES";
            this.btnSkata.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(711, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 84);
            this.button1.TabIndex = 3;
            this.button1.Text = "WEIGHT LIFTING";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Gym
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1125, 456);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSkata);
            this.Controls.Add(this.btnTreadMill);
            this.Controls.Add(this.btnBike);
            this.Name = "Gym";
            this.Text = "MainRoom";
            this.Load += new System.EventHandler(this.Gym_Load);
            this.Controls.SetChildIndex(this.btnBike, 0);
            this.Controls.SetChildIndex(this.btnTreadMill, 0);
            this.Controls.SetChildIndex(this.btnSkata, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBike;
        private System.Windows.Forms.Button btnTreadMill;
        private System.Windows.Forms.Button btnSkata;
        private System.Windows.Forms.Button button1;
    }
}