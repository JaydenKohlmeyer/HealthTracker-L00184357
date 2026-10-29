using HealthTrackerL00184357.Views;

namespace HealthTrackerL00184357
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            
            Routing.RegisterRoute(
                nameof(ProfilePage),
                typeof(ProfilePage));

            Routing.RegisterRoute(
                nameof(MeasurementsPage), 
                typeof(MeasurementsPage));

            Routing.RegisterRoute(
                nameof(ActivityPage), 
                typeof(ActivityPage));

            Routing.RegisterRoute(
                nameof(GoalsPage), 
                typeof(GoalsPage));

            Routing.RegisterRoute(
                nameof(StatisticsPage),
                typeof(StatisticsPage));

            Routing.RegisterRoute(
                nameof(SettingsPage),
                typeof(SettingsPage));
        }
    }
}
