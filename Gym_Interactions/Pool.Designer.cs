namespace Gym_Interactions
{
    partial class Pool
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
            this.swimBtn = new System.Windows.Forms.Button();
            this.picAdjusted = new System.Windows.Forms.PictureBox();
            this.scrBrightness = new System.Windows.Forms.HScrollBar();
            this.picOriginal = new System.Windows.Forms.PictureBox();
            this.lblBrightness = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scrWaterLevel = new System.Windows.Forms.HScrollBar();
            this.lblWaterLevel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.exitPoolBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.AlarmEnabler = new System.Windows.Forms.CheckBox();
            this.SensorOn = new System.Windows.Forms.RadioButton();
            this.SensorOff = new System.Windows.Forms.RadioButton();
            this.peopleInsidePoolBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAdjusted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // swimBtn
            // 
            this.swimBtn.Location = new System.Drawing.Point(355, 399);
            this.swimBtn.Name = "swimBtn";
            this.swimBtn.Size = new System.Drawing.Size(103, 45);
            this.swimBtn.TabIndex = 0;
            this.swimBtn.Text = "swim";
            this.swimBtn.UseVisualStyleBackColor = true;
            this.swimBtn.Click += new System.EventHandler(this.swimBtn_Click);
            // 
            // picAdjusted
            // 
            this.picAdjusted.Image = global::Gym_Interactions.Properties.Resources.Pool;
            this.picAdjusted.Location = new System.Drawing.Point(3, 2);
            this.picAdjusted.Name = "picAdjusted";
            this.picAdjusted.Size = new System.Drawing.Size(999, 561);
            this.picAdjusted.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdjusted.TabIndex = 3;
            this.picAdjusted.TabStop = false;
            this.picAdjusted.Click += new System.EventHandler(this.picAdjusted_Click);
            // 
            // scrBrightness
            // 
            this.scrBrightness.Location = new System.Drawing.Point(1005, 100);
            this.scrBrightness.Maximum = 500;
            this.scrBrightness.Minimum = 1;
            this.scrBrightness.Name = "scrBrightness";
            this.scrBrightness.Size = new System.Drawing.Size(300, 17);
            this.scrBrightness.TabIndex = 12;
            this.scrBrightness.Value = 1;
            this.scrBrightness.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrBrightness_Scroll);
            // 
            // picOriginal
            // 
            this.picOriginal.Image = global::Gym_Interactions.Properties.Resources.Pool;
            this.picOriginal.Location = new System.Drawing.Point(24, 44);
            this.picOriginal.Name = "picOriginal";
            this.picOriginal.Size = new System.Drawing.Size(314, 93);
            this.picOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOriginal.TabIndex = 13;
            this.picOriginal.TabStop = false;
            this.picOriginal.Visible = false;
            // 
            // lblBrightness
            // 
            this.lblBrightness.Location = new System.Drawing.Point(1002, 130);
            this.lblBrightness.Name = "lblBrightness";
            this.lblBrightness.Size = new System.Drawing.Size(303, 19);
            this.lblBrightness.TabIndex = 14;
            this.lblBrightness.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1009, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Light Adjustment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1009, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Water Level";
            // 
            // scrWaterLevel
            // 
            this.scrWaterLevel.Location = new System.Drawing.Point(1003, 196);
            this.scrWaterLevel.Name = "scrWaterLevel";
            this.scrWaterLevel.Size = new System.Drawing.Size(300, 17);
            this.scrWaterLevel.TabIndex = 17;
            this.scrWaterLevel.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrWaterLevel_Scroll);
            // 
            // lblWaterLevel
            // 
            this.lblWaterLevel.Location = new System.Drawing.Point(1002, 222);
            this.lblWaterLevel.Name = "lblWaterLevel";
            this.lblWaterLevel.Size = new System.Drawing.Size(303, 19);
            this.lblWaterLevel.TabIndex = 18;
            this.lblWaterLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1009, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Sensor";
            // 
            // exitPoolBtn
            // 
            this.exitPoolBtn.Location = new System.Drawing.Point(588, 463);
            this.exitPoolBtn.Name = "exitPoolBtn";
            this.exitPoolBtn.Size = new System.Drawing.Size(103, 45);
            this.exitPoolBtn.TabIndex = 20;
            this.exitPoolBtn.Text = "Exit Pool";
            this.exitPoolBtn.UseVisualStyleBackColor = true;
            this.exitPoolBtn.Click += new System.EventHandler(this.exitPoolBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1009, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Temperature Set";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(1008, 306);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown1.TabIndex = 23;
            this.numericUpDown1.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // AlarmEnabler
            // 
            this.AlarmEnabler.AutoSize = true;
            this.AlarmEnabler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmEnabler.Location = new System.Drawing.Point(1014, 435);
            this.AlarmEnabler.Name = "AlarmEnabler";
            this.AlarmEnabler.Size = new System.Drawing.Size(159, 29);
            this.AlarmEnabler.TabIndex = 26;
            this.AlarmEnabler.Text = "Enable Alarm";
            this.AlarmEnabler.UseVisualStyleBackColor = true;
            this.AlarmEnabler.CheckedChanged += new System.EventHandler(this.AlarmEnabler_CheckedChanged);
            // 
            // SensorOn
            // 
            this.SensorOn.AutoSize = true;
            this.SensorOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SensorOn.Location = new System.Drawing.Point(1095, 357);
            this.SensorOn.Name = "SensorOn";
            this.SensorOn.Size = new System.Drawing.Size(58, 29);
            this.SensorOn.TabIndex = 28;
            this.SensorOn.TabStop = true;
            this.SensorOn.Text = "On";
            this.SensorOn.UseVisualStyleBackColor = true;
            this.SensorOn.CheckedChanged += new System.EventHandler(this.SensorOn_CheckedChanged);
            // 
            // SensorOff
            // 
            this.SensorOff.AutoSize = true;
            this.SensorOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SensorOff.Location = new System.Drawing.Point(1159, 359);
            this.SensorOff.Name = "SensorOff";
            this.SensorOff.Size = new System.Drawing.Size(58, 29);
            this.SensorOff.TabIndex = 29;
            this.SensorOff.TabStop = true;
            this.SensorOff.Text = "Off";
            this.SensorOff.UseVisualStyleBackColor = true;
            this.SensorOff.CheckedChanged += new System.EventHandler(this.SensorOff_CheckedChanged);
            // 
            // peopleInsidePoolBtn
            // 
            this.peopleInsidePoolBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peopleInsidePoolBtn.Location = new System.Drawing.Point(1014, 388);
            this.peopleInsidePoolBtn.Name = "peopleInsidePoolBtn";
            this.peopleInsidePoolBtn.Size = new System.Drawing.Size(167, 41);
            this.peopleInsidePoolBtn.TabIndex = 30;
            this.peopleInsidePoolBtn.Text = "People Inside?";
            this.peopleInsidePoolBtn.UseVisualStyleBackColor = true;
            this.peopleInsidePoolBtn.Click += new System.EventHandler(this.peopleInsidePoolBtn_Click);
            // 
            // Pool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1312, 567);
            this.Controls.Add(this.peopleInsidePoolBtn);
            this.Controls.Add(this.SensorOff);
            this.Controls.Add(this.SensorOn);
            this.Controls.Add(this.AlarmEnabler);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exitPoolBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblWaterLevel);
            this.Controls.Add(this.scrWaterLevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBrightness);
            this.Controls.Add(this.picOriginal);
            this.Controls.Add(this.scrBrightness);
            this.Controls.Add(this.swimBtn);
            this.Controls.Add(this.picAdjusted);
            this.Name = "Pool";
            this.Text = "Pool";
            this.Load += new System.EventHandler(this.Pool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAdjusted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button swimBtn;
        public System.Windows.Forms.PictureBox picAdjusted;
        private System.Windows.Forms.HScrollBar scrBrightness;
        private System.Windows.Forms.Label lblBrightness;
        private System.Windows.Forms.PictureBox picOriginal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HScrollBar scrWaterLevel;
        private System.Windows.Forms.Label lblWaterLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button exitPoolBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox AlarmEnabler;
        private System.Windows.Forms.RadioButton SensorOn;
        private System.Windows.Forms.RadioButton SensorOff;
        private System.Windows.Forms.Button peopleInsidePoolBtn;
    }
}