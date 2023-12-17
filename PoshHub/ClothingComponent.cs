using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

// Компонент (інтерфейс)
public interface IProductComponent
{
    void DisplayInfo(ListView listView);
}

// Лист (конкретний товар)
public class Product : IProductComponent
{
    public int price { get; set; }
    public int quantity { get; set; }
    public int purchases { get; set; }
    public string name { get; set; }
    public string info { get; set; }
    public string image { get; set; }

    public Product() {

        this.price = 0;
        this.quantity = 0;
        this.purchases = 0;
        this.name = null;
        this.info = null;
        this.image = null;

    }
    public Product(int price, int quantity, int purchases, string name, string info, string image)
    {
        this.price = price;
        this.quantity = quantity;
        this.purchases = purchases;
        this.name = name;
        this.info = info;
        this.image = image;
        
    }

    public void DisplayInfo(ListView listView)
    {
        ListViewItem item = new ListViewItem(name);
        item.SubItems.Add(price.ToString());
        listView.Items.Add(item);
    }
}

// Гілка (категорія товарів)
 public class Category : IProductComponent
{
    private List<Product> children = new List<Product>();

    public void AddProduct(Product product)
    {
        children.Add(product);
    }
    public int Count()
    {
        return children.Count;
    }
    public Product Chindren(int i)
    {
        return children[i];
    }

    public void DisplayInfo(ListView listView)
    {
        foreach (var child in children)
        {
            child.DisplayInfo(listView);
        }
    }
}
