namespace Project1
{
    partial class Main
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
            this.grbEmploye = new System.Windows.Forms.GroupBox();
            this.btnEmployeRechercher = new System.Windows.Forms.Button();
            this.btnEmployeConsulter = new System.Windows.Forms.Button();
            this.btnEmployeAjouter = new System.Windows.Forms.Button();
            this.btnProjetAjouter = new System.Windows.Forms.Button();
            this.grbDate = new System.Windows.Forms.GroupBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.grbInscription = new System.Windows.Forms.GroupBox();
            this.btnInscriptionCreation = new System.Windows.Forms.Button();
            this.grbProjet = new System.Windows.Forms.GroupBox();
            this.btnProjetConsulter = new System.Windows.Forms.Button();
            this.grbEmploye.SuspendLayout();
            this.grbDate.SuspendLayout();
            this.grbInscription.SuspendLayout();
            this.grbProjet.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbEmploye
            // 
            this.grbEmploye.Controls.Add(this.btnEmployeRechercher);
            this.grbEmploye.Controls.Add(this.btnEmployeConsulter);
            this.grbEmploye.Controls.Add(this.btnEmployeAjouter);
            this.grbEmploye.Location = new System.Drawing.Point(39, 22);
            this.grbEmploye.Name = "grbEmploye";
            this.grbEmploye.Size = new System.Drawing.Size(336, 239);
            this.grbEmploye.TabIndex = 0;
            this.grbEmploye.TabStop = false;
            this.grbEmploye.Text = "Employe";
            // 
            // btnEmployeRechercher
            // 
            this.btnEmployeRechercher.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEmployeRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeRechercher.Location = new System.Drawing.Point(39, 87);
            this.btnEmployeRechercher.Name = "btnEmployeRechercher";
            this.btnEmployeRechercher.Size = new System.Drawing.Size(265, 36);
            this.btnEmployeRechercher.TabIndex = 0;
            this.btnEmployeRechercher.Text = "Rechercher Employe";
            this.btnEmployeRechercher.UseVisualStyleBackColor = false;
            this.btnEmployeRechercher.Click += new System.EventHandler(this.btnEmployeRechercher_Click);
            // 
            // btnEmployeConsulter
            // 
            this.btnEmployeConsulter.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEmployeConsulter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeConsulter.Location = new System.Drawing.Point(39, 155);
            this.btnEmployeConsulter.Name = "btnEmployeConsulter";
            this.btnEmployeConsulter.Size = new System.Drawing.Size(265, 36);
            this.btnEmployeConsulter.TabIndex = 0;
            this.btnEmployeConsulter.Text = "Consulter Employe";
            this.btnEmployeConsulter.UseVisualStyleBackColor = false;
            this.btnEmployeConsulter.Click += new System.EventHandler(this.btnEmployeConsulter_Click);
            // 
            // btnEmployeAjouter
            // 
            this.btnEmployeAjouter.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEmployeAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeAjouter.Location = new System.Drawing.Point(39, 19);
            this.btnEmployeAjouter.Name = "btnEmployeAjouter";
            this.btnEmployeAjouter.Size = new System.Drawing.Size(265, 36);
            this.btnEmployeAjouter.TabIndex = 0;
            this.btnEmployeAjouter.Text = "Ajouter Employe";
            this.btnEmployeAjouter.UseVisualStyleBackColor = false;
            this.btnEmployeAjouter.Click += new System.EventHandler(this.btnEmployeAjouter_Click);
            // 
            // btnProjetAjouter
            // 
            this.btnProjetAjouter.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnProjetAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjetAjouter.Location = new System.Drawing.Point(67, 19);
            this.btnProjetAjouter.Name = "btnProjetAjouter";
            this.btnProjetAjouter.Size = new System.Drawing.Size(265, 36);
            this.btnProjetAjouter.TabIndex = 0;
            this.btnProjetAjouter.Text = "Ajouter Projet";
            this.btnProjetAjouter.UseVisualStyleBackColor = false;
            this.btnProjetAjouter.Click += new System.EventHandler(this.btnProjetAjouter_Click);
            // 
            // grbDate
            // 
            this.grbDate.Controls.Add(this.lblDate);
            this.grbDate.Location = new System.Drawing.Point(220, 267);
            this.grbDate.Name = "grbDate";
            this.grbDate.Size = new System.Drawing.Size(368, 61);
            this.grbDate.TabIndex = 1;
            this.grbDate.TabStop = false;
            this.grbDate.Text = "Date du jour";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(128, 29);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(51, 20);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "label1";
            // 
            // grbInscription
            // 
            this.grbInscription.Controls.Add(this.btnInscriptionCreation);
            this.grbInscription.Location = new System.Drawing.Point(387, 158);
            this.grbInscription.Name = "grbInscription";
            this.grbInscription.Size = new System.Drawing.Size(370, 66);
            this.grbInscription.TabIndex = 2;
            this.grbInscription.TabStop = false;
            this.grbInscription.Text = "Inscription";
            // 
            // btnInscriptionCreation
            // 
            this.btnInscriptionCreation.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnInscriptionCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscriptionCreation.Location = new System.Drawing.Point(67, 19);
            this.btnInscriptionCreation.Name = "btnInscriptionCreation";
            this.btnInscriptionCreation.Size = new System.Drawing.Size(265, 36);
            this.btnInscriptionCreation.TabIndex = 0;
            this.btnInscriptionCreation.Text = "Creation";
            this.btnInscriptionCreation.UseVisualStyleBackColor = false;
            this.btnInscriptionCreation.Click += new System.EventHandler(this.btnInscriptionCreation_Click);
            // 
            // grbProjet
            // 
            this.grbProjet.Controls.Add(this.btnProjetConsulter);
            this.grbProjet.Controls.Add(this.btnProjetAjouter);
            this.grbProjet.Location = new System.Drawing.Point(387, 22);
            this.grbProjet.Name = "grbProjet";
            this.grbProjet.Size = new System.Drawing.Size(370, 130);
            this.grbProjet.TabIndex = 3;
            this.grbProjet.TabStop = false;
            this.grbProjet.Text = "Projet";
            // 
            // btnProjetConsulter
            // 
            this.btnProjetConsulter.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnProjetConsulter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjetConsulter.Location = new System.Drawing.Point(67, 75);
            this.btnProjetConsulter.Name = "btnProjetConsulter";
            this.btnProjetConsulter.Size = new System.Drawing.Size(265, 36);
            this.btnProjetConsulter.TabIndex = 0;
            this.btnProjetConsulter.Text = "Consulter Projet";
            this.btnProjetConsulter.UseVisualStyleBackColor = false;
            this.btnProjetConsulter.Click += new System.EventHandler(this.btnProjetConsulter_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 336);
            this.Controls.Add(this.grbProjet);
            this.Controls.Add(this.grbInscription);
            this.Controls.Add(this.grbDate);
            this.Controls.Add(this.grbEmploye);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.grbEmploye.ResumeLayout(false);
            this.grbDate.ResumeLayout(false);
            this.grbDate.PerformLayout();
            this.grbInscription.ResumeLayout(false);
            this.grbProjet.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEmploye;
        private System.Windows.Forms.Button btnEmployeRechercher;
        private System.Windows.Forms.Button btnEmployeConsulter;
        private System.Windows.Forms.Button btnProjetAjouter;
        private System.Windows.Forms.Button btnEmployeAjouter;
        private System.Windows.Forms.GroupBox grbDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox grbInscription;
        private System.Windows.Forms.Button btnInscriptionCreation;
        private System.Windows.Forms.GroupBox grbProjet;
        private System.Windows.Forms.Button btnProjetConsulter;
    }
}

