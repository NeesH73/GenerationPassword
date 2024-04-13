using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GenerationPassword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Вы хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();              
            }
            else { this.Show(); }
        }

        public void btngeneration_Click(object sender, EventArgs e)
        {
            string username = textBoxLogin.Text;
            int length12 = Convert.ToInt32(length.Value);
            bool poxojie = vklpoxojix.Checked;
            bool nebykvi = vklnebykv.Checked;
            string password = GeneratePassword(length12, poxojie, nebykvi);
            textBoxPass.Text=password;          
            string message = "Запомните свой пароль: " + password;
            MessageBox.Show(message, "Пароль сгенерирован");
        }

        public string GeneratePassword(int length, bool poxojie, bool nebykvi)
        {
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            if (!poxojie)
            {
                chars = chars.Replace("iIlLoO", "");
            }
            if (!nebykvi)
            {
                chars = chars.Replace("{ } [ ] ( ) / \\ '\" ` ~ , ; : . < >", "");
            }

            StringBuilder password = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                password.Append(chars[random.Next(chars.Length)]);               
            }     
            return password.ToString();
        }

        public void btnsaved_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPass.Text;

            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password))
            {
                string filePath = "passwords.txt";

                using (StreamWriter writer = File.AppendText(filePath))
                {
                    writer.WriteLine($"Логин: {login}, Пароль: {password}");
                }

                MessageBox.Show("Логин и пароль сохранены в файл", "Пароль сохранен");
            }
            else
            {
                MessageBox.Show("Сгенерируйте сначала пароль", "Ошибка");
            }
        }
    }
}
