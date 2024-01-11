namespace TP5
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbSerieCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbTitleSerie = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnFirst = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnPrevious = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnNext = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnLast = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnAdd = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnEdit = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnDelete = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnClear = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.SerieDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dtpReleaseDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbGenre = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.SerieDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code de serie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Titre de serie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date de sortie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Genre";
            // 
            // txbSerieCode
            // 
            this.txbSerieCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSerieCode.DefaultText = "";
            this.txbSerieCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbSerieCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbSerieCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSerieCode.DisabledState.Parent = this.txbSerieCode;
            this.txbSerieCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSerieCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSerieCode.FocusedState.Parent = this.txbSerieCode;
            this.txbSerieCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSerieCode.HoverState.Parent = this.txbSerieCode;
            this.txbSerieCode.Location = new System.Drawing.Point(146, 31);
            this.txbSerieCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbSerieCode.Name = "txbSerieCode";
            this.txbSerieCode.PasswordChar = '\0';
            this.txbSerieCode.PlaceholderText = "";
            this.txbSerieCode.SelectedText = "";
            this.txbSerieCode.ShadowDecoration.Parent = this.txbSerieCode;
            this.txbSerieCode.Size = new System.Drawing.Size(281, 35);
            this.txbSerieCode.TabIndex = 1;
            // 
            // txbTitleSerie
            // 
            this.txbTitleSerie.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTitleSerie.DefaultText = "";
            this.txbTitleSerie.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbTitleSerie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbTitleSerie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbTitleSerie.DisabledState.Parent = this.txbTitleSerie;
            this.txbTitleSerie.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbTitleSerie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbTitleSerie.FocusedState.Parent = this.txbTitleSerie;
            this.txbTitleSerie.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbTitleSerie.HoverState.Parent = this.txbTitleSerie;
            this.txbTitleSerie.Location = new System.Drawing.Point(146, 88);
            this.txbTitleSerie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbTitleSerie.Name = "txbTitleSerie";
            this.txbTitleSerie.PasswordChar = '\0';
            this.txbTitleSerie.PlaceholderText = "";
            this.txbTitleSerie.SelectedText = "";
            this.txbTitleSerie.ShadowDecoration.Parent = this.txbTitleSerie;
            this.txbTitleSerie.Size = new System.Drawing.Size(281, 36);
            this.txbTitleSerie.TabIndex = 2;
            // 
            // btnFirst
            // 
            this.btnFirst.CheckedState.Parent = this.btnFirst;
            this.btnFirst.CustomImages.Parent = this.btnFirst;
            this.btnFirst.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.ForeColor = System.Drawing.Color.White;
            this.btnFirst.HoverState.Parent = this.btnFirst;
            this.btnFirst.Location = new System.Drawing.Point(194, 257);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnFirst.ShadowDecoration.Parent = this.btnFirst;
            this.btnFirst.Size = new System.Drawing.Size(48, 50);
            this.btnFirst.TabIndex = 6;
            this.btnFirst.Text = "<<";
            // 
            // btnPrevious
            // 
            this.btnPrevious.CheckedState.Parent = this.btnPrevious;
            this.btnPrevious.CustomImages.Parent = this.btnPrevious;
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.HoverState.Parent = this.btnPrevious;
            this.btnPrevious.Location = new System.Drawing.Point(249, 257);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnPrevious.ShadowDecoration.Parent = this.btnPrevious;
            this.btnPrevious.Size = new System.Drawing.Size(48, 50);
            this.btnPrevious.TabIndex = 6;
            this.btnPrevious.Text = "<";
            // 
            // btnNext
            // 
            this.btnNext.CheckedState.Parent = this.btnNext;
            this.btnNext.CustomImages.Parent = this.btnNext;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.HoverState.Parent = this.btnNext;
            this.btnNext.Location = new System.Drawing.Point(304, 257);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnNext.ShadowDecoration.Parent = this.btnNext;
            this.btnNext.Size = new System.Drawing.Size(48, 50);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = ">";
            // 
            // btnLast
            // 
            this.btnLast.CheckedState.Parent = this.btnLast;
            this.btnLast.CustomImages.Parent = this.btnLast;
            this.btnLast.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.ForeColor = System.Drawing.Color.White;
            this.btnLast.HoverState.Parent = this.btnLast;
            this.btnLast.Location = new System.Drawing.Point(359, 257);
            this.btnLast.Name = "btnLast";
            this.btnLast.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnLast.ShadowDecoration.Parent = this.btnLast;
            this.btnLast.Size = new System.Drawing.Size(48, 50);
            this.btnLast.TabIndex = 6;
            this.btnLast.Text = ">>";
            // 
            // btnAdd
            // 
            this.btnAdd.Animated = true;
            this.btnAdd.AutoRoundedCorners = true;
            this.btnAdd.BorderRadius = 17;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(434, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(180, 36);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Animated = true;
            this.btnEdit.AutoRoundedCorners = true;
            this.btnEdit.BorderRadius = 17;
            this.btnEdit.CheckedState.Parent = this.btnEdit;
            this.btnEdit.CustomImages.Parent = this.btnEdit;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.HoverState.Parent = this.btnEdit;
            this.btnEdit.Location = new System.Drawing.Point(434, 88);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(180, 36);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Modifier";
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.AutoRoundedCorners = true;
            this.btnDelete.BorderRadius = 17;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(434, 145);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(180, 36);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Supprimer";
            // 
            // btnClear
            // 
            this.btnClear.Animated = true;
            this.btnClear.AutoRoundedCorners = true;
            this.btnClear.BorderRadius = 17;
            this.btnClear.CheckedState.Parent = this.btnClear;
            this.btnClear.CustomImages.Parent = this.btnClear;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.HoverState.Parent = this.btnClear;
            this.btnClear.Location = new System.Drawing.Point(434, 202);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(180, 36);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Vider";
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BorderRadius = 17;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(434, 259);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(180, 36);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Enregistre";
            // 
            // SerieDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.SerieDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SerieDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SerieDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.SerieDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SerieDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SerieDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SerieDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SerieDataGridView.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SerieDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.SerieDataGridView.EnableHeadersVisualStyles = false;
            this.SerieDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SerieDataGridView.Location = new System.Drawing.Point(12, 323);
            this.SerieDataGridView.Name = "SerieDataGridView";
            this.SerieDataGridView.RowHeadersVisible = false;
            this.SerieDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SerieDataGridView.Size = new System.Drawing.Size(639, 157);
            this.SerieDataGridView.TabIndex = 8;
            this.SerieDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.SerieDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.SerieDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.SerieDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.SerieDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.SerieDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.SerieDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.SerieDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SerieDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SerieDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SerieDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerieDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.SerieDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SerieDataGridView.ThemeStyle.HeaderStyle.Height = 30;
            this.SerieDataGridView.ThemeStyle.ReadOnly = false;
            this.SerieDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.SerieDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SerieDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerieDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SerieDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.SerieDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SerieDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dtpReleaseDate
            // 
            this.dtpReleaseDate.CheckedState.Parent = this.dtpReleaseDate;
            this.dtpReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpReleaseDate.HoverState.Parent = this.dtpReleaseDate;
            this.dtpReleaseDate.Location = new System.Drawing.Point(146, 146);
            this.dtpReleaseDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpReleaseDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpReleaseDate.Name = "dtpReleaseDate";
            this.dtpReleaseDate.ShadowDecoration.Parent = this.dtpReleaseDate;
            this.dtpReleaseDate.Size = new System.Drawing.Size(281, 36);
            this.dtpReleaseDate.TabIndex = 9;
            this.dtpReleaseDate.Value = new System.DateTime(2024, 1, 1, 20, 58, 17, 266);
            // 
            // cmbGenre
            // 
            this.cmbGenre.BackColor = System.Drawing.Color.Transparent;
            this.cmbGenre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenre.FocusedColor = System.Drawing.Color.Empty;
            this.cmbGenre.FocusedState.Parent = this.cmbGenre;
            this.cmbGenre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.HoverState.Parent = this.cmbGenre;
            this.cmbGenre.ItemHeight = 30;
            this.cmbGenre.ItemsAppearance.Parent = this.cmbGenre;
            this.cmbGenre.Location = new System.Drawing.Point(146, 202);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.ShadowDecoration.Parent = this.cmbGenre;
            this.cmbGenre.Size = new System.Drawing.Size(281, 36);
            this.cmbGenre.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 485);
            this.Controls.Add(this.cmbGenre);
            this.Controls.Add(this.dtpReleaseDate);
            this.Controls.Add(this.SerieDataGridView);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.txbTitleSerie);
            this.Controls.Add(this.txbSerieCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Serie";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SerieDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txbSerieCode;
        private Guna.UI2.WinForms.Guna2TextBox txbTitleSerie;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnFirst;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnPrevious;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnNext;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnLast;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnAdd;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnEdit;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnDelete;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnClear;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnSave;
        private Guna.UI2.WinForms.Guna2DataGridView SerieDataGridView;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpReleaseDate;
        private Guna.UI2.WinForms.Guna2ComboBox cmbGenre;
    }
}