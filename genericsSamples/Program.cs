using genericsSamples;

PrintService<int> ps = new PrintService<int>();

Console.Write("How many values? ");
int n = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    int x = int.Parse(Console.ReadLine());
    ps.AddValue(x);
}

int a = ps.First();
int b = a + 2;
Console.WriteLine(b);

ps.Print();
Console.Write($"First: {ps.First}");