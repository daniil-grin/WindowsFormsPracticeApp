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
        DataSetEmployee dsEmployee = new DataSetEmployee();
        DataSetEmployeeTableAdapters.EmployeeTableAdapter daEmployee = new WindowsFormsPracticeApp.DataSetEmployeeTableAdapters.EmployeeTableAdapter();
        DataSetEmployeeTableAdapters.JobTitleTableAdapter daJobTitle = new WindowsFormsPracticeApp.DataSetEmployeeTableAdapters.JobTitleTableAdapter();
        BindingManagerBase bmEmployee;
        public FormEmployee()
        {
            InitializeComponent();
            bmEmployee = this.BindingContext[dsEmployee, "Employee"];
            // Добавляем делегата  PositionChanged для события - изменение позиции в таблице Employee DataSet dsEmployee
            bmEmployee.PositionChanged += new EventHandler(BindingManagerBase_PositionChanged);
        }
        private void FormEmployee_Load(object sender, EventArgs e)
        {
            // this.WindowState = FormWindowState.Maximized;
            DisplayForm(true);
            EmployeeFill();
            this.listBoxEmployee.DataSource = this.dsEmployee;
            this.listBoxEmployee.DisplayMember = "Employee.EmployeeSurname";
            textBoxSurname.DataBindings.Add("Text", dsEmployee, "Employee.EmployeeSurname");
            textBoxName.DataBindings.Add("Text", dsEmployee, "Employee.EmployeeName");
            textBoxPatronymic.DataBindings.Add("Text", dsEmployee, "Employee.EmployeePatronymic");
            textBoxNetName.DataBindings.Add("Text", dsEmployee, "Employee.NetName");
            this.comboBoxAccess.Items.AddRange(new object[] {"не задан", "администратор", "начальник смены", "старший оператор", "оператор", "аналитик"});
            comboBoxAccess.DataBindings.Add("Text", dsEmployee, "Employee.Access");
            comboBoxJobRole.DataSource = this.dsEmployee.JobTitle;
            comboBoxJobRole.DisplayMember = "JobRoleName";
            comboBoxJobRole.ValueMember = "JobRoleID";
            comboBoxJobRole.DataBindings.Add("SelectedValue", dsEmployee, "Employee.JobRoleID");
        }
        public void EmployeeFill()
        {
            daJobTitle.Fill(dsEmployee.JobTitle);
            daEmployee.Fill(dsEmployee.Employee);
            // MessageBox.Show("Метод Fill отработал");
        }
        private void BindingManagerBase_PositionChanged(object sender, EventArgs e)
        {
            int pos = ((BindingManagerBase)sender).Position;
            int sel = (int)dsEmployee.Employee[pos].EmployeeStatus;
            this.comboBoxStatus.Text = this.comboBoxStatus.Items[sel].ToString();
        }
        private void Undo()
        {
            MessageBox.Show("метод Undo");
            DisplayForm(true);
        }
        private void New()
        {
            MessageBox.Show("метод New");
            DisplayForm(false);
        }
        private void Edit()
        {
            MessageBox.Show("метод Edit");
            DisplayForm(false);
        }
        private void Save()
        {
            MessageBox.Show("метод Save");
            DisplayForm(true);
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
            DisplayForm(true);
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
        //Задание режима просмотра или редактирования
        public void DisplayReadOnly(bool readOnly)
        {
            if (readOnly)
            {
                this.textBoxSurname.ReadOnly = true;
                this.textBoxName.ReadOnly = true;
                this.textBoxPatronymic.ReadOnly = true;
                this.textBoxNetName.ReadOnly = true;
                this.comboBoxJobRole.Enabled = false;
                this.comboBoxStatus.Enabled = false;
                this.comboBoxAccess.Enabled = false;
            }
            else
            {
                this.textBoxSurname.ReadOnly = false;
                this.textBoxName.ReadOnly = false;
                this.textBoxPatronymic.ReadOnly = false;
                this.textBoxNetName.ReadOnly = false;
                this.comboBoxJobRole.Enabled = true;
                this.comboBoxStatus.Enabled = true;
                this.comboBoxAccess.Enabled = true;
            }
        }
        public void MenuItemEnabled(bool itemEnabled)
        {
            if (itemEnabled)
            {
                this.createToolStripMenuItem.Enabled = true;
                this.editToolStripMenuItem.Enabled = true;
                this.removeToolStripMenuItem.Enabled = true;
                this.undoToolStripMenuItem.Enabled = false;
                this.saveToolStripMenuItem.Enabled = false;
            }
            else
            {
                this.createToolStripMenuItem.Enabled = false;
                this.editToolStripMenuItem.Enabled = false;
                this.removeToolStripMenuItem.Enabled = false;
                this.undoToolStripMenuItem.Enabled = true;
                this.saveToolStripMenuItem.Enabled = true;
            }
        }
        public void MenuItemContextEnabled(bool itemEnabled)
        {
            if (itemEnabled)
            {
                this.toolStripMenuNew.Enabled = true;
                this.toolStripMenuEdit.Enabled = true;
                this.toolStripMenuRemove.Enabled = true;
                this.toolStripMenuUndo.Enabled = false;
                this.toolStripMenuSave.Enabled = false;
            }
            else
            {
                this.toolStripMenuNew.Enabled = false;
                this.toolStripMenuEdit.Enabled = false;
                this.toolStripMenuRemove.Enabled = false;
                this.toolStripMenuUndo.Enabled = true;
                this.toolStripMenuSave.Enabled = true;
            }
        }
        public void StripButtonEnabled(bool itemEnabled)
        {
            if (itemEnabled)
            {
                this.toolStripButtonNew.Enabled = true;
                this.toolStripButtonEdit.Enabled = true;
                this.toolStripButtonRemove.Enabled = true;
                this.toolStripButtonUndo.Enabled = false;
                this.toolStripButtonSave.Enabled = false;
            }
            else
            {
                this.toolStripButtonNew.Enabled = false;
                this.toolStripButtonEdit.Enabled = false;
                this.toolStripButtonRemove.Enabled = false;
                this.toolStripButtonUndo.Enabled = true;
                this.toolStripButtonSave.Enabled = true;
            }
        }
        private void DisplayForm(bool mode)
        {
            DisplayReadOnly(mode);
            MenuItemEnabled(mode);
            MenuItemContextEnabled(mode);
            StripButtonEnabled(mode);
        }
    }
}
