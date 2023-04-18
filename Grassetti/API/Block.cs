namespace PowPaw
{
    public interface Block
    {
        Vector2 getPosition();

        void setX(double x);

        void setY(double y);

        double getWidth();

        void setWidth(double width);

        double getHeight();

        void setHeight(double height);
    }   
}