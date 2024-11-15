using Castle.Core.Logging;
using Excersices.diary_service;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Test
{
//    8. Dagbokfunktionalitet
//         Uppgift: Skapa en Diary-klass som låter användare lägga till och ta bort anteckningar.
//         Tester: Använd xUnit för att testa att anteckningar kan läggas till, visas och tas bort korrekt.
    public class DiaryServiceTests
    {
        [Fact]
        public void AddNote_WithValidContent_AddsNoteToDiary()
        {
            // Arrange
            var note = "";

            // Act

            // Assert
        }

        //Förklaring av Funktionalitet
        //AddNote: Lägger till en anteckning i dagboken.

        //Validerar att anteckningen inte är null, tom eller bara blanksteg.
        //RemoveNoteAt: Tar bort en anteckning med det angivna indexet.

        //Returnerar false om indexet är ogiltigt, annars true.
        //GetNotes: Returnerar en kopia av listan med alla anteckningar.

        //Tester
        //Lägg till anteckningar:
        //Bekräftar att anteckningar läggs till korrekt.
        //Säkerställer att ogiltiga anteckningar (null, tomma strängar) kastar undantag.
        //Ta bort anteckningar:
        //Testar att anteckningar kan tas bort med rätt index.
        //Testar hantering av ogiltiga index.
        //Hämta anteckningar:
        //Validerar att alla anteckningar returneras korrekt.


        //[Fact]
        //public void AddNote_ShouldAddNoteToDiary()
        //{
        //    // Arrange
        //    var diary = new Diary();
        //    var note = "Buy milk";

        //    // Act
        //    diary.AddNote(note);
        //    var notes = diary.GetNotes();

        //    // Assert
        //    Assert.Single(notes);
        //    Assert.Equal(note, notes[0]);
        //}

        //[Fact]
        //public void AddNote_ShouldThrowException_WhenNoteIsInvalid()
        //{
        //    // Arrange
        //    var diary = new Diary();

        //    // Act & Assert
        //    Assert.Throws<ArgumentException>(() => diary.AddNote(null));
        //    Assert.Throws<ArgumentException>(() => diary.AddNote(""));
        //    Assert.Throws<ArgumentException>(() => diary.AddNote("   "));
        //}

        //[Fact]
        //public void RemoveNoteAt_ShouldRemoveNoteByIndex()
        //{
        //    // Arrange
        //    var diary = new Diary();
        //    diary.AddNote("First note");
        //    diary.AddNote("Second note");

        //    // Act
        //    var result = diary.RemoveNoteAt(0);
        //    var notes = diary.GetNotes();

        //    // Assert
        //    Assert.True(result);
        //    Assert.Single(notes);
        //    Assert.Equal("Second note", notes[0]);
        //}

        //[Fact]
        //public void RemoveNoteAt_ShouldReturnFalse_WhenIndexIsInvalid()
        //{
        //    // Arrange
        //    var diary = new Diary();
        //    diary.AddNote("First note");

        //    // Act
        //    var resultNegative = diary.RemoveNoteAt(-1);
        //    var resultOutOfBounds = diary.RemoveNoteAt(10);

        //    // Assert
        //    Assert.False(resultNegative);
        //    Assert.False(resultOutOfBounds);
        //    Assert.Single(diary.GetNotes());
        //}

        //[Fact]
        //public void GetNotes_ShouldReturnAllNotes()
        //{
        //    // Arrange
        //    var diary = new Diary();
        //    diary.AddNote("First note");
        //    diary.AddNote("Second note");

        //    // Act
        //    var notes = diary.GetNotes();

        //    // Assert
        //    Assert.Equal(2, notes.Count);
        //    Assert.Equal("First note", notes[0]);
        //    Assert.Equal("Second note", notes[1]);
        //}
    }
}
