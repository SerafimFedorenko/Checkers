using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CheckersLib
{
    public class SimpleDisk : Disk
    {
        public SimpleDisk() : base()
        {

        }
        public SimpleDisk(DiskColor color, Point point) : base(color, point)
        {

        }
        public override List<Point> GetAvailableMoves(Board board)
        {
            AvailebleMoves = new List<Point>();
            List<Point> moves = new List<Point>() 
            { 
                new Point(Point.X - 1, Point.Y - 1),
                new Point(Point.X - 2, Point.Y - 2),
                new Point(Point.X + 1, Point.Y - 1),
                new Point(Point.X + 2, Point.Y - 2)
            };
            CanCapture = false;
            for (int i = 0;i < moves.Count;i += 2)
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
            return "Simple disk " + base.ToString();
        }
    }
}
