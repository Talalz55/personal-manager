using FinalProject.Views.ElementPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public static class RemindersRepository
    {
        private static List<Reminder> _reminders;
        static RemindersRepository()
        {
            _reminders = new List<Reminder>();
            PopulateList();
        }
        private static void PopulateList()
        {
            //_reminders.Add(new Reminder
            //{
            //    Title = "Make homeworkkkkkkkkkkkkkkkkkkkkk", //30 symbols => 27 allowed
            //    Text = "1. Make a c# assignment\n2. Make math Assignment",
            //    Date = new DateTime(2023, 4, 16, 6, 50, 00)
            //});
            //_reminders.Add(new Reminder
            //{
            //    Title = "Make ho", //54 symbols => 51 allowed
            //    Text = "1.Make a c# assignmentMake a c# assignmentMake a c# acawhfbafh",
            //    Date = new DateTime(2023, 5, 15)
            //});
        }

        public static List<Reminder> GetReminders()
        {
            return _reminders;
        }

        public static void AddReminder(Reminder reminder)
        {
            _reminders.Insert(0, reminder); 
        }
        public static Reminder GetLastReminder()
        {
            try
            {
                return _reminders[0];
            }
            catch { return null; }
        }
        public static Reminder GetNearestReminder()
        {
            var reminder = GetLastReminder();
            foreach (Reminder r in _reminders)
            {
                if (r.Date < reminder.Date)
                {
                    reminder = r;
                }
            }
            return reminder;
        }
    }
}
