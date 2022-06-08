/* This is challenge work for the "C# Players Guide"
Level 24 "The Point" Challenge
Goals:
1) Create a point class to store a point in two dimensions
2) Each point is represented by an X coordinate (left/right from an origin point)
3) Each point is represented by a Y coordinate (Up/down from an origin point)
Note: Added point_3 to demonstrate that the parameterless constructor works
*/

Point point_1 = new Point(2, 3);
Point point_2 = new Point(-4,0);
Point point_3 = new Point();

Console.WriteLine($"Point 1: ({point_1.x_Coord}, {point_1.y_Coord})");
Console.WriteLine($"Point 2: ({point_2.x_Coord}, {point_2.y_Coord})");
Console.WriteLine($"Point 3: ({point_3.x_Coord}, {point_3.y_Coord})");
Console.WriteLine("Press any key to end the program");
Console.ReadKey();

public class Point
{
    public float x_Coord { get; }
    public float y_Coord { get; }

public Point(float X_Coord, float Y_Coord)
    {
        x_Coord = X_Coord;
        y_Coord = Y_Coord;
    }

public Point()
    {
        x_Coord = 0;
        y_Coord = 0;
    }
}
