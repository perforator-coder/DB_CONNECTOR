namespace item_bd
{
    partial class MAIN_FORM_DB
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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            DATA = new TabPage();
            DATA_DB_tabl = new DataGridView();
            USERS = new TabPage();
            Data_user = new DataGridView();
            User_selector = new ContextMenuStrip(components);
            вРАЗРАБОТКЕToolStripMenuItem = new ToolStripMenuItem();
            изменитьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьВсеToolStripMenuItem = new ToolStripMenuItem();
            создатьСтрокуToolStripMenuItem = new ToolStripMenuItem();
            удалитьСтрокуToolStripMenuItem = new ToolStripMenuItem();
            DATA_ITEM_SELECTOR = new ContextMenuStrip(components);
            сохранитьВсеToolStripMenuItem1 = new ToolStripMenuItem();
            изменитьСтрокуToolStripMenuItem = new ToolStripMenuItem();
            добавитьНовуюСтрокуToolStripMenuItem = new ToolStripMenuItem();
            удалитьСтрокуToolStripMenuItem1 = new ToolStripMenuItem();
            tabControl1.SuspendLayout();
            DATA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DATA_DB_tabl).BeginInit();
            USERS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Data_user).BeginInit();
            User_selector.SuspendLayout();
            DATA_ITEM_SELECTOR.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(DATA);
            tabControl1.Controls.Add(USERS);
            tabControl1.Location = new Point(-2, -2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(803, 453);
            tabControl1.TabIndex = 0;
            // 
            // DATA
            // 
            DATA.Controls.Add(DATA_DB_tabl);
            DATA.Location = new Point(4, 24);
            DATA.Name = "DATA";
            DATA.Padding = new Padding(3);
            DATA.Size = new Size(795, 425);
            DATA.TabIndex = 1;
            DATA.Text = "DATA_DB";
            DATA.UseVisualStyleBackColor = true;
            // 
            // DATA_DB_tabl
            // 
            DATA_DB_tabl.AllowUserToAddRows = false;
            DATA_DB_tabl.AllowUserToDeleteRows = false;
            DATA_DB_tabl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DATA_DB_tabl.Dock = DockStyle.Fill;
            DATA_DB_tabl.Location = new Point(3, 3);
            DATA_DB_tabl.Name = "DATA_DB_tabl";
            DATA_DB_tabl.Size = new Size(789, 419);
            DATA_DB_tabl.TabIndex = 0;
            DATA_DB_tabl.CellMouseDown += DATA_DB_tabl_CellMouseDown;
            DATA_DB_tabl.MouseDown += DATA_DB_tabl_MouseDown;
            // 
            // USERS
            // 
            USERS.Controls.Add(Data_user);
            USERS.Location = new Point(4, 24);
            USERS.Name = "USERS";
            USERS.Padding = new Padding(3);
            USERS.Size = new Size(795, 425);
            USERS.TabIndex = 0;
            USERS.Text = "User_DB";
            USERS.UseVisualStyleBackColor = true;
            // 
            // Data_user
            // 
            Data_user.AllowUserToAddRows = false;
            Data_user.AllowUserToDeleteRows = false;
            Data_user.AllowUserToOrderColumns = true;
            Data_user.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Data_user.Dock = DockStyle.Fill;
            Data_user.Location = new Point(3, 3);
            Data_user.Name = "Data_user";
            Data_user.Size = new Size(789, 419);
            Data_user.TabIndex = 0;
            Data_user.CellContentClick += dataGridView1_CellContentClick;
            Data_user.CellMouseDown += Data_user_CellMouseDown;
            Data_user.MouseDown += Data_user_MouseDown;
            // 
            // User_selector
            // 
            User_selector.Items.AddRange(new ToolStripItem[] { вРАЗРАБОТКЕToolStripMenuItem, изменитьToolStripMenuItem, сохранитьВсеToolStripMenuItem, создатьСтрокуToolStripMenuItem, удалитьСтрокуToolStripMenuItem });
            User_selector.Name = "User_selector";
            User_selector.Size = new Size(161, 114);
            // 
            // вРАЗРАБОТКЕToolStripMenuItem
            // 
            вРАЗРАБОТКЕToolStripMenuItem.Name = "вРАЗРАБОТКЕToolStripMenuItem";
            вРАЗРАБОТКЕToolStripMenuItem.Size = new Size(160, 22);
            вРАЗРАБОТКЕToolStripMenuItem.Text = "В РАЗРАБОТКЕ!";
            // 
            // изменитьToolStripMenuItem
            // 
            изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            изменитьToolStripMenuItem.Size = new Size(160, 22);
            изменитьToolStripMenuItem.Text = "Изменить";
            изменитьToolStripMenuItem.Click += изменитьToolStripMenuItem_Click;
            // 
            // сохранитьВсеToolStripMenuItem
            // 
            сохранитьВсеToolStripMenuItem.Name = "сохранитьВсеToolStripMenuItem";
            сохранитьВсеToolStripMenuItem.Size = new Size(160, 22);
            сохранитьВсеToolStripMenuItem.Text = "Сохранить все";
            сохранитьВсеToolStripMenuItem.Click += сохранитьВсеToolStripMenuItem_Click;
            // 
            // создатьСтрокуToolStripMenuItem
            // 
            создатьСтрокуToolStripMenuItem.Name = "создатьСтрокуToolStripMenuItem";
            создатьСтрокуToolStripMenuItem.Size = new Size(160, 22);
            создатьСтрокуToolStripMenuItem.Text = "Создать строку";
            создатьСтрокуToolStripMenuItem.Click += создатьСтрокуToolStripMenuItem_Click;
            // 
            // удалитьСтрокуToolStripMenuItem
            // 
            удалитьСтрокуToolStripMenuItem.Name = "удалитьСтрокуToolStripMenuItem";
            удалитьСтрокуToolStripMenuItem.Size = new Size(160, 22);
            удалитьСтрокуToolStripMenuItem.Text = "Удалить строку";
            удалитьСтрокуToolStripMenuItem.Click += удалитьСтрокуToolStripMenuItem_Click;
            // 
            // DATA_ITEM_SELECTOR
            // 
            DATA_ITEM_SELECTOR.Items.AddRange(new ToolStripItem[] { сохранитьВсеToolStripMenuItem1, изменитьСтрокуToolStripMenuItem, добавитьНовуюСтрокуToolStripMenuItem, удалитьСтрокуToolStripMenuItem1 });
            DATA_ITEM_SELECTOR.Name = "DATA_ITEM_SELECTOR";
            DATA_ITEM_SELECTOR.Size = new Size(206, 114);
            // 
            // сохранитьВсеToolStripMenuItem1
            // 
            сохранитьВсеToolStripMenuItem1.Name = "сохранитьВсеToolStripMenuItem1";
            сохранитьВсеToolStripMenuItem1.Size = new Size(205, 22);
            сохранитьВсеToolStripMenuItem1.Text = "Сохранить все";
            // 
            // изменитьСтрокуToolStripMenuItem
            // 
            изменитьСтрокуToolStripMenuItem.Name = "изменитьСтрокуToolStripMenuItem";
            изменитьСтрокуToolStripMenuItem.Size = new Size(205, 22);
            изменитьСтрокуToolStripMenuItem.Text = "Изменить строку";
            изменитьСтрокуToolStripMenuItem.Click += изменитьСтрокуToolStripMenuItem_Click;
            // 
            // добавитьНовуюСтрокуToolStripMenuItem
            // 
            добавитьНовуюСтрокуToolStripMenuItem.Name = "добавитьНовуюСтрокуToolStripMenuItem";
            добавитьНовуюСтрокуToolStripMenuItem.Size = new Size(205, 22);
            добавитьНовуюСтрокуToolStripMenuItem.Text = "Добавить новую строку";
            добавитьНовуюСтрокуToolStripMenuItem.Click += добавитьНовуюСтрокуToolStripMenuItem_Click;
            // 
            // удалитьСтрокуToolStripMenuItem1
            // 
            удалитьСтрокуToolStripMenuItem1.Name = "удалитьСтрокуToolStripMenuItem1";
            удалитьСтрокуToolStripMenuItem1.Size = new Size(205, 22);
            удалитьСтрокуToolStripMenuItem1.Text = "Удалить строку";
            // 
            // MAIN_FORM_DB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "MAIN_FORM_DB";
            Text = "MAIN_FORM_DB";
            Load += MAIN_FORM_DB_Load;
            tabControl1.ResumeLayout(false);
            DATA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DATA_DB_tabl).EndInit();
            USERS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Data_user).EndInit();
            User_selector.ResumeLayout(false);
            DATA_ITEM_SELECTOR.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage USERS;
        private DataGridView Data_user;
        private TabPage DATA;
        private ContextMenuStrip User_selector;
        private ToolStripMenuItem вРАЗРАБОТКЕToolStripMenuItem;
        private ToolStripMenuItem изменитьToolStripMenuItem;
        private ToolStripMenuItem сохранитьВсеToolStripMenuItem;
        private ToolStripMenuItem создатьСтрокуToolStripMenuItem;
        private ToolStripMenuItem удалитьСтрокуToolStripMenuItem;
        private DataGridView DATA_DB_tabl;
        private ContextMenuStrip DATA_ITEM_SELECTOR;
        private ToolStripMenuItem сохранитьВсеToolStripMenuItem1;
        private ToolStripMenuItem изменитьСтрокуToolStripMenuItem;
        private ToolStripMenuItem добавитьНовуюСтрокуToolStripMenuItem;
        private ToolStripMenuItem удалитьСтрокуToolStripMenuItem1;
    }
}