using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code {
  public class Player : BattleCharacter {
    public Armor shield { get; private set; }
    public Armor helmet { get; private set; }
    public Armor vest { get; private set; }
    public Armor mask { get; private set; }
    public int totalArmor { get; set; }
    public int maxArmor { get; private set; }
    public bool hasWeapon {get; set; }

    public List<Items> curWeapons {get; set;}
    public List<Items> backpack {get; set; }
    
    //telling the backpack to display base items should probably just be put in the main start loop.
    //public static bool Item1 = true;
    //public static bool Item2 = true;
    //public static bool Item3 = true;
    //public static bool Item4 = true;
      public Player(Vector2 initPos, Collider collider) : base(initPos, collider) 
      {
          this.shield = new Armor(5);
          this.helmet = new Armor(3);
          this.vest = new Armor(4);
          this.mask = new Armor(3);
          this.hasWeapon = false;
          this.totalArmor = 0;
          this.curWeapons = new List<Items>();
          this.maxArmor = this.shield.protectionLevel + this.helmet.protectionLevel + this.vest.protectionLevel + this.mask.protectionLevel;
          // adding items to backpack
          this.backpack = new List<Items> {
                //weapon items
                new Items("Sword", 6),
                new Items("Cane", 4),
                new Items("Brass Knuckles", 5),
                new Items("Dagger", 2),

                //health items
                new Items("Cupcake", 5, "HEALTH")
            };
      }
        public void Loot(Enemy e)
        { //adds item to backpack
            this.backpack.Add(e.personalItem);
            e.personalItem = null;
            //return "You took " + e.personalItem.Name + " from enemy";
        }

        public Items findItem(string name)
        {
            return backpack.Find(item => item.Name == name);
        }

        public void removeItem(Items i)
        {
            backpack.Remove(i);
        }
    }
}
