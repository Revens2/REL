using System;
using System.Data;
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
        private string dateDeNaissance;  
        private int numero;     
        private string mail;
        private string password;
        private string adresse;
        private int zip;
        private string ville;
        public static bool isAdmin { get; private set; }
        public static bool isRh { get; private set; }
        public static bool isInfo { get; private set; }
        public static bool isPaie { get; private set; }

        public static bool istypeService { get; private set; }
        public static bool istypeReunion { get; private set; }
        public static bool istypeVehicule { get; private set; }



        // Constructeur vide
        public cUtilisateur() { }

        // Constructeur complet
        public cUtilisateur(int id_utilisateur)
        {
            string query = $"SELECT Nom, Prenom, Date_de_naissance, Numero, Email, Adresse, Zip,Ville FROM utilisateur WHERE Id_Utilisateur = {id_utilisateur};";
            

            DataTable dt = cBdd.ExecuteSelectToDataTable(query);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                this.name = Convert.ToString(row["Nom"]);
                this.prenom = Convert.ToString(row["Prenom"]);
                this.dateDeNaissance = Convert.ToString(row["Date_de_naissance"]);
                this.Numero = Convert.ToInt32(row["Numero"]);
                this.mail = Convert.ToString(row["Email"]);
                this.adresse = Convert.ToString(row["Adresse"]);
                this.zip = Convert.ToInt32(row["Zip"]);
                this.ville = Convert.ToString(row["Ville"]);
            }

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

        public int Numero
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

        public int Zip
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
                    reader.Read();

                    if (!reader.IsDBNull(0))
                    {
                        user_id = reader.GetInt32(0);  
                    }
                  

                    reader.Close();
                    cUtilisateur.LoadUserRoles(cUtilisateur.user_id);
                    return true;
                }
                else
                {
                    reader.Close();
                    
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
            int isUser = 1;


            string query = $"INSERT INTO utilisateur (Nom, Prenom, Date_de_naissance,  Adresse, Zip, Ville, Numero, Email, Mot_de_passe) " +
                           $"VALUES ('{unName}', '{unPrenom}', '{dateDeNaissance}','{uneAdresse}', '{unZip}', '{uneVille}', '{unNumero}', '{unMail}', '{unPassword}')";


            int result = cBdd.ExecuteQuery(query);

            string query2 = $"INSERT INTO Role (Id_utilisateur, IsUser) " +
                           $"VALUES (SELECT LAST_INSERT_ID();, '{cUtilisateur.user_id}')";
       cBdd.ExecuteQuery(query2);
            return result;
        }

        public DataTable getAccount(int id_user)
        {

            string query = $"select Nom, Prenom, date_de_naissance, Numero, Email, Adresse, Zip, Ville from Utilisateur where Id_Utilisateur = '{id_user}' ;";
            return cBdd.ExecuteSelectToDataTable(query);
        }

        public static DataTable getRole(int id_user)
        {
            string query = $"SELECT isAdmin, isService, isRh, IsInfo, IsPaie, IsReunion, IsVehicule FROM Role WHERE Id_Utilisateur = {id_user};";
            return cBdd.ExecuteSelectToDataTable(query); 
        }
        public static void LoadUserRoles(int id_user)
        {
            DataTable dt = getRole(id_user);

            if (dt.Rows.Count > 0) 
            {
                DataRow row = dt.Rows[0];

                isAdmin = Convert.ToBoolean(row["isAdmin"]);
                isRh = Convert.ToBoolean(row["isRh"]);
                isInfo = Convert.ToBoolean(row["IsInfo"]);
                isPaie = Convert.ToBoolean(row["IsPaie"]);
                istypeService = Convert.ToBoolean(row["isService"]);
                istypeReunion = Convert.ToBoolean(row["IsReunion"]);
                istypeVehicule = Convert.ToBoolean(row["IsVehicule"]);
            }
        }

        public static int GetAccounType()
        {

            int type = 0;
            if (cUtilisateur.istypeService)
            {
                type = 1;

            }
            else if (cUtilisateur.istypeReunion)
            {
                type = 2;
            }
            else if (cUtilisateur.istypeVehicule)
            {
                type = 3;
            }

            return type;

        }

    }


}
