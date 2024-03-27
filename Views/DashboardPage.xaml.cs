using PersonalManager.Models;
using PersonalManager.Views.ElementPages;

namespace FinalProject.Views;

public partial class DashboardPage : ContentPage
{
	public DashboardPage()
	{
		InitializeComponent();
	}

    private void EarningsButton_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new EarningsPage());
    }

    private void ExpensesButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ExpensesPage()); 
    }

    private void RemindersButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new RemindersPage());
    }

    private void NotesButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NotesPage());
    }

    private void ContentPage_Appearing(object sender, EventArgs e)
    {
        DisplayLastEarning();
        DisplayLastExpense();
        DisplayBalance();
        DisplayReminder();
        DisplayNote();        
        //var balanceCalculation = totalEarnings - totalExpenses;
        //string balance;
        //if (balanceCalculation < 0)
        //{
        //    string amount = balanceCalculation.ToString();
        //}
    }
    private void DisplayLastEarning()
    {
        var earning = EarningsRepository.GetLastEarning();
        if (earning == null) {
            LastEarningLabel.TextColor = Colors.Grey;
            earning = "0";
            LastEarningLabel.Text = earning;
        }
        else
        {
            LastEarningLabel.TextColor = Colors.Green;
            LastEarningLabel.Text = earning;

        }
    }
    private void DisplayLastExpense()
    {
        var expense = ExpensesRepository.GetLastExpense();
        if (expense == null)
        {
            LastExpenseLabel.TextColor = Colors.Grey;
            expense = "0";
            LastExpenseLabel.Text = expense;
        }
        else
        {
            LastExpenseLabel.TextColor = Colors.Red;
            LastExpenseLabel.Text = expense;
        }
        
    }
    private void DisplayBalance()
    {
        try
        {
            double totalExpenses = ExpensesRepository.GetTotal();
            double totalEarnings = EarningsRepository.GetTotal();
            string balance;
            if (totalEarnings > totalExpenses)
            {
                var calculation = Math.Round(totalEarnings - totalExpenses, 2);
                string amount = calculation.ToString();
                balance = "+" + amount + "$";
                BalanceLabel.TextColor = Colors.Green;
            }
            else if (totalEarnings < totalExpenses)
            {
                var calculation = Math.Round(totalExpenses - totalEarnings, 2);
                string amount = calculation.ToString();
                balance = "-" + amount + "$";
                BalanceLabel.TextColor = Colors.Red;
            }
            else
            {
                balance = "0";
                BalanceLabel.TextColor = Colors.Grey;
            }

            BalanceLabel.Text = balance;
        }
        catch(Exception ex)
        {
            BalanceLabel.Text = "-";
        }
    }
    private void DisplayReminder()
    {
        Reminder reminder = RemindersRepository.GetLastReminder();
        if (reminder == null) { 
            NoReminders.IsVisible = true;
            YesReminders.IsVisible = false;  
        }
        else
        {
            NoReminders.IsVisible = false;
            YesReminders.IsVisible = true;
            string date = reminder.DayOfMonth;
            string time = reminder.Time;
            string title = reminder.TitleString;

            ReminderTitleLabel.Text = title;
            TimeLabel.Text = time;
            DateLabel.Text = date;
        }
        
    }
    private void DisplayNote()
    {
        Note note = NotesRepository.GetLastNote();
        if (note == null)
        {
            YesNotes.IsVisible = false;
            NoNotes.IsVisible= true;
        }
        else
        {
            NoNotes.IsVisible = false;
            YesNotes.IsVisible= true;
            string title = note.TitleString;
            string text = note.TextString;
            NoteTitleLabel.Text = title;
            NoteTextLabel.Text = text;
        }
        
    }
}