using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captcha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.RegistrationButton.Enabled = false;
            this.UserName.Tag = false;
            this.Login.Tag = false;
            this.Password.Tag = false;
            this.UserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxEmpty_Validating);
            this.Login.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxEmpty_Validating);
            this.Password.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxEmpty_Validating);
            CaptchaImages();
        }
        public void CaptchaImages()
        {
            string[] pathFiles = Directory.GetFiles("Res","*.png", SearchOption.AllDirectories);

            //выбор рандом капчи
            Random r = new Random();
            int id = r.Next(0, pathFiles.Length);
            Bitmap yourPic = new Bitmap(pathFiles[id]);

            //нахождение текста капчи(для проверки)
            FileInfo yourFile = new FileInfo(pathFiles[id]);
            string yourText = yourFile.Name;
            yourText = yourText.Replace(".png", "");

            //отображение капчи
            CaptchaPic.Image = yourPic;
            CaptchaText.Text = "";
            Password.Text = "";
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {   
            if (Login.Text.Length < 4)
            {
                MessageBox.Show("Длина пароля должна быть от 4 символов!");
                CaptchaImages();
            }
        }

        private void ChangeImageButton_Click(object sender, EventArgs e)
        {
            CaptchaImages();
        }

        private void txtBoxEmpty_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb;
            tb = (TextBox)sender;
            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.Red;
                tb.Tag = false;
            }
            else
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
                tb.Tag = true;
            }
            ValidateAll();
        }
        private void ValidateAll()
        {
            this.RegistrationButton.Enabled = (bool)(this.UserName.Tag) && 
                (bool)(this.Login.Tag) && 
                (bool)(this.Password.Tag);
        }

        public void CaptchaText_TextChanged(object sender, EventArgs e)
        {
           if (CaptchaText.Text)     
        }
    }
}
