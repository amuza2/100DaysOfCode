using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exm01
{
    internal static class ColumnNames
    {
        // realisator table
        public static string realisator = "realisator";
        // realisator table columns
        public static string idRealisatorCol => "id_realisator";
        public static string realisatorNameCol => "realisator_name";
        // film table
        public static string film = "film";
        // film table columnss
        public static string idFilmCol => "id_film";
        public static string titleFilmCol => "title_film";
        public static string lengthFilmCol => "length_film";
        public static string releasedDateCol => "released_date";

        // dataset tables
        public static string dsRealisator = "dsRealisator";
        public static string dsFilm = "dsFilm";

        // SQL queries

        // sql query to get realisator table
        public static string SQLrealisator = "SELECT * FROM " + realisator;

        // sql query to get film table with realisator_name column from realisator table
        public static string SQLfilm = $"SELECT {idFilmCol}, {titleFilmCol}, {lengthFilmCol}, {releasedDateCol}, {realisator}.{realisatorNameCol} FROM {film} INNER JOIN {realisator} ON {film}.{idRealisatorCol} = {realisator}.{idRealisatorCol}";
    }
}
