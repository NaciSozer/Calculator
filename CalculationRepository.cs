
public class CalculationRepository : ICalculationRepository
{
    private readonly AppDbContext _context;

    public CalculationRepository(AppDbContext context)
    {
        _context = context;
    }

    public void Add(Calculation calculation)
    {
        _context.Calculations.Add(calculation);
        _context.SaveChanges();
    }
    public List<Calculation> GetAll()
    {
        return _context.Calculations
            .OrderByDescending(c => c.Id)
            .ToList();
    }

    public void DeleteAll()
    {
        _context.Calculations.RemoveRange(_context.Calculations);
        _context.SaveChanges();
    }

}