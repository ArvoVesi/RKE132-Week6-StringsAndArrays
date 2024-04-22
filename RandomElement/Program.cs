string[] snacks = { "pits", "sush", "kanep", "leb"};

Random rnd = new Random();

int randomIndex = rnd.Next(0, snacks.Length);

Console.WriteLine($"Tonight we are going eat {randomIndex}");