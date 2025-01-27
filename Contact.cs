using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REL
{
    internal class Contact
        {
            public string NomContact;
            public string PrenomContact;
            public int AgeContact;

        public Contact() { }

            public Contact(string unNomContact, string unPrenomContact, int unAgeContact)
            {
                NomContact = unNomContact;
                PrenomContact = unPrenomContact;
                AgeContact = unAgeContact;
        }


            public string GetNom()
            {
                return NomContact;
            }

            public string GetPrenom()
            {
                return PrenomContact;
            }
            public int GetAge()
            {
                return AgeContact;
            }
            public string SetNom(string unNomContact)
            {
                NomContact = unNomContact; ;
                return NomContact;
            }
            public string SetPrenom(string unPrenomContact)
            {
                PrenomContact = unPrenomContact;
                return PrenomContact;
            }
            public int SetAge(int unAgeContact)
            {
                AgeContact = unAgeContact;
                return AgeContact;
            }

            public static int Add(string nom, string prenom, int age)
            {

                string query = $"INSERT INTO contacts (nom_contact, prenom_contact, age) VALUES ('{nom}', '{prenom}', '{age}')";

                int result = Bdd.ExecuteQuery(query);
                return result;
            }

            public static int update(string nom, string prenom, int age, int id )
            {

                string query = $"update contacts set nom_contact= '{nom}' , prenom_contact = '{prenom}', age =  '{age}' where id = '{id}' ";

                int result = Bdd.ExecuteQuery(query);
                return result;
            }
            public static int delete(int id)
            {

                string query = $" delete from contacts where id = '{id}'";

                int result = Bdd.ExecuteQuery(query);
                return result;
            }

        public static DataTable List()
        {

                string query = $"select * from contacts";

                DataTable result = Bdd.ExecuteSelectToDataTable(query);
                return result;
        }

    }
    
}
