using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersLib
{
    public class Cell
    {
        public Disk Disk { get; set; } = null;
        public Cell()
        {
        }
        public override string ToString()
        {
            if (Disk == null)
                return "Empty";
            return Disk.ToString();
        }
    }
}
