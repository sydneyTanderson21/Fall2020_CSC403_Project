using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmLevel : Form {
    public bool formClosed { get; set; }
    public bool victory { get; set; }
    public bool loss { get; set; }
    
    private Player player;

    private NPC tingle;

    private Enemy enemyPoisonPacket;
    private Enemy bossKoolaid;
    private Enemy enemyCheeto;
    private Enemy enemySmiley;
    private Character[] walls;

    private DateTime timeBegin;
    private FrmBattle frmBattle;
    private FrmTingle frmTingle;
    

    //your relationship and gift status with tingle
    private int tingleRelationship = 5;
    private bool tingleGiftGiven = false;

    public FrmLevel() {
      InitializeComponent();
    }

    private void FrmLevel_Load(object sender, EventArgs e) {
      const int PADDING = 7;
      const int NUM_WALLS = 13;

      player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
      tingle = new NPC(CreatePosition(picTingle), CreateCollider(picTingle, PADDING));
      bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
      bossKoolaid.personalItem = new Items("Trophy", 100);
      enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
      enemyPoisonPacket.personalItem = new Items("Poison Bomb", 5);
      enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));
      enemyCheeto.personalItem = new Items("Cleaver", 8);
      enemySmiley = new Enemy(CreatePosition(picEnemySmiley), CreateCollider(picEnemySmiley, PADDING));
      enemySmiley.personalItem = new Items("Smile", 10, "HEALTH");

      bossKoolaid.Img = picBossKoolAid.BackgroundImage;
      enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
      enemyCheeto.Img = picEnemyCheeto.BackgroundImage;
      enemySmiley.Img = picEnemySmiley.BackgroundImage;

      bossKoolaid.Color = Color.Red;
      enemyPoisonPacket.Color = Color.Green;
      enemyCheeto.Color = Color.FromArgb(255, 245, 161);
      txtWeapons.Visible = false;
      txtHealth.Visible = false;

      walls = new Character[NUM_WALLS];
      for (int w = 0; w < NUM_WALLS; w++) {
        PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
        walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }

    frmTingle = new FrmTingle(tingleRelationship, tingleGiftGiven, player);
    Game.player = player;
      timeBegin = DateTime.Now;
    }

    private Vector2 CreatePosition(PictureBox pic) {
      return new Vector2(pic.Location.X, pic.Location.Y);
    }

    private Collider CreateCollider(PictureBox pic, int padding) {
      Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
      return new Collider(rect);
    }

    private void FrmLevel_KeyUp(object sender, KeyEventArgs e) {
      player.ResetMoveSpeed();
    }

    private void tmrUpdateInGameTime_Tick(object sender, EventArgs e) {
      TimeSpan span = DateTime.Now - timeBegin;
      string time = span.ToString(@"hh\:mm\:ss");
      lblInGameTime.Text = "Time: " + time.ToString();
    }

    private void tmrPlayerMove_Tick(object sender, EventArgs e) {
      // move player
      player.Move();

      //check tingle relationship
      tingleRelationship = frmTingle.getRelationship();

      // check collision with walls
      if (HitAWall(player)) {
        player.MoveBack();
      }

      // check collision with enemies
      if (HitAChar(player, enemyPoisonPacket)) {
        if (enemyPoisonPacket.Health <= 0) { }
        else
        {
          Fight(enemyPoisonPacket);
        }
      }
      else if (HitAChar(player, enemyCheeto)) {
        if (enemyCheeto.Health <= 0) { }
        else
        {
          Fight(enemyCheeto);
        }
      }
      else if(HitAChar(player, enemySmiley)){
        if (enemySmiley.Health <= 0) { }
        else
        {
          Fight(enemySmiley);
        }
      }
      if (HitAChar(player, bossKoolaid)) {
        if (bossKoolaid.Health <= 0) { }
        else
        {
          Fight(bossKoolaid);
        }
      }
      if (HitAChar(player, tingle))
      {
        TalkTingle();
      }
      if(player.Health < 20)
       {
        if (FormChar.Change == false)
        {

            picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.babyP;
        }

        if (FormChar.Change == true)
        {

            picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.babyBowser;
        }
    }

      //check if dead
      if(player.Health <= 0){
        Close();
        loss = true;
        formClosed = true; 
      }

      //check if won
      //this happens if all enemies died
      if (enemyPoisonPacket.Health <= 0 && enemyCheeto.Health <= 0 && enemySmiley.Health <= 0 && bossKoolaid.Health <= 0)
      {
        Close();
        victory = true;
        formClosed = true;
      }

      // update player's picture box
      picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
    }

    private bool HitAWall(Character c) {
      bool hitAWall = false;
      for (int w = 0; w < walls.Length; w++) {
        if (c.Collider.Intersects(walls[w].Collider)) {
          hitAWall = true;
          break;
        }
      }
      return hitAWall;
    }

    private bool HitAChar(Character you, Character other) {
      return you.Collider.Intersects(other.Collider);
    }

    private void Fight(Enemy enemy) {
      player.ResetMoveSpeed();
      player.MoveBack();
      frmBattle = FrmBattle.GetInstance(enemy);
      if (enemy == bossKoolaid) {
        frmBattle.SetupForBossBattle();
      }
      frmBattle.Refresh();
      frmBattle.ShowDialog();
      //check if enemies are dead
      if (enemySmiley.Health <= 0 && picEnemySmiley.Visible == true)
      {
        Rectangle rect = new Rectangle(picEnemySmiley.Location, new Size(0,0));
        enemySmiley.Collider = new Collider(rect);
        picEnemySmiley.Visible = false;
      }
      else if (enemyCheeto.Health <= 0 && picEnemyCheeto.Visible == true)
      {
        picEnemyCheeto.Visible = false;
      }
      else if (enemyPoisonPacket.Health <= 0 && picEnemyPoisonPacket.Visible == true)
      {
        picEnemyPoisonPacket.Visible = false;
      }
      else if (bossKoolaid.Health <= 0 && picBossKoolAid.Visible == true)
      {
        picBossKoolAid.Visible = false;
      }

    }

    private void TalkTingle()
    {
      player.ResetMoveSpeed();
      player.MoveBack();
      frmTingle = new FrmTingle(tingleRelationship, tingleGiftGiven, player);
      frmTingle.Show();
    }

    private void FrmLevel_KeyDown(object sender, KeyEventArgs e) {
      switch (e.KeyCode) {
        case Keys.Left:
          player.GoLeft();
          break;

        case Keys.Right:
          player.GoRight();
          break;

        case Keys.Up:
          player.GoUp();
          break;

        case Keys.Down:
          player.GoDown();
          break;

        case Keys.I:
          var frmBackpack = new FrmBackpack();
          frmBackpack.ShowDialog();
            //display that a player has selected a weapon and/or health boost
          if(frmBackpack.selectedWeapon) {
                tmrWeapon.Enabled = true;
                txtWeapons.Visible = true;
            }
          if (frmBackpack.selectedHealth)
          {
              tmrHealth.Enabled = true;
              txtHealth.Visible = true;
          }
          frmBackpack.selectedHealth = false;
          frmBackpack.selectedWeapon = false;
          break;

        default:
          player.ResetMoveSpeed();
          break;
      }
    }

    private void FrmLevel_FormClosed(object sender, FormClosedEventArgs e)
    {
      formClosed = true;
      loss = true;
    }

        private void tmrHealth_Tick(object sender, EventArgs e)
        {
            txtHealth.Visible = false;
            tmrHealth.Enabled = false;
        }

        private void tmrWeapon_Tick(object sender, EventArgs e)
        {
            txtWeapons.Visible = false;
            tmrWeapon.Enabled = false;
        }
    }
}
