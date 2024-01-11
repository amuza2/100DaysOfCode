using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5
{
    internal class Tables
    {
        // SQL Genre Table Query
        public static readonly string genreTableQuery = "SELECT * FROM Genre";
        // Genre table name
        public static readonly string genreTableName = "Genre";
        // Genre column names
        public static readonly string genreColumnID = "codeGenre";
        public static readonly string genreColumnIntitle = "inttitleGenre";
        // Genre dataTable name
        public static readonly string genreDtName = "dtGenre";


        // SQL Serie Table Query
        public static readonly string serieTableQuery = "SELECT * FROM Genre INNER JOIN Serie ON Serie.codeGenre = Genre.codeGenre";
        public static readonly string SqlFails = $"SELECT * FROM {genreTableName} INNER JOIN {serieTableName} ON {serieTableName}.{genreColumnID} = {genreTableName}.{genreColumnID}";
        // Serie Table Name
        public static readonly string serieTableName = "Serie";
        // Serie column names
        public static readonly string serieColumnID = "codeSerie";
        public static readonly string serieTitle = "titleSerie";
        public static readonly string serieDate = "dataSortie";
        // serie DataTable name
        public static readonly string serieDtName = "dtSerie";
    }
}
