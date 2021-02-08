using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MovieCircle
{
    class Ball
    {
        public int pitch; // 移動の割合

        private PictureBox pictureBox; // 描画するPictureBox
        private Bitmap canvas; // 描画するキャンバス
        private Brush brushColor; // 塗りつぶす色
        private int positionX; // 横位置(x座標)
        private int positionY; // 縦位置(y座標)
        private int previousX; // 以前の横位置(x座標)
        private int previousY; // 以前の縦位置(y座標)
        private int directionX; // 移動方向(x座標) (+1 or -1)
        private int directionY; // 移動方向(y座標) (+1 or -1)
        private int radius; // 円の半径
        private string kanji; // 表示する漢字
        private string fontName; // 表示する漢字のフォント名

        // 4つの引数を指定しクラスの内部に保持する。4つの引数は、描画するPictureBox、
        // 描画するキャンバス、塗りつぶす色、表示する漢字
        public Ball(PictureBox pb, Bitmap cv, Brush cl, string st)
        {
            pictureBox = pb;
            canvas = cv;
            brushColor = cl;
            kanji = st;

            radius = 40;
            pitch = radius / 2;
            directionX = +1;
            directionY = +1;
            fontName = "HG教科書体";
        }

            // 指定した位置にボールを描く
        public void PutCircle(int x, int y)
        {
            // 現在の位置を記録
            positionX = x;
            positionY = y;

            using (Graphics g = Graphics.FromImage(canvas))
            {
                // 円をbrushColorで指定された色で描く
                g.FillEllipse(brushColor, x, y, radius * 2, radius * 2);

                // 文字列を描画する
                g.DrawString(kanji, new Font(fontName, radius),
                    Brushes.Black, x + 4, y + 12, new StringFormat());

                // mainPictureBoxに表示する
                pictureBox.Image = canvas;
            }
        }

        // 指定した位置のボールを消す(白で描く)
        public void DeleteCircle()
        {
            // 初めて呼ばれて以前の値がない場合
            if(previousX == 0)
            {
                previousX = positionX;
            }
            if (previousY == 0)
            {
                previousY = positionY;
            }

            using (Graphics g = Graphics.FromImage(canvas))
            {
                // 円を白で描く
                g.FillEllipse(Brushes.White, previousX, previousY, radius * 2, radius * 2);

                // mainPictureBoxに表示する
                pictureBox.Image = canvas;
            }
        }

        // 指定した位置にボールを動かす
        public void Move()
        {
            // 以前の表示を削除
            DeleteCircle();

            // 新しい移動先の計算
            int x = positionX + pitch * directionX;
            int y = positionY + pitch * directionY;

            // 壁で跳ね返る補正
            if(x >= pictureBox.Width - radius * 2) // 右端に来た場合の判定
            {
                directionX = -1;
            }
            if(x <= 0) // 左端に来た場合の判定
            {
                directionX = +1;
            }
            if(y >= pictureBox.Height - radius * 2) // 下端に来た場合の判定
            {
                directionY = -1;
            }
            if (y <= 0) // 上端に来た場合の判定
            {
                directionY = +1;
            }

            // 跳ね返り補正を反映した値で新しい位置を計算
            positionX = x + directionX;
            positionY = y + directionY;

            // 新しい位置に描画
            PutCircle(positionX, positionY);

            // 新しい位置を以前の値として記録
            previousX = positionX;
            previousY = positionY;
        }
    }
}
