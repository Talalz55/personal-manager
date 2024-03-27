namespace PersonalManager.Views.ElementPages;
using PersonalManager.Models;

public partial class AddEarningPage : ContentPage
{
	public AddEarningPage()
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
            PlusLabel.TextColor = Colors.Green;
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
            EarningsCategory category;
                            //< !--Work, Gifts, Investments, RentalIncome, PersonalLoans, Other-- >
            switch (item)
            {
                case "Work": category = EarningsCategory.Work; break;
                case "Gifts": category = EarningsCategory.Gifts; break;
                case "Investments": category = EarningsCategory.Investments; break;
                case "Rental Income": category = EarningsCategory.RentalIncome; break;
                case "Personal Loans": category = EarningsCategory.PersonalLoans; break;
                case "Other": category = EarningsCategory.Other; break;
                default: category = EarningsCategory.Other; break;

            }
            string details;
            if (DetailsEditor.Text == null)
                details = "-";
            else
                details = DetailsEditor.Text;
            Earning earning = new Earning { Amount = amount, EarningCategory = category, Details = details };
            EarningsRepository.AddEarning(earning);
            Navigation.PopModalAsync();
            //Navigation.PopToRootAsync();
        }
        catch (Exception ex)
        {
            DisplayAlert("Warning", "Please fill out the required fields", "Ok");
        }
    }
}