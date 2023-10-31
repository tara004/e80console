using System.Data;
using System.Data.SqlClient;

namespace classReservations
{
    public class Reservation
    {

        string connectionString;
        SqlConnection connection;
        SqlDataAdapter adapter;

        /// <summary>
        /// Default constructor, uses localhost and integrated authentication
        /// </summary>
        public Reservation()
        {
            this.connectionString = "Data Source=DESKTOP-N4139G5\\MSSQLSERVER01;Initial Catalog=prenotazioni;Integrated Security=True";
            this.ConnectToDB();
        }

        /// <summary>
        /// Default constructor, uses localhost and integrated authentication
        /// </summary>
        /// <param name="server">server name or address</param>
        /// <param name="database">database name</param>
        public Reservation(string server, string database)
        {
            this.connectionString = $"Data Source={server};Initial Catalog={database};Integrated Security=True";
            this.ConnectToDB();
        }

        /// <summary>
        /// Default constructor, uses localhost and integrated authentication
        /// </summary>
        /// <param name="server">server name or address</param>
        /// <param name="database">database name</param>
        /// <param name="username">username</param>
        /// <param name="password">password</param>
        public Reservation(string server, string database, string username, string password)
        {
            this.connectionString = $"user id={username};data source='{server}';persist security info=True;initial catalog={database};password={password};MultipleActiveResultSets=true";
            this.ConnectToDB();
        }

        private void ConnectToDB()
        {
            this.connection = new SqlConnection(this.connectionString);

            this.connection.Open();
        }
        

        public DataTable tuttiPrenotazioni()
        {
			/* Aggiungere alla classe Reservation il metodo Reservations che restituisce 
			una DataTable che contiene tutti i dati delle prenotazioni */
			
            string queryString;
            DataTable result;
            SqlCommand command;
            DataSet dataSet;

            //loads data from database
            queryString = "SELECT * FROM prenotazioni";

            command = new SqlCommand(queryString, this.connection);
            //connection.Open();

            adapter = new SqlDataAdapter(queryString, this.connection);

            dataSet = new DataSet();
            adapter.Fill(dataSet, "Clienti");

            result = dataSet.Tables["Clienti"];

            return result;
        }
        public DataTable verifica_id(int dati_prenotazione)
        {
            /* Aggiungere alla classe Reservation il metodo Reservations che accetta 
            un intero restituisce una DataTable che contiene i dati della prenotazione che ha ID uguale al valore ricevuto*/
            
            string queryString;
            DataTable result;
            SqlCommand command;
            DataSet dataSet;

            //loads data from database
            queryString = $"SELECT * FROM prenotazioni where prenotazioni.ID_prenotazione = '{dati_prenotazione}'";

            command = new SqlCommand(queryString, this.connection);
            //connection.Open();

            adapter = new SqlDataAdapter(queryString, this.connection);

            dataSet = new DataSet();
            adapter.Fill(dataSet, "Clienti");

            result = dataSet.Tables["Clienti"];

            return result;

        }

        public DataTable verifica_nome_cognome(string firstName, string secondName)
        {
            /* Aggiungere alla classe Reservation il metodo Reservations che accetta due 
            stringhe e restituisce una DataTable che contiene tutti dati delle prenotazioni 
            relative ai clienti che hanno nome e cognome uguale ai valori ricevuti */
            string queryString;
            DataTable result;
            SqlCommand command;
            DataSet dataSet;

            //loads data from database
            queryString = "SELECT * FROM clienti";

            if ((firstName != "") && (secondName != ""))
            {
                queryString += $"\nWHERE cognome = '{secondName.Replace("'", "''")}' AND nome = '{firstName.Replace("'", "''")}'";
            }

            command = new SqlCommand(queryString, this.connection);
            //connection.Open();

            adapter = new SqlDataAdapter(queryString, this.connection);

            dataSet = new DataSet();
            adapter.Fill(dataSet, "Clienti");

            result = dataSet.Tables["Clienti"];

            return result;

        }
        /// <summary>
        /// Loads all customers data
        /// </summary>
        /// <returns></returns>
        public DataTable Customers()
        {
            return this.Customers("", "");
        }

        /// <summary>
        /// Loads all customers data
        /// </summary>
        /// <returns></returns>
        public DataTable Customers(string firstName, string secondName)
        {
            string queryString;
            DataTable result;
            SqlCommand command;
            DataSet dataSet;

            //loads data from database
            queryString = "SELECT * FROM clienti";

            if ((firstName != "") && (secondName != ""))
            {
                queryString += $"\nWHERE cognome = '{secondName.Replace("'", "''")}' AND nome = '{firstName.Replace("'", "''")}'";
            }

            command = new SqlCommand(queryString, this.connection);
            //connection.Open();

            adapter = new SqlDataAdapter(queryString, this.connection);

            dataSet = new DataSet();
            adapter.Fill(dataSet, "Clienti");

            result = dataSet.Tables["Clienti"];

            return result;
        }

    }
}