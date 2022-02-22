List<int> list = new List<int>() { 1, 2, 3, 4 };

List<int> evenNumbers = list.FindAll(x => (x % 2) == 0);

foreach (var num in evenNumbers)
{
    Console.Write("{0} ", num);
}
Console.WriteLine();				// 2 4
Console.WriteLine("Removing stuff:");
list.RemoveAll(x => x > 3); 
foreach (var num in list)
{
    Console.Write("{0} ", num);
}
Console.WriteLine();    //1 2 3

// Sortering med lambdauttryck
var pets = new Pet[]
{
  new Pet { Name="Sharo", Age=8 },
  new Pet { Name="Rex", Age=4 },
  new Pet { Name="Strela", Age=1 },
  new Pet { Name="Bora", Age=3 }
};
var sortedPets = pets.OrderBy(pet => pet.Name);
foreach (Pet pet in sortedPets)
{
    Console.WriteLine("{0} -> {1}", pet.Name, pet.Age);
}

// Lambda koduttryck
List<int> lista = new List<int>()
    { 20, 1, 4, 8, 9, 44 };

// Process each argument with code statements
List<int> evenNumber = lista.FindAll(i =>
{
    Console.WriteLine("value of i is: {0}", i);
    return (i % 2) == 0;
});

Console.WriteLine("Here are your even numbers:");
foreach (int even in evenNumber)
    Console.Write("{0}\t", even);
