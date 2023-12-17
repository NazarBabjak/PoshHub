using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters.Entities;
using static Azure.Core.HttpHeader;

namespace PoshHub.WindowState
{
    public partial class ViewProduct : UserControl
    {
        private Form_Home form_home;
        private Category category;
        private Category basket;
        private int CurrentIndex;
        public ViewProduct()
        {
            InitializeComponent();

            this.BackColor = Color.White;

        }

        public ViewProduct(string sample, Form_Home form_home)
        {
            InitializeComponent();

            this.BackColor = Color.White;
            this.form_home = form_home;
            category = new Category();
            basket = new Category();
            DisplayClothes(sample);
        }


        public void DisplayClothes(string sample)
        {
            try
            {
                int panelHeight = 450;
                int panelWidth = (int)(0.1925 * this.Width); // 19,25% ширина вікна
                int panelMargin = (int)(0.1 * this.Width); // 10% відступ зліва та справа
                int gapBetweenPanels = (int)(0.03 * this.Width); // 1% між панелями

                int x = panelMargin;
                int count = 0, y = gapBetweenPanels;

                MySqlConnection conDB;
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

                for (int i = 0; i < prices.Count(); i++)
                {
                    
                    Panel panel0 = new Panel();
                    panel0.Size = new Size(panelWidth, panelHeight);
                    panel0.Location = new Point(x, y);
                    panel0.BackColor = Color.White; // білий колір фону

                    PictureBox pictureBox = new PictureBox
                    {
                        Size = new Size(panelWidth, (int)(panelHeight * 0.78)),
                        Location = new Point(0, 0),
                        Image = Image.FromFile(images[i]),
                        SizeMode = PictureBoxSizeMode.Zoom
                    };

                    panel0.Controls.Add(pictureBox);
                    Label name = new Label();
                    name.Size = new Size(panelWidth, (int)(panelHeight * 0.1));
                    name.Text = names[i];
                    name.Font = new Font("Ubuntu", 12);
                    name.ForeColor = Color.Black;
                    name.Location = new Point(0, (int)((panelHeight * 0.78) + 10));
                    panel0.Controls.Add(name);

                    Label price = new Label();
                    price.Size = new Size(panelWidth/2, (int)(panelHeight * 0.1));
                    price.Text = prices[i] +" грн";
                    price.Font = new Font("Verdana", 14, FontStyle.Bold);
                    price.ForeColor = Color.Black;
                    price.Location = new Point(0, (int)((panelHeight * 0.78) + 10 + name.Height));
                    panel0.Controls.Add(price);

                    PictureBox pictureBasket = new PictureBox
                    {
                        Size = new Size(41, 34),
                        Location = new Point(panelWidth - 46, (int)((panelHeight * 0.78) + 10 + name.Height)),
                        Image = PoshHub.Properties.Resources.basketAdd,
                        SizeMode = PictureBoxSizeMode.Zoom
                    };
                    panel0.Controls.Add(pictureBasket);

                    panel0.MouseEnter += Panel_MouseEnter;
                    panel0.MouseLeave += Panel_MouseLeave;
                    panel0.Click += Clothes_Click;

                    pictureBox.MouseEnter += Panel_MouseEnter;
                    pictureBox.MouseLeave += Panel_MouseLeave;

                    pictureBasket.MouseEnter += Panel_MouseEnter;
                    pictureBasket.MouseLeave += Panel_MouseLeave;
                    pictureBasket.Click += BasketAdd_Click;

                    name.MouseEnter += Panel_MouseEnter;
                    name.MouseLeave += Panel_MouseLeave;

                    this.Controls.Add(panel0);

                    x += gapBetweenPanels + panelWidth;
                    count++;
                    if (count == 4)
                    {
                        count = 0;
                        y += panelHeight + gapBetweenPanels;
                        x = panelMargin;
                    }

                    Product clothes = new Product();

                    clothes.name = names[i];
                    clothes.price= prices[i];
                    clothes.image= images[i];
                    category.AddProduct( clothes );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка при відображенні одягу: " + ex.Message);
               
            }
        }

        private void BasketAdd_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBasket)
            {
                Panel parentPanel = pictureBasket.Parent as Panel;

                if (parentPanel != null)
                {
                    pictureBasket.Image = PoshHub.Properties.Resources.basketAdded;

                    // Отримати індекс товару відповідно до панелі
                    int index = this.Controls.IndexOf(parentPanel);

                    if (index >= 0 && index < category.Count())
                    {
                        // Отримати товар за допомогою індексу
                        Product selectedProduct = category.Chindren(index);

                        // Додати товар до кошика користувача
                        form_home.basket.AddProduct(selectedProduct);
                        form_home.basketCount++;
                    }
                }
            }
        }



        // Обробник події при наведенні миші на панель
        private void Panel_MouseEnter(object sender, EventArgs e)
        {
            Panel panel = null;

            if (sender is PictureBox pictureBox)
            {
                panel = pictureBox.Parent as Panel;
            }
            else if (sender is Panel)
            {
                panel = (Panel)sender;
            }
            else if (sender is Label name)
            {
                panel = name.Parent as Panel;
            }

            if (panel != null)
            {
                panel.BackColor = Color.LightGray;
                panel.Cursor = Cursors.Hand;
            }
        }


        // Обробник події при виході миші з панелі
        private void Panel_MouseLeave(object sender, EventArgs e)
        {

            Panel panel = null;

            if (sender is PictureBox pictureBox)
            {
                panel = pictureBox.Parent as Panel;
            }
            else if (sender is Panel)
            {
                panel = (Panel)sender;
            }
            else if (sender is Label label)
            {
                panel = label.Parent as Panel;
            }

            if (panel != null)
            {
                panel.BackColor = Color.White; // Змінити колір при наведенні на панель
                panel.Cursor = Cursors.Arrow;
            }
        }

        private void Clothes_Click(object sender, EventArgs e)
        {
            
        }

        private void ViewProduct_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
