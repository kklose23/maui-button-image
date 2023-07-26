using MonkeyFinder.Services;

namespace MonkeyFinder.ViewModel;

public partial class MonkeysViewModel : BaseViewModel
{
  public ObservableCollection<Monkey> Monkeys { get; } = new();
  MonkeyService monkeyService;
  IConnectivity connectivity;
  IGeolocation geolocation;
  public MonkeysViewModel(MonkeyService monkeyService, IConnectivity connectivity, IGeolocation geolocation)
  {
    Title = "Monkey Finder";
    this.monkeyService = monkeyService;
    this.connectivity = connectivity;
    this.geolocation = geolocation;
  }

  [ObservableProperty]
  private bool showButton = false;

  [RelayCommand]
  public void ToggleButton()
  {
    ShowButton = !ShowButton;
  }
}
