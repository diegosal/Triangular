using Triangular.Web.Models;

namespace Triangular.Web.StateService;

public class StateGridService
{
    private Grid? _grid;

    public Grid Grid
    { 
        get => _grid ?? new(60, 60, 10);
        set
        {
            _grid = value;
            NotifyStateChanged();
        }
    }

    public event Action? OnChange;

    private void NotifyStateChanged() => OnChange?.Invoke();
}
