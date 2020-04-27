using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp2
{
    class Item
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public List<string> Customizations { get; set; }
        public Item(string name, double cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
    }
}
