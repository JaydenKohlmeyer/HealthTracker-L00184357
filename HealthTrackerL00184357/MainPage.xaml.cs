using HealthTrackerL00184357.Views;

namespace HealthTrackerL00184357;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
    private async void OnProfileClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ProfilePage));
    }

    private async void OnMeasurementsClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(MeasurementsPage));
    }
    private async void OnActivityClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ActivityPage));
    }
    private async void OnGoalsClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(GoalsPage));
    }

    private async void OnStatisticsClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(StatisticsPage));
    }

    private async void OnSettingsClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SettingsPage));
    }
}