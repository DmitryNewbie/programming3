int[] number =new int[8];


for(int i = 0; i < number.Length; i++)
{
    number[i] =new Random().Next(1,99);
    Console.Write(" "+ Method (i) + " ");
}

int Method(int a)
{
    return number[a];
}