using System;
using System.Drawing;
using System.Windows.Forms;

namespace PoshHub.WindowState
{
    public partial class ViewBasket : UserControl
    {
        Form_Home form_Home;
        public ViewBasket()
        {
            InitializeComponent();
            DisplayBasket();
        }

        public ViewBasket(Form_Home form_Home)
        {
            InitializeComponent();
            this.form_Home = form_Home;
            DisplayBasket();
        }

        public void DisplayBasket()
        {
            this.BackColor = Color.White;
            Label basket = new Label();
            basket.Text = "Кошик";
            basket.Font = new Font("Franklin Gothic", 18);
            basket.ForeColor = Color.Black;
            basket.Size = TextRenderer.MeasureText(basket.Text, basket.Font);
            basket.Location = new Point((this.Width - basket.Width) / 2, (int)(this.Height * 0.08));
            this.Controls.Add(basket);

            Label clearBasket = new Label();
            clearBasket.Text = "Очистити кошик";
            clearBasket.Font = new Font("Ubuntu", 10, FontStyle.Underline);
            clearBasket.ForeColor = Color.Black;
            clearBasket.Size = TextRenderer.MeasureText(clearBasket.Text, clearBasket.Font);
            clearBasket.Location = new Point((this.Width - clearBasket.Width) / 2, (int)(this.Height * 0.15));
            clearBasket.Cursor = Cursors.Hand;
            clearBasket.Click += ClearBasket_Click;
            this.Controls.Add(clearBasket);

            int gap = 0;

            for(int i=0; i< form_Home.basket.Count();i++)
            {
                PictureBox picture = new PictureBox
                {
                    Size = new Size(150, 100),
                    Location = new Point((int)(this.Width*0.1), clearBasket.Location.Y+40),
                    Image = Image.FromFile(form_Home.basket.Chindren(i).image),
                    SizeMode = PictureBoxSizeMode.Zoom
                };

                gap+= picture.Location.Y+picture.Height;

                this.Controls.Add(picture);



                Label name = new Label();
                name.Text = form_Home.basket.Chindren(i).name;
                name.Font = new Font("Ubuntu", 14);
                name.ForeColor = Color.Black;
                name.Size = TextRenderer.MeasureText(name.Text, name.Font);
                name.Location = new Point(picture.Location.X + picture.Size.Width + 15, picture.Location.Y+5);
                this.Controls.Add(name);

                Label price = new Label();
                price.Text = form_Home.basket.Chindren(i).price.ToString()+" грн";
                price.Font = new Font("Ubuntu", 14);
                price.ForeColor = Color.Black;
                price.Size = TextRenderer.MeasureText(price.Text, price.Font);
                price.Location = new Point(name.Location.X, picture.Location.Y+picture.Size.Height-50);
                this.Controls.Add(price);

                PictureBox basketremove = new PictureBox
                {
                    Size = new Size(100, 50),
                    Location = new Point(name.Location.X+500, picture.Location.Y + picture.Size.Height - 70),
                    Image = PoshHub.Properties.Resources.basketpng,
                    SizeMode = PictureBoxSizeMode.Zoom
                };

                this.Controls.Add(basketremove);

                basketremove.Cursor = Cursors.Hand;

            }

            Label order = new Label();
            order.Text = "ЗАМОВИТИ";
            order.Font = new Font("Ac Line", 18, FontStyle.Bold);
            order.ForeColor = Color.White;
            order.BackColor = Color.Black;
            order.Size = TextRenderer.MeasureText(order.Text, order.Font);
            order.Location = new Point((this.Width - order.Width) / 2, gap+20);
            order.Cursor = Cursors.Hand;
            this.Controls.Add(order);
        }

        private void ClearBasket_Click(object sender, EventArgs e)
        {
            
        }
    }
}
