// РЁБРА ГРАФА ГОРОД

namespace lab2
{
    class Path
    {
        public City Target { get; set; }
        public int Cost { get; set; }

        public Path(City target, int cost)
        {
            Target = target;
            Cost = cost;

        }

        public override string ToString()
        {
            return $"{Target.Name}:{Cost}";
        }

    }
}


