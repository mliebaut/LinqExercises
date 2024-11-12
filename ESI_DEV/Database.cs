using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESI_DEV
{
    public class Database
    {
        public static List<Music> Musics { get; set; }

        public static void Initialize()
        {
            Musics = new List<Music>();
        }

        public static List<Music> GetMusicsByGenre(Genre genreToGet)
        {
            return Musics
                .Where(music => music.Genre == genreToGet)
                .ToList();
        }

        public static List<Music> GetMusicsByTitle(string query)
        {
            return Musics
                .Where(music => music.Title.Contains(query))
                .ToList();
        }

        public static List<Music> GetMusicsByGenreOrderedByListenings(Genre genreToGet)
        {
            return Musics
                .Where(music => music.Genre == genreToGet)
                .OrderByDescending(music => music.NumberOfListenings)
                .ToList();
        }

        public static List<Music> GetMusicsByTitleOrderedByListenings(string query)
        {
            List<Music> musicsContainingQuery = GetMusicsByTitle(query);

            return musicsContainingQuery
                .OrderByDescending(music => music.NumberOfListenings)
                .ToList();
        }
    }
}
