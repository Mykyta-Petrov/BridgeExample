namespace BridgeExample
{
    public class SoftwareRenderer
    {
        // Bridge has a link to the implementation of an interface,
        // which allows to work with different implementations of an interface,
        // and hides complex actions of an interface behind "abstract" methods,
        // that call respective interface methods

        private readonly IGraphicalRenderer _renderer;

        public SoftwareRenderer(IGraphicalRenderer renderer)
        {
            _renderer = renderer;
        }

        public void DrawPolygon(int size, int length, int x, int y, int colorId)
        {
            _renderer.SetColor(colorId);
            _renderer.SetPointer(x, y);

            for (int i = 0; i < size; i++)
            {
                // some calculations
                // _renderer.Line( ... )
            }
        }

        public void DrawSymbol(int id, int x, int y, int colorId)
        {
            _renderer.SetColor(colorId);
            _renderer.SetPointer(x, y);

            // some actions
            // _renderer.Point(x, y);
            // _renderer.Line( ... )
            // _renderer.Circle( ... )
        }

        public void RenderWindow(int id)
        {
            _renderer.Clear();

            // next actions
            // _renderer.Line( ... )
        }
    }
}
