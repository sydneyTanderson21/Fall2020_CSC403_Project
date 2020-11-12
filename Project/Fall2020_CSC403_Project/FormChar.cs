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
   

    public partial class FormChar : Form
    {
        public static bool Change;
        //public static bool cheetoReaper = true;
       //public static bool packetReaper = true;
        //public static bool smileyReaper = true;
        //public static bool koolaidReaper = true;

        public FormChar()
        {
            InitializeComponent();
        }

        private void FormChar_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnNut(object sender, EventArgs e)
        {
            Change = false;
            Close();
        }

        private void btnBowser(object sender, EventArgs e)
        {
            Change = true;
            Close();
        }
    }
}
