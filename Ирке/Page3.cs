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
    public partial class Page3 : Form
    {

        PersonCheck p1 = new PersonCheck();
        public Page3(PersonCheck p)
        {
            InitializeComponent();
            p1 = p;
        }

        private void nextBTN_Click(object sender, EventArgs e)
        {
           
            p1.setQ(2, 10, this.gb1());
            this.Hide();
            Page4 p4 = new Page4(p1);
            p4.Show();

        }
        private int[] gb1()//баллы за ответ на 3ий вопрос
        {
            int[] ans = new int[10];
            for (int j = 0; j < 10; j++ )
            {
                for (int i = 0; i < 3; i++)
                {
                    if (((RadioButton)((GroupBox)mainGB.Controls[j]).Controls[i]).Checked == true) { ans[j] = Math.Abs(i - 3); }
                    
                }
            }
            return ans;
        }

        private void Page3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main m = new Main();
            m.Show();
        }

    }
}
