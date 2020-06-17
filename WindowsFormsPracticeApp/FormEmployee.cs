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
            DialogResult result = MessageBox.Show(" Удалить данные  \n по сотруднику? ", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            switch (result)
            {
                case DialogResult.Yes:
                {
                    //выполнить действия по удалению данных по сотруднику 
                    MessageBox.Show("Удаление данных");
                    break;
                }
                case DialogResult.No:
                {
                    //отмена удаления данных по сотруднику   
                    MessageBox.Show("Отмена удаления данных");
                    break;
                }
            }
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
