using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Reg
{
    public partial class MainForm : Form
    {
        RegistrationForm registrationForm = new RegistrationForm();
        SettingsForm settingsForm = new SettingsForm();
        public MainForm()
        {
            InitializeComponent();

            registrationForm.ShowDialog(); // Отображаем форму авторизации.
            setLang(registrationForm.lang);
            nameLabel.Text = "User: " + registrationForm.login;
                if (registrationForm.PathOfPicture != "NonChoosed" && registrationForm.PathOfPicture != String.Empty)
            {
                try
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = Image.FromFile(registrationForm.PathOfPicture);
                }
                catch (OutOfMemoryException ex)
                {
                    MessageBox.Show("Ошибка чтения картинки");
                    return;
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            registrationForm.login = string.Empty;
            registrationForm.password = string.Empty;
            registrationForm.ShowDialog(); // Отображаем форму авторизации.
            this.Show();
            nameLabel.Text = "User: " + registrationForm.login;
            if (registrationForm.PathOfPicture != "NonChoosed" && registrationForm.PathOfPicture != String.Empty)
            {
                try
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = Image.FromFile(registrationForm.PathOfPicture);
                }
                catch (OutOfMemoryException ex)
                {
                    MessageBox.Show("Ошибка чтения картинки");
                    return;
                }

            }
        }


        private void textBox_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A) textBox_input.SelectAll();
        }

        private void textBox_output_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A) textBox_output.SelectAll();
        }

        private void textBox_hack_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A) textBox_output.SelectAll();
        }

        private void textBox_input_TextChanged(object sender, EventArgs e)
        {
            /* char test = 'a';
             for(int i = 0; i < 40; i++)
             {
                 test.= Char.(int)Char.GetNumericValue(test) + 1;
                 textBox_input.Text += test + Environment.NewLine;
             }*/
        }
        /*char[] RusBig = { 'А','Б','В','Г','Д','Е','Ё','Ж','З','И','Й','К','Л','М',
                'Н','О','П','Р','С','Т','У','Ф','Х','Ц','Ч','Ш','Щ','Ъ','Ы','Ь','Э','Ю','Я'};
        char[] RusSmall = { 'а','б','в','г','д','е','ё','ж','з','и','й','к','л','м',
                'н','о','п','р','с','т','у','ф','х','ц','ч','ш','щ','ъ','ы','ь','э','ю','я'};
        char[] EngBig = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        char[] EngSmall = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };*/
        string RusBig = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        string RusSmall = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        string EngBig = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string EngSmall = "abcdefghijklmnopqrstuvwxyz";
        string Rotate(int keyEng, int keyRus, string input)
        {
            string tempstring = "";

            foreach (char c in input)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    tempstring += EngBig[(c + keyEng - 'A') % 26];
                }
                else if (c >= 'a' && c <= 'z')
                {
                    tempstring += EngSmall[(c + keyEng - 'a') % 26];
                }
                else if (c >= 'А' && c <= 'Я' || c == 'Ё')
                {
                    if (c == 'Ё')
                    {
                        tempstring += RusBig[(6 + keyRus) % 33];
                    }
                    else
                    {
                        if (c >= 'Ж' && c <= 'Я')
                        {
                            tempstring += RusBig[(c + keyRus - 'А' + 1) % 33];
                        }
                        else
                        {
                            tempstring += RusBig[(c + keyRus - 'А') % 33];
                        }
                    }
                }
                else if (c >= 'а' && c <= 'я' || c == 'ё')
                {
                    if (c == 'ё')
                    {
                        tempstring += RusSmall[(6 + keyRus) % 33];
                    }
                    else
                    {
                        if (c >= 'ж' && c <= 'я')
                        {
                            tempstring += RusSmall[(c + keyRus - 'а' + 1) % 33];
                        }
                        else
                        {
                            tempstring += RusSmall[(c + keyRus - 'а') % 33];
                        }
                    }
                }
                else
                {
                    tempstring += c;
                }
            }
            return tempstring;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox_output.Text = Rotate((int)numericUpDownKeyEng.Value, (int)numericUpDownKeyRus.Value, textBox_input.Text);
          
                try
                {
                    StreamWriter sw = new StreamWriter(registrationForm.login+"_log.txt", true);
                    sw.WriteLine("------------------------------------------------------------------------\r\n");
                    sw.WriteLine(DateTime.Now + " Результат шифрования:\r\n");
                    sw.WriteLine(textBox_output.Text + "\r\n");
                    sw.Close();
                }
                catch (Exception ex) // ошибки
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox_output.Text = Rotate(26 - (int)numericUpDownKeyEng.Value, 33 - (int)numericUpDownKeyRus.Value, textBox_input.Text);

            try
            {
                StreamWriter sw = new StreamWriter(registrationForm.login + "_log.txt", true);
                sw.WriteLine("------------------------------------------------------------------------\r\n");
                sw.WriteLine(DateTime.Now + " Результат дешифровки:\r\n");
                sw.WriteLine(textBox_output.Text + "\r\n");
                sw.Close();
            }
            catch (Exception ex) // ошибки
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            numericUpDownKeyRus.Value = rnd.Next() % 32 + 1;
            numericUpDownKeyEng.Value = rnd.Next() % 25 + 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string tempstring = textBox_input.Text;
            tempstring = tempstring.Substring(0, tempstring.Length>=45?44 : tempstring.Length-1);
            string resultstrings = "";
            for (int i = 0; i < 33; i++)
            {
                resultstrings += "Eng=" + (26 - i % 26).ToString() + " Rus=" + (33 - i % 32).ToString() + "     " + Rotate(i % 26, i % 32, tempstring) + "\r\n";
            }
            textBox_hack.Text = resultstrings;
        }




        string allRus = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        string allEng = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        int[] countRus = new int[33];
        int[] countEng = new int[26];



        int intArrayMaxId(int [] intArray)
        {
            int tempid= 0, tempmax= intArray[0];
            for(int i=1; i<intArray.Length;i++)
            {
                if(intArray[i]> tempmax)
                {
                    tempid = i;
                    tempmax = intArray[i];
                }
                

            }

            return tempid;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string tempstring = textBox_input.Text;
            Array.Clear(countRus, 0, countRus.Length);
            Array.Clear(countEng, 0, countEng.Length);
            int indexOfChar;
            foreach (char c in tempstring)
            {
                indexOfChar = allRus.IndexOf(c);
                if (indexOfChar != -1)
                {
                    ++countRus[indexOfChar % 33];
                }
                else
                {
                    indexOfChar = allEng.IndexOf(c);
                    if (indexOfChar != -1)
                    {
                        ++countEng[indexOfChar % 26];
                    }
                    
                }
            }
            int rusMostPopularId = intArrayMaxId(countRus);
            int engMostPopularId = intArrayMaxId(countEng);

            //char rusMostPopular = RusSmall[intArrayMaxId(countRus)];
            //char engMostPopular = EngSmall[intArrayMaxId(countEng)];
            ////////заносим сдвиги самой популярной буквы(сдвиг относительно статистически самых частых букв) в массив
            int[] rusMostPopularRotate = new int[10];
            int[] engMostPopularRotate = new int[10];
            string rusMostPopularSymbols = "оеаинтсрвл";
            string engMostPopularSymbols = "etaoinshrd";
            

            for (int i = 0; i < 10; i++) {
                rusMostPopularRotate[i] = RusSmall.IndexOf(rusMostPopularSymbols[i]) - rusMostPopularId >= 0 ? RusSmall.IndexOf(rusMostPopularSymbols[i]) - rusMostPopularId : RusSmall.IndexOf(rusMostPopularSymbols[i]) - rusMostPopularId + 32;
                engMostPopularRotate[i] = EngSmall.IndexOf(engMostPopularSymbols[i]) - engMostPopularId >= 0 ? EngSmall.IndexOf(engMostPopularSymbols[i]) - engMostPopularId : EngSmall.IndexOf(engMostPopularSymbols[i]) - engMostPopularId + 25;
            }//на данном этапе мы получили массив с 10ю наиболее вероятными с точки зрения частотности символов смещениями

            string teststring =tempstring.Substring(0, tempstring.Length >= 45 ? 44 : tempstring.Length - 1);
            string resultstrings = "";
            for (int i = 0; i < 10; i++)
            {
                resultstrings += "Eng = " + (26-engMostPopularRotate[i]-1).ToString() + "\tRus = " + (33-rusMostPopularRotate[i]-1).ToString() + "\t" + Rotate(engMostPopularRotate[i]+1, rusMostPopularRotate[i]+1, teststring) + "\r\n";
            }
            textBox_hack.Text = resultstrings;








            /* Взлом шифра методом частотного анализа эффективен лишь для длинного текста. 
             В данной реализации мы выводим варианты для 10и самых встречаемых букв языка.
             В случае шифра цезаря достаточно найти лишь самую частую букву, ибо шифр каждой буквы не уникален, а просто идёт смещение.

о	10.97%
е	8.45%
а	8.01%
и	7.35%
н	6.70%
т	6.26%
с	5.47%
р	4.73%
в	4.54%
л	4.40%
---------
e	12.702%
t	9.056%
a	8.167%
o	7.507%
i	6.966%
n	6.749%
s	6.327%
h	6.094%
r	5.987%
d	4.253%
             */

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void saveAsOwnTextFormat(string textToSave)
        {

            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "*.txt";
            saveFile1.Filter = "Text files|*.txt";
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                saveFile1.FileName.Length > 0)
            {
                try
                {
                    //Создаём или перезаписываем существующий файл
                    StreamWriter sw = File.CreateText(saveFile1.FileName);
                    //Записываем текст в поток файла
                    sw.WriteLine(textToSave);
                    //Закрываем файл
                    sw.Close();
                }
                catch (Exception ex) // ошибки
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private string openFromOwnTextFormat()
        {
            OpenFileDialog openfile1 = new OpenFileDialog();
            openfile1.DefaultExt = "*.txt";
            openfile1.Filter = "Text files|*.txt";
            if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openfile1.FileName.Length > 0)
            {

                string mytext = "";
                try
                {
                    using (StreamReader sr = new StreamReader(openfile1.FileName))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            mytext += line + "\r\n";
                        }
                    }
                    return mytext;
                }
                catch
                {
                    MessageBox.Show("Error when opening file");
                    
                }
            }
            return "";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            saveAsOwnTextFormat(textBox_output.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox_input.Text = openFromOwnTextFormat();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            saveAsOwnTextFormat(numericUpDownKeyRus.Value.ToString() + "|" + numericUpDownKeyEng.Value.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string keys = openFromOwnTextFormat();
            string[] words = keys.Split(new char[] { '|' });
            int val = -2;
             
            if (Int32.TryParse(words[0], out val) && val <= 32)
            {
                numericUpDownKeyRus.Value = Int32.Parse(words[0]);
                val = -2;

                if (Int32.TryParse(words[1], out val) && val<=25)
                {
                    numericUpDownKeyEng.Value = Int32.Parse(words[1]);
                }
                else
                {
                    MessageBox.Show("Файл повреждён");
                }
            }
            else {
                MessageBox.Show("Файл повреждён");
            }

        }
             

        void setLang(int lang)
        {
            label1.Text = registrationForm.labelKeys[lang];
            label4.Text = registrationForm.labelOrigText[lang];
            label5.Text = registrationForm.labelProcessedText[lang];
            label6.Text = registrationForm.labelHack[lang];
            button10.Text = registrationForm.buttonLoad[lang];
            button9.Text = registrationForm.buttonSave[lang];
            button4.Text = registrationForm.buttonRandomKeys[lang];
            button7.Text = registrationForm.buttonSaveKeys[lang];
            button8.Text = registrationForm.buttonLoadKeys[lang];
            button2.Text = registrationForm.buttonEncrypt[lang];
            button3.Text = registrationForm.buttonDecrypt[lang];
            button5.Text = registrationForm.buttonHack1[lang];
            button6.Text = registrationForm.buttonHack2[lang];
            button1.Text = registrationForm.buttonExit[lang];
            button11.Text = registrationForm.buttonSwitchLang[lang];
        }

        private void button11_Click(object sender, EventArgs e)
        {
            registrationForm.lang = registrationForm.lang == 0 ? 1 : 0;
            setLang(registrationForm.lang);
        }

            
private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            registrationForm.selectTab(2);
            this.Hide();          
            registrationForm.ShowDialog(); // Отображаем форму авторизации.
            this.Show();
            registrationForm.selectTab(0);
            nameLabel.Text = "User: " + registrationForm.login;
            if (registrationForm.PathOfPicture != "NonChoosed" && registrationForm.PathOfPicture != String.Empty)
            {
                try
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = Image.FromFile(registrationForm.PathOfPicture);
                }
                catch (OutOfMemoryException ex)
                {
                    MessageBox.Show("Ошибка чтения картинки");
                    return;
                }

            }
        }
    }
}
