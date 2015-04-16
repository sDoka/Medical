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
    public partial class Page6 : Form
    {
        PersonCheck p1 = new PersonCheck();
        public Page6(PersonCheck p)
        {
            InitializeComponent();
            p1 = p;
        }

        private void nextBTN_Click(object sender, EventArgs e)
        {
            p1.setQ(19, 3, this.gb1());
            this.Hide();
            Page7 p7 = new Page7(p1);
            p7.Show();
        }

        private int[] gb1()//баллы за ответ на 6.7.8ый вопросы
        {
            int[] ans = new int[3];
            for (int j = 0; j < 3; j++)//кол-во вопросов
            {
                if (j!= 1)
                for (int i = 0; i < 5; i++)//кол-во вариантов ответа
                {
                    if (((RadioButton)((GroupBox)mainGB.Controls[j]).Controls[i]).Checked == true) { ans[j] = Math.Abs(i - 5); }

                }
                else
                {
                    for (int i = 0; i < 6; i++)//кол-во вариантов ответа
                    {
                        if (((RadioButton)((GroupBox)mainGB.Controls[j]).Controls[i]).Checked == true) { ans[j] = Math.Abs(i - 6); }

                    }
                }
            }
            return ans;
        }

        private void Page6_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main m = new Main();
            m.Show();
        }
    }
}
