namespace GloboTicket.Ordering.Model;

public class OrderLine
{
    public Guid ConcertId { get; set; }
    public int TicketCount { get; set; }
    public int Price { get; set; }
    // Feature Twelve: this is a placeholder to simulate a conflict
    // tODO : Simulate a conflict code for feature twelve
}
