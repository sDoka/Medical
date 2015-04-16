using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ирке
{
    public partial class Page5 : Form
    {
        PersonCheck p1 = new PersonCheck();
        public Page5(PersonCheck p)
        {
            InitializeComponent();
            p1 = p;
        }

        private void button2_Click(object sender, EventArgs e)//назад
        {
            //this.Hide();
            //Page4 p4 = new Page4();
            //p4.Show();
        }

        private void button1_Click(object sender, EventArgs e)//вперёд
        {
            p1.setQ(16, 3, this.gb1());
            this.Hide();
            Page6 p6 = new Page6(p1);
            p6.Show();
        }

        private int[] gb1()//баллы за ответ на 5ый вопрос
        {
            int[] ans = new int[3];
            for (int j = 0; j < 3; j++)//кол-во вопросов
            {
                for (int i = 0; i < 2; i++)//кол-во вариантов ответа
                {
                    if (((RadioButton)((GroupBox)mainGB.Controls[j]).Controls[i]).Checked == true) { ans[j] = Math.Abs(i - 2); }

                }
            }
            return ans;
        }

        private void Page5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main m = new Main();
            m.Show();
        }
    }
}
