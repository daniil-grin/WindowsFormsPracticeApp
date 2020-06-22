using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPracticeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Создать объект FEmployee класса FormEmployee
            FormEmployee FEmployee = new FormEmployee();
            // Установить родительское окно для дочернего
            FEmployee.MdiParent = this;
            // Вывести на экран дочерее окно
            FEmployee.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            employeeToolStripMenuItem_Click(sender, e);
        }
    }
}
