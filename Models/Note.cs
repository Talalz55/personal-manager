using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Note
    {
        public string Title { get; set; }
        public string TitleString
        {
            get
            {
                if (Title.Length > 32)
                    return new string(Title.Take(29).ToArray()) + "...";
                return Title;
            }
        }
        public string Text { get; set; }
        public string TextString
        {
            get
            {
                if (Text.Length > 145)
                    return new string(Text.Take(142).ToArray()) + "...";
                return Text;
            }

        }
    }
}
