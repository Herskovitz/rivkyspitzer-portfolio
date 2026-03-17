namespace MauiBasics;

public partial class BasicControls : ContentPage
{
	public BasicControls()
	{
		InitializeComponent();
        slHeight.ValueChanged += SlHeight_ValueChanged;
    }
    private void btnSave_Clicked(object sender, EventArgs e)
    {
        lblMessage.Text = "Saved - " + txtLastName.Text;
        txtLastName.Text = "";
    }
    private void SlHeight_ValueChanged(object? sender, ValueChangedEventArgs e)
    {
        lblMessage.Text = slHeight.Value.ToString();
    }
}
