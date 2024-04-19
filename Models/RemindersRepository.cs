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
