using System;

/// <summary>
/// The IFlyable interface with the FlyTo (new point), GetFlyTime (new point) methods.
/// </summary>
interface IFlyable
{
    /// <summary>
    /// FlyTo method provides the new point.
    /// </summary>
    void FlyTo(Coordinate newPoint);
    /// <summary>
    /// GetFlyTime method provides the time of flight to the new point.
    /// </summary>
    double GetFlyTime(Coordinate newPoint);
}