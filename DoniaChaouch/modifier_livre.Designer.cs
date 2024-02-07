namespace DoniaChaouch
{
    partial class modifier_livre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modifier_livre));
            panel1 = new Panel();
            List_type_livre = new ListBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            TxT_editeur = new TextBox();
            TxT_annee_sortie = new TextBox();
            TxT_auteur = new TextBox();
            label3 = new Label();
            label2 = new Label();
            TxT_titre_livre = new TextBox();
            TxT_isbn = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            btn_annuler = new Button();
            btn_modifier = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(List_type_livre);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(TxT_editeur);
            panel1.Controls.Add(TxT_annee_sortie);
            panel1.Controls.Add(TxT_auteur);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TxT_titre_livre);
            panel1.Controls.Add(TxT_isbn);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(57, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 449);
            panel1.TabIndex = 2;
            // 
            // List_type_livre
            // 
            List_type_livre.FormattingEnabled = true;
            List_type_livre.ItemHeight = 20;
            List_type_livre.Items.AddRange(new object[] { "Roman ", "Action", "Comédie", "Horreur" });
            List_type_livre.Location = new Point(146, 290);
            List_type_livre.Name = "List_type_livre";
            List_type_livre.Size = new Size(163, 24);
            List_type_livre.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(22, 352);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 11;
            label6.Text = "Editeur";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(22, 290);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 10;
            label5.Text = "Type Livre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(22, 229);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 9;
            label4.Text = "Année de Sortie";
            // 
            // TxT_editeur
            // 
            TxT_editeur.Location = new Point(146, 345);
            TxT_editeur.Name = "TxT_editeur";
            TxT_editeur.Size = new Size(163, 27);
            TxT_editeur.TabIndex = 8;
            // 
            // TxT_annee_sortie
            // 
            TxT_annee_sortie.Location = new Point(146, 226);
            TxT_annee_sortie.Name = "TxT_annee_sortie";
            TxT_annee_sortie.Size = new Size(163, 27);
            TxT_annee_sortie.TabIndex = 6;
            // 
            // TxT_auteur
            // 
            TxT_auteur.Location = new Point(146, 172);
            TxT_auteur.Name = "TxT_auteur";
            TxT_auteur.Size = new Size(163, 27);
            TxT_auteur.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 175);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 4;
            label3.Text = "Auteur";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 127);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 3;
            label2.Text = "Titre de Livre";
            // 
            // TxT_titre_livre
            // 
            TxT_titre_livre.Location = new Point(146, 124);
            TxT_titre_livre.Name = "TxT_titre_livre";
            TxT_titre_livre.Size = new Size(163, 27);
            TxT_titre_livre.TabIndex = 2;
            // 
            // TxT_isbn
            // 
            TxT_isbn.Location = new Point(146, 75);
            TxT_isbn.Name = "TxT_isbn";
            TxT_isbn.Size = new Size(163, 27);
            TxT_isbn.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 78);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 0;
            label1.Text = "ISBN";
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_annuler);
            panel2.Controls.Add(btn_modifier);
            panel2.Location = new Point(416, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(208, 447);
            panel2.TabIndex = 3;
            // 
            // btn_annuler
            // 
            btn_annuler.BackColor = Color.FromArgb(255, 255, 192);
            btn_annuler.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_annuler.ForeColor = SystemColors.ControlText;
            btn_annuler.Image = (Image)resources.GetObject("btn_annuler.Image");
            btn_annuler.ImageAlign = ContentAlignment.MiddleRight;
            btn_annuler.Location = new Point(26, 225);
            btn_annuler.Name = "btn_annuler";
            btn_annuler.Size = new Size(139, 60);
            btn_annuler.TabIndex = 1;
            btn_annuler.Text = "Annuler";
            btn_annuler.TextAlign = ContentAlignment.MiddleLeft;
            btn_annuler.UseVisualStyleBackColor = false;
            btn_annuler.Click += btn_annuler_Click;
            // 
            // btn_modifier
            // 
            btn_modifier.BackColor = Color.FromArgb(255, 255, 192);
            btn_modifier.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_modifier.ForeColor = SystemColors.ControlText;
            btn_modifier.Image = (Image)resources.GetObject("btn_modifier.Image");
            btn_modifier.ImageAlign = ContentAlignment.MiddleRight;
            btn_modifier.Location = new Point(26, 144);
            btn_modifier.Name = "btn_modifier";
            btn_modifier.Size = new Size(139, 63);
            btn_modifier.TabIndex = 0;
            btn_modifier.Text = "Modifier";
            btn_modifier.TextAlign = ContentAlignment.MiddleLeft;
            btn_modifier.UseVisualStyleBackColor = false;
            btn_modifier.Click += btn_modifier_Click;
            // 
            // modifier_livre
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 499);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "modifier_livre";
            Text = "modifier_livre";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button btn_annuler;
        private Button btn_modifier;
        public TextBox TxT_isbn;
        public TextBox TxT_editeur;
        public TextBox TxT_annee_sortie;
        public TextBox TxT_auteur;
        public TextBox TxT_titre_livre;
        public ListBox List_type_livre;

    }
}