namespace Gym_Interactions
{
    partial class Order
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.drinksListBox = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.foodListBox = new System.Windows.Forms.CheckedListBox();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelNight = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalCostTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CashRadioBtn = new System.Windows.Forms.RadioButton();
            this.CreditCardRadioBtn = new System.Windows.Forms.RadioButton();
            this.CompletePaymentBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.NameHolderTxtBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CCVTxtBox = new System.Windows.Forms.TextBox();
            this.CDNumberTxtBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dataSet1 = new System.Data.DataSet();
            this.dataSet2 = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gym_Interactions.Properties.Resources.byzarou;
            this.pictureBox1.Location = new System.Drawing.Point(12, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose between food or drink:";
            // 
            // drinksListBox
            // 
            this.drinksListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinksListBox.FormattingEnabled = true;
            this.drinksListBox.Items.AddRange(new object[] {
            "Coffee - 3 euros",
            "Enerrgy Drink - 4 euros",
            "Water -1 euro",
            "Vodka -7 euros",
            "Gin -7 euros",
            "Whiskey -7 euros",
            "Protein Shake - 6 euros"});
            this.drinksListBox.Location = new System.Drawing.Point(213, 55);
            this.drinksListBox.Name = "drinksListBox";
            this.drinksListBox.Size = new System.Drawing.Size(265, 186);
            this.drinksListBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Drinks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(481, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Food";
            // 
            // foodListBox
            // 
            this.foodListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodListBox.FormattingEnabled = true;
            this.foodListBox.Items.AddRange(new object[] {
            "Chicken - 10 euros",
            "Pasta - 7 euros",
            "Rice - 4 euros",
            "Steak -9 euros",
            "Hot Dog - 2 euros"});
            this.foodListBox.Location = new System.Drawing.Point(484, 55);
            this.foodListBox.Name = "foodListBox";
            this.foodListBox.Size = new System.Drawing.Size(209, 186);
            this.foodListBox.TabIndex = 5;
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay.Location = new System.Drawing.Point(210, 244);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(178, 16);
            this.labelDay.TabIndex = 6;
            this.labelDay.Text = "Can\'t order drinks during day";
            this.labelDay.Visible = false;
            // 
            // labelNight
            // 
            this.labelNight.AutoSize = true;
            this.labelNight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNight.Location = new System.Drawing.Point(481, 244);
            this.labelNight.Name = "labelNight";
            this.labelNight.Size = new System.Drawing.Size(174, 16);
            this.labelNight.TabIndex = 7;
            this.labelNight.Text = "Can\'t order food during night\r\n";
            this.labelNight.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(766, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Checkout";
            // 
            // TotalCostTxtBox
            // 
            this.TotalCostTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCostTxtBox.Location = new System.Drawing.Point(849, 55);
            this.TotalCostTxtBox.Name = "TotalCostTxtBox";
            this.TotalCostTxtBox.Size = new System.Drawing.Size(53, 31);
            this.TotalCostTxtBox.TabIndex = 9;
            this.TotalCostTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(766, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total Value";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(908, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Euros";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(762, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Pay By:";
            // 
            // CashRadioBtn
            // 
            this.CashRadioBtn.AutoSize = true;
            this.CashRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashRadioBtn.Location = new System.Drawing.Point(823, 121);
            this.CashRadioBtn.Name = "CashRadioBtn";
            this.CashRadioBtn.Size = new System.Drawing.Size(57, 20);
            this.CashRadioBtn.TabIndex = 13;
            this.CashRadioBtn.TabStop = true;
            this.CashRadioBtn.Text = "Cash";
            this.CashRadioBtn.UseVisualStyleBackColor = true;
            // 
            // CreditCardRadioBtn
            // 
            this.CreditCardRadioBtn.AutoSize = true;
            this.CreditCardRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditCardRadioBtn.Location = new System.Drawing.Point(823, 145);
            this.CreditCardRadioBtn.Name = "CreditCardRadioBtn";
            this.CreditCardRadioBtn.Size = new System.Drawing.Size(93, 20);
            this.CreditCardRadioBtn.TabIndex = 14;
            this.CreditCardRadioBtn.TabStop = true;
            this.CreditCardRadioBtn.Text = "Credit Card";
            this.CreditCardRadioBtn.UseVisualStyleBackColor = true;
            // 
            // CompletePaymentBtn
            // 
            this.CompletePaymentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompletePaymentBtn.Location = new System.Drawing.Point(1013, 336);
            this.CompletePaymentBtn.Name = "CompletePaymentBtn";
            this.CompletePaymentBtn.Size = new System.Drawing.Size(145, 27);
            this.CompletePaymentBtn.TabIndex = 15;
            this.CompletePaymentBtn.Text = "Complete Payment";
            this.CompletePaymentBtn.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(727, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Credit Card Name Holder";
            // 
            // NameHolderTxtBox
            // 
            this.NameHolderTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameHolderTxtBox.Location = new System.Drawing.Point(892, 183);
            this.NameHolderTxtBox.Name = "NameHolderTxtBox";
            this.NameHolderTxtBox.Size = new System.Drawing.Size(266, 31);
            this.NameHolderTxtBox.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(760, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Credit Card Number";
            // 
            // CCVTxtBox
            // 
            this.CCVTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCVTxtBox.Location = new System.Drawing.Point(892, 257);
            this.CCVTxtBox.MaxLength = 3;
            this.CCVTxtBox.Name = "CCVTxtBox";
            this.CCVTxtBox.Size = new System.Drawing.Size(266, 31);
            this.CCVTxtBox.TabIndex = 20;
            // 
            // CDNumberTxtBox
            // 
            this.CDNumberTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CDNumberTxtBox.Location = new System.Drawing.Point(892, 220);
            this.CDNumberTxtBox.Name = "CDNumberTxtBox";
            this.CDNumberTxtBox.Size = new System.Drawing.Size(266, 31);
            this.CDNumberTxtBox.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(851, 267);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "CCV";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "drinksDataSet";
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "foodDataSet";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 375);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CDNumberTxtBox);
            this.Controls.Add(this.CCVTxtBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.NameHolderTxtBox);
            this.Controls.Add(this.CompletePaymentBtn);
            this.Controls.Add(this.CreditCardRadioBtn);
            this.Controls.Add(this.CashRadioBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TotalCostTxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelNight);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.foodListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.drinksListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox drinksListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox foodListBox;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelNight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TotalCostTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton CashRadioBtn;
        private System.Windows.Forms.RadioButton CreditCardRadioBtn;
        private System.Windows.Forms.Button CompletePaymentBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox NameHolderTxtBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox CDNumberTxtBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox CCVTxtBox;
        private System.Data.DataSet dataSet1;
        private System.Data.DataSet dataSet2;
    }
}