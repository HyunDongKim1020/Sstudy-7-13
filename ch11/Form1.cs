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
            MessageBox.Show("�⺻ �޽����ڽ�");
            Console.WriteLine("��ư1 Ŭ��!");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("����� ������ �ִ� �޽����ڽ�", "��ư2 Ŭ��");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
           DialogResult result =  MessageBox.Show("�ΰ��� ��ư �� ���� �޽��� �ڽ�", 
                            "��ư3Ŭ��", 
                            MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("YES�� Ŭ��!");
            }
            else
            {
                MessageBox.Show("No Ŭ��!");
            }
        }

        private void TextBoxController�ǽ�_Click(object sender, EventArgs e)
        {

        }

        private void btnHp_Load(object sender, EventArgs e)
        {

        }

        private void btnUid_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text;
            lbUid.Text = "��� : " +uid;
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            
            lbName.Text = "��� : " + txtName.Text;
        }

        private void btnhp1_Click(object sender, EventArgs e)
        {
            
            lbHp.Text = "��� : " + txtHp.Text;
        }

      
    }
}