namespace DoniaChaouch
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            label1 = new Label();
            label2 = new Label();
            TXT_login = new TextBox();
            TXT_pwd = new TextBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.InactiveCaptionText;
            label1.Location = new Point(83, 291);
            label1.Name = "label1";
            label1.Size = new Size(80, 31);
            label1.TabIndex = 0;
            label1.Text = "Login ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(71, 341);
            label2.Name = "label2";
            label2.Size = new Size(116, 31);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // TXT_login
            // 
            TXT_login.Location = new Point(211, 291);
            TXT_login.Name = "TXT_login";
            TXT_login.Size = new Size(174, 27);
            TXT_login.TabIndex = 2;
            // 
            // TXT_pwd
            // 
            TXT_pwd.Location = new Point(211, 341);
            TXT_pwd.Name = "TXT_pwd";
            TXT_pwd.Size = new Size(174, 27);
            TXT_pwd.TabIndex = 3;
            TXT_pwd.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(94, 401);
            button1.Name = "button1";
            button1.Size = new Size(125, 50);
            button1.TabIndex = 4;
            button1.Text = "Se connecter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(234, 402);
            button2.Name = "button2";
            button2.Size = new Size(121, 49);
            button2.TabIndex = 5;
            button2.Text = "Annuler";
            button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(52, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(369, 221);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 480);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TXT_pwd);
            Controls.Add(TXT_login);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "login";
            Text = "login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TXT_login;
        private TextBox TXT_pwd;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
    }
}