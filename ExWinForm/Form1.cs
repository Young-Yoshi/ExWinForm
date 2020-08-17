using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ExWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //////////////////////////////////////////
        int question = 1;
        int mark = 0;
        bool correct = false;
        //////////////////////////////////////////
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            button1.Visible = false;
            label3.Visible = true;
            label1.Visible = false;
            label5.Visible = false;
            radioButton1.Visible = true; radioButton2.Visible = true;
            radioButton3.Visible = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (question == 2)
                {
                    correct = true;

                }
            }
            if (radioButton2.Checked == true)
            {
                if (question == 1 || question == 4)
                {
                    correct = true;
                }
            }
            if (radioButton3.Checked == true)
            {
                if (question == 3 || question == 5)
                {
                    correct = true;
                }
            }
            question++;
            if (question == 2)
            {
                label3.Text = "Куда ведёт дорога желтого кирпича?";
                radioButton1.Text = "Изумрудный город";
                radioButton2.Text = "Северный полюс";
                radioButton3.Text = "Домой";
            }
            if (question == 3)
            {
                label3.Text = "Кто открыл Америку?";
                radioButton1.Text = "Бетховен";
                radioButton2.Text = "Я";
                radioButton3.Text = "Колумб";
            }
            if (question == 4)
            {
                label3.Text = "Кто нашёл волшебную лампу?";
                radioButton1.Text = "Кабиб";
                radioButton2.Text = "Алладин";
                radioButton3.Text = "Мерхаба";
            }
            if (question == 5)
            {
                label3.Text = "Кто написал картину Мона Лизы?";
                radioButton1.Text = "Ван Гог";
                radioButton2.Text = "Моне";
                radioButton3.Text = "Да Винчи"; // +

            }
            if (correct == true)
            {
                correct = false;
                mark++;
            }
            if (question == 6)
            {
                MessageBox.Show($"Ваша оценка за экзамен: {mark }");
                Application.Exit();
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }


    // Буду очень скучано по вашим парам ='( 
}

