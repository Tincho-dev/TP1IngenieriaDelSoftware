using TP1IngenieriaDelSoftware.Model;

namespace ModelTesting
{
    public class ColorTesting
    {
        private readonly Color _color = new("123abc","Fucsia");
        public ColorTesting() { }

        [Fact]
        public void Test1()
        {
            //_color;
        }
    }
}