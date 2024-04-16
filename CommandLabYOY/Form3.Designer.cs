namespace CommandLabYOY
{
    partial class Form3
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
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlLight;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 50F);
            label1.Location = new Point(606, 9);
            label1.Name = "label1";
            label1.Size = new Size(273, 109);
            label1.TabIndex = 0;
            label1.Text = "Оплата";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(542, 169);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(425, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ControlLight;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(542, 139);
            label2.Name = "label2";
            label2.Size = new Size(267, 27);
            label2.TabIndex = 6;
            label2.Text = "Адрес электронной почты";
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ControlLight;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(542, 227);
            label3.Name = "label3";
            label3.Size = new Size(117, 27);
            label3.TabIndex = 7;
            label3.Text = "Номер карты";
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ControlLight;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(542, 283);
            label4.Name = "label4";
            label4.Size = new Size(125, 27);
            label4.TabIndex = 8;
            label4.Text = "Действителен до";
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ControlLight;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(710, 283);
            label5.Name = "label5";
            label5.Size = new Size(64, 27);
            label5.TabIndex = 9;
            label5.Text = "CVC";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(542, 313);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 23);
            maskedTextBox1.TabIndex = 10;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(542, 257);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(284, 23);
            maskedTextBox2.TabIndex = 11;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(710, 313);
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.PasswordChar = '*';
            maskedTextBox3.Size = new Size(64, 23);
            maskedTextBox3.TabIndex = 12;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 15F);
            button2.Location = new Point(12, 9);
            button2.Name = "button2";
            button2.Size = new Size(206, 77);
            button2.TabIndex = 14;
            button2.Text = "Вернуться в корзину";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 255, 128);
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 15F);
            button3.Location = new Point(574, 474);
            button3.Name = "button3";
            button3.Size = new Size(367, 50);
            button3.TabIndex = 15;
            button3.Text = "Оплатить";
            button3.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1457, 648);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(maskedTextBox3);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "4242";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox3;
        private Button button2;
        private Button button3;
    }
}