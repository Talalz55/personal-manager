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
