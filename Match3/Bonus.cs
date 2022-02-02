using System.Windows.Media;

namespace Match3
{
    public class Bonus : Tile
    {
        private int _top;
        private int _left;

        public Color Color { get; }

        public int Top
        {
            get => _top;
            set => _top = value;
        }

        public int Left
        {
            get => _left;
            set => _left = value;
        }

        public BonusShape Shape { get; }

        public bool Line { get; set; }
        public bool Bomb { get; set; }
        public bool Selected { get; set; }
        public Bonus(int top, int left, Color color) : base (top, left, color)
        {
            Top = top;
            Left = left;
            Color = color;
            Shape = new BonusShape
            {
                Fill = new SolidColorBrush(color),
                Stroke = new SolidColorBrush(Colors.Black),
                StrokeThickness = 2.0,
                Tag = this
            };
        }
    }
}
