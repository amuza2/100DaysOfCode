using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    internal class Tables
    {
        public static string Adherent = "Adherent";
        public static string CodeAdherent = "CodeAdherent";
        public static string NomAdherent = "NomAdherent";
        public static string Address = "Address";
        public static string DateInscription = "DateInscription";

        public static string Emprunt = "Emprunt";
        public static string Date_Emprunt = "Date_Emprunt";
        public static string Date_Retour = "Date_Retour";

        public static string Livre = "Livre";
        public static string CodeLivre = "CodeLivre";
        public static string TitreLivre = "TitreLivre";
        public static string AuteurLivre = "AuteurLivre";
        public static string NbExamplaires = "NbExamplaires";

        public static string Theme = "Theme";
        public static string CodeTheme = "CodeTheme";
        public static string ThemeName = "ThemeName";

        // sql Queries
        // show all books
        public static string sql = $"SELECT * FROM {Livre}";

        // show columns for Emprunted books with param
        public static string sql1 = $"SELECT E.{CodeLivre}, L.{TitreLivre}, E.{CodeAdherent},A.{NomAdherent}, E.{Date_Emprunt}, E.{Date_Retour} FROM {Emprunt} AS E, {Adherent} AS A, {Livre} AS L " +
                $"WHERE E.{CodeLivre} = @Data1 AND E.{CodeAdherent} = A.{CodeAdherent}";
        
        // show columns for Emprunted books withour param
        public static string sql2 = $"SELECT E.{CodeLivre}, L.{TitreLivre}, E.{CodeAdherent},A.{NomAdherent}, E.{Date_Emprunt}, E.{Date_Retour} FROM {Emprunt} AS E, {Adherent} AS A, {Livre} AS L " +
            $"WHERE E.{CodeLivre} = L.{CodeLivre} AND A.{CodeAdherent} = E.{CodeAdherent}";

    }
}
