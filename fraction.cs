namespace lab2
    {
        class Fraction
        {

            //свойства числитель,знаменатель
            public int Num { get; set; }
            public int Del { get; set; }

            //в конструкторе если знаменатель дроби 0 ,ставим 1
            public Fraction(int num, int del)
            {
                Num = num;
                Del = del == 0 ? 1 : del;
            }

            public override string ToString()
            {
                return $"{Num}/{Del}";
            }

            public void Print()
            {
                Console.WriteLine(ToString());
            }

            //сложение дробей,чтобы внести под единый знаменатель,домножаем a/b + c/d = (ad+bc)/bd
            public Fraction Add(Fraction f)
            {
                return new Fraction(Num * f.Del + f.Num * Del, Del * f.Del);
            }

            //вычитание дробей a/b - c/d = (ad - bc)/bd
            public Fraction Sub(Fraction f)
            {
                return new Fraction(Num * f.Del - f.Num * Del, Del * f.Del);
            }

            //умножение дробей a/b * c/d = (ac)/(bd)
            public Fraction Mul(Fraction f)
            {
                return new Fraction(Num * f.Num, Del * f.Del);
            }

            //деление дробей a/b ÷ c/d = (a*d)/(b*c)
            public Fraction Div(Fraction f)
            {
                return new Fraction(Num * f.Del, Del * f.Num);
            }

            //операции с целым числом: x = x/1
            public Fraction Add(int x) => Add(new Fraction(x, 1));
            public Fraction Sub(int x) => Sub(new Fraction(x, 1));
            public Fraction Mul(int x) => Mul(new Fraction(x, 1));
            public Fraction Div(int x) => Div(new Fraction(x, 1));

        }
}
