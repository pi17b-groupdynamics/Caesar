using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Reg
{
    public partial class RegForm : Form
    {
        RegistrationForm registrationForm = new RegistrationForm();

        public RegForm()
        {
            InitializeComponent();

            registrationForm.ShowDialog(); // Отображаем форму авторизации.

            nameLabel.Text = "User: " + registrationForm.login;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            registrationForm.login = string.Empty;
            registrationForm.password = string.Empty;
            registrationForm.ShowDialog(); // Отображаем форму авторизации.
            this.Show();
            nameLabel.Text = "User: " + registrationForm.login;
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
        char[] RusBig = { 'А','Б','В','Г','Д','Е','Ё','Ж','З','И','Й','К','Л','М',
                'Н','О','П','Р','С','Т','У','Ф','Х','Ц','Ч','Ш','Щ','Ъ','Ы','Ь','Э','Ю','Я'};
        char[] RusSmall = { 'а','б','в','г','д','е','ё','ж','з','и','й','к','л','м',
                'н','о','п','р','с','т','у','ф','х','ц','ч','ш','щ','ъ','ы','ь','э','ю','я'};
        char[] EngBig = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        char[] EngSmall = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

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
            /*
ABCDEFGHIJKLMNOPQRSTUVWXYZ
abcdefghijklmnopqrstuvwxyz
АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ
абвгдеёжзийклмнопрстуфхцчшщъыьэюя
   */
            /* 
             for (int i = 0; i < 100; i++)
             {
                 textBox_input.Text += (i+1) + "\t" + a + "\t" + b + "\t" + c + "\t" + d + Environment.NewLine;
                 a++;
                 b++;
                 c++;
                 d++;
             }
             */
            /* string small = "abcdefghijklmnopqrstuvwxyz", big = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
             string[] imoN = new string[26];
             string[] imoZ = new string[26];
             int x, q = 0, key = 0;
             Console.WriteLine("Кодування файлу методом Цезаря...\n");
             StreamReader s = new StreamReader(File.Open(@"c:\in.txt", FileMode.Open));
             string c = s.ReadToEnd();
             StreamWriter sw = new StreamWriter(@"c:\zak.txt", true, Encoding.Default);
             for (int j = 0; j < c.Length; j++)
             {
                 if (c[j] == ' ')
                     sw.Write(string.Format(" "));
                 if (c[j] == '\n')
                     sw.Write(string.Format("\n"));
                 for (int i = 0; i <= 25; i++)
                 {
                     x = (i + 5) % 26;
                     if (c[j] == small[i])
                         sw.Write(string.Format(@"{0}", small[x]));
                     if (c[j] == big[i])
                         sw.Write(string.Format(@"{0}", big[x]));
                 }
             }
             for (char ch = 'a', ch1 = 'A'; ch <= 'z' || ch1 <= 'Z'; ch++, ch1++)
             {
                 float j = 0.0f;
                 for (int i = 0; i < c.Length; i++)
                 {
                     if (c[i] == ch || c[i] == ch1)
                         ++j;
                 }
                 imoN[q] = Convert.ToString(j / c.Length);
                 ++q;
             }
             sw.Close();
             StreamReader cs = new StreamReader(File.Open(@"c:\zak.txt", FileMode.Open));
             string ss = cs.ReadToEnd();
             q = 0;
             for (char ch = 'a', ch1 = 'A'; ch <= 'z' || ch1 <= 'Z'; ch++, ch1++)
             {
                 float j = 0.0f;
                 for (int i = 0; i < ss.Length; i++)
                 {
                     if (ss[i] == ch || ss[i] == ch1)
                         ++j;
                 }
                 imoZ[q] = Convert.ToString(j / c.Length);
                 ++q;
             }
             for (int r = 0; r < imoZ.Length; r++)
             {
                 if (imoN[25] == imoZ[r])
                 {
                     for (int i = 0; i <= 25; i++)
                     {
                         if (small[i] == small[r])
                             key = (26 + i - 25) % 26;
                     }
                 }
             }
             Console.Write("Key={0}\n", key);
             cs.Close();
             StreamReader sd = new StreamReader(File.Open(@"c:\zak.txt", FileMode.Open));
             string cd = sd.ReadToEnd();
             StreamWriter sq = new StreamWriter(@"c:\dek.txt", true, Encoding.Default);
             for (int j = 0; j < cd.Length; j++)
             {
                 if (cd[j] == ' ')
                     sq.Write(string.Format(" "));
                 if (cd[j] == '\n')
                     sq.Write(string.Format("\n"));
                 for (int i = 0; i <= 25; i++)
                 {
                     x = (i + 26 - key) % 26;
                     if (cd[j] == small[i])
                         sq.Write(string.Format(@"{0}", small[x]));
                     if (cd[j] == big[i])
                         sq.Write(string.Format(@"{0}", big[x]));
                 }
             }
             sq.Close();
             Console.WriteLine("\nФайл для кодування: c:\\in.txt\nЗакодований файл: c:\\zak.txt\nДекодований файл: c:\\dek.txt");
             Console.Read();
         }*/
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox_output.Text = Rotate(26 - (int)numericUpDownKeyEng.Value, 33 - (int)numericUpDownKeyRus.Value, textBox_input.Text);
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
            string resultstrings="";
            for (int i = 0; i < 33; i++)
            {
                resultstrings+= "Eng=" + (26 - i % 26).ToString() + " Rus=" + (33-i % 32).ToString() + "     "+ Rotate(i%26, i%32, tempstring)+ "\r\n";
            }
              textBox_hack.Text = resultstrings;
        }
        enum _RusBig  { А, Б, В, Г, Д, Е, Ё, Ж, З, И, Й, К, Л, М,
                Н, О, П, Р, С, Т, У, Ф, Х, Ц, Ч, Ш, Щ, Ъ, Ы, Ь, Э, Ю, Я};
        enum _RusSmall { а, б, в, г, д, е, ё, ж, з, и, й, к, л, м,
                н, о, п, р, с, т, у, ф, х, ц, ч, ш, щ, ъ, ы, ь, э, ю, я};
        enum _EngBig { A, B, C, D, E, F, G, H, I, J, K, L, M,
                N, O, P, Q, R, S, T, U, V, W, X, Y, Z };
        enum _EngSmall { a, b, c, d, e, f, g, h, i, j, k, l, m,
                n, o, p, q, r, s, t, u, v, w, x, y, z };
        _RusBig eRusBig;
        _RusSmall eRusSmall;
        _EngBig eEngBig;
        _EngSmall eEngSmall;
        int [] countRus = new int [33];
        int [] countEng = new int [26];
        private void button6_Click(object sender, EventArgs e)
        {
            
        }
    }
}
