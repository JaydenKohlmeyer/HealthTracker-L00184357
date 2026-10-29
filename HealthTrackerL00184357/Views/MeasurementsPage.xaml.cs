namespace HealthTrackerL00184357.Views;

public partial class MeasurementsPage : ContentPage
{
    public MeasurementsPage()
    {
        InitializeComponent();
    }

    private void OnSaveMeasurementClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(WeightEntry.Text) &&
            string.IsNullOrWhiteSpace(HeartRateEntry.Text) &&
            string.IsNullOrWhiteSpace(WaterEntry.Text))
        {
            StatusLabel.Text = "Please enter at least one measurement.";
            return;
        }

        StatusLabel.Text = "Measurement recorded for this demo.";
    }
}