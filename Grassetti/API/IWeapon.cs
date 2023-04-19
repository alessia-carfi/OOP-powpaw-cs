using System.Numerics;

namespace PowPaw
{
    public interface IWeapon
    {
        Vector2 Position { get; }
        double Attack { get; set; }
        int Durability { get; }
        void DecrementDurability();
        void ResetDurability();
        int Id { get; }
        bool IsPicked { get; set; }
        bool GetIsVisible();
        void AddAttack(double ps);
        void SetVisible(bool b);
    }
}