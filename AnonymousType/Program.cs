
var point = new { X = 3, Y = 5 };
Console.WriteLine($"point: X={point.X}, Y={point.Y}");

// Use an anonymous type representing a car
var myCar = new { Color = "Red", Brand = "BMW", Speed = 180 };

Console.WriteLine("My car is a {0} {1} with a speed of {2}.", myCar.Color, myCar.Brand, myCar.Speed);

var p = new { X = 3, Y = 5 };
var q = new { X = 3, Y = 5 };
Console.WriteLine(p == q); 			// false
Console.WriteLine(p.Equals(q)); 		// true

var arr = new[]
    {
        new { X = 3, Y = 5.0f },
        new { X = 1, Y = 2.1f },
        new { X = 0, Y = 7.345f }
    };

foreach (var item in arr)
{
    Console.WriteLine("({0}, {1})",
        item.X, item.Y);
}
