using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using Newtonsoft.Json;

namespace Practos2_C
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Note> Notes { get; } = new ObservableCollection<Note>();

        public MainWindow()
        {
            InitializeComponent();

            LoadNotes();
        }

        private void LoadNotes()
        {
            if (!File.Exists("notes.json"))
            {
                return;
            }

            var json = File.ReadAllText("notes.json");
            var notes = JsonConvert.DeserializeObject<List<Note>>(json);
            foreach (var note in notes)
            {
                Notes.Add(note);
            }
        }

        private void SaveNotes()
        {
            var json = JsonConvert.SerializeObject(Notes);
            File.WriteAllText("notes.json", json);
        }

        private void AddNoteButton_Click(object sender, RoutedEventArgs e)
        {
            var noteWindow = new NoteWindow();
            if (noteWindow.ShowDialog() == true)
            {
                Notes.Add(noteWindow.Note);
            }
        }


        private void EditNoteButton_Click(object sender, RoutedEventArgs e)
        {
            if (NotesListView.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите заметку для редактирования.");
                return;
            }

            var note = (Note)NotesListView.SelectedItem;
            var noteWindow = new NoteWindow
            {
                Title = note.Title,
                Text = note.Text
            };
            if (noteWindow.ShowDialog() == true)
            {
                note.Title = noteWindow.Title;
                note.Text = noteWindow.Text;
                SaveNotes();
            }
        }

        private void DeleteNoteButton_Click(object sender, RoutedEventArgs e)
        {
            if (NotesListView.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите заметку для удаления.");
                return;
            }

            var note = (Note)NotesListView.SelectedItem;
            Notes.Remove(note);
            SaveNotes();
        }

        private void ShowNotesButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedDate = DatePicker.SelectedDate.Value.Date;
            NotesListView.ItemsSource = Notes.Where(n => n.Date.Date == selectedDate);
        }
    }

    public class Note
    {
        public DateTime Date { get; set; } = DateTime.Now;
        public string Title { get; set; }
        public string Text { get; set; }
    }

}
