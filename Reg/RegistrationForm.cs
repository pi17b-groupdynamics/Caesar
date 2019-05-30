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
        public string PathOfPicture = string.Empty;
        private Users user = new Users(); // Экземпляр класса пользователей.
        public int lang = 0;
        public string[]
           labelOrigText = { "Исходный текст", "Original text" },
           labelProcessedText = { "Обработанный текст", "Processed text" },
           labelHack = { "Взлом", "Hack" },
           labelKeys = { "Ключи:", "Keys:" },
           buttonLoad = { "Загрузить", "Load" },
           buttonSave = { "Сохранить", "Save" },
           buttonLoadKeys = { "Загрузить ключи", "Load keys" },
           buttonSaveKeys = { "Сохранить ключи", "Save keys" },
           buttonRandomKeys = { "Случайно", "Random" },
           buttonHack1 = { "Взлом перебором", "Bruteforce" },
           buttonHack2 = { "Частотный анализ", "Freq. analysis" },
            buttonDecrypt = { "Расшифровать", "Decrypt" },
            buttonEncrypt = { "Зашифровать", "Encrypt" },
            buttonExit = { "Выход", "Exit" },
            buttonSwitchLang = { "Switch language", "Переключить язык" },
            buttonBack = { "Назад", "Back" },
            labelLogin = { "Логин", "Login" },
            labelPassword = { "Пароль", "Password" },
            labelSignIn = { "Войти", "Sign in" },
            labelSignUp = { "Регистрация", "Sign up" },
            errorNonCorrectPasswd = { "Неверный пароль!", "Wrong password!" },
            errorSelectUsr = { "Выберите пользователя!", "Select user!" },
            errorNotUniqueLogin = { "Пользователь с таким логином уже существует. Введите другой логин", "A user with this login already exists. Enter a different username" },
          errorNoLoginOrPassword = { "Не введен логин или пароль!", "No login or password entered!" },
         selectImage = { "Выбрать изображение", "Select image" },
            applyTheChanges = { "Применить изменения", "Apply the changes" };

        private void button5_Click(object sender, EventArgs e)
        {
            user.Logins[comboBox1.SelectedIndex]= textBox1.Text;
            user.Passwords[comboBox1.SelectedIndex]= textBox2.Text;
            user.PathOfPicture[comboBox1.SelectedIndex]= filename;

            FileStream fs = new FileStream("Users.dat", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, user); // Сериализуем класс.
            fs.Close();
            login = user.Logins[comboBox1.SelectedIndex];
            password = user.Passwords[comboBox1.SelectedIndex];
            PathOfPicture = user.PathOfPicture[comboBox1.SelectedIndex];
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //openFileDialog1.Filter = "Изображение (*.jpg)|*.jpg | Изображение (*.bmp)|*.bmp | Изображение (*.png)|*.png | Все файлы (*.*) | *.*";
            openFileDialog1.InitialDirectory = "c:\\";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                if (filename != "NonChoosed")
                {
                    try
                    {
                        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox2.Image = Image.FromFile(filename);
                    }
                    catch (OutOfMemoryException ex)
                    {
                        MessageBox.Show("Ошибка чтения картинки");
                        return;
                    }

                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                textBox1.Text = login;
                textBox2.Text = password;
                if (filename != "NonChoosed" && filename != String.Empty)
                {
                    try
                    {
                        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox2.Image = Image.FromFile(filename);
                    }
                    catch (OutOfMemoryException ex)
                    {
                        MessageBox.Show("Ошибка чтения картинки");
                        return;
                    }

                }
            }
        }

        string filename = "NonChoosed";
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //openFileDialog1.Filter = "Изображение (*.jpg)|*.jpg | Изображение (*.bmp)|*.bmp | Изображение (*.png)|*.png | Все файлы (*.*) | *.*";
            openFileDialog1.InitialDirectory = "c:\\";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                if (filename != "NonChoosed")
                {
                    try
                    {
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox1.Image = Image.FromFile(filename);
                    }
                    catch (OutOfMemoryException ex)
                    {
                        MessageBox.Show("Ошибка чтения картинки");
                        return;
                    }
                    
                }
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lang = lang != 0 ? 0 : 1;
            updateLang();
        }

        void updateLang()
        {
            enterButton.Text = labelSignIn[lang];
            button1.Text = labelSignUp[lang];
            button2.Text = buttonBack[lang];
            label1.Text = labelLogin[lang];
            label2.Text = labelPassword[lang];
            label4.Text = labelLogin[lang];
            label3.Text = labelPassword[lang];
            button3.Text = buttonSwitchLang[lang];
           regButton.Text = labelSignUp[lang];
            label6.Text = labelPassword[lang];
            label7.Text = labelLogin[lang];
            button5.Text = applyTheChanges[lang];
            button6.Text = selectImage[lang];



        }
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
                    PathOfPicture = user.PathOfPicture[comboBox1.SelectedIndex];
                    this.Close();
                }
                else 
                {
                    MessageBox.Show(errorNonCorrectPasswd[lang]);
                }
            }

            else{
                MessageBox.Show(errorSelectUsr[lang]);
            }
        }

        private void AddUser() // Регистрируем нового пользователя.
        {
            for (int i = 0; i < user.Logins.Count; i++) // Ищем пользователя.
            {
                if (user.Logins[i] == loginTextBox.Text)
                {
                    MessageBox.Show(errorNotUniqueLogin[lang]);
                    i = user.Logins.Count;
                    loginTextBox.Text = "";
                    return;
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////
            if (loginTextBox.Text == "" || regPassTextBox.Text == "") { MessageBox.Show(errorNoLoginOrPassword[lang]); return; }

            user.Logins.Add(loginTextBox.Text);
            user.Passwords.Add(regPassTextBox.Text);
            user.PathOfPicture.Add(filename);
            filename = "NonChoosed";
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationForm_Shown(object sender, EventArgs e)
        {
            updateLang();
            if (tabControl1.SelectedIndex == 2)
            {
                textBox1.Text = user.Logins[comboBox1.SelectedIndex];
                textBox2.Text = user.Passwords[comboBox1.SelectedIndex];
                if (user.PathOfPicture[comboBox1.SelectedIndex] != "NonChoosed" && user.PathOfPicture[comboBox1.SelectedIndex] != String.Empty)
                {
                    try
                    {
                        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox2.Image = Image.FromFile(user.PathOfPicture[comboBox1.SelectedIndex]);
                    }
                    catch (OutOfMemoryException ex)
                    {
                        MessageBox.Show("Ошибка чтения картинки");
                        return;
                    }

                }
            }
        }
        public void selectTab(int tab)
        {
            tabControl1.SelectedIndex = tab >= 0 && tab <= 3 ? tab : 0;
        }
    }
}
