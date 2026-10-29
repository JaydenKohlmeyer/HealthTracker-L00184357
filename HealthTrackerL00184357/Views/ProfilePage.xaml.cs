namespace HealthTrackerL00184357.Views;

public partial class ProfilePage : ContentPage
{
    public ProfilePage()
    {
        InitializeComponent();
    }

    private void OnSaveProfileClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(NameEntry.Text))
        {
            StatusLabel.Text = "Please enter your name.";
            return;
        }

        StatusLabel.Text = "Profile details saved for this demo.";
    }
}