namespace Reg
{
    partial class MainForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDownKeyRus = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownKeyEng = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox_hack = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKeyRus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKeyEng)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(15, 84);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(91, 34);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "label1";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Location = new System.Drawing.Point(979, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 223);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(42, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 85);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(39, 119);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(118, 45);
            this.button11.TabIndex = 2;
            this.button11.Text = "Switch language";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(0, 35);
            this.textBox_input.Multiline = true;
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_input.Size = new System.Drawing.Size(503, 197);
            this.textBox_input.TabIndex = 2;
            this.textBox_input.TextChanged += new System.EventHandler(this.textBox_input_TextChanged);
            this.textBox_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_input_KeyDown);
            // 
            // textBox_output
            // 
            this.textBox_output.Location = new System.Drawing.Point(0, 265);
            this.textBox_output.Multiline = true;
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_output.Size = new System.Drawing.Size(503, 301);
            this.textBox_output.TabIndex = 3;
            this.textBox_output.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_output_KeyDown);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(507, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "Зашифровать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDownKeyRus
            // 
            this.numericUpDownKeyRus.Location = new System.Drawing.Point(441, 9);
            this.numericUpDownKeyRus.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDownKeyRus.Name = "numericUpDownKeyRus";
            this.numericUpDownKeyRus.Size = new System.Drawing.Size(66, 20);
            this.numericUpDownKeyRus.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ключи:";
            // 
            // numericUpDownKeyEng
            // 
            this.numericUpDownKeyEng.Location = new System.Drawing.Point(556, 9);
            this.numericUpDownKeyEng.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownKeyEng.Name = "numericUpDownKeyEng";
            this.numericUpDownKeyEng.Size = new System.Drawing.Size(66, 20);
            this.numericUpDownKeyEng.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Рус";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Eng";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(507, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(230, 44);
            this.button3.TabIndex = 11;
            this.button3.Text = "Расшифровать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(628, -1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 39);
            this.button4.TabIndex = 12;
            this.button4.Text = "Случайно";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(743, 44);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(230, 44);
            this.button5.TabIndex = 13;
            this.button5.Text = "Взлом перебором";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(743, 94);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(230, 44);
            this.button6.TabIndex = 15;
            this.button6.Text = "Частотный анализ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox_hack
            // 
            this.textBox_hack.Location = new System.Drawing.Point(509, 265);
            this.textBox_hack.Multiline = true;
            this.textBox_hack.Name = "textBox_hack";
            this.textBox_hack.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_hack.Size = new System.Drawing.Size(632, 301);
            this.textBox_hack.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(0, 2);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(165, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Исходный текст";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(0, 237);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(210, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Обработанный текст";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(518, 237);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Взлом";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(714, -1);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(104, 20);
            this.button7.TabIndex = 20;
            this.button7.Text = "Сохранить ключи";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(714, 18);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(104, 20);
            this.button8.TabIndex = 21;
            this.button8.Text = "Загрузить ключи";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(216, 235);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(163, 27);
            this.button9.TabIndex = 22;
            this.button9.Text = "Сохранить";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(171, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(163, 27);
            this.button10.TabIndex = 23;
            this.button10.Text = "Загрузить";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.Location = new System.Drawing.Point(0, 119);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(33, 96);
            this.button12.TabIndex = 4;
            this.button12.Text = "⚙";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 566);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_hack);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownKeyEng);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownKeyRus);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_output);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reg";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKeyRus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKeyEng)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.TextBox textBox_output;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDownKeyRus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownKeyEng;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox_hack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button12;
    }
}

