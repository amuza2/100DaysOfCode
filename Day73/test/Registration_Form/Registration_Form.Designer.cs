namespace Registration_Form
{
    partial class Registration_Form
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
            this.gb1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.rdName3 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdName2 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdName1 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.btnSubmit);
            this.gb1.Controls.Add(this.rdName3);
            this.gb1.Controls.Add(this.rdName2);
            this.gb1.Controls.Add(this.rdName1);
            this.gb1.Font = new System.Drawing.Font("KenPixel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gb1.Location = new System.Drawing.Point(267, 53);
            this.gb1.Margin = new System.Windows.Forms.Padding(6);
            this.gb1.Name = "gb1";
            this.gb1.ShadowDecoration.Parent = this.gb1;
            this.gb1.Size = new System.Drawing.Size(275, 328);
            this.gb1.TabIndex = 0;
            this.gb1.Text = "Developer Project";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Animated = true;
            this.btnSubmit.AutoRoundedCorners = true;
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.BorderColor = System.Drawing.Color.Transparent;
            this.btnSubmit.BorderRadius = 21;
            this.btnSubmit.CheckedState.Parent = this.btnSubmit;
            this.btnSubmit.CustomImages.Parent = this.btnSubmit;
            this.btnSubmit.FillColor2 = System.Drawing.Color.CornflowerBlue;
            this.btnSubmit.Font = new System.Drawing.Font("KenPixel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.HoverState.Parent = this.btnSubmit;
            this.btnSubmit.Location = new System.Drawing.Point(37, 259);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.PressedColor = System.Drawing.Color.Aqua;
            this.btnSubmit.ShadowDecoration.Parent = this.btnSubmit;
            this.btnSubmit.Size = new System.Drawing.Size(192, 45);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rdName3
            // 
            this.rdName3.Animated = true;
            this.rdName3.AutoSize = true;
            this.rdName3.BackColor = System.Drawing.Color.Transparent;
            this.rdName3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdName3.CheckedState.BorderThickness = 0;
            this.rdName3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdName3.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdName3.CheckedState.InnerOffset = -4;
            this.rdName3.Font = new System.Drawing.Font("KenPixel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdName3.Location = new System.Drawing.Point(37, 159);
            this.rdName3.Name = "rdName3";
            this.rdName3.Size = new System.Drawing.Size(135, 27);
            this.rdName3.TabIndex = 2;
            this.rdName3.TabStop = true;
            this.rdName3.Text = "Test case 2";
            this.rdName3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdName3.UncheckedState.BorderThickness = 2;
            this.rdName3.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdName3.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdName3.UseVisualStyleBackColor = false;
            // 
            // rdName2
            // 
            this.rdName2.Animated = true;
            this.rdName2.AutoSize = true;
            this.rdName2.BackColor = System.Drawing.Color.Transparent;
            this.rdName2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdName2.CheckedState.BorderThickness = 0;
            this.rdName2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdName2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdName2.CheckedState.InnerOffset = -4;
            this.rdName2.Font = new System.Drawing.Font("KenPixel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdName2.Location = new System.Drawing.Point(37, 110);
            this.rdName2.Name = "rdName2";
            this.rdName2.Size = new System.Drawing.Size(132, 27);
            this.rdName2.TabIndex = 1;
            this.rdName2.TabStop = true;
            this.rdName2.Text = "Test Case 1";
            this.rdName2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdName2.UncheckedState.BorderThickness = 2;
            this.rdName2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdName2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdName2.UseVisualStyleBackColor = false;
            // 
            // rdName1
            // 
            this.rdName1.Animated = true;
            this.rdName1.AutoSize = true;
            this.rdName1.BackColor = System.Drawing.Color.Transparent;
            this.rdName1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdName1.CheckedState.BorderThickness = 0;
            this.rdName1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdName1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdName1.CheckedState.InnerOffset = -4;
            this.rdName1.Font = new System.Drawing.Font("KenPixel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdName1.Location = new System.Drawing.Point(37, 59);
            this.rdName1.Name = "rdName1";
            this.rdName1.Size = new System.Drawing.Size(125, 27);
            this.rdName1.TabIndex = 0;
            this.rdName1.TabStop = true;
            this.rdName1.Text = "Med Chami";
            this.rdName1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdName1.UncheckedState.BorderThickness = 2;
            this.rdName1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdName1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdName1.UseVisualStyleBackColor = false;
            // 
            // Registration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 453);
            this.Controls.Add(this.gb1);
            this.Font = new System.Drawing.Font("KenPixel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Registration_Form";
            this.Text = "Registration Form";
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gb1;
        private Guna.UI2.WinForms.Guna2RadioButton rdName3;
        private Guna.UI2.WinForms.Guna2RadioButton rdName2;
        private Guna.UI2.WinForms.Guna2RadioButton rdName1;
        private Guna.UI2.WinForms.Guna2GradientButton btnSubmit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

