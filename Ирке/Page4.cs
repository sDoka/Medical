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
    public partial class Page4 : Form
    {
        PersonCheck p1 = new PersonCheck();
        public Page4(PersonCheck p)
        {
            InitializeComponent();
            button2.Enabled = false;
            p1 = p;

        }

        private void button2_Click(object sender, EventArgs e)//назад
        {

          //  Page3 p3 = new Page3();
            //p3.Show();
        }

        private void button1_Click(object sender, EventArgs e)//вперёд
        {
            p1.setQ(12, 4, this.gb1());
            this.Hide();

            Page5 p5 = new Page5(p1);
            p5.Show();
        }

        private int[] gb1()//баллы за ответ на 4ый вопрос
        {
            int[] ans = new int[4];
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 2; i++)
                {
                    if (((RadioButton)((GroupBox)mainGB.Controls[j]).Controls[i]).Checked == true) { ans[j] = Math.Abs(i - 2); }

                }
            }
            return ans;
        }

        private void Page4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main m = new Main();
            m.Show();
        }


    }
}
