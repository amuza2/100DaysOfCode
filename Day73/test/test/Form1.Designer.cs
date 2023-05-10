namespace test
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
            this.btnCheckall = new Guna.UI2.WinForms.Guna2Button();
            this.cbVolant = new System.Windows.Forms.CheckBox();
            this.cbWheel = new System.Windows.Forms.CheckBox();
            this.cbDirection = new System.Windows.Forms.CheckBox();
            this.cbBrakes = new System.Windows.Forms.CheckBox();
            this.cbAbs = new System.Windows.Forms.CheckBox();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.tbPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAucunoptions = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuit = new Guna.UI2.WinForms.Guna2Button();
            this.gbOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheckall
            // 
            this.btnCheckall.Animated = true;
            this.btnCheckall.AutoRoundedCorners = true;
            this.btnCheckall.BorderRadius = 26;
            this.btnCheckall.CheckedState.Parent = this.btnCheckall;
            this.btnCheckall.CustomImages.Parent = this.btnCheckall;
            this.btnCheckall.Font = new System.Drawing.Font("KenPixel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckall.ForeColor = System.Drawing.Color.White;
            this.btnCheckall.HoverState.Parent = this.btnCheckall;
            this.btnCheckall.Location = new System.Drawing.Point(41, 384);
            this.btnCheckall.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckall.Name = "btnCheckall";
            this.btnCheckall.ShadowDecoration.Parent = this.btnCheckall;
            this.btnCheckall.Size = new System.Drawing.Size(332, 55);
            this.btnCheckall.TabIndex = 1;
            this.btnCheckall.Text = "Toutes options";
            this.btnCheckall.Click += new System.EventHandler(this.btnCheckall_Click);
            // 
            // cbVolant
            // 
            this.cbVolant.AutoSize = true;
            this.cbVolant.Location = new System.Drawing.Point(61, 54);
            this.cbVolant.Margin = new System.Windows.Forms.Padding(4);
            this.cbVolant.Name = "cbVolant";
            this.cbVolant.Size = new System.Drawing.Size(152, 24);
            this.cbVolant.TabIndex = 0;
            this.cbVolant.Text = "Volant (8 000$)";
            this.cbVolant.UseVisualStyleBackColor = true;
            this.cbVolant.CheckedChanged += new System.EventHandler(this.cbVolant_CheckedChanged);
            // 
            // cbWheel
            // 
            this.cbWheel.AutoSize = true;
            this.cbWheel.Location = new System.Drawing.Point(61, 105);
            this.cbWheel.Margin = new System.Windows.Forms.Padding(4);
            this.cbWheel.Name = "cbWheel";
            this.cbWheel.Size = new System.Drawing.Size(144, 24);
            this.cbWheel.TabIndex = 0;
            this.cbWheel.Text = "Roues (5 000$)";
            this.cbWheel.UseVisualStyleBackColor = true;
            this.cbWheel.CheckedChanged += new System.EventHandler(this.cbWheel_CheckedChanged);
            // 
            // cbDirection
            // 
            this.cbDirection.AutoSize = true;
            this.cbDirection.Location = new System.Drawing.Point(61, 160);
            this.cbDirection.Margin = new System.Windows.Forms.Padding(4);
            this.cbDirection.Name = "cbDirection";
            this.cbDirection.Size = new System.Drawing.Size(185, 24);
            this.cbDirection.TabIndex = 0;
            this.cbDirection.Text = "Direction (12 000$)";
            this.cbDirection.UseVisualStyleBackColor = true;
            this.cbDirection.CheckedChanged += new System.EventHandler(this.cbDirection_CheckedChanged);
            // 
            // cbBrakes
            // 
            this.cbBrakes.AutoSize = true;
            this.cbBrakes.Location = new System.Drawing.Point(61, 212);
            this.cbBrakes.Margin = new System.Windows.Forms.Padding(4);
            this.cbBrakes.Name = "cbBrakes";
            this.cbBrakes.Size = new System.Drawing.Size(151, 24);
            this.cbBrakes.TabIndex = 0;
            this.cbBrakes.Text = "Friens (4 000$)";
            this.cbBrakes.UseVisualStyleBackColor = true;
            this.cbBrakes.CheckedChanged += new System.EventHandler(this.cbBrakes_CheckedChanged);
            // 
            // cbAbs
            // 
            this.cbAbs.AutoSize = true;
            this.cbAbs.Location = new System.Drawing.Point(61, 260);
            this.cbAbs.Margin = new System.Windows.Forms.Padding(4);
            this.cbAbs.Name = "cbAbs";
            this.cbAbs.Size = new System.Drawing.Size(91, 24);
            this.cbAbs.TabIndex = 0;
            this.cbAbs.Text = "ABS (5$)";
            this.cbAbs.UseVisualStyleBackColor = true;
            this.cbAbs.CheckedChanged += new System.EventHandler(this.cbAbs_CheckedChanged);
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.cbAbs);
            this.gbOptions.Controls.Add(this.cbBrakes);
            this.gbOptions.Controls.Add(this.cbDirection);
            this.gbOptions.Controls.Add(this.cbWheel);
            this.gbOptions.Controls.Add(this.cbVolant);
            this.gbOptions.Font = new System.Drawing.Font("KenPixel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOptions.Location = new System.Drawing.Point(41, 13);
            this.gbOptions.Margin = new System.Windows.Forms.Padding(4);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Padding = new System.Windows.Forms.Padding(4);
            this.gbOptions.Size = new System.Drawing.Size(332, 311);
            this.gbOptions.TabIndex = 0;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // tbPrice
            // 
            this.tbPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPrice.DefaultText = "";
            this.tbPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPrice.DisabledState.Parent = this.tbPrice;
            this.tbPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPrice.Enabled = false;
            this.tbPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPrice.FocusedState.Parent = this.tbPrice;
            this.tbPrice.Font = new System.Drawing.Font("KenPixel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPrice.HoverState.Parent = this.tbPrice;
            this.tbPrice.Location = new System.Drawing.Point(41, 332);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.PasswordChar = '\0';
            this.tbPrice.PlaceholderText = "";
            this.tbPrice.SelectedText = "";
            this.tbPrice.ShadowDecoration.Parent = this.tbPrice;
            this.tbPrice.Size = new System.Drawing.Size(332, 44);
            this.tbPrice.TabIndex = 2;
            this.tbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAucunoptions
            // 
            this.btnAucunoptions.Animated = true;
            this.btnAucunoptions.AutoRoundedCorners = true;
            this.btnAucunoptions.BorderRadius = 26;
            this.btnAucunoptions.CheckedState.Parent = this.btnAucunoptions;
            this.btnAucunoptions.CustomImages.Parent = this.btnAucunoptions;
            this.btnAucunoptions.Font = new System.Drawing.Font("KenPixel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAucunoptions.ForeColor = System.Drawing.Color.White;
            this.btnAucunoptions.HoverState.Parent = this.btnAucunoptions;
            this.btnAucunoptions.Location = new System.Drawing.Point(41, 468);
            this.btnAucunoptions.Margin = new System.Windows.Forms.Padding(4);
            this.btnAucunoptions.Name = "btnAucunoptions";
            this.btnAucunoptions.ShadowDecoration.Parent = this.btnAucunoptions;
            this.btnAucunoptions.Size = new System.Drawing.Size(332, 55);
            this.btnAucunoptions.TabIndex = 1;
            this.btnAucunoptions.Text = "Aucun Option";
            this.btnAucunoptions.Click += new System.EventHandler(this.btnAucunoptions_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Animated = true;
            this.btnQuit.AutoRoundedCorners = true;
            this.btnQuit.BorderRadius = 26;
            this.btnQuit.CheckedState.Parent = this.btnQuit;
            this.btnQuit.CustomImages.Parent = this.btnQuit;
            this.btnQuit.Font = new System.Drawing.Font("KenPixel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.HoverState.Parent = this.btnQuit;
            this.btnQuit.Location = new System.Drawing.Point(41, 545);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.ShadowDecoration.Parent = this.btnQuit;
            this.btnQuit.Size = new System.Drawing.Size(332, 55);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "Quiter";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 647);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnAucunoptions);
            this.Controls.Add(this.btnCheckall);
            this.Controls.Add(this.gbOptions);
            this.Font = new System.Drawing.Font("KenPixel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnCheckall;
        private System.Windows.Forms.CheckBox cbVolant;
        private System.Windows.Forms.CheckBox cbWheel;
        private System.Windows.Forms.CheckBox cbDirection;
        private System.Windows.Forms.CheckBox cbBrakes;
        private System.Windows.Forms.CheckBox cbAbs;
        private System.Windows.Forms.GroupBox gbOptions;
        private Guna.UI2.WinForms.Guna2TextBox tbPrice;
        private Guna.UI2.WinForms.Guna2Button btnAucunoptions;
        private Guna.UI2.WinForms.Guna2Button btnQuit;
    }
}

