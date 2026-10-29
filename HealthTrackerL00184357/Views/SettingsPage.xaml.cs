namespace HealthTrackerL00184357.Views;

public partial class SettingsPage : ContentPage
{
    public SettingsPage()
    {
        InitializeComponent();
    }

    private void OnSaveSettingsClicked(object sender, EventArgs e)
    {
        if (UnitsPicker.SelectedIndex == -1)
        {
            StatusLabel.Text = "Please select your measurement units.";
            return;
        }

        StatusLabel.Text = "Preferences updated for this demo.";
    }
}