using System;
using System.Windows;

namespace Practos2_C
{
    public partial class NoteWindow : Window
    {
        public string Title
        {
            get { return TitleTextBox.Text; }
            set { TitleTextBox.Text = value; }
        }

        public string Text
        {
            get { return TextBox.Text; }
            set { TextBox.Text = value; }
        }

        private void AddNoteButton_Click(object sender, RoutedEventArgs e)
        {
            var note = new Note
            {
                Title = TitleTextBox.Text,
                Text = TextBox.Text,
                Date = DateTime.Now
            };

            DialogResult = true;
            Close();
        }
        public Note Note { get; private set; }

        public NoteWindow()
        {
            InitializeComponent();
            Note = new Note();
            DataContext = Note;
        }


    }
}
