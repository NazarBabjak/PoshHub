using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoshHub
{
    public partial class Form_Registration : Form
    {
        Form_Authorization authorization;
        public Form_Registration()
        {
            InitializeComponent();
        }

        public Form_Registration(Form_Authorization a)
        {
            InitializeComponent();
            this.authorization = a;
            a.TopMost = false;
            this.TopMost = true;
        }

        private void button_Registration_Click(object sender, EventArgs e)
        {

        }

        private void button_WelcomWithRegistration_Click(object sender, EventArgs e)
        {
            this.TopMost = false; authorization.TopMost = true;
            this.Close();
        }

        
        private void button_CloseAuthorization_Click(object sender, EventArgs e)
        {
            this.TopMost = false; authorization.TopMost = true;
            this.Close();
        }

        private void button_PasswordView_Click(object sender, EventArgs e)
        {
            string resourceName;

            if (this.text_passwordRegistration.UseSystemPasswordChar)
            {
                this.text_passwordRegistration.UseSystemPasswordChar = false;
                resourceName = "PasswordNotView";
            }
            else
            {
                this.text_passwordRegistration.UseSystemPasswordChar = true;
                resourceName = "PasswordView";
            }

            System.Drawing.Bitmap image = (System.Drawing.Bitmap)Properties.Resources.ResourceManager.GetObject(resourceName);
            button_PasswordView.Image = image;
        }
    }
}
