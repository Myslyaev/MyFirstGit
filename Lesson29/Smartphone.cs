namespace Lesson29
{
    public class Smartphone : BaseProduct
    {
        public int Camera { get; set; }
        public Smartphone(string title, string manufacturer, int memory, int display, int price, int camera) : base(title, manufacturer, memory, display, price)
        {
            Camera = camera;
        }
    }
}
