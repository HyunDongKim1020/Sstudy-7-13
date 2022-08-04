namespace project5
{
    public partial class Form1 : Form
    {
        //�׷��� ��ü ����
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

        double slope = 0;  //�� ����
        double dir = 0;   //���� �Ʒ�,���� ���ϴ� ���⿩��

        bool[] blockVisible = new bool[100];

        Random random = new Random();

        public Form1()
        {
            InitializeComponent();


            //�� ������
            this.ClientSize = new Size(300, 500);
            this.Text = "�����Ʊ� v1.0";
            

            // �׷��� ��ü ����
            g = this.CreateGraphics();

            //��� �ʱ�ȭ
            InitBlock();

            //���� �ʱ�ȭ
            InitRocket();
            //�� �ʱ�ȭ
            InitBall();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        protected override void OnPaint(PaintEventArgs e)
        {
            //���� �׸���

            for (int i = 0; i < nBlock; i++)
            {
                if (blockVisible[i]) 
                {
                    g.FillRectangle(blocksBrush, blocks[i]);
                }
            }
            //���� �׸���
            g.FillRectangle(racketBrush, racket);

            //�� �׸���
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

            //���� �ʱ�ȭ
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

            // ball�� �¿� ���� �浹������
            if (ball.X < 0 || ball.X >= this.Width - ballW)
            {
                slope = -slope;
            }


            // ball�� rocket�� �浹������
            if(ball.Y <0 || racket.IntersectsWith(ball))
            {
                dir = -dir;
            }


            // ball�� ������ �浹������
            for(int i = 0; i < nBlock; i++)
            {
                if (ball.IntersectsWith(blocks[i]))
                {
                    dir *= -1;
                    blockVisible[i] = false;
                }
                  
            }

            //ball�� ��������
            if (ball.Y > this.Height)
            {
                MyTimer.Stop();

               DialogResult result = MessageBox.Show("�ٽ� ���� �Ͻðڽ��ϱ�?","Ok",MessageBoxButtons.YesNo);
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

            //��� block�� ������


            //�ٽ� �׸���(OnPaint ȣ��)
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