public interface ICalculationRepository
{
    void Add(Calculation calculation);
    List<Calculation> GetAll();
    void DeleteAll();
}