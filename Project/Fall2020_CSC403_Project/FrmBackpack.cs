using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmBackpack : Form
    {
        private Player player;
        public bool selectedWeapon;
        public bool selectedHealth;
        public FrmBackpack()
        {
            InitializeComponent();
            player = Game.player;
        }

        private void FrmBackpack_Load(object sender, EventArgs e)
        {
            Load_listView();
        }

        private void Load_listView()
        {
            this.listView1.CheckBoxes = true;
            this.listView1.FullRowSelect = true;
            this.listView1.View = View.Details;
            this.listView1.GridLines = true;

            //adding members to the list
            this.listView1.BeginUpdate();
                       
            foreach(Items i in player.backpack)
            {
                this.listView1.Items.Add(new ListViewItem(new string[] { i.Name, i.Value.ToString(), i.Desc }));
            }

            this.listView1.EndUpdate();


            /*
            if (code.Player.Item1 == true)
            {
                Items a = new Items("Cane-sword", "1", "Mr.Peanut's Cane-sword.");

                string[] rowa = { a.Name, a.Value, a.Desc };
                var listviewItema = new ListViewItem(rowa);
                listView1.Items.Add(listviewItema);
            }
            if (code.Player.Item2 == true)
            {
                Items b = new Items("Peanut Shell", "1", "Mr.Peanut's Shell.");

                string[] rowb = { b.Name, b.Value, b.Desc };
                var listviewItema = new ListViewItem(rowb);
                listView1.Items.Add(listviewItema);
            }*/

        }

        private void btnUseItem_Click(object sender, EventArgs e)
        { //Use buttton is clicked
            foreach(ListViewItem lv in this.listView1.CheckedItems)
            {
                //finds selected item
                Items i = player.findItem(lv.Text);
                //use item
                if (i.itemType == "WEAPON")
                {
                    player.hasWeapon = true;
                    player.curWeapons.Add(i);
                    selectedWeapon = true;


                }
                else if(i.itemType == "HEALTH")
                {
                    if(player.Health + i.Value > player.MaxHealth){
                        player.MaxHealth += i.Value;
                    }
                    player.Health += i.Value;
                    selectedHealth = true;
                }

                //remove item from backpack
                player.removeItem(i);
            }
            Close();
        }
    }
}
