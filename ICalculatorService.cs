
public interface ICalculatorService
{
    Calculation Calculate(
        OperationType operation,
        double number1,
        double number2
    );
}

