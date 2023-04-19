using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheckersLib;

namespace CheckersApp
{
    public partial class EnglishCheckersForm : Form
    {
        string[] moveStrings = { "Ход белых", "Ход чёрных" };
        string[] colorNames = { "Белые", "Чёрные" };
        Point diskPoint;
        Point selectedPoint;
        List<Point> movePoints = new List<Point>();
        DiskColor moveColor = DiskColor.White;
        PictureBox[,] pictureBoxes = new PictureBox[8, 8];
        Board board = new Board();
        public EnglishCheckersForm()
        {
            InitializeComponent();
            Icon = new Icon(Environment.CurrentDirectory + "\\pictures\\icon.ico");
            board.FillStart();
            createCells();
            fillLikeBoard();
            createEvents();
        }
        private void startGame()
        {
            board.FillStart();
            fillLikeBoard();
            diskPoint = new Point();
            selectedPoint = new Point();
            movePoints.Clear();
            moveColor = DiskColor.White;
            drawButton.Visible = true;
            askToDrawLabel.Visible = false;
            agreeButton.Visible = false;
            refuseButton.Visible = false;
            moveLabel.Text = moveStrings[1 - (int)moveColor];
        }
        private void createCells()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    PictureBox cell = null;
                    if ((j + i) % 2 == 0)
                    {
                        cell = createPictureBox(new Point(5 + i * 50, 5 + j * 50), Color.FromArgb(255, 253, 208));
                    }
                    else
                    {
                        cell = createPictureBox(new Point(5 + i * 50, 5 + j * 50), Color.FromArgb(128, 64, 48));
                    }
                    pictureBoxes[i, j] = cell;
                }
            }
        }
        private void fillCells()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if ((j + i) % 2 == 0)
                    {
                        pictureBoxes[i, j].BackColor = Color.FromArgb(255, 253, 208);
                    }
                    else
                    {
                        pictureBoxes[i, j].BackColor = Color.FromArgb(128, 64, 48);
                    }
                }
            }
        }
        private void fillLikeBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (pictureBoxes[i, j].Image != null)
                    {
                        pictureBoxes[i, j].Image.Dispose();
                        pictureBoxes[i, j].Image = null;
                    }
                    if (board[i, j].Disk != null && board[i, j].Disk.Color == DiskColor.Black)
                    {
                        SimpleDisk simpleDisk = board[i, j].Disk as SimpleDisk;
                        if (simpleDisk != null)
                        {
                            pictureBoxes[i, j].Image = Image.FromFile(Environment.CurrentDirectory + "\\pictures\\black_disk.png");
                        }
                        else
                        {
                            pictureBoxes[i, j].Image = Image.FromFile(Environment.CurrentDirectory + "\\pictures\\black_king.png");
                        }
                    }
                    else
                    {
                        if (board[i, j].Disk != null && board[i, j].Disk.Color == DiskColor.White)
                        {
                            SimpleDisk simpleDisk = board[i, j].Disk as SimpleDisk;
                            if (simpleDisk != null)
                            {
                                pictureBoxes[i, j].Image = Image.FromFile(Environment.CurrentDirectory + "\\pictures\\white_disk.png");
                            }
                            else
                            {
                                pictureBoxes[i, j].Image = Image.FromFile(Environment.CurrentDirectory + "\\pictures\\white_king.png");
                            }
                        }
                        else
                        {
                            if(pictureBoxes[i, j].Image != null)
                            {
                                pictureBoxes[i, j].Image.Dispose();
                                pictureBoxes[i, j].Image = null;
                            }
                            
                        }
                    }
                }
            }
        }

        private void createEvents()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    int x = i;
                    int y = j;
                    pictureBoxes[i, j].Click += (sender, e) =>
                    {
                        SimpleClick(new Point(x, y));
                    };
                }
            }
        }
        private void SimpleClick(Point position)
        {
            fillCells();
            selectedPoint = position;
            pictureBoxes[position.X, position.Y].BackColor = Color.Green;
            if (board[position.X, position.Y].Disk != null && board[position.X, position.Y].Disk.Color == moveColor)
            {
                if(!board[position.X, position.Y].Disk.MayCapture(board))
                {
                    movePoints = board[position.X, position.Y].Disk.GetAvailableMoves(board);
                    foreach (Point point in movePoints)
                    {
                        diskPoint = position;
                        //костыль которого быть не должно
                        if (board[point.X, point.Y].Disk == null)
                        {
                            pictureBoxes[point.X, point.Y].BackColor = Color.Gray;
                        }
                    }
                }
                else
                {
                    if(board[position.X, position.Y].Disk.MayCapture(board) && board[position.X, position.Y].Disk.CanCapture)
                    {
                        movePoints = board[position.X, position.Y].Disk.GetAvailableMoves(board);
                        foreach (Point point in movePoints)
                        {
                            diskPoint = position;
                            //костыль которого быть не должно
                            if (board[point.X, point.Y].Disk == null)
                            {
                                pictureBoxes[point.X, point.Y].BackColor = Color.Gray;
                            }
                        }
                    }
                }
            }
            else
            {
                if (movePoints.Contains(selectedPoint))
                {
                    board.DoMove(diskPoint, selectedPoint);
                    powerTransmission();
                    fillLikeBoard();
                    fillCells();
                    if (!board.CanMove(moveColor))
                    {
                        MessageBox.Show(colorNames[(int)moveColor] + " победили!");
                        startGame();
                    }
                    else
                    {
                        drawButton.Visible = true;
                    }
                }
                movePoints.Clear();
            }
        }

        private PictureBox createPictureBox(Point point, Color color)
        {
            return new PictureBox
            {
                Height = 50,
                Width = 50,
                Location = point,
                Parent = this,
                Visible = true,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = color,
                SizeMode = PictureBoxSizeMode.Zoom
            };
        }
        private void powerTransmission()
        {
            moveColor = (DiskColor)(1 - (int)moveColor);
            board.Expand();
            moveLabel.Text = moveStrings[1 - (int)moveColor];
        }
        private void agreeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ничья!");
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                pictureBox.Visible = true;
            }
            startGame();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            powerTransmission();
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                pictureBox.Visible = false;
            }
            drawButton.Visible = false;
            askToDrawLabel.Visible = true;
            agreeButton.Visible = true;
            refuseButton.Visible = true;
        }

        private void refuseButton_Click(object sender, EventArgs e)
        {

            askToDrawLabel.Visible = false;
            agreeButton.Visible = false;
            refuseButton.Visible = false;
            powerTransmission();
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                pictureBox.Visible = true;
            }
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            Point[,] locations = new Point[8,8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    locations[i, j] = new Point(5 + i * 50, 5 + j * 50);
                }
            }
            for (int i = 0;i < 8;i++)
            {
                for(int j = 0;j < 8;j++)
                {
                    pictureBoxes[i, j].Location = 
                        new Point(
                            (locations[i, j].X) * Size.Width / 600, 
                            (locations[i, j].Y) * Size.Height / 450
                            );
                    pictureBoxes[i, j].Width = 50 * Size.Width / 600;
                    pictureBoxes[i, j].Height = 50 * Size.Height / 450;
                }
            }
            drawButton.Location =
                new Point(
                    441 * Size.Width / 600,
                    236 * Size.Height / 450
                    );
            agreeButton.Location =
                new Point(
                    441 * Size.Width / 600,
                    312 * Size.Height / 450
                    );
            refuseButton.Location =
                new Point(
                    441 * Size.Width / 600,
                    341 * Size.Height / 450
                    );
            moveLabel.Location =
                new Point(
                    464 * Size.Width / 600,
                    45 * Size.Height / 450
                    );
            askToDrawLabel.Location =
                new Point(
                    415 * Size.Width / 600,
                    296 * Size.Height / 450
                    );
        }
    }
}
