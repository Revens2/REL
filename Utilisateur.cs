using System;

namespace REL
{
    internal class Utilisateur
    {
        private string name;
        private string prenom;
        private string mail;
        private string password;
        private string adresse;
        private string zip;
        private string ville;
        private string numero;

        public Utilisateur() { }

        public Utilisateur(string unName, string unPrenom, string unMail, string unPassword, string uneAdresse, string unZip, string uneVille, string unNumero)
        {
            name = unName;
            prenom = unPrenom;
            mail = unMail;
            password = unPassword;
            adresse = uneAdresse;
            zip = unZip;
            ville = uneVille;
            numero = unNumero;
        }

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

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string GetUserInfo()
        {
            return $"{Name} {Prenom} - Email: {Mail} - Adresse: {Adresse}, {Ville}, {Zip} - Numéro: {Numero}";
        }
    }
}
