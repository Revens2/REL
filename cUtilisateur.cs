using System;
using MySql.Data.MySqlClient;

namespace REL
{
    internal class cUtilisateur
    {
        public static int user_id; // Variable statique privée

        public static int User_id
        {
            get { return user_id; }
            set { user_id = value; }
        }
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
        public cUtilisateur() { }

        // Constructeur complet
        public cUtilisateur(string name,string prenom, string dateDeNaissance, string numero,string mail, string password,string adresse,string zip,string ville)
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

        public bool validLogin(string username, string password)
        {
            string query = $"SELECT Id_Utilisateur FROM utilisateur WHERE Email = '{username}' AND Mot_de_passe = '{password}'";

            try
            {
                MySqlDataReader reader = cBdd.ExecuteSelect(query);

                if (reader.HasRows)
                {
                    reader.Read();  // ✅ Lire la première ligne avant de fermer la connexion

                    if (!reader.IsDBNull(0))
                    {
                        user_id = reader.GetInt32(0);  // ✅ Stocke l'ID utilisateur
                    }
                    else
                    {
                        user_id = -1;  // Aucun ID trouvé
                    }

                    reader.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    user_id = -1;
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}");
                return false;
            }
        }

        public static int Validregister(string unName, string unPrenom, string dateDeNaissance, string unMail, string unPassword, string uneAdresse, string unZip, string uneVille, string unNumero)
        {
            int isClientValue = 1;


            string query = $"INSERT INTO utilisateur (Nom, Prenom, Date_de_naissance,  Adresse, Zip, Ville, Numero, IsClient, Email, Mot_de_passe) " +
                           $"VALUES ('{unName}', '{unPrenom}', '{dateDeNaissance}','{uneAdresse}', '{unZip}', '{uneVille}', '{unNumero}', {isClientValue}, '{unMail}', '{unPassword}')";

            int result = cBdd.ExecuteQuery(query);
            return result;
        }


    }
}
