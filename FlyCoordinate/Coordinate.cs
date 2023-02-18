namespace FlyCoordinate;

/// <summary>
/// Coordinate structure defines the 3D coordinates of some object (positive numbers).
/// </summary>
public struct Coordinate
{
    public int X { get; private set; }
    public int Y { get; private set; }
    public int Z { get; private set; }

    public Coordinate(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public override string ToString()
    {
        return $"(X: {X}, Y: {Y}, Z: {Z})";
    }
}