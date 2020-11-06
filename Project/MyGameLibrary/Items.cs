using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyGameLibrary
{
    class Items
    {
        public static List<string> ItemsAll = new List<string>();
        public static List<string> ItemsValue = new List<string>();
        public static List<string> ItemsDesc = new List<string>();
        public static List<string> Backpack = new List<string>();
        public static string[,] ItemStats = new string[ItemsAll.Count, 3];

        static void Main(String[] args)
        {
            //List<string> ItemsAll = new List<string>();
            ItemsAll.Add("Cane-Sword");
            ItemsAll.Add("Peanut Shell");
            ItemsAll.Add("Tophat of the dapper");
            ItemsAll.Add("Monacle of the dapper");
            ItemsAll.Add("Dagger");
            ItemsAll.Add("Bastard Sword");
            ItemsAll.Add("Chainmail");
            ItemsAll.Add("Platemail");
            ItemsAll.Add("Health Potion");

            ItemsValue.Add("1");
            ItemsValue.Add("1");
            ItemsValue.Add("100");
            ItemsValue.Add("100");
            ItemsValue.Add("5");
            ItemsValue.Add("10");
            ItemsValue.Add("5");
            ItemsValue.Add("10");
            ItemsValue.Add("25");

            ItemsDesc.Add("Mr.Peanut's Cane-sword.");
            ItemsDesc.Add("Mr.Peanut's Shell.");
            ItemsDesc.Add("Mr.Peanut's Tophat.");
            ItemsDesc.Add("Mr.Peanut's Monacle.");
            ItemsDesc.Add("A simple Dagger.");
            ItemsDesc.Add("A Strong Bastard Sword.");
            ItemsDesc.Add("Simple Chainmail.");
            ItemsDesc.Add("Intricate Platemail.");
            ItemsDesc.Add("A Strange Red Glowing Potion.");


            for (int x = 0; x <= ItemsAll.Count; x++)
            {
                ItemStats[x, 1] = ItemsAll[x];
            }

            for (int y = 0; y <= ItemsAll.Count; y++)
            {
                ItemStats[y, 2] = ItemsAll[y];
            }

            for (int z = 0; z <= ItemsAll.Count; z++)
            {
                ItemStats[z, 3] = ItemsAll[z];
            }

            Backpack.Add("Cane-Sword");
            Backpack.Add("Peanut Shell");
            Backpack.Add("Tophat of the dapper");
            Backpack.Add("Monacle of the dapper");
        }

        public List<string> GetList() => ItemsAll;

        public List<string> ToBackpack()
        {
            return null;
        }
        public List<string> FromBackpack()
        {
            return null;
        }
        public List<string> FromEnemy()
        {
            return null;
        }

        public string Inspect(string Item)
        {
            int x = ItemsAll.FindIndex(y => y == Item);
            return ItemStats[x, 3];
        }
        public string InspectValue(string Item)
        {
            int x = ItemsAll.FindIndex(y => y == Item);
            return ItemStats[x, 2];
        }
    }
}
