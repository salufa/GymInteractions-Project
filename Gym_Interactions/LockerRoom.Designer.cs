namespace Gym_Interactions
{
    partial class LockerRoom
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
            this.btnSauna = new System.Windows.Forms.Button();
            this.btnShower = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSauna
            // 
            this.btnSauna.Location = new System.Drawing.Point(192, 145);
            this.btnSauna.Name = "btnSauna";
            this.btnSauna.Size = new System.Drawing.Size(49, 95);
            this.btnSauna.TabIndex = 0;
            this.btnSauna.Text = "button1";
            this.btnSauna.UseVisualStyleBackColor = true;
            this.btnSauna.Click += new System.EventHandler(this.btnSauna_Click);
            // 
            // btnShower
            // 
            this.btnShower.Location = new System.Drawing.Point(117, 145);
            this.btnShower.Name = "btnShower";
            this.btnShower.Size = new System.Drawing.Size(49, 93);
            this.btnShower.TabIndex = 1;
            this.btnShower.Text = "button2";
            this.btnShower.UseVisualStyleBackColor = true;
            this.btnShower.Click += new System.EventHandler(this.btnShower_Click);
            // 
            // LockerRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gym_Interactions.Properties.Resources.nonslip_locker_room2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(742, 391);
            this.Controls.Add(this.btnShower);
            this.Controls.Add(this.btnSauna);
            this.Name = "LockerRoom";
            this.Text = "LockerRoom";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSauna;
        private System.Windows.Forms.Button btnShower;
    }
}