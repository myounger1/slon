namespace WindowsFormsApplication1
{
    partial class Регистрация
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.av_way = new System.Windows.Forms.TextBox();
            this.save_b = new System.Windows.Forms.Button();
            this.ava = new System.Windows.Forms.PictureBox();
            this.av_b = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ava)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Путь аватара";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(130, 24);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(210, 20);
            this.login.TabIndex = 3;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(130, 63);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(210, 20);
            this.password.TabIndex = 4;
            // 
            // av_way
            // 
            this.av_way.Location = new System.Drawing.Point(130, 102);
            this.av_way.Name = "av_way";
            this.av_way.Size = new System.Drawing.Size(210, 20);
            this.av_way.TabIndex = 5;
            // 
            // save_b
            // 
            this.save_b.Location = new System.Drawing.Point(130, 126);
            this.save_b.Name = "save_b";
            this.save_b.Size = new System.Drawing.Size(210, 23);
            this.save_b.TabIndex = 6;
            this.save_b.Text = "Сохранить";
            this.save_b.UseVisualStyleBackColor = true;
            this.save_b.Click += new System.EventHandler(this.save_b_Click);
            // 
            // ava
            // 
            this.ava.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ava.Location = new System.Drawing.Point(21, 20);
            this.ava.Name = "ava";
            this.ava.Size = new System.Drawing.Size(100, 100);
            this.ava.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ava.TabIndex = 7;
            this.ava.TabStop = false;
            // 
            // av_b
            // 
            this.av_b.Location = new System.Drawing.Point(12, 126);
            this.av_b.Name = "av_b";
            this.av_b.Size = new System.Drawing.Size(62, 23);
            this.av_b.TabIndex = 8;
            this.av_b.Text = "Указать";
            this.av_b.UseVisualStyleBackColor = true;
            this.av_b.Click += new System.EventHandler(this.av_b_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Обзор";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Регистрация
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 161);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.av_b);
            this.Controls.Add(this.ava);
            this.Controls.Add(this.save_b);
            this.Controls.Add(this.av_way);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Регистрация";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Регистрация_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ava)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox av_way;
        private System.Windows.Forms.Button save_b;
        private System.Windows.Forms.PictureBox ava;
        private System.Windows.Forms.Button av_b;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}