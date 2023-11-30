namespace BridgeExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SoftwareRenderer software = new SoftwareRenderer(new WindowsGraphicalRenderer());
            software.RenderWindow(1);
            software.DrawSymbol(45, 5, 5, 1);
            software.DrawSymbol(32, 10, 5, 1);
            software.DrawSymbol(23, 15, 5, 1);
            software.DrawSymbol(2, 20, 5, 1);
            software.DrawPolygon(5, 100, 200, 200, 3);
        }
    }
}