using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Interactions.Forms
{
    public class BaseForm : Form, IBackTrackingForm
    {
        private Button btnBack;

        public void Backtrack()
        {
            var previousForm = Tag as Form;
            previousForm.Show();
            this.Hide();
        }

        public void Visit(Form from)
        {
            Tag = from;
            from.Hide();
            Show();
        }
        public BaseForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 25);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // BaseForm
            // 
            this.ClientSize = new System.Drawing.Size(628, 456);
            this.Controls.Add(this.btnBack);
            this.Name = "BaseForm";
            this.ResumeLayout(false);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Backtrack();
        }
    }
}
