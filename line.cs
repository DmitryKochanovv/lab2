namespace lab2
{
    class Line
    {
        //композиция объекты класс Point
        public Point Start { get; set; }
        public Point End { get; set; }
        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }

        public override string ToString()
        {
            return $"ЛИНИЯ ОТ {Start.ToString()} ДО {End.ToString()}";
        }
        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }
}