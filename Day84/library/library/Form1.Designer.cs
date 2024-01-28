namespace library
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
            this.btnAjouterLivre = new System.Windows.Forms.Button();
            this.btnListLivre = new System.Windows.Forms.Button();
            this.btnAjouterEtudient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAjouterLivre
            // 
            this.btnAjouterLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterLivre.Location = new System.Drawing.Point(64, 61);
            this.btnAjouterLivre.Name = "btnAjouterLivre";
            this.btnAjouterLivre.Size = new System.Drawing.Size(122, 39);
            this.btnAjouterLivre.TabIndex = 0;
            this.btnAjouterLivre.Text = "Ajouter Livre";
            this.btnAjouterLivre.UseVisualStyleBackColor = true;
            this.btnAjouterLivre.Click += new System.EventHandler(this.btnAjouterLivre_Click);
            // 
            // btnListLivre
            // 
            this.btnListLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListLivre.Location = new System.Drawing.Point(208, 61);
            this.btnListLivre.Name = "btnListLivre";
            this.btnListLivre.Size = new System.Drawing.Size(122, 39);
            this.btnListLivre.TabIndex = 0;
            this.btnListLivre.Text = "List de Livre";
            this.btnListLivre.UseVisualStyleBackColor = true;
            this.btnListLivre.Click += new System.EventHandler(this.btnListLivre_Click);
            // 
            // btnAjouterEtudient
            // 
            this.btnAjouterEtudient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterEtudient.Location = new System.Drawing.Point(352, 61);
            this.btnAjouterEtudient.Name = "btnAjouterEtudient";
            this.btnAjouterEtudient.Size = new System.Drawing.Size(145, 39);
            this.btnAjouterEtudient.TabIndex = 0;
            this.btnAjouterEtudient.Text = "Ajouter Etudient";
            this.btnAjouterEtudient.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAjouterEtudient);
            this.Controls.Add(this.btnListLivre);
            this.Controls.Add(this.btnAjouterLivre);
            this.Name = "Form1";
            this.Text = "Library Management System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAjouterLivre;
        private System.Windows.Forms.Button btnListLivre;
        private System.Windows.Forms.Button btnAjouterEtudient;
    }
}

