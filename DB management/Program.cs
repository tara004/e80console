using System.Data;
using System.Data.SqlClient;
using classReservations;

string customerFirstName;
string customerSecondName;
string queryString = "SELECT * FROM clienti INNER JOIN prenotazioni ON id_cliente = cliente";
DataTable dataTable;
DataSet dataSet;
/*
string a,b;
Console.WriteLine("Nome");
a=Console.ReadLine();
Console.WriteLine("Cognome"); 
b=Console.ReadLine();
*/

Reservation r = new Reservation();
ù
dataTable = r.tuttiPrenotazioni();

foreach (DataRow row in dataTable.Rows)
	{
		Console.WriteLine($"{row["ID_prenotazione"]}\t{row["camera"]}\t{row["importo"]}\t{row["arrivo"]}");
	}

////create a DB connection
//	//ask for first and second name
//	Console.Write("Nome: ");
//	customerFirstName = Console.ReadLine();
//	Console.Write("Cognome: ");
//	customerSecondName = Console.ReadLine();

//	queryString += $" WHERE nome = '{customerFirstName}' AND cognome = '{customerSecondName}'";

//	command = new SqlCommand(queryString, connection);
//	connection.Open();

//	adapter = new SqlDataAdapter(queryString, connection);

//	dataSet = new DataSet();
//	adapter.Fill(dataSet, "Clienti");

//	//command.ExecuteNonQuery();

//	dataTable = dataSet.Tables["Clienti"];

//	Console.WriteLine("Data di arrivo\tData di partenza\timporto\ttipo struttura");

//	foreach (DataRow row in dataTable.Rows)
//	{
//		Console.WriteLine($"{row["arrivo"]}\t{row["partenza"]}\t{row["importo"]}\t{row["tipo_struttura"]}");
//	}
