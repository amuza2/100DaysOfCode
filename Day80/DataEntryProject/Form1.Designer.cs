namespace DataEntryProject
{
    partial class frmDataEntry
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
            this.grbDataEntry = new Guna.UI2.WinForms.Guna2GroupBox();
            this.grbTimer = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtName = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtAddress = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txtCity = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtState = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtZip = new Guna.UI.WinForms.GunaTextBox();
            this.btnAccept = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnStart = new Guna.UI2.WinForms.Guna2Button();
            this.btnPause = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimer = new Guna.UI.WinForms.GunaTextBox();
            this.timTimer = new System.Windows.Forms.Timer(this.components);
            this.grbDataEntry.SuspendLayout();
            this.grbTimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDataEntry
            // 
            this.grbDataEntry.Controls.Add(this.btnClear);
            this.grbDataEntry.Controls.Add(this.btnAccept);
            this.grbDataEntry.Controls.Add(this.txtZip);
            this.grbDataEntry.Controls.Add(this.gunaLabel5);
            this.grbDataEntry.Controls.Add(this.txtState);
            this.grbDataEntry.Controls.Add(this.gunaLabel4);
            this.grbDataEntry.Controls.Add(this.txtCity);
            this.grbDataEntry.Controls.Add(this.gunaLabel3);
            this.grbDataEntry.Controls.Add(this.txtAddress);
            this.grbDataEntry.Controls.Add(this.gunaLabel2);
            this.grbDataEntry.Controls.Add(this.txtName);
            this.grbDataEntry.Controls.Add(this.gunaLabel1);
            this.grbDataEntry.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grbDataEntry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grbDataEntry.Location = new System.Drawing.Point(12, 31);
            this.grbDataEntry.Name = "grbDataEntry";
            this.grbDataEntry.ShadowDecoration.Parent = this.grbDataEntry;
            this.grbDataEntry.Size = new System.Drawing.Size(300, 391);
            this.grbDataEntry.TabIndex = 0;
            this.grbDataEntry.Text = "Data Entry";
            // 
            // grbTimer
            // 
            this.grbTimer.Controls.Add(this.txtTimer);
            this.grbTimer.Controls.Add(this.btnExit);
            this.grbTimer.Controls.Add(this.btnPause);
            this.grbTimer.Controls.Add(this.btnStart);
            this.grbTimer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grbTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grbTimer.Location = new System.Drawing.Point(354, 31);
            this.grbTimer.Name = "grbTimer";
            this.grbTimer.ShadowDecoration.Parent = this.grbTimer;
            this.grbTimer.Size = new System.Drawing.Size(300, 391);
            this.grbTimer.TabIndex = 1;
            this.grbTimer.Text = "Timer";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(26, 84);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(39, 15);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.BaseColor = System.Drawing.Color.White;
            this.txtName.BorderColor = System.Drawing.Color.Silver;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.Location = new System.Drawing.Point(83, 76);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(194, 30);
            this.txtName.TabIndex = 0;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(26, 130);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(49, 15);
            this.gunaLabel2.TabIndex = 0;
            this.gunaLabel2.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.BaseColor = System.Drawing.Color.White;
            this.txtAddress.BorderColor = System.Drawing.Color.Silver;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAddress.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAddress.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.Location = new System.Drawing.Point(83, 122);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(194, 30);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(26, 177);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(28, 15);
            this.gunaLabel3.TabIndex = 0;
            this.gunaLabel3.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.BaseColor = System.Drawing.Color.White;
            this.txtCity.BorderColor = System.Drawing.Color.Silver;
            this.txtCity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCity.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCity.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCity.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCity.Location = new System.Drawing.Point(83, 169);
            this.txtCity.Name = "txtCity";
            this.txtCity.PasswordChar = '\0';
            this.txtCity.SelectedText = "";
            this.txtCity.Size = new System.Drawing.Size(194, 30);
            this.txtCity.TabIndex = 3;
            this.txtCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(26, 222);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(33, 15);
            this.gunaLabel4.TabIndex = 0;
            this.gunaLabel4.Text = "State";
            // 
            // txtState
            // 
            this.txtState.BaseColor = System.Drawing.Color.White;
            this.txtState.BorderColor = System.Drawing.Color.Silver;
            this.txtState.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtState.FocusedBaseColor = System.Drawing.Color.White;
            this.txtState.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtState.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtState.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtState.Location = new System.Drawing.Point(83, 214);
            this.txtState.Name = "txtState";
            this.txtState.PasswordChar = '\0';
            this.txtState.SelectedText = "";
            this.txtState.Size = new System.Drawing.Size(194, 30);
            this.txtState.TabIndex = 4;
            this.txtState.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(26, 268);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(24, 15);
            this.gunaLabel5.TabIndex = 0;
            this.gunaLabel5.Text = "Zip";
            // 
            // txtZip
            // 
            this.txtZip.BaseColor = System.Drawing.Color.White;
            this.txtZip.BorderColor = System.Drawing.Color.Silver;
            this.txtZip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtZip.FocusedBaseColor = System.Drawing.Color.White;
            this.txtZip.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtZip.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtZip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtZip.Location = new System.Drawing.Point(83, 260);
            this.txtZip.Name = "txtZip";
            this.txtZip.PasswordChar = '\0';
            this.txtZip.SelectedText = "";
            this.txtZip.Size = new System.Drawing.Size(194, 30);
            this.txtZip.TabIndex = 5;
            this.txtZip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // btnAccept
            // 
            this.btnAccept.Animated = true;
            this.btnAccept.AutoRoundedCorners = true;
            this.btnAccept.BackColor = System.Drawing.Color.Transparent;
            this.btnAccept.BorderRadius = 15;
            this.btnAccept.CheckedState.Parent = this.btnAccept;
            this.btnAccept.CustomImages.Parent = this.btnAccept;
            this.btnAccept.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAccept.ForeColor = System.Drawing.Color.White;
            this.btnAccept.HoverState.Parent = this.btnAccept;
            this.btnAccept.Location = new System.Drawing.Point(29, 325);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.ShadowDecoration.Parent = this.btnAccept;
            this.btnAccept.Size = new System.Drawing.Size(111, 32);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "Accept";
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnClear
            // 
            this.btnClear.Animated = true;
            this.btnClear.AutoRoundedCorners = true;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BorderRadius = 15;
            this.btnClear.CheckedState.Parent = this.btnClear;
            this.btnClear.CustomImages.Parent = this.btnClear;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.HoverState.Parent = this.btnClear;
            this.btnClear.Location = new System.Drawing.Point(166, 325);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(111, 32);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnStart
            // 
            this.btnStart.Animated = true;
            this.btnStart.AutoRoundedCorners = true;
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BorderRadius = 15;
            this.btnStart.CheckedState.Parent = this.btnStart;
            this.btnStart.CustomImages.Parent = this.btnStart;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.HoverState.Parent = this.btnStart;
            this.btnStart.Location = new System.Drawing.Point(89, 130);
            this.btnStart.Name = "btnStart";
            this.btnStart.ShadowDecoration.Parent = this.btnStart;
            this.btnStart.Size = new System.Drawing.Size(111, 32);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Animated = true;
            this.btnPause.AutoRoundedCorners = true;
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.BorderRadius = 15;
            this.btnPause.CheckedState.Parent = this.btnPause;
            this.btnPause.CustomImages.Parent = this.btnPause;
            this.btnPause.Enabled = false;
            this.btnPause.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPause.ForeColor = System.Drawing.Color.White;
            this.btnPause.HoverState.Parent = this.btnPause;
            this.btnPause.Location = new System.Drawing.Point(89, 193);
            this.btnPause.Name = "btnPause";
            this.btnPause.ShadowDecoration.Parent = this.btnPause;
            this.btnPause.Size = new System.Drawing.Size(111, 32);
            this.btnPause.TabIndex = 9;
            this.btnPause.Text = "Pause";
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnExit
            // 
            this.btnExit.Animated = true;
            this.btnExit.AutoRoundedCorners = true;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderRadius = 15;
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Location = new System.Drawing.Point(89, 325);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(111, 32);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtTimer
            // 
            this.txtTimer.BaseColor = System.Drawing.Color.White;
            this.txtTimer.BorderColor = System.Drawing.Color.Silver;
            this.txtTimer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimer.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTimer.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTimer.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTimer.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimer.Location = new System.Drawing.Point(67, 69);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.PasswordChar = '\0';
            this.txtTimer.ReadOnly = true;
            this.txtTimer.SelectedText = "";
            this.txtTimer.Size = new System.Drawing.Size(160, 38);
            this.txtTimer.TabIndex = 0;
            this.txtTimer.Text = "00:00:00";
            this.txtTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timTimer
            // 
            this.timTimer.Interval = 1000;
            this.timTimer.Tick += new System.EventHandler(this.timTimer_Tick);
            // 
            // frmDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbTimer);
            this.Controls.Add(this.grbDataEntry);
            this.Name = "frmDataEntry";
            this.Text = "Data Entry Form";
            this.grbDataEntry.ResumeLayout(false);
            this.grbDataEntry.PerformLayout();
            this.grbTimer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox grbDataEntry;
        private Guna.UI2.WinForms.Guna2GroupBox grbTimer;
        private Guna.UI.WinForms.GunaTextBox txtZip;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox txtState;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txtCity;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox txtAddress;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtName;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnAccept;
        private Guna.UI.WinForms.GunaTextBox txtTimer;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnPause;
        private Guna.UI2.WinForms.Guna2Button btnStart;
        private System.Windows.Forms.Timer timTimer;
    }
}

