using Evernote_Application.Model;
using Evernote_Application.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evernote_Application.ViewModel
{
    public class NotesViewModel
    {
        public ObservableCollection<Notebook> notebooks { get; set; }

        private Notebook selectedNotebook;

        public Notebook SelectedNotebook
        {
            get { return selectedNotebook; }
            set 
            {
                selectedNotebook = value; 
                //TODO: get notes
            }
        }

        public ObservableCollection<Note> Notes {  get; set; }

        public NewNotebookCommand NewNotebookCommand { get; set; }
        public NewNoteCommand NewNoteCommand { get; set; }

        public NotesViewModel()
        {
            NewNotebookCommand = new NewNotebookCommand(this);
            NewNoteCommand = new NewNoteCommand(this);
        }

    }
}
