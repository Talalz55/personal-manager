using FinalProject.Models;
using Microsoft.Maui.Graphics;

using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FinalProject.Views.ElementPages;

public partial class AddReminderPage : ContentPage
{
	public AddReminderPage()
	{
		InitializeComponent();
	}

    private void AddButton_Clicked(object sender, EventArgs e)
    {
		try
		{

		
		var title = TitleEntry.Text;
		var details = DetailsEditor.Text;
		var year = DatePicker.Date.Year;
		var month = DatePicker.Date.Month;
		var day = DatePicker.Date.Day;
		var hour = TimePicker.Time.Hours;
		var minute = TimePicker.Time.Minutes;

		if (title == null)
		{
			throw new Exception();
		}
		if (details == null)
			{
				details = "-";
			}

		var reminder = new Reminder { Title = title, Text = details, Date = new DateTime(year, month, day, hour, minute, 00) };
		RemindersRepository.AddReminder(reminder);
        Navigation.PopModalAsync();
        }
		catch(Exception ex)
		{
            DisplayAlert("Warning", "Please fill out the required fields", "Ok");
        }


        //Title = "Make ho", //54 symbols => 51 allowed
        //        Text = "1.Make a c# assignmentMake a c# assignmentMake a c# acawhfbafh",
        //        Date = new DateTime(2023, 5, 15)

    }

    private void TitleEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (string.IsNullOrEmpty(TitleEntry.Text))
        {
			// The Entry control does not contain any text
			AddButton.BackgroundColor = Colors.DarkGray;            

        }
        else
        {
            // The Entry control contains text
            AddButton.BackgroundColor = Colors.Purple;
        }
    }
}