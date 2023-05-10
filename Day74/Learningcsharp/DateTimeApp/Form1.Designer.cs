namespace DateTimeApp
{
    partial class Home
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
            dateTimePicker = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            showbtn = new Button();
            SuspendLayout();
            // 
            // dateTimePicker
            // 
            dateTimePicker.CalendarFont = new Font("Monda", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker.Font = new Font("Monda", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker.Location = new Point(161, 73);
            dateTimePicker.Margin = new Padding(4);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(464, 30);
            dateTimePicker.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 159);
            label1.Name = "label1";
            label1.Size = new Size(105, 22);
            label1.TabIndex = 1;
            label1.Text = "Date type 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 208);
            label2.Name = "label2";
            label2.Size = new Size(105, 22);
            label2.TabIndex = 1;
            label2.Text = "Date type 2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 257);
            label3.Name = "label3";
            label3.Size = new Size(105, 22);
            label3.TabIndex = 1;
            label3.Text = "Date type 3:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(152, 303);
            label4.Name = "label4";
            label4.Size = new Size(106, 22);
            label4.TabIndex = 1;
            label4.Text = "Time type 1:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(153, 345);
            label5.Name = "label5";
            label5.Size = new Size(106, 22);
            label5.TabIndex = 1;
            label5.Text = "Time type 2:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.DarkOrange;
            label6.Location = new Point(287, 159);
            label6.Name = "label6";
            label6.Size = new Size(170, 22);
            label6.TabIndex = 2;
            label6.Text = "--------------------";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(287, 208);
            label7.Name = "label7";
            label7.Size = new Size(170, 22);
            label7.TabIndex = 2;
            label7.Text = "--------------------";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.DarkOrange;
            label8.Location = new Point(287, 257);
            label8.Name = "label8";
            label8.Size = new Size(170, 22);
            label8.TabIndex = 2;
            label8.Text = "--------------------";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(287, 303);
            label9.Name = "label9";
            label9.Size = new Size(170, 22);
            label9.TabIndex = 2;
            label9.Text = "--------------------";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.DarkOrange;
            label10.Location = new Point(287, 345);
            label10.Name = "label10";
            label10.Size = new Size(170, 22);
            label10.TabIndex = 2;
            label10.Text = "--------------------";
            // 
            // showbtn
            // 
            showbtn.Location = new Point(622, 375);
            showbtn.Name = "showbtn";
            showbtn.Size = new Size(136, 57);
            showbtn.TabIndex = 3;
            showbtn.Text = "show";
            showbtn.UseVisualStyleBackColor = true;
            showbtn.Click += showbtn_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 454);
            Controls.Add(showbtn);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker);
            Font = new Font("Monda", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Home";
            Text = "DateTimeApp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button showbtn;
    }
}