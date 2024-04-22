
// string[] fruit = ("apples", "bananas", "oranges")

string[] fruit = new string[3];

fruit[0] = "aples";
fruit[1] = "banan";
fruit[2] = "mang";
Console.WriteLine($"{fruit[0]}, {fruit[1]}, {fruit[2]}");

int fruitArrayLength = fruit.Length;

Console.WriteLine($"There are {fruitArrayLength} in your array");

for (int i = 0; i < fruitArrayLength; i++)
{
    fruit[i] = fruit[i].Replace(fruit[i][0], char.ToUpper(fruit[i][0]));
}

foreach (string element in fruit) //foreach ei lase elementide sisu muuta, selleks peab for-i kasutama
{
    Console.WriteLine(element);
}