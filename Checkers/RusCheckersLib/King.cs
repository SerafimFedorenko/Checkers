using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RusCheckersLib
{
    public class King : Disk
    {
        public King() : base()
        {

        }
        public King(DiskColor color, Point point) : base(color, point)
        {

        }
        public King(Disk disk)
        {
            Color = disk.Color;
            Point = disk.Point;
        }
        public List<Point> GetMoves(Board board)
        {
            AvailableMoves = new List<Point>();
            CanCapture = false;
            List<Point> pointsToMove = new List<Point>();
            List<Point> pointsToCapture = new List<Point>();
            List<Point> biases = new List<Point>()
            {
                new Point(1, 1),
                new Point(1, -1),
                new Point(-1, -1),
                new Point(-1, 1)
            };
            foreach (Point bias in biases)
            {
                int x = Point.X + bias.X;
                int y = Point.Y + bias.Y;
                while (CheckPointInBoard(x, y) && board[x, y].Disk == null)
                {
                    pointsToMove.Add(new Point(x, y));
                    x += bias.X;
                    y += bias.Y;
                }
                if (CheckPointInBoard(x, y) && board[x, y].Disk != null && board[x, y].Disk.Color != Color)
                {
                    x += bias.X;
                    y += bias.Y;
                    while (CheckPointInBoard(x, y) && board[x, y].Disk == null)
                    {
                        pointsToCapture.Add(new Point(x, y));
                        x += bias.X;
                        y += bias.Y;
                    }
                }

            }
            if (pointsToCapture.Count > 0)
            {
                AvailableMoves.AddRange(pointsToCapture);
                CanCapture = true;
            }
            else
            {
                AvailableMoves.AddRange(pointsToMove);
                CanCapture = false;
            }
            return AvailableMoves;
        }
        public override List<Point> GetAvailableMoves(Board board)
        {
            GetMoves(board);
            List<Point> capturePoints = GetCapturePoints(board);
            if(capturePoints.Count > 0 && CanCapture)
            {
                AvailableMoves = capturePoints;
            }
            return AvailableMoves;
        }
        public List<Point> GetCapturePoints(Board board)
        {
            List<Point> capturePoints = new List<Point>();
            foreach(Point point in AvailableMoves)
            {
                Board newBoard = new Board(board);

                newBoard.DoMove(Point, point);
                ((King)newBoard[point.X, point.Y].Disk).GetMoves(newBoard);
                if(newBoard[point.X, point.Y].Disk.CanCapture)
                {
                    capturePoints.Add(point);
                }
            }
            return capturePoints;
        }
        public override string ToString()
        {
            return "King " + base.ToString();
        }
        public override bool Equals(object obj)
        {
            SimpleDisk disk = (SimpleDisk)obj;
            if(disk != null)
            {
                return disk.Color == Color && disk.Point == disk.Point;
            }
            return false;
        }

        public override int GetHashCode()
        {
            int hashCode = -1565312704;
            hashCode = hashCode * -1521134295 + Color.GetHashCode();
            hashCode = hashCode * -1521134295 + Point.GetHashCode();
            hashCode = hashCode * -1521134295 + CanCapture.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Point>>.Default.GetHashCode(AvailableMoves);
            return hashCode;
        }
    }
}
