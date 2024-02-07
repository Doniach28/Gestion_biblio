namespace DoniaChaouch
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            btn_ajout = new Button();
            btn_modif = new Button();
            btn_supprime = new Button();
            btn_quitter = new Button();
            btn_recherche = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Location = new Point(37, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(843, 269);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "ISBN";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Titre de Livre";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Auteur";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Année Sortie";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Type Livre";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Editeur";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // btn_ajout
            // 
            btn_ajout.BackColor = Color.FromArgb(255, 255, 192);
            btn_ajout.Font = new Font("Sylfaen", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ajout.ForeColor = SystemColors.ControlText;
            btn_ajout.Image = (Image)resources.GetObject("btn_ajout.Image");
            btn_ajout.ImageAlign = ContentAlignment.MiddleRight;
            btn_ajout.Location = new Point(912, 97);
            btn_ajout.Margin = new Padding(4);
            btn_ajout.Name = "btn_ajout";
            btn_ajout.Size = new Size(152, 55);
            btn_ajout.TabIndex = 0;
            btn_ajout.Text = "Ajouter";
            btn_ajout.TextAlign = ContentAlignment.MiddleLeft;
            btn_ajout.UseVisualStyleBackColor = false;
            btn_ajout.Click += btn_ajout_Click;
            // 
            // btn_modif
            // 
            btn_modif.BackColor = Color.FromArgb(255, 255, 192);
            btn_modif.Font = new Font("Sylfaen", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_modif.ForeColor = SystemColors.Desktop;
            btn_modif.Image = (Image)resources.GetObject("btn_modif.Image");
            btn_modif.ImageAlign = ContentAlignment.MiddleRight;
            btn_modif.Location = new Point(912, 175);
            btn_modif.Margin = new Padding(4);
            btn_modif.Name = "btn_modif";
            btn_modif.Size = new Size(152, 55);
            btn_modif.TabIndex = 2;
            btn_modif.Text = "Modifier";
            btn_modif.TextAlign = ContentAlignment.MiddleLeft;
            btn_modif.UseVisualStyleBackColor = false;
            btn_modif.Click += btn_modif_Click;
            // 
            // btn_supprime
            // 
            btn_supprime.BackColor = Color.FromArgb(255, 255, 192);
            btn_supprime.Font = new Font("Sylfaen", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_supprime.ForeColor = SystemColors.Desktop;
            btn_supprime.Image = (Image)resources.GetObject("btn_supprime.Image");
            btn_supprime.ImageAlign = ContentAlignment.MiddleRight;
            btn_supprime.Location = new Point(912, 251);
            btn_supprime.Margin = new Padding(4);
            btn_supprime.Name = "btn_supprime";
            btn_supprime.Size = new Size(152, 53);
            btn_supprime.TabIndex = 3;
            btn_supprime.Text = "Supprimer";
            btn_supprime.TextAlign = ContentAlignment.MiddleLeft;
            btn_supprime.UseVisualStyleBackColor = false;
            btn_supprime.Click += btn_supprime_Click;
            // 
            // btn_quitter
            // 
            btn_quitter.BackColor = Color.FromArgb(255, 255, 192);
            btn_quitter.Font = new Font("Sylfaen", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_quitter.ForeColor = SystemColors.ControlText;
            btn_quitter.Image = (Image)resources.GetObject("btn_quitter.Image");
            btn_quitter.ImageAlign = ContentAlignment.MiddleRight;
            btn_quitter.Location = new Point(912, 323);
            btn_quitter.Margin = new Padding(4);
            btn_quitter.Name = "btn_quitter";
            btn_quitter.Size = new Size(152, 56);
            btn_quitter.TabIndex = 4;
            btn_quitter.Text = "Quitter";
            btn_quitter.TextAlign = ContentAlignment.MiddleLeft;
            btn_quitter.UseVisualStyleBackColor = false;
            btn_quitter.Click += btn_quitter_Click;
            // 
            // btn_recherche
            // 
            btn_recherche.Location = new Point(149, 351);
            btn_recherche.Name = "btn_recherche";
            btn_recherche.Size = new Size(480, 27);
            btn_recherche.TabIndex = 5;
            btn_recherche.TextChanged += btn_recherche_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Image = Properties.Resources.loupe_et_icone_de_recherche_de_couleur_orange;
            label1.Location = new Point(655, 351);
            label1.Name = "label1";
            label1.Size = new Size(0, 28);
            label1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(24, 350);
            label2.Name = "label2";
            label2.Size = new Size(119, 28);
            label2.TabIndex = 7;
            label2.Text = "Rechercher ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 413);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_recherche);
            Controls.Add(btn_quitter);
            Controls.Add(btn_supprime);
            Controls.Add(btn_modif);
            Controls.Add(btn_ajout);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button btn_modif;
        private Button btn_supprime;
        private Button btn_quitter;
        private TextBox btn_recherche;
        private Label label1;
        internal DataGridView dataGridView1;
        internal Button btn_ajout;
        private Label label2;
    }
}