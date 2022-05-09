using FriendsNess.Shared.Domain.Exercices;
using Microsoft.AspNetCore.Components;

namespace FriendsNess.Client.Areas.Exercices.Pages;

public partial class ExercicesIndex
{
    private IEnumerable<Exercice> _exercices = new List<Exercice>();
    private string _exerciceName;
    private ExerciceCategory _exerciceCategory;
    private BodyPart _exerciceBodyPart;

    protected async override Task OnInitializedAsync()
    {
        _exercices = await GetExercices();
    }

    private async Task<IEnumerable<Exercice>> GetExercices()
    {
        try
        {
            return await ExercicesService.GetExercices();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    private async Task Search()
    {
        var exercices = await GetExercices();
        if (_exerciceName != null)
        {
            exercices = exercices.Where(x => x.Name.ToLower().Contains(_exerciceName.ToLower()));
        }
        if (_exerciceCategory != null)
        {
            _exercices = exercices.Where(x => x.Category == _exerciceCategory);
        }
        if (_exerciceBodyPart != null)
        {
            _exercices = exercices.Where(x => x.ExercicedBodyParts == _exerciceBodyPart);
        }
    }

    private async Task OnFilterNameChanged(string exerciceName)
    {
        _exerciceName = exerciceName;
        await Search();
    }

    private async Task OnFilterExerciceCategoryChanged(ExerciceCategory exerciceCategory)
    {
        _exerciceCategory = exerciceCategory;
        await Search();
    }

    private async Task OnFilterBodyPartChanged(BodyPart exerciceBodyPart)
    {
        _exerciceBodyPart = exerciceBodyPart;
        await Search();
    }
}
