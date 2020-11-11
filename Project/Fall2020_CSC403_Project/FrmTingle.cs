using Fall2020_CSC403_Project.code;
using System;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
  public partial class FrmTingle : Form{

    //variable tracking how Tingle feels about you (0 is the lowest)
    private int relationship;

    //variable that says whether a gift is given
    private bool givenGift;

    //current player
    Player player;

    public FrmTingle(int relationship, bool gift, Player p){
      InitializeComponent();
      this.relationship = relationship;
      givenGift = gift;
      player = p;
    }

    public int getRelationship()
    {
      return relationship;
    }

    public bool getGiftStatus()
    {
      return givenGift;
    }

    //close the form
    private void btnLeave_Click(object sender, EventArgs e){
      Close();
    }

    //tingles responses to greeting button
    private void btnGreet_Click(object sender, EventArgs e){
      if (relationship == 5)
      {
        txtResponse.Text = "Hello traveler!";
      }
      else if(relationship > 5)
      {
        txtResponse.Text = "Hello there good friend!";
      }
      else
      {
        txtResponse.Text = "Get away from me, you fiend!";
      }
    }

    //tingles responses to compliment button
    private void btnCompliment_Click(object sender, EventArgs e){
      if(relationship < 5)
      {
        txtResponse.Text = "Don't come at me with your flattery now, you peanut head!";
      }
      else
      {
        txtResponse.Text = "Aren't you just the kindest!!";
        relationship = 10;
      }
    }

    //tingles responses to insult button
    private void btnInsult_Click(object sender, EventArgs e)
    {
      if(relationship > 5)
      {
        txtResponse.Text = "I thought we were friends! How dare you insult my dearest mother!";
        relationship = 0;
      }
      else if(relationship == 5) {
        txtResponse.Text = "Why would you say my mother is a llama! I don't even know you!";
        relationship = 0;
      }
      else
      {
        txtResponse.Text = "Your words can no longer hurt me!";
      }
    }

    //tingles responses to weather button
    private void btnWeather_Click(object sender, EventArgs e)
    {
      if(relationship > 5)
      {
        txtResponse.Text = "The weather may be nice, but you, my friend, are more nice!";
      }
      else if(relationship == 5)
      {
        txtResponse.Text = "That wind last week was something, wasn't it?";
      }
      else
      {
        txtResponse.Text = "Don't try to have small talk with me!";
      }
    }

    //tingles responses to gift button
    private void btnGift_Click(object sender, EventArgs e)
    {
      if(givenGift == false)
      {
        if(relationship > 5)
        {
          txtResponse.Text = "Why of course! Anything for a friend! Have two apples!";
          player.backpack.Add(new Items("Apple", 2, "HEALTH"));
          player.backpack.Add(new Items("Apple", 2, "HEALTH"));
          givenGift = true;
        }
        else if(relationship == 0)
        {
          txtResponse.Text = "Why... of course! I would love to give you a gift!";
          player.backpack.Add(new Items("REALLY TASTY SNACK", -10, "HEALTH"));
          givenGift = true;
        }
        else
        {
          txtResponse.Text = "Yes, I am quite the courteous man. Have an apple, sojourner!";
          player.backpack.Add(new Items("Apple", 2, "HEALTH"));
          givenGift = true;
        }
      }
      else
      {
        if (relationship > 5)
        {
          txtResponse.Text = "I apologize dear friend! Maybe tomorrow!";
        }
        else if (relationship == 0)
        {
          txtResponse.Text = "Quit bothering me!";
        }
        else
        {
          txtResponse.Text = "I apologize, but I can't give you anything else.";
        }
      }
    }
  }
}
