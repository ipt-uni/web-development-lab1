namespace lab1.Models;

/// <summary>
/// Represents a purchase transaction in the system.
/// </summary>
public class Purchase
{
    public int Id { get; set; }
    public DateTime dateTime { get; set; }
    public State state { get; set; }
}

/// <summary>
/// Defines the possible states of a purchase.
/// </summary>
public enum State
{
    Pending,
    Paid,
    sent,
    Delivered,
    Closed,
}
