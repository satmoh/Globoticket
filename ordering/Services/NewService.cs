using GloboTicket.Ordering.Model;

namespace GloboTicket.Ordering.Services
{
    public class NewService
    {
        public NewService()
        {
            NewModelId = Guid.NewGuid();
            NewModels = new List<NewModel>();
        }
        //  identifiant de NewModel
        public Guid NewModelId { get; }

        // décklarer une collection de NewModel
        public List<NewModel>? NewModels { get; }

        // définir une méthode pour ajouter un NewModel à la collection
        public NewModel addNewModel(NewModel newModel)
        {
            NewModels!.Add(newModel);
            return newModel;
            
        }
        // this a placeholder to put a code for issue53
        //TODO: implement the logic for issue53
    }
}
