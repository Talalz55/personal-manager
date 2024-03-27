using PersonalManager.Models;

namespace PersonalManager.Views.ElementPages;

public partial class ExpensesPage : ContentPage
{
	public ExpensesPage()
	{
		InitializeComponent();
    }

    private void ContentPage_Appearing(object sender, EventArgs e)
    {
        ExpensesListView.ItemsSource = ExpensesRepository.GetEarnings();
        ExpensesListView.SelectedItem = null;

    }

    private void ExpensesListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var expense = (Expense)ExpensesListView.SelectedItem;
        Navigation.PushModalAsync(new ExpensePage(expense));
    }
}