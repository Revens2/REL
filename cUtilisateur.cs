using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace REL
{
    internal class cUtilisateur
    {
        private int user_id;

        private string mail;

        private string password;

        private string name;

        private string prenom;

        private string dateDeNaissance;

        private int numero;

        private string adresse;

        private int zip;

        private string ville;
        public int User_id
        {
            get { return user_id; }
            set { user_id = value; }
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

        public  bool isAdmin 
        {
            get; private set; 
        }
        public  bool isRh { get; private set; }
        public  bool isInfo { get; private set; }
        public  bool isPaie { get; private set; }

        public  bool istypeService { get; private set; }
        public  bool istypeReunion { get; private set; }
        public  bool istypeVehicule { get; private set; }

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
        public cUtilisateur()
        {

        }

        // Constructeur complet
        public cUtilisateur(int id_utilisateur)
        {
            user_id = id_utilisateur;


            DataTable dt = cBdd.SelectOneUser(id_utilisateur);

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
            LoadUserRoles();
        }
        public string GetUserInfo()
        {
      

            return $" Name: {Name}, Prénom: {Prenom}, " +
                   $"Né(e) le: {DateDeNaissance}, Téléphone: {Numero}, " +
                   $"Email: {Mail}, Adresse: {Adresse}, {Ville}, {Zip}";
        }

        public bool ValidLogin()
        {
            
            try
            {
                MySqlDataReader reader = cBdd.SelectLogin(Mail, Password);

                if (reader.HasRows)
                {
                    reader.Read();

                    if (!reader.IsDBNull(0))
                    {
                        user_id = reader.GetInt32(0);  
                    }
                  

                    reader.Close();
                    cUtilisateur user = new cUtilisateur(user_id);
                    user.LoadUserRoles();
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

        public int Validregister()
        {
            return cBdd.InsertNewUser(Name,Prenom, dateDeNaissance, Adresse, Zip, Ville, Numero, Mail, Password);
            
        }

        public DataTable GetAccount()
        {
            return cBdd.SelectAccount(user_id);
        }

        
        public void LoadUserRoles()
        {
            DataTable dt = cBdd.SelectRole(user_id);

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

        public int GetAccounType()
        {

            int type = 0;
            if (istypeService)
            {
                type = 1;

            }
            else if (istypeReunion)
            {
                type = 2;
            }
            else if (istypeVehicule)
            {
                type = 3;
            }

            return type;

        }

        public bool IsValidEmail()
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(Mail);
                return addr.Address == Mail;
            }
            catch
            {
                return false;
            }
        }

        public int MajUser()
        {
            return cBdd.UpdateUser(Name, Prenom, dateDeNaissance, Adresse, Zip, Ville, Numero, Mail, user_id);

        }
    }


}
