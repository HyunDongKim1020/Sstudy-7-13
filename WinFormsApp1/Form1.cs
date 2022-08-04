namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        class User
        {
            private string uid;
            private string name;
            private string hp;
            private string age;

            public User(string uid, string name, string hp, string age)
            {
                this.uid = uid;
                this.name = name;
                this.hp = hp;
                this.age = age;
            }

            public string Uid { get => uid; set => uid = value; }
            public string Name { get => name; set => name = value; }
            public string Hp { get => hp; set => hp = value; }
            public string Age { get => age; set => age = value; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Form2�� ���� �ɋ�
        private void Form1_Load(object sender, EventArgs e)
        {
            //�޺��ڽ� ������ ����
            List<string> posDta = new List<string> { "���", "�븮", "����", "����", "����" };
            cbPos.DataSource = posDta;

            string[] cityData = { "����", "����", "�뱸", "�λ�", "����" };
            cbCity.DataSource = cityData;

            //������ �׸���� ������ ����
            List<User> users = new List<User>();
            users.Add(new User("a101", "������", "010-1234-1111", "25"));
            users.Add(new User("a102", "������", "010-1234-1111", "25"));
            users.Add(new User("a103", "������", "010-1234-1111", "25"));
            users.Add(new User("a104", "������", "010-1234-1111", "25"));
            users.Add(new User("a105", "������", "010-1234-1111", "25"));

            girdView.DataSource = users;


        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            //lbPos = "��� : " +cdPos.Text
        }

        private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {


            lbCity.Text = "��� : " + cbCity.SelectedText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }
    }
}