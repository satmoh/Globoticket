namespace GloboTicket.Catalog.Repositories;

public interface IEventRepository
{
    // return all events
    Task<IEnumerable<Event>> GetEvents();
    // return event by id
    Task<Event> GetEventById(Guid eventId);
    //set a special offer for an event
    void UpdateSpecialOffer();
}
