﻿using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace REL
{
    internal class cUtilisateur
    {
        public static int user_id;

        private string mail;

        private string password;

        private string name;

        private string prenom;

        private string dateDeNaissance;

        private int numero;

        private string adresse;

        private int zip;

        private string ville;
        public static int User_id
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

        public static bool isAdmin 
        {
            get; private set; 
        }
        public static bool isRh { get; private set; }
        public static bool isInfo { get; private set; }
        public static bool isPaie { get; private set; }

        public static bool istypeService { get; private set; }
        public static bool istypeReunion { get; private set; }
        public static bool istypeVehicule { get; private set; }

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

        }
        public string GetUserInfo()
        {
      

            return $" Name: {Name}, Prénom: {Prenom}, " +
                   $"Né(e) le: {DateDeNaissance}, Téléphone: {Numero}, " +
                   $"Email: {Mail}, Adresse: {Adresse}, {Ville}, {Zip}";
        }

        public bool validLogin()
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
                    cUtilisateur.LoadUserRoles(user_id);
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

        public DataTable getAccount(int id_user)
        {

            string query = $"select Nom, Prenom, date_de_naissance, Numero, Email, Adresse, Zip, Ville from Utilisateur where Id_Utilisateur = '{id_user}' ;";
            return cBdd.ExecuteSelectToDataTable(query);
        }

        
        public static void LoadUserRoles(int id_user)
        {
            DataTable dt = cBdd.SelectRole(id_user);

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

        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


    }


}
