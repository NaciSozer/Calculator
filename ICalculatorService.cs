
public interface ICalculatorService
{
    Calculation Calculate(
        OperationType operation,
        double number1,
        double number2
    );
}

public interface ICalculationRepository
{
    void Add(Calculation calculation);

    List<Calculation> GetAll();

    void DeleteAll();
}