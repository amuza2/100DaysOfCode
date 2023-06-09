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
            picGameBoard = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            imageList = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)picGameBoard).BeginInit();
            SuspendLayout();
            // 
            // picGameBoard
            // 
            picGameBoard.Location = new Point(12, 12);
            picGameBoard.Name = "picGameBoard";
            picGameBoard.Size = new Size(478, 426);
            picGameBoard.TabIndex = 0;
            picGameBoard.TabStop = false;
            // 
            // timer
            // 
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth8Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "wall.png");
            imageList.Images.SetKeyName(1, "bonus4.png");
            imageList.Images.SetKeyName(2, "bonus3.png");
            imageList.Images.SetKeyName(3, "bonus2.png");
            imageList.Images.SetKeyName(4, "bonus1.png");
            imageList.Images.SetKeyName(5, "snake_body.png");
            imageList.Images.SetKeyName(6, "snake_head.png");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 450);
            Controls.Add(picGameBoard);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Key_Pressed;
            ((System.ComponentModel.ISupportInitialize)picGameBoard).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picGameBoard;
        private System.Windows.Forms.Timer timer;
        private ImageList imageList;
    }
}