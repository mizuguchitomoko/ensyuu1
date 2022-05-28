using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ensyuu1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 1; i <= 10; i++)//初期化;条件式;変化式;
            {
                if(i == 5)//iが5だった場合の処理
                {
                    MessageBox.Show(i.ToString());//実行する処理
                    MessageBox.Show("ここで半分です");
                }
                else//変数iが5以外の処理
                {
                    MessageBox.Show(i + "");
                }
            }
        }
    }
}
