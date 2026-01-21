namespace lab2
{
    class City
    {
        public string Name {  get; set; }
        public Path[] Paths { get; set; }

        //2 конструктора,создаёт город только по названию
        public City(string name)
        {
            Name = name;
            Paths = new Path[0];
        }


        //создаёт город с названием и готовым набором путей в графе
        public City(string name, Path[] paths)
        {
            Name = name;
            Paths = paths;
        }

        
        //метод добавляет путь из текущего города в другой,конечная точка и вес графа
        //создаём новый массив на 1 индекс больше и копируем туда старые элементы + 1,заменяем старый мас новым
        public void AddPath(City target,int cost)
        {
            Path[] newArr = new Path[Paths.Length + 1];
            for(int i =0;i < Paths.Length;i++)
                newArr[i] = Paths[i];
            newArr[Paths.Length] = new Path(target, cost);
            Paths = newArr;
        }
        public string ToString()
        {
            string result = Name;
            if(Paths.Length > 0)
            {
                result += " ---> ";
                for(int i = 0; i < Paths.Length; i++)
                {
                    result += Paths[i].ToString();
                    if(i< Paths.Length-1)
                        result += ", ";
                }
            }
            return result;
        }
        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }
}