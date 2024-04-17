using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public static class NotesRepository
    {
        private static List<Note> _notes;
        static NotesRepository()
        {
            _notes = new List<Note>();
            PopulateList();
        }
        private static void PopulateList()
        { //title 32 => 29 allowed, text 145 => 142 allowed
            //_notes.Add(new Note { Title = "listShoppinglistlistShoppinglistmynameisAndrew", Text = "1. Carrots\n2. Meat\n3. Pasta\n3. Pasta" });
            //_notes.Add(new Note
            //{
            //    Title = "Project ideas",
            //    Text = "1. Fitness app 2. Personal Manager 3. Mobile Game3. Mobile Game3. Mobile Game3. Mobile Game1. Fitness app1. Fitness app1. Fitness app1. Fitnessaphelloimandrew"
            //});
        }

        public static List<Note> GetNotes()
        {
            return _notes;
        }
        public static void AddNote(Note note)
        {
            _notes.Insert(0, note);
        }
        public static Note GetLastNote()
        {
            try
            {
                return _notes[0];
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
