using FinalProject.Models;

namespace FinalProject.Views.ElementPages;

public partial class EarningsPage : ContentPage
{
	public EarningsPage()
	{
		InitializeComponent();
		EarningsListView.ItemsSource = EarningsRepository.GetEarnings();
	}

    private void EarningsListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var earning = (Earning)EarningsListView.SelectedItem;
        Navigation.PushModalAsync(new EarningPage(earning));
    }

    private void ContentPage_Appearing(object sender, EventArgs e)
    {
        EarningsListView.ItemsSource = EarningsRepository.GetEarnings();
        EarningsListView.SelectedItem = null;
    }
}