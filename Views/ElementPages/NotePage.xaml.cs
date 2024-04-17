using FinalProject.Models;

namespace FinalProject.Views.ElementPages;

public partial class NotePage : ContentPage
{
	public NotePage(Note note)
	{
		InitializeComponent();
		TitleLabel.Text = note.Title;
		TextLabel.Text = note.Text;
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }
}