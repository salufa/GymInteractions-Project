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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pool));
            this.btnSwim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSwim
            // 
            this.btnSwim.Location = new System.Drawing.Point(718, 482);
            this.btnSwim.Name = "btnSwim";
            this.btnSwim.Size = new System.Drawing.Size(223, 73);
            this.btnSwim.TabIndex = 0;
            this.btnSwim.Text = "button1";
            this.btnSwim.UseVisualStyleBackColor = true;
            this.btnSwim.Click += new System.EventHandler(this.btnSwim_Click);
            // 
            // Pool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1317, 567);
            this.Controls.Add(this.btnSwim);
            this.Name = "Pool";
            this.Text = "Pool";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSwim;

    }
}