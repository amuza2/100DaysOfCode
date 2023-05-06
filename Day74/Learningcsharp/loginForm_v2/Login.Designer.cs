namespace loginForm_v2
{
    partial class LoginForm
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
            lblFirstName = new Label();
            lblLastName = new Label();
            lblEmail = new Label();
            txbFirstName = new TextBox();
            txbLastName = new TextBox();
            txbEmail = new TextBox();
            lblServices = new Label();
            chbSMSNotification = new CheckBox();
            chbReports = new CheckBox();
            chbTransactionReports = new CheckBox();
            lblSMSCharges = new Label();
            lblReportCharges = new Label();
            lblTransactionReports = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(169, 72);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(115, 27);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(169, 134);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(113, 27);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "Last name:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(209, 191);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(71, 27);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            // 
            // txbFirstName
            // 
            txbFirstName.Location = new Point(304, 69);
            txbFirstName.Name = "txbFirstName";
            txbFirstName.Size = new Size(528, 34);
            txbFirstName.TabIndex = 1;
            // 
            // txbLastName
            // 
            txbLastName.Location = new Point(304, 127);
            txbLastName.Name = "txbLastName";
            txbLastName.Size = new Size(528, 34);
            txbLastName.TabIndex = 2;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(304, 188);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(528, 34);
            txbEmail.TabIndex = 3;
            // 
            // lblServices
            // 
            lblServices.AutoSize = true;
            lblServices.Location = new Point(181, 265);
            lblServices.Name = "lblServices";
            lblServices.Size = new Size(95, 27);
            lblServices.TabIndex = 0;
            lblServices.Text = "Services:";
            // 
            // chbSMSNotification
            // 
            chbSMSNotification.AutoSize = true;
            chbSMSNotification.Location = new Point(304, 313);
            chbSMSNotification.Name = "chbSMSNotification";
            chbSMSNotification.Size = new Size(186, 31);
            chbSMSNotification.TabIndex = 4;
            chbSMSNotification.Text = "SMS Notification";
            chbSMSNotification.UseVisualStyleBackColor = true;
            chbSMSNotification.CheckedChanged += chbSMSNotification_CheckedChanged;
            // 
            // chbReports
            // 
            chbReports.AutoSize = true;
            chbReports.Location = new Point(304, 350);
            chbReports.Name = "chbReports";
            chbReports.Size = new Size(102, 31);
            chbReports.TabIndex = 5;
            chbReports.Text = "Reports";
            chbReports.UseVisualStyleBackColor = true;
            chbReports.CheckedChanged += chbReports_CheckedChanged;
            // 
            // chbTransactionReports
            // 
            chbTransactionReports.AutoSize = true;
            chbTransactionReports.Location = new Point(304, 387);
            chbTransactionReports.Name = "chbTransactionReports";
            chbTransactionReports.Size = new Size(213, 31);
            chbTransactionReports.TabIndex = 6;
            chbTransactionReports.Text = "Transaction Reports";
            chbTransactionReports.UseVisualStyleBackColor = true;
            chbTransactionReports.CheckedChanged += chbTransactionReports_CheckedChanged;
            // 
            // lblSMSCharges
            // 
            lblSMSCharges.AutoSize = true;
            lblSMSCharges.ForeColor = Color.Firebrick;
            lblSMSCharges.Location = new Point(515, 314);
            lblSMSCharges.Name = "lblSMSCharges";
            lblSMSCharges.Size = new Size(36, 27);
            lblSMSCharges.TabIndex = 0;
            lblSMSCharges.Text = "....";
            // 
            // lblReportCharges
            // 
            lblReportCharges.AutoSize = true;
            lblReportCharges.ForeColor = Color.Firebrick;
            lblReportCharges.Location = new Point(515, 351);
            lblReportCharges.Name = "lblReportCharges";
            lblReportCharges.Size = new Size(36, 27);
            lblReportCharges.TabIndex = 0;
            lblReportCharges.Text = "....";
            // 
            // lblTransactionReports
            // 
            lblTransactionReports.AutoSize = true;
            lblTransactionReports.ForeColor = Color.Firebrick;
            lblTransactionReports.Location = new Point(515, 388);
            lblTransactionReports.Name = "lblTransactionReports";
            lblTransactionReports.Size = new Size(36, 27);
            lblTransactionReports.TabIndex = 0;
            lblTransactionReports.Text = "....";
            // 
            // button1
            // 
            button1.Font = new Font("Monda Bold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(728, 460);
            button1.Name = "button1";
            button1.Size = new Size(104, 46);
            button1.TabIndex = 7;
            button1.Text = "Sign up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += signup;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(12F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 542);
            Controls.Add(button1);
            Controls.Add(lblTransactionReports);
            Controls.Add(lblReportCharges);
            Controls.Add(lblSMSCharges);
            Controls.Add(chbTransactionReports);
            Controls.Add(chbReports);
            Controls.Add(chbSMSNotification);
            Controls.Add(txbEmail);
            Controls.Add(txbLastName);
            Controls.Add(txbFirstName);
            Controls.Add(lblServices);
            Controls.Add(lblEmail);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Font = new Font("Monda", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private Label lblLastName;
        private Label lblEmail;
        private TextBox txbFirstName;
        private TextBox txbLastName;
        private TextBox txbEmail;
        private Label lblServices;
        private CheckBox chbSMSNotification;
        private CheckBox chbReports;
        private CheckBox chbTransactionReports;
        private Label lblSMSCharges;
        private Label lblReportCharges;
        private Label lblTransactionReports;
        private Button button1;
    }
}