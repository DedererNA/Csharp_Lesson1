int a = Convert.ToInt32(Console.ReadLine());
int b = 1;
while (b<a)
{
    b++;
    if (b%2==0)
    {
        Console.Write(b);
        if (b<a)
        {
            Console.Write(", ");
        }
    }
}