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
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поздравляю с первым(?) проектом на C#");
        }
        private void changeColor(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.Aqua)
            {
                button3.BackColor = Color.Lime;
                button2.BackColor = Color.Aqua;
            }
            else
            {
                button3.BackColor = Color.Aqua;
                button2.BackColor = Color.Lime;
            }
            // button2.BackColor = (button2.BackColor == Color.Aqua) ? Color.Lime : Color.Aqua;
            // button3.BackColor = (button2.BackColor == Color.Aqua) ? Color.Lime : Color.Aqua;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
