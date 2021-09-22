using _06_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_Inheritance
{
    public class Show : StreamingContent
    {
        public int NumberOfSeasons { get; set; }

        public int EmmyNominations { get; set; }

        public int EpisodeCount { get; set; }

        public List<string> Episodes { get; set; }
    }

    public class Episode
    {
        public string Title { get; set; }
        public int SeasonNumber { get; set; }
        public DateTime OriginalAiringDate { get; set; }
    }
}
