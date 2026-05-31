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
            label1 = new Label();
            USERS = new TabPage();
            Data_user = new DataGridView();
            User_selector = new ContextMenuStrip(components);
            вРАЗРАБОТКЕToolStripMenuItem = new ToolStripMenuItem();
            изменитьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьВсеToolStripMenuItem = new ToolStripMenuItem();
            создатьСтрокуToolStripMenuItem = new ToolStripMenuItem();
            tabControl1.SuspendLayout();
            DATA.SuspendLayout();
            USERS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Data_user).BeginInit();
            User_selector.SuspendLayout();
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
            DATA.Controls.Add(label1);
            DATA.Location = new Point(4, 24);
            DATA.Name = "DATA";
            DATA.Padding = new Padding(3);
            DATA.Size = new Size(795, 425);
            DATA.TabIndex = 1;
            DATA.Text = "DATA_DB";
            DATA.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(78, 184);
            label1.Name = "label1";
            label1.Size = new Size(634, 65);
            label1.TabIndex = 0;
            label1.Text = "UNDER RECONSTRUCTION";
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
            User_selector.Items.AddRange(new ToolStripItem[] { вРАЗРАБОТКЕToolStripMenuItem, изменитьToolStripMenuItem, сохранитьВсеToolStripMenuItem, создатьСтрокуToolStripMenuItem });
            User_selector.Name = "User_selector";
            User_selector.Size = new Size(161, 92);
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
            DATA.PerformLayout();
            USERS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Data_user).EndInit();
            User_selector.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage USERS;
        private DataGridView Data_user;
        private TabPage DATA;
        private Label label1;
        private ContextMenuStrip User_selector;
        private ToolStripMenuItem вРАЗРАБОТКЕToolStripMenuItem;
        private ToolStripMenuItem изменитьToolStripMenuItem;
        private ToolStripMenuItem сохранитьВсеToolStripMenuItem;
        private ToolStripMenuItem создатьСтрокуToolStripMenuItem;
    }
}