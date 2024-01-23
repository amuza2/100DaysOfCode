namespace Project1
{
    partial class AjouterProjet
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
            this.cmbTypeProjet = new System.Windows.Forms.ComboBox();
            this.dateTimePickerProjetFinDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerProjetDebutDate = new System.Windows.Forms.DateTimePicker();
            this.txtProjetCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjouterType = new System.Windows.Forms.Button();
            this.btnProjetValider = new System.Windows.Forms.Button();
            this.btnAnnule = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTypeProjet);
            this.groupBox1.Controls.Add(this.dateTimePickerProjetFinDate);
            this.groupBox1.Controls.Add(this.dateTimePickerProjetDebutDate);
            this.groupBox1.Controls.Add(this.txtProjetCode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Projet";
            // 
            // cmbTypeProjet
            // 
            this.cmbTypeProjet.FormattingEnabled = true;
            this.cmbTypeProjet.Location = new System.Drawing.Point(133, 78);
            this.cmbTypeProjet.Name = "cmbTypeProjet";
            this.cmbTypeProjet.Size = new System.Drawing.Size(200, 21);
            this.cmbTypeProjet.TabIndex = 5;
            this.cmbTypeProjet.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePickerProjetFinDate
            // 
            this.dateTimePickerProjetFinDate.Location = new System.Drawing.Point(133, 179);
            this.dateTimePickerProjetFinDate.Name = "dateTimePickerProjetFinDate";
            this.dateTimePickerProjetFinDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerProjetFinDate.TabIndex = 4;
            // 
            // dateTimePickerProjetDebutDate
            // 
            this.dateTimePickerProjetDebutDate.Location = new System.Drawing.Point(133, 124);
            this.dateTimePickerProjetDebutDate.Name = "dateTimePickerProjetDebutDate";
            this.dateTimePickerProjetDebutDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerProjetDebutDate.TabIndex = 3;
            // 
            // txtProjetCode
            // 
            this.txtProjetCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjetCode.Location = new System.Drawing.Point(133, 23);
            this.txtProjetCode.Name = "txtProjetCode";
            this.txtProjetCode.Size = new System.Drawing.Size(200, 26);
            this.txtProjetCode.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date Fin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date Debut:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Type Projet:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code Projet:";
            // 
            // btnAjouterType
            // 
            this.btnAjouterType.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAjouterType.Location = new System.Drawing.Point(32, 268);
            this.btnAjouterType.Name = "btnAjouterType";
            this.btnAjouterType.Size = new System.Drawing.Size(91, 27);
            this.btnAjouterType.TabIndex = 5;
            this.btnAjouterType.Text = "Ajouter Type";
            this.btnAjouterType.UseVisualStyleBackColor = false;
            this.btnAjouterType.Click += new System.EventHandler(this.btnAjouterType_Click);
            // 
            // btnProjetValider
            // 
            this.btnProjetValider.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnProjetValider.Location = new System.Drawing.Point(155, 268);
            this.btnProjetValider.Name = "btnProjetValider";
            this.btnProjetValider.Size = new System.Drawing.Size(91, 27);
            this.btnProjetValider.TabIndex = 6;
            this.btnProjetValider.Text = "Valider";
            this.btnProjetValider.UseVisualStyleBackColor = false;
            this.btnProjetValider.Click += new System.EventHandler(this.btnProjetValider_Click);
            // 
            // btnAnnule
            // 
            this.btnAnnule.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAnnule.Location = new System.Drawing.Point(276, 268);
            this.btnAnnule.Name = "btnAnnule";
            this.btnAnnule.Size = new System.Drawing.Size(91, 27);
            this.btnAnnule.TabIndex = 7;
            this.btnAnnule.Text = "Annulé";
            this.btnAnnule.UseVisualStyleBackColor = false;
            this.btnAnnule.Click += new System.EventHandler(this.btnAnnule_Click);
            // 
            // AjouterProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 311);
            this.Controls.Add(this.btnAnnule);
            this.Controls.Add(this.btnProjetValider);
            this.Controls.Add(this.btnAjouterType);
            this.Controls.Add(this.groupBox1);
            this.Name = "AjouterProjet";
            this.Text = "AjouterProjet";
            this.Load += new System.EventHandler(this.AjouterProjet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProjetCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerProjetFinDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerProjetDebutDate;
        private System.Windows.Forms.Button btnAjouterType;
        private System.Windows.Forms.Button btnProjetValider;
        private System.Windows.Forms.Button btnAnnule;
        private System.Windows.Forms.ComboBox cmbTypeProjet;
    }
}