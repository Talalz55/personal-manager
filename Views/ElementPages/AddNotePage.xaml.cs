using PersonalManager.Models;

namespace PersonalManager.Views.ElementPages;

public partial class AddNotePage : ContentPage
{
	public AddNotePage()
	{
		InitializeComponent();
	}

    private void AddButton_Clicked(object sender, EventArgs e)
    {
        try
        {
            var title = TitleEntry.Text;
            var details = DetailsEditor.Text;

            if (details == null)
            {
                throw new Exception();
            }
            if (title == null)
            {
                title = "-";
            }

            var note = new Note { Title = title, Text = details};
            NotesRepository.AddNote(note);
            Navigation.PopModalAsync();
        }
        catch (Exception ex)
        {
            DisplayAlert("Warning", "Please fill out the required fields", "Ok");
        }
    }
}