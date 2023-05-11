using System;
namespace learning;

class Livre {
    // Variables
    string titre, auteur;
    int nbPages ;
    // Constructeur
    public Livre(String unAuteur, String unTitre) {
    auteur = unAuteur;
    titre = unTitre;
    }
    // Accesseur
    public String getAuteur() 
    {
        return auteur;
    }
    // Modificateur
    public void setNbPages(int nb) {
        if(nb >= 0) nbPages = nb;
        else Console.WriteLine("Error, you can't add a negative number!");
    }
}

class Program
{
    static void Main(string[] args)
        {
            Livre book1 = new Livre("Med", "C# for devlopers");
            book1.setNbPages(-5);
            Livre book2 = new Livre("Chami", "C# for everybody");
            book2.setNbPages(200);
        }
}