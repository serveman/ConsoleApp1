using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.NewFolder1._0210
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            Solution021103 s = new Solution021103();

            s.SwitchCase();
        }
    }

    internal class Solution021103
    {
        public void SwitchCase()
        {
            // SKU = Stock Keeping Unit
            string sku = "01-MN-L";

            string[] product = sku.Split('-');

            string type = "";
            string color = "";
            string size = "";

            switch (product[0])
            {
                case "01": type = "Sweat shirt"; break;
                case "02": type = "T-Shirt"; break;
                default: type = "Other"; break;
            }

            switch (product[1])
            {
                case "BL": color = "Black"; break;
                case "MN": color = "Maroon"; break;
                default: color = "White"; break;
            }

            switch (product[2])
            {
                case "S": size = "Small"; break;
                case "M": size = "Medium"; break;
                case "L": size = "Large"; break;
                default: size = "One Size Fits All"; break;
            }

            Console.WriteLine($"Product: {size} {color} {type}");
        }
    }
}
