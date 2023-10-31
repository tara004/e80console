using classReservations;
using System.Data;

namespace testReservation
{
	[TestClass]
	public class UnitTestReservation
	{
		[TestMethod]
		public void TestCustomers()
		{
			Reservation reservation = new Reservation();
			DataTable customers;

			customers = reservation.Customers();

			if (customers == null)
			{
				throw new Exception("customers load failed");
			}
			if (customers.Rows.Count != 930)
			{
				//test DB contains 930 customers
				throw new Exception("customers count doesn't match");
			}
			
			customers = reservation.Customers("Claudio", "Rossi");

			if (customers == null)
			{
				throw new Exception("customers load failed");
			}
			if (customers.Rows.Count != 5)
			{
				//test DB contains 5 Claudio Rossi
				throw new Exception("customers named Claudio Rossi count doesn't match");
			}		
			
			customers = reservation.Customers("doesn't", "Exists");

			if (customers == null)
			{
				throw new Exception("customers load failed");
			}
			if (customers.Rows.Count != 0)
			{
				//test DB contains 0 customer named "Doesn't Exists"
				throw new Exception("customers named Doesn't Exists count doesn't match");
			}
		}
		[TestMethod]
		public void TestTuttiPrenotazioni()
		{
            Reservation reservation = new Reservation();
            DataTable tutti_preonatazioni;

			tutti_preonatazioni = reservation.tuttiPrenotazioni();

            if (tutti_preonatazioni == null)
            {
                throw new Exception("customers load failed");
            }
            if (tutti_preonatazioni.Rows.Count != 0)
            {
                //test DB contains 930 customers
                throw new Exception("Prenotazioni count doesn't match");
            }
        }
		public void TestVerificaId()
		{
            Reservation reservation = new Reservation();
            DataTable verifica_id;

            verifica_id = reservation.verifica_id(5);
        }
		public void TestVerifica_nome_cognome()
		{
            Reservation reservation = new Reservation();
            DataTable verifica_nome_cognome;

            verifica_nome_cognome = reservation.verifica_nome_cognome("Cladio","Rossi");
        }

    }
}