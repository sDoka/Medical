using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Ирке
{
    public partial class Page8 : Form
    {
        PersonCheck p1 = new PersonCheck();
        public Page8(PersonCheck p)
        {

            InitializeComponent();
            p1 = p;
        }

        private void Page8_Load(object sender, EventArgs e)
        {

        }






        private void finishBTN_Click(object sender, EventArgs e)//сохранение
        {
            p1.setQ(31, this.gb2());
            p1.setQ(32, 4, this.gb1());
            
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "Опросник";

            sfd.DefaultExt = "csv";
            sfd.Filter = "Файл опросника (*.csv)| *.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {

                write2file(sfd.FileName);
                MessageBox.Show("Файл сохранен", "Всё ок =)");
                this.Hide();
                Main m = new Main();
                m.Show();
            }
            else MessageBox.Show("Ошибка при попытке сохранения файла" );
        }





        private int gb2()//баллы за ответ на 10 вопрос
        {
            int ans = 0;
            for (int i = 0; i < 5; i++)
            {
                if (((RadioButton)subGB.Controls[i]).Checked == true) { ans = Math.Abs(i - 5); }

            }
            return ans;
        }
        private int[] gb1()//баллы за ответ на 11ый вопрос
        {
            int[] ans = new int[4];
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (((RadioButton)((GroupBox)mainGB.Controls[j]).Controls[i]).Checked == true) { ans[j] = Math.Abs(i - 6); }

                }
            }
            return ans;
        }

        private void write2file(string path)
        {
            string s = "";
            string name = p1.getFIO();
            int[] arr = p1.getQ();
           
            StreamWriter sw = new StreamWriter(path, true, Encoding.GetEncoding(1251));
            
            s = String.Join(";", arr);
            sw.Write('\n'+name +";" + s +";");
                sw.Close();
        }

        private void Page8_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main m = new Main();
            m.Show();
        }
    }
}
