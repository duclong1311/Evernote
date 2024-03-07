﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evernote_Application.Model
{
    public class Note
    {
        public int Id { get; set; }
        public int NotebookID { get; set; }
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set;}
        public string Filelocation {  get; set; }
    }
}
