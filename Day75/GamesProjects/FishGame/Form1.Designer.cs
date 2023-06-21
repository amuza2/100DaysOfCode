namespace FishGame
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.picPlayer = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.picEnemy = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picFeedFish = new Guna.UI2.WinForms.Guna2PictureBox();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFeedFish)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.Image = global::FishGame.Properties.Resources.clown_fish;
            this.picPlayer.Location = new System.Drawing.Point(245, 182);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picPlayer.ShadowDecoration.Parent = this.picPlayer;
            this.picPlayer.Size = new System.Drawing.Size(64, 64);
            this.picPlayer.TabIndex = 3;
            this.picPlayer.TabStop = false;
            this.picPlayer.UseTransparentBackground = true;
            this.picPlayer.Click += new System.EventHandler(this.picPlayer_Click);
            // 
            // picEnemy
            // 
            this.picEnemy.BackColor = System.Drawing.Color.Transparent;
            this.picEnemy.Image = global::FishGame.Properties.Resources.puffer_fish;
            this.picEnemy.Location = new System.Drawing.Point(342, 131);
            this.picEnemy.Name = "picEnemy";
            this.picEnemy.ShadowDecoration.Parent = this.picEnemy;
            this.picEnemy.Size = new System.Drawing.Size(68, 66);
            this.picEnemy.TabIndex = 2;
            this.picEnemy.TabStop = false;
            this.picEnemy.UseTransparentBackground = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::FishGame.Properties.Resources.kpBoMZ_2768905381;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(805, 454);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // picFeedFish
            // 
            this.picFeedFish.BackColor = System.Drawing.Color.Transparent;
            this.picFeedFish.Image = global::FishGame.Properties.Resources.clown_fish2;
            this.picFeedFish.Location = new System.Drawing.Point(431, 142);
            this.picFeedFish.Name = "picFeedFish";
            this.picFeedFish.ShadowDecoration.Parent = this.picFeedFish;
            this.picFeedFish.Size = new System.Drawing.Size(35, 35);
            this.picFeedFish.TabIndex = 4;
            this.picFeedFish.TabStop = false;
            this.picFeedFish.UseTransparentBackground = true;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "clown-fish.png");
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2CircleButton1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Image = global::FishGame.Properties.Resources.clown_fish;
            this.guna2CircleButton1.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2CircleButton1.Location = new System.Drawing.Point(376, 203);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(71, 67);
            this.guna2CircleButton1.TabIndex = 5;
            this.guna2CircleButton1.Click += new System.EventHandler(this.Direction_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.picFeedFish);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.picEnemy);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFeedFish)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox picEnemy;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picPlayer;
        private Guna.UI2.WinForms.Guna2PictureBox picFeedFish;
        private System.Windows.Forms.ImageList imageList2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
    }
}

