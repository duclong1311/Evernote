﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Evernote_Application.ViewModel.Commands
{
    public class NewNoteCommand : ICommand
    {
        public NotesViewModel VM { get; set; }

        public event EventHandler? CanExecuteChanged;

        public NewNoteCommand(NotesViewModel vm)
        {
            VM = vm;
        }
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            //TODO: Create new note
        }
    }
}
