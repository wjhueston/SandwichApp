using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cory's Concatenated Cold Cuts\n");
            var items = new Order();
            
            string newItem = "y";
            do
            {
                Console.WriteLine("Menu:\n1. Ham and Cheese\n2. Turkey and Swiss\n" +
                "3. Corned Beef\n4. Ham on Rye\n5. French Dip\n6. Grilled Cheese\n" +
                "7. Grilled Chicken\n8. Roast Beef\n9. Peanut Butter and Jelly\n10. Coder's Special");
                string order = Console.ReadLine();
                
                switch (order)
                {
                    case "1":
                        Console.WriteLine("Ham and Cheese");
                        Console.WriteLine("Would you like to customize this item? (Y/N)");
                        var hamItem = new Item("Ham and Cheese", 5.00);
                        
                        string customize = Console.ReadLine();
                        if (customize == "Y" || customize == "y")
                        {
                            string response = "y";
                            do
                            {
                                Console.WriteLine(Customizations());
                                string cust = Console.ReadLine();
                                CustomizeHandler(cust, hamItem);
                                Console.WriteLine("Add another customizations? (Y/N)");
                                response = Console.ReadLine();
                            }
                            while (response == "y" || response == "Y");
                            items.Purchases.Add(hamItem);

                        }
                        else if(customize == "N" || customize == "n")
                        {
                            items.Purchases.Add(hamItem);
                        }
                        break;
                    case "2": break;
                    case "3": break;
                    case "4": break;
                    case "5": break;
                    case "6": break;
                    case "7": break;
                    case "8": break;
                    case "9": break;
                    case "10": break;
                    default: break;
                }
                newItem = Console.ReadLine();
            }
            while (newItem != "n" && newItem != "N");
            items.Subtotal = 0;
            foreach(var price in items.Purchases)
            {
                items.Subtotal += price.Cost;
            }
            foreach(var item in items.Purchases)
            {
                Console.WriteLine($"{item.Name}.............{item.Cost}");
            }
            Console.WriteLine($"Subtotal: {items.Subtotal}");
            Console.WriteLine($"Total: {(items.Subtotal * 0.051) + items.Subtotal}");
        }
        public static string Customizations()
        {
            return ("Please select a customizations.\n1. Oil\n2. Mustard\n3. Ketchup\n4. Lettuce\n5. Tomato\n6. Onion\n7. Pickles\n8. Peppers\n9. Extra Cheese\n10. Bacon");
        }
        public static void CustomizeHandler(string number, Item item)
        {
            switch (number)
            {
                case "1":
                    item.Customizations.Add("Oil");
                    break;
                case "2":
                    item.Customizations.Add("Mustard");
                    break;
                case "3":
                    item.Customizations.Add("Ketchup");
                    break;
                case "4":
                    item.Customizations.Add("Lettuce");
                    break;
                case "5":
                    item.Customizations.Add("Tomato");
                    break;
                case "6":
                    item.Customizations.Add("Onion");
                    break;
                case "7":
                    item.Customizations.Add("Pickles");
                    break;
                case "8":
                    item.Customizations.Add("Peppers");
                    break;
                case "9":
                    item.Customizations.Add("Extra Cheese");
                    break;
                case "10":
                    item.Customizations.Add("Bacon");
                    break;
                default: Console.WriteLine("Invalid Response. Please Try Again."); break;
            }
            
        }
        
    }
}
