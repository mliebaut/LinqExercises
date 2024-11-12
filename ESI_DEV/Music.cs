using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESI_DEV
{
    public class Music
    {
        public Genre Genre { get; set; }
        public string Title { get; set; }
        public long NumberOfListenings { get; set; }

        public Music(Genre genre, string title, long numberOfListenings)
        {
            Genre = genre;
            Title = title ?? throw new ArgumentNullException(nameof(title));
            NumberOfListenings = numberOfListenings;

            Database.Musics.Add(this);
        }

        public override string ToString()
        {
            return Title + " " + NumberOfListenings;
        }
    }
}
