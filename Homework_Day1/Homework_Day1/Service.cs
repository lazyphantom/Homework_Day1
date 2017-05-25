using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Day1
{
    public class Service
    {
        private IProductManager _procudtManager;

        public Service()
        {
            this._procudtManager = new ProductManager();
        }
        public Service(IProductManager productManager)
        {
            this._procudtManager = productManager;
        }

        public string getSplitSum(string name, int num)
        {
            IProductManager productManager = _procudtManager;
            List<int> list = productManager.GetListByName(name);
            int temp_int = 0;
            StringBuilder temp_string = new StringBuilder();
            int times = 0;

            foreach (int item in list)
            {
                temp_int += item;
                if (times + 1 == list.Count())
                {
                    temp_string.Append(temp_int);
                }
                if ((times + 1) % num == 0)
                {
                    temp_string.Append(temp_int + ",");
                    temp_int = 0;
                }
                times++;

            }

            return temp_string.ToString();
        }
    }

    public interface IProductManager
    {
        List<int> GetListByName(string name);
    }

    public class ProductManager : IProductManager
    {
        public List<int> GetListByName(string name)
        {
            switch (name)
            {
                case "Id":
                    return (from data in ProductList.GetProductList() select data.Id).ToList();
                case "Cost":
                    return (from data in ProductList.GetProductList() select data.Cost).ToList();
                case "Revenue":
                    return (from data in ProductList.GetProductList() select data.Revenue).ToList();
                case "SellPrice":
                    return (from data in ProductList.GetProductList() select data.SellPrice).ToList();
                default:
                    return new List<int>() { 0 };
            }
        }
    }

    public static class ProductList
    {

        private static List<Product> context;
        static ProductList()
        {
            context = new List<Product>() {
                new Product(1, 1, 11, 21),
                new Product(2, 2, 12, 22),
                new Product(3, 3, 13, 23),
                new Product(4, 4, 14, 24),
                new Product(5, 5, 15, 25),
                new Product(6, 6, 16, 26),
                new Product(7, 7, 17, 27),
                new Product(8, 8, 18, 28),
                new Product(9, 9, 19, 29),
                new Product(10, 10, 20, 30),
                new Product(11, 11, 21, 31)
            };
        }
        public static List<Product> GetProductList()
        {
            return context;
        }
    }

    public struct Product
    {
        public int Id { get; private set; }
        public int Cost { get; private set; }
        public int Revenue { get; private set; }
        public int SellPrice { get; private set; }

        public Product(int id, int cost, int revenue, int sellprice)
        {
            Id = id;
            Cost = cost;
            Revenue = revenue;
            SellPrice = sellprice;
        }
    }
}
