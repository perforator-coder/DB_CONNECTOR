namespace item_bd
{
    partial class Setings
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
            IP_box = new TextBox();
            PORT_box = new TextBox();
            save_BT = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 18);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "IP:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "PORT:";
            // 
            // IP_box
            // 
            IP_box.Location = new Point(57, 15);
            IP_box.Name = "IP_box";
            IP_box.Size = new Size(100, 23);
            IP_box.TabIndex = 2;
            // 
            // PORT_box
            // 
            PORT_box.Location = new Point(57, 47);
            PORT_box.Name = "PORT_box";
            PORT_box.Size = new Size(100, 23);
            PORT_box.TabIndex = 3;
            // 
            // save_BT
            // 
            save_BT.Location = new Point(47, 101);
            save_BT.Name = "save_BT";
            save_BT.Size = new Size(75, 23);
            save_BT.TabIndex = 4;
            save_BT.Text = "Сохранить";
            save_BT.UseVisualStyleBackColor = true;
            save_BT.Click += save_BT_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(47, 76);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(82, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Localhost?";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Setings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(174, 130);
            ControlBox = false;
            Controls.Add(checkBox1);
            Controls.Add(save_BT);
            Controls.Add(PORT_box);
            Controls.Add(IP_box);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Setings";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Setings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox IP_box;
        private TextBox PORT_box;
        private Button save_BT;
        private CheckBox checkBox1;
    }
}