
Console.WriteLine("World".SayHello());
Console.WriteLine("Dolly".SayHello());

public static class ExtensionMethods
{
    public static string SayHello(this string str)
    {
        return string.Concat("Hello, ", str, "!");
    }
}