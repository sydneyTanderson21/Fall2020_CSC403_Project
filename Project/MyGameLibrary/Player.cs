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
   public Player(Vector2 initPos, Collider collider) : base(initPos, collider) {
      this.shield = new Armor(5);
      this.helmet = new Armor(3);
      this.vest = new Armor(4);
      this.mask = new Armor(2);
      this.totalArmor = 0;
      this.maxArmor = this.shield.protectionLevel + this.helmet.protectionLevel + this.vest.protectionLevel + this.mask.protectionLevel;
    }
  }
}
