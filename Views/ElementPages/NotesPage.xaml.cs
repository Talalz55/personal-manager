using FinalProject.Models;

namespace FinalProject.Views.ElementPages;

public partial class NotesPage : ContentPage
{
	public NotesPage()
	{
		InitializeComponent();
	}

    private void ContentPage_Appearing(object sender, EventArgs e)
    {
        NotesListView.ItemsSource = NotesRepository.GetNotes();
        NotesListView.SelectedItem = null;

    }

    private void NotesListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var note = (Note)NotesListView.SelectedItem;
        Navigation.PushModalAsync(new NotePage(note));
    }
}