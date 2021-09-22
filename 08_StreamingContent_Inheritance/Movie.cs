using _06_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_Inheritance
{
    public class Movie : StreamingContent
    {
        public int OscarNominations { get; set; }

        public Movie Sequel { get; set; }
    }
}
