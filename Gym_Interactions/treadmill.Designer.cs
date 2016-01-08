namespace Gym_Interactions
{
    partial class treadmill
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.treadmillStart = new System.Windows.Forms.Button();
            this.massCalculate = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.massTxtBox = new System.Windows.Forms.TextBox();
            this.heightTxtBox = new System.Windows.Forms.TextBox();
            this.heightBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ageTxtBox = new System.Windows.Forms.TextBox();
            this.ageBtn = new System.Windows.Forms.Button();
            this.suggestionTreadmill = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Times_Per_Week = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.food_programTxtBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suggestionTreadmill)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gym_Interactions.Properties.Resources.treadmill_panel;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(572, 538);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // treadmillStart
            // 
            this.treadmillStart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.treadmillStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treadmillStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.treadmillStart.Location = new System.Drawing.Point(255, 434);
            this.treadmillStart.Name = "treadmillStart";
            this.treadmillStart.Size = new System.Drawing.Size(82, 55);
            this.treadmillStart.TabIndex = 1;
            this.treadmillStart.Text = "Go";
            this.treadmillStart.UseVisualStyleBackColor = false;
            this.treadmillStart.Click += new System.EventHandler(this.treadmillStart_Click);
            // 
            // massCalculate
            // 
            this.massCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.massCalculate.Location = new System.Drawing.Point(603, 11);
            this.massCalculate.Name = "massCalculate";
            this.massCalculate.Size = new System.Drawing.Size(175, 35);
            this.massCalculate.TabIndex = 2;
            this.massCalculate.Text = "Calculate Mass";
            this.massCalculate.UseVisualStyleBackColor = true;
            this.massCalculate.Click += new System.EventHandler(this.massCalculate_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // massTxtBox
            // 
            this.massTxtBox.Enabled = false;
            this.massTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.massTxtBox.Location = new System.Drawing.Point(793, 11);
            this.massTxtBox.Name = "massTxtBox";
            this.massTxtBox.Size = new System.Drawing.Size(71, 35);
            this.massTxtBox.TabIndex = 4;
            // 
            // heightTxtBox
            // 
            this.heightTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightTxtBox.Location = new System.Drawing.Point(793, 58);
            this.heightTxtBox.Name = "heightTxtBox";
            this.heightTxtBox.Size = new System.Drawing.Size(71, 35);
            this.heightTxtBox.TabIndex = 6;
            // 
            // heightBtn
            // 
            this.heightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightBtn.Location = new System.Drawing.Point(603, 58);
            this.heightBtn.Name = "heightBtn";
            this.heightBtn.Size = new System.Drawing.Size(175, 32);
            this.heightBtn.TabIndex = 5;
            this.heightBtn.Text = "Enter Height";
            this.heightBtn.UseVisualStyleBackColor = true;
            this.heightBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(598, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Suggestions";
            // 
            // ageTxtBox
            // 
            this.ageTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageTxtBox.Location = new System.Drawing.Point(793, 105);
            this.ageTxtBox.Name = "ageTxtBox";
            this.ageTxtBox.Size = new System.Drawing.Size(71, 35);
            this.ageTxtBox.TabIndex = 9;
            // 
            // ageBtn
            // 
            this.ageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageBtn.Location = new System.Drawing.Point(603, 105);
            this.ageBtn.Name = "ageBtn";
            this.ageBtn.Size = new System.Drawing.Size(175, 32);
            this.ageBtn.TabIndex = 8;
            this.ageBtn.Text = "Enter Age";
            this.ageBtn.UseVisualStyleBackColor = true;
            this.ageBtn.Click += new System.EventHandler(this.ageBtn_Click);
            // 
            // suggestionTreadmill
            // 
            this.suggestionTreadmill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suggestionTreadmill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Speed,
            this.Times_Per_Week});
            this.suggestionTreadmill.Enabled = false;
            this.suggestionTreadmill.Location = new System.Drawing.Point(603, 182);
            this.suggestionTreadmill.Name = "suggestionTreadmill";
            this.suggestionTreadmill.Size = new System.Drawing.Size(346, 85);
            this.suggestionTreadmill.TabIndex = 10;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            // 
            // Speed
            // 
            this.Speed.HeaderText = "Speed";
            this.Speed.Name = "Speed";
            // 
            // Times_Per_Week
            // 
            this.Times_Per_Week.HeaderText = "Times_Per_Week";
            this.Times_Per_Week.Name = "Times_Per_Week";
            // 
            // food_programTxtBox
            // 
            this.food_programTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.food_programTxtBox.Location = new System.Drawing.Point(603, 306);
            this.food_programTxtBox.Name = "food_programTxtBox";
            this.food_programTxtBox.Size = new System.Drawing.Size(333, 148);
            this.food_programTxtBox.TabIndex = 11;
            this.food_programTxtBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(599, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Food Program";
            // 
            // treadmill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.food_programTxtBox);
            this.Controls.Add(this.suggestionTreadmill);
            this.Controls.Add(this.ageTxtBox);
            this.Controls.Add(this.ageBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.heightTxtBox);
            this.Controls.Add(this.heightBtn);
            this.Controls.Add(this.massTxtBox);
            this.Controls.Add(this.massCalculate);
            this.Controls.Add(this.treadmillStart);
            this.Controls.Add(this.pictureBox1);
            this.Name = "treadmill";
            this.Text = "treadmill";
            this.Load += new System.EventHandler(this.treadmill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suggestionTreadmill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button treadmillStart;
        private System.Windows.Forms.Button massCalculate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox massTxtBox;
        private System.Windows.Forms.TextBox heightTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button heightBtn;
        private System.Windows.Forms.TextBox ageTxtBox;
        private System.Windows.Forms.Button ageBtn;
        private System.Windows.Forms.DataGridView suggestionTreadmill;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Times_Per_Week;
        private System.Windows.Forms.RichTextBox food_programTxtBox;
        private System.Windows.Forms.Label label2;
    }
}