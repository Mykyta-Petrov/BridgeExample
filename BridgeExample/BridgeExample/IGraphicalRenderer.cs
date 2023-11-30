namespace BridgeExample
{
    public interface IGraphicalRenderer
    {
        void SetPointer(int x, int y);

        void Line(int length, int xS, int yS, int xE, int yE);

        void Circle(int radius, int sector, int x, int y);

        void Point(int x, int y);

        void SetColor(int id);

        void Clear();
    }
}
