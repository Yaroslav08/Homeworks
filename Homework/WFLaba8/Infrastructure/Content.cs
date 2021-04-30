using System.Drawing;

namespace WFLaba8.Infrastructure
{
    public class Content
    {
        public Content(Point position, Size size, string textBox, bool[] checkBox)
        {
            CheckBox = checkBox;
            Position = position;
            Size = size;
            TextBox = textBox;
        }
        public Content() { }

        public bool[] CheckBox { get; set; }
        public Point Position { get; set; }
        public Size Size { get; set; }
        public string TextBox { get; set; }
    }
}