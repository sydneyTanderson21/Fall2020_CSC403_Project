namespace Fall2020_CSC403_Project {
  partial class FrmBattle {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBattle));
            this.btnAttack = new System.Windows.Forms.Button();
            this.lblPlayerHealthFull = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEnemyHealthFull = new System.Windows.Forms.Label();
            this.tmrFinalBattle = new System.Windows.Forms.Timer(this.components);
            this.defeatEnemy = new System.Windows.Forms.Timer(this.components);
            this.lblArmorBar = new System.Windows.Forms.Label();
            this.tmrStrengthReduced = new System.Windows.Forms.Timer(this.components);
            this.directHit = new System.Windows.Forms.PictureBox();
            this.btnMask = new System.Windows.Forms.Button();
            this.btnVest = new System.Windows.Forms.Button();
            this.btnHelmet = new System.Windows.Forms.Button();
            this.btnShield = new System.Windows.Forms.Button();
            this.levelUp = new System.Windows.Forms.PictureBox();
            this.picBossBattle = new System.Windows.Forms.PictureBox();
            this.picEnemy = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.directHit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossBattle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAttack
            // 
            this.btnAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack.Location = new System.Drawing.Point(169, 519);
            this.btnAttack.Margin = new System.Windows.Forms.Padding(4);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(171, 53);
            this.btnAttack.TabIndex = 2;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // lblPlayerHealthFull
            // 
            this.lblPlayerHealthFull.BackColor = System.Drawing.Color.Blue;
            this.lblPlayerHealthFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHealthFull.ForeColor = System.Drawing.Color.White;
            this.lblPlayerHealthFull.Location = new System.Drawing.Point(95, 74);
            this.lblPlayerHealthFull.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerHealthFull.Name = "lblPlayerHealthFull";
            this.lblPlayerHealthFull.Size = new System.Drawing.Size(301, 25);
            this.lblPlayerHealthFull.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(93, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 28);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(687, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 28);
            this.label2.TabIndex = 5;
            // 
            // lblEnemyHealthFull
            // 
            this.lblEnemyHealthFull.BackColor = System.Drawing.Color.Blue;
            this.lblEnemyHealthFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyHealthFull.ForeColor = System.Drawing.Color.White;
            this.lblEnemyHealthFull.Location = new System.Drawing.Point(688, 74);
            this.lblEnemyHealthFull.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnemyHealthFull.Name = "lblEnemyHealthFull";
            this.lblEnemyHealthFull.Size = new System.Drawing.Size(301, 25);
            this.lblEnemyHealthFull.TabIndex = 6;
            // 
            // tmrFinalBattle
            // 
            this.tmrFinalBattle.Interval = 5600;
            this.tmrFinalBattle.Tick += new System.EventHandler(this.tmrFinalBattle_Tick);
            // 
            // defeatEnemy
            // 
            this.defeatEnemy.Interval = 2500;
            this.defeatEnemy.Tick += new System.EventHandler(this.defeatEnemy_Tick);
            // 
            // lblArmorBar
            // 
            this.lblArmorBar.BackColor = System.Drawing.Color.Yellow;
            this.lblArmorBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArmorBar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblArmorBar.Location = new System.Drawing.Point(92, 33);
            this.lblArmorBar.Name = "lblArmorBar";
            this.lblArmorBar.Size = new System.Drawing.Size(301, 25);
            this.lblArmorBar.TabIndex = 3;
            // 
            // tmrStrengthReduced
            // 
            this.tmrStrengthReduced.Interval = 1300;
            this.tmrStrengthReduced.Tick += new System.EventHandler(this.tmrStrengthReduced_Tick);
            // 
            // directHit
            // 
            this.directHit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("directHit.BackgroundImage")));
            this.directHit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.directHit.Location = new System.Drawing.Point(445, 200);
            this.directHit.Name = "directHit";
            this.directHit.Size = new System.Drawing.Size(196, 249);
            this.directHit.TabIndex = 13;
            this.directHit.TabStop = false;
            // 
            // btnMask
            // 
            this.btnMask.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.mask;
            this.btnMask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMask.Location = new System.Drawing.Point(336, 456);
            this.btnMask.Name = "btnMask";
            this.btnMask.Size = new System.Drawing.Size(60, 48);
            this.btnMask.TabIndex = 12;
            this.btnMask.Text = "Mask";
            this.btnMask.UseVisualStyleBackColor = true;
            this.btnMask.Click += new System.EventHandler(this.btnMask_Click);
            // 
            // btnVest
            // 
            this.btnVest.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.vest;
            this.btnVest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVest.Location = new System.Drawing.Point(259, 456);
            this.btnVest.Name = "btnVest";
            this.btnVest.Size = new System.Drawing.Size(60, 48);
            this.btnVest.TabIndex = 11;
            this.btnVest.Text = "Vest";
            this.btnVest.UseVisualStyleBackColor = true;
            this.btnVest.Click += new System.EventHandler(this.btnVest_Click);
            // 
            // btnHelmet
            // 
            this.btnHelmet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelmet.BackgroundImage")));
            this.btnHelmet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelmet.ForeColor = System.Drawing.Color.Black;
            this.btnHelmet.Location = new System.Drawing.Point(180, 456);
            this.btnHelmet.Name = "btnHelmet";
            this.btnHelmet.Size = new System.Drawing.Size(65, 48);
            this.btnHelmet.TabIndex = 10;
            this.btnHelmet.Text = "Helmet";
            this.btnHelmet.UseVisualStyleBackColor = true;
            this.btnHelmet.Click += new System.EventHandler(this.btnHelmet_Click);
            // 
            // btnShield
            // 
            this.btnShield.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.shield;
            this.btnShield.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShield.Location = new System.Drawing.Point(100, 456);
            this.btnShield.Name = "btnShield";
            this.btnShield.Size = new System.Drawing.Size(60, 48);
            this.btnShield.TabIndex = 9;
            this.btnShield.Text = "Shield";
            this.btnShield.UseVisualStyleBackColor = true;
            this.btnShield.Click += new System.EventHandler(this.btnShield_Click);
            // 
            // levelUp
            // 
            this.levelUp.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.strength_LevelUp;
            this.levelUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.levelUp.Location = new System.Drawing.Point(427, 54);
            this.levelUp.Name = "levelUp";
            this.levelUp.Size = new System.Drawing.Size(214, 236);
            this.levelUp.TabIndex = 8;
            this.levelUp.TabStop = false;
            // 
            // picBossBattle
            // 
            this.picBossBattle.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.battle_screen;
            this.picBossBattle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBossBattle.Location = new System.Drawing.Point(1040, 693);
            this.picBossBattle.Margin = new System.Windows.Forms.Padding(4);
            this.picBossBattle.Name = "picBossBattle";
            this.picBossBattle.Size = new System.Drawing.Size(40, 34);
            this.picBossBattle.TabIndex = 7;
            this.picBossBattle.TabStop = false;
            this.picBossBattle.Visible = false;
            // 
            // picEnemy
            // 
            this.picEnemy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picEnemy.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_koolaid;
            this.picEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picEnemy.Location = new System.Drawing.Point(687, 121);
            this.picEnemy.Margin = new System.Windows.Forms.Padding(4);
            this.picEnemy.Name = "picEnemy";
            this.picEnemy.Size = new System.Drawing.Size(304, 328);
            this.picEnemy.TabIndex = 1;
            this.picEnemy.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPlayer.Location = new System.Drawing.Point(93, 121);
            this.picPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(304, 328);
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // FrmBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1096, 742);
            this.Controls.Add(this.directHit);
            this.Controls.Add(this.lblArmorBar);
            this.Controls.Add(this.btnMask);
            this.Controls.Add(this.btnVest);
            this.Controls.Add(this.btnHelmet);
            this.Controls.Add(this.btnShield);
            this.Controls.Add(this.levelUp);
            this.Controls.Add(this.picBossBattle);
            this.Controls.Add(this.lblEnemyHealthFull);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPlayerHealthFull);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.picEnemy);
            this.Controls.Add(this.picPlayer);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBattle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fight!";
            ((System.ComponentModel.ISupportInitialize)(this.directHit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossBattle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox picPlayer;
    private System.Windows.Forms.PictureBox picEnemy;
    private System.Windows.Forms.Button btnAttack;
    private System.Windows.Forms.Label lblPlayerHealthFull;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lblEnemyHealthFull;
    private System.Windows.Forms.PictureBox picBossBattle;
    private System.Windows.Forms.Timer tmrFinalBattle;
    private System.Windows.Forms.Timer defeatEnemy;
        private System.Windows.Forms.PictureBox levelUp;
        private System.Windows.Forms.Button btnShield;
        private System.Windows.Forms.Button btnHelmet;
        private System.Windows.Forms.Button btnVest;
        private System.Windows.Forms.Button btnMask;
        private System.Windows.Forms.Label lblArmorBar;
        private System.Windows.Forms.Timer tmrStrengthReduced;
        private System.Windows.Forms.PictureBox directHit;
    }
}