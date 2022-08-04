namespace ch11
{
    public partial class btnHp : Form
    {
        public btnHp()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("기본 메시지박스");
            Console.WriteLine("버튼1 클릭!");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("제목과 내용이 있는 메시지박스", "버튼2 클릭");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
           DialogResult result =  MessageBox.Show("두개의 버튼 을 갖는 메시지 박스", 
                            "버튼3클릭", 
                            MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("YES를 클릭!");
            }
            else
            {
                MessageBox.Show("No 클릭!");
            }
        }

        private void TextBoxController실습_Click(object sender, EventArgs e)
        {

        }

        private void btnHp_Load(object sender, EventArgs e)
        {

        }

        private void btnUid_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text;
            lbUid.Text = "결과 : " +uid;
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            
            lbName.Text = "결과 : " + txtName.Text;
        }

        private void btnhp1_Click(object sender, EventArgs e)
        {
            
            lbHp.Text = "결과 : " + txtHp.Text;
        }

      
    }
}