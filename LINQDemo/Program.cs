//int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

//var querySmallNums =
//    from num in numbers
//    where num < 5
//    orderby num
//    select num;

//foreach (var num in querySmallNums)
//{
//    Console.Write(num.ToString() + " ");
//}
//// The result is 4 1 3 2 0
//Console.WriteLine("\n\n");

//// Exempel 2, Nästlade frågor
//string[] towns =
//  { "Skövde", "Västerås", "Partille", "Piteå", "Borgholm" };

//var townPairs =
//  from t1 in towns
//  from t2 in towns
//  select new { T1 = t1, T2 = t2 };

//foreach (var townPair in townPairs)
//{
//    Console.WriteLine("({0}, {1})",
//      townPair.T1, townPair.T2);
//}

//// Exempel 3, sortering
//Console.WriteLine("\n\n");
//string[] fruits =
//  { "cherry", "apple", "blueberry", "banana" };

//// Sort in ascending sort
//var fruitsAscending =
//    from fruit in fruits
//    orderby fruit descending
//    select fruit;

//foreach (string fruit in fruitsAscending)
//{
//    Console.WriteLine(fruit);
//}

string[] games = {"Morrowind", "BioShock","Half Life", "The Darkness","Daxter", "System Shock 2"};

// Build a query expression using extension methods
// granted to the Array via the Enumerable type

//var subset = games
//		.Where(game => game.Length > 6)
//		.OrderBy(game => game)
//		.Select(game => game);

var subset =
  from g in games
  where g.Length > 6
  orderby g
  select g;


foreach (var game in subset)
	Console.WriteLine(game);
Console.WriteLine();


// Räkna antalet ord i en sträng
string text = "Historically, the world of data has been full of data programmers";
string searchTerm = "data";
string[] source = text.Split(
  new char[] { '.', '?', '!', ' ', ';', ':', ',' },
  StringSplitOptions.RemoveEmptyEntries);

// Use ToLower() to match both "data" and "Data"
//var matchQuery =
//  from word in source
//  where word.ToLower() == searchTerm.ToLower()
//  select word;
//int wordCount =
//  matchQuery.Count();

int wordCount = source.Select(
  w => w.ToLower() ==
  searchTerm
  .ToLower())
	.Count(b => b);

Console.WriteLine($"Found search term in data {wordCount} times");

// Ställ frågor mot strängar
var count = "Non-letter characters in this string: 8"
  .Where(x => !Char.IsLetter(x))
  .Count();
Console.WriteLine(count);
// The result is: 8
