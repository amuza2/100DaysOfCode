namespace Project1
{
    partial class AjouterType
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbProjetType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbProjetLibele = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbProjetDuree = new System.Windows.Forms.TextBox();
            this.btnAjouterType = new System.Windows.Forms.Button();
            this.btnAnnule = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbProjetDuree);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbProjetLibele);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbProjetType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Projet Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type Projet:";
            // 
            // txbProjetType
            // 
            this.txbProjetType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProjetType.Location = new System.Drawing.Point(133, 30);
            this.txbProjetType.Name = "txbProjetType";
            this.txbProjetType.Size = new System.Drawing.Size(208, 26);
            this.txbProjetType.TabIndex = 1;
            this.txbProjetType.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Libelé Projet:";
            // 
            // txbProjetLibele
            // 
            this.txbProjetLibele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProjetLibele.Location = new System.Drawing.Point(133, 83);
            this.txbProjetLibele.Name = "txbProjetLibele";
            this.txbProjetLibele.Size = new System.Drawing.Size(208, 26);
            this.txbProjetLibele.TabIndex = 1;
            this.txbProjetLibele.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Durée Projet:";
            // 
            // txbProjetDuree
            // 
            this.txbProjetDuree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProjetDuree.Location = new System.Drawing.Point(133, 141);
            this.txbProjetDuree.Name = "txbProjetDuree";
            this.txbProjetDuree.Size = new System.Drawing.Size(208, 26);
            this.txbProjetDuree.TabIndex = 1;
            this.txbProjetDuree.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAjouterType
            // 
            this.btnAjouterType.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAjouterType.Location = new System.Drawing.Point(49, 224);
            this.btnAjouterType.Name = "btnAjouterType";
            this.btnAjouterType.Size = new System.Drawing.Size(98, 31);
            this.btnAjouterType.TabIndex = 1;
            this.btnAjouterType.Text = "Ajouter";
            this.btnAjouterType.UseVisualStyleBackColor = false;
            // 
            // btnAnnule
            // 
            this.btnAnnule.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAnnule.Location = new System.Drawing.Point(236, 224);
            this.btnAnnule.Name = "btnAnnule";
            this.btnAnnule.Size = new System.Drawing.Size(98, 31);
            this.btnAnnule.TabIndex = 1;
            this.btnAnnule.Text = "Annulé";
            this.btnAnnule.UseVisualStyleBackColor = false;
            // 
            // AjouterType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 273);
            this.Controls.Add(this.btnAnnule);
            this.Controls.Add(this.btnAjouterType);
            this.Controls.Add(this.groupBox1);
            this.Name = "AjouterType";
            this.Text = "AjouterType";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbProjetType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbProjetDuree;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbProjetLibele;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAjouterType;
        private System.Windows.Forms.Button btnAnnule;
    }
}