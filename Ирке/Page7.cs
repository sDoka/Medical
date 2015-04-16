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
    public partial class Page7 : Form
    {
        PersonCheck p1 = new PersonCheck();
        public Page7(PersonCheck p)
        {
            InitializeComponent();
            p1 = p;
        }

        private int[] gb1()//баллы за ответ на 9ый вопрос
        {
            int[] ans = new int[9];
            for (int j = 0; j < 9; j++)
            {
                for (int i = 0; i < 6; i++)
                {
                    if (((RadioButton)((GroupBox)mainGB.Controls[j]).Controls[i]).Checked == true) { ans[j] = Math.Abs(i - 6); }

                }
            }
            return ans;
        }

        private void nextBTN_Click(object sender, EventArgs e)
        {
            p1.setQ(22, 9, this.gb1());
            this.Hide();
            Page8 p8 = new Page8(p1);
            p8.Show();
        }

        private void Page7_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main m = new Main();
            m.Show();
        }
    }
}
