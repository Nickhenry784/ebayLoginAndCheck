namespace ebayLoginAndCheck.Views
{
    partial class AddAccount
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(469, 25);
            label1.TabIndex = 0;
            label1.Text = "List Account (Username|Password Or Username:Password)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(596, 20);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "List Proxy";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 59);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(544, 437);
            textBox1.TabIndex = 2;
            textBox1.WordWrap = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(596, 59);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(383, 437);
            textBox2.TabIndex = 3;
            textBox2.WordWrap = false;
            // 
            // button2
            // 
            button2.Location = new Point(596, 517);
            button2.Name = "button2";
            button2.Size = new Size(383, 46);
            button2.TabIndex = 5;
            button2.Text = "Add Account And Proxy";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(202, 517);
            button3.Name = "button3";
            button3.Size = new Size(167, 46);
            button3.TabIndex = 7;
            button3.Text = "Import Account";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(397, 517);
            button4.Name = "button4";
            button4.Size = new Size(167, 46);
            button4.TabIndex = 8;
            button4.Text = "Import Proxy";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // AddAccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1000, 575);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximumSize = new Size(1018, 622);
            MinimumSize = new Size(1018, 622);
            Name = "AddAccount";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}