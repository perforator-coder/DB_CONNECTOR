namespace item_bd
{
    partial class DATA_EDIT_item
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
            label4 = new Label();
            SAVE_ITEM_BT = new Button();
            ITEM_NAME_BOX = new TextBox();
            ITEM_ID_BOX = new TextBox();
            count_item_box = new TextBox();
            STATUS_ITEM_BOX = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(203, 164);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Артикул";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(170, 139);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 1;
            label2.Text = "Имя предмета";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(184, 190);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "Количество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(213, 217);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "Статус";
            // 
            // SAVE_ITEM_BT
            // 
            SAVE_ITEM_BT.Location = new Point(256, 247);
            SAVE_ITEM_BT.Name = "SAVE_ITEM_BT";
            SAVE_ITEM_BT.Size = new Size(75, 23);
            SAVE_ITEM_BT.TabIndex = 4;
            SAVE_ITEM_BT.Text = "Сохранить";
            SAVE_ITEM_BT.UseVisualStyleBackColor = true;
            SAVE_ITEM_BT.Click += SAVE_ITEM_BT_Click;
            // 
            // ITEM_NAME_BOX
            // 
            ITEM_NAME_BOX.Location = new Point(262, 139);
            ITEM_NAME_BOX.Name = "ITEM_NAME_BOX";
            ITEM_NAME_BOX.Size = new Size(100, 23);
            ITEM_NAME_BOX.TabIndex = 5;
            // 
            // ITEM_ID_BOX
            // 
            ITEM_ID_BOX.Location = new Point(256, 164);
            ITEM_ID_BOX.Name = "ITEM_ID_BOX";
            ITEM_ID_BOX.Size = new Size(100, 23);
            ITEM_ID_BOX.TabIndex = 6;
            // 
            // count_item_box
            // 
            count_item_box.Location = new Point(256, 193);
            count_item_box.Name = "count_item_box";
            count_item_box.Size = new Size(100, 23);
            count_item_box.TabIndex = 7;
            // 
            // STATUS_ITEM_BOX
            // 
            STATUS_ITEM_BOX.Location = new Point(262, 222);
            STATUS_ITEM_BOX.Name = "STATUS_ITEM_BOX";
            STATUS_ITEM_BOX.Size = new Size(100, 23);
            STATUS_ITEM_BOX.TabIndex = 8;
            // 
            // DATA_EDIT_item
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 371);
            Controls.Add(STATUS_ITEM_BOX);
            Controls.Add(count_item_box);
            Controls.Add(ITEM_ID_BOX);
            Controls.Add(ITEM_NAME_BOX);
            Controls.Add(SAVE_ITEM_BT);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DATA_EDIT_item";
            Text = "DATA_EDIT_item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button SAVE_ITEM_BT;
        private TextBox ITEM_NAME_BOX;
        private TextBox ITEM_ID_BOX;
        private TextBox count_item_box;
        private TextBox STATUS_ITEM_BOX;
    }
}