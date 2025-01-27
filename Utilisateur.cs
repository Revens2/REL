using System;

namespace REL
{
    internal class Utilisateur
    {
      
        private string name;
        private string prenom;
        private string dateDeNaissance;   // Nullable car SQL peut permettre NULL
        private string numero;      // Peut rester int, mais ajustable en string si besoin
        private string mail;
        private string password;
        private string adresse;
        private string zip;
        private string ville;

        // Constructeur vide
        public Utilisateur() { }

        // Constructeur complet
        public Utilisateur(string name,string prenom, string dateDeNaissance, string numero,string mail, string password,string adresse,string zip,string ville)
        {
         
            this.name = name;
            this.prenom = prenom;
            this.dateDeNaissance = dateDeNaissance;
            this.numero = numero;
            this.mail = mail;
            this.password = password;
            this.adresse = adresse;
            this.zip = zip;
            this.ville = ville;
        }

        // Propriétés publiques (getters et setters)

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public string DateDeNaissance
        {
            get { return dateDeNaissance; }
            set { dateDeNaissance = value; }
        }

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        public string Zip
        {
            get { return zip; }
            set { zip = value; }
        }

        public string Ville
        {
            get { return ville; }
            set { ville = value; }
        }

        public string GetUserInfo()
        {
      

            return $" Name: {Name}, Prénom: {Prenom}, " +
                   $"Né(e) le: {DateDeNaissance}, Téléphone: {Numero}, " +
                   $"Email: {Mail}, Adresse: {Adresse}, {Ville}, {Zip}";
        }
    }
}
