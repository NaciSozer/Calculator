
public class CalculatorUI
{
    public double GetNumber(string numberName)
    {
        while (true)
        {
            Console.Write($"{numberName} sayıyı girin: ");

            if (double.TryParse(Console.ReadLine(), out double number))
            {
                return number;
            }

            Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
        }
    }

    public OperationType GetOperation()
{
    while (true)
    {
        Console.WriteLine();
        Console.WriteLine("1 - Toplama");
        Console.WriteLine("2 - Çıkartma");
        Console.WriteLine("3 - Çarpma");
        Console.WriteLine("4 - Bölme");
        Console.WriteLine("5 - Geçmiş");
        Console.WriteLine("6 - Geçmişi Temizle");
        Console.WriteLine("0 - Çıkış");
        Console.Write("Seçiminiz: ");

        if (int.TryParse(Console.ReadLine(), out int operation))
        {
            if (operation >= 0 && operation <= 6)
            {
                return (OperationType)operation;
            }
        }

        Console.WriteLine(
            "Geçersiz giriş, lütfen 0-6 arasında bir seçim yapınız."
        );
    }
}

    public void ShowResult(Calculation calculation)
    {
        Console.WriteLine(
            $"Sonuç: {calculation.Result}"
        );
    }

    public void ShowHistory(List<Calculation> calculations)
    {
        Console.WriteLine();
        Console.WriteLine("--- Hesaplama Geçmişi ---");

        if (calculations.Count == 0)
        {
            Console.WriteLine("Henüz hesaplama geçmişi bulunmuyor.");
            return;
        }

        foreach (Calculation calculation in calculations)
        {
            Console.WriteLine(
                $"{calculation.Number1} {calculation.Operation} " +
                $"{calculation.Number2} = {calculation.Result}"
            );
        }
    }

    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
}