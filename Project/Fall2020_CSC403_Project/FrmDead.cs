using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
  public partial class FrmDead : Form {
    public bool tryAgain { get; set; }

    public FrmDead()
    {
      InitializeComponent();
      tryAgain = true;
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void btnAgain_Click(object sender, EventArgs e)
    {
      tryAgain = true;
      Close();
    }

    private void btnQuit_Click(object sender, EventArgs e)
    {
      tryAgain = false;
      Close();
    }

    private void FrmDead_FormClosed(object sender, FormClosedEventArgs e)
    {
      tryAgain = false;
      Close();
    }
  }
}
