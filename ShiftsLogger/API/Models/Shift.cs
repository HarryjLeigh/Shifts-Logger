namespace ShiftsLogger.API.Models;

public class Shift
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int Hours { get; set; }
    public int AmountOfTime { get; set; }
}