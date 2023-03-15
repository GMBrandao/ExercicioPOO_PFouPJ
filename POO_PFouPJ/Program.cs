using POO_PFouPJ;

internal class Program
{
    private static void Main(string[] args)
    {
        Juridica juridica = new Juridica("Zezinho", "Casa dele", "123456789", "987654321", "email@email.com", 0184721007111, "GBrandao");
        Fisica fisica = new Fisica("Zezinho", "Casa dele", "123456789", "987654321", "email@email.com", 012345789456);

        Console.WriteLine(fisica.ToString());
        Console.WriteLine(juridica.ToString());
    }
}