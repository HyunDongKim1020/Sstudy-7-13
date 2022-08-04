namespace project5
{
    public partial class Form1 : Form
    {
        //그래픽 객체 선언
        Graphics g;
        Brush racketBrush = new SolidBrush(Color.Red);
        Brush blocksBrush = new SolidBrush(Color.Orange);
        Brush ballBrush = new SolidBrush(Color.Gold);
        Pen pen = new Pen(Color.Black);

        Rectangle racket = new Rectangle();
        Rectangle[] blocks = new Rectangle[100];
        Rectangle ball = new Rectangle();

        int nBlock = 20;

        int racketW = 50;
        int racketH = 10;
        int racketY = 480;

        int blockW = 30;
        int blockH = 20;
        int blockY = 60;

        int ballW = 10;
        int ballf = 10;

        double slope = 0;  //공 기울기
        double dir = 0;   //공이 아래,위로 향하는 방향여부

        bool[] blockVisible = new bool[100];

        Random random = new Random();

        public Form1()
        {
            InitializeComponent();


            //폼 사이즈
            this.ClientSize = new Size(300, 500);
            this.Text = "벽돌꺠기 v1.0";
            

            // 그래픽 객체 생성
            g = this.CreateGraphics();

            //블록 초기화
            InitBlock();

            //라켓 초기화
            InitRocket();
            //공 초기화
            InitBall();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        protected override void OnPaint(PaintEventArgs e)
        {
            //벽돌 그리기

            for (int i = 0; i < nBlock; i++)
            {
                if (blockVisible[i]) 
                {
                    g.FillRectangle(blocksBrush, blocks[i]);
                }
            }
            //라켓 그리기
            g.FillRectangle(racketBrush, racket);

            //공 그리기
            g.FillRectangle(ballBrush, ball);
            g.DrawEllipse(pen, ball);
        }

        public void InitBlock()
        {
           for(int i = 0; i < nBlock; i++)
            {
                blocks[i] = new Rectangle(blockW * (i % 10),
                                     blockY + blockH * (i / 10),
                                              blockW -1,
                                              blockH -1);

                blockVisible[i] = true; 
            }
        }

        public void InitRocket()
        {
            racket.X = this.Width / 2 - racketW / 2;
            if(racket.X < 0)
            {

            }


            racket.Y = racketY;
            racket.Width = racketW;
            racket.Height = racketH;



        }

        public void InitBall()
        {
            ball.X = this.Width / ballW/ 2;
            ball.Y = ballf + blockY * 4;
            ball.Width = ballW;
            ball.Height = ballf;

            //기울기 초기화
            slope = random.Next(1,20) / 10.0;

            if (random.Next(2) % 2 == 1)
            {
                slope = -slope;
            }
            dir = 1;
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            //Console.WriteLine("Tick!");
            double dx = ballW / slope;
            double dy = Math.Abs(ballf * slope) * dir;

            int x = (int)dx;
            int y = (int)dy;
            
            ball.X += x;
            ball.Y += y;

            // ball이 좌우 벽에 충돌했을떄
            if (ball.X < 0 || ball.X >= this.Width - ballW)
            {
                slope = -slope;
            }


            // ball이 rocket에 충돌했을떄
            if(ball.Y <0 || racket.IntersectsWith(ball))
            {
                dir = -dir;
            }


            // ball이 벽돌에 충돌했을떄
            for(int i = 0; i < nBlock; i++)
            {
                if (ball.IntersectsWith(blocks[i]))
                {
                    dir *= -1;
                    blockVisible[i] = false;
                }
                  
            }

            //ball을 놓쳤을떄
            if (ball.Y > this.Height)
            {
                MyTimer.Stop();

               DialogResult result = MessageBox.Show("다시 시작 하시겠습니까?","Ok",MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    InitBlock();
                    InitBall();
                    InitRocket();

                    MyTimer.Start();
                }
                else
                {
                    this.Close();
                }
            }

            //모든 block을 깼을떄


            //다시 그리기(OnPaint 호출)
            this.Invalidate();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                racket.X -= racketW;
              
            }
            if(e.KeyCode == Keys.Right)
            {
                racket.X += racketW;
            }
           
        }
    }
}