using MySql.Data.MySqlClient;

namespace Project3
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           

            //데이터그리드뷰 데이터공급
            dataGrid.DataSource = DBAccess.Instance.SelecttUsers();


            //DB 실행
            //결과처리
            //DB 종료
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //입력 데이터 저장
            string uid = txtUid.Text;
            string name = txtName.Text;
            string hp = txtHp.Text;
            string age = nAge.Text;

            DBAccess.Instance.insertUser(uid, name, hp, age);

            

          

            MessageBox.Show("데이터가 추가 되었습니다", "확인");
            //데이터그리드뷰 데이터공급
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
           dataGrid.DataSource = DBAccess.Instance.SelecttUsers();
        }

        public void CleatText()
        {
            txtUid.Text = "";
            txtName.Text = "";
            txtHp.Text = "";
            nAge.Text = "0";
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            DataGridViewRow dataRow= dataGrid.Rows[row];

            txtUid.Text = dataRow.Cells[0].Value.ToString();
            txtName.Text = dataRow.Cells[1].Value.ToString();
            txtHp.Text = dataRow.Cells[2].Value.ToString();
            nAge.Text = dataRow.Cells[3].Value.ToString();

            Console.WriteLine(dataRow.Cells[0].Value.ToString());
            Console.WriteLine(dataRow.Cells[0].Value.ToString());
            Console.WriteLine(dataRow.Cells[0].Value.ToString());
            Console.WriteLine(dataRow.Cells[0].Value.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //입력 데이터 저장
            string uid = txtUid.Text;
            string name = txtName.Text;
            string hp = txtHp.Text;
            string age = nAge.Text;

            DBAccess.Instance.UpdateUser(uid,name,hp,age);
            MessageBox.Show("데이터가 수정 되었습니다", "확인");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

           string uid = txtUid.Text;

            DialogResult result = MessageBox.Show("데이터를 삭제 하시겠습니까?","삭제 확인",MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                DBAccess.Instance.DeleteUser(uid);
                MessageBox.Show("데이터가 삭제 되었습니다");
            }
                

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            CleatText();
        }
    }
}