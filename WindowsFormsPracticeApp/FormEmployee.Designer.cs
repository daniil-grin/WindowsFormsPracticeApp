namespace WindowsFormsPracticeApp
{
    partial class FormEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployee));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonUndo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRemove = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripEmployee = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelEmployee = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBoxEmployee = new System.Windows.Forms.ListBox();
            this.labelListEmployee = new System.Windows.Forms.Label();
            this.textBoxAccess = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.textBoxJobRole = new System.Windows.Forms.TextBox();
            this.dateTimePickerFirstDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.labelFirstDate = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.comboBoxAccess = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxJobRole = new System.Windows.Forms.ComboBox();
            this.textBoxNetName = new System.Windows.Forms.TextBox();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelNetName = new System.Windows.Forms.Label();
            this.labelAccess = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelJobRole = new System.Windows.Forms.Label();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxBirthday = new System.Windows.Forms.TextBox();
            this.textBoxFirstDate = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStripEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(712, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.toolStripSeparator4,
            this.createToolStripMenuItem,
            this.editToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.removeToolStripMenuItem});
            this.actionToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.actionToolStripMenuItem.MergeIndex = 1;
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.actionToolStripMenuItem.Text = "Действие";
            this.actionToolStripMenuItem.MouseEnter += new System.EventHandler(this.actionToolStripMenuItem_MouseEnter);
            this.actionToolStripMenuItem.MouseLeave += new System.EventHandler(this.allToolStripMenuItem_MouseLeave);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.undoToolStripMenuItem.Text = "Отменить";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            this.undoToolStripMenuItem.MouseEnter += new System.EventHandler(this.undoToolStripMenuItem_MouseEnter);
            this.undoToolStripMenuItem.MouseLeave += new System.EventHandler(this.allToolStripMenuItem_MouseLeave);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(151, 6);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.createToolStripMenuItem.Text = "Создать";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            this.createToolStripMenuItem.MouseEnter += new System.EventHandler(this.createToolStripMenuItem_MouseEnter);
            this.createToolStripMenuItem.MouseLeave += new System.EventHandler(this.allToolStripMenuItem_MouseLeave);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editToolStripMenuItem.Text = "Редактировать";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            this.editToolStripMenuItem.MouseEnter += new System.EventHandler(this.editToolStripMenuItem_MouseEnter);
            this.editToolStripMenuItem.MouseLeave += new System.EventHandler(this.allToolStripMenuItem_MouseLeave);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            this.saveToolStripMenuItem.MouseEnter += new System.EventHandler(this.saveToolStripMenuItem_MouseEnter);
            this.saveToolStripMenuItem.MouseLeave += new System.EventHandler(this.allToolStripMenuItem_MouseLeave);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.removeToolStripMenuItem.Text = "Удалить";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            this.removeToolStripMenuItem.MouseEnter += new System.EventHandler(this.removeToolStripMenuItem_MouseEnter);
            this.removeToolStripMenuItem.MouseLeave += new System.EventHandler(this.allToolStripMenuItem_MouseLeave);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportToolStripMenuItem1,
            this.reportToolStripMenuItem2});
            this.reportToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.reportToolStripMenuItem.MergeIndex = 2;
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.reportToolStripMenuItem.Text = "Отчет";
            // 
            // reportToolStripMenuItem1
            // 
            this.reportToolStripMenuItem1.Name = "reportToolStripMenuItem1";
            this.reportToolStripMenuItem1.Size = new System.Drawing.Size(195, 22);
            this.reportToolStripMenuItem1.Text = "По сотруднику";
            this.reportToolStripMenuItem1.MouseEnter += new System.EventHandler(this.reportToolStripMenuItem1_MouseEnter);
            this.reportToolStripMenuItem1.MouseLeave += new System.EventHandler(this.allToolStripMenuItem_MouseLeave);
            // 
            // reportToolStripMenuItem2
            // 
            this.reportToolStripMenuItem2.Name = "reportToolStripMenuItem2";
            this.reportToolStripMenuItem2.Size = new System.Drawing.Size(195, 22);
            this.reportToolStripMenuItem2.Text = "По всем сотрудникам";
            this.reportToolStripMenuItem2.MouseEnter += new System.EventHandler(this.reportToolStripMenuItem2_MouseEnter);
            this.reportToolStripMenuItem2.MouseLeave += new System.EventHandler(this.allToolStripMenuItem_MouseLeave);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonUndo,
            this.toolStripButtonNew,
            this.toolStripButtonEdit,
            this.toolStripButtonSave,
            this.toolStripButtonRemove});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(791, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonUndo
            // 
            this.toolStripButtonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUndo.Image")));
            this.toolStripButtonUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUndo.Name = "toolStripButtonUndo";
            this.toolStripButtonUndo.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonUndo.Text = "toolStripButton1";
            this.toolStripButtonUndo.ToolTipText = "Отменить";
            this.toolStripButtonUndo.Click += new System.EventHandler(this.toolStripButtonUndo_Click);
            // 
            // toolStripButtonNew
            // 
            this.toolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNew.Image")));
            this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNew.Name = "toolStripButtonNew";
            this.toolStripButtonNew.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNew.Text = "toolStripButton2";
            this.toolStripButtonNew.ToolTipText = "Создать";
            this.toolStripButtonNew.Click += new System.EventHandler(this.toolStripButtonNew_Click);
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEdit.Image")));
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEdit.Text = "toolStripButton1";
            this.toolStripButtonEdit.ToolTipText = "Редактировать";
            this.toolStripButtonEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSave.Text = "toolStripButton1";
            this.toolStripButtonSave.ToolTipText = "Сохранить";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripButtonRemove
            // 
            this.toolStripButtonRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRemove.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRemove.Image")));
            this.toolStripButtonRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemove.Name = "toolStripButtonRemove";
            this.toolStripButtonRemove.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRemove.Text = "toolStripButton1";
            this.toolStripButtonRemove.ToolTipText = "Удалить";
            this.toolStripButtonRemove.Click += new System.EventHandler(this.toolStripButtonRemove_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuUndo,
            this.toolStripSeparator2,
            this.toolStripMenuNew,
            this.toolStripMenuEdit,
            this.toolStripMenuSave,
            this.toolStripSeparator3,
            this.toolStripMenuRemove});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 126);
            // 
            // toolStripMenuUndo
            // 
            this.toolStripMenuUndo.Name = "toolStripMenuUndo";
            this.toolStripMenuUndo.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuUndo.Text = "Отменить";
            this.toolStripMenuUndo.Click += new System.EventHandler(this.toolStripMenuUndo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(151, 6);
            // 
            // toolStripMenuNew
            // 
            this.toolStripMenuNew.Name = "toolStripMenuNew";
            this.toolStripMenuNew.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuNew.Text = "Создать";
            this.toolStripMenuNew.Click += new System.EventHandler(this.toolStripMenuNew_Click);
            // 
            // toolStripMenuEdit
            // 
            this.toolStripMenuEdit.Name = "toolStripMenuEdit";
            this.toolStripMenuEdit.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuEdit.Text = "Редактировать";
            this.toolStripMenuEdit.Click += new System.EventHandler(this.toolStripMenuEdit_Click);
            // 
            // toolStripMenuSave
            // 
            this.toolStripMenuSave.Name = "toolStripMenuSave";
            this.toolStripMenuSave.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuSave.Text = "Сохранить";
            this.toolStripMenuSave.Click += new System.EventHandler(this.toolStripMenuSave_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(151, 6);
            // 
            // toolStripMenuRemove
            // 
            this.toolStripMenuRemove.Name = "toolStripMenuRemove";
            this.toolStripMenuRemove.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuRemove.Text = "Удалить";
            this.toolStripMenuRemove.Click += new System.EventHandler(this.toolStripMenuRemove_Click);
            // 
            // statusStripEmployee
            // 
            this.statusStripEmployee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelEmployee});
            this.statusStripEmployee.Location = new System.Drawing.Point(0, 449);
            this.statusStripEmployee.Name = "statusStripEmployee";
            this.statusStripEmployee.Size = new System.Drawing.Size(791, 22);
            this.statusStripEmployee.TabIndex = 0;
            this.statusStripEmployee.Text = "statusStrip1";
            // 
            // toolStripStatusLabelEmployee
            // 
            this.toolStripStatusLabelEmployee.Name = "toolStripStatusLabelEmployee";
            this.toolStripStatusLabelEmployee.Size = new System.Drawing.Size(0, 17);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBoxEmployee);
            this.splitContainer1.Panel1.Controls.Add(this.labelListEmployee);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxFirstDate);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxBirthday);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxAccess);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxStatus);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxJobRole);
            this.splitContainer1.Panel2.Controls.Add(this.dateTimePickerFirstDate);
            this.splitContainer1.Panel2.Controls.Add(this.dateTimePickerBirthday);
            this.splitContainer1.Panel2.Controls.Add(this.labelFirstDate);
            this.splitContainer1.Panel2.Controls.Add(this.labelBirthday);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxAccess);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxStatus);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxJobRole);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxNetName);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxPatronymic);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxName);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxSurname);
            this.splitContainer1.Panel2.Controls.Add(this.labelNetName);
            this.splitContainer1.Panel2.Controls.Add(this.labelAccess);
            this.splitContainer1.Panel2.Controls.Add(this.labelStatus);
            this.splitContainer1.Panel2.Controls.Add(this.labelJobRole);
            this.splitContainer1.Panel2.Controls.Add(this.labelPatronymic);
            this.splitContainer1.Panel2.Controls.Add(this.labelName);
            this.splitContainer1.Panel2.Controls.Add(this.labelSurname);
            this.splitContainer1.Size = new System.Drawing.Size(791, 424);
            this.splitContainer1.SplitterDistance = 329;
            this.splitContainer1.TabIndex = 2;
            // 
            // listBoxEmployee
            // 
            this.listBoxEmployee.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEmployee.FormattingEnabled = true;
            this.listBoxEmployee.ItemHeight = 16;
            this.listBoxEmployee.Location = new System.Drawing.Point(12, 44);
            this.listBoxEmployee.Name = "listBoxEmployee";
            this.listBoxEmployee.Size = new System.Drawing.Size(300, 356);
            this.listBoxEmployee.TabIndex = 0;
            // 
            // labelListEmployee
            // 
            this.labelListEmployee.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.labelListEmployee.AutoSize = true;
            this.labelListEmployee.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListEmployee.Location = new System.Drawing.Point(47, 13);
            this.labelListEmployee.Name = "labelListEmployee";
            this.labelListEmployee.Size = new System.Drawing.Size(154, 17);
            this.labelListEmployee.TabIndex = 1;
            this.labelListEmployee.Text = "Список сотрудников";
            // 
            // textBoxAccess
            // 
            this.textBoxAccess.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAccess.Location = new System.Drawing.Point(183, 230);
            this.textBoxAccess.Name = "textBoxAccess";
            this.textBoxAccess.Size = new System.Drawing.Size(256, 26);
            this.textBoxAccess.TabIndex = 13;
            this.textBoxAccess.Click += new System.EventHandler(this.textBoxAccess_Click);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStatus.Location = new System.Drawing.Point(183, 190);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(256, 26);
            this.textBoxStatus.TabIndex = 12;
            this.textBoxStatus.Click += new System.EventHandler(this.textBoxStatus_Click);
            // 
            // textBoxJobRole
            // 
            this.textBoxJobRole.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJobRole.Location = new System.Drawing.Point(183, 150);
            this.textBoxJobRole.Name = "textBoxJobRole";
            this.textBoxJobRole.Size = new System.Drawing.Size(256, 26);
            this.textBoxJobRole.TabIndex = 11;
            this.textBoxJobRole.Click += new System.EventHandler(this.textBoxJobRole_Click);
            // 
            // dateTimePickerFirstDate
            // 
            this.dateTimePickerFirstDate.CalendarFont = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFirstDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFirstDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFirstDate.Location = new System.Drawing.Point(183, 355);
            this.dateTimePickerFirstDate.Name = "dateTimePickerFirstDate";
            this.dateTimePickerFirstDate.Size = new System.Drawing.Size(256, 27);
            this.dateTimePickerFirstDate.TabIndex = 10;
            this.dateTimePickerFirstDate.ValueChanged += new System.EventHandler(this.dateTimePickerFirstDate_ValueChanged);
            this.dateTimePickerFirstDate.Leave += new System.EventHandler(this.dateTimePickerFirstDate_Leave);
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBirthday.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(183, 310);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(256, 27);
            this.dateTimePickerBirthday.TabIndex = 9;
            this.dateTimePickerBirthday.ValueChanged += new System.EventHandler(this.dateTimePickerBirthday_ValueChanged);
            this.dateTimePickerBirthday.Leave += new System.EventHandler(this.dateTimePickerBirthday_Leave);
            // 
            // labelFirstDate
            // 
            this.labelFirstDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstDate.Location = new System.Drawing.Point(20, 350);
            this.labelFirstDate.Name = "labelFirstDate";
            this.labelFirstDate.Size = new System.Drawing.Size(148, 40);
            this.labelFirstDate.TabIndex = 8;
            this.labelFirstDate.Text = "Дата приема на работу";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthday.Location = new System.Drawing.Point(20, 314);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(122, 19);
            this.labelBirthday.TabIndex = 7;
            this.labelBirthday.Text = "Дата рождения";
            // 
            // comboBoxAccess
            // 
            this.comboBoxAccess.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAccess.FormattingEnabled = true;
            this.comboBoxAccess.Location = new System.Drawing.Point(183, 230);
            this.comboBoxAccess.Name = "comboBoxAccess";
            this.comboBoxAccess.Size = new System.Drawing.Size(256, 26);
            this.comboBoxAccess.TabIndex = 5;
            this.comboBoxAccess.SelectedIndexChanged += new System.EventHandler(this.comboBoxAccess_SelectedIndexChanged);
            this.comboBoxAccess.SelectionChangeCommitted += new System.EventHandler(this.comboBoxAccess_SelectionChangeCommitted);
            this.comboBoxAccess.Leave += new System.EventHandler(this.comboBoxAccess_Leave);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Активен",
            "Выходной",
            "В отпуске",
            "Болеет",
            "Не работает",
            "Помечен как удаленный"});
            this.comboBoxStatus.Location = new System.Drawing.Point(183, 190);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(256, 26);
            this.comboBoxStatus.TabIndex = 4;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            this.comboBoxStatus.SelectionChangeCommitted += new System.EventHandler(this.comboBoxStatus_SelectionChangeCommitted);
            this.comboBoxStatus.Leave += new System.EventHandler(this.comboBoxStatus_Leave);
            // 
            // comboBoxJobRole
            // 
            this.comboBoxJobRole.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxJobRole.FormattingEnabled = true;
            this.comboBoxJobRole.Location = new System.Drawing.Point(183, 150);
            this.comboBoxJobRole.Name = "comboBoxJobRole";
            this.comboBoxJobRole.Size = new System.Drawing.Size(256, 26);
            this.comboBoxJobRole.TabIndex = 3;
            this.comboBoxJobRole.SelectedIndexChanged += new System.EventHandler(this.comboBoxJobRole_SelectedIndexChanged);
            this.comboBoxJobRole.SelectionChangeCommitted += new System.EventHandler(this.comboBoxJobRole_SelectionChangeCommitted);
            this.comboBoxJobRole.Leave += new System.EventHandler(this.comboBoxJobRole_Leave);
            // 
            // textBoxNetName
            // 
            this.textBoxNetName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNetName.Location = new System.Drawing.Point(183, 270);
            this.textBoxNetName.Name = "textBoxNetName";
            this.textBoxNetName.Size = new System.Drawing.Size(256, 26);
            this.textBoxNetName.TabIndex = 6;
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPatronymic.Location = new System.Drawing.Point(183, 110);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(256, 26);
            this.textBoxPatronymic.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(183, 70);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(256, 26);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSurname.Location = new System.Drawing.Point(183, 30);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(256, 26);
            this.textBoxSurname.TabIndex = 0;
            // 
            // labelNetName
            // 
            this.labelNetName.AutoSize = true;
            this.labelNetName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNetName.Location = new System.Drawing.Point(20, 271);
            this.labelNetName.Name = "labelNetName";
            this.labelNetName.Size = new System.Drawing.Size(100, 19);
            this.labelNetName.TabIndex = 6;
            this.labelNetName.Text = "Сетевое имя\t";
            // 
            // labelAccess
            // 
            this.labelAccess.AutoSize = true;
            this.labelAccess.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccess.Location = new System.Drawing.Point(20, 231);
            this.labelAccess.Name = "labelAccess";
            this.labelAccess.Size = new System.Drawing.Size(132, 19);
            this.labelAccess.TabIndex = 5;
            this.labelAccess.Text = "Уровень доступа";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(20, 191);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(58, 19);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "Статус";
            // 
            // labelJobRole
            // 
            this.labelJobRole.AutoSize = true;
            this.labelJobRole.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJobRole.Location = new System.Drawing.Point(20, 151);
            this.labelJobRole.Name = "labelJobRole";
            this.labelJobRole.Size = new System.Drawing.Size(91, 19);
            this.labelJobRole.TabIndex = 3;
            this.labelJobRole.Text = "Должность";
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatronymic.Location = new System.Drawing.Point(20, 111);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(78, 19);
            this.labelPatronymic.TabIndex = 2;
            this.labelPatronymic.Text = "Отчество";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(20, 71);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 19);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Имя";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurname.Location = new System.Drawing.Point(20, 31);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(74, 19);
            this.labelSurname.TabIndex = 0;
            this.labelSurname.Text = "Фамилия";
            // 
            // textBoxBirthday
            // 
            this.textBoxBirthday.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBirthday.Location = new System.Drawing.Point(183, 310);
            this.textBoxBirthday.Name = "textBoxBirthday";
            this.textBoxBirthday.Size = new System.Drawing.Size(256, 27);
            this.textBoxBirthday.TabIndex = 14;
            this.textBoxBirthday.Click += new System.EventHandler(this.textBoxBirthday_Click);
            // 
            // textBoxFirstDate
            // 
            this.textBoxFirstDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstDate.Location = new System.Drawing.Point(183, 355);
            this.textBoxFirstDate.Name = "textBoxFirstDate";
            this.textBoxFirstDate.Size = new System.Drawing.Size(256, 27);
            this.textBoxFirstDate.TabIndex = 15;
            this.textBoxFirstDate.Click += new System.EventHandler(this.textBoxFirstDate_Click);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 471);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStripEmployee);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(730, 510);
            this.Name = "FormEmployee";
            this.Text = "Данные по сотрудникам";
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStripEmployee.ResumeLayout(false);
            this.statusStripEmployee.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonUndo;
        private System.Windows.Forms.ToolStripButton toolStripButtonNew;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemove;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuUndo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuNew;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuRemove;
        private System.Windows.Forms.StatusStrip statusStripEmployee;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelEmployee;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBoxEmployee;
        private System.Windows.Forms.Label labelListEmployee;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelJobRole;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelNetName;
        private System.Windows.Forms.Label labelAccess;
        private System.Windows.Forms.ComboBox comboBoxAccess;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxJobRole;
        private System.Windows.Forms.TextBox textBoxNetName;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelFirstDate;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.DateTimePicker dateTimePickerFirstDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.TextBox textBoxJobRole;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.TextBox textBoxAccess;
        private System.Windows.Forms.TextBox textBoxFirstDate;
        private System.Windows.Forms.TextBox textBoxBirthday;
    }
}