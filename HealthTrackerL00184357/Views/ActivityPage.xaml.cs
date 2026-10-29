namespace HealthTrackerL00184357.Views;

public partial class ActivityPage : ContentPage
{
    public ActivityPage()
    {
        InitializeComponent();
    }

    private void OnSaveActivityClicked(object sender, EventArgs e)
    {
        if (ActivityPicker.SelectedIndex == -1)
        {
            StatusLabel.Text = "Please select an activity.";
            return;
        }

        if (!int.TryParse(DurationEntry.Text, out int duration) ||
            duration <= 0)
        {
            StatusLabel.Text = "Enter a duration greater than zero.";
            return;
        }

        StatusLabel.Text = "Activity recorded for this demo.";
    }
}