namespace Project1
{
    partial class ConsulterProjet
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
            this.txbProjetName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbProjetDu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbProjetAu = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnReturnToProjetsList = new System.Windows.Forms.Button();
            this.btnNouvelleInscription = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbProjetAu);
            this.groupBox1.Controls.Add(this.txbProjetDu);
            this.groupBox1.Controls.Add(this.txbProjetName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Projet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projet:";
            // 
            // txbProjetName
            // 
            this.txbProjetName.Enabled = false;
            this.txbProjetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProjetName.Location = new System.Drawing.Point(88, 31);
            this.txbProjetName.Name = "txbProjetName";
            this.txbProjetName.ReadOnly = true;
            this.txbProjetName.Size = new System.Drawing.Size(198, 26);
            this.txbProjetName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Du:";
            // 
            // txbProjetDu
            // 
            this.txbProjetDu.Enabled = false;
            this.txbProjetDu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProjetDu.Location = new System.Drawing.Point(359, 31);
            this.txbProjetDu.Name = "txbProjetDu";
            this.txbProjetDu.ReadOnly = true;
            this.txbProjetDu.Size = new System.Drawing.Size(167, 26);
            this.txbProjetDu.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(532, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Au:";
            // 
            // txbProjetAu
            // 
            this.txbProjetAu.Enabled = false;
            this.txbProjetAu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProjetAu.Location = new System.Drawing.Point(571, 32);
            this.txbProjetAu.Name = "txbProjetAu";
            this.txbProjetAu.ReadOnly = true;
            this.txbProjetAu.Size = new System.Drawing.Size(167, 26);
            this.txbProjetAu.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(13, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 260);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List des Inscrits";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(769, 241);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnReturnToProjetsList
            // 
            this.btnReturnToProjetsList.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnReturnToProjetsList.Location = new System.Drawing.Point(130, 385);
            this.btnReturnToProjetsList.Name = "btnReturnToProjetsList";
            this.btnReturnToProjetsList.Size = new System.Drawing.Size(191, 29);
            this.btnReturnToProjetsList.TabIndex = 2;
            this.btnReturnToProjetsList.Text = "Retour a la list des projets";
            this.btnReturnToProjetsList.UseVisualStyleBackColor = false;
            this.btnReturnToProjetsList.Click += new System.EventHandler(this.btnReturnToProjetsList_Click);
            // 
            // btnNouvelleInscription
            // 
            this.btnNouvelleInscription.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnNouvelleInscription.Location = new System.Drawing.Point(467, 385);
            this.btnNouvelleInscription.Name = "btnNouvelleInscription";
            this.btnNouvelleInscription.Size = new System.Drawing.Size(191, 29);
            this.btnNouvelleInscription.TabIndex = 2;
            this.btnNouvelleInscription.Text = "Nouvelle Inscription";
            this.btnNouvelleInscription.UseVisualStyleBackColor = false;
            this.btnNouvelleInscription.Click += new System.EventHandler(this.btnNouvelleInscription_Click);
            // 
            // ConsulterProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNouvelleInscription);
            this.Controls.Add(this.btnReturnToProjetsList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConsulterProjet";
            this.Text = "ConsulterProjet";
            this.Load += new System.EventHandler(this.ConsulterProjet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbProjetDu;
        private System.Windows.Forms.TextBox txbProjetName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbProjetAu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnReturnToProjetsList;
        private System.Windows.Forms.Button btnNouvelleInscription;
    }
}