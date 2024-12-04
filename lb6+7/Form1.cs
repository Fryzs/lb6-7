namespace lb6_7
{
    public partial class Form1 : Form
    {
        public float mark = 0;
        int tmp;
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void BtAnswer_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows[0].Cells[1].Value = comboBox1.Text;
            String s = "";
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    s = s + checkedListBox1.Items[i].ToString() + ", ";
                }
            }
            if (s.Length > 0)
            {
                s = s.Substring(0, s.Length - 2);
            }

            dataGridView1.Rows[1].Cells[1].Value = s;
            dataGridView1.Rows[2].Cells[1].Value = listBox1.SelectedItem;
            dataGridView1.Rows[3].Cells[1].Value = comboBox2.Text;
            s = "";
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                if (checkedListBox2.GetItemChecked(i))
                {
                    s = s + checkedListBox2.Items[i].ToString() + ", ";
                }
            }
            if (s.Length > 0)
            {
                s = s.Substring(0, s.Length - 2);
            }
            dataGridView1.Rows[4].Cells[1].Value = s;
            button1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
                dataGridView1.Rows.Add();
            for (int i = 0; i < 5; i++)
                dataGridView1.Rows[i].Cells[0].Value = i + 1;

            string[] questionsTXT = File.ReadAllLines("questions.TXT");
            label1.Text = questionsTXT[4];
            label2.Text = questionsTXT[3];
            label3.Text = questionsTXT[2];
            label4.Text = questionsTXT[1];
            label5.Text = questionsTXT[0];
            string[] answerTXT = File.ReadAllLines("answer.TXT");
            int j = 0;
            int t = 0;
            bool oo = true;
            while (t < answerTXT.Length && oo)
            {

                if (string.IsNullOrEmpty(answerTXT[t]))
                {
                    j++;
                    t++;
                    continue;
                }


                if (answerTXT[t] == "/")
                {
                    t++;
                    t = tmp;
                    oo = false; 
                }


                if (j < 5)
                {
                    switch (j)
                    {
                        case 0:
                            comboBox1.Items.Add(answerTXT[t]);
                            break;
                        case 1:
                            checkedListBox2.Items.Add(answerTXT[t]);
                            break;
                        case 2:
                            listBox1.Items.Add(answerTXT[t]);
                            break;
                        case 3:
                            checkedListBox1.Items.Add(answerTXT[t]);
                            break;
                        case 4:
                            comboBox2.Items.Add(answerTXT[t]);
                            break;
                        default:
                            break;
                    }
                }


                t++;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] answerTXT = File.ReadAllLines("answer.TXT");
            int p = tmp;
             mark = 0; 
            if (dataGridView1.Rows[0].Cells[1].Value != null && dataGridView1.Rows[0].Cells[1].Value.ToString() == answerTXT[p].ToString())
                mark++;
            p++;
            if (dataGridView1.Rows[1].Cells[1].Value != null && dataGridView1.Rows[1].Cells[1].Value.ToString() == answerTXT[p].ToString())
                mark++;
            p++;
            if (dataGridView1.Rows[2].Cells[1].Value != null && dataGridView1.Rows[2].Cells[1].Value.ToString() == answerTXT[p].ToString())
                mark++;
            p++;
            if (dataGridView1.Rows[3].Cells[1].Value != null && dataGridView1.Rows[3].Cells[1].Value.ToString() == answerTXT[p].ToString())
                mark++;
            p++;
            if (dataGridView1.Rows[4].Cells[1].Value != null && dataGridView1.Rows[4].Cells[1].Value.ToString() == answerTXT[p].ToString())
                mark++;
            p++;
            MessageBox.Show("Your mark is: " + mark);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("data.bin", FileMode.Create)) 
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                writer.Write("Your mark is: " + mark);
            }

        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
