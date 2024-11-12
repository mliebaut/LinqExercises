using System;

namespace ESI_DEV
{
    public class Program
    {
        static void Main(string[] args)
        {
            Database.Initialize();

            Music music1 = new Music(Genre.pop, "Born to Die", 1000000);
            Music music2 = new Music(Genre.rock, "Changes", 200000);
            Music music3 = new Music(Genre.pop, "Toxic", 2000000);
            Music music4 = new Music(Genre.pop, "Born to be alive", 2000000000000000000);

            List<Music> musicsFiltered = Database.GetMusicsByTitleOrderedByListenings("Born");

            foreach (Music music in musicsFiltered)
            {
                Console.WriteLine(music);
            }

        }
    }
}