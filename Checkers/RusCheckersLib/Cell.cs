namespace RusCheckersLib
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
