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
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStripEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
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
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.undoToolStripMenuItem.Text = "Отменить";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            this.undoToolStripMenuItem.MouseEnter += new System.EventHandler(this.undoToolStripMenuItem_MouseEnter);
            this.undoToolStripMenuItem.MouseLeave += new System.EventHandler(this.allToolStripMenuItem_MouseLeave);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createToolStripMenuItem.Text = "Создать";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            this.createToolStripMenuItem.MouseEnter += new System.EventHandler(this.createToolStripMenuItem_MouseEnter);
            this.createToolStripMenuItem.MouseLeave += new System.EventHandler(this.allToolStripMenuItem_MouseLeave);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Редактировать";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            this.editToolStripMenuItem.MouseEnter += new System.EventHandler(this.editToolStripMenuItem_MouseEnter);
            this.editToolStripMenuItem.MouseLeave += new System.EventHandler(this.allToolStripMenuItem_MouseLeave);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            this.saveToolStripMenuItem.MouseEnter += new System.EventHandler(this.saveToolStripMenuItem_MouseEnter);
            this.saveToolStripMenuItem.MouseLeave += new System.EventHandler(this.allToolStripMenuItem_MouseLeave);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(884, 25);
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
            this.statusStripEmployee.Location = new System.Drawing.Point(0, 218);
            this.statusStripEmployee.Name = "statusStripEmployee";
            this.statusStripEmployee.Size = new System.Drawing.Size(884, 22);
            this.statusStripEmployee.TabIndex = 2;
            this.statusStripEmployee.Text = "statusStrip1";
            // 
            // toolStripStatusLabelEmployee
            // 
            this.toolStripStatusLabelEmployee.Name = "toolStripStatusLabelEmployee";
            this.toolStripStatusLabelEmployee.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 240);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.statusStripEmployee);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormEmployee";
            this.Text = "Данные по сотрудникам";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStripEmployee.ResumeLayout(false);
            this.statusStripEmployee.PerformLayout();
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
    }
}