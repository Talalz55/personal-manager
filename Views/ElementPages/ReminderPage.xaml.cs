using PersonalManager.Models;

namespace PersonalManager.Views.ElementPages;

public partial class ReminderPage : ContentPage
{
	public ReminderPage(Reminder reminder)
	{
		InitializeComponent();
		var title = reminder.Title;
		var text = reminder.Text;
		var day = reminder.DayOfMonth;
		var time = reminder.Time;

		TitleLabel.Text = title;
		TextLabel.Text = text;
		DayLabel.Text = day;
		TimeLabel.Text = time;
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PopModalAsync();
    }
}