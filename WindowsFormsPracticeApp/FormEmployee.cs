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
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }
        private void Undo()
        {
            MessageBox.Show("метод Undo");
        }
        private void New()
        {
            MessageBox.Show("метод New");
        }
        private void Edit()
        {
            MessageBox.Show("метод Edit");
        }
        private void Save()
        {
            MessageBox.Show("метод Save");
        }
        private void Remove()
        {
            MessageBox.Show("метод Remove");
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remove();
        }
    }
}
