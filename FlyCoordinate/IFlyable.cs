namespace FlyCoordinate;

public interface IFlyable
{
    void FlyTo(Coordinate newPoint);
    double GetFlyTime();
}