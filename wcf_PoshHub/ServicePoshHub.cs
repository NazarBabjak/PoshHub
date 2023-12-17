using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MySql.Data.MySqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace wcf_PoshHub
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ServicePoshHub : IServicePoshHub
    {
        int nextID = 1;
        MySqlConnection conDB;
        List <ServiceUser> users = new List <ServiceUser> ();

        public void BlockUser(string name)
        {
            throw new NotImplementedException();
        }

        public int Connect(string name)
        {
          
            ServiceUser user = new ServiceUser() { 
            
                ID = nextID,
                Name = name,
                operationContext = OperationContext.Current

            };
            nextID++;
            users.Add(user);
            return user.ID;
        }
            
        public void Disconnect(int id)
        {
            var user = users.FirstOrDefault(i => i.ID == id);
            if (user != null)
            {
                users.Remove(user);
            }
        }

        public void Member(int id)
        {
            string[] onlineUsersName = new string[users.Count];

            int n = 0;

            var user = users.FirstOrDefault(i => i.ID == id);
            foreach (var item in users)
            {
                onlineUsersName[n] = item.Name;
                n++;
            }

            user.operationContext.GetCallbackChannel<IServicePoshHubCallBack>().MemberCallBack(onlineUsersName);
        }

        public void SelectionOfClothes(string sample, int id)
        {
            
            var user = users.FirstOrDefault(i => i.ID == id);


            string constr = "Server=localhost;Database=poshhub;User ID=root;Password=123456n;";
            conDB = new MySqlConnection(constr);

            // Lists to store the retrieved data
            List<int> prices = new List<int>();
            List<int> quantities = new List<int>();
            List<int> purchasesList = new List<int>();
            List<string> names = new List<string>();
            List<string> infos = new List<string>();
            List<string> images = new List<string>();

            MySqlCommand cmd = new MySqlCommand(sample, conDB);

            conDB.Open(); 
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Retrieve data from each column
                    int price = reader.GetInt32("price");
                    int quantity = reader.GetInt32("quantity");
                    int purchases = reader.GetInt32("purchases");
                    string name = reader.GetString("name");
                    string info = reader.GetString("info");
                    string image = reader.GetString("photo");

                    // Store the retrieved data in lists
                    prices.Add(price);
                    quantities.Add(quantity);
                    purchasesList.Add(purchases);
                    names.Add(name);
                    infos.Add(info);
                    images.Add(image);
                }
            }

            // Close the connection after executing the query
            conDB.Close();

            // Convert lists to arrays if needed
            int[] priceArray = prices.ToArray();
            int[] quantityArray = quantities.ToArray();
            int[] purchasesArray = purchasesList.ToArray();
            string[] nameArray = names.ToArray();
            string[] infoArray = infos.ToArray();
            string[] imageArray = images.ToArray();

            user.operationContext.GetCallbackChannel<IServicePoshHubCallBack>().SelectionOfClothesCallBack(priceArray, quantityArray, purchasesArray, nameArray,infoArray,imageArray);
        }
    }
}
