using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoshHub.Forms
{
    public partial class Form_Search : Form
    {
        Form_Home form_Home;
        public Form_Search()
        {
            InitializeComponent();
        }
        public Form_Search(Form_Home fm)
        {
            InitializeComponent();
            form_Home = fm;

            form_Home.SetBackground();
            this.TopMost = true;

        }

        private void button_CloseSearch_Click(object sender, EventArgs e)
        {
            form_Home.DeleteBackground();
            this.Close();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {

        }
    }
}
