
using Microsoft.Maui.Controls;
using PersonalManager.Models;


namespace PersonalManager.Views.ElementPages;

public partial class AddExpensePage : ContentPage
{
	public AddExpensePage()
	{
		InitializeComponent();
	}

    private void AmountEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (string.IsNullOrEmpty(AmountEntry.Text))
        {
            // The Entry control does not contain any text
            PlusLabel.TextColor = Colors.DimGray;

        }
        else
        {
            // The Entry control contains text
            PlusLabel.TextColor = Colors.Red;
        }
    }
    private void AddButton_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (AmountEntry.Text == null)
                throw new Exception();
            if (CategoryPicker.SelectedItem == null)
                throw new Exception();
        
        double amount = double.Parse(AmountEntry.Text);
        //Housing, Transportation, Food, HealthFitness, PersonalCare, Education, DebtPayments, Insuarance, GiftsDonations, Other
        string item = (string)CategoryPicker.SelectedItem;
        ExpensesCategory category;
        switch (item)
        {
            case "Food": category = ExpensesCategory.Food; break;
            case "Transportation": category = ExpensesCategory.Transportation; break;
            case "Personal Care": category = ExpensesCategory.PersonalCare; break;
            case "Housing": category = ExpensesCategory.Housing; break;
            case "Electronics": category = ExpensesCategory.Electronics; break;
            case "Healthcare/Fitness": category = ExpensesCategory.HealthFitness; break;
            case "Education": category = ExpensesCategory.Education; break;
            case "Debt Payments": category = ExpensesCategory.DebtPayments; break;
            case "Insurance": category = ExpensesCategory.Insurance; break;
            case "Gifts/Donations": category = ExpensesCategory.GiftsDonations; break;
            case "Other": category = ExpensesCategory.Other; break;
            default: category = ExpensesCategory.Other; break;
        }
            string details;
            if (DetailsEditor.Text == null)
                 details = "-";
            else
                details = DetailsEditor.Text;
        Expense expense = new Expense {Amount = amount, ExpenseCategory = category, Details = details};
        ExpensesRepository.AddExpense(expense);
        Navigation.PopModalAsync();
            //Navigation.PopToRootAsync();
        }
        catch (Exception ex)
        {
            DisplayAlert("Warning","Please fill out the required fields","Ok");
        }
    }
}