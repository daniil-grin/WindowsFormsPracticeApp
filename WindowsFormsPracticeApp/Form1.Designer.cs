namespace WindowsFormsPracticeApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.objectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.договорToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поручениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сделкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.странаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регионToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.городToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.иМНСToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.objectToolStripMenuItem,
            this.справочникToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(608, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // objectToolStripMenuItem
            // 
            this.objectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сотрудникToolStripMenuItem,
            this.клиентToolStripMenuItem,
            this.договорToolStripMenuItem,
            this.поручениеToolStripMenuItem,
            this.сделкаToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.objectToolStripMenuItem.Name = "objectToolStripMenuItem";
            this.objectToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.objectToolStripMenuItem.Text = "Объект";
            this.objectToolStripMenuItem.Click += new System.EventHandler(this.objectToolStripMenuItem_Click);
            // 
            // сотрудникToolStripMenuItem
            // 
            this.сотрудникToolStripMenuItem.Name = "сотрудникToolStripMenuItem";
            this.сотрудникToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.сотрудникToolStripMenuItem.Text = "Сотрудник";
            // 
            // клиентToolStripMenuItem
            // 
            this.клиентToolStripMenuItem.Name = "клиентToolStripMenuItem";
            this.клиентToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.клиентToolStripMenuItem.Text = "Клиент";
            // 
            // договорToolStripMenuItem
            // 
            this.договорToolStripMenuItem.Name = "договорToolStripMenuItem";
            this.договорToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.договорToolStripMenuItem.Text = "Договор";
            // 
            // поручениеToolStripMenuItem
            // 
            this.поручениеToolStripMenuItem.Name = "поручениеToolStripMenuItem";
            this.поручениеToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.поручениеToolStripMenuItem.Text = "Поручение";
            // 
            // сделкаToolStripMenuItem
            // 
            this.сделкаToolStripMenuItem.Name = "сделкаToolStripMenuItem";
            this.сделкаToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.сделкаToolStripMenuItem.Text = "Сделка";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // справочникToolStripMenuItem
            // 
            this.справочникToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.должностьToolStripMenuItem,
            this.странаToolStripMenuItem,
            this.регионToolStripMenuItem,
            this.городToolStripMenuItem,
            this.иМНСToolStripMenuItem});
            this.справочникToolStripMenuItem.Name = "справочникToolStripMenuItem";
            this.справочникToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.справочникToolStripMenuItem.Text = "Справочник";
            // 
            // должностьToolStripMenuItem
            // 
            this.должностьToolStripMenuItem.Name = "должностьToolStripMenuItem";
            this.должностьToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.должностьToolStripMenuItem.Text = "Должность";
            // 
            // странаToolStripMenuItem
            // 
            this.странаToolStripMenuItem.Name = "странаToolStripMenuItem";
            this.странаToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.странаToolStripMenuItem.Text = "Страна";
            // 
            // регионToolStripMenuItem
            // 
            this.регионToolStripMenuItem.Name = "регионToolStripMenuItem";
            this.регионToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.регионToolStripMenuItem.Text = "Регион";
            // 
            // городToolStripMenuItem
            // 
            this.городToolStripMenuItem.Name = "городToolStripMenuItem";
            this.городToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.городToolStripMenuItem.Text = "Город";
            // 
            // иМНСToolStripMenuItem
            // 
            this.иМНСToolStripMenuItem.Name = "иМНСToolStripMenuItem";
            this.иМНСToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.иМНСToolStripMenuItem.Text = "ИМНС";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.helpToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(521, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Выход";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Приветствие";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aqua;
            this.button2.Location = new System.Drawing.Point(12, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.changeColor);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.Location = new System.Drawing.Point(12, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "2";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.changeColor);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 249);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem objectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem договорToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поручениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сделкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem странаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регионToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem городToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem иМНСToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

