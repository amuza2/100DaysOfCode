namespace Project1
{
    partial class AjouterEmploye
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
            this.txbEmployeId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbEmployeNom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbEmployePrenom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dateTimePickerEmploye = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbEmployeFunction = new System.Windows.Forms.TextBox();
            this.btnEmployeAjouter = new System.Windows.Forms.Button();
            this.btnEmployeeAnnule = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerEmploye);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.txbEmployeFunction);
            this.groupBox1.Controls.Add(this.txbEmployePrenom);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbEmployeNom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbEmployeId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 376);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero Employe:";
            // 
            // txbEmployeId
            // 
            this.txbEmployeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmployeId.Location = new System.Drawing.Point(154, 55);
            this.txbEmployeId.Name = "txbEmployeId";
            this.txbEmployeId.Size = new System.Drawing.Size(213, 26);
            this.txbEmployeId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom:";
            // 
            // txbEmployeNom
            // 
            this.txbEmployeNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmployeNom.Location = new System.Drawing.Point(154, 111);
            this.txbEmployeNom.Name = "txbEmployeNom";
            this.txbEmployeNom.Size = new System.Drawing.Size(213, 26);
            this.txbEmployeNom.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Prenom:";
            // 
            // txbEmployePrenom
            // 
            this.txbEmployePrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmployePrenom.Location = new System.Drawing.Point(154, 172);
            this.txbEmployePrenom.Name = "txbEmployePrenom";
            this.txbEmployePrenom.Size = new System.Drawing.Size(213, 26);
            this.txbEmployePrenom.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sexe:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(154, 235);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Masculin";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(282, 235);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Feminin";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerEmploye
            // 
            this.dateTimePickerEmploye.Location = new System.Drawing.Point(154, 284);
            this.dateTimePickerEmploye.Name = "dateTimePickerEmploye";
            this.dateTimePickerEmploye.Size = new System.Drawing.Size(213, 20);
            this.dateTimePickerEmploye.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date de naissance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Function:";
            // 
            // txbEmployeFunction
            // 
            this.txbEmployeFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmployeFunction.Location = new System.Drawing.Point(154, 339);
            this.txbEmployeFunction.Name = "txbEmployeFunction";
            this.txbEmployeFunction.Size = new System.Drawing.Size(213, 26);
            this.txbEmployeFunction.TabIndex = 1;
            // 
            // btnEmployeAjouter
            // 
            this.btnEmployeAjouter.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEmployeAjouter.Location = new System.Drawing.Point(42, 408);
            this.btnEmployeAjouter.Name = "btnEmployeAjouter";
            this.btnEmployeAjouter.Size = new System.Drawing.Size(138, 23);
            this.btnEmployeAjouter.TabIndex = 1;
            this.btnEmployeAjouter.Text = "Ajouter";
            this.btnEmployeAjouter.UseVisualStyleBackColor = false;
            // 
            // btnEmployeeAnnule
            // 
            this.btnEmployeeAnnule.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEmployeeAnnule.Location = new System.Drawing.Point(254, 408);
            this.btnEmployeeAnnule.Name = "btnEmployeeAnnule";
            this.btnEmployeeAnnule.Size = new System.Drawing.Size(138, 23);
            this.btnEmployeeAnnule.TabIndex = 1;
            this.btnEmployeeAnnule.Text = "Annulé";
            this.btnEmployeeAnnule.UseVisualStyleBackColor = false;
            // 
            // AjouterEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 450);
            this.Controls.Add(this.btnEmployeeAnnule);
            this.Controls.Add(this.btnEmployeAjouter);
            this.Controls.Add(this.groupBox1);
            this.Name = "AjouterEmploye";
            this.Text = "AjouterEmploye";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerEmploye;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txbEmployeFunction;
        private System.Windows.Forms.TextBox txbEmployePrenom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbEmployeNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbEmployeId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEmployeAjouter;
        private System.Windows.Forms.Button btnEmployeeAnnule;
    }
}