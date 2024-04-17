using FinalProject.Models;

namespace FinalProject.Views;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
	}

    private void SaveButton_Clicked(object sender, EventArgs e)
    {
		var firstName = FirstNameEntry.Text;
		var lastName = LastNameEntry.Text;
		if (firstName == null || lastName == null)
		{
            DisplayAlert("Error", "Empty input!", "OK");
            return;
        }

		User.FirstName = firstName;
		User.LastName = lastName;
		Navigation.PopAsync();
    }

    private void FirstButton_Clicked(object sender, EventArgs e)
    {
        var firstName = FirstNameEntry.Text;
        if (firstName == null)
        {
            DisplayAlert("Error", "Empty input!", "OK");
            return;
        }
        User.FirstName = firstName;
        FirstNameEntry.Text = null;
    }

    private void SecondButton_Clicked(object sender, EventArgs e)
    {
        var secondName = LastNameEntry.Text;
        if (secondName == null)
        {
            DisplayAlert("Error", "Empty input!", "OK");
            return;
        }
        User.LastName = secondName;
        LastNameEntry.Text = null;
    }

    private void BackButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}