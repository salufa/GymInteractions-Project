namespace Gym_Interactions
{
    partial class PoolSettings
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
            this.label3 = new System.Windows.Forms.Label();
            this.poolBrightnessTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.poolWaterLevelTxtBox = new System.Windows.Forms.TextBox();
            this.brightnessSet = new System.Windows.Forms.Button();
            this.waterLevelSet = new System.Windows.Forms.Button();
            this.picOriginal = new System.Windows.Forms.PictureBox();
            this.scrBrightness = new System.Windows.Forms.HScrollBar();
            this.lblBrightness = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pool  Settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Water Level Percentage";
            // 
            // poolBrightnessTxtBox
            // 
            this.poolBrightnessTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poolBrightnessTxtBox.Location = new System.Drawing.Point(358, 85);
            this.poolBrightnessTxtBox.Multiline = true;
            this.poolBrightnessTxtBox.Name = "poolBrightnessTxtBox";
            this.poolBrightnessTxtBox.Size = new System.Drawing.Size(54, 34);
            this.poolBrightnessTxtBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Set Brightness Level of the pool";
            // 
            // poolWaterLevelTxtBox
            // 
            this.poolWaterLevelTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poolWaterLevelTxtBox.Location = new System.Drawing.Point(358, 183);
            this.poolWaterLevelTxtBox.Multiline = true;
            this.poolWaterLevelTxtBox.Name = "poolWaterLevelTxtBox";
            this.poolWaterLevelTxtBox.Size = new System.Drawing.Size(54, 34);
            this.poolWaterLevelTxtBox.TabIndex = 4;
            // 
            // brightnessSet
            // 
            this.brightnessSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brightnessSet.Location = new System.Drawing.Point(444, 85);
            this.brightnessSet.Name = "brightnessSet";
            this.brightnessSet.Size = new System.Drawing.Size(75, 34);
            this.brightnessSet.TabIndex = 5;
            this.brightnessSet.Text = "set";
            this.brightnessSet.UseVisualStyleBackColor = true;
            this.brightnessSet.Click += new System.EventHandler(this.brightnessSet_Click);
            // 
            // waterLevelSet
            // 
            this.waterLevelSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waterLevelSet.Location = new System.Drawing.Point(444, 183);
            this.waterLevelSet.Name = "waterLevelSet";
            this.waterLevelSet.Size = new System.Drawing.Size(75, 34);
            this.waterLevelSet.TabIndex = 6;
            this.waterLevelSet.Text = "set";
            this.waterLevelSet.UseVisualStyleBackColor = true;
            // 
            // picOriginal
            // 
            this.picOriginal.Image = global::Gym_Interactions.Properties.Resources.Pool;
            this.picOriginal.Location = new System.Drawing.Point(348, 223);
            this.picOriginal.Name = "picOriginal";
            this.picOriginal.Size = new System.Drawing.Size(314, 93);
            this.picOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOriginal.TabIndex = 7;
            this.picOriginal.TabStop = false;
            this.picOriginal.Visible = false;
            // 
            // scrBrightness
            // 
            this.scrBrightness.Location = new System.Drawing.Point(365, 122);
            this.scrBrightness.Maximum = 500;
            this.scrBrightness.Minimum = 1;
            this.scrBrightness.Name = "scrBrightness";
            this.scrBrightness.Size = new System.Drawing.Size(300, 17);
            this.scrBrightness.TabIndex = 11;
            this.scrBrightness.Value = 1;
            this.scrBrightness.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrBrightness_Scroll);
            // 
            // lblBrightness
            // 
            this.lblBrightness.Location = new System.Drawing.Point(49, 122);
            this.lblBrightness.Name = "lblBrightness";
            this.lblBrightness.Size = new System.Drawing.Size(303, 19);
            this.lblBrightness.TabIndex = 12;
            this.lblBrightness.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PoolSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 328);
            this.Controls.Add(this.lblBrightness);
            this.Controls.Add(this.scrBrightness);
            this.Controls.Add(this.picOriginal);
            this.Controls.Add(this.waterLevelSet);
            this.Controls.Add(this.brightnessSet);
            this.Controls.Add(this.poolWaterLevelTxtBox);
            this.Controls.Add(this.poolBrightnessTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PoolSettings";
            this.Text = "te";
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox poolBrightnessTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox poolWaterLevelTxtBox;
        private System.Windows.Forms.Button brightnessSet;
        private System.Windows.Forms.Button waterLevelSet;
        private System.Windows.Forms.HScrollBar scrBrightness;
        private System.Windows.Forms.Label lblBrightness;
        public System.Windows.Forms.PictureBox picOriginal;
    }
}