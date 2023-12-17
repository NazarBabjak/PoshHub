using MySql.Data.MySqlClient;
using PoshHub.Forms;
using PoshHub.WindowState;
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
    public partial class Form_Home : Form
    {
        private GrayBackGround grayBG;
        private Server server;
        public Category basket;
        public int basketCount = 0;
        public Form_Home()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            grayBG = new GrayBackGround();
            grayBG.StartPosition = FormStartPosition.Manual;
            grayBG.Left = panel.Location.X;
            grayBG.Top = 23;
            grayBG.Enabled = false;
            button_ForBoys.Checked = true;
            server = new Server(this);
            server.ConnectUser();
            string query = "SELECT price, quantity, purchases, name, info, photo FROM Clothing WHERE gender = 'Чоловічий'";
            ViewProduct vb= new ViewProduct(query,this);
            SelectStateWindow(vb);
            basket = new Category();
        }

        public void SelectStateWindow(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        public void SetBackground()
        {
            grayBG.Width = panel.Width;
            grayBG.Height = panel.Height+75;

            grayBG.Show();
            button_ForBoys.Visible= false;
            button_ForGirls.Visible= false;
            this.Enabled = false;
        }

        public void DeleteBackground() {

            grayBG.Hide();
            this.Enabled = true;
            button_ForBoys.Visible = true;
            button_ForGirls.Visible = true;
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {

        }

        private void button_Logo_Click(object sender, EventArgs e)
        {
            string query;
            if (button_ForBoys.Checked == true)
            {
                query = "SELECT price, quantity, purchases, name, info, photo FROM Clothing WHERE gender = 'Чоловічий'";
            }
            else
            {
                query = "SELECT price, quantity, purchases, name, info, photo FROM Clothing WHERE gender = 'Жіночий'";
            }

            ViewProduct vb = new ViewProduct(query,this);
            SelectStateWindow(vb);
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            Form_Search form_Search = new Form_Search(this);
            form_Search.StartPosition = FormStartPosition.Manual;
            form_Search.Left = this.Left + (this.Width - form_Search.Width) / 2;
            form_Search.Top = (int)((this.Top + (this.Height - form_Search.Height) / 2)*0.4);
            form_Search.Show();
        }

        private void button_Profile_Click(object sender, EventArgs e)
        {

            Form_Authorization formAuthorization = new Form_Authorization(this);
            formAuthorization.StartPosition = FormStartPosition.Manual;
            formAuthorization.Left = this.Left + (this.Width - formAuthorization.Width) / 2;
            formAuthorization.Top = this.Top + (this.Height - formAuthorization.Height) / 2;
            formAuthorization.Show();
            


        }

        private void button_Basket_Click(object sender, EventArgs e)
        {
            if (basketCount>0) {

                ViewBasket b = new ViewBasket(this);
                SelectStateWindow(b);

            }
            else
            {
                MessageBox.Show("Кошик пустий(");
            }
 
        }

        private void button_ForBoys_Click(object sender, EventArgs e)
        {

        }

        private void button_ForGirls_Click(object sender, EventArgs e)
        {
            
        }

        private void Form_Home_Load(object sender, EventArgs e)
        {

        }

        private void button_MemberSite_Click(object sender, EventArgs e)
        {
            server.client.Member(server.ID);
        }

        private void Form_Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            server.DisconnectUser();
        }

    }
}
