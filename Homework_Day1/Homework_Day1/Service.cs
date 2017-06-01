using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Day1
{
    public class SplitSumService
    {
        public List<int> GetSplitSum(List<Product> productList, string name, int num)
        {
            List<int> list;

            switch (name)
            {
                case "Id":
                    list = (from data in productList select data.Id).ToList();
                    break;
                case "Cost":
                    list = (from data in productList select data.Cost).ToList();
                    break;
                case "Revenue":
                    list = (from data in productList select data.Revenue).ToList();
                    break;
                case "SellPrice":
                    list = (from data in productList select data.SellPrice).ToList();
                    break;
                default:
                    list = new List<int>();
                    break;
            }
            int temp_int = 0;
            List<int> temp_retune = new List<int>();
            int times = 0;

            foreach (int item in list)
            {
                temp_int += item;
                if (times + 1 == list.Count())
                {
                    temp_retune.Add(temp_int);
                }
                if ((times + 1) % num == 0)
                {
                    temp_retune.Add(temp_int);
                    temp_int = 0;
                }
                times++;
            }

            return temp_retune;
        }
    }

    public class Product
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
