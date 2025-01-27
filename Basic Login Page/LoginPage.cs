using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Login_Page
{
    public partial class LoginPage : Form
    {
        public string username = "ariacik"; // Kullanıcı adı
        public string password = "aria123"; // Şifre

        MainPage mainPage = new MainPage();

        private Point mouseLocation;
        private Point mouseLocation1;
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

            this.MouseDown += guna2Panel3_MouseDown;
            this.MouseMove += guna2Panel3_MouseMove;
            this.MouseDown += guna2Panel2_MouseDown;
            this.MouseMove += guna2Panel2_MouseMove;
        }
        private void guna2Panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }

        private void guna2Panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseLocation = new Point(-e.X, -e.Y);
            }
        }

        private void guna2Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation1.X, mouseLocation1.Y);
                Location = mousePos;
            }
        }

        private void guna2Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseLocation1 = new Point(-e.X, -e.Y);
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameBox.Text) || string.IsNullOrEmpty(passwordBox.Text))
            {
                MessageBox.Show("Kutucuklar boş bırakılamaz!", "Discord: @ariacik");
            }
            else
            {
                if (usernameBox.Text == username)
                {
                    if (passwordBox.Text == password)
                    {
                        MessageBox.Show("Başarıyla giriş yapıldı!", "Discord: @ariacik");
                        mainPage.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Discord: @ariacik");
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Discord: @ariacik");
                }
            }
        }
    }
}
