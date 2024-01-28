namespace library
{
    partial class AjouterLivre
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
            this.tbTitre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAuteur = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbExamplaires = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTheme = new System.Windows.Forms.ComboBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAjouterTheme = new System.Windows.Forms.Button();
            this.btnannulé = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titre Du Livre:";
            // 
            // tbTitre
            // 
            this.tbTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitre.Location = new System.Drawing.Point(207, 30);
            this.tbTitre.Name = "tbTitre";
            this.tbTitre.Size = new System.Drawing.Size(218, 26);
            this.tbTitre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Auteur:";
            // 
            // tbAuteur
            // 
            this.tbAuteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAuteur.Location = new System.Drawing.Point(207, 84);
            this.tbAuteur.Name = "tbAuteur";
            this.tbAuteur.Size = new System.Drawing.Size(218, 26);
            this.tbAuteur.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre D\'examplaire:";
            // 
            // tbExamplaires
            // 
            this.tbExamplaires.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExamplaires.Location = new System.Drawing.Point(207, 138);
            this.tbExamplaires.Name = "tbExamplaires";
            this.tbExamplaires.Size = new System.Drawing.Size(218, 26);
            this.tbExamplaires.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Theme:";
            // 
            // cbTheme
            // 
            this.cbTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTheme.FormattingEnabled = true;
            this.cbTheme.Location = new System.Drawing.Point(207, 192);
            this.cbTheme.Name = "cbTheme";
            this.cbTheme.Size = new System.Drawing.Size(218, 28);
            this.cbTheme.TabIndex = 4;
            // 
            // btnValider
            // 
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(12, 271);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(116, 34);
            this.btnValider.TabIndex = 5;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAjouterTheme
            // 
            this.btnAjouterTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterTheme.Location = new System.Drawing.Point(143, 271);
            this.btnAjouterTheme.Name = "btnAjouterTheme";
            this.btnAjouterTheme.Size = new System.Drawing.Size(139, 34);
            this.btnAjouterTheme.TabIndex = 6;
            this.btnAjouterTheme.Text = "Ajouter Theme";
            this.btnAjouterTheme.UseVisualStyleBackColor = true;
            this.btnAjouterTheme.Click += new System.EventHandler(this.btnAjouterTheme_Click);
            // 
            // btnannulé
            // 
            this.btnannulé.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnannulé.Location = new System.Drawing.Point(297, 271);
            this.btnannulé.Name = "btnannulé";
            this.btnannulé.Size = new System.Drawing.Size(139, 34);
            this.btnannulé.TabIndex = 7;
            this.btnannulé.Text = "Annulé";
            this.btnannulé.UseVisualStyleBackColor = true;
            this.btnannulé.Click += new System.EventHandler(this.btnannulé_Click);
            // 
            // AjouterLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 328);
            this.Controls.Add(this.btnannulé);
            this.Controls.Add(this.btnAjouterTheme);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.cbTheme);
            this.Controls.Add(this.tbExamplaires);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAuteur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTitre);
            this.Controls.Add(this.label1);
            this.Name = "AjouterLivre";
            this.Text = "AjouterLivre";
            this.Load += new System.EventHandler(this.AjouterLivre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTitre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAuteur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbExamplaires;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTheme;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAjouterTheme;
        private System.Windows.Forms.Button btnannulé;
    }
}