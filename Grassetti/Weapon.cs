using System.Numerics;

namespace PowPaw
{
    public class Weapon : IWeapon
    {
        public const double WIDTH = 200;
        public const double HEIGHT = 200;
        public const int MAX_DURABILITY = 10;

        private Vector2 position;
        private double attack;
        private bool isVisible = true;
        private int id;
        private int durability = MAX_DURABILITY;
        private bool isPicked;

        //property definition
        public Vector2 Position => position;
        public double Attack
        {
            get => attack;
            set => attack = value;
        }
        public int Durability => durability;
        public void DecrementDurability() => durability--;
        public void ResetDurability() => durability = MAX_DURABILITY;
        public int Id => id;
        public bool IsPicked
        {
            get => isPicked;
            set => isPicked = value;
        }
        public bool GetIsVisible() => isVisible;

        //costructor
        public Weapon(Vector2 position, int id)
        {
            this.position = position;
            this.id = id;
        }

        public void AddAttack(double ps)
        {
            double oldAttack = ps;
            ps = oldAttack + attack;
            if (durability == 0)
            {
                ps = oldAttack;
            }
        }

        public void SetVisible(bool b)
        {
            isVisible = b;
        }

    }
}