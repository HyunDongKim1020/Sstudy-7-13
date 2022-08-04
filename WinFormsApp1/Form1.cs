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
        //Form2가 실행 될떄
        private void Form1_Load(object sender, EventArgs e)
        {
            //콤보박스 데이터 공급
            List<string> posDta = new List<string> { "사원", "대리", "차장", "과장", "부장" };
            cbPos.DataSource = posDta;

            string[] cityData = { "서울", "대전", "대구", "부산", "광주" };
            cbCity.DataSource = cityData;

            //데이터 그리드뷰 데이터 공급
            List<User> users = new List<User>();
            users.Add(new User("a101", "김유신", "010-1234-1111", "25"));
            users.Add(new User("a102", "김유신", "010-1234-1111", "25"));
            users.Add(new User("a103", "김유신", "010-1234-1111", "25"));
            users.Add(new User("a104", "김유신", "010-1234-1111", "25"));
            users.Add(new User("a105", "김유신", "010-1234-1111", "25"));

            girdView.DataSource = users;


        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            //lbPos = "결과 : " +cdPos.Text
        }

        private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {


            lbCity.Text = "결과 : " + cbCity.SelectedText;
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