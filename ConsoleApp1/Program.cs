Console.WriteLine("Input deposit amont");
double a = Convert.ToDouble(Console.ReadLine());
double b,c;

if (a < 100)
{
    b = a * 5 / 100;
    c = a + b;
    Console.WriteLine("Your deposit amount: " +a+ "\n" +
        "Your percentage: " +b+ "\nDeposit amount with " +
        "percentage is: " +c);
}
else if ((a>=100) && (a <= 200))
{
    b = a * 7 / 100;
    c = a + b;
    Console.WriteLine("Your deposit amount: " + a + "\n" +
        "Your percentage: " +b+ "\nDeposit amount with " +
        "percentage is: " + c);
}
else if (a > 200)
{
    b = a * 10 / 100;
    c = a + b;
    Console.WriteLine("Your deposit amount: " + a + "\n" +
        "Your percentage: " +b+ "\nDeposit amount with " +
        "percentage is: " +c);
}
else
{
    Console.WriteLine("Input another deposit amont");
}