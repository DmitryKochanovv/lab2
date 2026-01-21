namespace lab2
{
    class Point
    {

        //свойства
        public double X { get; set; }
        public double Y { get; set; }

        //Конструктор с параметрами
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }


        //объект в строку
        public override string ToString()
        {
            return $"{{{X};{Y}}}";
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }
}
