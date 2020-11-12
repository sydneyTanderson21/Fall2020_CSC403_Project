using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  static class Program {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      //a boolean to tell whether the user chose to quit the game after dying
      bool didNotQuit = true;

      //this will loop as long as the user did not quit
      while (didNotQuit)
      {
          FormChar frmChar = new FormChar();
          Application.Run(frmChar);
          
          // make a form level and run it
          FrmLevel frmLevel = new FrmLevel();
          Application.Run(frmLevel);
          
          //after running the form, check to see if it closed
          if (frmLevel.formClosed)
          {
          if (frmLevel.loss)
          {
            // go to the dead form
            FrmDead frmDead = new FrmDead();
            Application.Run(frmDead);
            didNotQuit = frmDead.tryAgain;
          }
          else if (frmLevel.victory)
          {
            // go to the win form
            FrmWon frmWon = new FrmWon();
            Application.Run(frmWon);
            didNotQuit = frmWon.tryAgain;
          }
          //set the didNotQuit var to true or false depending on how the user answers
          
          }
        }
    }
  }
}
