namespace PopovR_GUN28_GUNPC_Memory
{
    public struct Room
    {
        public Unit Unit { get; } 
        public Weapon Weapon { get; } 

        public Room(Unit unit, Weapon weapon)
        {
            Unit = unit; 
            Weapon = weapon; 
        }
    }

    public class Dungeon
    {
        private Room[] rooms; 

        public Dungeon()
        {
            rooms = new Room[]
            {
            new Room(new Unit("Warrior", 5, 15),  new Weapon("Sword", 3, 10)),
            new Room(new Unit("Mage", 8, 20), new Weapon("Staff", 4, 12)),
            new Room(new Unit("Rogue", 6, 18), new Weapon("Dagger", 2, 8)),
            };
        }

        public void ShowRooms()
        {
            for (int i = 0; i < rooms.Length; i++)
            {
                var room = rooms[i];

                int unitDamage = room.Unit.GetRandomDamage();
                int weaponDamage = room.Weapon.GetRandomDamage();

                Console.WriteLine($"Unit of room: {room.Unit}, Random Damage: {unitDamage}");
                Console.WriteLine($"Weapon of room: {room.Weapon}, Random Damage: {weaponDamage}");
                Console.WriteLine("—");
            }
        }
    }
}
