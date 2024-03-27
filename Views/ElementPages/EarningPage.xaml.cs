using PersonalManager.Models;

namespace PersonalManager.Views.ElementPages;

public partial class EarningPage : ContentPage
{
	public EarningPage(Earning earning)
	{
		InitializeComponent();
		AmountLabel.Text = "Amount: " + earning.Amount.ToString() + "$";
		CategoryLabel.Text = "Category: " + earning.EarningCategory.ToString();
		TextLabel.Text = "Details: " + earning.Details.ToString();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();

    }
}