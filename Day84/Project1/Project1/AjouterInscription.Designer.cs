﻿namespace Project1
{
    partial class AjouterInscription
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCodeProjet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerInscription = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txbFonction = new System.Windows.Forms.TextBox();
            this.txbPrenom = new System.Windows.Forms.TextBox();
            this.txbNom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbNumEploye = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAjouterEmployeRecrute = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txbDu = new System.Windows.Forms.TextBox();
            this.txbAu = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbAu);
            this.groupBox1.Controls.Add(this.txbDu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbCodeProjet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Projet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Au:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Du:";
            // 
            // cmbCodeProjet
            // 
            this.cmbCodeProjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCodeProjet.FormattingEnabled = true;
            this.cmbCodeProjet.Location = new System.Drawing.Point(145, 30);
            this.cmbCodeProjet.Name = "cmbCodeProjet";
            this.cmbCodeProjet.Size = new System.Drawing.Size(237, 28);
            this.cmbCodeProjet.TabIndex = 1;
            this.cmbCodeProjet.SelectedIndexChanged += new System.EventHandler(this.cmbCodeProjet_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code Projet:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePickerInscription);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(16, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 75);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inscription";
            // 
            // dateTimePickerInscription
            // 
            this.dateTimePickerInscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerInscription.Location = new System.Drawing.Point(145, 31);
            this.dateTimePickerInscription.Name = "dateTimePickerInscription";
            this.dateTimePickerInscription.Size = new System.Drawing.Size(237, 26);
            this.dateTimePickerInscription.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date D\'inscription:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txbFonction);
            this.groupBox3.Controls.Add(this.txbPrenom);
            this.groupBox3.Controls.Add(this.txbNom);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cmbNumEploye);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(416, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(372, 244);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Employe";
            // 
            // txbFonction
            // 
            this.txbFonction.Enabled = false;
            this.txbFonction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFonction.Location = new System.Drawing.Point(135, 196);
            this.txbFonction.Name = "txbFonction";
            this.txbFonction.Size = new System.Drawing.Size(231, 26);
            this.txbFonction.TabIndex = 2;
            // 
            // txbPrenom
            // 
            this.txbPrenom.Enabled = false;
            this.txbPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrenom.Location = new System.Drawing.Point(135, 141);
            this.txbPrenom.Name = "txbPrenom";
            this.txbPrenom.Size = new System.Drawing.Size(231, 26);
            this.txbPrenom.TabIndex = 2;
            // 
            // txbNom
            // 
            this.txbNom.Enabled = false;
            this.txbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNom.Location = new System.Drawing.Point(135, 86);
            this.txbNom.Name = "txbNom";
            this.txbNom.Size = new System.Drawing.Size(231, 26);
            this.txbNom.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Fonction:";
            // 
            // cmbNumEploye
            // 
            this.cmbNumEploye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNumEploye.FormattingEnabled = true;
            this.cmbNumEploye.Location = new System.Drawing.Point(135, 29);
            this.cmbNumEploye.Name = "cmbNumEploye";
            this.cmbNumEploye.Size = new System.Drawing.Size(231, 28);
            this.cmbNumEploye.TabIndex = 2;
            this.cmbNumEploye.SelectedIndexChanged += new System.EventHandler(this.cmbNumEploye_SelectedIndexChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Prenom:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nom:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Num Employe:";
            // 
            // btnAjouterEmployeRecrute
            // 
            this.btnAjouterEmployeRecrute.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAjouterEmployeRecrute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterEmployeRecrute.Location = new System.Drawing.Point(270, 294);
            this.btnAjouterEmployeRecrute.Name = "btnAjouterEmployeRecrute";
            this.btnAjouterEmployeRecrute.Size = new System.Drawing.Size(203, 32);
            this.btnAjouterEmployeRecrute.TabIndex = 3;
            this.btnAjouterEmployeRecrute.Text = "Neuvaux Employe recruté";
            this.btnAjouterEmployeRecrute.UseVisualStyleBackColor = false;
            this.btnAjouterEmployeRecrute.Click += new System.EventHandler(this.btnAjouterEmployeRecrute_Click);
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(510, 294);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(130, 32);
            this.btnValider.TabIndex = 3;
            this.btnValider.Text = "Validation";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(675, 294);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "Annulé";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txbDu
            // 
            this.txbDu.Enabled = false;
            this.txbDu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDu.Location = new System.Drawing.Point(145, 78);
            this.txbDu.Name = "txbDu";
            this.txbDu.Size = new System.Drawing.Size(237, 26);
            this.txbDu.TabIndex = 2;
            // 
            // txbAu
            // 
            this.txbAu.Enabled = false;
            this.txbAu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAu.Location = new System.Drawing.Point(145, 124);
            this.txbAu.Name = "txbAu";
            this.txbAu.Size = new System.Drawing.Size(237, 26);
            this.txbAu.TabIndex = 2;
            // 
            // AjouterInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 340);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnAjouterEmployeRecrute);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AjouterInscription";
            this.Text = "AjouterInscription";
            this.Load += new System.EventHandler(this.AjouterInscription_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCodeProjet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePickerInscription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbNumEploye;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbPrenom;
        private System.Windows.Forms.TextBox txbNom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbFonction;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAjouterEmployeRecrute;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txbAu;
        private System.Windows.Forms.TextBox txbDu;
    }
}