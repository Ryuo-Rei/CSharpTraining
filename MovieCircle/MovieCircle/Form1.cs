using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieCircle
{
    public partial class FormBallGame : Form
    {
        private Bitmap canvas;
        private Ball[] balls;
        private string[] kanjis;
        private Brush[] brushes;
        private string fontName = "HG教科書体";
        private string correctText = "荻";
        private string mistakeText = "萩";
        private string circleText = "○";
        private double nowTime = 0;
        private int ballCount = 5;
        private int randomResult = 0;

        public FormBallGame()
        {
            InitializeComponent();
        }

        private void FormBallGame_Load(object sender, EventArgs e)
        {
            timer1.Start();
            InitGraphics();
            SetStartPosition();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
            InitGraphics();
            SetStartPosition();
        }

        private void selectPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (restartButton.Enabled)
            {
                return;
            }

            if (e.Button == MouseButtons.Left)
            {
                // どの円を選択したかを計算で算出(クリックしたx座標の位置/PictureBoxの情報)
                int selectCircle = e.X / selectPictureBox.Height;
                if (randomResult == selectCircle)
                {
                    timer1.Stop();
                    DrawMainPictureBox(Brushes.Red, circleText, true);
                    restartButton.Enabled = true;
                }
                else
                {
                    DrawMainPictureBox(Brushes.Red, correctText, false);
                    // 移動の割合を減少させる
                    for (int i = 0; i < ballCount; i++)
                    {
                        balls[i].pitch = balls[i].pitch - balls[i].pitch / 2;
                    }
                    nowTime = nowTime + 10;
                }
            }
        }

        private void mainPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (restartButton.Enabled)
            {
                return;
            }

            SetBalls(e.X, e.Y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           for (int i = 0; i < ballCount; i++)
            {
                balls[i].Move();
            }

            nowTime = nowTime + 0.02;
            textTimer.Text = nowTime.ToString("0.00");
        }

        private void DrawCircleSelectPictureBox()
        {
            int height = selectPictureBox.Height; // 高さ
            int width = selectPictureBox.Width; // 幅

            Bitmap selectCanvas = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(selectCanvas))
            {
                // g.FillEllipse(Brushes.LightBlue, 0, 0, height, height);
                for (int i = 0; i < ballCount; i++)
                {
                    g.FillEllipse(brushes[i], i * height, 0, height, height);
                }
                selectPictureBox.Image = selectCanvas;
            }
        }

        private void DrawMainPictureBox(Brush color, string text, bool trueFlag)
        {
            int height = mainPictureBox.Height;
            int width = mainPictureBox.Width;

            // 描画先とするImageオブジェクトを作成する
            if (canvas == null)
            {
                canvas = new Bitmap(width, height);
            }

            using (Graphics g = Graphics.FromImage(canvas))
            {
                // 正解用の背景色にする
                if (trueFlag)
                {
                    g.FillRectangle(Brushes.LightPink, 0, 0, width, height);
                }
                else
                {
                    g.FillRectangle(Brushes.White, 0, 0, width, height);
                }
                // 背景に引数で指定した文字列を描画する
                g.DrawString(text,
                    new Font(fontName, height - height / 4),
                    color, 0, 0, new StringFormat());

                // mainPictureBoxに表示する
                mainPictureBox.Image = canvas;
            }
        }

        // 配列の初期化、画面の初期設定を行う
        private void InitGraphics()
        {
            brushes = new Brush[ballCount];
            kanjis = new string[ballCount];
            balls = new Ball[ballCount];

            brushes[0] = Brushes.LightPink;
            brushes[1] = Brushes.LightBlue;
            brushes[2] = Brushes.LightGray;
            brushes[3] = Brushes.LightCoral;
            brushes[4] = Brushes.LightGreen;

            DrawCircleSelectPictureBox();

            DrawMainPictureBox(Brushes.Gray, correctText, false);

            restartButton.Enabled = false;
            textHunt.Text = correctText;
        }

        // ボールのインスタンスの作成とランダムな位置にボールを描く
        private void SetStartPosition()
        {
            for (int i = 0; i < ballCount; i++)
            {
                kanjis[i] = mistakeText;
            }
            randomResult = new Random().Next(ballCount);
            kanjis[randomResult] = correctText;

            for (int i = 0; i < ballCount; i++)
            {
                balls[i] = new Ball(mainPictureBox, canvas, brushes[i], kanjis[i]);
            }

            // ランダムな位置にボールを描く
            int rndXMax = mainPictureBox.Width;
            int rndYMax = mainPictureBox.Height;
            SetBalls(new Random().Next(rndXMax), new Random().Next(rndYMax));
        }

        // 引数の位置情報を利用してランダムにボールを描く
        private void SetBalls(int x, int y)
        {
            int rndXMax = mainPictureBox.Width;
            int rndYMax = mainPictureBox.Height;
            int rndX;
            int rndY;

            for (int i = 0; i < ballCount; i++)
            {
                rndX = new Random(i * x).Next(rndXMax);
                rndY = new Random(i * y).Next(rndYMax);
                balls[i].DeleteCircle();
                balls[i].PutCircle(rndX, rndY);
            }
        }
    }
}
