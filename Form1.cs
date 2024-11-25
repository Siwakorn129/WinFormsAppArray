namespace WinFormsAppArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] student = new string[5];
            student[0] = "���";
            student[1] = "�ͤ��";
            student[2] = "ࢵ��";
            student[3] = "⪡ع";
            student[4] = "�鹡���";
            string test = "";
            int n = student.Length; //�Ң�Ҵ�ͧ array
            for (int i = 0; i < 5; i++)
            {
                test += student[i] + Environment.NewLine;
            }
            MessageBox.Show(test);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] Fruits = { "���", "�����¹", "�С͡", "�ѡ��", "��ҡ���" };
            string myFruits = "";
            foreach (string str in Fruits)
            {
                myFruits += str + ", ";
            }
            MessageBox.Show(myFruits, "�����ͧ�ѹ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] data = textBox1.Lines; //���������к�÷Ѵ����� array
            string result = "";
            foreach (string str in data)
            {
                if (str != "")
                {
                    result += str + Environment.NewLine;
                }
            }
            label1.Text = result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] data = textBox1.Lines;
            int sum = 0;
            string result = "";
            foreach (string str in data)
            {
                int x = 0;
                if (int.TryParse(str, out x))
                {
                    sum += x;
                    result += x.ToString() + Environment.NewLine;
                }
            }
            label1.Text = $"{result}\nSum: {sum}";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[,] student = new string[3, 2];
            student[0, 0] = "�ͻ�";
            student[0, 1] = "�֧���";
            student[1, 0] = "���";
            student[1, 1] = "�شøҹ�";
            student[2, 0] = "����";
            student[2, 1] = "˹ͧ����Ӿ�";
            string ResultData = "";
            int m = student.GetLength(0);
            int n = student.GetLength(1);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ResultData += student[i, j];
                    if (j < n - 1)
                    {
                        ResultData += "-";
                    }
                }
                ResultData += Environment.NewLine;
            }
            MessageBox.Show(ResultData, "�ʴ�������� array 2 �Ե�");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] Fruits = { "���", "�����¹", "�С͡", "�ѡ��", "��ҡ���" };
            comboBox1.Items.AddRange(Fruits);
            listBox1.Items.AddRange(Fruits);
            checkedListBox1.Items.AddRange(Fruits);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = comboBox1.SelectedIndex.ToString() + "-";
            str += comboBox1.SelectedItem;
            MessageBox.Show(str);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = listBox1.SelectedIndex.ToString() + "-";
            str += listBox1.SelectedItem;
            MessageBox.Show(str);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = checkedListBox1.SelectedIndex.ToString() + "-";
            str += checkedListBox1.SelectedItem;
            MessageBox.Show(str);
        }
    }
}
