using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LabirintWalker
{
    public partial class Form1 : Form
    {
        public enum PType { wall, free, finish }//полезно разделять точки трёх типов 
        private Point lastLocation;
        private Bitmap image;
        private Graphics graphics;
        private Pen dot;
        private Pathel[,] map;
        private List<Pathel>edge = new List<Pathel>();
        private int clicked;// 2 - выбирается конечная точка, 1 - начальная, 0 - всё выбрали
        private double k_x = 1, k_y = 1; //коэффиценты сжатия картинки 
        private bool found = false, uploaded = false;
        private long n;

        public Form1()
        {
            InitializeComponent();
            image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(image);
            graphics.Clear(Color.White);
            dot = new Pen(Color.Red, 100);
            pictureBox1.Image = image;
        }

        public void Preparation()
        {
            uploaded = true;
            clicked = 2;
            k_x = Convert.ToDouble(image.Width) / Convert.ToDouble(pictureBox1.Width);
            k_y = Convert.ToDouble(image.Height) / Convert.ToDouble(pictureBox1.Height);
            edge.Clear();
            found = false;
            Recoloring();
            pictureBox1.Image = image;
            sign.Text = "Укажите конечную точку";
        }

        public void Recoloring()
        {
            map = new Pathel[image.Width, image.Height];
            for (int j = 0; j < image.Height; j++)
            {
                for (int i = 0; i < image.Width; i++)
                {
                    int r = image.GetPixel(i, j).R;
                    int g = image.GetPixel(i, j).G;
                    int b = image.GetPixel(i, j).B;
                    if ((r + g + b) / 3 <= 220 || image.GetPixel(i,j).Equals(Color.DarkCyan))
                    {
                        map[i,j]=new Pathel(i, j, i, j, PType.wall);
                        image.SetPixel(i, j, Color.DarkCyan);
                    }
                    else
                    {
                        map[i, j] = new Pathel(i, j, i, j, PType.free);
                        image.SetPixel(i, j, Color.White);
                    }
                }
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (uploaded)
            {
                int X = Convert.ToInt32(e.X * k_x), Y = Convert.ToInt32(e.Y * k_y);
                if (clicked == 2)
                {
                    clicked--;
                    map[X, Y].Type = PType.finish;
                    graphics.DrawRectangle(dot,X,Y,dot.Width, dot.Width);
                    pictureBox1.Image = image;
                    sign.Text = "Укажите точку старта";
                }
                else if (clicked == 1)
                {
                    clicked--;
                    map[X, Y].Type = PType.wall;
                    map[X, Y].X_ = -1;
                    map[X, Y].Y_ = -1;
                    edge.Add(map[X, Y]);
                    startButton.Enabled = true;
                    startButton.BackColor = SystemColors.GradientActiveCaption;
                    startButton.ForeColor = SystemColors.ControlText;
                    n = 0;
                    sign.Text = "Начните поиск";
                }                
            }
        }

        public void Rec()
        {
            n++;
            if (n < 4200 && edge.Count > 0)
            {
                if (!found)
                {
                    foreach (Pathel path in edge.ToArray())
                    {
                        int x = path.X, y = path.Y;
                        if (x >= 1 && x < image.Width - 1 && y >= 1 && y < image.Height - 1)
                        {
                            edge.Remove(map[x, y]);
                            for (int i = -1; i <= 1; i++)
                            {
                                for (int j = -1; j <= 1; j++)
                                {
                                    switch (map[x + i, y + j].Type)
                                    {
                                        case PType.finish:
                                            found = true;
                                            map[x + i, y + j].Type = PType.wall;
                                            DrawPath(x, y);
                                            break;
                                        case PType.free:
                                            map[x + i, y + j].Type = PType.wall;
                                            map[x + i, y + j].X_ = x;
                                            map[x + i, y + j].Y_ = y;
                                            edge.Add(map[x + i, y + j]);
                                            break;
                                        default:
                                            break;
                                    }
                                }
                            }
                        }
                    }
                    Rec();
                }
            }
            else
            {
                MessageBox.Show("Путь либо невозможный, либо слишком длинный\nПопробуйте указать снова");
                Preparation();
            }
        }

        public void DrawPath(int x, int y)
        {
            if (x != -1 && y != -1)
            {
                image.SetPixel(x, y, Color.Red);
                DrawPath(map[x,y].X_, map[x,y].Y_);
            }

            sign.Text = "Готово";
            pictureBox1.Image = image;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            image = new Bitmap(openFileDialog1.FileName);
            Preparation();
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            sign.Text = "Думаю";
            startButton.Enabled = false;
            startButton.BackColor = Color.FromArgb(64,64,64);
            startButton.ForeColor = Color.Silver;
            Rec();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastLocation.X;
                this.Top += e.Y - lastLocation.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastLocation = new Point(e.X, e.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {        
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }
    }
}
