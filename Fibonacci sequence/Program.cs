int a = 0;
int b = 3;

Console.WriteLine(a);
Console.WriteLine(b);

for (int i = 2; i < 10; i++)
{
    int next = a + b;
    a = b;
    b = next;

    Console.WriteLine(next);
}

