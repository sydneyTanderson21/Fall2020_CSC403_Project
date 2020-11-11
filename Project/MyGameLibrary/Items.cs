using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code
{
    public class Items
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public string Desc { get; set; }

        public string itemType { get; private set; }
        public Items(string name, int value, string itemType = "WEAPON")
        { //default itemType is WEAPON if no type is given. Otherwise, itemType can be HEALTH. 
            this.Name = name;
            this.Value = value;
            this.itemType = itemType;
            this.Desc = itemType == "WEAPON" ? "A simple " + name : "Health Boost!";
        }
    }
    /* public class MainItem
    {
        public List<Items> backpack = new List<Items>();
        public void Initialize()
        {
            backpack.Add(new Items("Cane-sword", "1", "Mr.Peanut's Cane-sword."));
            backpack.Add(new Items("Peanut Shell", "1", "Mr.Peanut's Shell."));
        }
        public void Loot(string name, string value, string desc)
        {
            backpack.Add(new Items(name, value, desc));
        }
    } */
}
