namespace HealthTrackerL00184357.Views;

public partial class GoalsPage : ContentPage
{
    public GoalsPage()
    {
        InitializeComponent();
    }

    private async void OnEditGoalsClicked(object sender, EventArgs e)
    {
        string result = await DisplayPromptAsync(
            "Edit Daily Steps Goal",
            "Enter your new daily steps target:",
            accept: "Save",
            cancel: "Cancel",
            keyboard: Keyboard.Numeric);

        if (string.IsNullOrWhiteSpace(result))
            return;

        if (!int.TryParse(result, out int goal) || goal <= 0)
        {
            await DisplayAlertAsync(
                "Invalid goal",
                "Please enter a whole number greater than zero.",
                "OK");
            return;
        }

        StatusLabel.Text = $"New daily steps goal: {goal:N0}";
    }
}