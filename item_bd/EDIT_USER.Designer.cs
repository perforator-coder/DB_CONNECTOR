namespace item_bd
{
    partial class EDIT_USER
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            login_BOX = new TextBox();
            pass_box = new TextBox();
            BT_save_user_data = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 75);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Логин:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 106);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Пароль:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(161, 133);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "Роль:";
            // 
            // login_BOX
            // 
            login_BOX.Location = new Point(205, 72);
            login_BOX.Name = "login_BOX";
            login_BOX.Size = new Size(100, 23);
            login_BOX.TabIndex = 3;
            login_BOX.TextChanged += login_BOX_TextChanged;
            // 
            // pass_box
            // 
            pass_box.Location = new Point(213, 106);
            pass_box.Name = "pass_box";
            pass_box.Size = new Size(100, 23);
            pass_box.TabIndex = 4;
            // 
            // BT_save_user_data
            // 
            BT_save_user_data.Location = new Point(205, 160);
            BT_save_user_data.Name = "BT_save_user_data";
            BT_save_user_data.Size = new Size(75, 23);
            BT_save_user_data.TabIndex = 6;
            BT_save_user_data.Text = "Сохранить";
            BT_save_user_data.UseVisualStyleBackColor = true;
            BT_save_user_data.Click += BT_save_user_data_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "User", "Неизвестно" });
            comboBox1.Location = new Point(204, 135);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            // 
            // EDIT_USER
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(BT_save_user_data);
            Controls.Add(pass_box);
            Controls.Add(login_BOX);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EDIT_USER";
            Text = "EDIT_USER";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox login_BOX;
        private TextBox pass_box;
        private Button BT_save_user_data;
        private ComboBox comboBox1;
    }
}