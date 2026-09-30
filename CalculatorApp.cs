public class CalculatorApp
{
    private readonly ICalculatorService _calculator;
    private readonly ICalculationRepository _repository;
    private readonly CalculatorUI _ui;

    public CalculatorApp(
        ICalculatorService calculator,
        ICalculationRepository repository,
        CalculatorUI ui)
    {
        _calculator = calculator;
        _repository = repository;
        _ui = ui;
    }

    public void Run()
    {
        Console.WriteLine("C# Calculator");
        Console.WriteLine("-------------");

        double number1 = _ui.GetNumber("Birinci");
        double number2 = _ui.GetNumber("İkinci");

        while (true)
        {
            OperationType operation = _ui.GetOperation();

            if (operation == OperationType.Exit)
            {
                _ui.ShowMessage("Programdan çıkılıyor...");
                break;
            }

            if (operation == OperationType.History)
            {
                ShowHistory();
                continue;
            }

            if (operation == OperationType.ClearHistory)
            {
                _repository.DeleteAll();

                _ui.ShowMessage("Hesaplama geçmişi temizlendi.");

                continue;
            }

            Calculate(number1, number2, operation);
        }
    }

    private void ShowHistory()
    {
        List<Calculation> history = _repository.GetAll();

        _ui.ShowHistory(history);
    }

    private void Calculate(
        double number1,
        double number2,
        OperationType operation)
    {
        try
        {
            Calculation calculation = _calculator.Calculate(
                operation,
                number1,
                number2
            );

            _repository.Add(calculation);

            _ui.ShowResult(calculation);
        }
        catch (DivideByZeroException ex)
        {
            _ui.ShowMessage(ex.Message);
        }
        catch (ArgumentException ex)
        {
            _ui.ShowMessage(ex.Message);
        }
    }
}