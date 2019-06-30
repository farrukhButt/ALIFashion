using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AliFashion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // shelf life
            ShelfLife shelflife = new ShelfLife();
            CallAPI callapi = new CallAPI();
            shelflife.ShopCode = int.Parse(m1ShopeCode.Text);
            shelflife.SalePrice = int.Parse(m1SalePrice.Text);
            shelflife.Season = m1Season.Text;
            shelflife.GroupName = m1GroupName.Text;
            shelflife.CategoryName = m1CategoryName.Text;
            shelflife.ClassName = m1ClassName.Text;
            double sf = callapi.ShelfLife(shelflife);
            Pshelflife.Text = sf.ToString();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Price price = new Price();
            price.CategoryName = m2CategoryName.Text;
            price.ClassName = m2ClassName.Text;
            price.ColorName = m2ColorName.Text;
            price.GroupName = m2Groupname.Text;
            price.Season = m2Seasons.Text;
            price.SubClassName = m2SubClassName.Text;
            price.TypeName = m2TypeName.Text;
            CallAPI callapi = new CallAPI();
            double pre= callapi.Price(price);
            PPrice.Text = pre.ToString();
        }

        private void Pshelflife_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var shelfStr = Pshelflife.Text;
                var ShelfLife = float.Parse(shelfStr);
                var days = 1 / ShelfLife;
                DaysItemBox.Text = days.ToString();
            }

            catch (Exception ee)
            {

            }
        }
    }
}
