﻿namespace Gym_Interactions
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
            this.btnBike.Location = new System.Drawing.Point(207, 194);
            this.btnBike.Name = "btnBike";
            this.btnBike.Size = new System.Drawing.Size(162, 250);
            this.btnBike.TabIndex = 0;
            this.btnBike.Text = "bicycle";
            this.btnBike.UseVisualStyleBackColor = true;
            this.btnBike.Click += new System.EventHandler(this.btnBicycle_Click);
            // 
            // btnTreadMill
            // 
            this.btnTreadMill.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTreadMill.Location = new System.Drawing.Point(463, 251);
            this.btnTreadMill.Name = "btnTreadMill";
            this.btnTreadMill.Size = new System.Drawing.Size(208, 134);
            this.btnTreadMill.TabIndex = 1;
            this.btnTreadMill.Text = "treadmill";
            this.btnTreadMill.UseVisualStyleBackColor = true;
            this.btnTreadMill.Click += new System.EventHandler(this.btnTreadMill_Click_1);
            // 
            // btnSkata
            // 
            this.btnSkata.Location = new System.Drawing.Point(927, 44);
            this.btnSkata.Name = "btnSkata";
            this.btnSkata.Size = new System.Drawing.Size(166, 371);
            this.btnSkata.TabIndex = 2;
            this.btnSkata.Text = "button3";
            this.btnSkata.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(711, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "weight lifting";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBike;
        private System.Windows.Forms.Button btnTreadMill;
        private System.Windows.Forms.Button btnSkata;
        private System.Windows.Forms.Button button1;
    }
}