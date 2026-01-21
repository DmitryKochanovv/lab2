using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ЗАДАЧА 1.1: Точки ");

            Point p1 = new Point(1, 3);
            Point p2 = new Point(23, 8);
            Point p3 = new Point(5, 10);

            p1.Print();
            p2.Print();
            p3.Print();

            Console.WriteLine("\n ЗАДАЧА 1.3: Имена ");

            Name n1 = new Name(null, "Клеопатра", null);
            Name n2 = new Name("Пушкин", "Александр", "Сергеевич");
            Name n3 = new Name("Маяковский", "Владимир", null);

            n1.Print();
            n2.Print();
            n3.Print();

            Console.WriteLine("\nЗАДАЧА 2: Линии ");

            Line l1 = new Line(new Point(1, 3), new Point(23, 8));
            Line l2 = new Line(new Point(5, 10), new Point(25, 10));
            Line l3 = new Line(l1.Start, l2.End);

            l1.Print();
            l2.Print();
            l3.Print();

            // Пункт 4 — изменяем линии так чтобы изменилась и третья
            Console.WriteLine("\nизменяем линии так, чтобы изменилась и третья ");

            l1.Start.X = 100;
            l1.Start.Y = 200;

            l2.End.X = -50;
            l2.End.Y = -100;

            Console.WriteLine("После изменения :");
            l1.Print();
            l2.Print();
            l3.Print(); 

            //3 ЛИНИЮ НЕ МЕНЯЕМ
            Console.WriteLine("\nПункт 5: изменяем первую линию так, чтобы третья не изменилась");

            l1.Start = new Point(999, 999); 

            Console.WriteLine("После изменения:");
            l1.Print();
            l2.Print();
            l3.Print(); 

            Console.WriteLine("\nЗАДАЧА 3 и 4: Города");

            City A = new City("A");
            City B = new City("B");
            City C = new City("C");
            City D = new City("D");
            City E = new City("E");
            City F = new City("F");

            A.AddPath(B, 5);
            B.AddPath(A, 5);
            A.AddPath(F, 1);
            F.AddPath(B, 1);
            B.AddPath(C, 3);
            C.AddPath(B, 3);
            F.AddPath(E, 2);
            E.AddPath(F, 2);
            A.AddPath(D, 6);
            D.AddPath(A, 6);
            D.AddPath(E, 2);
            C.AddPath(D, 4);
            D.AddPath(C, 4);

            A.Print();
            B.Print();
            C.Print();
            D.Print();
            E.Print();
            F.Print();

            // Демонстрация второго конструктора,создал g и указал рёбра с весов
            Console.WriteLine("\n=== Демонстрация конструктора с путями ===");

            City G = new City("G", new Path[]
            {
                new Path(A, 10),
                new Path(B, 20),
                new Path(C, 30)
            });

            G.Print();

            Console.WriteLine("\n=== ЗАДАЧА 5: Дроби ===");

            //создаём дроби
            Fraction f1 = new Fraction(1, 3);
            Fraction f2 = new Fraction(2, 3);
            Fraction f3 = new Fraction(3, 4);

            //показываем созданные дроби
            Console.WriteLine("Созданные дроби:");
            Console.WriteLine($"f1 = {f1}");
            Console.WriteLine($"f2 = {f2}");
            Console.WriteLine($"f3 = {f3}");

            //сложени
            Fraction addF = f1.Add(f2);
            Console.WriteLine($"\n{f1} + {f2} = {addF}");

            //вычитание
            Fraction subF = f2.Sub(f1);
            Console.WriteLine($"{f2} - {f1} = {subF}");

            //умножение
            Fraction mulF = f1.Mul(f2);
            Console.WriteLine($"{f1} * {f2} = {mulF}");

            //деление
            Fraction divF = f2.Div(f3);
            Console.WriteLine($"{f2} / {f3} = {divF}");

            //примеры
            Fraction addInt = f1.Add(5);
            Console.WriteLine($"\n{f1} + 5 = {addInt}");

            Fraction subInt = f2.Sub(2);
            Console.WriteLine($"{f2} - 2 = {subInt}");

            
            Fraction mulInt = f3.Mul(3);
            Console.WriteLine($"{f3} * 3 = {mulInt}");

            
            Fraction divInt = f3.Div(2);
            Console.WriteLine($"{f3} / 2 = {divInt}");

            // ПЕРВАЯ ДРОБЬ ПЛЮС ВТОРАЯ / 3 И ВЫЧЕСТЬ 5 
            Fraction chain = f1.Add(f2).Div(f3).Sub(5);
            Console.WriteLine($"\nf1.sum(f2).div(f3).minus(5) = {chain}");
        }
    }
}
