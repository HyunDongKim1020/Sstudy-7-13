namespace project4
{
    public partial class Form1 : Form
    {

        private Graphics g;
        private Pen pen;
        private Brush wBrush, bBrush;

        private int margin = 40;
        private int sizeNum = 40;
        private int sizeDol = 40;

        private bool isBlack = true;
        enum STONE { none , black , white}
        STONE[,] dataSet = new STONE[19, 19];


        public Form1()
        {
            InitializeComponent();

            //�׷��� ��ü �ʱ�ȭ
            g = this.CreateGraphics();
            pen = new Pen(Color.Black);       
            wBrush = new SolidBrush(Color.White);
            bBrush = new SolidBrush(Color.Black);

            //�ٵ��� �� ũ��
            this.BackColor = Color.Orange;
            this.ClientSize = new Size(2 * margin + 18 * sizeNum, 2 * sizeNum + 18 * sizeNum);


            //�ٵ��� ���� �׸���
            g.DrawLine(pen, new Point(10, 10), new Point(100, 10));

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int x = (e.X - margin + sizeNum /2) / sizeNum;
            int y = (e.Y -margin + sizeNum /2) / sizeNum;
            //Console.WriteLine($"x : {x},y : {y}");

            Rectangle dol = new Rectangle( margin + sizeNum * x - sizeNum /2,  
                                           margin + sizeNum * y - sizeNum /2,
                                           sizeDol,
                                           sizeDol);


            //���� �����ִ��� Ȯ��
            if (dataSet[x,y] != STONE.none)
            {
                MessageBox.Show("�̹� ���� ���� �ֽ��ϴ�");
                return;
            }

            //������,�� �׸���

            if (isBlack )
            {
                g.FillEllipse(bBrush, dol);
                dataSet[x, y] = STONE.black;
                isBlack = false;
            }
            else
            {
                g.FillEllipse(wBrush, dol);
                dataSet[x, y] = STONE.white;
                isBlack = true; 
            }

            //��������
            CheckOmok(x, y); 
            
        }

        public void CheckOmok(int x,int y)
        {
            int count = 1;

            //������ ����
            for (int i = x +1; i< x + 5; i++) {
                if (dataSet[x, y] == dataSet[i, y])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            

            //���� ����
            for (int i = x - 1; i < x - 5; i--)
            {
                if (dataSet[x, y] == dataSet[i, y])
                    count++;
                else
                    break;
                CheckCountResult(count);
                count = 1;
            }
           

            Console.WriteLine("ī��Ʈ : "+count);
            count = 1;
            //���� ����
            for (int i = y + 1; i < y + 5; i++)
            {
                if (dataSet[x, y] == dataSet[x, i])
                    count++;
                else
                    break;
            }
            Console.WriteLine("ī��Ʈ : " + count);
            count = 1;

            //�Ʒ��� ����
            for (int i = y - 1; i < y - 5; i--)
            {
                if (dataSet[x, y] == dataSet[x, i])
                    count++;
                else
                    break;
                CheckCountResult(count);
                count = 1;
            }
           

            //11�� ����
            for (int i = x - 1,j = y-1; i >=0 && j>=0; i--,j--)
            {
                if (dataSet[x, y] == dataSet[i, j])
                    count++;
                else
                    break;
            }

            //16�� ����
            for (int i = x + 1, j = y + 1; i < 19 && j < 19; i++, j++)
            {
                if (dataSet[x, y] == dataSet[i, j])
                    count++;
                else
                    break;
                CheckCountResult(count);
                count = 1;
            }

           
            //13�� ����
            for (int i = x + 1, j = y - 1; i < 19 && j >= 0; i++, j--)
            {
                if (dataSet[x, y] == dataSet[i, j])
                    count++;
                else
                    break;
                
            }

            //19�� ����
            for (int i = x - 1, j = y + 1; i >= 0 && j < 19; i--, j++)
            {
                if (dataSet[x, y] == dataSet[i, j])
                    count++; 
                else
                    break;
                CheckCountResult(count);
                count = 1;
            }
            
        }

        
        public void CheckCountResult(int count)
        {
            if(count >= 5)
            {
              DialogResult result =  MessageBox.Show("���� �Դϴ�! ���ο� ������ ���� �ұ��?", "Ȯ��", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    NewGame();
                    return;
                }
                else
                {
                    this.Close();
                }
            }
        }

        public void NewGame()
        {
            this.Invalidate();

            //dataSet �ʱ�ȭ
            for(int x = 0; x<19; x++)
            {
                for (int y = 0; y < 19; y++)
                {
                    dataSet[x, y] = STONE.none;
                }
            }
            isBlack = true;

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            for (int i = 0; i< 19; i++) 
            {
                //������
                g.DrawLine(pen, new Point(margin, margin + sizeNum * i), new Point(margin + 18 * sizeNum, margin + sizeNum * i));
                //������
                g.DrawLine(pen, new Point(margin + sizeNum * i, margin), new Point(margin + sizeNum * i, margin + 18 * sizeNum));
            }
        }
    }
}