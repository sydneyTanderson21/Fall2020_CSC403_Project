using System.Drawing;


namespace Fall2020_CSC403_Project.code {
  public class NPC : Character {
    /// <summary>
    /// THis is the image for an enemy
    /// </summary>
    public Image Img { get; set; }

    /// <summary>
    /// this is the background color for the fight form for this enemy
    /// </summary>
    public Color Color { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="initPos">this is the initial position of the npc</param>
    /// <param name="collider">this is the collider for the npc</param>
    public NPC(Vector2 initPos, Collider collider) : base(initPos, collider) {

    }
  }
}
