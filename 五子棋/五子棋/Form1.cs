using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Timers;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections.Specialized;
//这是一个测试
namespace 五子棋
{
    public partial class Form1 : Form
    {
        private string Whites = Application.StartupPath + "\\白棋子.png";
        private string Blacks = Application.StartupPath + "\\黑棋子.png";
        private string png = Application.StartupPath + "\\棋盘1.jpg";
        string[] color = new string[] { "白子", "黑子" };
        private const int None = 2;//没有棋子
        private const int White = 0;//代表白棋
        private const int Black = 1;//代表黑棋        
        private int[,] checkerBoard = new int[15, 15];//棋盘(用来保存每一个棋子)
        private int[,] temp = new int[15, 15];//预测棋盘
        private int nextPlayer;//下一个选手
        private int times = 0;
        private int nowstep = 0;//当前步数
        private bool gameover = true;//判断游戏是否结束
        private bool machine =true ;//轮到电脑下
        ArrayList step = new ArrayList();//存放棋谱
        ArrayList nextchess = new ArrayList();//读取棋谱
        ArrayList root = new ArrayList();//读取棋谱

        private int Player
        {
            get
            {
                return nextPlayer;
            }
            set
            {
                nextPlayer = value;
                ReDrawNextPlayerMark();
            }
        }
        public struct Stonepoint  //棋谱结构
        {
            public Point P;
            public int color;
        };
        public struct Tree_Point//搜索树结构
        {
            public Point P;
            public int score;

        }

        public Form1()
        {
            InitializeComponent();
            Player = Black;//默认设置为黑棋先下      
            时间textBox.Text = (30 - times).ToString();
            ReDrawNextPlayerMark();
        }

        //开始新的棋局，所有数据复位并重画棋盘
        private void Reset()
        {
            this.BackgroundImage = Image.FromFile(png);//重画棋盘
            Delay(0.01);//延时
            for (int i = 0; i < 15; i++)//数据清零
            {
                for (int j = 0; j < 15; j++)
                {
                    checkerBoard[i, j] = None;
                }
            }
            gameover = false;
            step.Clear();
            textBox.Text = "—————————\r\n开始——" + color[Player] + "先手\r\n";
            richTextBox0.Text = richTextBox1.Text = "";
            暂停SToolStripMenuItem.Text = "暂停（&S）";
            button2.Text = "结束";
            Player = 黑子先下ToolStripMenuItem.Checked == true ? Black : White;
            ReDrawNextPlayerMark();
            times = 0;//时间清零
            timer1.Start();
        }
        //重画选手的标志棋子
        private void ReDrawNextPlayerMark()
        {
            Image image;
            if (Player == White) image = Image.FromFile(Whites);
            else image = Image.FromFile(Blacks);
            Graphics g = this.CreateGraphics();
            g.DrawImage(image, 540, 170, 30, 30);
        }
        //响应鼠标点击
        private void OnMouseClick(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            switch (e.Button)
            {
                //take left button down
                case MouseButtons.Left:
                    /*  if ((e.X > 530) && (e.X < 570) && (e.Y > 160) && (e.Y < 200)) changchess();//更改先手
                       else */
                    if (machine == false || Player == (comboBoxA.Text == "黑子" ? Black : White))
                        AddChess(MToA(new Point(e.X, e.Y)));
                    break;
                //take right button down
                case MouseButtons.Right:
                    // OnRButtonDown(new Point(e.X,e.Y));
                    break;
            }
        }
        //把鼠标坐标转换成棋盘坐标
        private Point MToA(Point p)
        {
            return new Point((p.X - 12) / 30, (p.Y - 37) / 30);
        }
        //在棋盘上画一个棋子
        private void DrawChess(Point pCoordinates, int iplayer)
        {
            // System.Drawing.Graphics g = this.CreateGraphics();
            // imageList1.Draw(g, 20 + pCoordinates.X * 32, 20 + pCoordinates.Y * 32, 20, 20, iPlayer);           
            Image image;
            if (iplayer == White) image = Image.FromFile(Whites);
            else image = Image.FromFile(Blacks);
            Graphics g = this.CreateGraphics();
            g.DrawImage(image, 10 + pCoordinates.X * 30, 35 + pCoordinates.Y * 30, 20, 20);
            textBox.Text = color[iplayer] + ":" + pCoordinates.Y.ToString() + "," + pCoordinates.X.ToString() + "\r\n" + textBox.Text;
        }
        //在指定的棋盘坐标位置添加一个棋子
        private void AddChess(Point p)
        {
            //判断是否超出边界
            if ((p.X < 0 || p.X > 14) || (p.Y < 0 || p.Y > 14)) return;
            //判断该位置有无棋子
            if (checkerBoard[p.Y, p.X] != None || gameover == true) return;//如果已经有了棋子则退出（这颗棋不能下）
            DrawChess(p, Player);
            if (Player == White)//换颜色
            {
                checkerBoard[p.Y, p.X] = White;
                Player = Black;
            }
            else
            {
                checkerBoard[p.Y, p.X] = Black;
                Player = White;
            }
            times = 0;//重新计时
            Stonepoint pt = new Stonepoint();
            pt.P.X = p.X;
            pt.P.Y = p.Y;
            pt.color = checkerBoard[p.Y, p.X];
            step.Add(pt);//存储棋局
            Check(checkerBoard, p.Y, p.X);//判断是否结束
            compare(info(checkerBoard), White);//分析棋局
            compare(info(checkerBoard), Black);
            if (gameover == false && machine == true && Player == (comboBoxB.Text == "白子" ? White : Black))
                auto(Player);//电脑自动下子
        }
        //判断游戏是否结束
        private void Check(int[,] manual, int m, int n)
        {
            if (step.Count >= 225)
            {
                timer1.Stop();
                textBox.Text = "平局，游戏结束\r\n—————————\r\n" + textBox.Text;
                if (MessageBox.Show("平局，游戏结束。是否重新开始？", "结束", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    Reset();
                else { gameover = true; button2.Text = "开始"; }
                return;
            }
            //判断是否有五子相连
            if (win(manual, 5, m, n) == true)
            {
                timer1.Stop();
                textBox.Text = color[manual[m, n]] + "胜利，游戏结束\r\n—————————\r\n" + textBox.Text;
                if (MessageBox.Show(color[manual[m, n]] + "胜利，游戏结束。是否重新开始？", "结束", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    Reset();
                else { gameover = true; button2.Text = "开始"; }
            }
        }
        //胜负判定函数
        private bool win(int[,] manual, int number, int m, int n)
        {
            int startRow, startColumn, endRow, endColumn;

            //第一步：越界处理
            startColumn = (n - 4 < 0) ? 0 : n - 4;
            startRow = (m - 4 < 0) ? 0 : m - 4;
            endColumn = (n + 4 > 14) ? 14 : n + 4;
            endRow = (m + 4 > 14) ? 14 : m + 4;
            //第二步：以每个落子坐标为中心，判断各方向是否成5
            //落子所在行
            for (int count = 0, i = startColumn; i <= endColumn; i++)
            {
                if (manual[m, i] == manual[m, n]) count++;
                else count = 0;
                if (count >= number) return true;
            }

            //落子所在列
            for (int count = 0, i = startRow; i <= endRow; i++)
            {
                if (manual[i, n] == manual[m, n]) count++;
                else count = 0;
                if (count >= number) return true;
            }
            //落子所在左斜向下
            int num = 0;
            for (int i = m - 1, j = n - 1; i >= 0 && m - i <= 4 && j >= 0 && n - j <= 4; )
            {
                if (manual[i, j] == manual[m, n]) { num++; i--; j--; }
                else break;
                if (num >= number - 1) return true;
            }
            for (int i = m + 1, j = n + 1; i <= 14 && i - m <= 4 && j <= 14 && j - n <= 4; )
            {
                if (manual[i, j] == manual[m, n]) { num++; i++; j++; }
                else break;
                if (num >= number - 1) return true;
            }
            if (num >= number - 1) return true;
            //落子所在左斜向上
            num = 0;
            for (int i = m - 1, j = n + 1; i >= 0 && m - i <= 4 && j <= 14 && j - n <= 4; )
            {
                if (manual[i, j] == manual[m, n]) { num++; i--; j++; }
                else break;
                if (num >= number - 1) return true;
            }
            for (int i = m + 1, j = n - 1; i <= 14 && i - m <= 4 && j >= 0 && n - j <= 4; )
            {
                if (manual[i, j] == manual[m, n]) { num++; i++; j--; }
                else break;
                if (num >= number - 1) return true;
            }
            if (num >= number - 1) return true;

            return false;
        }
        //统计各种棋型的数目
        /*  private int[,] type(int[,] manual, int m, int n, int iplayer)
          {
              int[,] num = new int[6, 2];
              for (int i = 0; i < 6; i++)
              {
                  num[i, 0] = 0;
                  num[i, 1] = 0;
              }
              int count = 0;
              //落子所在行
              for (int i = n + 1; i <= 14; i++)
              {
                  if (manual[m, i] == None) continue;
                  else if (manual[m, i] == iplayer) count++;
                  else break;
                  if (i - n > 5 || i > 14)
                  {
                      if (i <= 14 && manual[m, i] == None) num[count, 0]++;
                      else num[count, 1]++;
                      break;
                  }
              }

              count = 0;
              //落子所在列
              for (int i = m + 1; i <= 14; i++)
              {
                  if (manual[m, i] == None) continue;
                  else if (manual[i, n] == iplayer) count++;
                  else break;
                  if (i - m > 5 || i > 14)
                  {
                      if (i <= 14 && manual[i, n] == None) num[count, 0]++;
                      else num[count, 1]++;
                      break;
                  }
              }

              count = 0;
              //落子所在左斜
              for (int i = m + 1, j = n - 1; i <= 14 && j >= 0; i++, j--)
              {
                  if (manual[m, i] == None) continue;
                  else if (manual[i, j] == iplayer) count++;
                  else break;
                  if (i - m > 5 || i > 14 || n - j > 5 || j < 0)
                  {
                      if (i <= 14 && j >= 0 && manual[i, j] == None) num[count, 0]++;
                      else num[count, 1]++;
                      break;
                  }
              }

              count = 0;
              //落子所在右斜
              for (int i = m + 1, j = n + 1; i <= 14 && j <= 14; i++, j++)
              {
                  if (manual[m, i] == None) continue;
                  else if (manual[i, j] == iplayer) count++;
                  else break;
                  if (i - m > 5 || i > 14 || j - n > 5 || j > 14)
                  {
                      if (i <= 14 && j <= 14 && manual[i, j] == None) num[count, 0]++;
                      else num[count, 1]++;
                      break;
                  }
              }
              return num;
          }*/

        //解析当前棋盘（转换为字符串）
        private string[,] info(int [,]check )
        {
            string[,] infochess = new string[4, 32];
            for (int i = 0; i < 32; i++)
            {
                infochess[0, i] = infochess[1, i] = infochess[2, i] = infochess[3, i] = "#";
            }
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    infochess[0, i + 1] += check[i, j].ToString();//横
                    infochess[1, j + 1] += check[i, j].ToString();//竖
                    if (i - j >= 0)//右斜
                    {
                        infochess[2, i + 1] += check[14 - i + j, j].ToString();
                        infochess[2, 30 - i] += check[j, 14 - i + j].ToString();
                    }
                    if (i - j >= 0)//左斜
                    {
                        infochess[3, i + 1] += check[i - j, j].ToString();
                        infochess[3, 30 - i] += check[14 - j, 14 - i + j].ToString();
                    }
                }
            }
            return infochess;
        }
        //统计当前棋局各种棋型并算出得分
        private int compare(string[,] infochess, int iplayer)
        {
            Regex strinfo;
            int score = 0;
            string[] het = new string[] { "五子","活四", "冲四", "活三", "眠三", "活二", "眠二" };
            int[] hes = new int[] { 50000, 20000, 10000, 6000, 800, 400, 100 };
            string[] ss = new string[7];
            int[] sum = new int[] {0, 0, 0, 0, 0, 0, 0 };
            if (iplayer == White)//匹配白子
            {
                ss = new string[] {                        
                "00000",
                "200002",
                "(20000(1|#))|((1|#)00002)|(02000)|(00020)|(00200)",
                "(220002)|(200022)|(202002)|(200202)",
                "(22000(1|#))|((1|#)00022)|(20200(1|#))|((1|#)00202)|(20020(1|#))|((1|#)02002)|(02200)|(02020)|((1|#)20002(1|#))",
                "(22002(2|1|#))|((2|1|#)20022)|(202202)|(20202)", 
                "(22200(1|#))|((1|#)00222)|(22020(1|#))|((1|#)02022)|(20220(1|#))|((1|#)02202)|(02220)",};
            }
            else if (iplayer == Black)//匹配黑子
            {
                ss = new string[]{
                "11111",
                "211112",
                "(21111(0|#))|((0|#)11112)|(12111)|(11121)|(11211)",
                "(221112)|(211122)|(212112)|(211212)",
                "(22111(0|#))|((0|#)11122)|(21211(0|#))|((0|#)11212)|(21121(0|#))|((0|#)12112)|(12211)|(12121)|((0|#)21112(0|#))",
                "(22112(2|0|#))|((2|0|#)21122)|(212212)|(21212)",
                "(22211(0|#))|((0|#)11222)|(22121(0|#))|((0|#)12122)|(21221(0|#))|((0|#)12212)|(12221)",};
            }

            for (int k = 0; k < ss.Length; k++)
            {
                for (int i = 0; i < 15; i++)
                {
                    strinfo = new Regex(ss[k]);
                    sum[k] += strinfo.Matches(infochess[0, i]).Count;//横
                    sum[k] += strinfo.Matches(infochess[1, i]).Count;//竖
                }
                for (int i = 5; i < 25; i++)
                {
                    if (i == 15) continue;
                    strinfo = new Regex(ss[k]);
                    sum[k] += strinfo.Matches(infochess[2, i]).Count;//右斜
                    sum[k] += strinfo.Matches(infochess[3, i]).Count;//左斜
                }
            }
            for (int i = 0; i < sum.Length; i++)
                score += sum[i] * hes[i];
            if ((iplayer == White && comboBoxA.Text == "白子") || (iplayer == Black && comboBoxA.Text == "黑子"))
            {
                richTextBox0.Text = "棋局分析," + comboBoxA.Text + "得分：" + score + "\r\n";
                for (int i = 0; i < sum.Length; i++)
                {
                    if (sum[i] != 0) richTextBox0.Text += het[i] + ":" + sum[i] + "\r\n";
                }
            }
            else
            {
                richTextBox1.Text = "棋局分析," + comboBoxB.Text + "得分：" + score + "\r\n";
                for (int i = 0; i < sum.Length; i++)
                {
                    if (sum[i] != 0) richTextBox1.Text += het[i] + ":" + sum[i] + "\r\n";
                }
            }
            return score;
        }        
        //电脑自动分析并下子
        private void auto(int iplayer)
        {
            if (step.Count ==0)//电脑先手随机下子
            {
                Random r = new Random();
                int x = r.Next(5, 10);
                int y = r.Next(5, 10);
                AddChess(new Point(x,y));
                return;
            }

            int[,] chessscore1 = new int[15, 15];//我方下当前位置得分
            int[,] chessscore2 = new int[15, 15];//对方下当前位置得分
            int fscore1 = compare(info(checkerBoard), iplayer);//当前棋盘分数
            int fscore2 = compare(info(checkerBoard), iplayer == White ? Black : White);
            for (int i = 0; i < 15; i++)//初始化
            {
                for (int j = 0; j < 15; j++)
                {
                    chessscore1[i, j] = chessscore2[i, j] = 1;
                }
            }
            int min_i, min_j, max_i, max_j;
            min_i = max_i = ((Stonepoint)(step[0])).P.Y;
            min_j = max_j = ((Stonepoint)(step[0])).P.X;
            for (int i = 0; i < step.Count; i++)//求下子边界值
            {
                if (((Stonepoint)(step[i])).P.Y < min_i) min_i = ((Stonepoint)(step[i])).P.Y;
                if (((Stonepoint)(step[i])).P.Y > max_i) max_i = ((Stonepoint)(step[i])).P.Y;
                if (((Stonepoint)(step[i])).P.X < min_j) min_j = ((Stonepoint)(step[i])).P.X;
                if (((Stonepoint)(step[i])).P.X > max_j) max_j = ((Stonepoint)(step[i])).P.X;
            }
            int range = step.Count > 5 ? 2 : 1;
            min_i = min_i - range < 0 ? 0 : min_i - range;
            max_i = max_i + range > 14 ? 14 : max_i + range;
            min_j = min_j - range < 0 ? 0 : min_j - range;
            max_j = max_j + range > 14 ? 14 : max_j + range;

            int[] hex = new int[4] { min_j, min_j, min_j, min_j };
            int[] hey = new int[4] { min_i, min_i, min_i, min_j };
            int[] maxscore = new int[4] { -1000000, -1000000, -1000000, -1000000 };
            //temp = (int[,])checkerBoard.Clone();
            for (int m = 0; m < 15; m++)
                for (int n = 0; n < 15; n++)
                    temp[m, n] = checkerBoard[m, n];

            for (int i = min_i; i <= max_i; i++)//预测下子后棋盘分数变化
            {
                for (int j = min_j; j <= max_j; j++)
                {
                    if (temp[i, j] == None)
                    {
                        int score1, score2;
                        temp[i, j] = iplayer;
                        score1 = compare(info(temp), iplayer);
                        if (score1 - fscore1 > 10000) score1 += 5000;//构成双活三加分
                        score2 = compare(info(temp), iplayer == White ? Black : White);
                        if (score2 - fscore2 > 10000) score2 += 5000;
                        chessscore1[i, j] = score1 - score2 * 3;
                        temp[i, j] = iplayer == White ? Black : White;
                        score1 = compare(info(temp), iplayer == White ? Black : White);
                        score2 = compare(info(temp), iplayer);
                        chessscore2[i, j] = score1 * 3 - score2;     
                        temp[i, j] = None;
                    }
                }
            }
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)//计算3个最佳下子位置
                {
                    if (chessscore1[i, j] != 1 && chessscore2[i, j] != 1 && chessscore1[i, j] + chessscore2[i, j] > maxscore[0])
                    {
                        maxscore[0] = chessscore1[i, j] + chessscore2[i, j];
                        hex[0] = j;
                        hey[0] = i;
                    }
                    for (int k = 1; chessscore1[i, j] != 1 && chessscore2[i, j] != 1 && k < 4; k++)//得分一样的位置
                    {
                        if (chessscore1[i, j] + chessscore2[i, j] > maxscore[k])
                        {
                            maxscore[k] = chessscore1[i, j] +chessscore2[i, j];
                            hex[k] = j;
                            hey[k] = i;
                            break;
                        }
                    }
                }
            }
            int num = 0;
            if (maxscore[0] == maxscore[1] && maxscore[1] == maxscore[2] && maxscore[2] == maxscore[3])
            {
                Random rd = new Random();//得分一样随机下子
                num = rd.Next(4);
            }
            Point pt = new Point();//记录下子坐标
            pt.X = hex[num];
            pt.Y = hey[num];
            AddChess(pt);//调用下子函数
        }

        //Max_Min博弈树的构造：传入当前棋局矩阵作为参数
        private void Tree_Construct(int[,] chess_board, int play)
        {
            if (root.Count >= 110) return;
            int[,] score = new int[15, 15];   //评分数组，落子坐标作为索引，评分函数得出的分数作为元素值
            int[,] temp = new int[15, 15];    //临时存放传入的棋局，防止后面的假设落子操作修改的原有棋局
            temp = (int[,])chess_board.Clone();

            int min_i, min_j, max_i, max_j;//计算下子边界值
            min_i = max_i = ((Stonepoint)(step[0])).P.Y;
            min_j = max_j = ((Stonepoint)(step[0])).P.X;
            for (int i = 0; i < step.Count; i++)
            {
                if (((Stonepoint)(step[i])).P.Y < min_i) min_i = ((Stonepoint)(step[i])).P.Y;
                if (((Stonepoint)(step[i])).P.Y > max_i) max_i = ((Stonepoint)(step[i])).P.Y;
                if (((Stonepoint)(step[i])).P.X < min_j) min_j = ((Stonepoint)(step[i])).P.X;
                if (((Stonepoint)(step[i])).P.X > max_j) max_j = ((Stonepoint)(step[i])).P.X;
            }
            min_i = min_i - 2 < 0 ? 0 : min_i - 2;
            max_i = max_i + 2 > 14 ? 14 : max_i + 2;
            min_j = min_j - 2 < 0 ? 0 : min_j - 2;
            max_j = max_j + 2 > 14 ? 14 : max_j + 2;
            //遍历整个棋盘，对每一个可落子位置：
            //1.假设落子，调用评价函数进行落子后的棋局评分，存入评分数组
            //2.选取评分前10的落子位置对应的棋局及对应棋局评分，作为子节点，加入Max_Min策略博弈树
            //3.以其中一个子节点为例，重复1,2两步，直至Max_Min策略博弈树的深度为5（即预测两步或者三步）
            for (int row = min_i; row <= max_i; ++row)
            {
                for (int column = min_j; column <= max_j; ++column)
                {
                    //当前位置不是空位（即可落子位置）
                    if (temp[row, column] != None)
                    {
                        continue;
                    }
                    //当前位置为空位
                    else //调用评价函数
                    {
                        int score1, score2;
                        temp[row, column] = play == White ? White : Black;
                        score1 = compare(info(temp), play);
                        score2 = compare(info(temp), play == White ? Black : White);
                        score[row, column] = score1 - score2 * 3;                     
                        temp[row, column] = None;
                    }
                }
            }

            Tree_Point[] tree_p = new Tree_Point[10];
            for (int i = min_i; i <= max_i; ++i)
                for (int j = min_j; j < max_j; ++j)
                {
                    for (int k = 0; k < 10; ++k)
                        if (score[i, j] > tree_p[k].score)
                        {
                            tree_p[k].score = score[i, j];
                            tree_p[k].P.Y = i;
                            tree_p[k].P.X = j;
                            break;
                        }
                }

            ArrayList subroot = new ArrayList();
            for (int index = 0; index < 10; ++index)
            {
                root.Add(tree_p[index]);
                subroot.Add(tree_p[index]);
            }

            while (subroot.Count != 0)
            {
                Point p = new Point();
                p.Y = ((Tree_Point)(subroot[0])).P.Y;
                p.X = ((Tree_Point)(subroot[0])).P.X;
                if (play == White)
                {
                    temp[p.Y, p.X] = 0;
                    play = Black;
                    Tree_Construct(temp, play);
                    subroot.RemoveAt(0);
                }
                else if (play == Black)
                {
                    temp[p.Y, p.X] = 1;
                    play = White;
                    Tree_Construct(temp, play);
                    subroot.RemoveAt(0);
                }
                temp = (int[,])chess_board.Clone();
            }
        }
        //Max_Min博弈树的搜索
        int Find(ArrayList root)
        {
            int top_score, weizhi = 0;
            for (int index = root.Count - 1; index > 0; index -= 10)
            {

                top_score = ((Tree_Point)root[index]).score;
                int count;
                for (count = 0; count < 10; ++count)//查找10个子节点中最优值
                    if (((Tree_Point)root[index - count]).score > top_score)
                    {
                        top_score = ((Tree_Point)root[index - count]).score;
                        weizhi = index - count;
                    }
                if (weizhi >= 9)//最大分数返回父节点
                {
                    Tree_Point temp = ((Tree_Point)root[(weizhi / 10 - 1)]);
                    temp.score = -top_score;
                    root[weizhi / 10 - 1] = temp;
                }
            }
            return weizhi;
        }

        //读取棋谱并下子
        private void playchess(ArrayList stepschess,int num)
        {
            Image image;
            Graphics g1 = this.CreateGraphics();
            Stonepoint pt = new Stonepoint();
            pt.P.X = ((Stonepoint)(stepschess[num])).P.X;
            pt.P.Y = ((Stonepoint)(stepschess[num])).P.Y;
            pt.color = ((Stonepoint)(stepschess[num])).color;
            if (pt.color == White) image = Image.FromFile(Whites);
            else image = Image.FromFile(Blacks);
            g1.DrawImage(image, 10 + pt.P.X * 30, 35 + pt.P.Y * 30, 20, 20);
            textBox.Text = color[pt.color] + ":" + pt.P.Y.ToString() + "," + pt.P.X.ToString() + "\r\n" + textBox.Text;
            if (Player == White)//换颜色
            {
                checkerBoard[pt.P.Y, pt.P.X] = White;
                Player = Black;
            }
            else
            {
                checkerBoard[pt.P.Y, pt.P.X] = Black;
                Player = White;
            }
        }
        //下一步
        private void button6_Click(object sender, EventArgs e)
        {
            if (nowstep >= nextchess.Count) return;
            button2.Text = "结束";
            playchess(nextchess, nowstep);
            compare(info(checkerBoard), White);//分析棋局
            compare(info(checkerBoard), Black);
            nowstep++;
            times = 0;
        }
        //解析棋谱，并存在step中
        private ArrayList parsesgf(string path)
        {
            try
            {
                StreamReader reader = new StreamReader(path);   	//打开棋谱文件
                string data = reader.ReadToEnd();                   //读取棋谱文件
                string patten = @"((B|W)\[[a-z]{2}?\];)+";         //匹配模式
                Regex r = new Regex(patten);
                Match m = r.Match(data);
                // textBox1.Text += m.Value;
                string[] stones = m.Value.Split(';');            //分割每个棋子的位置

                ArrayList stoneArr = new ArrayList();			//棋子序列

                Stonepoint S = new Stonepoint();
                //建立索引对a-0；b-1……；
                Dictionary<String, int> dic = new Dictionary<string, int>();
                char ch = 'a';
                for (int i = 0; i < 15; i++)
                {
                    dic.Add(ch++.ToString(), i);
                }
                foreach (string item in stones)
                {
                    if (item != "")
                    {                       
                        char[] stone = item.ToCharArray();
                        string Rkey = stone[2].ToString();//读取行
                        string Ckey = stone[3].ToString();//读取列
                        int t1 = -1, t2 = -1;
                        if (dic.ContainsKey(Rkey) && dic.ContainsKey(Ckey))
                        {
                            t1 = dic[Rkey];//转换行序号
                            S.P.Y = t1;
                            t2 = dic[Ckey];//转换列序号
                            S.P.X = t2;                           
                        }
                        //判断棋子颜色
                        if (stone[0] == 'B')
                        {
                            S.color = Black;//黑色是1
                        }
                        else
                        {
                            S.color = White;//黑色是 0
                        }                       
                        //棋子入栈
                        stoneArr.Add(S);
                        //t++;
                    }
                }
                return stoneArr;//返回棋子序列
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
        private void 读取RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = System.Environment.CurrentDirectory + "\\sgf";//Application.StartPath
            OpenFileDialog fileDialog1 = new OpenFileDialog();
            fileDialog1.InitialDirectory = path;
            fileDialog1.Filter = "sgf files (*.sgf)|*.sgf|All files (*.*)|*.*";
            fileDialog1.FilterIndex = 1;
            fileDialog1.RestoreDirectory = true;
            if (fileDialog1.ShowDialog() == DialogResult.OK)
            {
                //textBox1.Text = fileDialog1.FileName;
                Reset();
                nextchess = parsesgf(fileDialog1.FileName);
            }
        }
        //悔棋
        private void button3_Click(object sender, EventArgs e)
        {
            if (step.Count > 0 && gameover == false)
            {
                this.BackgroundImage = Image.FromFile(png);//重画棋盘
                Delay(0.01);//延时
                for (int i = 0; i < (machine == true ? 2 : 1); i++)
                {
                    int iplayer = ((Stonepoint)(step[step.Count - 1])).color;//重新下子
                    string s = color[Player] + ":" + ((Stonepoint)(step[step.Count - 1])).P.Y.ToString() + "," + ((Stonepoint)(step[step.Count - 1])).P.X.ToString() + "\r\n";
                    textBox.Text = textBox.Text.Remove(0, s.Length);
                    checkerBoard[((Stonepoint)(step[step.Count - 1])).P.Y, ((Stonepoint)(step[step.Count - 1])).P.X] = None;//消除最后一步记录
                    step.RemoveAt(step.Count - 1);//消除棋谱记录
                }
                for (int i = 0; i < step.Count; i++)//从棋谱中读取数据并重画
                {
                    playchess(step, i);
                }
                times = 0;
            }
        }
        //延时函数
        public static bool Delay(double delayTime)
        {
            DateTime now = DateTime.Now;
            double s;
            do
            {
                TimeSpan spand = DateTime.Now - now;
                s = spand.Milliseconds * 10;
                Application.DoEvents();
            }
            while (s < delayTime);
            return true;
        }
        //更改先手
        private void changchess(int iplayer)
        {
            if (gameover == false)
            {
                if (MessageBox.Show("更改先手顺序后必须重新开始，是否更改？", "更改", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Reset();
                }
                else return;
            }
            Player = iplayer;
            if (iplayer == White)
            {
                白子先下ToolStripMenuItem.Checked = true;
                黑子先下ToolStripMenuItem.Checked = false;
            }
            else
            {
                白子先下ToolStripMenuItem.Checked = false;
                黑子先下ToolStripMenuItem.Checked = true;
            }
            if ((iplayer == White && comboBoxA.Text == "白子") || (iplayer == Black && comboBoxA.Text == "黑子"))
            {
                radioButtonA.Checked = true;
                radioButtonB.Checked = false;
            }
            else
            {
                radioButtonA.Checked = false;
                radioButtonB.Checked = true;
            }
        }
        //时间函数
        private void timer1_Tick(object sender, EventArgs e)
        {
            时间textBox.Text = (30 - times).ToString();
            times++;
            if (times > 5 && gameover == false && machine == true && Player == (comboBoxB.Text == "白子" ? White : Black))
                auto(Player);//电脑先手
            if (times > 30)
            {
                timer1.Stop();
                if (MessageBox.Show(color[Player] + "下子超时！是否重新计时？", "超时", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    times = 0;
                    timer1.Start();
                }
                else
                {
                    textBox.Text = color[Player] + "超时，游戏结束\r\n—————————\r\n" + textBox.Text;
                    MessageBox.Show(color[Player] + "超时，" + color[Player == White ? Black : White] + "胜利！游戏结束。", "结束", MessageBoxButtons.OK);
                    gameover = true;
                    button2.Text = "开始";
                }
            }
        }
        //重新开始
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "开始")
            {
                Reset();
            }
            else
            {
                gameover = true;
                timer1.Stop();
                button2.Text = "开始";
            }
        }
        //退出
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            timer1.Stop();
        }
        private void 开始SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void 悔棋HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }
        private void 退出CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
        private void 暂停SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (暂停SToolStripMenuItem.Text == "暂停（&S）")
            {
                timer1.Stop();
                暂停SToolStripMenuItem.Text = "继续（&S）";
                gameover = true;
            }
            else
            {
                timer1.Start();
                暂停SToolStripMenuItem.Text = "暂停（&S）";
                gameover = false;
            }
        }
        private void 黑子先下ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            changchess(Black);
        }
        private void 白子先下ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changchess(White);
        }
        //更改选手的标志棋子
        private void comboBoxA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxA.Text == "白子") comboBoxB.Text = "黑子";
            else comboBoxB.Text = "白子";
            if (radioButtonA.Checked == true)
                changchess(comboBoxA.Text == "黑子" ? Black : White);
        }

        private void comboBoxB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxB.Text == "白子") comboBoxA.Text = "黑子";
            else comboBoxA.Text = "白子";
            if (radioButtonB.Checked == true)
                changchess(comboBoxB.Text == "黑子" ? Black : White);
        }
        //更改先手
        private void radioButtonA_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonA.Checked == true)
                changchess(comboBoxA.Text == "黑子" ? Black : White);
        }

        private void radioButtonB_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonB.Checked == true)
                changchess(comboBoxB.Text == "黑子" ? Black : White);
        }

        private void 人机模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            人机模式ToolStripMenuItem.Checked = true;
            双人模式ToolStripMenuItem.Checked = false;
            labelA.Text = "玩家：";
            labelB.Text = "电脑：";
            machine = true;
        }

        private void 双人模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            人机模式ToolStripMenuItem.Checked = false;
            双人模式ToolStripMenuItem.Checked = true;
            labelA.Text = "玩家甲";
            labelB.Text = "玩家乙";
            machine = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tree_Construct(checkerBoard, Player);
            AddChess(((Tree_Point)root[Find(root)]).P);//下子
            root.Clear();
        }




    }
}
