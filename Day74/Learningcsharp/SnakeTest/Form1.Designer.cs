namespace SnakeTest
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
            imageList = new ImageList(components);
            timer = new System.Windows.Forms.Timer(components);
            picBoardGame = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBoardGame).BeginInit();
            SuspendLayout();
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth8Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "wall.png");
            imageList.Images.SetKeyName(1, "snake_head.png");
            imageList.Images.SetKeyName(2, "snake_body.png");
            imageList.Images.SetKeyName(3, "bonus4.png");
            imageList.Images.SetKeyName(4, "bonus3.png");
            imageList.Images.SetKeyName(5, "bonus2.png");
            imageList.Images.SetKeyName(6, "bonus1.png");
            // 
            // timer
            // 
            timer.Interval = 500;
            // 
            // picBoardGame
            // 
            picBoardGame.Location = new Point(12, 29);
            picBoardGame.Name = "picBoardGame";
            picBoardGame.Size = new Size(682, 409);
            picBoardGame.TabIndex = 0;
            picBoardGame.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 450);
            Controls.Add(picBoardGame);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picBoardGame).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ImageList imageList;
        private System.Windows.Forms.Timer timer;
        private PictureBox picBoardGame;
    }
}