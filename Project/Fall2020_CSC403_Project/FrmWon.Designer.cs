namespace Fall2020_CSC403_Project
{
  partial class FrmWon
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
      this.picPeanuts = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnAgain = new System.Windows.Forms.Button();
      this.btnQuit = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.picPeanuts)).BeginInit();
      this.SuspendLayout();
      // 
      // picPeanuts
      // 
      this.picPeanuts.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.peanuts;
      this.picPeanuts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picPeanuts.Location = new System.Drawing.Point(-8, -19);
      this.picPeanuts.Name = "picPeanuts";
      this.picPeanuts.Size = new System.Drawing.Size(1202, 549);
      this.picPeanuts.TabIndex = 1;
      this.picPeanuts.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 65.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.Blue;
      this.label1.Location = new System.Drawing.Point(347, 88);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(479, 106);
      this.label1.TabIndex = 2;
      this.label1.Text = "Victory";
      // 
      // btnAgain
      // 
      this.btnAgain.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.btnAgain.Font = new System.Drawing.Font("Perpetua", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAgain.ForeColor = System.Drawing.Color.Blue;
      this.btnAgain.Location = new System.Drawing.Point(97, 335);
      this.btnAgain.Name = "btnAgain";
      this.btnAgain.Size = new System.Drawing.Size(236, 104);
      this.btnAgain.TabIndex = 7;
      this.btnAgain.Text = "TRY AGAIN";
      this.btnAgain.UseVisualStyleBackColor = false;
      this.btnAgain.Click += new System.EventHandler(this.btnAgain_Click);
      // 
      // btnQuit
      // 
      this.btnQuit.BackColor = System.Drawing.Color.Black;
      this.btnQuit.Font = new System.Drawing.Font("Perpetua", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnQuit.ForeColor = System.Drawing.Color.Red;
      this.btnQuit.Location = new System.Drawing.Point(865, 335);
      this.btnQuit.Name = "btnQuit";
      this.btnQuit.Size = new System.Drawing.Size(236, 104);
      this.btnQuit.TabIndex = 8;
      this.btnQuit.Text = "QUIT";
      this.btnQuit.UseVisualStyleBackColor = false;
      this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
      // 
      // FrmWon
      // 
      this.ClientSize = new System.Drawing.Size(1186, 510);
      this.Controls.Add(this.btnQuit);
      this.Controls.Add(this.btnAgain);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.picPeanuts);
      this.Name = "FrmWon";
      ((System.ComponentModel.ISupportInitialize)(this.picPeanuts)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox picPeanuts;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnAgain;
    private System.Windows.Forms.Button btnQuit;
  }
}
