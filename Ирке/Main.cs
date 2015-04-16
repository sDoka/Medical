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
    public partial class Main : Form
    {
    
       
       // string output = @"";
        public Main()
        {
           
            InitializeComponent();
        }


       private void button2_Click(object sender, EventArgs e)
        {
            
           
            this.Hide();
            FIO f2 = new FIO();
            f2.Show();
        }
        
        private void SaveFileAs()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "";

            sfd.DefaultExt = ".csv";
            sfd.Filter = "Файлы опросника (*.csv)| *.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {

                // write2file(sfd.FileName);
                MessageBox.Show("Файл сохранен", "Всё ок =)");
            }
        }

        private void select_Resp_Click(object sender, EventArgs e)
        {
            Respondents r = new Respondents();

            this.Hide();
            r.Show();

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(1);
          
        }






    }
}
