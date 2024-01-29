namespace ebayLoginAndCheck
{
    partial class Dashboard
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            stt = new DataGridViewTextBoxColumn();
            username = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            proxy = new DataGridViewTextBoxColumn();
            quality = new DataGridViewTextBoxColumn();
            log = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            dataGridView2 = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            statusCC = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            groupBox4 = new GroupBox();
            numericUpDown14 = new NumericUpDown();
            label9 = new Label();
            label18 = new Label();
            numericUpDown12 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            label3 = new Label();
            numericUpDown2 = new NumericUpDown();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            button2 = new Button();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { stt, username, password, status, proxy, quality, log });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(11, 29);
            dataGridView1.Margin = new Padding(5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(912, 563);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseDown += dataGridView1_CellMouseDown;
            dataGridView1.MouseClick += dataGridView1_MouseClick;
            // 
            // stt
            // 
            stt.HeaderText = "STT";
            stt.MinimumWidth = 50;
            stt.Name = "stt";
            stt.Width = 50;
            // 
            // username
            // 
            username.HeaderText = "Username";
            username.MinimumWidth = 100;
            username.Name = "username";
            username.Width = 125;
            // 
            // password
            // 
            password.HeaderText = "Password";
            password.MinimumWidth = 80;
            password.Name = "password";
            password.Width = 80;
            // 
            // status
            // 
            status.HeaderText = "Status";
            status.MinimumWidth = 60;
            status.Name = "status";
            status.Width = 60;
            // 
            // proxy
            // 
            proxy.HeaderText = "Proxy";
            proxy.MinimumWidth = 100;
            proxy.Name = "proxy";
            proxy.Width = 125;
            // 
            // quality
            // 
            quality.HeaderText = "Quality";
            quality.MinimumWidth = 70;
            quality.Name = "quality";
            quality.Width = 70;
            // 
            // log
            // 
            log.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            log.HeaderText = "Log";
            log.MinimumWidth = 200;
            log.Name = "log";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Location = new Point(949, 163);
            groupBox2.Margin = new Padding(5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5);
            groupBox2.Size = new Size(323, 601);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "CC";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { name, statusCC });
            dataGridView2.Location = new Point(13, 28);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 24;
            dataGridView2.Size = new Size(303, 563);
            dataGridView2.TabIndex = 0;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.HeaderText = "Name";
            name.MinimumWidth = 100;
            name.Name = "name";
            // 
            // statusCC
            // 
            statusCC.HeaderText = "Status";
            statusCC.MinimumWidth = 70;
            statusCC.Name = "statusCC";
            statusCC.Width = 70;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(8, 163);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(933, 601);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Account";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(15, 20);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(165, 52);
            button1.TabIndex = 6;
            button1.Text = "Import Account";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(15, 80);
            button3.Margin = new Padding(5);
            button3.Name = "button3";
            button3.Size = new Size(165, 52);
            button3.TabIndex = 8;
            button3.Text = "Import CC";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(200, 80);
            button4.Margin = new Padding(5);
            button4.Name = "button4";
            button4.Size = new Size(165, 52);
            button4.TabIndex = 9;
            button4.Text = "Delete CC";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(checkBox1);
            groupBox4.Controls.Add(numericUpDown14);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label18);
            groupBox4.Controls.Add(numericUpDown12);
            groupBox4.Controls.Add(numericUpDown3);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(numericUpDown2);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(numericUpDown1);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(button8);
            groupBox4.Controls.Add(button7);
            groupBox4.Controls.Add(button6);
            groupBox4.Controls.Add(button5);
            groupBox4.Controls.Add(button3);
            groupBox4.Controls.Add(button4);
            groupBox4.Controls.Add(button1);
            groupBox4.Location = new Point(8, 9);
            groupBox4.Margin = new Padding(5);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(5);
            groupBox4.Size = new Size(1263, 145);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "Setting";
            // 
            // numericUpDown14
            // 
            numericUpDown14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDown14.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown14.Location = new Point(826, 26);
            numericUpDown14.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            numericUpDown14.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown14.Name = "numericUpDown14";
            numericUpDown14.Size = new Size(58, 31);
            numericUpDown14.TabIndex = 29;
            numericUpDown14.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown14.ValueChanged += numericUpDown14_ValueChanged;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(743, 31);
            label9.Name = "label9";
            label9.Size = new Size(77, 25);
            label9.TabIndex = 28;
            label9.Text = "Chạy từ:";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(581, 32);
            label18.Name = "label18";
            label18.Size = new Size(72, 25);
            label18.TabIndex = 27;
            label18.Text = "Quality:";
            // 
            // numericUpDown12
            // 
            numericUpDown12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDown12.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown12.Location = new Point(659, 30);
            numericUpDown12.Maximum = new decimal(new int[] { -1530494976, 232830, 0, 0 });
            numericUpDown12.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown12.Name = "numericUpDown12";
            numericUpDown12.Size = new Size(66, 31);
            numericUpDown12.TabIndex = 26;
            numericUpDown12.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // numericUpDown3
            // 
            numericUpDown3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDown3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown3.Location = new Point(826, 89);
            numericUpDown3.Margin = new Padding(5);
            numericUpDown3.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            numericUpDown3.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(62, 31);
            numericUpDown3.TabIndex = 19;
            numericUpDown3.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(743, 92);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 18;
            label3.Text = "Thread:";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDown2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown2.Location = new Point(1183, 25);
            numericUpDown2.Margin = new Padding(5);
            numericUpDown2.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(59, 31);
            numericUpDown2.TabIndex = 17;
            numericUpDown2.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1122, 27);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(36, 25);
            label2.TabIndex = 16;
            label2.Text = "Tới";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDown1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(1036, 24);
            numericUpDown1.Margin = new Padding(5);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(63, 31);
            numericUpDown1.TabIndex = 15;
            numericUpDown1.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(900, 27);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 25);
            label1.TabIndex = 14;
            label1.Text = "Thời gian đợi";
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button8.BackColor = Color.Red;
            button8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Location = new Point(1077, 79);
            button8.Margin = new Padding(5);
            button8.Name = "button8";
            button8.Size = new Size(165, 52);
            button8.TabIndex = 13;
            button8.Text = "Stop";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(902, 80);
            button7.Margin = new Padding(5);
            button7.Name = "button7";
            button7.Size = new Size(165, 52);
            button7.TabIndex = 12;
            button7.Text = "Start";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(388, 20);
            button6.Margin = new Padding(5);
            button6.Name = "button6";
            button6.Size = new Size(165, 52);
            button6.TabIndex = 11;
            button6.Text = "Delete Account";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(200, 20);
            button5.Margin = new Padding(5);
            button5.Name = "button5";
            button5.Size = new Size(165, 52);
            button5.TabIndex = 10;
            button5.Text = "Change Proxy";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(7, 11);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1286, 801);
            tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox4);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(1278, 768);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Hotmail Login And Check";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(1278, 768);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Setting";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(485, 218);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(165, 52);
            button2.TabIndex = 38;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(140, 157);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(510, 27);
            textBox3.TabIndex = 37;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(22, 159);
            label6.Name = "label6";
            label6.Size = new Size(89, 25);
            label6.TabIndex = 36;
            label6.Text = "ID Group:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(140, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(510, 27);
            textBox2.TabIndex = 35;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(22, 89);
            label5.Name = "label5";
            label5.Size = new Size(115, 25);
            label5.TabIndex = 34;
            label5.Text = "Bot Telegram";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(140, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(510, 27);
            textBox1.TabIndex = 33;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(22, 21);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 32;
            label4.Text = "API Captcha:";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.ForeColor = Color.Green;
            label15.Location = new Point(705, 812);
            label15.Name = "label15";
            label15.Size = new Size(104, 20);
            label15.TabIndex = 12;
            label15.Text = "Creation Date:";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.ForeColor = Color.Green;
            label16.Location = new Point(960, 812);
            label16.Name = "label16";
            label16.Size = new Size(89, 20);
            label16.TabIndex = 13;
            label16.Text = "Expire Date:";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.ForeColor = Color.Green;
            label17.Location = new Point(1174, 812);
            label17.Name = "label17";
            label17.Size = new Size(67, 20);
            label17.TabIndex = 14;
            label17.Text = "Day Left:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(590, 90);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(92, 29);
            checkBox1.TabIndex = 30;
            checkBox1.Text = "Tắt ảnh";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1305, 836);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(tabControl1);
            MinimumSize = new Size(1323, 883);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            FormClosing += Dashboard_FormClosing;
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown14).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown12).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button button1;
        private Button button3;
        private Button button4;
        private GroupBox groupBox4;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private NumericUpDown numericUpDown3;
        private Label label3;
        private NumericUpDown numericUpDown2;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn statusCC;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private NumericUpDown numericUpDown12;
        private NumericUpDown numericUpDown14;
        private Label label9;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn proxy;
        private DataGridViewTextBoxColumn quality;
        private DataGridViewTextBoxColumn log;
        private TabPage tabPage2;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox3;
        private Label label6;
        private Button button2;
        private CheckBox checkBox1;
    }
}