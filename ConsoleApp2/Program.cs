int number1 = 0;
int number2 = 0;
int som = number1 + number2;
while (som < 50)
{
    Console.Write("Number 1 : ");
    number1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Number 2 : ");
    number2 = Convert.ToInt32(Console.ReadLine());

    int answer = ggd(number1, number2);
    Console.WriteLine("Result: " + answer);

    som = number1 + number2;
    if (som < 40)
    {
        Console.WriteLine("Again ? ( Y or y ) : Y");
    }
    else if (som >= 40 && som < 50)
    {
        Console.WriteLine("Again ? ( Y or y ) : y");
    }
    else if (som >= 50)
    {
        Console.WriteLine("Again ? ( Y or y ) : n");
        
    }
    static int ggd(int n1, int n2)
    {
        if (n2 == 0)
        {
            return n1;
        }
        else
        {
            return ggd(n2, n1 % n2);
        }
    }
}
Console.ReadLine();