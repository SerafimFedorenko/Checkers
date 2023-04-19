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
        public override List<Point> GetAvailableMoves(Board board)
        {
            AvailebleMoves = new List<Point>();
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
            if(pointsToCapture.Count > 0)
            {
                AvailebleMoves.AddRange(pointsToCapture);
                CanCapture = true;
            }
            else
            {
                AvailebleMoves.AddRange(pointsToMove);
                CanCapture = false;
            }
            return AvailebleMoves;
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
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Point>>.Default.GetHashCode(AvailebleMoves);
            return hashCode;
        }
    }
}
