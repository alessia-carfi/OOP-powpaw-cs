namespace PowPaw
{
    public interface Weapon {

        Vector2 getPosition();

        void update();

        void setAttack(double attack);

        int getDurability();

        void decrementDurability();

        void resetDurability();

        int getId();

        boolean isPicked();

        void setPicked(boolean isPicked);

        void addAttack(PlayerStats ps);

        void setVisible(boolean b);

        boolean isVisible();

    }
}
