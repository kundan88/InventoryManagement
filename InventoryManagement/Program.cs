using System;
namespace InventoryManagement
{
    class Program
    {
        public static void Main(string[] args)
        {

            FetchInventoryDetails fetchInventoryDetails = new FetchInventoryDetails();


            string filepath = "C:\\Users\\DELL\\Desktop\\PracticeProblem\\InventoryManagement\\Data.json";

            Rice data = fetchInventoryDetails.Read(filepath);
            Console.WriteLine("Types of Rice :");
            for (int i = 0; i < data.typesofRice.Count; i++)
            {
                Console.WriteLine(data.typesofRice[i].name);
                Console.WriteLine(data.typesofRice[i].price);
                Console.WriteLine(data.typesofRice[i].weight);
                int total = data.typesofRice[i].price * data.typesofRice[i].weight;

                Console.WriteLine("The price of " + data.typesofRice[i].name + " for " + data.typesofRice[i].weight + "kg = " + total);

                Console.WriteLine("--------------");
            }

            Console.WriteLine("Types of Pulses :");
            for (int i = 0; i < data.typesofPulses.Count; i++)
            {

                Console.WriteLine(data.typesofPulses[i].name);
                Console.WriteLine(data.typesofPulses[i].price);
                Console.WriteLine(data.typesofPulses[i].weight);

                int total = data.typesofPulses[i].price * data.typesofPulses[i].weight;
                Console.WriteLine("The price of " + data.typesofPulses[i].name + " for " + data.typesofPulses[i].weight + "kg = " + total);

                Console.WriteLine("--------------");
            }

            Console.WriteLine("Types of Wheat :");
            for (int i = 0; i < data.typesofPulses.Count; i++)
            {

                Console.WriteLine(data.typesofWheat[i].name);
                Console.WriteLine(data.typesofWheat[i].price);
                Console.WriteLine(data.typesofWheat[i].weight);

                int total = data.typesofWheat[i].price * data.typesofWheat[i].weight;
                Console.WriteLine("The price of " + data.typesofWheat[i].name + " for " + data.typesofWheat[i].weight + "kg = " + total);

                Console.WriteLine("--------------");
            }
        }
    }
}


        