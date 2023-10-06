using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CheckersLib
{
    public class Board
    {
        private Cell[,] cells = new Cell[8,8];
        public Board()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    cells[i,j] = new Cell();
                }
            }
        }
        public Cell this[int x,int y]
        {
            get { return cells[x,y]; }
            set { cells[x,y] = value; }
        }
        public void DoMove(Point oldPosition, Point newPosition)
        {
            //cells[newPosition.X, newPosition.Y].Disk =
            //    new SimpleDisk(cells[oldPosition.X, oldPosition.Y].Disk.Color, newPosition);
            
            
            if (newPosition.Y == 0)
            {
                cells[newPosition.X, newPosition.Y].Disk = new King(cells[oldPosition.X, oldPosition.Y].Disk);
            }
            else
            {
                cells[newPosition.X, newPosition.Y].Disk = cells[oldPosition.X, oldPosition.Y].Disk;
            }
            cells[newPosition.X, newPosition.Y].Disk.Point = newPosition;
            cells[oldPosition.X, oldPosition.Y].Disk = null;
            if (newPosition.X > oldPosition.X + 1 || newPosition.X < oldPosition.X - 1)
            {
                cells[(newPosition.X + oldPosition.X) / 2, (newPosition.Y + oldPosition.Y) / 2].Disk = null;
            }
        }
        public void Expand()
        {
            Board board = new Board();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    board[7 - i, 7 - j].Disk = cells[i, j].Disk;
                    if(cells[i, j].Disk != null)
                    {
                        board[7 - i, 7 - j].Disk.Point =
                            new Point(
                                7 - cells[i, j].Disk.Point.X,
                                7 - cells[i, j].Disk.Point.Y
                                );
                    }

                }
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    cells[i, j].Disk = board[i, j].Disk;
                }
            }
        }
        public void FillStart()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if((i + j) % 2 == 1)
                    {
                        if (j < 3)
                        {
                            cells[i, j].Disk = new SimpleDisk(DiskColor.Black, new Point(i, j));
                        }
                        else
                        {
                            if (j > 4)
                            {
                                cells[i, j].Disk = new SimpleDisk(DiskColor.White, new Point(i, j));
                            }
                            else
                            {
                                cells[i, j].Disk = null;
                            }
                        }
                    }
                }
            }
        }
        public bool CanMove(DiskColor color)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if(cells[i, j].Disk != null &&
                       cells[i, j].Disk.Color == color)
                    {
                        List<Point> points = cells[i, j].Disk.GetAvailableMoves(this);
                        if(points.Count > 0)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public int GetDisksNumber()
        {
            int disksNumber = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (cells[i, j].Disk != null)
                    {
                        disksNumber++;
                    }
                }
            }
            return disksNumber;
        }
    }
}
