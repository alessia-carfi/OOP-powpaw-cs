using System.Numerics;

namespace PowPaw
{
    public static class WeaponFactory
    {
        private const double START_TERRAIN = 300;
        private const double END_TERRAIN = 700;
        private const double ATK_SWORD = 0.25;
        private const double ATK_HAMMER = 0.4;

        public static Weapon CreateWeapon(int id)
        {
            Random rand = new Random();
            Vector2 position = new Vector2((float)rand.NextDouble(), 200);
            Weapon weapon = new Weapon(position, id);
            switch (id)
            {
                case 0:
                    weapon = CreateSword(position, id);
                    break;
                default:
                    weapon = CreateHammer(position, id);
                    break;
            }
            return weapon;
        }

        private static Weapon CreateSword(Vector2 pos, int id)
        {
            Weapon sword = new Weapon(pos, id)
            {
                Attack = ATK_SWORD
            };
            return sword;
        }

        private static Weapon CreateHammer(Vector2 pos, int id)
        {
            Weapon hammer = new Weapon(pos, id)
            {
                Attack = ATK_HAMMER
            };
            return hammer;
        }

    }
}