namespace PopovR_GUN28_GUNPC_Memory
{
    public class Weapon
    {
        public string Name { get; }
        public Interval Damage { get; }

        public Weapon(string name, int minDamage, int maxDamage)
        {
            Name = name;
            Damage = new Interval(minDamage, maxDamage);
        }

        public int GetRandomDamage()
        {
            return Damage.Get();
        }

        public override string ToString()
        {
            return $"{Name}, Damage: {Damage.Min} - {Damage.Max}";
        }
    }

    public struct Interval
    {
        private Random random;
        private int minValue;
        private int maxValue;

        public int Min => minValue;
        public int Max => maxValue;

        public Interval(int minValue, int maxValue)
        {
            this.random = new Random();

            if (minValue < 0 || maxValue < 0)
            {
                Console.WriteLine("Некорректные входные данные: отрицательные значения заменены на 0.");
                this.minValue = Math.Max(minValue, 0);
                this.maxValue = Math.Max(maxValue, 0);
            }
            else if (minValue > maxValue)
            {
                Console.WriteLine("Некорректные входные данные: значения поменяны местами.");
                this.minValue = maxValue;
                this.maxValue = minValue;
            }
            else if (minValue == maxValue)
            {
                Console.WriteLine("Некорректные входные данные: максимальное значение увеличено на 10.");
                this.minValue = minValue;
                this.maxValue = maxValue + 10;
            }
            else
            {
                this.minValue = minValue;
                this.maxValue = maxValue;
            }
        }

        public int Get()
        {
            return random.Next(minValue, maxValue + 1);
        }
    }
}
