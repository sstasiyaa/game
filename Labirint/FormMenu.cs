using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        
        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            start_level1();
        }

        private void start_level1()
        {
            Form_level1 level1 = new Form_level1();
            DialogResult dr = level1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                start_level2();
            }
        }

        private void start_level2()
        {
            Form_level2 level2 = new Form_level2();
            DialogResult dr = level2.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                start_level3();
            }
        }

        private void start_level3()
        {
            Form_level3 level3 = new Form_level3();
            DialogResult dr = level3.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                start_level4();
            }
        }

        private void start_level4()
        {
            Form_level4 level4 = new Form_level4();
            DialogResult dr = level4.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Все уровни пройдены!", "Поздравляем");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_с();
        }

        private void Form_с()
        {
            Form_с Form_с = new Form_с();
            Form_с.Show();
        }
    }
}
