
using FinalProject.Models;

namespace FinalProject.Views
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            RefreshUser();
        }
        private void EditButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SettingsPage());
        }
        private void RefreshUser()
        {
            var firstName = string.IsNullOrEmpty(User.FirstName);
            FirstLabel.Text = firstName ? "First Name" : User.FirstName;
            var lastName = string.IsNullOrEmpty(User.LastName);
            SecondLabel.Text = lastName ? "Last Name" : User.LastName;
        }
    }
}
