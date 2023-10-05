Console.Write("Введите число ");
int valte = Convert.ToInt32(Console.ReadLine());
int foo(int valte)
{
    int result = 0;
    while(valte>0)
    {
        result += valte %10;
        valte = valte/10;
    }
    return result;
}

int result = foo(valte);
Console.WriteLine(result);