static bool isPowerOfTwo(int n)
{
    if (n == 0)
        return false;

    while (n > 1)
    {
        if (n % 2 != 0)
            return false;

        n = n / 2;
    }
    return true;
}
Console.WriteLine("reqem daxil edin");
int sayi = int.Parse(Console.ReadLine());

  
