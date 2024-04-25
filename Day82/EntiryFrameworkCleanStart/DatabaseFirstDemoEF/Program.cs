using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstDemoEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new cenimaDatabaseEntities();
            var film = new film()
            {
                id_realisator = 1,
                title_film = "EF Test Title",
                length_film = "2h:45m",
                released_date = DateTime.Now,
            };
            context.films.Add(film);
            context.SaveChanges();
        }
    }
}
