using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace FinalProject.Models
{
    public class Reminder
    {
        public string Title {get; set;}
        public string TitleString {
            get
            {
                if (Title.Length > 27)
                    return new string(Title.Take(27).ToArray()) + "...";
                return Title;
            }
        } 

        public string Text { get; set; }
        public string TextString { get 
            {
                if (Text.Length > 51)
                    return new string(Text.Take(51).ToArray()) + "...";
                return Text;
            }
        }
        public DateTime Date { get; set; }
        private string Day { get
            {
                return Date.Day.ToString();
            } }
        private string Month
        { //Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec 
            get { 
            int month = Date.Month;
            string monthText = null;

                switch (month)
                {
                    case 01: 
                        monthText = "Jan";
                        break;
                    case 02: 
                        monthText = "Feb";
                        break;
                    case 03:
                        monthText = "Mar";
                        break;
                    case 04:
                        monthText = "Apr";
                        break;
                    case 05:
                        monthText = "May";
                        break;
                    case 06:
                        monthText = "Jun";
                        break;
                    case 07:
                        monthText = "Jul";
                        break;
                    case 08:
                        monthText = "Aug";
                        break;
                    case 09:
                        monthText = "Sep";
                        break;
                    case 10:
                        monthText = "Oct";
                        break;
                    case 11:
                        monthText = "Nov";
                        break;
                    case 12:
                        monthText = "Dec";
                        break;
                }
                return monthText;
            }
        }
        public string DayOfMonth
        {
            get
            {
                return Day + " " + Month;
            }
        }
        public string Time
        {
            get
            {
                var fullTime = Date.TimeOfDay.ToString();
                string newTime = fullTime.Substring(0, fullTime.Length - 3);
                return newTime;
            }
        }
    }
}
