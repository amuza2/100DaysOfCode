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
                id_realisator = 3,
                title_film = "EF Test Title 2",
                length_film = "1h",
                released_date = DateTime.Now,
            };
            context.films.Add(film);
            context.SaveChanges();
        }
    }
}
