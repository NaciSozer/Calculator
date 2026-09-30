public class CalculatorService : ICalculatorService
{
    public Calculation Add(double number1, double number2)
    {
        double result = number1 + number2;
        return CreateCalculation(number1, number2, "+", result);
    }

    public Calculation Subtract(double number1, double number2)
    {
        double result = number1 - number2;
        return CreateCalculation(number1, number2, "-", result);
    }

    public Calculation Multiply(double number1, double number2)
    {
        double result = number1 * number2;
        return CreateCalculation(number1, number2, "*", result);
    }

    public Calculation Divide(double number1, double number2)
    {
        if (number2 == 0)
        {
            throw new DivideByZeroException(
                "Bir sayı sıfıra bölünemez!"
            );
        }

        double result = number1 / number2;
        return CreateCalculation(number1, number2, "/", result);
    }

    public Calculation Calculate(
        OperationType operation,
        double number1,
        double number2)
    {
        switch (operation)
        {
            case OperationType.Add:
                return Add(number1, number2);

            case OperationType.Subtract:
                return Subtract(number1, number2);

            case OperationType.Multiply:
                return Multiply(number1, number2);

            case OperationType.Divide:
                return Divide(number1, number2);

            default:
                throw new ArgumentException("Geçersiz işlem.");
        }
    }

    private Calculation CreateCalculation(
        double number1,
        double number2,
        string operation,
        double result)
    {
        return new Calculation
        {
            Number1 = number1,
            Number2 = number2,
            Operation = operation,
            Result = result
        };
    }
}