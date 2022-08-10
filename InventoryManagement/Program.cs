using System;
namespace InventoryManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            string filepath = "C:\\Users\\DELL\\Desktop\\Assignment\\InventoryManagement\\InventoryManagement_UC3\\Data.json";
            Portfolio stockPort = new Portfolio();
            stockPort.ShowStockDetails(filepath);


        }
    }
}


        