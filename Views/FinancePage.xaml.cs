using FinalProject.Models;
namespace FinalProject.Views;
public partial class FinancePage : ContentPage
{
    public FinancePage()
	{
		InitializeComponent();


    }

    private void ContentPage_Appearing(object sender, EventArgs e)
    {

        var expensesPercentages = ExpensesRepository.CalculatePercentage();
        Expense1Label.Text = expensesPercentages[0].Description;
        if (expensesPercentages[0].Percentage > 0)
            Expense1Label.TextColor = Colors.Red;
        Expense2Label.Text = expensesPercentages[1].Description;
        Expense3Label.Text = expensesPercentages[2].Description;
        Expense4Label.Text = expensesPercentages[3].Description;
        Expense5Label.Text = expensesPercentages[4].Description;
        Expense6Label.Text = expensesPercentages[5].Description;
        Expense7Label.Text = expensesPercentages[6].Description;
        Expense8Label.Text = expensesPercentages[7].Description;
        Expense9Label.Text = expensesPercentages[8].Description;
        Expense10Label.Text = expensesPercentages[9].Description;
        Expense11Label.Text = expensesPercentages[10].Description;


        var incomePercentages = EarningsRepository.CalculatePercentage();
        if (incomePercentages[0].Percentage > 0)
            Income1Label.TextColor = Colors.Green;
        Income1Label.Text = incomePercentages[0].Description; 
        Income2Label.Text = incomePercentages[1].Description;
        Income3Label.Text = incomePercentages[2].Description;
        Income4Label.Text = incomePercentages[3].Description;
        Income5Label.Text = incomePercentages[4].Description;
        Income6Label.Text = incomePercentages[5].Description;
    }

}