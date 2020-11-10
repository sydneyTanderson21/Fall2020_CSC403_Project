using MyGameLibrary;
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
        public FrmBackpack()
        {
            InitializeComponent();
        }

        private void FrmBackpack_Load(object sender, EventArgs e)
        {
            Load_listView();
        }

        private void Load_listView()
        {
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
            }

        }

    }
}
