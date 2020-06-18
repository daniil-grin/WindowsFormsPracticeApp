﻿using System;
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

        private void toolStripButtonUndo_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            New();
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void toolStripButtonRemove_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void toolStripMenuUndo_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void toolStripMenuNew_Click(object sender, EventArgs e)
        {
            New();
        }

        private void toolStripMenuEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void toolStripMenuSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void toolStripMenuRemove_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void actionToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "Выбор действий по сотрудникам";
        }

        private void allToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "";
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void undoToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "Отменить редактирование данных по сотруднику";
        }

        private void createToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "Создание данных по сотруднику";
        }

        private void editToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "Редактировать данные по сотруднику";
        }

        private void saveToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "Сохранить данные по сотруднику";
        }

        private void removeToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "Удалить данные по сотруднику";
        }

        private void reportToolStripMenuItem1_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "Создать отчет по сотруднику";
        }

        private void reportToolStripMenuItem2_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "Создать отчет по всем сотрудникам";
        }
    }
}
