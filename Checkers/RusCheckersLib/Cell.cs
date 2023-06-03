namespace RusCheckersLib
{
    public class Cell
    {
        public Disk Disk { get; set; } = null;
        public Cell()
        {
        }
        public Cell(Cell cell)
        {
            if(cell.Disk is SimpleDisk)
            {
                Disk = new SimpleDisk(cell.Disk);
            }
            else
            {
                if (cell.Disk is King)
                {
                    Disk = new King(cell.Disk);
                }
                else
                {
                    Disk = null;
                }
            }

            
        }
        public override string ToString()
        {
            if (Disk == null)
                return "Empty";
            return Disk.ToString();
        }
    }
}
