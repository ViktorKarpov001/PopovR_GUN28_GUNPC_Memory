namespace PopovR_GUN28_GUNPC_Memory
{
    public class Unit
    {
        public string Name { get; }
        public Interval Damage { get; }

        public Unit(string name, int minDamage, int maxDamage)
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
}
