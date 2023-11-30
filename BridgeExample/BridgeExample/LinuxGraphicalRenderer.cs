namespace BridgeExample
{
    public class LinuxGraphicalRenderer : IGraphicalRenderer
    {
        public void Circle(int radius, int sector, int x, int y)
        {
            Console.WriteLine("Some Linux circle drawing");
        }

        public void Clear()
        {
            Console.WriteLine("Some Linux screen clearing");
        }

        public void Line(int length, int xS, int yS, int xE, int yE)
        {
            Console.WriteLine("Some Linux line drawing");
        }

        public void Point(int x, int y)
        {
            Console.WriteLine("Some Linux point drawing");
        }

        public void SetColor(int id)
        {
            Console.WriteLine("Some Linux color changing");
        }

        public void SetPointer(int x, int y)
        {
            Console.WriteLine("Some Linux pointer placing");
        }
    }
}
