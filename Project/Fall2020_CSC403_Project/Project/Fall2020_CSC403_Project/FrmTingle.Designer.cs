namespace Fall2020_CSC403_Project
{
  partial class FrmTingle
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.btnLeave = new System.Windows.Forms.Button();
      this.btnGreet = new System.Windows.Forms.Button();
      this.btnCompliment = new System.Windows.Forms.Button();
      this.btnInsult = new System.Windows.Forms.Button();
      this.btnWeather = new System.Windows.Forms.Button();
      this.btnGift = new System.Windows.Forms.Button();
      this.lblTingle = new System.Windows.Forms.Label();
      this.txtResponse = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.Color.White;
      this.pictureBox1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.tingle;
      this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.pictureBox1.Location = new System.Drawing.Point(12, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(595, 181);
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // btnLeave
      // 
      this.btnLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnLeave.Location = new System.Drawing.Point(438, 385);
      this.btnLeave.Name = "btnLeave";
      this.btnLeave.Size = new System.Drawing.Size(128, 43);
      this.btnLeave.TabIndex = 3;
      this.btnLeave.Text = "Leave";
      this.btnLeave.UseVisualStyleBackColor = true;
      this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
      // 
      // btnGreet
      // 
      this.btnGreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnGreet.Location = new System.Drawing.Point(49, 325);
      this.btnGreet.Name = "btnGreet";
      this.btnGreet.Size = new System.Drawing.Size(128, 43);
      this.btnGreet.TabIndex = 4;
      this.btnGreet.Text = "Greet";
      this.btnGreet.UseVisualStyleBackColor = true;
      this.btnGreet.Click += new System.EventHandler(this.btnGreet_Click);
      // 
      // btnCompliment
      // 
      this.btnCompliment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
      this.btnCompliment.Location = new System.Drawing.Point(49, 386);
      this.btnCompliment.Name = "btnCompliment";
      this.btnCompliment.Size = new System.Drawing.Size(128, 43);
      this.btnCompliment.TabIndex = 5;
      this.btnCompliment.Text = "Compliment Eyes";
      this.btnCompliment.UseVisualStyleBackColor = true;
      this.btnCompliment.Click += new System.EventHandler(this.btnCompliment_Click);
      // 
      // btnInsult
      // 
      this.btnInsult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnInsult.Location = new System.Drawing.Point(236, 325);
      this.btnInsult.Name = "btnInsult";
      this.btnInsult.Size = new System.Drawing.Size(128, 43);
      this.btnInsult.TabIndex = 6;
      this.btnInsult.Text = "Insult Mother";
      this.btnInsult.UseVisualStyleBackColor = true;
      this.btnInsult.Click += new System.EventHandler(this.btnInsult_Click);
      // 
      // btnWeather
      // 
      this.btnWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
      this.btnWeather.Location = new System.Drawing.Point(236, 385);
      this.btnWeather.Name = "btnWeather";
      this.btnWeather.Size = new System.Drawing.Size(128, 43);
      this.btnWeather.TabIndex = 7;
      this.btnWeather.Text = "Talk about Weather";
      this.btnWeather.UseVisualStyleBackColor = true;
      this.btnWeather.Click += new System.EventHandler(this.btnWeather_Click);
      // 
      // btnGift
      // 
      this.btnGift.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnGift.Location = new System.Drawing.Point(438, 325);
      this.btnGift.Name = "btnGift";
      this.btnGift.Size = new System.Drawing.Size(128, 43);
      this.btnGift.TabIndex = 8;
      this.btnGift.Text = "Ask for Gift";
      this.btnGift.UseVisualStyleBackColor = true;
      this.btnGift.Click += new System.EventHandler(this.btnGift_Click);
      // 
      // lblTingle
      // 
      this.lblTingle.AutoSize = true;
      this.lblTingle.BackColor = System.Drawing.Color.White;
      this.lblTingle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblTingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTingle.Location = new System.Drawing.Point(12, 207);
      this.lblTingle.Name = "lblTingle";
      this.lblTingle.Size = new System.Drawing.Size(97, 31);
      this.lblTingle.TabIndex = 10;
      this.lblTingle.Text = "Tingle:";
      // 
      // txtResponse
      // 
      this.txtResponse.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.txtResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
      this.txtResponse.Location = new System.Drawing.Point(12, 241);
      this.txtResponse.Multiline = true;
      this.txtResponse.Name = "txtResponse";
      this.txtResponse.ReadOnly = true;
      this.txtResponse.Size = new System.Drawing.Size(595, 69);
      this.txtResponse.TabIndex = 11;
      this.txtResponse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // FrmTingle
      // 
      this.BackColor = System.Drawing.Color.Green;
      this.ClientSize = new System.Drawing.Size(619, 469);
      this.Controls.Add(this.txtResponse);
      this.Controls.Add(this.lblTingle);
      this.Controls.Add(this.btnGift);
      this.Controls.Add(this.btnWeather);
      this.Controls.Add(this.btnInsult);
      this.Controls.Add(this.btnCompliment);
      this.Controls.Add(this.btnGreet);
      this.Controls.Add(this.btnLeave);
      this.Controls.Add(this.pictureBox1);
      this.Name = "FrmTingle";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button btnLeave;
    private System.Windows.Forms.Button btnGreet;
    private System.Windows.Forms.Button btnCompliment;
    private System.Windows.Forms.Button btnInsult;
    private System.Windows.Forms.Button btnWeather;
    private System.Windows.Forms.Button btnGift;
    private System.Windows.Forms.Label lblTingle;
    private System.Windows.Forms.TextBox txtResponse;
  }
}
