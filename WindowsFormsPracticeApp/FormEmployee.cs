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
            AddColumsFullName();
            AddListBoxEmployeeDataSource();
            // this.listBoxEmployee.DataSource = this.dsEmployee;
            // this.listBoxEmployee.DisplayMember = "Employee.EmployeeSurname";
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

            /* Проверка ----
            DataRow employeeRow = dsEmployee.Employee.NewRow();
            employeeRow[1] = 1;
            employeeRow[2] = "Ларина";
            employeeRow[3] = "Татьяна";
            employeeRow[4] = "Ивановна";
            employeeRow[5] = 1;
            employeeRow[6] = 2;
            employeeRow[7] = 1;
            employeeRow[8] = new DateTime(2020, 6, 22);
            employeeRow[9] = new DateTime(2020, 6, 22);
            dsEmployee.Employee.Rows.Add(employeeRow);
            // dsEmployee.Employee.Rows[0].Delete();
            try
            {
                daEmployee.Update(dsEmployee.Employee);
            }
            catch (Exception ex)
            {
              // Код обработки ошибочной ситуации. 
              String err = ex.ToString();
              MessageBox.Show("Ошибка обновления таблицы базы данных  Employee"  + err);
            }
            // */
        }
        public void EmployeeFill()
        {
            daJobTitle.Fill(dsEmployee.JobTitle);
            daEmployee.Fill(dsEmployee.Employee);
            // MessageBox.Show("Метод Fill отработал");
        }
        private void AddColumsFullName()
        {
            dsEmployee.Employee.Columns.Add("FullName", typeof(string),
             "EmployeeSurname+' '+EmployeeName+' '+EmployeePatronymic");
        }
        private void AddListBoxEmployeeDataSource()
        {
            listBoxEmployee.DataSource = this.dsEmployee;
            listBoxEmployee.DisplayMember = "Employee.FullName";
        }
        private void BindingManagerBase_PositionChanged(object sender, EventArgs e)
        {
            int pos = ((BindingManagerBase)sender).Position;
            int sel = (int)dsEmployee.Employee[pos].EmployeeStatus;
            this.comboBoxStatus.Text = this.comboBoxStatus.Items[sel].ToString();
        }
        private void Undo()
        {
            DialogResult result = MessageBox.Show("Отменить изменени?", "Отмена изменений", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        bmEmployee.EndCurrentEdit();
                        dsEmployee.Employee.RejectChanges();
                        break;
                    }
                case DialogResult.No:
                    {
                        //отмена удаления данных по сотруднику  
                        break;
                    }
            }

            DisplayForm(true);
        }
        private void New()
        {
            // Создать новую строку
            DataRow rowEmployee = this.dsEmployee.Employee.NewEmployeeRow();
            // Сформировать начальные значения для элементов строки
            rowEmployee["JobRoleID"] = 3;
            rowEmployee["EmployeeStatus"] = 0;
            rowEmployee["EmployeeSurname"] = "";
            rowEmployee["EmployeeName"] = "";
            rowEmployee["EmployeePatronymic"] = "";
            rowEmployee["Access"] = "не задано";
            rowEmployee["NetName"] = "";
            rowEmployee["Birthday"] = DateTime.Today;
            rowEmployee["FirstDate"] = DateTime.Today;

            // Добавить сформированную строку к таблице Employee
            dsEmployee.Employee.Rows.Add(rowEmployee);
            // Установить активную позицию в таблице Employee на добавленную строку
            int pos = this.dsEmployee.Employee.Rows.Count - 1;
            this.BindingContext[dsEmployee, "Employee"].Position = pos;
            // Задать режим редактирования формы
            DisplayForm(false);
            // Сделать список сотрудников недоступным для выбора
            listBoxEmployee.Enabled = false;
            // Установить фокус на элементе textBoxSurname
            textBoxSurname.Focus();
        }
        private void Edit()
        {
            this.listBoxEmployee.Enabled = false;
            DisplayForm(false);
        }
        private void Save()
        {
            // Завершение текущих обновлений всех  связанных с помощью 
            // объектов Binding элементов управления 
            bmEmployee.EndCurrentEdit();

            /// Формирование таблицы, в которую включаются только 
            // модифицированные строки
            DataSetEmployee.EmployeeDataTable ds1 = 
                (DataSetEmployee.EmployeeDataTable)dsEmployee.Employee.GetChanges(DataRowState.Modified);

            if (ds1 != null)
                try
                {
                    this.daEmployee.Update(ds1);
                    ds1.Dispose();
                    dsEmployee.Employee.AcceptChanges();
                }
                catch (Exception x)
                {
                    string mes = x.Message;
                    MessageBox.Show("Ошибка обновления базы данных Employee " + mes, "Предупреждение");
                    this.dsEmployee.Employee.RejectChanges();
                }
            DisplayForm(true);
            /// Формирование таблицы, в которую включаются только добавленные строки
            DataSetEmployee.EmployeeDataTable ds2 = (DataSetEmployee.EmployeeDataTable)dsEmployee.Employee.
            GetChanges(DataRowState.Added);
            if (ds2 != null)
            {
                try
                {
                    daEmployee.Update(ds2);
                    ds2.Dispose();
                    dsEmployee.Employee.AcceptChanges();
                }
                catch (Exception x)
                {
                    string mes = x.Message;
                    MessageBox.Show("Ошибка вставки записи в базу данных Employee " + mes, "Предупреждение");
                    this.dsEmployee.Employee.RejectChanges();
                }
            }
            listBoxEmployee.Enabled = true;
            textBoxSurname.Focus();
        }

        private void Remove()
        {
            // Определяется позиция, которую необходимо удалить в таблице Employee
            int pos = -1;
            pos = this.BindingContext[dsEmployee, "Employee"].Position;
            // Затем формируется строка с фамилией, именем и отчеством, удаляемого сотрудника
            string mes = textBoxSurname.Text.ToString().Trim() + " " + textBoxName.Text.ToString().Trim() + " " + textBoxPatronymic.Text.ToString().Trim();
            DialogResult result = MessageBox.Show(" Удалить данные  \n по сотруднику \n" + mes + "?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            switch (result)
            {
                case DialogResult.Yes:
                {
                        //выполнить действия по удалению данных по сотруднику 
                    this.dsEmployee.Employee.Rows[pos].Delete();
                    if (this.dsEmployee.Employee.GetChanges(DataRowState.Deleted) != null)
                    {
                        try
                        {
                            this.daEmployee.Update(dsEmployee.Employee);
                            this.dsEmployee.Employee.AcceptChanges();
                        }
                        catch (Exception x)
                        {
                            string er = x.Message.ToString();
                            MessageBox.Show("Ошибка удаления записи в базе данных Employee " + er, "Предупреждение");
                            this.dsEmployee.Employee.RejectChanges();
                        }
                    }
                    break;
                }
                case DialogResult.No:
                {
                    //отмена удаления данных по сотруднику   
                    this.dsEmployee.Employee.RejectChanges();
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

        private void comboBoxJobRole_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Определяем позицию в таблице Employee
            int pos = -1;
            pos = this.BindingContext[dsEmployee,"Employee"].Position;
            // Изменение в таблице Employee поля JobRoleID при изменении 
            // выбора должности (comboBoxJobRole) 
            dsEmployee.Employee[pos].JobRoleID = 
                (short)((DataRowView)comboBoxJobRole.Items[comboBoxJobRole.SelectedIndex])["JobRoleID"];
        }

        private void comboBoxAccess_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int pos = -1;
            pos = this.BindingContext[dsEmployee, "Employee"].Position;
            dsEmployee.Employee[pos].Access = comboBoxAccess.SelectedItem.ToString();
        }

        private void comboBoxStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int pos = -1;
            pos = this.BindingContext[dsEmployee, "Employee"].Position;
            dsEmployee.Employee[pos].EmployeeStatus = comboBoxStatus.SelectedIndex;
        }
    }
}
