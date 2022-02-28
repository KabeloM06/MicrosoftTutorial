// Combine branches example

// initialise sum 
int sum = 0;

// create loop to incriment counter
for (int index = 1; index < 21 ; index++)
{
    // check if counter value is divisible by 3
    if (index % 3 == 0)
    {
        sum = sum + index;
        Console.WriteLine($"{index} is divisible by 3, so sum is {sum}");
    }
    else
    {
        Console.WriteLine($"{index} is not divisible by 3");
    }
}


// Lists
var names = new List<string> { "Kabelo", "Tebogo", "Nadi"};

names.Add("Lauren");
names.Add("Lindiwe");
//names.Remove("Kabelo");

names.Sort();
foreach (string name in names)
{
    Console.WriteLine($"Hello. I am {name}");
}

// fibonacci numbers
var fibonacciNumbers = new List<int> { 1, 1 };

Console.WriteLine($"Fibonacci sequence is {fibonacciNumbers[0]}");
Console.WriteLine($"Fibonacci sequence is {fibonacciNumbers[1]}");

while (fibonacciNumbers.Count < 20)
{
    var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
    var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

    fibonacciNumbers.Add(previous + previous2);

    Console.WriteLine($"Fibonacci sequence is {fibonacciNumbers[fibonacciNumbers.Count - 1]}");

}
