namespace lab1.Models;

public class Purchase
{
    public int Id { get; set; }
    public DateTime dateTime { get; set; }
    public State state { get; set; }
}

public enum State
{
    Pending,
    Paid,
    sent,
    Delivered,
    Closed,
}
