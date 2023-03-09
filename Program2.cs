

int sum = 0;
int counter = 0;

for (int i = 1; i <= 100; i++)
{
    counter++;
    sum = i;
}

global::System.Console.WriteLine($"Sum numbers from 1 to 100 : {sum}");
global::System.Console.ReadLine();