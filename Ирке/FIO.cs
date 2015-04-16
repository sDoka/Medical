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
    public partial class FIO : Form
    {
       public PersonCheck p = new PersonCheck();
       
        public FIO()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            p.setFIO(""+familia.Text.ToString()+" "+name.Text.ToString()+" "+otchestvo.Text.ToString()+"");
            this.Hide();
            page1_2 o = new page1_2(p);
            o.Show();

        }

        private void FIO_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main m = new Main();
            m.Show();
        }


        private void onlyRus(object sender, KeyPressEventArgs e)
        {
            //char l = e.KeyChar;
            //if (l < 'А' || l > 'я' )
            //    e.Handled = true;
            //if (l == (Char)Keys.Back)//чёзаговно не работает
            //    e.Handled = true;

         
        }


    }
}
