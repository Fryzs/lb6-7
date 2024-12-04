namespace lb6_7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            checkedListBox2 = new CheckedListBox();
            checkedListBox1 = new CheckedListBox();
            comboBox2 = new ComboBox();
            listBox1 = new ListBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            BtAnswer = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(110, 99);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(349, 23);
            comboBox1.TabIndex = 0;
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Location = new Point(557, 125);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(342, 130);
            checkedListBox2.TabIndex = 1;
            checkedListBox2.SelectedIndexChanged += checkedListBox2_SelectedIndexChanged;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(110, 192);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(281, 112);
            checkedListBox1.TabIndex = 2;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(557, 330);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(342, 23);
            comboBox2.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(110, 348);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(349, 94);
            listBox1.TabIndex = 4;
            listBox1.DrawItem += listBox1_DrawItem;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(294, 499);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(385, 193);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Question";
            Column1.MinimumWidth = 4;
            Column1.Name = "Column1";
            Column1.Width = 70;
            // 
            // Column2
            // 
            Column2.HeaderText = "Answer";
            Column2.MinimumWidth = 20;
            Column2.Name = "Column2";
            Column2.Width = 300;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 81);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 174);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 7;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 330);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 8;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(575, 107);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 9;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(557, 313);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 10;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(248, 36);
            label6.Name = "label6";
            label6.Size = new Size(457, 15);
            label6.TabIndex = 11;
            label6.Text = "Тест з навчального предмету «Бази даних» тема «Основні визначення баз даних».";
            label6.Click += label6_Click;
            // 
            // BtAnswer
            // 
            BtAnswer.Location = new Point(162, 572);
            BtAnswer.Name = "BtAnswer";
            BtAnswer.Size = new Size(104, 23);
            BtAnswer.TabIndex = 12;
            BtAnswer.Text = "Write answer";
            BtAnswer.UseVisualStyleBackColor = true;
            BtAnswer.Click += BtAnswer_Click;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(763, 572);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Check";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 704);
            Controls.Add(button1);
            Controls.Add(BtAnswer);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(listBox1);
            Controls.Add(comboBox2);
            Controls.Add(checkedListBox1);
            Controls.Add(checkedListBox2);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private CheckedListBox checkedListBox2;
        private CheckedListBox checkedListBox1;
        private ComboBox comboBox2;
        private ListBox listBox1;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button BtAnswer;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button button1;
    }
}
