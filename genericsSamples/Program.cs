using genericsSamples;

PrintServiceString ps = new PrintServiceString();

Console.Write("How many values? ");
int n = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    string x = Console.ReadLine();
    ps.AddValue(x);
}
ps.Print();
Console.Write($"First: {ps.First}");