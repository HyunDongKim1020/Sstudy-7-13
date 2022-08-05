using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._10
{
    class Products
    {
        List<Product> list = new List<Product>();

        public void SetProduct(string item, int price)
        {
            Product products = new Product();
            Product.Setitem(this,item, price);
        }

        public void ShowList()
        {
            foreach(Product p in list)
            {
                Console.WriteLine("상품 : {0}, 가격 : {1:c}",p.GetItem(),p.GetPrice());
            }
        }
        private class Product
        {
            private string item;
            private int price;

            public void SetItem(Products outer, string item,int price)
            {
                this.item = item;
                this.price = price;

                outer.list.Add(this);
            }

            public string GetItem()
            {
                return item;
            }

            public int GetPrice()
            {
                return price;
            }
        }
    }
    internal class Class5
    {
        static void Main(string[] args)
        {
            Products products = new Products();
            products.SetProduct("신발", 30000);
            products.SetProduct("셔츠", 30000);
            products.SetProduct("바지", 30000);
            Console.WriteLine();
        }
    }
}
