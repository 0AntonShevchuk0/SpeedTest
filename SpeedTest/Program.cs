using System.Diagnostics;

var iterationsCount = 1000000;
List<string> stringsList = new();

Stopwatch stopwatch = new Stopwatch();
Console.WriteLine($"For loop with inner variables");
stopwatch.Start();

for (var i = 0; i < iterationsCount; i++)
{
    string newStr = $"It is {i + 1} iteration";
    stringsList.Add(newStr);
}

stopwatch.Stop();
Console.WriteLine($"Time: {stopwatch.Elapsed}");

stringsList.Clear();

Console.WriteLine($"For loop with outer variables");
stopwatch.Start();

string newStr2;
for (var i = 0; i < iterationsCount; i++)
{
    newStr2 = $"It is {i + 1} iteration";
    stringsList.Add(newStr2);
}

stopwatch.Stop();
Console.WriteLine($"Time: {stopwatch.Elapsed}");