namespace SnakeGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            picBoardGame = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            imgList = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)picBoardGame).BeginInit();
            SuspendLayout();
            // 
            // picBoardGame
            // 
            picBoardGame.Location = new Point(24, 18);
            picBoardGame.Name = "picBoardGame";
            picBoardGame.Size = new Size(420, 420);
            picBoardGame.TabIndex = 0;
            picBoardGame.TabStop = false;
            // 
            // timer
            // 
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            // 
            // imgList
            // 
            imgList.ColorDepth = ColorDepth.Depth8Bit;
            imgList.ImageStream = (ImageListStreamer)resources.GetObject("imgList.ImageStream");
            imgList.TransparentColor = Color.Transparent;
            imgList.Images.SetKeyName(0, "bonus1.png");
            imgList.Images.SetKeyName(1, "bonus2.png");
            imgList.Images.SetKeyName(2, "bonus3.png");
            imgList.Images.SetKeyName(3, "bonus4.png");
            imgList.Images.SetKeyName(4, "snake_body.png");
            imgList.Images.SetKeyName(5, "snake_head.png");
            imgList.Images.SetKeyName(6, "wall.png");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 450);
            Controls.Add(picBoardGame);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += frmSnake_KeyDown;
            ((System.ComponentModel.ISupportInitialize)picBoardGame).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picBoardGame;
        private System.Windows.Forms.Timer timer;
        private ImageList imgList;
    }
}