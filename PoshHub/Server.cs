using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoshHub.ServicePoshHub;
using PoshHub.WindowState;

namespace PoshHub
{
    internal class Server : IServicePoshHubCallback
    {
        Form_Home form_Home;
        public bool isConnected { get; set; }
        public ServicePoshHubClient client { get; set; }
        public int ID { get; set; }

        public Server()
        {
            isConnected = false;
        }

        public Server(Form_Home form_Home)
        {
            isConnected = false;
            this.form_Home = form_Home;
        }


        public void ConnectUser()
        {
            if (!isConnected)
            {
                Random random = new Random();
                string name = "user" + random.Next(1,1000);
                isConnected = true;
                client = new ServicePoshHubClient(new System.ServiceModel.InstanceContext(this));
                ID = client.Connect(name);
            }
        }

        public void DisconnectUser()
        {
            if (isConnected)
            {
                isConnected = false;
                client.Disconnect(ID);
            }
        }

        public void MemberCallBack(string [] onlineUsersName)
        {
            string text = " ";
            foreach (var s in onlineUsersName)
            {
                text += s + " ";
            }

            MessageBox.Show(text);
        }

        public void SelectionOfClothesCallBack(int[] price, int[] quantity, int[] purchases, string[] name, string[] info, string[] image)
        {
            try
            {
                Category category = new Category();

                for (int i = 0; i < price.Count(); i++)
                {
                    Product product = new Product(price[i], quantity[i], purchases[i], name[i], info[i], image[i]);

                    category.AddProduct(product);
                }

                ViewProduct vb = new ViewProduct(null,form_Home);
                form_Home.SelectStateWindow(vb);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка "+ex.Message);
            }
        }
    }
}
