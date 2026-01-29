//Перегрузка операций
//Вариант 33
Console.Write("Введите первое число: ");
double x = double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
double y = double.Parse(Console.ReadLine());
Money x1 = new Money(x);
Money x2 = new Money(y);
Money sum = x1 + x2;
Console.WriteLine("Сумма про сложении = " + sum.Total.ToString("F2") + " руб");
Money min = x1 - x2;
Console.WriteLine("Сумма про вычитании = " + min.Total.ToString("F2") + " руб");
Money div = x1 / x2;
Console.WriteLine("Сумма про делении = " + div.Total.ToString("F2") + " руб");
sum.Dengi();
class Money
{
    public double Total;
    public Money(double sum)
    {
        Total = sum;
    }
    public static Money operator +(Money a, Money b)
    {
        return new Money(a.Total + b.Total);
    }
    public static Money operator -(Money a, Money b)
    {
        return new Money(a.Total - b.Total);
    }
    public static Money operator /(Money a, Money b)
    {
        return new Money(a.Total / b.Total);
    }
    public void Dengi()
    {
        int[] rubl = { 5000, 1000, 500, 100, 50, 10, 5, 2, 1 };
        double[] kopi = { 0.5, 0.1, 0.05, 0.01 };
        int rubles = (int)Total;
        double kopeyki = Total - rubles;
        Console.WriteLine("Купюры:");
        foreach (int n in rubl)
        {
            int count = rubles / n;
            rubles %= n;
            if (count > 0)
                Console.WriteLine($"{n} руб - {count} шт");
        }
        Console.WriteLine("Копейки:");
        foreach (double cop in kopi)
        {
            int count = (int)(kopeyki / cop);
            kopeyki = (kopeyki % cop);

            if (count > 0)
                Console.WriteLine($"{cop.ToString("0.##")} руб - {count} шт");
        }
    }
}