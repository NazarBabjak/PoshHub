using PoshHub.WindowState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoshHub
{
    public class User
    {
        private int ID;
        private IProductComponent Clothing;
        private Form_Home form_Home;
        public string query { get; set; }
        public Customer customerUser;
        public Admin admin;
        public User user;

        public User(Form_Home form_Home)
        {
            this.form_Home = form_Home;
            customerUser = new Customer(form_Home);
        }
        public void ViewClothing()
        {

        }

        public void SelectionOfClothes()
        {

        }

    }

    public class Customer
    {
        private int phone;
        private string name;
        public Basket basket;

        private Form_Home form_Home;
        public Customer(Form_Home form_Home)
        {
            this.form_Home = form_Home;
        }

        public void EditProfile()
        {

        }
        public void ViewBasket() 
        {
            if (basket.NotNull())
            {
                ViewBasket vb = new ViewBasket();
                form_Home.SelectStateWindow(vb);

            }
            else
            {
                MessageBox.Show("Кошик пустий(");
            }
        }
    }

    public class Admin
    {
        public void BlockUser()
        {

        }

        public void ViewOnlineUser()
        {

        }

    }

    public class Guest
    {
        public void Register() 
        {
        
        }
        public void Login()
        {

        }
    }

    public class Basket
    {
        public Category Clothing = new Category();

        public void AddClothes(Product product)
        {

            Clothing.AddProduct(product);

        }

        public void RemoveClothes()
        {

        }

        public bool NotNull()
        {
            if (Clothing.Count()>0)
            {
                return true;
            }

            return false;
        }
        public void DeleteAllClothing()
        {

        }

        public void MakeOrder()
        {

        }
    }

}
