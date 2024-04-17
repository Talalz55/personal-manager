using FinalProject.Models;

namespace FinalProject.Views.ElementPages;

public partial class ExpensePage : ContentPage
{
	public ExpensePage(Expense expense)
	{
		InitializeComponent();
        AmountLabel.Text = "Amount: " + expense.Amount.ToString() + "$";
        CategoryLabel.Text = "Category: " + expense.ExpenseCategory.ToString();
        TextLabel.Text = "Details: " + expense.Details.ToString();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();

    }
}