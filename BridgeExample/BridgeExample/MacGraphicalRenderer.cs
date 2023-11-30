namespace BridgeExample
{
    public class MacGraphicalRenderer : IGraphicalRenderer
    {
        public void Circle(int radius, int sector, int x, int y)
        {
            Console.WriteLine("Some MacOS circle drawing");
        }

        public void Clear()
        {
            Console.WriteLine("Some MacOS screen clearing");
        }

        public void Line(int length, int xS, int yS, int xE, int yE)
        {
            Console.WriteLine("Some MacOS line drawing");
        }

        public void Point(int x, int y)
        {
            Console.WriteLine("Some MacOS point drawing");
        }

        public void SetColor(int id)
        {
            Console.WriteLine("Some MacOS color changing");
        }

        public void SetPointer(int x, int y)
        {
            Console.WriteLine("Some MacOS pointer placing");
        }
    }
}
