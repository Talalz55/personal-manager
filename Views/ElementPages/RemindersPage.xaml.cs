using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using FinalProject.Models;

namespace FinalProject.Views.ElementPages;

public partial class RemindersPage : ContentPage
{
    public RemindersPage()
    {
        InitializeComponent();
    }

    private void ContentPage_Appearing(object sender, EventArgs e)
    {
        RemindersListView.ItemsSource = RemindersRepository.GetReminders();
        RemindersListView.SelectedItem= null;
    }

    private void RemindersListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        
        var reminder = (Reminder)RemindersListView.SelectedItem;
        Navigation.PushModalAsync(new ReminderPage(reminder));
    }

}
