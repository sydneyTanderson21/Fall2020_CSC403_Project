using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code{
    public class Armor
    {
        public int protectionLevel { get; private set; }
        public bool Active { get;  set; }
        public Armor(int power)
        {
            this.protectionLevel = power;
            this.Active = true;
        }
    }
}
