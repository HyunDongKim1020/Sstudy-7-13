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

            //그래픽 객체 초기화
            g = this.CreateGraphics();
            pen = new Pen(Color.Black);       
            wBrush = new SolidBrush(Color.White);
            bBrush = new SolidBrush(Color.Black);

            //바둑판 색 크기
            this.BackColor = Color.Orange;
            this.ClientSize = new Size(2 * margin + 18 * sizeNum, 2 * sizeNum + 18 * sizeNum);


            //바둑판 라인 그리기
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


            //돌이 놓여있는지 확인
            if (dataSet[x,y] != STONE.none)
            {
                MessageBox.Show("이미 돌이 놓여 있습니다");
                return;
            }

            //검은돌,흰돌 그리기

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

            //오목판정
            CheckOmok(x, y); 
            
        }

        public void CheckOmok(int x,int y)
        {
            int count = 1;

            //오른쪽 방향
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
            

            //왼쪽 방향
            for (int i = x - 1; i < x - 5; i--)
            {
                if (dataSet[x, y] == dataSet[i, y])
                    count++;
                else
                    break;
                CheckCountResult(count);
                count = 1;
            }
           

            Console.WriteLine("카운트 : "+count);
            count = 1;
            //위쪽 방향
            for (int i = y + 1; i < y + 5; i++)
            {
                if (dataSet[x, y] == dataSet[x, i])
                    count++;
                else
                    break;
            }
            Console.WriteLine("카운트 : " + count);
            count = 1;

            //아래쪽 방향
            for (int i = y - 1; i < y - 5; i--)
            {
                if (dataSet[x, y] == dataSet[x, i])
                    count++;
                else
                    break;
                CheckCountResult(count);
                count = 1;
            }
           

            //11시 방향
            for (int i = x - 1,j = y-1; i >=0 && j>=0; i--,j--)
            {
                if (dataSet[x, y] == dataSet[i, j])
                    count++;
                else
                    break;
            }

            //16시 방향
            for (int i = x + 1, j = y + 1; i < 19 && j < 19; i++, j++)
            {
                if (dataSet[x, y] == dataSet[i, j])
                    count++;
                else
                    break;
                CheckCountResult(count);
                count = 1;
            }

           
            //13시 방향
            for (int i = x + 1, j = y - 1; i < 19 && j >= 0; i++, j--)
            {
                if (dataSet[x, y] == dataSet[i, j])
                    count++;
                else
                    break;
                
            }

            //19시 방향
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
              DialogResult result =  MessageBox.Show("오목 입니다! 새로운 게임을 시작 할까요?", "확인", MessageBoxButtons.YesNo);
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

            //dataSet 초기화
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
                //가로줄
                g.DrawLine(pen, new Point(margin, margin + sizeNum * i), new Point(margin + 18 * sizeNum, margin + sizeNum * i));
                //세로줄
                g.DrawLine(pen, new Point(margin + sizeNum * i, margin), new Point(margin + sizeNum * i, margin + 18 * sizeNum));
            }
        }
    }
}