namespace WindowsFormsApplication1
{
    partial class TorgPlatForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TorgPlatForm));
            this.ava_picturebox = new System.Windows.Forms.PictureBox();
            this.login_label = new System.Windows.Forms.Label();
            this.profile_button = new System.Windows.Forms.Button();
            this.balance_label = new System.Windows.Forms.Label();
            this.clothes_button = new System.Windows.Forms.Button();
            this.clothes_pictureBox = new System.Windows.Forms.PictureBox();
            this.electro_pictureBox = new System.Windows.Forms.PictureBox();
            this.electro_Button = new System.Windows.Forms.Button();
            this.toy_pictureBox = new System.Windows.Forms.PictureBox();
            this.toys_button = new System.Windows.Forms.Button();
            this.furniture_button = new System.Windows.Forms.Button();
            this.furniture_pictureBox = new System.Windows.Forms.PictureBox();
            this.tovaryPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ava_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothes_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electro_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toy_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furniture_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ava_picturebox
            // 
            this.ava_picturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ava_picturebox.Location = new System.Drawing.Point(12, 12);
            this.ava_picturebox.Name = "ava_picturebox";
            this.ava_picturebox.Size = new System.Drawing.Size(50, 50);
            this.ava_picturebox.TabIndex = 0;
            this.ava_picturebox.TabStop = false;
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.BackColor = System.Drawing.SystemColors.Menu;
            this.login_label.Location = new System.Drawing.Point(68, 23);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(0, 13);
            this.login_label.TabIndex = 1;
            // 
            // profile_button
            // 
            this.profile_button.Location = new System.Drawing.Point(68, 39);
            this.profile_button.Name = "profile_button";
            this.profile_button.Size = new System.Drawing.Size(75, 23);
            this.profile_button.TabIndex = 2;
            this.profile_button.Text = "Профиль";
            this.profile_button.UseVisualStyleBackColor = true;
            this.profile_button.Click += new System.EventHandler(this.profileb_Click);
            // 
            // balance_label
            // 
            this.balance_label.AutoSize = true;
            this.balance_label.BackColor = System.Drawing.SystemColors.Menu;
            this.balance_label.Location = new System.Drawing.Point(145, 23);
            this.balance_label.Name = "balance_label";
            this.balance_label.Size = new System.Drawing.Size(70, 13);
            this.balance_label.TabIndex = 3;
            this.balance_label.Text = "Ваш баланс:";
            // 
            // clothes_button
            // 
            this.clothes_button.Location = new System.Drawing.Point(28, 113);
            this.clothes_button.Name = "clothes_button";
            this.clothes_button.Size = new System.Drawing.Size(86, 23);
            this.clothes_button.TabIndex = 4;
            this.clothes_button.Text = "Одежда";
            this.clothes_button.UseVisualStyleBackColor = true;
            this.clothes_button.Click += new System.EventHandler(this.clothes_button_Click);
            // 
            // clothes_pictureBox
            // 
            this.clothes_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("clothes_pictureBox.Image")));
            this.clothes_pictureBox.Location = new System.Drawing.Point(3, 115);
            this.clothes_pictureBox.Name = "clothes_pictureBox";
            this.clothes_pictureBox.Size = new System.Drawing.Size(25, 21);
            this.clothes_pictureBox.TabIndex = 7;
            this.clothes_pictureBox.TabStop = false;
            this.clothes_pictureBox.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // electro_pictureBox
            // 
            this.electro_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("electro_pictureBox.Image")));
            this.electro_pictureBox.Location = new System.Drawing.Point(3, 142);
            this.electro_pictureBox.Name = "electro_pictureBox";
            this.electro_pictureBox.Size = new System.Drawing.Size(25, 21);
            this.electro_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.electro_pictureBox.TabIndex = 8;
            this.electro_pictureBox.TabStop = false;
            // 
            // electro_Button
            // 
            this.electro_Button.Location = new System.Drawing.Point(28, 140);
            this.electro_Button.Name = "electro_Button";
            this.electro_Button.Size = new System.Drawing.Size(86, 23);
            this.electro_Button.TabIndex = 9;
            this.electro_Button.Text = "Электроника";
            this.electro_Button.UseVisualStyleBackColor = true;
            this.electro_Button.Click += new System.EventHandler(this.electro_Button_Click);
            // 
            // toy_pictureBox
            // 
            this.toy_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("toy_pictureBox.Image")));
            this.toy_pictureBox.Location = new System.Drawing.Point(3, 169);
            this.toy_pictureBox.Name = "toy_pictureBox";
            this.toy_pictureBox.Size = new System.Drawing.Size(25, 21);
            this.toy_pictureBox.TabIndex = 10;
            this.toy_pictureBox.TabStop = false;
            // 
            // toys_button
            // 
            this.toys_button.Location = new System.Drawing.Point(28, 167);
            this.toys_button.Name = "toys_button";
            this.toys_button.Size = new System.Drawing.Size(86, 23);
            this.toys_button.TabIndex = 11;
            this.toys_button.Text = "Игрушки";
            this.toys_button.UseVisualStyleBackColor = true;
            this.toys_button.Click += new System.EventHandler(this.toys_button_Click);
            // 
            // furniture_button
            // 
            this.furniture_button.Location = new System.Drawing.Point(28, 196);
            this.furniture_button.Name = "furniture_button";
            this.furniture_button.Size = new System.Drawing.Size(86, 23);
            this.furniture_button.TabIndex = 12;
            this.furniture_button.Text = "Мебель";
            this.furniture_button.UseVisualStyleBackColor = true;
            this.furniture_button.Click += new System.EventHandler(this.furniture_button_Click);
            // 
            // furniture_pictureBox
            // 
            this.furniture_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("furniture_pictureBox.Image")));
            this.furniture_pictureBox.Location = new System.Drawing.Point(3, 196);
            this.furniture_pictureBox.Name = "furniture_pictureBox";
            this.furniture_pictureBox.Size = new System.Drawing.Size(25, 21);
            this.furniture_pictureBox.TabIndex = 13;
            this.furniture_pictureBox.TabStop = false;
            // 
            // tovaryPanel
            // 
            this.tovaryPanel.AutoScroll = true;
            this.tovaryPanel.BackColor = System.Drawing.Color.Transparent;
            this.tovaryPanel.Location = new System.Drawing.Point(120, 115);
            this.tovaryPanel.Name = "tovaryPanel";
            this.tovaryPanel.Size = new System.Drawing.Size(604, 671);
            this.tovaryPanel.TabIndex = 15;
            this.tovaryPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tovaryPanel_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TorgPlatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(781, 534);
            this.Controls.Add(this.tovaryPanel);
            this.Controls.Add(this.furniture_pictureBox);
            this.Controls.Add(this.furniture_button);
            this.Controls.Add(this.toys_button);
            this.Controls.Add(this.toy_pictureBox);
            this.Controls.Add(this.electro_Button);
            this.Controls.Add(this.electro_pictureBox);
            this.Controls.Add(this.clothes_pictureBox);
            this.Controls.Add(this.clothes_button);
            this.Controls.Add(this.balance_label);
            this.Controls.Add(this.profile_button);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.ava_picturebox);
            this.Name = "TorgPlatForm";
            this.Text = "У весёлого слоника";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.TorgPlatForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.ava_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothes_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electro_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toy_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furniture_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ava_picturebox;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Button profile_button;
        private System.Windows.Forms.Label balance_label;
        private System.Windows.Forms.Button clothes_button;
        private System.Windows.Forms.PictureBox clothes_pictureBox;
        private System.Windows.Forms.PictureBox electro_pictureBox;
        private System.Windows.Forms.Button electro_Button;
        private System.Windows.Forms.PictureBox toy_pictureBox;
        private System.Windows.Forms.Button toys_button;
        private System.Windows.Forms.Button furniture_button;
        private System.Windows.Forms.PictureBox furniture_pictureBox;
        private System.Windows.Forms.Panel tovaryPanel;
        private System.Windows.Forms.Timer timer1;
    }
}

