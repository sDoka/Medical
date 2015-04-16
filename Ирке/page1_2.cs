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
    public partial class page1_2 : Form
    {
        int[] mas = new int[2];
        PersonCheck p1 = new PersonCheck();

       
        public page1_2(PersonCheck p)
        {
            InitializeComponent();
            p1 = p;
            
        }


        public void nextBTN_Click(object sender, EventArgs e)
        {
          
          string s =   p1.getFIO();
            
            p1.setQ(0, this.gb1());
            p1.setQ(1, this.gb2());
            this.Hide();
            Page3 p3 = new Page3(p1);
            p3.Show();
        }

        private int  gb1()//баллы за ответ на 1ый вопрос
        {
            int ans = 0;
            for (int i = 0; i < 5; i++)
            {
                if (((RadioButton)groupBox1.Controls[i]).Checked == true) { ans = Math.Abs(i - 5); }
                
            }
            return ans;
        }
        private int gb2()//баллы за ответ на второй вопрос
        {
            int ans = 0;
            for (int i = 0; i < 5; i++)
            {
                if (((RadioButton)groupBox2.Controls[i]).Checked == true) { ans = Math.Abs(i - 5); }

            }
            return ans;
        }

        private void page1_2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main m = new Main();
            m.Show();
        }

    }
}
