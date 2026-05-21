namespace GloboTicket.Ordering.Model
{
    public class NewModel
    {
        // a propertie
        public Guid NewModelId { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        // another propertie
        public string? Password { get; set; }
        // This is a placeholder to simulate a confilict code
        //TODO: Simulate a conflict code
        // There is a conflict aoce I guess
        //TODO: This one will raise a conflict code
    }
}
