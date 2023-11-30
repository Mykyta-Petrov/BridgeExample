namespace BridgeExample
{
    public class WindowsGraphicalRenderer : IGraphicalRenderer
    {
        public void Circle(int radius, int sector, int x, int y)
        {
            Console.WriteLine("Some Windows circle drawing");
        }

        public void Clear()
        {
            Console.WriteLine("Some Windows screen clearing");
        }

        public void Line(int length, int xS, int yS, int xE, int yE)
        {
            Console.WriteLine("Some Windows line drawing");
        }

        public void Point(int x, int y)
        {
            Console.WriteLine("Some Windows point drawing");
        }

        public void SetColor(int id)
        {
            Console.WriteLine("Some Windows color changing");
        }

        public void SetPointer(int x, int y)
        {
            Console.WriteLine("Some Windows pointer placing");
        }
    }
}
