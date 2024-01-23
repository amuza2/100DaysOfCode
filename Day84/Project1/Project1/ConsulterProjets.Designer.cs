namespace Project1
{
    partial class ConsulterProjets
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnListerParDate = new System.Windows.Forms.Button();
            this.btnListerParType = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnAjouterProjet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 319);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Double Click sure le projet pour l\'afficher";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(770, 300);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnListerParDate
            // 
            this.btnListerParDate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnListerParDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListerParDate.Location = new System.Drawing.Point(15, 344);
            this.btnListerParDate.Name = "btnListerParDate";
            this.btnListerParDate.Size = new System.Drawing.Size(161, 30);
            this.btnListerParDate.TabIndex = 1;
            this.btnListerParDate.Text = "lister par date";
            this.btnListerParDate.UseVisualStyleBackColor = false;
            this.btnListerParDate.Click += new System.EventHandler(this.btnListerParDate_Click);
            // 
            // btnListerParType
            // 
            this.btnListerParType.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnListerParType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListerParType.Location = new System.Drawing.Point(321, 344);
            this.btnListerParType.Name = "btnListerParType";
            this.btnListerParType.Size = new System.Drawing.Size(161, 30);
            this.btnListerParType.TabIndex = 1;
            this.btnListerParType.Text = "Lister par type";
            this.btnListerParType.UseVisualStyleBackColor = false;
            this.btnListerParType.Click += new System.EventHandler(this.btnListerParType_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.Tomato;
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(627, 344);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(161, 30);
            this.btnFermer.TabIndex = 1;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnAjouterProjet
            // 
            this.btnAjouterProjet.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAjouterProjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterProjet.Location = new System.Drawing.Point(15, 383);
            this.btnAjouterProjet.Name = "btnAjouterProjet";
            this.btnAjouterProjet.Size = new System.Drawing.Size(770, 30);
            this.btnAjouterProjet.TabIndex = 1;
            this.btnAjouterProjet.Text = "Ajouter un nouveaux Projet";
            this.btnAjouterProjet.UseVisualStyleBackColor = false;
            this.btnAjouterProjet.Click += new System.EventHandler(this.btnAjouterProjet_Click);
            // 
            // ConsulterProjets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 431);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnAjouterProjet);
            this.Controls.Add(this.btnListerParType);
            this.Controls.Add(this.btnListerParDate);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConsulterProjets";
            this.Text = "ConsulterProjet";
            this.Load += new System.EventHandler(this.ConsulterProjet_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnListerParDate;
        private System.Windows.Forms.Button btnListerParType;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnAjouterProjet;
    }
}