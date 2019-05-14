using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Reg
{
    public partial class RegistrationForm : Form
    {
        /* Переменные, которые будут хранить на протяжение работы программы логин и пароль. */
        public string login = string.Empty;
        public string password = string.Empty;
        private Users user = new Users(); // Экземпляр класса пользователей.

        public RegistrationForm()
        {
            InitializeComponent();
           
           LoadUsers(); // Метод десериализует класс.
        }
      
        private void LoadUsers()
        {
            try
            {
                FileStream fs = new FileStream("Users.dat", FileMode.Open);

                BinaryFormatter formatter = new BinaryFormatter();

                user = (Users)formatter.Deserialize(fs);

                fs.Close();
                for (int i = 0; i < user.Logins.Count; i++) {
                    comboBox1.Items.Add(user.Logins[i]);
                }
            }
            catch { return; }
        }

        private void EnterToForm()
        {
            if (comboBox1.SelectedIndex != -1)
            {
                if (user.Passwords[comboBox1.SelectedIndex] == passwordTextBox.Text)
                {
                    login = user.Logins[comboBox1.SelectedIndex];
                    password = user.Passwords[comboBox1.SelectedIndex];

                    MessageBox.Show("Вы вошли в систему!");

                    this.Close();
                }
                else 
                {
                    MessageBox.Show("Неверный пароль!");
                }
            }

            else{
                MessageBox.Show("Выберите пользователя!");
            }
        }

        private void AddUser() // Регистрируем нового пользователя.
        {
            for (int i = 0; i < user.Logins.Count; i++) // Ищем пользователя.
            {
                if (user.Logins[i] == loginTextBox.Text)
                {
                    MessageBox.Show("Пользователь с таким логином уже существует. Введите другой логин");
                    i = user.Logins.Count;
                    loginTextBox.Text = "";
                    return;
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////
            if (loginTextBox.Text == "" || regPassTextBox.Text == "") { MessageBox.Show("Не введен логин или пароль!"); return; }

            user.Logins.Add(loginTextBox.Text);
            user.Passwords.Add(regPassTextBox.Text);

            FileStream fs = new FileStream("Users.dat", FileMode.OpenOrCreate);

            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, user); // Сериализуем класс.

            fs.Close();

            login = loginTextBox.Text;

            //this.Close();
            tabControl1.SelectedIndex = 0;
            comboBox1.Items.Clear();
            for (int i = 0; i < user.Logins.Count; i++)
            {
                comboBox1.Items.Add(user.Logins[i]);
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Закрываем программу.
        }    
           
        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (login == "" | password == "") { Application.Exit(); }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedIndex.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void regButton_Click_1(object sender, EventArgs e)
        {
            AddUser();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void enterButton_Click_1(object sender, EventArgs e)
        {
            EnterToForm();
        }
    }
}
