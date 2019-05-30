using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Reg
{
    public partial class SettingsForm : Form
    {
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
           applyTheChanges = { "Применить изменения(Программа перезагрузится)", "Apply the changes" };
        public SettingsForm()
        {
            InitializeComponent();

        }

        private void Settings_Load(object sender, EventArgs e)
        {
           // label1.Text = registrationForm.labelLogin;
        }
    }
}
