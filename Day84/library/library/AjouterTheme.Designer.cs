namespace library
{
    partial class AjouterTheme
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
            this.tbThemeName = new System.Windows.Forms.TextBox();
            this.btnAjouterTheme = new System.Windows.Forms.Button();
            this.btnAnnule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom Du Theme:";
            // 
            // tbThemeName
            // 
            this.tbThemeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbThemeName.Location = new System.Drawing.Point(198, 31);
            this.tbThemeName.Name = "tbThemeName";
            this.tbThemeName.Size = new System.Drawing.Size(228, 26);
            this.tbThemeName.TabIndex = 1;
            // 
            // btnAjouterTheme
            // 
            this.btnAjouterTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterTheme.Location = new System.Drawing.Point(33, 93);
            this.btnAjouterTheme.Name = "btnAjouterTheme";
            this.btnAjouterTheme.Size = new System.Drawing.Size(199, 34);
            this.btnAjouterTheme.TabIndex = 2;
            this.btnAjouterTheme.Text = "Ajouter";
            this.btnAjouterTheme.UseVisualStyleBackColor = true;
            this.btnAjouterTheme.Click += new System.EventHandler(this.btnAjouterTheme_Click);
            // 
            // btnAnnule
            // 
            this.btnAnnule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnule.Location = new System.Drawing.Point(264, 93);
            this.btnAnnule.Name = "btnAnnule";
            this.btnAnnule.Size = new System.Drawing.Size(117, 34);
            this.btnAnnule.TabIndex = 2;
            this.btnAnnule.Text = "Annulé";
            this.btnAnnule.UseVisualStyleBackColor = true;
            this.btnAnnule.Click += new System.EventHandler(this.btnAnnule_Click);
            // 
            // AjouterTheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 160);
            this.Controls.Add(this.btnAnnule);
            this.Controls.Add(this.btnAjouterTheme);
            this.Controls.Add(this.tbThemeName);
            this.Controls.Add(this.label1);
            this.Name = "AjouterTheme";
            this.Text = "AjouterTheme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbThemeName;
        private System.Windows.Forms.Button btnAjouterTheme;
        private System.Windows.Forms.Button btnAnnule;
    }
}