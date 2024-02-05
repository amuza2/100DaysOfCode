namespace library
{
    partial class RetourEmprunt
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRetourLivre = new System.Windows.Forms.Button();
            this.btnAnnule = new System.Windows.Forms.Button();
            this.btnClearText = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chercher par code:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(179, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(642, 287);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnRetourLivre
            // 
            this.btnRetourLivre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRetourLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetourLivre.Location = new System.Drawing.Point(18, 371);
            this.btnRetourLivre.Name = "btnRetourLivre";
            this.btnRetourLivre.Size = new System.Drawing.Size(106, 33);
            this.btnRetourLivre.TabIndex = 3;
            this.btnRetourLivre.Text = "Retour Live";
            this.btnRetourLivre.UseVisualStyleBackColor = false;
            // 
            // btnAnnule
            // 
            this.btnAnnule.BackColor = System.Drawing.Color.IndianRed;
            this.btnAnnule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnule.Location = new System.Drawing.Point(151, 371);
            this.btnAnnule.Name = "btnAnnule";
            this.btnAnnule.Size = new System.Drawing.Size(106, 33);
            this.btnAnnule.TabIndex = 3;
            this.btnAnnule.Text = "Annule";
            this.btnAnnule.UseVisualStyleBackColor = false;
            // 
            // btnClearText
            // 
            this.btnClearText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClearText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearText.Location = new System.Drawing.Point(355, 26);
            this.btnClearText.Name = "btnClearText";
            this.btnClearText.Size = new System.Drawing.Size(106, 27);
            this.btnClearText.TabIndex = 3;
            this.btnClearText.Text = "Clear Text";
            this.btnClearText.UseVisualStyleBackColor = false;
            // 
            // RetourEmprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 422);
            this.Controls.Add(this.btnClearText);
            this.Controls.Add(this.btnAnnule);
            this.Controls.Add(this.btnRetourLivre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "RetourEmprunt";
            this.Text = "RetourEmprunt";
            this.Load += new System.EventHandler(this.RetourEmprunt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRetourLivre;
        private System.Windows.Forms.Button btnAnnule;
        private System.Windows.Forms.Button btnClearText;
    }
}