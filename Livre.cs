using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using Mysqlx.Crud;
using REL;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Biblio
{
    internal class Livre
    {
        private string titre;
        private string auteur;
        private int anneeDePublication;
        private string genre;

        public Livre() { }

        public Livre(string unTitre, string unAuteur, int uneAnneeDePublication, string unGenre)
        {
            titre = unTitre;
            auteur = unAuteur;
            anneeDePublication = uneAnneeDePublication;
            genre = unGenre;
        }

        public string Titre
        {
            get { return titre; }
            set { titre = value; }
        }

        public string Auteur
        {
            get { return auteur; }
            set { auteur = value; }
        }

        public int AnneeDePublication
        {
            get { return anneeDePublication; }
            set { anneeDePublication = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public DataTable GetLivreInfo()
        {


            string query = $"select * from Livre";

            DataTable result = cBdd.ExecuteSelectToDataTable(query);

            return result;
        }
        public static bool AddLivre(string unTitre, string unAuteur, int uneAnneeDePublication, string unGenre)
        {

            string query = $"insert into livre (titre, Auteur, Annee_de_publication, Genre) " +
                           $"VALUES ('{unTitre}', '{unAuteur}', '{uneAnneeDePublication}', '{unGenre}')";

            int oui = cBdd.ExecuteQuery(query);
            bool result = false;
            if (oui != 0)
            {
                result = true;

            }

            return result;
        }

        
    }
}
