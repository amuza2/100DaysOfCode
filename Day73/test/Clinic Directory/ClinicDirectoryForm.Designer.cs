namespace Clinic_Directory
{
    partial class ClinicDirectoryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboboxClinics = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboboxDoctors = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblClinicName = new System.Windows.Forms.Label();
            this.lblClinicAddress = new System.Windows.Forms.Label();
            this.lblClinicNumber = new System.Windows.Forms.Label();
            this.lblClinicRating = new System.Windows.Forms.Label();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.lblDoctorSpeciality = new System.Windows.Forms.Label();
            this.lblDoctorContact = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("KenPixel", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a clinic to get details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("KenPixel", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(551, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select a doctor to get details";
            // 
            // comboboxClinics
            // 
            this.comboboxClinics.Animated = true;
            this.comboboxClinics.AutoRoundedCorners = true;
            this.comboboxClinics.BackColor = System.Drawing.Color.Transparent;
            this.comboboxClinics.BorderRadius = 17;
            this.comboboxClinics.DisplayMember = "Select";
            this.comboboxClinics.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboboxClinics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxClinics.FocusedColor = System.Drawing.Color.Empty;
            this.comboboxClinics.FocusedState.Parent = this.comboboxClinics;
            this.comboboxClinics.Font = new System.Drawing.Font("KenPixel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboboxClinics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboboxClinics.FormattingEnabled = true;
            this.comboboxClinics.HoverState.Parent = this.comboboxClinics;
            this.comboboxClinics.ItemHeight = 30;
            this.comboboxClinics.ItemsAppearance.Parent = this.comboboxClinics;
            this.comboboxClinics.Location = new System.Drawing.Point(29, 69);
            this.comboboxClinics.Name = "comboboxClinics";
            this.comboboxClinics.ShadowDecoration.Parent = this.comboboxClinics;
            this.comboboxClinics.Size = new System.Drawing.Size(319, 36);
            this.comboboxClinics.TabIndex = 1;
            this.comboboxClinics.SelectedIndexChanged += new System.EventHandler(this.comboboxClinics_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("KenPixel", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Clinic name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("KenPixel", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Clinic address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("KenPixel", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Contact number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("KenPixel", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Contact rating:";
            // 
            // comboboxDoctors
            // 
            this.comboboxDoctors.Animated = true;
            this.comboboxDoctors.AutoRoundedCorners = true;
            this.comboboxDoctors.BackColor = System.Drawing.Color.Transparent;
            this.comboboxDoctors.BorderRadius = 17;
            this.comboboxDoctors.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboboxDoctors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxDoctors.FocusedColor = System.Drawing.Color.Empty;
            this.comboboxDoctors.FocusedState.Parent = this.comboboxDoctors;
            this.comboboxDoctors.Font = new System.Drawing.Font("KenPixel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboboxDoctors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboboxDoctors.FormattingEnabled = true;
            this.comboboxDoctors.HoverState.Parent = this.comboboxDoctors;
            this.comboboxDoctors.ItemHeight = 30;
            this.comboboxDoctors.ItemsAppearance.Parent = this.comboboxDoctors;
            this.comboboxDoctors.Location = new System.Drawing.Point(501, 69);
            this.comboboxDoctors.Name = "comboboxDoctors";
            this.comboboxDoctors.ShadowDecoration.Parent = this.comboboxDoctors;
            this.comboboxDoctors.Size = new System.Drawing.Size(339, 36);
            this.comboboxDoctors.TabIndex = 1;
            this.comboboxDoctors.SelectedIndexChanged += new System.EventHandler(this.comboboxDoctors_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("KenPixel", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(498, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Doctor name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("KenPixel", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(498, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Doctor Speciality:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("KenPixel", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(498, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Doctor contact:";
            // 
            // lblClinicName
            // 
            this.lblClinicName.AutoSize = true;
            this.lblClinicName.Font = new System.Drawing.Font("KenPixel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClinicName.Location = new System.Drawing.Point(205, 212);
            this.lblClinicName.Name = "lblClinicName";
            this.lblClinicName.Size = new System.Drawing.Size(87, 16);
            this.lblClinicName.TabIndex = 0;
            this.lblClinicName.Text = "----------";
            // 
            // lblClinicAddress
            // 
            this.lblClinicAddress.AutoSize = true;
            this.lblClinicAddress.Font = new System.Drawing.Font("KenPixel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClinicAddress.Location = new System.Drawing.Point(205, 257);
            this.lblClinicAddress.Name = "lblClinicAddress";
            this.lblClinicAddress.Size = new System.Drawing.Size(87, 16);
            this.lblClinicAddress.TabIndex = 0;
            this.lblClinicAddress.Text = "----------";
            // 
            // lblClinicNumber
            // 
            this.lblClinicNumber.AutoSize = true;
            this.lblClinicNumber.Font = new System.Drawing.Font("KenPixel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClinicNumber.Location = new System.Drawing.Point(205, 299);
            this.lblClinicNumber.Name = "lblClinicNumber";
            this.lblClinicNumber.Size = new System.Drawing.Size(87, 16);
            this.lblClinicNumber.TabIndex = 0;
            this.lblClinicNumber.Text = "----------";
            // 
            // lblClinicRating
            // 
            this.lblClinicRating.AutoSize = true;
            this.lblClinicRating.Font = new System.Drawing.Font("KenPixel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClinicRating.Location = new System.Drawing.Point(205, 340);
            this.lblClinicRating.Name = "lblClinicRating";
            this.lblClinicRating.Size = new System.Drawing.Size(87, 16);
            this.lblClinicRating.TabIndex = 0;
            this.lblClinicRating.Text = "----------";
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Font = new System.Drawing.Font("KenPixel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorName.Location = new System.Drawing.Point(668, 212);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(87, 16);
            this.lblDoctorName.TabIndex = 0;
            this.lblDoctorName.Text = "----------";
            // 
            // lblDoctorSpeciality
            // 
            this.lblDoctorSpeciality.AutoSize = true;
            this.lblDoctorSpeciality.Font = new System.Drawing.Font("KenPixel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorSpeciality.Location = new System.Drawing.Point(668, 257);
            this.lblDoctorSpeciality.Name = "lblDoctorSpeciality";
            this.lblDoctorSpeciality.Size = new System.Drawing.Size(87, 16);
            this.lblDoctorSpeciality.TabIndex = 0;
            this.lblDoctorSpeciality.Text = "----------";
            // 
            // lblDoctorContact
            // 
            this.lblDoctorContact.AutoSize = true;
            this.lblDoctorContact.Font = new System.Drawing.Font("KenPixel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorContact.Location = new System.Drawing.Point(668, 299);
            this.lblDoctorContact.Name = "lblDoctorContact";
            this.lblDoctorContact.Size = new System.Drawing.Size(87, 16);
            this.lblDoctorContact.TabIndex = 0;
            this.lblDoctorContact.Text = "----------";
            // 
            // ClinicDirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 489);
            this.Controls.Add(this.comboboxDoctors);
            this.Controls.Add(this.comboboxClinics);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDoctorContact);
            this.Controls.Add(this.lblDoctorSpeciality);
            this.Controls.Add(this.lblDoctorName);
            this.Controls.Add(this.lblClinicRating);
            this.Controls.Add(this.lblClinicNumber);
            this.Controls.Add(this.lblClinicAddress);
            this.Controls.Add(this.lblClinicName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("KenPixel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClinicDirectoryForm";
            this.Text = "Clinic Directory";
            this.Load += new System.EventHandler(this.ClinicDirectoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox comboboxClinics;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox comboboxDoctors;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblClinicName;
        private System.Windows.Forms.Label lblClinicAddress;
        private System.Windows.Forms.Label lblClinicNumber;
        private System.Windows.Forms.Label lblClinicRating;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.Label lblDoctorSpeciality;
        private System.Windows.Forms.Label lblDoctorContact;
    }
}

