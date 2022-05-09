using FriendsNess.Shared.Domain.Exercices;

namespace FriendsNess.Client.Http.Services;

public interface IExercicesService
{
    Task<IEnumerable<Exercice>> GetExercices();
    Task<Exercice> GetExercice(int exerciceId);
}

public class ExercicesService : IExercicesService
{
    private readonly IRepository _repository;
    
    public ExercicesService(IRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Exercice>> GetExercices()
    {
        var httpResponse = await _repository.Get<List<Exercice>>($"/api/exercices");
        if (!httpResponse.Error)
        {
            return httpResponse.Response;
        }
        else
        {
            var message = await httpResponse.GetBody();
            throw new Exception(message);
        }
    }

    public async Task<Exercice> GetExercice(int exerciceId)
    {
        var httpResponse = await _repository.Get<Exercice>($"/exercices/{exerciceId}");
        if (!httpResponse.Error) 
        {
            return httpResponse.Response;
        }
        else
        {
            var message = await httpResponse.GetBody();
            throw new Exception(message);
        }
    }
}
