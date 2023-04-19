using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersLib
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
            List<Point> moves = new List<Point>()
            {
                new Point(Point.X - 1, Point.Y - 1),
                new Point(Point.X - 2, Point.Y - 2),
                new Point(Point.X + 1, Point.Y - 1),
                new Point(Point.X + 2, Point.Y - 2),
                new Point(Point.X + 1, Point.Y + 1),
                new Point(Point.X + 2, Point.Y + 2),
                new Point(Point.X - 1, Point.Y + 1),
                new Point(Point.X - 2, Point.Y + 2)

            };
            CanCapture = false;
            for (int i = 0; i < moves.Count; i += 2)
            {
                if (CheckPointInBoard(moves[i].X, moves[i].Y))
                {
                    if (CheckPointInBoard(moves[i + 1].X, moves[i + 1].Y) &&
                        board[moves[i].X, moves[i].Y].Disk != null &&
                        board[moves[i].X, moves[i].Y].Disk.Color != Color &&
                        board[moves[i + 1].X, moves[i + 1].Y].Disk == null)
                    {
                        AvailebleMoves.Add(new Point(moves[i + 1].X, moves[i + 1].Y));
                        CanCapture = true;
                    }
                    else
                    {
                        if (board[moves[i].X, moves[i].Y].Disk == null)
                        {
                            AvailebleMoves.Add(new Point(moves[i].X, moves[i].Y));
                        }
                    }
                }
            }
            if (CanCapture)
            {
                for (int i = 0; i < moves.Count; i += 2)
                {
                    AvailebleMoves.Remove(moves[i]);
                }
            }
            return AvailebleMoves;
        }
        public override string ToString()
        {
            return "King " + base.ToString();
        }
    }
}
