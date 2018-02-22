using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaunchChrome
{
    public partial class LaunchChrome : Form
    {
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        public LaunchChrome()
        {
            InitializeComponent();
            ComboboxItem item = new ComboboxItem();
            item.Text = "Labels";
            ComboboxItem item2 = new ComboboxItem();
            item2.Text = "Texts";
            ComboboxItem item3 = new ComboboxItem();
            item3.Text = "Letters";
            ComboboxItem item4 = new ComboboxItem();
            item4.Text = "Mardi Gras Photos";
            comboBox1.Items.Add(item);
            comboBox1.Items.Add(item2);
            comboBox1.Items.Add(item3);
            comboBox1.Items.Add(item4);
        }

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string SelectedItem = comboBox1.SelectedItem.ToString();
            if (SelectedItem == "Labels")
            {
                System.Diagnostics.Process.Start("https://www.google.com/search?ei=AiyOWuKPIcWhzwLwzYagAw&q=labels&oq=labels");
            }
            if (SelectedItem == "Texts")
            {
                System.Diagnostics.Process.Start("https://www.google.com/search?ei=5CuOWqK3HYrczwKRy47YCw&q=texts&oq=texts");
            }
            if (SelectedItem == "Letters")
            {
                System.Diagnostics.Process.Start("https://www.google.com/search?source=hp&ei=4iuOWvnJBcGWzwL1566gAg&q=letters&oq=letters");
            }
            if (SelectedItem == "Mardi Gras Photos")
            {
                System.Diagnostics.Process.Start("https://www.google.com/search?hl=en&tbm=isch&source=hp&biw=1920&bih=974&ei=lyuOWuXZB4-wzwKmh5iIDw&q=mardi+gras+photos&oq=mardi+gras+photos");
            }
        }

    }
}
