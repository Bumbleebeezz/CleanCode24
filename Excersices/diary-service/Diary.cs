using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersices.diary_service
{
    public class Diary
    {
        private List<string> _notes;

        public Diary()
        {
            _notes = new List<string>();
        }

        // Add notes
        public void AddNote(string note)
        {
            if (string.IsNullOrWhiteSpace(note))
            {
                throw new ArgumentException("Note cannot be null, empty, or only whitespace.");
            }
            _notes.Add(note);
        }

        // Remove note with id
        public bool RemoveNoteAt(int index)
        {
            if (index < 0 || index >= _notes.Count)
            {
                return false;
            }
            _notes.RemoveAt(index);
            return true;
        }

        // Get all notes
        public List<string> GetNotes()
        {
            return new List<string>(_notes); // Returns a copy of the list
        }
    }
}
