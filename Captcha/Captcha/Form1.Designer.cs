
namespace Captcha
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.CaptchaText = new System.Windows.Forms.TextBox();
            this.CaptchaPic = new System.Windows.Forms.PictureBox();
            this.ChangeImageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CaptchaPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(100, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите данные для регистрации";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(195, 89);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(120, 20);
            this.UserName.TabIndex = 1;
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.RegistrationButton.Location = new System.Drawing.Point(157, 379);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(100, 29);
            this.RegistrationButton.TabIndex = 2;
            this.RegistrationButton.Text = "Регистрация";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(59, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя пользователя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(102, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Логин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(102, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Пароль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(14, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Введите текст с картинки";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(195, 129);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(120, 20);
            this.Login.TabIndex = 7;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(195, 170);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(120, 20);
            this.Password.TabIndex = 8;
            // 
            // CaptchaText
            // 
            this.CaptchaText.Location = new System.Drawing.Point(195, 331);
            this.CaptchaText.Name = "CaptchaText";
            this.CaptchaText.Size = new System.Drawing.Size(120, 20);
            this.CaptchaText.TabIndex = 9;
            // 
            // CaptchaPic
            // 
            this.CaptchaPic.Location = new System.Drawing.Point(30, 211);
            this.CaptchaPic.Name = "CaptchaPic";
            this.CaptchaPic.Size = new System.Drawing.Size(269, 107);
            this.CaptchaPic.TabIndex = 10;
            this.CaptchaPic.TabStop = false;
            // 
            // ChangeImageButton
            // 
            this.ChangeImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ChangeImageButton.Location = new System.Drawing.Point(319, 235);
            this.ChangeImageButton.Name = "ChangeImageButton";
            this.ChangeImageButton.Size = new System.Drawing.Size(100, 49);
            this.ChangeImageButton.TabIndex = 11;
            this.ChangeImageButton.Text = "Сменить картинку";
            this.ChangeImageButton.UseVisualStyleBackColor = true;
            this.ChangeImageButton.Click += new System.EventHandler(this.ChangeImageButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 428);
            this.Controls.Add(this.ChangeImageButton);
            this.Controls.Add(this.CaptchaPic);
            this.Controls.Add(this.CaptchaText);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Регистрация";
            ((System.ComponentModel.ISupportInitialize)(this.CaptchaPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox CaptchaText;
        private System.Windows.Forms.PictureBox CaptchaPic;
        private System.Windows.Forms.Button ChangeImageButton;
    }
}

