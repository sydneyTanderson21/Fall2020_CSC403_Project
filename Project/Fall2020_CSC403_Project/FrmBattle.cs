using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Fall2020_CSC403_Project {
    public partial class FrmBattle : Form {
        public static FrmBattle instance = null;
        private Enemy enemy;
        private Player player;
        private bool finalBattle;

        private FrmBattle() {
            InitializeComponent();
            player = Game.player;
        }

        public void Setup() {
            // update for this enemy
            btnShield.Enabled = player.shield.Active;
            btnHelmet.Enabled = player.helmet.Active;
            btnVest.Enabled = player.vest.Active;
            btnMask.Enabled = player.mask.Active;
            picEnemy.BackgroundImage = enemy.Img;
            picEnemy.Refresh();
            BackColor = enemy.Color;
            picBossBattle.Visible = false;
            levelUp.Location = new Point((this.Width / 2) - (levelUp.Width / 2) - 30, (this.Height / 2) - (levelUp.Height / 2) - 200);
            levelUp.Size = new System.Drawing.Size(180, 208);
            levelUp.Visible = false;
            directHit.Location = new Point((this.Width / 2) - (directHit.Width / 2) - 30, (this.Height / 2) - (directHit.Height / 2) - 200);
            directHit.Size = new System.Drawing.Size(180, 208);
            directHit.Visible = false;
            


            // Observer pattern
            enemy.AttackEvent += PlayerDamage;
            player.AttackEvent += EnemyDamage;

            // show health
            UpdateHealthBars();
            //show Armor 
            UpdateArmorBar();
        }

        public void SetupForBossBattle() {
            finalBattle = true;
            btnShield.Visible = false;
            btnHelmet.Visible = false;
            btnVest.Visible = false;
            btnMask.Visible = false;
            picBossBattle.Location = Point.Empty;
            picBossBattle.Size = ClientSize;
            picBossBattle.Visible = true;
            //upgrade Final Boss
            enemy.strength = 3;
            enemy.MaxHealth = 50;
            enemy.Health = 50;
            UpdateHealthBars();

            SoundPlayer simpleSound = new SoundPlayer(Resources.final_battle);
            simpleSound.Play();

            tmrFinalBattle.Enabled = true;
        }

        public static FrmBattle GetInstance(Enemy enemy) {
            if (instance == null) {
                instance = new FrmBattle();
                instance.enemy = enemy;
                instance.Setup();
            }
            return instance;
        }

        private void UpdateHealthBars() {
            float playerHealthPer = player.Health / (float)player.MaxHealth;
            float enemyHealthPer = enemy.Health / (float)enemy.MaxHealth;

            const int MAX_HEALTHBAR_WIDTH = 226;
            lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
            lblEnemyHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);

            lblPlayerHealthFull.Text = player.Health.ToString();
            lblEnemyHealthFull.Text = enemy.Health.ToString();
        }


        //Armor Add ons
        private void UpdateArmorBar()
        {
            float playerArmour = player.totalArmor / (float)player.maxArmor;

            const int MAX_ARMOR_WIDTH = 226;
            lblArmorBar.Width = (int)(MAX_ARMOR_WIDTH * playerArmour);

            lblArmorBar.Text = player.totalArmor.ToString();
        }
        private void btnShield_Click(object sender, EventArgs e){
            btnShield.Enabled = false;
            player.shield.Active = false;
            player.totalArmor += player.shield.protectionLevel;
            UpdateArmorBar();
         }
        private void btnHelmet_Click(object sender, EventArgs e)
        {
            btnHelmet.Enabled = false;
            player.helmet.Active = false;
            player.totalArmor += player.helmet.protectionLevel;
            UpdateArmorBar();
            }
        private void btnVest_Click(object sender, EventArgs e)
        {
            btnVest.Enabled = false;
            player.vest.Active = false;
            player.totalArmor += player.vest.protectionLevel;
            UpdateArmorBar();
        }
        private void btnMask_Click(object sender, EventArgs e)
        {
            btnMask.Enabled = false;
            player.mask.Active = false;
            player.totalArmor += player.mask.protectionLevel;
            UpdateArmorBar();
        }

     private void btnAttack_Click(object sender, EventArgs e) {
      player.OnAttack(-4);
      if (enemy.Health > 0) {
        //Armor Bar update
        if (player.totalArmor > 0){
            player.totalArmor += (int)(enemy.strength * -2);
            if(player.totalArmor < 0){
                //use Observer to attack with new amount
                enemy.OnAttackafterArmor(player.totalArmor);
                player.totalArmor = 0;
            }
            UpdateArmorBar();
        }
        else{
            enemy.OnAttack(-2);
            // final boss direct hit, strength reduced
            if (finalBattle){
                Console.WriteLine("Strength Reduced");
                directHit.Visible = true;
                tmrStrengthReduced.Enabled = true;
                //enemy Health Increased
                 enemy.Health += 2;
                //strength reduced
                player.strength -= 0.25;
                player.strength = player.strength < 1.5 ? 1.5 : player.strength;
            }
        }
      }
       UpdateHealthBars();

      if(player.Health < 20){
               picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.babyP;
       }

      //if (player.Health < 1) { picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.peanut; }

      // LEVEL Up - increase strength when enemy is defeated
      if (enemy.Health <= 0 && player.Health > 0) {
        Console.WriteLine("Level Up");
        levelUp.Visible = true;
        defeatEnemy.Enabled = true;
        //strength increased
        player.strength += 0.425;
      }
   
      else if (player.Health <= 0 || enemy.Health <= 0) {
        instance = null;
        Close();
      }
    }

    private void EnemyDamage(int amount) {
      enemy.AlterHealth(amount);
    }

    private void PlayerDamage(int amount) {
      player.AlterHealth(amount);
    }

    private void tmrFinalBattle_Tick(object sender, EventArgs e) {
      picBossBattle.Visible = false;
      tmrFinalBattle.Enabled = false;
      btnShield.Visible = true;
      btnHelmet.Visible = true;
      btnVest.Visible = true;
      btnMask.Visible = true;
    }
    private void defeatEnemy_Tick(object sender, EventArgs e){
        levelUp.Visible = false;
        defeatEnemy.Enabled = false;
        instance = null;
        Close();

     }
    private void tmrStrengthReduced_Tick(object sender, EventArgs e)
    {
        directHit.Visible = false;
        tmrStrengthReduced.Enabled = false;

    }
        
    }
}
